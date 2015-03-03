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

    Private depConn As SqlConnection
    Private SQLDepCmd As SqlCommand


    Dim WorkOrderNumber As String
    Dim BatchID As Integer
    Dim SelectedStepOrder As Integer
    Dim SelectedValue As Object
    Dim SelectedStepComplete As String
    Dim SelectedCompleteValue As Object
    Dim SelectedStepTypeValue As Object
    Dim SelectedStepType As String
    Dim NextStepNumber As Integer
    Dim NextStepStatus As String
    Dim NextStepType As String
    Dim OpenORClosed As Boolean

    Public Sub New(ByVal PassedWorkOrderNumber As String, ByVal PassedBatchIDNumber As Integer)
        InitializeComponent()
        WorkOrderNumber = PassedWorkOrderNumber
        BatchID = PassedBatchIDNumber

    End Sub

    Private Sub InitializeSQLDependency()
        If Not DoesUserHavePermission() Then
            Return
        End If

        depConn = DatabaseConnection.CreateSQLConnection

        ' You must stop the dependency before starting a new one.
        ' You must start the dependency when creating a new one.
        SqlDependency.Stop(DatabaseConnection.ReturnConnectionString)
        SqlDependency.Start(DatabaseConnection.ReturnConnectionString)

        SQLDepCmd = depConn.CreateCommand
        SQLDepCmd.CommandText = "SELECT [BatchID], [StepStatus] FROM [dbo].[baBatchSteps] WHERE [BatchID] = " & BatchID


        ' creates a new dependency for the SqlCommand
        Dim dep As SqlDependency = New SqlDependency(SQLDepCmd)
        ' creates an event handler for the notification of data changes in the database
        AddHandler dep.OnChange, AddressOf dep_onchange

        depConn.Open()
        SQLDepCmd.ExecuteReader()
    End Sub

    Private Sub BatchMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SqlDependency.Stop(DatabaseConnection.ReturnConnectionString)
    End Sub

    Private Sub BatchMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT [RecipeItem], [RecipeName] FROM [BatchDB].[dbo].[baBatches] WHERE [WorkOrder] = '" & WorkOrderNumber & "'"

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

        OpenORClosed = True
        ShowCompleteTglBtn.Text = "Show Completed"

        'Call load step sub to populate datagrid view.
        LoadSteps()

        'Ensures that the screen is centered on device
        CenterToScreen()
    End Sub

    Public Sub LoadSteps()

        InitializeSQLDependency()

        DataGridView1.Rows.Clear()
        NextStepNumber = Nothing

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        If OpenORClosed = True Then
            myCmd.CommandText = "SELECT [StepNum], [StepList], [StepStatus], [StepType] FROM [BatchDB].[dbo].[scnBatchStepList] WHERE [BatchID] = " & BatchID & " AND [StepStatus] <> 'COMP' ORDER BY [StepNum] ASC"
        Else
            myCmd.CommandText = "SELECT [StepNum], [StepList], [StepStatus], [StepType] FROM [BatchDB].[dbo].[scnBatchStepList] WHERE [BatchID] = " & BatchID & " ORDER BY [StepNum] ASC"
        End If

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
            DataGridView1.Rows.Item(n).Cells(3).Value = myReader.GetString(3)

            'Determine row color - if step completed, then green else white.
            If DataGridView1.Rows(n).Cells(2).Value = "OPEN" Then
                DataGridView1.Rows(n).DefaultCellStyle.BackColor = Color.White
            ElseIf DataGridView1.Rows(n).Cells(2).Value = "COMP" Then
                DataGridView1.Rows(n).DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)
            ElseIf DataGridView1.Rows(n).Cells(2).Value = "ACTV" Then
                DataGridView1.Rows(n).DefaultCellStyle.BackColor = Color.FromArgb(0, 192, 0)
            Else
                DataGridView1.Rows(n).DefaultCellStyle.BackColor = Color.Yellow
            End If

            If NextStepNumber = Nothing And (myReader.GetString(2) = "OPEN" Or myReader.GetString(2) = "ACTV") Then
                NextStepNumber = myReader.GetInt32(0)
                NextStepStatus = myReader.GetString(2)
                NextStepType = myReader.GetString(3)
            End If
        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        DataGridView1.ClearSelection()
        SelectedStepOrder = Nothing
        SelectedStepComplete = Nothing

    End Sub

    Private Sub LoadClosedWorkOrderStep(WorkOrderNumber As String, StepNumber As Integer, StepType As String)
        Select Case StepType
            Case "ADD "
                Dim oForm As ClosedWorkOrderStep
                oForm = New ClosedWorkOrderStep(WorkOrderNumber, StepNumber, BatchID)
                oForm.Show()
                oForm = Nothing
            Case "HEAT"
                Dim oForm As ClosedProcedureStep
                oForm = New ClosedProcedureStep(WorkOrderNumber, StepNumber, BatchID)
                oForm.Show()
                oForm = Nothing
            Case Else
                MessageBox.Show("ERROR")
        End Select
    End Sub

    Private Sub LoadOpenWorkOrderStep(WorkOrderNumber As String, StepNumber As Integer, StepType As String)
        'Open appropriate form based off of step type. If step is a procedureal step, then open procedure step type form. If step is a component change, then open work order step form.
        Select Case StepType
            Case "ADD "
                Dim oForm As WorkOrderStep
                oForm = New WorkOrderStep(WorkOrderNumber, StepNumber, BatchID)
                oForm.Show()
                oForm = Nothing
            Case "HEAT"
                Dim oForm As ProcedureStep
                oForm = New ProcedureStep(WorkOrderNumber, StepNumber, BatchID)
                oForm.Show()
                oForm = Nothing
            Case "QA  "
                ' MessageBox.Show("NEED TO CREATE SCREEN.")
            Case "MIX "
                Dim oForm As ProcedureStep
                oForm = New ProcedureStep(WorkOrderNumber, StepNumber, BatchID)
                oForm.Show()
                oForm = Nothing
            Case "CLOS"
                Dim oForm As CloseBatch
                oForm = New CloseBatch(WorkOrderNumber, BatchID)
                oForm.Show()
                oForm = Nothing
        End Select
    End Sub

    Private Sub LoadCloseWorkOrderStep(WorkOrderNumber As String, BatchID As Integer, StepNumber As Integer, StepType As String)
        Dim oForm As CloseWorkOrderStep
        oForm = New CloseWorkOrderStep(WorkOrderNumber, BatchID, StepNumber)
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        SelectedValue = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        SelectedCompleteValue = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        SelectedStepTypeValue = DataGridView1.Rows(e.RowIndex).Cells(3).Value

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

        If IsDBNull(SelectedStepTypeValue) Then
            SelectedStepType = "" ' blank if dbnull values
        Else
            SelectedStepType = CType(SelectedStepTypeValue, String)
        End If
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        ShowCompleteTglBtn.Text = "Show Completed"
        OpenORClosed = True

        Call LoadSteps()
    End Sub

    Private Sub ActiveStepBtn_Click(sender As Object, e As EventArgs) Handles ActiveStepBtn.Click
        If NextStepStatus = "OPEN" Then
            Call LoadOpenWorkOrderStep(WorkOrderNumber, NextStepNumber, NextStepType)
        ElseIf NextStepStatus = "ACTV" Then
            Call LoadCloseWorkOrderStep(WorkOrderNumber, BatchID, NextStepNumber, NextStepType)
        Else
            MessageBox.Show("No step available.")
        End If

    End Sub

    Private Sub ShowCompleteTglBtn_Click(sender As Object, e As EventArgs) Handles ShowCompleteTglBtn.Click
        If OpenORClosed = True Then
            ShowCompleteTglBtn.Text = "Show Open"
            OpenORClosed = False
        Else
            ShowCompleteTglBtn.Text = "Show Completed"
            OpenORClosed = True
        End If

        LoadSteps()
    End Sub

    Private Sub SelectBtn_Click(sender As Object, e As EventArgs) Handles SelectBtn.Click
        If SelectedStepOrder <> Nothing Then
            Select Case SelectedStepComplete
                Case "OPEN"
                    LoadOpenWorkOrderStep(WorkOrderNumber, SelectedStepOrder, SelectedStepType)
                Case "ACTV"
                    LoadCloseWorkOrderStep(WorkOrderNumber, BatchID, SelectedStepOrder, SelectedStepType)
                Case "COMP"
                    Call LoadClosedWorkOrderStep(WorkOrderNumber, SelectedStepOrder, SelectedStepType)
                Case "SKIP"
                    Dim oForm As ReopenStep
                    oForm = New ReopenStep(WorkOrderNumber, SelectedStepOrder, BatchID)
                    oForm.Show()
                    oForm = Nothing
                Case Else
                    MessageBox.Show("Please make a selection.")
            End Select
        Else
            MessageBox.Show("Please make a selection.")
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

    Private Sub dep_onchange(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlNotificationEventArgs)

        ' this event is run asynchronously so you will need to invoke to run on the UI thread(if required)
        If Me.InvokeRequired Then
            DataGridView1.BeginInvoke(New MethodInvoker(AddressOf LoadSteps))
        Else
            LoadSteps()
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