<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlusFrm
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
        Me.Btnanalyse = New System.Windows.Forms.Button()
        Me.BtnNewActivity = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btnanalyse
        '
        Me.Btnanalyse.Location = New System.Drawing.Point(16, 15)
        Me.Btnanalyse.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnanalyse.Name = "Btnanalyse"
        Me.Btnanalyse.Size = New System.Drawing.Size(189, 68)
        Me.Btnanalyse.TabIndex = 0
        Me.Btnanalyse.Text = "Get Analytics"
        Me.Btnanalyse.UseVisualStyleBackColor = True
        '
        'BtnNewActivity
        '
        Me.BtnNewActivity.Location = New System.Drawing.Point(16, 90)
        Me.BtnNewActivity.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNewActivity.Name = "BtnNewActivity"
        Me.BtnNewActivity.Size = New System.Drawing.Size(189, 68)
        Me.BtnNewActivity.TabIndex = 1
        Me.BtnNewActivity.Text = "New activity"
        Me.BtnNewActivity.UseVisualStyleBackColor = True
        '
        'PlusFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 170)
        Me.Controls.Add(Me.BtnNewActivity)
        Me.Controls.Add(Me.Btnanalyse)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PlusFrm"
        Me.Text = "PlusFrm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btnanalyse As Button
    Friend WithEvents BtnNewActivity As Button
End Class
