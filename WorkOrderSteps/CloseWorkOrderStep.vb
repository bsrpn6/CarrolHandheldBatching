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
    Friend WithEvents MyTimer As New Timer

    Dim WorkOrderNumber As String
    Dim BatchID As Integer
    Dim StepNumber As Integer
    Dim ParamTarget As Single
    Dim ParamUOM As String
    Dim StepStartTime As Date
    Dim StepTimeSpan As Long
    Dim Span As TimeSpan


    Public Sub New(ByVal PassedWorkOrderNumber As String, ByVal PassedBatchID As Integer, ByVal PassedStepNumber As String)
        InitializeComponent()
        WorkOrderNumber = PassedWorkOrderNumber
        BatchID = PassedBatchID
        StepNumber = PassedStepNumber
    End Sub

    Private Sub CloseWorkOrderStep_Load(sender As Object, e As EventArgs) Handles Me.Load
        MyTimer.Interval = 500
        WorkOrderNumberTxtBox.Text = WorkOrderNumber & " - " & StepNumber

        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT [StepStartDate], [ParamTarget], [ParamUOM] FROM [BatchDB].[dbo].[baBatchSteps] WHERE [BatchID] = " & BatchID & "AND [StepNum] = " & StepNumber

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Do While myReader.Read
            StepStartTime = myReader.GetDateTime(0)
            ParamTarget = myReader.GetSqlSingle(1)
            ParamUOM = myReader.GetString(2)
        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        MyTimer.Start()

        WorkOrderStepTargetQtyTxtBox.Text = ParamTarget & " " & ParamUOM

        CenterToScreen()
    End Sub

    Private Sub CloseStep()
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "UPDATE [BatchDB].[dbo].[baBatchSteps] SET [StepStatus] = 'COMP', [StepEndDate] = '" & Date.Now.ToString("yyyy-MM-dd HHH:mm:ss") & "', [ParamActual] = '" & DateDiff(DateInterval.Minute, StepStartTime, Date.Now) & "' WHERE [BatchID] = " & BatchID & "AND [StepNum] = " & StepNumber

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

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyTimer.Tick
        'Duration in seconds
        StepTimeSpan = DateDiff(DateInterval.Second, StepStartTime, Now())

        Span = TimeSpan.FromSeconds(StepTimeSpan)

        StepDurationTxtBox.Text = Span.Hours.ToString.PadLeft(2, "0"c) & ":" & Span.Minutes.ToString.PadLeft(2, "0"c) & ":" & Span.Seconds.ToString.PadLeft(2, "0"c)

    End Sub

    Private Sub AbortStepBtn_Click(sender As Object, e As EventArgs) Handles AbortStepBtn.Click
        If MessageBox.Show("Are you sure you want to abort?", "Confirm", MessageBoxButtons.YesNo) Then

            myConn = DatabaseConnection.CreateSQLConnection()

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "UPDATE [BatchDB].[dbo].[baBatchSteps] SET [StepStatus] = 'ABRT', [StepEndDate] = '" & Date.Now.ToString("yyyy-MM-dd HHH:mm:ss") & "'  WHERE [BatchID] = " & BatchID & "AND [StepNum] = " & StepNumber

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