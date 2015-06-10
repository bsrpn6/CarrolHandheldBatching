Option Strict Off
Option Explicit On
Imports System.Data.SqlClient

Public Class StagingMain
    Inherits System.Windows.Forms.Form

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Friend WithEvents MyTimer As New Timer

    Private depConn As SqlConnection
    Private SQLDepCmd As SqlCommand

    Dim WorkOrderNumber As String
    Dim BatchID As Integer
    Dim BOMItem As String
    Dim BOMItemID As Integer
    Dim BOMStepHiHiDev As Single
    Dim BOMStepHiDev As Single
    Dim BOMStepLoDev As Single
    Dim BOMStepLoLoDev As Single
    Dim QtyTxtBoxHiLo As Boolean = False
    Dim QtyTxtBoxHiHiLoLo As Boolean = False
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
        SQLDepCmd.CommandText = "SELECT [BatchID], [BOMQtyStaged] FROM [dbo].[baBatchBOM] WHERE [BatchID] = " & BatchID


        ' creates a new dependency for the SqlCommand
        Dim dep As SqlDependency = New SqlDependency(SQLDepCmd)
        ' creates an event handler for the notification of data changes in the database
        AddHandler dep.OnChange, AddressOf dep_onchange

        depConn.Open()
        SQLDepCmd.ExecuteReader()
    End Sub

    Private Sub ResetForm()
        BOMItemTxtBox.Text = ""
        LotcodeTxtBox.Text = ""
        QtyTxtBox.Text = ""
        BOMItemID = vbNull
        BOMStepHiHiDev = vbNull
        BOMStepHiDev = vbNull
        BOMStepLoDev = vbNull
        BOMStepLoLoDev = vbNull
        QtyTxtBoxHiLo = False
        QtyTxtBoxHiHiLoLo = False
        Call Timer_Stop_Check()
        QtyTxtBox.BackColor = Color.FromArgb(224, 224, 224)
        BOMItemTxtBox.Focus()
    End Sub

    Private Sub BatchMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SqlDependency.Stop(DatabaseConnection.ReturnConnectionString)
    End Sub

    Private Sub BatchMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OpenORClosed = True
        ShowCompleteTglBtn.Text = "Show Completed"
        MyTimer.Interval = 500
        'Call load step sub to populate datagrid view.
        LoadBOM()

        'Ensures that the screen is centered on device
        CenterToScreen()
    End Sub

    Public Sub LoadBOM()

        InitializeSQLDependency()

        DataGridView1.Rows.Clear()

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        If OpenORClosed = True Then
            myCmd.CommandText = "SELECT [BOMItem], [BOMQtyTarget], [BOMUOM], [BOMQtyStaged] FROM [BatchDB].[dbo].[baBatchBOM] WHERE [BatchID] = " & BatchID & " AND [BOMQtyStaged] = 0 ORDER BY [BOMItem] ASC"
        Else
            myCmd.CommandText = "SELECT [BOMItem], [BOMQtyTarget], [BOMUOM], [BOMQtyStaged] FROM [BatchDB].[dbo].[baBatchBOM] WHERE [BatchID] = " & BatchID & " ORDER BY [BOMItem] ASC"
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
            DataGridView1.Rows.Item(n).Cells(0).Value = myReader.GetSqlString(0).Value & " - " & myReader.GetSqlSingle(1).Value & " " & myReader.GetSqlString(2).Value

            'Determine row color - if step completed, then green else white.
            If myReader.GetSqlSingle(3).Value = 0 Then
                DataGridView1.Rows(n).DefaultCellStyle.BackColor = Color.White
            Else
                DataGridView1.Rows(n).DefaultCellStyle.BackColor = Color.Green
            End If

        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        DataGridView1.ClearSelection()

    End Sub

    Private Sub ShowCompleteTglBtn_Click(sender As Object, e As EventArgs)
        If OpenORClosed = True Then
            ShowCompleteTglBtn.Text = "Show Open"
            OpenORClosed = False
        Else
            ShowCompleteTglBtn.Text = "Show Completed"
            OpenORClosed = True
        End If

        LoadBOM()
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
            DataGridView1.BeginInvoke(New MethodInvoker(AddressOf LoadBOM))
        Else
            LoadBOM()
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

    Private Sub ShowCompleteTglBtn_Click_1(sender As Object, e As EventArgs) Handles ShowCompleteTglBtn.Click
        If OpenORClosed = True Then
            ShowCompleteTglBtn.Text = "Show Open"
            OpenORClosed = False
        Else
            ShowCompleteTglBtn.Text = "Show Completed"
            OpenORClosed = True
        End If

        LoadBOM()
    End Sub

    Private Sub BOMItemTxtBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BOMItemTxtBox.KeyDown
        If e.KeyData = Keys.Return Then
            BOMItem = BOMItemTxtBox.Text
            LotcodeTxtBox.Focus()
        End If
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyTimer.Tick
        Static HighBit As Boolean

        'QtyTxtBox
        If HighBit And QtyTxtBoxHiHiLoLo Then
            QtyTxtBox.BackColor = Color.Red
        ElseIf HighBit And QtyTxtBoxHiLo Then
            QtyTxtBox.BackColor = Color.Yellow
        Else
            QtyTxtBox.BackColor = Color.FromArgb(224, 224, 224)
        End If

        HighBit = Not HighBit
    End Sub

    Private Sub Timer_Stop_Check()
        If QtyTxtBoxHiLo.Equals(False) And QtyTxtBoxHiHiLoLo.Equals(False) Then
            MyTimer.Stop()
        Else
            MyTimer.Start()
        End If

    End Sub

    Public Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Dim Qty As Double
        If BOMItemTxtBox.Text > "" And LotcodeTxtBox.Text > "" And QtyTxtBox.Text > "" And Double.TryParse(QtyTxtBox.Text, Qty) Then
            Dim ReturnValue As Integer
            ReturnValue = DatabaseConnection.BatchUpdateBOM(BatchID, BOMItemID, Qty, LotcodeTxtBox.Text, 0)

            If ReturnValue > 0 Then
                MessageBox.Show("Staging for this BOM is complete.")
                Close()
            ElseIf ReturnValue = 0 Then
                ResetForm()
            End If
        Else
            MessageBox.Show("Missing or incorrect information given.")
        End If


    End Sub

    Private Sub BOMItemTxtBox_Enter(sender As Object, e As EventArgs) Handles BOMItemTxtBox.Enter
        ResetForm()

    End Sub

    Private Sub BOMItemTxtBox_Leave(sender As Object, e As EventArgs) Handles BOMItemTxtBox.Leave
        If BOMItemTxtBox.Text <> "" Then
            Dim IsStaged As Boolean = vbNull
            Dim StagedQty As Double = vbNull
            Dim AssignedLotNumber As String = vbNull


            'Create a Connection object.
            myConn = DatabaseConnection.CreateSQLConnection()

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "Select [BOMQtyHiDev], [BOMQtyHiHiDev], [BOMQtyLoDev], [BOMQtyLoLoDev], [LotNumber], [BOMQtyStaged], [BOMItemID] from [BatchDB].[dbo].[baBatchBOM] WHERE [BatchID] = " & BatchID & "AND [BOMItem] = '" & BOMItem & "'"

            'Open the connection.
            myConn.Open()

            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()

                BOMStepHiHiDev = myReader.GetSqlSingle(0)
                BOMStepHiDev = myReader.GetSqlSingle(1)
                BOMStepLoDev = myReader.GetSqlSingle(2)
                BOMStepLoLoDev = myReader.GetSqlSingle(3)
                If Not IsDBNull(myReader.GetValue(4)) Then
                    AssignedLotNumber = myReader.GetSqlString(4)
                End If
                If Not IsDBNull(myReader.GetValue(5)) Then
                    StagedQty = myReader.GetSqlSingle(5)
                End If

                BOMItemID = myReader.GetInt32(6)

                If StagedQty > 0 Then
                    IsStaged = True
                Else
                    IsStaged = False
                End If
            Loop

            'Close the reader and the database connection.
            myReader.Close()
            myConn.Close()

            If BOMItemID <> 1 Then
                If IsStaged Then
                    LotcodeTxtBox.Text = AssignedLotNumber
                    QtyTxtBox.Text = StagedQty
                    QtyTxtBox.Focus()
                End If
            Else
                BOMItemTxtBox.Text = ""
                BOMItemTxtBox.Focus()
                MessageBox.Show("This item is not part of this BOM.")
            End If
        End If

    End Sub

    Private Sub LotcodeTxtBox_KeyDown(sender As Object, e As KeyEventArgs) Handles LotcodeTxtBox.KeyDown
        If e.KeyData = Keys.Return Then
            QtyTxtBox.Focus()
        End If
    End Sub

    Private Sub QtyTxtBox_TextChanged(sender As Object, e As EventArgs) Handles QtyTxtBox.TextChanged
        Dim QtyTxtBoxValue As Integer

        If Integer.TryParse(QtyTxtBox.Text, QtyTxtBoxValue) Then
            If QtyTxtBox.Text > BOMStepHiDev Or QtyTxtBox.Text < BOMStepLoDev Then
                If QtyTxtBox.Text > BOMStepHiHiDev Or QtyTxtBox.Text < BOMStepLoLoDev Then
                    QtyTxtBoxHiHiLoLo = True
                Else
                    QtyTxtBoxHiHiLoLo = False
                    QtyTxtBoxHiLo = True
                End If
                MyTimer.Start()
            Else
                QtyTxtBoxHiLo = False
                QtyTxtBoxHiHiLoLo = False
                QtyTxtBox.BackColor = Color.FromArgb(224, 224, 224)
                Call Timer_Stop_Check()

            End If
        End If
    End Sub
End Class