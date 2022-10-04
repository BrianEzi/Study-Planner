<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtSecA = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.lblSecQ = New System.Windows.Forms.Label()
        Me.LblSecA = New System.Windows.Forms.Label()
        Me.BtnGetPass = New System.Windows.Forms.Button()
        Me.ChkboxConfirm = New System.Windows.Forms.CheckBox()
        Me.TxtSecQ = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(144, 30)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(293, 22)
        Me.TxtEmail.TabIndex = 0
        '
        'TxtSecA
        '
        Me.TxtSecA.Location = New System.Drawing.Point(144, 86)
        Me.TxtSecA.Name = "TxtSecA"
        Me.TxtSecA.Size = New System.Drawing.Size(378, 22)
        Me.TxtSecA.TabIndex = 21
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(14, 35)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(42, 17)
        Me.LblEmail.TabIndex = 22
        Me.LblEmail.Text = "Email"
        '
        'lblSecQ
        '
        Me.lblSecQ.AutoSize = True
        Me.lblSecQ.Location = New System.Drawing.Point(14, 64)
        Me.lblSecQ.Name = "lblSecQ"
        Me.lblSecQ.Size = New System.Drawing.Size(124, 17)
        Me.lblSecQ.TabIndex = 23
        Me.lblSecQ.Text = "Security Question:"
        '
        'LblSecA
        '
        Me.LblSecA.AutoSize = True
        Me.LblSecA.Location = New System.Drawing.Point(14, 91)
        Me.LblSecA.Name = "LblSecA"
        Me.LblSecA.Size = New System.Drawing.Size(113, 17)
        Me.LblSecA.TabIndex = 24
        Me.LblSecA.Text = "Security Answer:"
        '
        'BtnGetPass
        '
        Me.BtnGetPass.Location = New System.Drawing.Point(210, 114)
        Me.BtnGetPass.Name = "BtnGetPass"
        Me.BtnGetPass.Size = New System.Drawing.Size(166, 49)
        Me.BtnGetPass.TabIndex = 25
        Me.BtnGetPass.Text = "Get Password"
        Me.BtnGetPass.UseVisualStyleBackColor = True
        '
        'ChkboxConfirm
        '
        Me.ChkboxConfirm.AutoSize = True
        Me.ChkboxConfirm.Location = New System.Drawing.Point(444, 30)
        Me.ChkboxConfirm.Name = "ChkboxConfirm"
        Me.ChkboxConfirm.Size = New System.Drawing.Size(78, 21)
        Me.ChkboxConfirm.TabIndex = 26
        Me.ChkboxConfirm.Text = "Confirm"
        Me.ChkboxConfirm.UseVisualStyleBackColor = True
        '
        'TxtSecQ
        '
        Me.TxtSecQ.Location = New System.Drawing.Point(144, 58)
        Me.TxtSecQ.Name = "TxtSecQ"
        Me.TxtSecQ.Size = New System.Drawing.Size(378, 22)
        Me.TxtSecQ.TabIndex = 27
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 172)
        Me.Controls.Add(Me.TxtSecQ)
        Me.Controls.Add(Me.ChkboxConfirm)
        Me.Controls.Add(Me.BtnGetPass)
        Me.Controls.Add(Me.LblSecA)
        Me.Controls.Add(Me.lblSecQ)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.TxtSecA)
        Me.Controls.Add(Me.TxtEmail)
        Me.Name = "ForgotPassword"
        Me.Text = "ForgotPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtSecA As TextBox
    Friend WithEvents LblEmail As Label
    Friend WithEvents lblSecQ As Label
    Friend WithEvents LblSecA As Label
    Friend WithEvents BtnGetPass As Button
    Friend WithEvents ChkboxConfirm As CheckBox
    Friend WithEvents TxtSecQ As TextBox
End Class
