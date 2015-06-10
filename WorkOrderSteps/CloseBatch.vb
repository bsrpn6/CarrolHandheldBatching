Option Strict Off
Option Explicit On
Imports System.Data.SqlClient

Public Class CloseBatch
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Friend WithEvents MyTimer As New Timer

    Dim WorkOrderNumber As String
    Dim BatchID As Integer
    Dim RecipeItem As String
    Dim RecipeName As String
    Dim BatchSize As Single
    Dim BatchSizeUOM As String
    Dim BatchStartDate As Date
    Dim BatchEndDate As Date

    Public Sub New(ByVal PassedWorkOrderNumber As String, ByVal PassedBatchID As Integer)
        InitializeComponent()
        WorkOrderNumber = PassedWorkOrderNumber
        BatchID = PassedBatchID
    End Sub

    Private Sub CloseBatch_Load(sender As Object, e As EventArgs) Handles Me.Load
        MyTimer.Interval = 500
        WorkOrderNumberTxtBox.Text = WorkOrderNumber

        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT [RecipeItem], [RecipeName], [BatchSize], [BatchSizeUOM], [BatchStartDate], [BatchEndDate] FROM [BatchDB].[dbo].[baBatches] WHERE [BatchID] = " & BatchID

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Do While myReader.Read
            RecipeItem = myReader.GetString(0)
            RecipeName = myReader.GetString(1)
            BatchSize = myReader.GetSqlSingle(2)
            BatchSizeUOM = myReader.GetString(3)
            BatchStartDate = myReader.GetDateTime(4)
            BatchEndDate = myReader.GetDateTime(5)
        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        WorkOrderNumberTxtBox.Text = WorkOrderNumber
        RecipeTxtBox.Text = RecipeItem
        RecipeDescTxtBox.Text = RecipeName
        BatchSizeTxtBox.Text = BatchSize & " " & BatchSizeUOM
        BatchStartTxtBox.Text = BatchStartDate.ToString("MM/dd HHH:mm")
        BatchStopTxtBox.Text = BatchEndDate.ToString("MM/dd HHH:mm")

        CenterToScreen()
    End Sub

    Private Sub YOKBtn_Click(sender As Object, e As EventArgs) Handles OKBtn.Click
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

End Class