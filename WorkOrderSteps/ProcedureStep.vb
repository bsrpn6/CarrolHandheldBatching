Option Strict Off
Option Explicit On
Imports System.Data.SqlClient

Public Class ProcedureStep

    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    Dim WorkOrderNumber As String
    Dim StepNumber As Integer
    Dim BatchStepID As Integer
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
        myCmd.CommandText = "SELECT [BatchStepID], [StepDispType], [ParamTarget], [ParamUOM], [StepInstructions] FROM [BatchDB].[dbo].[baBatchSteps] WHERE [BatchID] = " & BatchID & "AND [StepNum] = " & StepNumber

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()


        'Concatenate the query result into a string.
        Do While myReader.Read()
            BatchStepID = myReader.GetSqlInt32(0)
            StepType = myReader.GetString(1)

            If Not IsDBNull(myReader.GetValue(2)) Then
                StepItemTarget = myReader.GetSqlSingle(2)
            Else
                StepItemTxtBox.Visible = False
            End If

            If Not IsDBNull(myReader.GetValue(3)) Then
                ParamUOM = myReader.GetString(3)
            End If

            If Not IsDBNull(myReader.GetValue(4)) Then
                StepInstructions = myReader.GetString(4)
            Else
                InstructionsTxtBox.Visible = False
            End If
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

        Dim ReturnValue As Integer

        ReturnValue = DatabaseConnection.BatchUpdateStep(BatchID, BatchStepID, "ACTV", 0)

        If ReturnValue = "0" Then
            Dim oForm As CloseWorkOrderStep
            oForm = New CloseWorkOrderStep(WorkOrderNumber, BatchID, StepNumber)
            oForm.Show()
            oForm = Nothing

            Close()
        End If

    End Sub

    Private Sub SkipStepBtn_Click(sender As Object, e As EventArgs) Handles SkipStepBtn.Click
        If MessageBox.Show("Are you sure you want to skip this step?", "Confirm", MessageBoxButtons.YesNo) Then
            Dim ReturnValue As Integer

            ReturnValue = DatabaseConnection.BatchUpdateStep(BatchID, BatchStepID, "SKIP", 0)

            If ReturnValue = "0" Then
                Close()
            End If

        End If
    End Sub
End Class