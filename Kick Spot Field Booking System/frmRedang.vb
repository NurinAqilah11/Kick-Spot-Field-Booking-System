Public Class frmRedang
    Private Sub FIELDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FIELDToolStripMenuItem.Click
        frmField.Show()
        Me.Hide()
    End Sub

    Private Sub ABOUTUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTUSToolStripMenuItem.Click
        frmAboutUs.Show()
        Me.Hide()
    End Sub
End Class