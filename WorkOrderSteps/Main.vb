Imports System.Data.SqlClient

Public Class Main
    Inherits System.Windows.Forms.Form

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TestSQLConnection()
        CenterToScreen()

        VersionLbl.Text = "Ver: " & My.Application.Info.Version.ToString
    End Sub

    Private Sub SelectOrderBtn_Click(sender As Object, e As EventArgs) Handles SelectOrderBtn.Click
        Dim oForm As SelectOrder
        oForm = New SelectOrder(vbNull)
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub CloseApplication_Click(sender As Object, e As EventArgs) Handles CloseApplication.Click
        Application.Exit()
    End Sub

    Private Sub TestSQLConnection()
        Dim myConn As SqlConnection
        myConn = DatabaseConnection.CreateSQLConnection()

        Try
            myConn.Open()
        Catch ex As Exception
            MessageBox.Show("Cannont Connect To Instance of SQL." + vbCrLf + "Please verify that the application is configured for the correct instance of SQL Server and that your device has network connectivity.", "DB Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try

    End Sub

    Private Sub SelectAssetBtn_Click(sender As Object, e As EventArgs) Handles SelectAssetBtn.Click
        Dim oForm As SelectAsset
        oForm = New SelectAsset(vbNull, vbNull)
        oForm.Show()
        oForm = Nothing
    End Sub
End Class