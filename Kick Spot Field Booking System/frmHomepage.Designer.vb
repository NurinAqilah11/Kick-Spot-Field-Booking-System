<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomepage
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FIELDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BOOKINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HISTORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
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
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HOMEToolStripMenuItem
        '
        Me.HOMEToolStripMenuItem.ForeColor = System.Drawing.Color.ForestGreen
        Me.HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        Me.HOMEToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.HOMEToolStripMenuItem.Text = "HOME"
        '
        'FIELDToolStripMenuItem
        '
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.YellowGreen
        Me.btnExit.Font = New System.Drawing.Font("Berlin Sans FB Demi", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1143, 32)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(134, 48)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmHomepage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Kick_Spot_Field_Booking_System.My.Resources.Resources.Homepage_Interface__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1290, 703)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmHomepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHomepage"
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
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents btnExit As Button
    Friend WithEvents HISTORYToolStripMenuItem As ToolStripMenuItem
End Class
