<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        lblTitle = New Label()
        lblSubtitle = New Label()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        chkShowPassword = New CheckBox()
        btnLogin = New Button()
        btnSignUp = New Button()
        btnExit = New Button()
        lblMessage = New Label()
        pnlRegistration = New Panel()
        btnBackToLogin = New Button()
        btnRegister = New Button()
        txtRegPassword = New TextBox()
        lblRegPassword = New Label()
        txtRegEmail = New TextBox()
        lblRegEmail = New Label()
        txtRegUsername = New TextBox()
        lblRegUsername = New Label()
        txtFullName = New TextBox()
        lblFullName = New Label()
        lblRegistrationTitle = New Label()
        pnlRegistration.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(50, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(567, 48)
        lblTitle.TabIndex = 0
        lblTitle.Text = "STUDENT APPLICATION SYSTEM"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSubtitle.Location = New Point(150, 80)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(241, 28)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "please login to continue"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(170, 135)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(183, 30)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username/Email"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(170, 160)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(360, 30)
        txtUsername.TabIndex = 3
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(170, 205)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(112, 30)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(170, 230)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(360, 30)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkShowPassword.Location = New Point(170, 270)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(184, 32)
        chkShowPassword.TabIndex = 6
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(170, 310)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(170, 40)
        btnLogin.TabIndex = 7
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnSignUp
        ' 
        btnSignUp.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignUp.Location = New Point(350, 310)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(180, 40)
        btnSignUp.TabIndex = 8
        btnSignUp.Text = "CREATE ACCOUNT"
        btnSignUp.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.DarkRed
        btnExit.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(170, 365)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(360, 48)
        btnExit.TabIndex = 9
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.ForeColor = Color.Red
        lblMessage.Location = New Point(150, 405)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(0, 25)
        lblMessage.TabIndex = 10
        ' 
        ' pnlRegistration
        ' 
        pnlRegistration.BackColor = Color.WhiteSmoke
        pnlRegistration.BorderStyle = BorderStyle.FixedSingle
        pnlRegistration.Controls.Add(btnBackToLogin)
        pnlRegistration.Controls.Add(btnRegister)
        pnlRegistration.Controls.Add(txtRegPassword)
        pnlRegistration.Controls.Add(lblRegPassword)
        pnlRegistration.Controls.Add(txtRegEmail)
        pnlRegistration.Controls.Add(lblRegEmail)
        pnlRegistration.Controls.Add(txtRegUsername)
        pnlRegistration.Controls.Add(lblRegUsername)
        pnlRegistration.Controls.Add(txtFullName)
        pnlRegistration.Controls.Add(lblFullName)
        pnlRegistration.Controls.Add(lblRegistrationTitle)
        pnlRegistration.Location = New Point(135, 1)
        pnlRegistration.Name = "pnlRegistration"
        pnlRegistration.Size = New Size(502, 401)
        pnlRegistration.TabIndex = 11
        pnlRegistration.Visible = False
        ' 
        ' btnBackToLogin
        ' 
        btnBackToLogin.BackColor = Color.Gray
        btnBackToLogin.FlatStyle = FlatStyle.Flat
        btnBackToLogin.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBackToLogin.ForeColor = Color.White
        btnBackToLogin.Location = New Point(165, 343)
        btnBackToLogin.Name = "btnBackToLogin"
        btnBackToLogin.Size = New Size(125, 53)
        btnBackToLogin.TabIndex = 11
        btnBackToLogin.Text = "BACK TO LOGIN"
        btnBackToLogin.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.Green
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(20, 343)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(125, 53)
        btnRegister.TabIndex = 10
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' txtRegPassword
        ' 
        txtRegPassword.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRegPassword.Location = New Point(20, 286)
        txtRegPassword.Multiline = True
        txtRegPassword.Name = "txtRegPassword"
        txtRegPassword.Size = New Size(458, 51)
        txtRegPassword.TabIndex = 9
        ' 
        ' lblRegPassword
        ' 
        lblRegPassword.AutoSize = True
        lblRegPassword.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRegPassword.Location = New Point(20, 257)
        lblRegPassword.Name = "lblRegPassword"
        lblRegPassword.Size = New Size(96, 21)
        lblRegPassword.TabIndex = 8
        lblRegPassword.Text = "Password"
        ' 
        ' txtRegEmail
        ' 
        txtRegEmail.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRegEmail.Location = New Point(20, 207)
        txtRegEmail.Multiline = True
        txtRegEmail.Name = "txtRegEmail"
        txtRegEmail.Size = New Size(458, 44)
        txtRegEmail.TabIndex = 7
        ' 
        ' lblRegEmail
        ' 
        lblRegEmail.AutoSize = True
        lblRegEmail.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRegEmail.Location = New Point(20, 180)
        lblRegEmail.Name = "lblRegEmail"
        lblRegEmail.Size = New Size(59, 21)
        lblRegEmail.TabIndex = 6
        lblRegEmail.Text = "Email"
        ' 
        ' txtRegUsername
        ' 
        txtRegUsername.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRegUsername.Location = New Point(20, 147)
        txtRegUsername.Name = "txtRegUsername"
        txtRegUsername.Size = New Size(458, 30)
        txtRegUsername.TabIndex = 5
        ' 
        ' lblRegUsername
        ' 
        lblRegUsername.AutoSize = True
        lblRegUsername.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRegUsername.Location = New Point(20, 126)
        lblRegUsername.Name = "lblRegUsername"
        lblRegUsername.Size = New Size(100, 21)
        lblRegUsername.TabIndex = 4
        lblRegUsername.Text = "Username"
        ' 
        ' txtFullName
        ' 
        txtFullName.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFullName.Location = New Point(20, 84)
        txtFullName.Multiline = True
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(458, 39)
        txtFullName.TabIndex = 3
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullName.Location = New Point(20, 60)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(114, 21)
        lblFullName.TabIndex = 2
        lblFullName.Text = "FULL NAME"
        ' 
        ' lblRegistrationTitle
        ' 
        lblRegistrationTitle.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRegistrationTitle.Location = New Point(10, 15)
        lblRegistrationTitle.Name = "lblRegistrationTitle"
        lblRegistrationTitle.Size = New Size(280, 30)
        lblRegistrationTitle.TabIndex = 1
        lblRegistrationTitle.Text = "CREATE ACCOUNT"
        lblRegistrationTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(678, 466)
        Controls.Add(pnlRegistration)
        Controls.Add(lblMessage)
        Controls.Add(btnExit)
        Controls.Add(btnSignUp)
        Controls.Add(btnLogin)
        Controls.Add(chkShowPassword)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblUsername)
        Controls.Add(lblSubtitle)
        Controls.Add(lblTitle)
        Name = "frmLogin"
        Text = "student Application System Login"
        pnlRegistration.ResumeLayout(False)
        pnlRegistration.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents pnlRegistration As Panel
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblRegistrationTitle As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtRegUsername As TextBox
    Friend WithEvents lblRegUsername As Label
    Friend WithEvents lblRegPassword As Label
    Friend WithEvents txtRegEmail As TextBox
    Friend WithEvents lblRegEmail As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtRegPassword As TextBox
    Friend WithEvents btnBackToLogin As Button
End Class
