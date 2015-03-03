Option Strict Off
Option Explicit On
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class ReopenStep

    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    Dim WorkOrderNumber As String
    Dim StepNumber As Integer
    Dim BatchID As Integer

    Dim StepType As String
    Dim StepItemDesc As String
    Dim StepItemTarget As Single
    Dim ParamUOM As String

    Public Sub New(ByVal PassedWorkOrderNumber As String, ByVal PassedStepNumber As String, ByVal PassedBatchID As Integer)
        InitializeComponent()
        WorkOrderNumber = PassedWorkOrderNumber
        StepNumber = PassedStepNumber
        BatchID = PassedBatchID
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT [StepDispType], [ParamTarget], [ParamUOM] FROM [BatchDB].[dbo].[baBatchSteps] WHERE [BatchID] = " & BatchID & "AND [StepNum] = " & StepNumber

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()


        'Concatenate the query result into a string.
        Do While myReader.Read()
            StepType = myReader.GetString(0)
            StepItemTarget = myReader.GetSqlSingle(1)
            ParamUOM = myReader.GetString(2)
        Loop

        StepNumberTxtBox.Text = WorkOrderNumber & " - " & StepNumber
        StepItemTxtBox.Text = StepType & " " & StepItemTarget & " " & ParamUOM

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        CenterToScreen()
        Show()

    End Sub

    Private Sub YesBtn_Click(sender As Object, e As EventArgs) Handles YesBtn.Click
        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "UPDATE [BatchDB].[dbo].[baBatchSteps] SET [StepStatus] = 'OPEN', [StepStartDate] = NULL, [StepEndDate] = NULL WHERE [BatchID] = " & BatchID & "AND [StepNum] = " & StepNumber

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()
        Close()
    End Sub

    Private Sub NoBtn_Click(sender As Object, e As EventArgs) Handles NoBtn.Click
        Close()
    End Sub
End Class