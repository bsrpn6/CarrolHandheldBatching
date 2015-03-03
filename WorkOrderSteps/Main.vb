Imports System.Data.SqlClient

Public Class Main
    Inherits System.Windows.Forms.Form

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub

    Private Sub SelectOrderBtn_Click(sender As Object, e As EventArgs) Handles SelectOrderBtn.Click
        Dim oForm As SelectOrder
        oForm = New SelectOrder()
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub CloseApplication_Click(sender As Object, e As EventArgs) Handles CloseApplication.Click
        Application.Exit()
    End Sub

    Private Sub TestResetBtn_Click(sender As Object, e As EventArgs) Handles TestResetBtn.Click

        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand
        Dim myReader As SqlDataReader
        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "UPDATE [BatchDB].[dbo].[baBatchSteps] SET [StepStatus] = 'OPEN', [ParamActual] = NULL, [StepStartDate] = NULL, [StepEndDate] = NULL, [LotNumber] = NULL"

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        'Close the reader and the database connection.
        myReader.Close()

        myCmd.CommandText = "UPDATE [dbo].[baBatches] SET [BatchStatus] = 'OPEN', [BatchStartDate] = NULL, [BatchEndDate] = NULL"

        myReader = myCmd.ExecuteReader

        myConn.Close()

        MessageBox.Show("Application has been reset.")
    End Sub
End Class