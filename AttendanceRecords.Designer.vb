<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AttendanceRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttendanceRecords))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ttime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.days = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id1, Me.lname, Me.tdate, Me.ttime, Me.stat, Me.days})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 63)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(800, 347)
        Me.DataGridView1.TabIndex = 0
        '
        'id1
        '
        Me.id1.HeaderText = "EMPLOYEE ID"
        Me.id1.Name = "id1"
        '
        'lname
        '
        Me.lname.HeaderText = "DATE"
        Me.lname.Name = "lname"
        '
        'tdate
        '
        Me.tdate.HeaderText = "GROSS PAY"
        Me.tdate.Name = "tdate"
        '
        'ttime
        '
        Me.ttime.HeaderText = "DEDUCTION"
        Me.ttime.Name = "ttime"
        '
        'stat
        '
        Me.stat.HeaderText = "TOTAL PAY"
        Me.stat.Name = "stat"
        '
        'days
        '
        Me.days.HeaderText = "Working Days"
        Me.days.Name = "days"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Corbel", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(10, 14)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(318, 30)
        Me.TextBox1.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Tan
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(331, 14)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(134, 31)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(13, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(835, 433)
        Me.Panel1.TabIndex = 18
        '
        'AttendanceRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(894, 461)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AttendanceRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pay Records"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents id1 As DataGridViewTextBoxColumn
    Friend WithEvents lname As DataGridViewTextBoxColumn
    Friend WithEvents tdate As DataGridViewTextBoxColumn
    Friend WithEvents ttime As DataGridViewTextBoxColumn
    Friend WithEvents stat As DataGridViewTextBoxColumn
    Friend WithEvents days As DataGridViewTextBoxColumn
    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel1 As Panel
End Class
