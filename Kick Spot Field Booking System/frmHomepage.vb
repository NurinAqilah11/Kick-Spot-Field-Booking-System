Public Class frmHomepage
    Private Sub BOOKINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKINGToolStripMenuItem.Click

    End Sub

    Private Sub FIELDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FIELDToolStripMenuItem.Click
        frmField.Show()
        Me.Hide()
    End Sub

    Private Sub ABOUTUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTUSToolStripMenuItem.Click
        frmAboutUs.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class