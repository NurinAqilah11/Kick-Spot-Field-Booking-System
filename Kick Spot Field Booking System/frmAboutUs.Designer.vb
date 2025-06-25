<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAboutUs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FIELDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BOOKINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HISTORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOMEToolStripMenuItem, Me.FIELDToolStripMenuItem, Me.BOOKINGToolStripMenuItem, Me.ABOUTUSToolStripMenuItem, Me.HISTORYToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1290, 28)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HOMEToolStripMenuItem
        '
        Me.HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        Me.HOMEToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.HOMEToolStripMenuItem.Text = "HOME"
        '
        'FIELDToolStripMenuItem
        '
        Me.FIELDToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FIELDToolStripMenuItem.Name = "FIELDToolStripMenuItem"
        Me.FIELDToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.FIELDToolStripMenuItem.Text = "FIELD"
        '
        'BOOKINGToolStripMenuItem
        '
        Me.BOOKINGToolStripMenuItem.Name = "BOOKINGToolStripMenuItem"
        Me.BOOKINGToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.BOOKINGToolStripMenuItem.Text = "BOOKING"
        '
        'ABOUTUSToolStripMenuItem
        '
        Me.ABOUTUSToolStripMenuItem.ForeColor = System.Drawing.Color.ForestGreen
        Me.ABOUTUSToolStripMenuItem.Name = "ABOUTUSToolStripMenuItem"
        Me.ABOUTUSToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.ABOUTUSToolStripMenuItem.Text = "ABOUT US"
        '
        'HISTORYToolStripMenuItem
        '
        Me.HISTORYToolStripMenuItem.Name = "HISTORYToolStripMenuItem"
        Me.HISTORYToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.HISTORYToolStripMenuItem.Text = "HISTORY"
        '
        'frmAboutUs
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Kick_Spot_Field_Booking_System.My.Resources.Resources._PROPOSED_USER_INTERFACE_DESIGN
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1290, 703)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAboutUs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAboutUs"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FIELDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BOOKINGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTUSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HISTORYToolStripMenuItem As ToolStripMenuItem
End Class
