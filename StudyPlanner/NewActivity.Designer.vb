<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewActivity
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
        Me.TxtActName = New System.Windows.Forms.TextBox()
        Me.CBoxActType = New System.Windows.Forms.ComboBox()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.RbtnRegular = New System.Windows.Forms.RadioButton()
        Me.RbtnFlexible = New System.Windows.Forms.RadioButton()
        Me.LblGoals = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LblActLen = New System.Windows.Forms.Label()
        Me.LblChooseDays = New System.Windows.Forms.Label()
        Me.LblChooseTime = New System.Windows.Forms.Label()
        Me.RbtnSelfSelect = New System.Windows.Forms.RadioButton()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.LblPriority = New System.Windows.Forms.Label()
        Me.BtnCreateAct = New System.Windows.Forms.Button()
        Me.NumUDHour = New System.Windows.Forms.NumericUpDown()
        Me.NumUDMin = New System.Windows.Forms.NumericUpDown()
        Me.LblH = New System.Windows.Forms.Label()
        Me.LblM = New System.Windows.Forms.Label()
        Me.LboxDays = New System.Windows.Forms.ListBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lbldash = New System.Windows.Forms.Label()
        Me.TxtGoal1 = New System.Windows.Forms.TextBox()
        Me.TxtGoal2 = New System.Windows.Forms.TextBox()
        Me.TxtGoal3 = New System.Windows.Forms.TextBox()
        Me.TxtGoal5 = New System.Windows.Forms.TextBox()
        Me.TxtGoal4 = New System.Windows.Forms.TextBox()
        Me.LblGoal1 = New System.Windows.Forms.Label()
        Me.LblGoal2 = New System.Windows.Forms.Label()
        Me.LblGoal3 = New System.Windows.Forms.Label()
        Me.LblGoal4 = New System.Windows.Forms.Label()
        Me.LblGoal5 = New System.Windows.Forms.Label()
        Me.InfoRT = New System.Windows.Forms.Label()
        Me.InfoFT = New System.Windows.Forms.Label()
        Me.InfoSST = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBoxReminder = New System.Windows.Forms.CheckBox()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUDHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUDMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtActName
        '
        Me.TxtActName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtActName.Location = New System.Drawing.Point(97, 21)
        Me.TxtActName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtActName.Name = "TxtActName"
        Me.TxtActName.Size = New System.Drawing.Size(230, 22)
        Me.TxtActName.TabIndex = 0
        '
        'CBoxActType
        '
        Me.CBoxActType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxActType.FormattingEnabled = True
        Me.CBoxActType.Location = New System.Drawing.Point(31, 50)
        Me.CBoxActType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBoxActType.Name = "CBoxActType"
        Me.CBoxActType.Size = New System.Drawing.Size(295, 26)
        Me.CBoxActType.TabIndex = 1
        Me.CBoxActType.Text = "Type of Activity"
        '
        'TxtDescription
        '
        Me.TxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescription.Location = New System.Drawing.Point(32, 112)
        Me.TxtDescription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(295, 240)
        Me.TxtDescription.TabIndex = 2
        '
        'RbtnRegular
        '
        Me.RbtnRegular.AutoSize = True
        Me.RbtnRegular.Location = New System.Drawing.Point(31, 369)
        Me.RbtnRegular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RbtnRegular.Name = "RbtnRegular"
        Me.RbtnRegular.Size = New System.Drawing.Size(121, 21)
        Me.RbtnRegular.TabIndex = 4
        Me.RbtnRegular.TabStop = True
        Me.RbtnRegular.Text = "Regular Times"
        Me.RbtnRegular.UseVisualStyleBackColor = True
        '
        'RbtnFlexible
        '
        Me.RbtnFlexible.AutoSize = True
        Me.RbtnFlexible.Location = New System.Drawing.Point(249, 369)
        Me.RbtnFlexible.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RbtnFlexible.Name = "RbtnFlexible"
        Me.RbtnFlexible.Size = New System.Drawing.Size(122, 21)
        Me.RbtnFlexible.TabIndex = 5
        Me.RbtnFlexible.TabStop = True
        Me.RbtnFlexible.Text = "Flexible Times "
        Me.RbtnFlexible.UseVisualStyleBackColor = True
        '
        'LblGoals
        '
        Me.LblGoals.AutoSize = True
        Me.LblGoals.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGoals.Location = New System.Drawing.Point(419, 78)
        Me.LblGoals.Name = "LblGoals"
        Me.LblGoals.Size = New System.Drawing.Size(90, 32)
        Me.LblGoals.TabIndex = 7
        Me.LblGoals.Text = "Goals"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "HH:mm"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(109, 437)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 11
        Me.DateTimePicker1.Value = New Date(2021, 2, 10, 0, 0, 0, 0)
        Me.DateTimePicker1.Visible = False
        '
        'LblActLen
        '
        Me.LblActLen.AutoSize = True
        Me.LblActLen.Location = New System.Drawing.Point(45, 465)
        Me.LblActLen.Name = "LblActLen"
        Me.LblActLen.Size = New System.Drawing.Size(52, 17)
        Me.LblActLen.TabIndex = 13
        Me.LblActLen.Text = "Length"
        Me.LblActLen.Visible = False
        '
        'LblChooseDays
        '
        Me.LblChooseDays.AutoSize = True
        Me.LblChooseDays.Location = New System.Drawing.Point(12, 410)
        Me.LblChooseDays.Name = "LblChooseDays"
        Me.LblChooseDays.Size = New System.Drawing.Size(92, 17)
        Me.LblChooseDays.TabIndex = 14
        Me.LblChooseDays.Text = "Choose Days"
        Me.LblChooseDays.Visible = False
        '
        'LblChooseTime
        '
        Me.LblChooseTime.AutoSize = True
        Me.LblChooseTime.Location = New System.Drawing.Point(12, 437)
        Me.LblChooseTime.Name = "LblChooseTime"
        Me.LblChooseTime.Size = New System.Drawing.Size(91, 17)
        Me.LblChooseTime.TabIndex = 15
        Me.LblChooseTime.Text = "Choose Time"
        Me.LblChooseTime.Visible = False
        '
        'RbtnSelfSelect
        '
        Me.RbtnSelfSelect.AutoSize = True
        Me.RbtnSelfSelect.Location = New System.Drawing.Point(447, 369)
        Me.RbtnSelfSelect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RbtnSelfSelect.Name = "RbtnSelfSelect"
        Me.RbtnSelfSelect.Size = New System.Drawing.Size(154, 21)
        Me.RbtnSelfSelect.TabIndex = 6
        Me.RbtnSelfSelect.TabStop = True
        Me.RbtnSelfSelect.Text = "Self Selected Times"
        Me.RbtnSelfSelect.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(109, 503)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(449, 56)
        Me.TrackBar1.TabIndex = 16
        Me.TrackBar1.Visible = False
        '
        'LblPriority
        '
        Me.LblPriority.AutoSize = True
        Me.LblPriority.Location = New System.Drawing.Point(45, 503)
        Me.LblPriority.Name = "LblPriority"
        Me.LblPriority.Size = New System.Drawing.Size(52, 17)
        Me.LblPriority.TabIndex = 18
        Me.LblPriority.Text = "Priority"
        Me.LblPriority.Visible = False
        '
        'BtnCreateAct
        '
        Me.BtnCreateAct.BackColor = System.Drawing.Color.Tomato
        Me.BtnCreateAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreateAct.Location = New System.Drawing.Point(335, 21)
        Me.BtnCreateAct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCreateAct.Name = "BtnCreateAct"
        Me.BtnCreateAct.Size = New System.Drawing.Size(267, 53)
        Me.BtnCreateAct.TabIndex = 19
        Me.BtnCreateAct.Text = "Create Activity"
        Me.BtnCreateAct.UseVisualStyleBackColor = False
        '
        'NumUDHour
        '
        Me.NumUDHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumUDHour.Location = New System.Drawing.Point(109, 465)
        Me.NumUDHour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumUDHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NumUDHour.Name = "NumUDHour"
        Me.NumUDHour.Size = New System.Drawing.Size(50, 22)
        Me.NumUDHour.TabIndex = 20
        Me.NumUDHour.Visible = False
        '
        'NumUDMin
        '
        Me.NumUDMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumUDMin.Location = New System.Drawing.Point(183, 465)
        Me.NumUDMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumUDMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumUDMin.Name = "NumUDMin"
        Me.NumUDMin.Size = New System.Drawing.Size(56, 22)
        Me.NumUDMin.TabIndex = 21
        Me.NumUDMin.Visible = False
        '
        'LblH
        '
        Me.LblH.AutoSize = True
        Me.LblH.Location = New System.Drawing.Point(165, 465)
        Me.LblH.Name = "LblH"
        Me.LblH.Size = New System.Drawing.Size(18, 17)
        Me.LblH.TabIndex = 22
        Me.LblH.Text = "H"
        Me.LblH.Visible = False
        '
        'LblM
        '
        Me.LblM.AutoSize = True
        Me.LblM.Location = New System.Drawing.Point(245, 467)
        Me.LblM.Name = "LblM"
        Me.LblM.Size = New System.Drawing.Size(19, 17)
        Me.LblM.TabIndex = 23
        Me.LblM.Text = "M"
        Me.LblM.Visible = False
        '
        'LboxDays
        '
        Me.LboxDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LboxDays.FormattingEnabled = True
        Me.LboxDays.ItemHeight = 16
        Me.LboxDays.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.LboxDays.Location = New System.Drawing.Point(109, 396)
        Me.LboxDays.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LboxDays.Name = "LboxDays"
        Me.LboxDays.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.LboxDays.Size = New System.Drawing.Size(347, 34)
        Me.LboxDays.TabIndex = 24
        Me.LboxDays.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "HH:mm"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(341, 438)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.ShowUpDown = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker2.TabIndex = 25
        Me.DateTimePicker2.Value = New Date(2021, 2, 10, 0, 0, 0, 0)
        Me.DateTimePicker2.Visible = False
        '
        'lbldash
        '
        Me.lbldash.AutoSize = True
        Me.lbldash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldash.Location = New System.Drawing.Point(316, 434)
        Me.lbldash.Name = "lbldash"
        Me.lbldash.Size = New System.Drawing.Size(19, 25)
        Me.lbldash.TabIndex = 26
        Me.lbldash.Text = "-"
        Me.lbldash.Visible = False
        '
        'TxtGoal1
        '
        Me.TxtGoal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGoal1.Location = New System.Drawing.Point(357, 112)
        Me.TxtGoal1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtGoal1.Name = "TxtGoal1"
        Me.TxtGoal1.Size = New System.Drawing.Size(245, 22)
        Me.TxtGoal1.TabIndex = 27
        '
        'TxtGoal2
        '
        Me.TxtGoal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGoal2.Location = New System.Drawing.Point(357, 165)
        Me.TxtGoal2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtGoal2.Name = "TxtGoal2"
        Me.TxtGoal2.Size = New System.Drawing.Size(245, 22)
        Me.TxtGoal2.TabIndex = 28
        '
        'TxtGoal3
        '
        Me.TxtGoal3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGoal3.Location = New System.Drawing.Point(357, 224)
        Me.TxtGoal3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtGoal3.Name = "TxtGoal3"
        Me.TxtGoal3.Size = New System.Drawing.Size(245, 22)
        Me.TxtGoal3.TabIndex = 29
        '
        'TxtGoal5
        '
        Me.TxtGoal5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGoal5.Location = New System.Drawing.Point(357, 332)
        Me.TxtGoal5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtGoal5.Name = "TxtGoal5"
        Me.TxtGoal5.Size = New System.Drawing.Size(245, 22)
        Me.TxtGoal5.TabIndex = 30
        '
        'TxtGoal4
        '
        Me.TxtGoal4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGoal4.Location = New System.Drawing.Point(357, 281)
        Me.TxtGoal4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtGoal4.Name = "TxtGoal4"
        Me.TxtGoal4.Size = New System.Drawing.Size(245, 22)
        Me.TxtGoal4.TabIndex = 31
        '
        'LblGoal1
        '
        Me.LblGoal1.AutoSize = True
        Me.LblGoal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblGoal1.Location = New System.Drawing.Point(332, 114)
        Me.LblGoal1.Name = "LblGoal1"
        Me.LblGoal1.Size = New System.Drawing.Size(18, 19)
        Me.LblGoal1.TabIndex = 32
        Me.LblGoal1.Text = "1"
        '
        'LblGoal2
        '
        Me.LblGoal2.AutoSize = True
        Me.LblGoal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblGoal2.Location = New System.Drawing.Point(332, 167)
        Me.LblGoal2.Name = "LblGoal2"
        Me.LblGoal2.Size = New System.Drawing.Size(18, 19)
        Me.LblGoal2.TabIndex = 33
        Me.LblGoal2.Text = "2"
        '
        'LblGoal3
        '
        Me.LblGoal3.AutoSize = True
        Me.LblGoal3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblGoal3.Location = New System.Drawing.Point(332, 229)
        Me.LblGoal3.Name = "LblGoal3"
        Me.LblGoal3.Size = New System.Drawing.Size(18, 19)
        Me.LblGoal3.TabIndex = 34
        Me.LblGoal3.Text = "3"
        '
        'LblGoal4
        '
        Me.LblGoal4.AutoSize = True
        Me.LblGoal4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblGoal4.Location = New System.Drawing.Point(332, 281)
        Me.LblGoal4.Name = "LblGoal4"
        Me.LblGoal4.Size = New System.Drawing.Size(18, 19)
        Me.LblGoal4.TabIndex = 35
        Me.LblGoal4.Text = "4"
        '
        'LblGoal5
        '
        Me.LblGoal5.AutoSize = True
        Me.LblGoal5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblGoal5.Location = New System.Drawing.Point(333, 332)
        Me.LblGoal5.Name = "LblGoal5"
        Me.LblGoal5.Size = New System.Drawing.Size(18, 19)
        Me.LblGoal5.TabIndex = 36
        Me.LblGoal5.Text = "5"
        '
        'InfoRT
        '
        Me.InfoRT.AutoSize = True
        Me.InfoRT.BackColor = System.Drawing.SystemColors.Info
        Me.InfoRT.Location = New System.Drawing.Point(165, 370)
        Me.InfoRT.Name = "InfoRT"
        Me.InfoRT.Size = New System.Drawing.Size(11, 17)
        Me.InfoRT.TabIndex = 37
        Me.InfoRT.Text = "i"
        '
        'InfoFT
        '
        Me.InfoFT.AutoSize = True
        Me.InfoFT.BackColor = System.Drawing.SystemColors.Info
        Me.InfoFT.Location = New System.Drawing.Point(377, 370)
        Me.InfoFT.Name = "InfoFT"
        Me.InfoFT.Size = New System.Drawing.Size(11, 17)
        Me.InfoFT.TabIndex = 38
        Me.InfoFT.Text = "i"
        '
        'InfoSST
        '
        Me.InfoSST.AutoSize = True
        Me.InfoSST.BackColor = System.Drawing.SystemColors.Info
        Me.InfoSST.Location = New System.Drawing.Point(607, 369)
        Me.InfoSST.Name = "InfoSST"
        Me.InfoSST.Size = New System.Drawing.Size(11, 17)
        Me.InfoSST.TabIndex = 39
        Me.InfoSST.Text = "i"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label1.Location = New System.Drawing.Point(69, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Activity Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 25)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Name"
        '
        'CheckBoxReminder
        '
        Me.CheckBoxReminder.AutoSize = True
        Me.CheckBoxReminder.Location = New System.Drawing.Point(489, 406)
        Me.CheckBoxReminder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxReminder.Name = "CheckBoxReminder"
        Me.CheckBoxReminder.Size = New System.Drawing.Size(91, 21)
        Me.CheckBoxReminder.TabIndex = 43
        Me.CheckBoxReminder.Text = "Reminder"
        Me.CheckBoxReminder.UseVisualStyleBackColor = True
        Me.CheckBoxReminder.Visible = False
        '
        'NewActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 545)
        Me.Controls.Add(Me.CheckBoxReminder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InfoSST)
        Me.Controls.Add(Me.InfoFT)
        Me.Controls.Add(Me.InfoRT)
        Me.Controls.Add(Me.LblGoal5)
        Me.Controls.Add(Me.LblGoal4)
        Me.Controls.Add(Me.LblGoal3)
        Me.Controls.Add(Me.LblGoal2)
        Me.Controls.Add(Me.LblGoal1)
        Me.Controls.Add(Me.TxtGoal4)
        Me.Controls.Add(Me.TxtGoal5)
        Me.Controls.Add(Me.TxtGoal3)
        Me.Controls.Add(Me.TxtGoal2)
        Me.Controls.Add(Me.TxtGoal1)
        Me.Controls.Add(Me.lbldash)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.LboxDays)
        Me.Controls.Add(Me.LblM)
        Me.Controls.Add(Me.LblH)
        Me.Controls.Add(Me.NumUDMin)
        Me.Controls.Add(Me.NumUDHour)
        Me.Controls.Add(Me.BtnCreateAct)
        Me.Controls.Add(Me.LblPriority)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.LblChooseTime)
        Me.Controls.Add(Me.LblChooseDays)
        Me.Controls.Add(Me.LblActLen)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LblGoals)
        Me.Controls.Add(Me.RbtnSelfSelect)
        Me.Controls.Add(Me.RbtnFlexible)
        Me.Controls.Add(Me.RbtnRegular)
        Me.Controls.Add(Me.TxtDescription)
        Me.Controls.Add(Me.CBoxActType)
        Me.Controls.Add(Me.TxtActName)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "NewActivity"
        Me.Text = "New Activity"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUDHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUDMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtActName As TextBox
    Friend WithEvents CBoxActType As ComboBox
    Friend WithEvents TxtDescription As TextBox
    Friend WithEvents RbtnRegular As RadioButton
    Friend WithEvents RbtnFlexible As RadioButton
    Friend WithEvents LblGoals As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LblActLen As Label
    Friend WithEvents LblChooseDays As Label
    Friend WithEvents LblChooseTime As Label
    Friend WithEvents RbtnSelfSelect As RadioButton
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents LblPriority As Label
    Friend WithEvents BtnCreateAct As Button
    Friend WithEvents NumUDHour As NumericUpDown
    Friend WithEvents NumUDMin As NumericUpDown
    Friend WithEvents LblH As Label
    Friend WithEvents LblM As Label
    Friend WithEvents LboxDays As ListBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents lbldash As Label
    Friend WithEvents TxtGoal1 As TextBox
    Friend WithEvents TxtGoal2 As TextBox
    Friend WithEvents TxtGoal3 As TextBox
    Friend WithEvents TxtGoal5 As TextBox
    Friend WithEvents TxtGoal4 As TextBox
    Friend WithEvents LblGoal1 As Label
    Friend WithEvents LblGoal2 As Label
    Friend WithEvents LblGoal3 As Label
    Friend WithEvents LblGoal4 As Label
    Friend WithEvents LblGoal5 As Label
    Friend WithEvents InfoRT As Label
    Friend WithEvents InfoFT As Label
    Friend WithEvents InfoSST As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBoxReminder As CheckBox
End Class
