<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignup
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
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSignup
        '
        Me.btnSignup.BackColor = System.Drawing.Color.YellowGreen
        Me.btnSignup.Font = New System.Drawing.Font("Berlin Sans FB Demi", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignup.Location = New System.Drawing.Point(968, 522)
        Me.btnSignup.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(155, 56)
        Me.btnSignup.TabIndex = 4
        Me.btnSignup.Text = "SIGN UP"
        Me.btnSignup.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.YellowGreen
        Me.btnClear.Font = New System.Drawing.Font("Berlin Sans FB Demi", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(805, 522)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(155, 56)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.YellowGreen
        Me.btnHome.Font = New System.Drawing.Font("Berlin Sans FB Demi", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(1143, 13)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(134, 48)
        Me.btnHome.TabIndex = 6
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.YellowGreen
        Me.btnLogin.Font = New System.Drawing.Font("Berlin Sans FB Demi", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(921, 615)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(150, 56)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "LOG IN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.YellowGreen
        Me.txtName.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(495, 213)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(576, 38)
        Me.txtName.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.YellowGreen
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(495, 294)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(576, 38)
        Me.txtEmail.TabIndex = 9
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.YellowGreen
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(495, 377)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(576, 38)
        Me.txtPassword.TabIndex = 10
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.YellowGreen
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(495, 460)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(576, 38)
        Me.txtConfirmPassword.TabIndex = 11
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(495, 511)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(292, 38)
        Me.lblMessage.TabIndex = 12
        Me.lblMessage.Text = "Output if user enter wrong input"
        '
        'frmSignup
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Kick_Spot_Field_Booking_System.My.Resources.Resources.Signup_Interface
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1290, 703)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSignup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSignup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSignup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSignup As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblMessage As Label
End Class
