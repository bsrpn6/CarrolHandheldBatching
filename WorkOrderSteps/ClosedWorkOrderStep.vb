Option Strict Off
Option Explicit On
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class ClosedWorkOrderStep
    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    Dim WorkOrderNumber As String
    Dim StepNumber As Integer
    Dim BatchID As Integer

    Dim StepType As String
    Dim StepItem As String
    Dim StepItemDesc As String
    Dim StepItemTarget As Single
    Dim StepItemActual As Single
    Dim ParamUOM As String
    Dim StepStatus As String
    Dim StartStepDate As Date
    Dim EndStepDate As Date
    Dim LotNumber As String
    Dim StepTimeSpan As Long
    Dim Span As TimeSpan


    Public Sub New(ByVal PassedWorkOrderNumber As String, ByVal PassedStepNumber As String, ByVal PassedBatchID As Integer)
        InitializeComponent()
        WorkOrderNumber = PassedWorkOrderNumber
        StepNumber = PassedStepNumber
        BatchID = PassedBatchID
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT [StepDispType], [StepItem], [StepItemDesc], [ParamTarget], [ParamUOM], [StepStatus], [ParamActual], [StepStartDate], [StepEndDate], [LotNumber] FROM [BatchDB].[dbo].[baBatchSteps] WHERE [BatchID] = " & BatchID & "AND [StepNum] = " & StepNumber

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()


        'Concatenate the query result into a string.
        Do While myReader.Read()
            StepType = myReader.GetString(0)
            StepItem = myReader.GetString(1)
            StepItemDesc = myReader.GetString(2)
            StepItemTarget = myReader.GetSqlSingle(3)
            ParamUOM = myReader.GetString(4)
            StepStatus = myReader.GetString(5)
            StepItemActual = myReader.GetSqlSingle(6)
            StartStepDate = myReader.GetSqlDateTime(7)
            EndStepDate = myReader.GetSqlDateTime(8)
            LotNumber = myReader.GetString(9)

        Loop

        StepTimeSpan = DateDiff(DateInterval.Second, StartStepDate, EndStepDate)

        Span = TimeSpan.FromSeconds(StepTimeSpan)

        StepNumberTxtBox.Text = WorkOrderNumber & " - " & StepNumber
        StepItemTxtBox.Text = StepType & " " & StepItem & " " & StepItemTarget & " " & ParamUOM
        StepItemDescTxtBox.Text = StepItemDesc
        StepActualTxtBox.Text = StepItemActual & " " & ParamUOM
        StepStatusTxtBox.Text = StepStatus
        StartStepDateTxtBox.Text = StartStepDate.ToString("MM/dd HHH:mm")
        StopStepDateTxtBox.Text = EndStepDate.ToString("MM/dd HHH:mm")
        WorkOrderDurationTxtBox.Text = Span.Hours.ToString.PadLeft(2, "0"c) & ":" & Span.Minutes.ToString.PadLeft(2, "0"c) & ":" & Span.Seconds.ToString.PadLeft(2, "0"c)
        LotNumTxtBox.Text = LotNumber


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

End Class