<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LinkPassword = New System.Windows.Forms.LinkLabel()
        Me.LinkNewAcc = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnLogin.Location = New System.Drawing.Point(166, 182)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(137, 48)
        Me.BtnLogin.TabIndex = 0
        Me.BtnLogin.Text = "Log In"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(134, 28)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(299, 22)
        Me.TxtEmail.TabIndex = 1
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.Location = New System.Drawing.Point(21, 33)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(60, 25)
        Me.LblEmail.TabIndex = 2
        Me.LblEmail.Text = "Email"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(134, 105)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(299, 22)
        Me.TxtPassword.TabIndex = 4
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(21, 105)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(98, 25)
        Me.LblPassword.TabIndex = 5
        Me.LblPassword.Text = "Password"
        '
        'LinkPassword
        '
        Me.LinkPassword.AutoSize = True
        Me.LinkPassword.Location = New System.Drawing.Point(228, 130)
        Me.LinkPassword.Name = "LinkPassword"
        Me.LinkPassword.Size = New System.Drawing.Size(114, 17)
        Me.LinkPassword.TabIndex = 6
        Me.LinkPassword.TabStop = True
        Me.LinkPassword.Text = "Forgot Password"
        '
        'LinkNewAcc
        '
        Me.LinkNewAcc.AutoSize = True
        Me.LinkNewAcc.Location = New System.Drawing.Point(182, 233)
        Me.LinkNewAcc.Name = "LinkNewAcc"
        Me.LinkNewAcc.Size = New System.Drawing.Size(109, 17)
        Me.LinkNewAcc.TabIndex = 7
        Me.LinkNewAcc.TabStop = True
        Me.LinkNewAcc.Text = "Create Account "
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 259)
        Me.Controls.Add(Me.LinkNewAcc)
        Me.Controls.Add(Me.LinkPassword)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.BtnLogin)
        Me.Name = "Login"
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents LblEmail As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents LinkPassword As LinkLabel
    Friend WithEvents LinkNewAcc As LinkLabel
End Class
