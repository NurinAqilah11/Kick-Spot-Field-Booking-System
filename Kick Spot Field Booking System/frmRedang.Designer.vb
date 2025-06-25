<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRedang
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FIELDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BOOKINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HISTORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.YellowGreen
        Me.Button1.Font = New System.Drawing.Font("Berlin Sans FB Demi", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1029, 551)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 44)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "BOOK NOW!"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOMEToolStripMenuItem, Me.FIELDToolStripMenuItem, Me.BOOKINGToolStripMenuItem, Me.ABOUTUSToolStripMenuItem, Me.HISTORYToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1290, 28)
        Me.MenuStrip1.TabIndex = 7
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
        'frmRedang
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Kick_Spot_Field_Booking_System.My.Resources.Resources.redang_field
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1290, 703)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmRedang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRedang"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FIELDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BOOKINGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTUSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HISTORYToolStripMenuItem As ToolStripMenuItem
End Class
