Public Class frmAboutUs
    Private Sub FIELDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FIELDToolStripMenuItem.Click
        frmField.Show()
        Me.Hide()

    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        frmHomepage.Show()
        Me.Hide()

    End Sub
End Class