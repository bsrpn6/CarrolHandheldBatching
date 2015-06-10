Option Strict Off
Option Explicit On
Imports System.Data.SqlClient

Public Class SelectAsset
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    Private fromIndex As Integer

    Dim SelectedAssetValue As Object
    Dim SelectedAsset As String
    Dim SelectedBatchStatus As String
    Dim WorkOrderNumber As String
    Dim BatchID As Integer

    Public Sub New(ByVal PassedWorkOrderNumber As String, ByVal PassedBatchIDNumber As Integer)
        InitializeComponent()
        WorkOrderNumber = PassedWorkOrderNumber
        BatchID = PassedBatchIDNumber

    End Sub

    Private Sub SelectAsset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Assets()

        If WorkOrderNumber = 1 Then
            SelectBtn.Text = "Select"
        Else
            SelectBtn.Text = "Assign"
        End If

        CenterToScreen()
        Show()
        AssetTxtBox.Focus()

    End Sub

    Private Sub Load_Assets()
        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT [BatchUnit] FROM [BatchDB].[dbo].[bmBatchUnits]"

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim n As Integer

        'Concatenate the query result into a string.
        Do While myReader.Read()
            n = DataGridView1.Rows.Add()
            DataGridView1.Rows.Item(n).Cells(0).Value = myReader.GetString(0)
        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        DataGridView1.ClearSelection()
        AssetTxtBox.Text = Nothing
        AssetTxtBox.Focus()

    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        DataGridView1.Rows.Clear()
        Load_Assets()
    End Sub

    Private Sub SelectBtn_Click(sender As Object, e As EventArgs) Handles SelectBtn.Click
        If SelectedAsset <> Nothing And WorkOrderNumber <> 1 Then
            BatchAssignToUnit()
        ElseIf SelectedAsset <> Nothing And WorkOrderNumber = 1
            Dim oForm As SelectOrder
            oForm = New SelectOrder(SelectedAsset)
            oForm.Show()
            oForm = Nothing
        Else
            MessageBox.Show("Please make a selection.")
        End If

    End Sub

    Private Sub BatchAssignToUnit()
        Dim ReturnValue As Integer
        Dim RunningBatchID As Integer

        If WorkOrderNumber <> 1 Then
            ReturnValue = DatabaseConnection.BatchAssignToUnit(BatchID, SelectedAsset, 0)

            If ReturnValue > 0 Then
                RunningBatchID = DatabaseConnection.BatchAssignToUnit(SelectedAsset, 0)

                Dim oForm As BatchMain
                oForm = New BatchMain(WorkOrderNumber, RunningBatchID)
                oForm.Show()
                oForm = Nothing
                Close()
            End If

        End If

    End Sub

    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDown
        AssetTxtBox.Text = Nothing

        fromIndex = DataGridView1.HitTest(e.X, e.Y).RowIndex

        SelectedAssetValue = DataGridView1.Rows(fromIndex).Cells(0).Value

        If IsDBNull(SelectedAssetValue) Then
            SelectedAsset = "" ' blank if dbnull values
        Else
            SelectedAsset = CType(SelectedAssetValue, String)
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

    Private Sub AssetTxtBox_Enter(sender As Object, e As EventArgs) Handles AssetTxtBox.Enter
        DataGridView1.ClearSelection()
        SelectedAsset = Nothing
    End Sub

    Private Sub AssetTxtBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AssetTxtBox.KeyDown
        If e.KeyData = Keys.Return Then

            'Create a Connection object.
            myConn = DatabaseConnection.CreateSQLConnection()

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT [BatchUnit] FROM [BatchDB].[dbo].[bmBatchUnits] WHERE [BatchUnit] = '" & AssetTxtBox.Text & "'"

            'Open the connection.
            myConn.Open()

            myReader = myCmd.ExecuteReader()

            'Concatenate the query result into a string.
            Do While myReader.Read()
                SelectedAsset = myReader.GetValue(0)
            Loop

            myReader.Close()
            myConn.Close()

            If SelectedAsset <> "0" Then
                BatchAssignToUnit()
            Else
                MessageBox.Show("There was an error.")
            End If
        End If
    End Sub
End Class

