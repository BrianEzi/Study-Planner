<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotEmail
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
        Me.CBoxSecQ = New System.Windows.Forms.ComboBox()
        Me.lblSecQ = New System.Windows.Forms.Label()
        Me.TxtSecA = New System.Windows.Forms.TextBox()
        Me.lblSecA = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CBoxSecQ
        '
        Me.CBoxSecQ.FormattingEnabled = True
        Me.CBoxSecQ.Items.AddRange(New Object() {"What is your mother's maiden name?", "What was your childhood pet's name?", "What primary school did you go to?", "What is your favourite food?", "What was the name of the street you grew up on?"})
        Me.CBoxSecQ.Location = New System.Drawing.Point(154, 11)
        Me.CBoxSecQ.Margin = New System.Windows.Forms.Padding(2)
        Me.CBoxSecQ.Name = "CBoxSecQ"
        Me.CBoxSecQ.Size = New System.Drawing.Size(221, 21)
        Me.CBoxSecQ.TabIndex = 19
        '
        'lblSecQ
        '
        Me.lblSecQ.AutoSize = True
        Me.lblSecQ.Location = New System.Drawing.Point(35, 19)
        Me.lblSecQ.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSecQ.Name = "lblSecQ"
        Me.lblSecQ.Size = New System.Drawing.Size(90, 13)
        Me.lblSecQ.TabIndex = 20
        Me.lblSecQ.Text = "Security Question"
        '
        'TxtSecA
        '
        Me.TxtSecA.Location = New System.Drawing.Point(154, 58)
        Me.TxtSecA.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSecA.Name = "TxtSecA"
        Me.TxtSecA.Size = New System.Drawing.Size(221, 20)
        Me.TxtSecA.TabIndex = 21
        '
        'lblSecA
        '
        Me.lblSecA.AutoSize = True
        Me.lblSecA.Location = New System.Drawing.Point(42, 61)
        Me.lblSecA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSecA.Name = "lblSecA"
        Me.lblSecA.Size = New System.Drawing.Size(83, 13)
        Me.lblSecA.TabIndex = 22
        Me.lblSecA.Text = "Security Answer"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(179, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Label1"
        '
        'ForgotEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 201)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblSecA)
        Me.Controls.Add(Me.TxtSecA)
        Me.Controls.Add(Me.lblSecQ)
        Me.Controls.Add(Me.CBoxSecQ)
        Me.Name = "ForgotEmail"
        Me.Text = "ForgotEmail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBoxSecQ As ComboBox
    Friend WithEvents lblSecQ As Label
    Friend WithEvents TxtSecA As TextBox
    Friend WithEvents lblSecA As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
