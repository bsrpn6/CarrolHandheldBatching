Option Strict Off
Option Explicit On
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class BatchMain
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Dim dep As SqlDependency
    Dim ConnectionString As String = DatabaseConnection.ReturnConnectionString

    Dim WorkOrderNumber As String
    Dim SelectedStepOrder As Integer
    Dim SelectedValue As Object
    Dim SelectedStepComplete As String
    Dim SelectedCompleteValue As Object
    Dim NextStepNumber As Integer
    Dim NextStepStatus

    Public Sub New(ByVal PassedWorkOrderNumber As String)
        InitializeComponent()
        WorkOrderNumber = PassedWorkOrderNumber

    End Sub

    Private Sub BatchMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SqlDependency.Stop(ConnectionString)
    End Sub

    Private Sub BatchMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT [Item], [Desc] FROM [BatchDB].[dbo].[WorkOrderHeader] WHERE [WorkOrderNumber] = '" & WorkOrderNumber & "'"

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        WorkOrderNumberTxtBox.Text = WorkOrderNumber

        'Fill in form's text boxes with data based off WorkOrderNumber passed by value.
        Do While myReader.Read()
            ItemTxtBox.Text = myReader.GetString(0)
            DescTxtBox.Text = myReader.GetString(1)
        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        'Call load step sub to populate datagrid view.
        Call Load_Steps()

        'Ensures that the screen is centered on device
        CenterToScreen()
    End Sub

    Private Sub Load_Steps()

        If Not DoesUserHavePermission() Then
            Return
        End If


        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT [StepNum], [WorkOrderItem], [Status] FROM [BatchDB].[dbo].[TestWorkOrderSteps] WHERE [WorkOrderNum] = " & WorkOrderNumber & " ORDER BY [StepNum] ASC"

        SqlDependency.Stop(ConnectionString)
        SqlDependency.Start(ConnectionString)

        ' creates a new dependency for the SqlCommand
        dep = DatabaseConnection.CreateSQLDependency(myCmd)

        ' creates an event handler for the notification of data changes in the database
        AddHandler dep.OnChange, AddressOf dep_onchange

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim n As Integer

        'Concatenate the query result into a string.
        Do While myReader.Read()
            'Add row to datagrid
            n = DataGridView1.Rows.Add()

            'Populate datagrid with two columns. Third column is hidden.
            DataGridView1.Rows.Item(n).Cells(0).Value = myReader.GetInt32(0)
            DataGridView1.Rows.Item(n).Cells(1).Value = myReader.GetString(1)
            DataGridView1.Rows.Item(n).Cells(2).Value = myReader.GetString(2)

            'Determine row color - if step completed, then green else white.
            If DataGridView1.Rows(n).Cells(2).Value = "OPEN" Then
                DataGridView1.Rows(n).DefaultCellStyle.BackColor = Color.White
            ElseIf DataGridView1.Rows(n).Cells(2).Value = "COMP" Then
                DataGridView1.Rows(n).DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)
            ElseIf DataGridView1.Rows(n).Cells(2).Value = "ACTV" Then
                DataGridView1.Rows(n).DefaultCellStyle.BackColor = Color.FromArgb(0, 192, 0)
            End If

            If NextStepNumber = Nothing And (myReader.GetString(2) = "OPEN" Or myReader.GetString(2) = "ACTV") Then
                NextStepNumber = myReader.GetInt32(0)
                NextStepStatus = myReader.GetString(2)
            End If
        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        DataGridView1.ClearSelection()
        SelectedStepOrder = Nothing
        SelectedStepComplete = Nothing

    End Sub

    Private Sub SelectBtn_Click(sender As Object, e As EventArgs) Handles SelectBtn.Click
        If SelectedStepOrder <> Nothing And SelectedStepComplete = "OPEN" Then
            Call LoadOpenWorkOrderStep(WorkOrderNumber, SelectedStepOrder)
        ElseIf SelectedStepOrder <> Nothing And SelectedStepComplete = "ACTV" Then
            Call LoadCloseWorkOrderStep(WorkOrderNumber, SelectedStepOrder)
        ElseIf SelectedStepOrder <> Nothing And SelectedStepComplete = "COMP" Then
            MessageBox.Show("This step is already complete.")
        Else
            MessageBox.Show("Please make a selection.")
        End If

    End Sub

    Private Sub LoadOpenWorkOrderStep(WorkOrderNumber As String, StepNumber As Integer)
        Dim oForm As WorkOrderStep
        oForm = New WorkOrderStep(WorkOrderNumber, StepNumber)
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub LoadCloseWorkOrderStep(WorkOrderNumber As String, StepNumber As Integer)
        Dim oForm As CloseWorkOrderStep
        oForm = New CloseWorkOrderStep(WorkOrderNumber, StepNumber)
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        SelectedValue = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        SelectedCompleteValue = DataGridView1.Rows(e.RowIndex).Cells(2).Value

        If IsDBNull(SelectedValue) Then
            SelectedStepOrder = "" ' blank if dbnull values
        Else
            SelectedStepOrder = CType(SelectedValue, String)
        End If

        If IsDBNull(SelectedCompleteValue) Then
            SelectedStepComplete = "" ' blank if dbnull values
        Else
            SelectedStepComplete = CType(SelectedCompleteValue, String)
        End If
    End Sub

    Private Sub HomeBtn_Click_1(sender As Object, e As EventArgs) Handles HomeBtn.Click
        If Not Application.OpenForms().OfType(Of Main).Any Then
            Dim oForm As Main
            oForm = New Main()
            oForm.Show()
            oForm = Nothing
        End If
        For i = System.Windows.Forms.Application.OpenForms.Count - 1 To 1 Step -1
            Dim form As Form = System.Windows.Forms.Application.OpenForms(i)
            If form.Name <> "Main" Then
                form.Close()
            End If

        Next i

    End Sub

    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        Me.Close()
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        Reset()
        Call Load_Steps()
    End Sub

    Private Sub Reset()
        DataGridView1.Rows.Clear()
        NextStepNumber = Nothing
    End Sub

    Private Sub ActiveStepBtn_Click(sender As Object, e As EventArgs) Handles ActiveStepBtn.Click
        If NextStepStatus = "OPEN" Then
            Call LoadOpenWorkOrderStep(WorkOrderNumber, NextStepNumber)
        ElseIf NextStepStatus = "ACTV" Then
            Call LoadCloseWorkOrderStep(WorkOrderNumber, NextStepNumber)
        Else
            MessageBox.Show("No step available.")
        End If

    End Sub

    Private Sub dep_onchange(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlNotificationEventArgs)

        ' this event is run asynchronously so you will need to invoke to run on the UI thread(if required)
        If Me.InvokeRequired Then

            DataGridView1.BeginInvoke(New MethodInvoker(AddressOf Load_Steps))

        Else

            Load_Steps()

        End If

        ' this will remove the event handler since the dependency is only for a single notification
        Dim dep As SqlDependency = DirectCast(sender, SqlDependency)
        RemoveHandler dep.onchange, AddressOf dep_onchange

    End Sub

    Private Function DoesUserHavePermission() As Boolean

        Try
            Dim clientPermission As SqlClientPermission = New SqlClientPermission(Security.Permissions.PermissionState.Unrestricted)

            ' this will throw an error if the user does not have the permissions
            clientPermission.Demand()

            Return True

        Catch ex As Exception

            Return False

        End Try

        Return True

    End Function



End Class