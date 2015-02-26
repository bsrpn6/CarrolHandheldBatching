Public Class Main
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
End Class