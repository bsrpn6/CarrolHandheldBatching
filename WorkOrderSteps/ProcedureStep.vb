Option Strict Off
Option Explicit On
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class ProcedureStep

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
    Dim StepInstructions As String


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
        myCmd.CommandText = "SELECT [StepDispType], [ParamTarget], [ParamUOM], [StepInstructions] FROM [BatchDB].[dbo].[baBatchSteps] WHERE [BatchID] = " & BatchID & "AND [StepNum] = " & StepNumber

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()


        'Concatenate the query result into a string.
        Do While myReader.Read()
            StepType = myReader.GetString(0)
            StepItemTarget = myReader.GetSqlSingle(1)
            ParamUOM = myReader.GetString(2)
            StepInstructions = myReader.GetString(3)
        Loop

        StepNumberTxtBox.Text = WorkOrderNumber & " - " & StepNumber
        StepItemTxtBox.Text = StepType & " " & StepItemTarget & " " & ParamUOM
        InstructionsTxtBox.Text = StepInstructions

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        CenterToScreen()
        Show()

    End Sub
    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
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

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "UPDATE [BatchDB].[dbo].[baBatchSteps] SET [StepStatus] = 'ACTV', [StepStartDate] = '" & Date.Now.ToString("yyyy-MM-dd HHH:mm:ss") & "' WHERE [BatchID] = " & BatchID & "AND [StepNum] = " & StepNumber

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        Dim oForm As CloseWorkOrderStep
        oForm = New CloseWorkOrderStep(WorkOrderNumber, BatchID, StepNumber)
        oForm.Show()
        oForm = Nothing

        Close()
    End Sub

    Private Sub SkipStepBtn_Click(sender As Object, e As EventArgs) Handles SkipStepBtn.Click
        If MessageBox.Show("Are you sure you want to skip this step?", "Confirm", MessageBoxButtons.YesNo) Then
            'Create a Connection object.
            myConn = DatabaseConnection.CreateSQLConnection()

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "UPDATE [BatchDB].[dbo].[baBatchSteps] SET [StepStatus] = 'SKIP', [StepStartDate] = '" & Date.Now.ToString("yyyy-MM-dd HHH:mm:ss") & "', [StepEndDate] = '" & Date.Now.ToString("yyyy-MM-dd HHH:mm:ss") & "' WHERE [BatchID] = " & BatchID & "AND [StepNum] = " & StepNumber

            'Open the connection.
            myConn.Open()

            myReader = myCmd.ExecuteReader()

            'Close the reader and the database connection.
            myReader.Close()
            myConn.Close()
            Close()

        End If
    End Sub
End Class