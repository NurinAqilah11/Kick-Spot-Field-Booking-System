<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.GreenYellow
        Me.btnLogin.Font = New System.Drawing.Font("Berlin Sans FB Demi", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(1034, 506)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(190, 57)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "LOG IN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.GreenYellow
        Me.btnSignUp.Font = New System.Drawing.Font("Berlin Sans FB Demi", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.Location = New System.Drawing.Point(1034, 585)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(190, 57)
        Me.btnSignUp.TabIndex = 1
        Me.btnSignUp.Text = "SIGN UP"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Kick_Spot_Field_Booking_System.My.Resources.Resources.MainInterface
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1290, 703)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.btnLogin)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents btnSignUp As Button
End Class
