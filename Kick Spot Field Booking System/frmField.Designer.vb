<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmField
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
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.MenuStrip1.TabIndex = 1
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
        Me.FIELDToolStripMenuItem.ForeColor = System.Drawing.Color.ForestGreen
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
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.YellowGreen
        Me.btnRegister.Font = New System.Drawing.Font("Berlin Sans FB Demi", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(882, 328)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(321, 44)
        Me.btnRegister.TabIndex = 3
        Me.btnRegister.Text = "LANG TENGAH FIELD"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.YellowGreen
        Me.Button1.Font = New System.Drawing.Font("Berlin Sans FB Demi", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(882, 602)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(321, 44)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "REDANG FIELD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmField
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Kick_Spot_Field_Booking_System.My.Resources.Resources.field_Interface
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1290, 703)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmField"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmField"
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
    Friend WithEvents btnRegister As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents HISTORYToolStripMenuItem As ToolStripMenuItem
End Class
