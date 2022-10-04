<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreateAcc
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
        Me.p = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblRepeat = New System.Windows.Forms.Label()
        Me.lblSecQ = New System.Windows.Forms.Label()
        Me.lblSecA = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtRepeat = New System.Windows.Forms.TextBox()
        Me.TxtSecA = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbllen = New System.Windows.Forms.Label()
        Me.lblnum = New System.Windows.Forms.Label()
        Me.lblsym = New System.Windows.Forms.Label()
        Me.lblcap = New System.Windows.Forms.Label()
        Me.BtnCreateAcc = New System.Windows.Forms.Button()
        Me.CBoxSecQ = New System.Windows.Forms.ComboBox()
        Me.LinkLogin = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'p
        '
        Me.p.AutoSize = True
        Me.p.Location = New System.Drawing.Point(21, 25)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(42, 17)
        Me.p.TabIndex = 0
        Me.p.Text = "Email"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(21, 73)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'lblRepeat
        '
        Me.lblRepeat.AutoSize = True
        Me.lblRepeat.Location = New System.Drawing.Point(25, 286)
        Me.lblRepeat.Name = "lblRepeat"
        Me.lblRepeat.Size = New System.Drawing.Size(119, 17)
        Me.lblRepeat.TabIndex = 2
        Me.lblRepeat.Text = "Repeat Password"
        '
        'lblSecQ
        '
        Me.lblSecQ.AutoSize = True
        Me.lblSecQ.Location = New System.Drawing.Point(25, 338)
        Me.lblSecQ.Name = "lblSecQ"
        Me.lblSecQ.Size = New System.Drawing.Size(120, 17)
        Me.lblSecQ.TabIndex = 3
        Me.lblSecQ.Text = "Security Question"
        '
        'lblSecA
        '
        Me.lblSecA.AutoSize = True
        Me.lblSecA.Location = New System.Drawing.Point(25, 386)
        Me.lblSecA.Name = "lblSecA"
        Me.lblSecA.Size = New System.Drawing.Size(109, 17)
        Me.lblSecA.TabIndex = 4
        Me.lblSecA.Text = "Security Answer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(389, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Strong"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(147, 25)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(293, 22)
        Me.TxtEmail.TabIndex = 6
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(147, 68)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(293, 22)
        Me.TxtPassword.TabIndex = 7
        '
        'TxtRepeat
        '
        Me.TxtRepeat.Location = New System.Drawing.Point(149, 289)
        Me.TxtRepeat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtRepeat.Name = "TxtRepeat"
        Me.TxtRepeat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtRepeat.Size = New System.Drawing.Size(293, 22)
        Me.TxtRepeat.TabIndex = 8
        '
        'TxtSecA
        '
        Me.TxtSecA.Location = New System.Drawing.Point(149, 383)
        Me.TxtSecA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSecA.Name = "TxtSecA"
        Me.TxtSecA.Size = New System.Drawing.Size(293, 22)
        Me.TxtSecA.TabIndex = 10
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(205, 117)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(171, 23)
        Me.ProgressBar1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Weak"
        '
        'lbllen
        '
        Me.lbllen.AutoSize = True
        Me.lbllen.ForeColor = System.Drawing.Color.Red
        Me.lbllen.Location = New System.Drawing.Point(175, 155)
        Me.lbllen.Name = "lbllen"
        Me.lbllen.Size = New System.Drawing.Size(224, 17)
        Me.lbllen.TabIndex = 13
        Me.lbllen.Text = "Must be at least 8 Characters long"
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.ForeColor = System.Drawing.Color.Red
        Me.lblnum.Location = New System.Drawing.Point(175, 190)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(124, 17)
        Me.lblnum.TabIndex = 14
        Me.lblnum.Text = "Includes a number"
        '
        'lblsym
        '
        Me.lblsym.AutoSize = True
        Me.lblsym.ForeColor = System.Drawing.Color.Red
        Me.lblsym.Location = New System.Drawing.Point(175, 226)
        Me.lblsym.Name = "lblsym"
        Me.lblsym.Size = New System.Drawing.Size(113, 17)
        Me.lblsym.TabIndex = 15
        Me.lblsym.Text = "Include a symbol"
        '
        'lblcap
        '
        Me.lblcap.AutoSize = True
        Me.lblcap.ForeColor = System.Drawing.Color.Red
        Me.lblcap.Location = New System.Drawing.Point(175, 258)
        Me.lblcap.Name = "lblcap"
        Me.lblcap.Size = New System.Drawing.Size(153, 17)
        Me.lblcap.TabIndex = 16
        Me.lblcap.Text = "Includes a capital letter"
        '
        'BtnCreateAcc
        '
        Me.BtnCreateAcc.Location = New System.Drawing.Point(179, 422)
        Me.BtnCreateAcc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCreateAcc.Name = "BtnCreateAcc"
        Me.BtnCreateAcc.Size = New System.Drawing.Size(171, 50)
        Me.BtnCreateAcc.TabIndex = 17
        Me.BtnCreateAcc.Text = "Create Account"
        Me.BtnCreateAcc.UseVisualStyleBackColor = True
        '
        'CBoxSecQ
        '
        Me.CBoxSecQ.FormattingEnabled = True
        Me.CBoxSecQ.Items.AddRange(New Object() {"What is your mothers maiden name?", "What was your childhood pets name?", "What primary school did you go to?", "What is your favourite food?", "What was the name of the street you grew up on?"})
        Me.CBoxSecQ.Location = New System.Drawing.Point(149, 336)
        Me.CBoxSecQ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBoxSecQ.Name = "CBoxSecQ"
        Me.CBoxSecQ.Size = New System.Drawing.Size(293, 24)
        Me.CBoxSecQ.TabIndex = 18
        '
        'LinkLogin
        '
        Me.LinkLogin.AutoSize = True
        Me.LinkLogin.Location = New System.Drawing.Point(221, 482)
        Me.LinkLogin.Name = "LinkLogin"
        Me.LinkLogin.Size = New System.Drawing.Size(47, 17)
        Me.LinkLogin.TabIndex = 19
        Me.LinkLogin.TabStop = True
        Me.LinkLogin.Text = "Log In"
        '
        'FrmCreateAcc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 510)
        Me.Controls.Add(Me.LinkLogin)
        Me.Controls.Add(Me.CBoxSecQ)
        Me.Controls.Add(Me.BtnCreateAcc)
        Me.Controls.Add(Me.lblcap)
        Me.Controls.Add(Me.lblsym)
        Me.Controls.Add(Me.lblnum)
        Me.Controls.Add(Me.lbllen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TxtSecA)
        Me.Controls.Add(Me.TxtRepeat)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblSecA)
        Me.Controls.Add(Me.lblSecQ)
        Me.Controls.Add(Me.lblRepeat)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.p)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmCreateAcc"
        Me.Text = "Create Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents p As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblRepeat As Label
    Friend WithEvents lblSecQ As Label
    Friend WithEvents lblSecA As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtRepeat As TextBox
    Friend WithEvents TxtSecA As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents lbllen As Label
    Friend WithEvents lblnum As Label
    Friend WithEvents lblsym As Label
    Friend WithEvents lblcap As Label
    Friend WithEvents BtnCreateAcc As Button
    Friend WithEvents CBoxSecQ As ComboBox
    Friend WithEvents LinkLogin As LinkLabel
End Class
