Option Strict Off
Option Explicit On
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient


Public Class WorkOrderStep
    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Friend WithEvents MyTimer As New Timer

    Dim WorkOrderNumber As String
    Dim StepNumber As Integer
    Dim WorkOrderItem As String
    Dim WorkOrderItemDesc As String
    Dim WorkOrderStepItem As String
    Dim WorkOrderStepItemDesc As String
    Dim WorkOrderStepTargetQty As Integer
    Dim WorkOrderStepHiHiDev As Integer
    Dim WorkOrderStepHiDev As Integer
    Dim WorkOrderStepLoDev As Integer
    Dim WorkOrderStepLoLoDev As Integer
    Dim InstructionsNotViewed As Boolean = True
    Dim QtyTxtBoxHiLo As Boolean = False
    Dim QtyTxtBoxHiHiLoLo As Boolean = False
    Dim WorkOrderStepItemIncorrect As Boolean = False

    Public Sub New(ByVal PassedWorkOrderNumber As String, ByVal PassedStepNumber As String)
        InitializeComponent()
        WorkOrderNumber = PassedWorkOrderNumber
        StepNumber = PassedStepNumber
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyTimer.Interval = 500
        Reset()

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT [WorkOrderNum] ,[WorkOrderItem] ,[WorkOrderItemDesc] ,[WorkOrderStepItem] ,[WorkOrderStepItemDesc] ,[WorkOrderStepTargetQty] ,[WorkOrderStepHiHiDev] ,[WorkOrderStepHiDev] ,[WorkOrderStepLoDev] ,[WorkOrderStepLoLoDev]FROM [BatchDB].[dbo].[TestWorkOrderSteps] WHERE [WorkOrderNum] = " & WorkOrderNumber & "AND [StepNum] = " & StepNumber

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()


        'Concatenate the query result into a string.
        Do While myReader.Read()
            WorkOrderNumber = myReader.GetString(0)
            WorkOrderItem = myReader.GetString(1)
            WorkOrderItemDesc = myReader.GetString(2)
            WorkOrderStepItem = myReader.GetString(3)
            WorkOrderStepItemDesc = myReader.GetString(4)
            WorkOrderStepTargetQty = myReader.GetInt32(5)
            WorkOrderStepHiHiDev = myReader.GetInt32(6)
            WorkOrderStepHiDev = myReader.GetInt32(7)
            WorkOrderStepLoDev = myReader.GetInt32(8)
            WorkOrderStepLoLoDev = myReader.GetInt32(9)

        Loop

        WorkOrderNumberTxtBox.Text = WorkOrderNumber & " - " & StepNumber
        WorkOrderItemTxtBox.Text = WorkOrderItem
        WorkOrderItemDescTxtBox.Text = WorkOrderItemDesc
        WorkOrderStepTargetQtyTxtBox.Text = WorkOrderStepTargetQty & " " & "LBS"

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        CenterToScreen()
        Show()
        WorkOrderStepItemTxtBox.Focus()


    End Sub

    Private Sub Reset()
        'WorkOrderNumberTxtBox.Text = ""
        'WorkOrderItemTxtBox.Text = ""
        'WorkOrderItemDescTxtBox.Text = ""
        WorkOrderStepItemTxtBox.Text = ""
        'WorkOrderStepTargetQtyTxtBox.Text = ""
        LotcodeTxtBox.Text = ""
        QtyTxtBox.Text = ""
        'WorkOrderNumber = ""
        'WorkOrderItem = ""
        'WorkOrderItemDesc = ""
        'WorkOrderStepItem = ""
        'WorkOrderStepItemDesc = ""
        'WorkOrderStepTargetQty = vbNull
        'WorkOrderStepHiHiDev = vbNull
        'WorkOrderStepHiDev = vbNull
        'WorkOrderStepLoDev = vbNull
        'WorkOrderStepLoLoDev = vbNull
        WorkOrderStepItemTxtBox.BackColor = Color.FromArgb(224, 224, 224)
        QtyTxtBox.BackColor = Color.FromArgb(224, 224, 224)
        ViewInstructionsBtn.BackColor = Color.FromArgb(0, 192, 0)
        QtyTxtBoxHiLo = False
        QtyTxtBoxHiHiLoLo = False
        WorkOrderStepItemIncorrect = False
        InstructionsNotViewed = True
        Call Timer_Stop_Check()
        
    End Sub

    Private Sub ViewInstructionsBtn_Click(sender As Object, e As EventArgs) Handles ViewInstructionsBtn.Click
        WorkOrderStepItemTxtBox.Focus()
        Dim oForm As Instructions
        oForm = New Instructions(WorkOrderNumber)
        oForm.Show()
        oForm = Nothing
        InstructionsNotViewed = False
        ViewInstructionsBtn.BackColor = Color.FromArgb(224, 224, 224)
        Call Timer_Stop_Check()
    End Sub

    Private Sub WorkOrderStepItemTxtBox_KeyDown(sender As Object, e As KeyEventArgs) Handles WorkOrderStepItemTxtBox.KeyDown
        If e.KeyData = Keys.Return Then
            LotcodeTxtBox.Focus()
        End If
    End Sub

    Private Sub WorkOrderStepItemTxtBox_TextChanged(sender As Object, e As EventArgs) Handles WorkOrderStepItemTxtBox.TextChanged
        If WorkOrderStepItemTxtBox.Text <> WorkOrderItem Then
            WorkOrderStepItemIncorrect = True
            MyTimer.Start()
        Else
            WorkOrderStepItemIncorrect = False
            WorkOrderStepItemTxtBox.BackColor = Color.FromArgb(224, 224, 224)
            Call Timer_Stop_Check()
        End If

    End Sub

    Private Sub QtyTxtBox_TextChanged(sender As Object, e As EventArgs) Handles QtyTxtBox.TextChanged
        Dim QtyTxtBoxValue As Integer

        If Integer.TryParse(QtyTxtBox.Text, QtyTxtBoxValue) Then
            If QtyTxtBox.Text > WorkOrderStepHiDev Or QtyTxtBox.Text < WorkOrderStepLoDev Then
                If QtyTxtBox.Text > WorkOrderStepHiHiDev Or QtyTxtBox.Text < WorkOrderStepLoLoDev Then
                    QtyTxtBoxHiHiLoLo = True
                Else
                    QtyTxtBoxHiHiLoLo = False
                    QtyTxtBoxHiLo = True
                End If
                MyTimer.Start()
            Else
                QtyTxtBoxHiLo = False
                QtyTxtBoxHiHiLoLo = False
                QtyTxtBox.BackColor = Color.FromArgb(224, 224, 224)
                Call Timer_Stop_Check()

            End If
        End If
    End Sub
    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyTimer.Tick
        Static HighBit As Boolean

        'QtyTxtBox
        If HighBit And QtyTxtBoxHiHiLoLo Then
            QtyTxtBox.BackColor = Color.Red
        ElseIf HighBit And QtyTxtBoxHiLo Then
            QtyTxtBox.BackColor = Color.Yellow
        Else
            QtyTxtBox.BackColor = Color.FromArgb(224, 224, 224)
        End If

        'WorkOrderStepItemTxtBox
        If HighBit And WorkOrderStepItemIncorrect Then
            WorkOrderStepItemTxtBox.BackColor = Color.Red
        Else
            WorkOrderStepItemTxtBox.BackColor = Color.FromArgb(224, 224, 224)
        End If

        'InstructionsNotViewed
        If HighBit And InstructionsNotViewed Then
            ViewInstructionsBtn.BackColor = Color.FromArgb(0, 192, 0)
        Else
            ViewInstructionsBtn.BackColor = Color.FromArgb(224, 224, 224)
        End If

        HighBit = Not HighBit
    End Sub

    Private Sub Timer_Stop_Check()
        If QtyTxtBoxHiLo.Equals(False) And QtyTxtBoxHiHiLoLo.Equals(False) And WorkOrderStepItemIncorrect.Equals(False) And InstructionsNotViewed.Equals(False) Then
            MyTimer.Stop()
        Else
            MyTimer.Start()
        End If

    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click

        If WorkOrderStepItemTxtBox.Text > "" And LotcodeTxtBox.Text > "" And QtyTxtBox.Text > "" Then
            'Create a Connection object.
            myConn = DatabaseConnection.CreateSQLConnection()

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "UPDATE [BatchDB].[dbo].[TestWorkOrderSteps] SET [WorkOrderStepItemUsed] = ' " & WorkOrderStepItemTxtBox.Text & " ' ,[WorkOrderLotNumber] = ' " & LotcodeTxtBox.Text & " ' ,[WorkOrderStepQtyUsed] = ' " & QtyTxtBox.Text & " ' ,[Status] = 'ACTV' WHERE [WorkOrderNum] = " & WorkOrderNumber & "AND [StepNum] = " & StepNumber

            'Open the connection.
            myConn.Open()

            myReader = myCmd.ExecuteReader()

            'Close the reader and the database connection.
            myReader.Close()
            myConn.Close()
            Close()
        Else
            MessageBox.Show("Please provide required information.")
        End If


    End Sub

    Private Sub ClearBtn_Click_1(sender As Object, e As EventArgs) Handles ClearBtn.Click
        Call Reset()
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

    Private Sub LotcodeTxtBox_KeyDown(sender As Object, e As KeyEventArgs) Handles LotcodeTxtBox.KeyDown
        If e.KeyData = Keys.Return Then
            QtyTxtBox.Focus()
        End If
    End Sub

End Class
