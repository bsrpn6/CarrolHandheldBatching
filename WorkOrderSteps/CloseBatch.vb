Option Strict Off
Option Explicit On
Imports System
Imports System.Data
Imports System.Data.Common
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
        myCmd.CommandText = "SELECT[RecipeItem], [RecipeName], [BatchSize], [BatchSizeUOM], [BatchStartDate] FROM [BatchDB].[dbo].[baBatches] WHERE [BatchID] = " & BatchID

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Do While myReader.Read
            RecipeItem = myReader.GetString(0)
            RecipeName = myReader.GetString(1)
            BatchSize = myReader.GetSqlSingle(2)
            BatchSizeUOM = myReader.GetString(3)
            BatchStartDate = myReader.GetDateTime(4)

        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        WorkOrderNumberTxtBox.Text = WorkOrderNumber
        RecipeTxtBox.Text = RecipeItem
        RecipeDescTxtBox.Text = RecipeName
        BatchSizeTxtBox.Text = BatchSize & " " & BatchSizeUOM
        BatchStartTxtBox.Text = BatchStartDate.ToString("MM/dd HHH:mm")

        CenterToScreen()
    End Sub

    Private Sub YesBtn_Click(sender As Object, e As EventArgs) Handles YesBtn.Click
        CloseBatch()
        Close()
    End Sub

    Private Sub CloseBatch()
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "UPDATE [BatchDB].[dbo].[baBatches] SET [BatchStatus] = 'COMP', [BatchEndDate] = '" & Date.Now.ToString("yyyy-MM-dd HHH:mm:ss") & "'  WHERE [BatchID] = " & BatchID

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub NoBtn_Click(sender As Object, e As EventArgs) Handles NoBtn.Click
        Close()
    End Sub
End Class