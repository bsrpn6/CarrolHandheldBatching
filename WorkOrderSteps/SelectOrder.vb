Option Strict Off
Option Explicit On
Imports System.Data.SqlClient

Public Class SelectOrder
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    Private fromIndex As Integer

    Private depConn As SqlConnection
    Private SQLDepCmd As SqlCommand

    Dim SelectedWorkOrder As String
    Dim SelectedWorkOrderValue As Object
    Dim SelectedBatchID As Integer
    Dim SelectedBatchStatus As String

    Dim Asset As String

    Public Sub New(ByVal PassedAsset As String)
        InitializeComponent()
        Asset = PassedAsset

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
        SQLDepCmd.CommandText = "SELECT [BatchID], [BatchStatus] FROM [dbo].[baBatches] WHERE [BatchStatus] <> 'DONE'"


        ' creates a new dependency for the SqlCommand
        Dim dep As SqlDependency = New SqlDependency(SQLDepCmd)
        ' creates an event handler for the notification of data changes in the database
        AddHandler dep.OnChange, AddressOf dep_onchange

        depConn.Open()
        SQLDepCmd.ExecuteReader()
    End Sub

    Private Sub SelectOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrders()

        If Asset = "1" Then
            SelectBtn.Text = "Select"
        Else
            SelectBtn.Text = "Assign"
        End If
        CenterToScreen()
        Show()
        WorkOrderTxtBox.Focus()

    End Sub

    Private Sub LoadOrders()

        InitializeSQLDependency()

        DataGridView1.Rows.Clear()

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT [WorkOrder], [BatchID], [BatchStatus] FROM [BatchDB].[dbo].[baBatches] WHERE [BatchStatus] NOT IN ('DONE', 'ABRT')"

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim n As Integer

        'Concatenate the query result into a string.
        Do While myReader.Read()
            n = DataGridView1.Rows.Add()
            DataGridView1.Rows.Item(n).Cells(0).Value = myReader.GetString(0)
            DataGridView1.Rows.Item(n).Cells(1).Value = myReader.GetInt32(1)

            'Determine row color - if step completed, then green else white.
            If myReader.GetString(2) = "OPEN" Then
                DataGridView1.Rows(n).DefaultCellStyle.BackColor = Color.White
            ElseIf myReader.GetString(2) = "ACTV" Then
                DataGridView1.Rows(n).DefaultCellStyle.BackColor = Color.FromArgb(0, 192, 0)
            Else
                DataGridView1.Rows(n).DefaultCellStyle.BackColor = Color.Yellow

            End If
        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        DataGridView1.ClearSelection()
        SelectedWorkOrder = Nothing
        WorkOrderTxtBox.Text = Nothing
        WorkOrderTxtBox.Focus()

    End Sub

    Private Sub RetrieveBatchOrderIDandStatus()
        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT [BatchID], [BatchStatus] FROM [BatchDB].[dbo].[baBatches] WHERE [WorkOrder] = '" & SelectedWorkOrder & "'"

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        'Concatenate the query result into a string.
        Do While myReader.Read()
            SelectedBatchID = myReader.GetInt32(0)
            SelectedBatchStatus = myReader.GetString(1)
        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        DataGridView1.Rows.Clear()
        LoadOrders()
    End Sub

    Private Sub SelectBtn_Click(sender As Object, e As EventArgs) Handles SelectBtn.Click
        If SelectedWorkOrder <> Nothing Then
            LoadSelectedWorkOrder()
        Else
            MessageBox.Show("Please make a selection.")
        End If

    End Sub

    Private Sub WorkOrderTxtBox_KeyDown(sender As Object, e As KeyEventArgs) Handles WorkOrderTxtBox.KeyDown
        If e.KeyData = Keys.Return Then
            SelectedWorkOrder = WorkOrderTxtBox.Text
            LoadSelectedWorkOrder()
        End If
    End Sub

    Private Sub LoadSelectedWorkOrder()
        RetrieveBatchOrderIDandStatus()
        If Asset <> "1" Then
            If SelectedBatchID <> 0 And SelectedBatchStatus = "STDN" Then
                BatchAssignToUnit()
            Else
                MessageBox.Show("This batch is not ready to be assigned.")
            End If
        Else
            If SelectedBatchID <> 0 Then
                LoadWorkOrder()
            Else
                MessageBox.Show("There was an error.")
            End If
        End If
    End Sub

    Private Sub BatchAssignToUnit()
        Dim ReturnValue As Integer
        Dim RunningBatchID As Integer

        If SelectedWorkOrder <> 1 Then
            ReturnValue = DatabaseConnection.BatchAssignToUnit(Asset, 0, SelectedBatchID)

            If ReturnValue > 0 Then
                RunningBatchID = DatabaseConnection.BatchAssignToUnit(Asset, 0)

                Dim oForm As BatchMain
                oForm = New BatchMain(SelectedWorkOrder, RunningBatchID)
                oForm.Show()
                oForm = Nothing
                Close()
            End If

        End If

    End Sub

    Private Sub LoadWorkOrder()

        Select Case SelectedBatchStatus
            Case "OPEN", "STGN" ' Needs staged/preweighed
                Dim oForm As StagingMain
                oForm = New StagingMain(SelectedWorkOrder, SelectedBatchID)
                oForm.Show()
                oForm = Nothing
                Close()

            Case "STDN" ' Staging Complete
                Dim oForm As SelectAsset
                oForm = New SelectAsset(SelectedWorkOrder, SelectedBatchID)
                oForm.Show()
                oForm = Nothing
                Close()

            Case "ACTV" ' Batch Active
                Dim oForm As BatchMain
                oForm = New BatchMain(SelectedWorkOrder, SelectedBatchID)
                oForm.Show()
                oForm = Nothing
                Close()

            Case "DONE" ' Batch Done
                MessageBox.Show("This batch is already complete.")

            Case "ABRT" ' Batch Aborted
                MessageBox.Show("This batch has been aborted.")

            Case Else
                MessageBox.Show("There was an error.")

        End Select

    End Sub

    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDown
        WorkOrderTxtBox.Text = Nothing

        fromIndex = DataGridView1.HitTest(e.X, e.Y).RowIndex

        SelectedWorkOrderValue = DataGridView1.Rows(fromIndex).Cells(0).Value

        If IsDBNull(SelectedWorkOrderValue) Then
            SelectedWorkOrder = "" ' blank if dbnull values
        Else
            SelectedWorkOrder = CType(SelectedWorkOrderValue, String)
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

    Private Sub ReturnBtn_Click_1(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        Me.Close()
    End Sub

    Private Sub WorkOrderTxtBox_Enter(sender As Object, e As EventArgs) Handles WorkOrderTxtBox.Enter
        DataGridView1.ClearSelection()
        SelectedWorkOrder = Nothing
    End Sub

    Private Sub dep_onchange(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlNotificationEventArgs)

        ' this event is run asynchronously so you will need to invoke to run on the UI thread(if required)
        If Me.InvokeRequired Then
            DataGridView1.BeginInvoke(New MethodInvoker(AddressOf LoadOrders))
        Else
            LoadOrders()
        End If

        ' this will remove the event handler since the dependency is only for a single notification
        Dim dep As SqlDependency = DirectCast(sender, SqlDependency)
        RemoveHandler dep.OnChange, AddressOf dep_onchange

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

