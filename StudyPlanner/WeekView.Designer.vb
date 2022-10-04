<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeekFrm
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
        Me.DGVWeek = New System.Windows.Forms.DataGridView()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Thu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnUp = New System.Windows.Forms.Button()
        Me.BtnDown = New System.Windows.Forms.Button()
        Me.BtnNextWeek = New System.Windows.Forms.Button()
        Me.BtnPrevWeek = New System.Windows.Forms.Button()
        Me.Lblweekstart = New System.Windows.Forms.Label()
        Me.lblweekend = New System.Windows.Forms.Label()
        Me.O = New System.Windows.Forms.Label()
        Me.BtnMonth = New System.Windows.Forms.Button()
        Me.Navbar1 = New StudyPlanner.Navbar()
        CType(Me.DGVWeek, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVWeek
        '
        Me.DGVWeek.AllowUserToAddRows = False
        Me.DGVWeek.AllowUserToDeleteRows = False
        Me.DGVWeek.AllowUserToResizeColumns = False
        Me.DGVWeek.AllowUserToResizeRows = False
        Me.DGVWeek.ColumnHeadersHeight = 29
        Me.DGVWeek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVWeek.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Time, Me.Mon, Me.Tue, Me.Wed, Me.Thu, Me.Fri, Me.Sat, Me.Sun})
        Me.DGVWeek.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVWeek.Location = New System.Drawing.Point(12, 64)
        Me.DGVWeek.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVWeek.MultiSelect = False
        Me.DGVWeek.Name = "DGVWeek"
        Me.DGVWeek.ReadOnly = True
        Me.DGVWeek.RowHeadersVisible = False
        Me.DGVWeek.RowHeadersWidth = 51
        Me.DGVWeek.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVWeek.RowTemplate.Height = 24
        Me.DGVWeek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVWeek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGVWeek.Size = New System.Drawing.Size(1231, 634)
        Me.DGVWeek.TabIndex = 0
        '
        'Time
        '
        Me.Time.Frozen = True
        Me.Time.HeaderText = "Time"
        Me.Time.MinimumWidth = 6
        Me.Time.Name = "Time"
        Me.Time.ReadOnly = True
        Me.Time.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Time.Width = 125
        '
        'Mon
        '
        Me.Mon.Frozen = True
        Me.Mon.HeaderText = "Mon"
        Me.Mon.MinimumWidth = 6
        Me.Mon.Name = "Mon"
        Me.Mon.ReadOnly = True
        Me.Mon.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Mon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Mon.Width = 125
        '
        'Tue
        '
        Me.Tue.Frozen = True
        Me.Tue.HeaderText = "Tue"
        Me.Tue.MinimumWidth = 6
        Me.Tue.Name = "Tue"
        Me.Tue.ReadOnly = True
        Me.Tue.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Tue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Tue.Width = 125
        '
        'Wed
        '
        Me.Wed.Frozen = True
        Me.Wed.HeaderText = "Wed"
        Me.Wed.MinimumWidth = 6
        Me.Wed.Name = "Wed"
        Me.Wed.ReadOnly = True
        Me.Wed.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Wed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Wed.Width = 125
        '
        'Thu
        '
        Me.Thu.Frozen = True
        Me.Thu.HeaderText = "Thu"
        Me.Thu.MinimumWidth = 6
        Me.Thu.Name = "Thu"
        Me.Thu.ReadOnly = True
        Me.Thu.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Thu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Thu.Width = 125
        '
        'Fri
        '
        Me.Fri.Frozen = True
        Me.Fri.HeaderText = "Fri"
        Me.Fri.MinimumWidth = 6
        Me.Fri.Name = "Fri"
        Me.Fri.ReadOnly = True
        Me.Fri.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Fri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Fri.Width = 125
        '
        'Sat
        '
        Me.Sat.Frozen = True
        Me.Sat.HeaderText = "Sat"
        Me.Sat.MinimumWidth = 6
        Me.Sat.Name = "Sat"
        Me.Sat.ReadOnly = True
        Me.Sat.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Sat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Sat.Width = 125
        '
        'Sun
        '
        Me.Sun.Frozen = True
        Me.Sun.HeaderText = "Sun"
        Me.Sun.MinimumWidth = 6
        Me.Sun.Name = "Sun"
        Me.Sun.ReadOnly = True
        Me.Sun.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Sun.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Sun.Width = 125
        '
        'BtnUp
        '
        Me.BtnUp.Location = New System.Drawing.Point(1249, 64)
        Me.BtnUp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUp.Name = "BtnUp"
        Me.BtnUp.Size = New System.Drawing.Size(75, 69)
        Me.BtnUp.TabIndex = 2
        Me.BtnUp.Text = "/\"
        Me.BtnUp.UseVisualStyleBackColor = True
        '
        'BtnDown
        '
        Me.BtnDown.Location = New System.Drawing.Point(1249, 622)
        Me.BtnDown.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDown.Name = "BtnDown"
        Me.BtnDown.Size = New System.Drawing.Size(75, 78)
        Me.BtnDown.TabIndex = 3
        Me.BtnDown.Text = "\/"
        Me.BtnDown.UseVisualStyleBackColor = True
        '
        'BtnNextWeek
        '
        Me.BtnNextWeek.Location = New System.Drawing.Point(344, 17)
        Me.BtnNextWeek.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnNextWeek.Name = "BtnNextWeek"
        Me.BtnNextWeek.Size = New System.Drawing.Size(123, 42)
        Me.BtnNextWeek.TabIndex = 4
        Me.BtnNextWeek.Text = "Next Week"
        Me.BtnNextWeek.UseVisualStyleBackColor = True
        '
        'BtnPrevWeek
        '
        Me.BtnPrevWeek.Location = New System.Drawing.Point(12, 16)
        Me.BtnPrevWeek.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPrevWeek.Name = "BtnPrevWeek"
        Me.BtnPrevWeek.Size = New System.Drawing.Size(115, 42)
        Me.BtnPrevWeek.TabIndex = 5
        Me.BtnPrevWeek.Text = "Previous Week"
        Me.BtnPrevWeek.UseVisualStyleBackColor = True
        '
        'Lblweekstart
        '
        Me.Lblweekstart.AutoSize = True
        Me.Lblweekstart.Location = New System.Drawing.Point(132, 30)
        Me.Lblweekstart.Name = "Lblweekstart"
        Me.Lblweekstart.Size = New System.Drawing.Size(72, 17)
        Me.Lblweekstart.TabIndex = 6
        Me.Lblweekstart.Text = "Weekstart"
        '
        'lblweekend
        '
        Me.lblweekend.AutoSize = True
        Me.lblweekend.Location = New System.Drawing.Point(247, 30)
        Me.lblweekend.Name = "lblweekend"
        Me.lblweekend.Size = New System.Drawing.Size(68, 17)
        Me.lblweekend.TabIndex = 7
        Me.lblweekend.Text = "Weekend"
        '
        'O
        '
        Me.O.AutoSize = True
        Me.O.Location = New System.Drawing.Point(228, 30)
        Me.O.Name = "O"
        Me.O.Size = New System.Drawing.Size(13, 17)
        Me.O.TabIndex = 8
        Me.O.Text = "-"
        '
        'BtnMonth
        '
        Me.BtnMonth.Location = New System.Drawing.Point(1093, 2)
        Me.BtnMonth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnMonth.Name = "BtnMonth"
        Me.BtnMonth.Size = New System.Drawing.Size(115, 57)
        Me.BtnMonth.TabIndex = 9
        Me.BtnMonth.Text = "Month View"
        Me.BtnMonth.UseVisualStyleBackColor = True
        '
        'Navbar1
        '
        Me.Navbar1.Location = New System.Drawing.Point(260, 704)
        Me.Navbar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Navbar1.Name = "Navbar1"
        Me.Navbar1.Size = New System.Drawing.Size(757, 77)
        Me.Navbar1.TabIndex = 10
        '
        'WeekFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1353, 783)
        Me.Controls.Add(Me.Navbar1)
        Me.Controls.Add(Me.BtnMonth)
        Me.Controls.Add(Me.O)
        Me.Controls.Add(Me.lblweekend)
        Me.Controls.Add(Me.Lblweekstart)
        Me.Controls.Add(Me.BtnPrevWeek)
        Me.Controls.Add(Me.BtnNextWeek)
        Me.Controls.Add(Me.BtnDown)
        Me.Controls.Add(Me.BtnUp)
        Me.Controls.Add(Me.DGVWeek)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "WeekFrm"
        Me.Text = "Calendar"
        CType(Me.DGVWeek, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVWeek As DataGridView
    Friend WithEvents Time As DataGridViewTextBoxColumn
    Friend WithEvents Mon As DataGridViewTextBoxColumn
    Friend WithEvents Tue As DataGridViewTextBoxColumn
    Friend WithEvents Wed As DataGridViewTextBoxColumn
    Friend WithEvents Thu As DataGridViewTextBoxColumn
    Friend WithEvents Fri As DataGridViewTextBoxColumn
    Friend WithEvents Sat As DataGridViewTextBoxColumn
    Friend WithEvents Sun As DataGridViewTextBoxColumn
    Friend WithEvents BtnUp As Button
    Friend WithEvents BtnDown As Button
    Friend WithEvents BtnNextWeek As Button
    Friend WithEvents BtnPrevWeek As Button
    Friend WithEvents Lblweekstart As Label
    Friend WithEvents lblweekend As Label
    Friend WithEvents O As Label
    Friend WithEvents BtnMonth As Button
    Friend WithEvents Navbar1 As Navbar
End Class
