<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeFrm
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
        Me.DGVTodo = New System.Windows.Forms.DataGridView()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Todo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CLBTasks = New System.Windows.Forms.CheckedListBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAnalytics = New System.Windows.Forms.Button()
        Me.Navbar1 = New StudyPlanner.Navbar()
        Me.BtnNewTask = New System.Windows.Forms.Button()
        CType(Me.DGVTodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVTodo
        '
        Me.DGVTodo.AllowUserToAddRows = False
        Me.DGVTodo.AllowUserToDeleteRows = False
        Me.DGVTodo.AllowUserToResizeColumns = False
        Me.DGVTodo.AllowUserToResizeRows = False
        Me.DGVTodo.BackgroundColor = System.Drawing.Color.PapayaWhip
        Me.DGVTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTodo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Time, Me.Todo})
        Me.DGVTodo.Location = New System.Drawing.Point(13, 62)
        Me.DGVTodo.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVTodo.Name = "DGVTodo"
        Me.DGVTodo.RowHeadersVisible = False
        Me.DGVTodo.RowHeadersWidth = 51
        Me.DGVTodo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVTodo.Size = New System.Drawing.Size(375, 310)
        Me.DGVTodo.TabIndex = 0
        '
        'Time
        '
        Me.Time.HeaderText = "Time"
        Me.Time.MinimumWidth = 6
        Me.Time.Name = "Time"
        Me.Time.ReadOnly = True
        Me.Time.Width = 125
        '
        'Todo
        '
        Me.Todo.HeaderText = "To-do"
        Me.Todo.MinimumWidth = 6
        Me.Todo.Name = "Todo"
        Me.Todo.ReadOnly = True
        Me.Todo.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "To-do for today"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(519, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tasks"
        '
        'CLBTasks
        '
        Me.CLBTasks.FormattingEnabled = True
        Me.CLBTasks.Location = New System.Drawing.Point(423, 62)
        Me.CLBTasks.Margin = New System.Windows.Forms.Padding(4)
        Me.CLBTasks.Name = "CLBTasks"
        Me.CLBTasks.Size = New System.Drawing.Size(293, 310)
        Me.CLBTasks.TabIndex = 3
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 447)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(700, 48)
        Me.ProgressBar1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(224, 407)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Progress for Today"
        '
        'BtnAnalytics
        '
        Me.BtnAnalytics.BackColor = System.Drawing.Color.Coral
        Me.BtnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnalytics.Location = New System.Drawing.Point(16, 399)
        Me.BtnAnalytics.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAnalytics.Name = "BtnAnalytics"
        Me.BtnAnalytics.Size = New System.Drawing.Size(96, 40)
        Me.BtnAnalytics.TabIndex = 7
        Me.BtnAnalytics.Text = "Analytics"
        Me.BtnAnalytics.UseVisualStyleBackColor = False
        '
        'Navbar1
        '
        Me.Navbar1.Location = New System.Drawing.Point(-17, 503)
        Me.Navbar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Navbar1.Name = "Navbar1"
        Me.Navbar1.Size = New System.Drawing.Size(757, 75)
        Me.Navbar1.TabIndex = 9
        '
        'BtnNewTask
        '
        Me.BtnNewTask.BackColor = System.Drawing.Color.Coral
        Me.BtnNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewTask.Location = New System.Drawing.Point(608, 399)
        Me.BtnNewTask.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNewTask.Name = "BtnNewTask"
        Me.BtnNewTask.Size = New System.Drawing.Size(108, 40)
        Me.BtnNewTask.TabIndex = 8
        Me.BtnNewTask.Text = "New Task"
        Me.BtnNewTask.UseVisualStyleBackColor = False
        '
        'HomeFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 580)
        Me.Controls.Add(Me.Navbar1)
        Me.Controls.Add(Me.BtnNewTask)
        Me.Controls.Add(Me.BtnAnalytics)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVTodo)
        Me.Controls.Add(Me.CLBTasks)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HomeFrm"
        Me.Text = "HomeFrm"
        CType(Me.DGVTodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVTodo As DataGridView
    Friend WithEvents Time As DataGridViewTextBoxColumn
    Friend WithEvents Todo As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CLBTasks As CheckedListBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAnalytics As Button
    Friend WithEvents Navbar1 As Navbar
    Friend WithEvents BtnNewTask As Button
End Class
