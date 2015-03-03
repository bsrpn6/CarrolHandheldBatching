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

    Dim WorkOrderNumber As String
    Dim BatchID As Integer
    Dim StepNum As Integer
    Dim WorkOrderInstructions As String

    Public Sub New(ByVal PassedWorkOrderNumber As String, ByVal PassedBatchID As Integer, ByVal PassedStepNumber As Integer)
        InitializeComponent()
        WorkOrderNumber = PassedWorkOrderNumber
        BatchID = PassedBatchID
        StepNum = PassedStepNumber
    End Sub

    Private Sub HelpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT [StepInstructions] FROM [BatchDB].[dbo].[baBatchSteps] WHERE [BatchID] = " & BatchID & " AND [StepNum] = " & StepNum

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

    Private Sub SkipStepBtn_Click(sender As Object, e As EventArgs) Handles SkipStepBtn.Click
        If MessageBox.Show("Are you sure you want to skip this step?", "Confirm", MessageBoxButtons.YesNo) Then
            'Create a Connection object.
            myConn = DatabaseConnection.CreateSQLConnection()

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "UPDATE [BatchDB].[dbo].[baBatchSteps] SET [StepStatus] = 'SKIP', [StepStartDate] = '" & Date.Now.ToString("yyyy-MM-dd HHH:mm:ss") & "', [StepEndDate] = '" & Date.Now.ToString("yyyy-MM-dd HHH:mm:ss") & "' WHERE [BatchID] = " & BatchID & "AND [StepNum] = " & StepNum

            'Open the connection.
            myConn.Open()

            myReader = myCmd.ExecuteReader()

            'Close the reader and the database connection.
            myReader.Close()
            myConn.Close()
            Close()

            If Application.OpenForms().OfType(Of WorkOrderStep).Any Then
                WorkOrderStep.ActiveForm.Close()
            End If
        End If
    End Sub
End Class