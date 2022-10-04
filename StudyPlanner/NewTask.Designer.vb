<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTask
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
        Me.LblDays = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtSub = New System.Windows.Forms.TextBox()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.ChboxReminder = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LblSub = New System.Windows.Forms.Label()
        Me.LboxDays = New System.Windows.Forms.ListBox()
        Me.LblPriority = New System.Windows.Forms.Label()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.ChboxToday = New System.Windows.Forms.CheckBox()
        Me.CboxAnytime = New System.Windows.Forms.CheckBox()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblDays
        '
        Me.LblDays.AutoSize = True
        Me.LblDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LblDays.Location = New System.Drawing.Point(331, 5)
        Me.LblDays.Name = "LblDays"
        Me.LblDays.Size = New System.Drawing.Size(147, 36)
        Me.LblDays.TabIndex = 0
        Me.LblDays.Text = "Pick Days"
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.TxtName.Location = New System.Drawing.Point(115, 12)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(183, 28)
        Me.TxtName.TabIndex = 1
        '
        'TxtSub
        '
        Me.TxtSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSub.Location = New System.Drawing.Point(19, 281)
        Me.TxtSub.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSub.Multiline = True
        Me.TxtSub.Name = "TxtSub"
        Me.TxtSub.Size = New System.Drawing.Size(279, 137)
        Me.TxtSub.TabIndex = 2
        Me.TxtSub.Text = "Each line is 1 subtask"
        '
        'TxtDesc
        '
        Me.TxtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesc.Location = New System.Drawing.Point(12, 44)
        Me.TxtDesc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDesc.Multiline = True
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(285, 194)
        Me.TxtDesc.TabIndex = 3
        Me.TxtDesc.Text = "Description"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(328, 281)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(268, 56)
        Me.TrackBar1.TabIndex = 4
        '
        'ChboxReminder
        '
        Me.ChboxReminder.AutoSize = True
        Me.ChboxReminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ChboxReminder.Location = New System.Drawing.Point(479, 348)
        Me.ChboxReminder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChboxReminder.Name = "ChboxReminder"
        Me.ChboxReminder.Size = New System.Drawing.Size(117, 29)
        Me.ChboxReminder.TabIndex = 5
        Me.ChboxReminder.Text = "Reminder"
        Me.ChboxReminder.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.CustomFormat = "HH:mm"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(339, 351)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 22)
        Me.DateTimePicker1.TabIndex = 6
        Me.DateTimePicker1.Value = New Date(2021, 3, 29, 16, 30, 0, 0)
        '
        'LblSub
        '
        Me.LblSub.AutoSize = True
        Me.LblSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LblSub.Location = New System.Drawing.Point(12, 241)
        Me.LblSub.Name = "LblSub"
        Me.LblSub.Size = New System.Drawing.Size(138, 36)
        Me.LblSub.TabIndex = 7
        Me.LblSub.Text = "Subtasks"
        '
        'LboxDays
        '
        Me.LboxDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LboxDays.FormattingEnabled = True
        Me.LboxDays.ItemHeight = 25
        Me.LboxDays.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.LboxDays.Location = New System.Drawing.Point(328, 44)
        Me.LboxDays.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LboxDays.Name = "LboxDays"
        Me.LboxDays.Size = New System.Drawing.Size(268, 129)
        Me.LboxDays.TabIndex = 8
        '
        'LblPriority
        '
        Me.LblPriority.AutoSize = True
        Me.LblPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LblPriority.Location = New System.Drawing.Point(389, 241)
        Me.LblPriority.Name = "LblPriority"
        Me.LblPriority.Size = New System.Drawing.Size(109, 36)
        Me.LblPriority.TabIndex = 10
        Me.LblPriority.Text = "Priority"
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnCreate.Location = New System.Drawing.Point(233, 446)
        Me.BtnCreate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(153, 46)
        Me.BtnCreate.TabIndex = 11
        Me.BtnCreate.Text = "Create Task"
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'ChboxToday
        '
        Me.ChboxToday.AutoSize = True
        Me.ChboxToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ChboxToday.Location = New System.Drawing.Point(328, 209)
        Me.ChboxToday.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChboxToday.Name = "ChboxToday"
        Me.ChboxToday.Size = New System.Drawing.Size(132, 29)
        Me.ChboxToday.TabIndex = 12
        Me.ChboxToday.Text = "Just Today"
        Me.ChboxToday.UseVisualStyleBackColor = True
        '
        'CboxAnytime
        '
        Me.CboxAnytime.AutoSize = True
        Me.CboxAnytime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CboxAnytime.Location = New System.Drawing.Point(337, 388)
        Me.CboxAnytime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboxAnytime.Name = "CboxAnytime"
        Me.CboxAnytime.Size = New System.Drawing.Size(118, 29)
        Me.CboxAnytime.TabIndex = 13
        Me.CboxAnytime.Text = "Any Time"
        Me.CboxAnytime.UseVisualStyleBackColor = True
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lbltime.Location = New System.Drawing.Point(419, 313)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(79, 36)
        Me.lbltime.TabIndex = 14
        Me.lbltime.Text = "Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 36)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Name"
        '
        'NewTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 502)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.CboxAnytime)
        Me.Controls.Add(Me.ChboxToday)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.LblPriority)
        Me.Controls.Add(Me.LboxDays)
        Me.Controls.Add(Me.LblSub)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ChboxReminder)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.TxtDesc)
        Me.Controls.Add(Me.TxtSub)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LblDays)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "NewTask"
        Me.Text = "NewTask"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDays As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtSub As TextBox
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents ChboxReminder As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LblSub As Label
    Friend WithEvents LboxDays As ListBox
    Friend WithEvents LblPriority As Label
    Friend WithEvents BtnCreate As Button
    Friend WithEvents ChboxToday As CheckBox
    Friend WithEvents CboxAnytime As CheckBox
    Friend WithEvents lbltime As Label
    Friend WithEvents Label1 As Label
End Class
