<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmViewActivity
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
        Me.btnback = New System.Windows.Forms.Button()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblActType = New System.Windows.Forms.Label()
        Me.Lbldesc = New System.Windows.Forms.Label()
        Me.Lblgoals = New System.Windows.Forms.Label()
        Me.LblScheduledDays = New System.Windows.Forms.Label()
        Me.CLBGoals = New System.Windows.Forms.CheckedListBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.LblStartTime = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(16, 15)
        Me.btnback.Margin = New System.Windows.Forms.Padding(4)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(100, 28)
        Me.btnback.TabIndex = 0
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(16, 127)
        Me.txtdesc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.ReadOnly = True
        Me.txtdesc.Size = New System.Drawing.Size(255, 262)
        Me.txtdesc.TabIndex = 1
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(497, 15)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(100, 28)
        Me.BtnEdit.TabIndex = 3
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(605, 15)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(100, 28)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LblName.Location = New System.Drawing.Point(251, 15)
        Me.LblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(86, 31)
        Me.LblName.TabIndex = 5
        Me.LblName.Text = "Name"
        Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblActType
        '
        Me.LblActType.AutoSize = True
        Me.LblActType.Location = New System.Drawing.Point(265, 46)
        Me.LblActType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblActType.Name = "LblActType"
        Me.LblActType.Size = New System.Drawing.Size(51, 17)
        Me.LblActType.TabIndex = 6
        Me.LblActType.Text = "Label2"
        '
        'Lbldesc
        '
        Me.Lbldesc.AutoSize = True
        Me.Lbldesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbldesc.Location = New System.Drawing.Point(71, 94)
        Me.Lbldesc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbldesc.Name = "Lbldesc"
        Me.Lbldesc.Size = New System.Drawing.Size(135, 29)
        Me.Lbldesc.TabIndex = 7
        Me.Lbldesc.Text = "Description"
        '
        'Lblgoals
        '
        Me.Lblgoals.AutoSize = True
        Me.Lblgoals.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lblgoals.Location = New System.Drawing.Point(366, 94)
        Me.Lblgoals.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblgoals.Name = "Lblgoals"
        Me.Lblgoals.Size = New System.Drawing.Size(76, 29)
        Me.Lblgoals.TabIndex = 8
        Me.Lblgoals.Text = "Goals"
        '
        'LblScheduledDays
        '
        Me.LblScheduledDays.AutoSize = True
        Me.LblScheduledDays.Location = New System.Drawing.Point(574, 123)
        Me.LblScheduledDays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblScheduledDays.Name = "LblScheduledDays"
        Me.LblScheduledDays.Size = New System.Drawing.Size(115, 17)
        Me.LblScheduledDays.TabIndex = 10
        Me.LblScheduledDays.Text = "Scheduled Days:"
        '
        'CLBGoals
        '
        Me.CLBGoals.FormattingEnabled = True
        Me.CLBGoals.Location = New System.Drawing.Point(279, 127)
        Me.CLBGoals.Margin = New System.Windows.Forms.Padding(4)
        Me.CLBGoals.Name = "CLBGoals"
        Me.CLBGoals.Size = New System.Drawing.Size(242, 225)
        Me.CLBGoals.TabIndex = 11
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(351, 360)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(100, 28)
        Me.BtnUpdate.TabIndex = 12
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'LblStartTime
        '
        Me.LblStartTime.AutoSize = True
        Me.LblStartTime.Location = New System.Drawing.Point(541, 325)
        Me.LblStartTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStartTime.Name = "LblStartTime"
        Me.LblStartTime.Size = New System.Drawing.Size(96, 17)
        Me.LblStartTime.TabIndex = 13
        Me.LblStartTime.Text = "Starting Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(574, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 29)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Schedule"
        '
        'FrmViewActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 399)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblStartTime)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.CLBGoals)
        Me.Controls.Add(Me.LblScheduledDays)
        Me.Controls.Add(Me.Lblgoals)
        Me.Controls.Add(Me.Lbldesc)
        Me.Controls.Add(Me.LblActType)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.btnback)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmViewActivity"
        Me.Text = "FrmEditActivity"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnback As Button
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents LblName As Label
    Friend WithEvents LblActType As Label
    Friend WithEvents Lbldesc As Label
    Friend WithEvents Lblgoals As Label
    Friend WithEvents LblScheduledDays As Label
    Friend WithEvents CLBGoals As CheckedListBox
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents LblStartTime As Label
    Friend WithEvents Label2 As Label
End Class
