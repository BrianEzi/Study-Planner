<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Navbar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BtnCalendar = New System.Windows.Forms.Button()
        Me.BtnPlus = New System.Windows.Forms.Button()
        Me.BtnActivities = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCalendar
        '
        Me.BtnCalendar.FlatAppearance.BorderSize = 0
        Me.BtnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!)
        Me.BtnCalendar.Location = New System.Drawing.Point(186, 0)
        Me.BtnCalendar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCalendar.Name = "BtnCalendar"
        Me.BtnCalendar.Size = New System.Drawing.Size(179, 75)
        Me.BtnCalendar.TabIndex = 1
        Me.BtnCalendar.Text = " Calendar"
        Me.BtnCalendar.UseVisualStyleBackColor = True
        '
        'BtnPlus
        '
        Me.BtnPlus.BackColor = System.Drawing.Color.LightBlue
        Me.BtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlus.Location = New System.Drawing.Point(360, 4)
        Me.BtnPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPlus.Name = "BtnPlus"
        Me.BtnPlus.Size = New System.Drawing.Size(96, 67)
        Me.BtnPlus.TabIndex = 2
        Me.BtnPlus.Text = "+"
        Me.BtnPlus.UseVisualStyleBackColor = False
        '
        'BtnActivities
        '
        Me.BtnActivities.FlatAppearance.BorderSize = 0
        Me.BtnActivities.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActivities.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActivities.Location = New System.Drawing.Point(464, 0)
        Me.BtnActivities.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnActivities.Name = "BtnActivities"
        Me.BtnActivities.Size = New System.Drawing.Size(156, 75)
        Me.BtnActivities.TabIndex = 3
        Me.BtnActivities.Text = "Activities"
        Me.BtnActivities.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 69)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "|"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(601, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 69)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "|"
        '
        'Navbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnActivities)
        Me.Controls.Add(Me.BtnPlus)
        Me.Controls.Add(Me.BtnCalendar)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Navbar"
        Me.Size = New System.Drawing.Size(819, 75)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCalendar As Button
    Friend WithEvents BtnPlus As Button
    Friend WithEvents BtnActivities As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
