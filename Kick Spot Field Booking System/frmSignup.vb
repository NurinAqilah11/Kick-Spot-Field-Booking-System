Public Class frmSignup
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmHomepage.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub frmSignup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class