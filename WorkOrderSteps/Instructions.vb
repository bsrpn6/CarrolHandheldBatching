Option Strict Off
Option Explicit On
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class Instructions
    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Public WorkOrderNumber As String

    Dim WorkOrderInstructions As String

    Public Sub New(ByVal PassedWorkOrderNumber As String)
        InitializeComponent()
        WorkOrderNumber = PassedWorkOrderNumber

    End Sub

    Private Sub HelpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT [Instructions] FROM [BatchDB].[dbo].[TestWorkOrderSteps] WHERE [WorkOrderNum] = " & WorkOrderNumber

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        'Concatenate the query result into a string.
        Do While myReader.Read()
            WorkOrderInstructions = myReader.GetString(0)

        Loop

        'WorkOrderNumberTxtBox.Text = WorkOrderNumber
        InstructionsTxtBox.Text = WorkOrderInstructions


        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        CenterToScreen()
    End Sub

    Private Sub ReturnBtn_Click_1(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        Me.Close()
    End Sub
End Class