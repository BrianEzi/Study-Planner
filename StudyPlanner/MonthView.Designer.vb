<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MonthFrm
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
        Me.DGVMonth = New System.Windows.Forms.DataGridView()
        Me.Mon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Thu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblMonth = New System.Windows.Forms.Label()
        Me.LblYear = New System.Windows.Forms.Label()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnWeek = New System.Windows.Forms.Button()
        Me.Navbar1 = New StudyPlanner.Navbar()
        CType(Me.DGVMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVMonth
        '
        Me.DGVMonth.AllowUserToAddRows = False
        Me.DGVMonth.AllowUserToDeleteRows = False
        Me.DGVMonth.AllowUserToResizeColumns = False
        Me.DGVMonth.AllowUserToResizeRows = False
        Me.DGVMonth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMonth.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mon, Me.Tue, Me.Wed, Me.Thu, Me.Fri, Me.Sat, Me.Sun})
        Me.DGVMonth.Location = New System.Drawing.Point(12, 80)
        Me.DGVMonth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVMonth.MultiSelect = False
        Me.DGVMonth.Name = "DGVMonth"
        Me.DGVMonth.ReadOnly = True
        Me.DGVMonth.RowHeadersVisible = False
        Me.DGVMonth.RowHeadersWidth = 51
        Me.DGVMonth.RowTemplate.Height = 24
        Me.DGVMonth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGVMonth.Size = New System.Drawing.Size(1004, 486)
        Me.DGVMonth.TabIndex = 0
        '
        'Mon
        '
        Me.Mon.HeaderText = "Mon"
        Me.Mon.MinimumWidth = 6
        Me.Mon.Name = "Mon"
        Me.Mon.ReadOnly = True
        Me.Mon.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Mon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Tue
        '
        Me.Tue.HeaderText = "Tue"
        Me.Tue.MinimumWidth = 6
        Me.Tue.Name = "Tue"
        Me.Tue.ReadOnly = True
        Me.Tue.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Tue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Wed
        '
        Me.Wed.HeaderText = "Wed"
        Me.Wed.MinimumWidth = 6
        Me.Wed.Name = "Wed"
        Me.Wed.ReadOnly = True
        Me.Wed.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Wed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Thu
        '
        Me.Thu.HeaderText = "Thu"
        Me.Thu.MinimumWidth = 6
        Me.Thu.Name = "Thu"
        Me.Thu.ReadOnly = True
        Me.Thu.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Thu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Fri
        '
        Me.Fri.HeaderText = "Fri"
        Me.Fri.MinimumWidth = 6
        Me.Fri.Name = "Fri"
        Me.Fri.ReadOnly = True
        Me.Fri.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Fri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Sat
        '
        Me.Sat.HeaderText = "Sat"
        Me.Sat.MinimumWidth = 6
        Me.Sat.Name = "Sat"
        Me.Sat.ReadOnly = True
        Me.Sat.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Sat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Sun
        '
        Me.Sun.HeaderText = "Sun"
        Me.Sun.MinimumWidth = 6
        Me.Sun.Name = "Sun"
        Me.Sun.ReadOnly = True
        Me.Sun.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Sun.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'LblMonth
        '
        Me.LblMonth.AutoSize = True
        Me.LblMonth.Location = New System.Drawing.Point(91, 32)
        Me.LblMonth.Name = "LblMonth"
        Me.LblMonth.Size = New System.Drawing.Size(77, 17)
        Me.LblMonth.TabIndex = 1
        Me.LblMonth.Text = "September"
        '
        'LblYear
        '
        Me.LblYear.AutoSize = True
        Me.LblYear.Location = New System.Drawing.Point(979, 30)
        Me.LblYear.Name = "LblYear"
        Me.LblYear.Size = New System.Drawing.Size(38, 17)
        Me.LblYear.TabIndex = 2
        Me.LblYear.Text = "Year"
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(173, 30)
        Me.BtnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 23)
        Me.BtnNext.TabIndex = 3
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Location = New System.Drawing.Point(11, 30)
        Me.BtnPrevious.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrevious.TabIndex = 4
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'BtnWeek
        '
        Me.BtnWeek.Location = New System.Drawing.Point(812, 12)
        Me.BtnWeek.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnWeek.Name = "BtnWeek"
        Me.BtnWeek.Size = New System.Drawing.Size(115, 57)
        Me.BtnWeek.TabIndex = 10
        Me.BtnWeek.Text = "Week View"
        Me.BtnWeek.UseVisualStyleBackColor = True
        '
        'Navbar1
        '
        Me.Navbar1.Location = New System.Drawing.Point(143, 574)
        Me.Navbar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Navbar1.Name = "Navbar1"
        Me.Navbar1.Size = New System.Drawing.Size(757, 75)
        Me.Navbar1.TabIndex = 11
        '
        'MonthFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 662)
        Me.Controls.Add(Me.Navbar1)
        Me.Controls.Add(Me.BtnWeek)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.LblYear)
        Me.Controls.Add(Me.LblMonth)
        Me.Controls.Add(Me.DGVMonth)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MonthFrm"
        Me.Text = "Calendar"
        CType(Me.DGVMonth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVMonth As DataGridView
    Friend WithEvents LblMonth As Label
    Friend WithEvents LblYear As Label
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents Mon As DataGridViewTextBoxColumn
    Friend WithEvents Tue As DataGridViewTextBoxColumn
    Friend WithEvents Wed As DataGridViewTextBoxColumn
    Friend WithEvents Thu As DataGridViewTextBoxColumn
    Friend WithEvents Fri As DataGridViewTextBoxColumn
    Friend WithEvents Sat As DataGridViewTextBoxColumn
    Friend WithEvents Sun As DataGridViewTextBoxColumn
    Friend WithEvents BtnWeek As Button
    Friend WithEvents Navbar1 As Navbar
End Class
