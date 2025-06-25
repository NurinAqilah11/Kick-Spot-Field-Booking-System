Public Class frmField
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmRedang.Show()
        Me.Hide()

    End Sub

    Private Sub ABOUTUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTUSToolStripMenuItem.Click
        frmAboutUs.Show()
        Me.Hide()
    End Sub

    Private Sub FIELDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FIELDToolStripMenuItem.Click

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        frmLangTengah.Show()
        Me.Hide()

    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        frmHomepage.Show()
        Me.Hide()

    End Sub
End Class