Option Strict Off
Option Explicit On
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class CloseWorkOrderStep
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    Dim WorkOrderNumber As String
    Dim StepNumber As Integer


    Public Sub New(ByVal PassedWorkOrderNumber As String, ByVal PassedStepNumber As String)
        InitializeComponent()
        WorkOrderNumber = PassedWorkOrderNumber
        StepNumber = PassedStepNumber
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        WorkOrderNumberTxtBox.Text = WorkOrderNumber & " - " & StepNumber
        CenterToScreen()
    End Sub

    Private Sub CloseStep()
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "UPDATE [BatchDB].[dbo].[TestWorkOrderSteps] SET [Status] = 'COMP 'WHERE [WorkOrderNum] = " & WorkOrderNumber & "AND [StepNum] = " & StepNumber

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub YesBtn_Click(sender As Object, e As EventArgs) Handles YesBtn.Click
        CloseStep()
        Close()
    End Sub

    Private Sub NoBtn_Click(sender As Object, e As EventArgs) Handles NoBtn.Click
        Close()
    End Sub
End Class