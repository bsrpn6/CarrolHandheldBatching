Option Strict Off
Option Explicit On
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class SelectOrder
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    Dim SelectedWorkOrder As String
    Dim SelectedWorkOrderValue As Object
    Dim SelectedBatchID As Integer

    Private Sub SelectOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Load_Orders()
        CenterToScreen()
        Show()
        WorkOrderTxtBox.Focus()

    End Sub

    Private Sub Load_Orders()
        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT [WorkOrder], [BatchID] FROM [BatchDB].[dbo].[baBatches] WHERE [BatchStatus] = 'OPEN'"

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim n As Integer

        'Concatenate the query result into a string.
        Do While myReader.Read()
            n = DataGridView1.Rows.Add()
            DataGridView1.Rows.Item(n).Cells(0).Value = myReader.GetString(0)
            DataGridView1.Rows.Item(n).Cells(1).Value = myReader.GetInt32(1)
        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        DataGridView1.ClearSelection()
        SelectedWorkOrder = Nothing
        WorkOrderTxtBox.Text = Nothing
        WorkOrderTxtBox.Focus()

    End Sub

    Private Sub RetrieveBatchOrderID()
        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT [BatchID] FROM [BatchDB].[dbo].[baBatches] WHERE [WorkOrder] = '" & SelectedWorkOrder & "'"

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        'Concatenate the query result into a string.
        Do While myReader.Read()
            SelectedBatchID = myReader.GetInt32(0)
        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        DataGridView1.Rows.Clear()
        Call Load_Orders()
    End Sub

    Private Sub SelectBtn_Click(sender As Object, e As EventArgs) Handles SelectBtn.Click
        If SelectedWorkOrder <> Nothing Then
            Call RetrieveBatchOrderID()
            Call LoadWorkOrder()
        Else
            MessageBox.Show("Please make a selection.")
        End If

    End Sub

    Private Sub LoadWorkOrder()
        Dim oForm As BatchMain
        oForm = New BatchMain(SelectedWorkOrder, SelectedBatchID)
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        WorkOrderTxtBox.Text = Nothing

        SelectedWorkOrderValue = DataGridView1.Rows(e.RowIndex).Cells(0).Value

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

    Private Sub WorkOrderTxtBox_KeyDown(sender As Object, e As KeyEventArgs) Handles WorkOrderTxtBox.KeyDown
        If e.KeyData = Keys.Return Then
            SelectedWorkOrder = WorkOrderTxtBox.Text
            Call RetrieveBatchOrderID()
            Call LoadWorkOrder()
        End If
    End Sub
End Class

