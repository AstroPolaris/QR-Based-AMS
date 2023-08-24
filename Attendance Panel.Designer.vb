<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Attendance_Panel
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Attendance_Panel))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.timeLbl = New System.Windows.Forms.Label()
        Me.datestr = New System.Windows.Forms.Label()
        Me.scantxtbox = New System.Windows.Forms.TextBox()
        Me.attendancetbl = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.attendancetbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.timeLbl)
        Me.Panel1.Controls.Add(Me.datestr)
        Me.Panel1.Controls.Add(Me.scantxtbox)
        Me.Panel1.Controls.Add(Me.attendancetbl)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1294, 848)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1125, 768)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Archive"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'timeLbl
        '
        Me.timeLbl.AutoSize = True
        Me.timeLbl.BackColor = System.Drawing.Color.Transparent
        Me.timeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLbl.ForeColor = System.Drawing.Color.White
        Me.timeLbl.Location = New System.Drawing.Point(1066, 65)
        Me.timeLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.timeLbl.Name = "timeLbl"
        Me.timeLbl.Size = New System.Drawing.Size(71, 33)
        Me.timeLbl.TabIndex = 5
        Me.timeLbl.Text = "......."
        '
        'datestr
        '
        Me.datestr.AutoSize = True
        Me.datestr.BackColor = System.Drawing.Color.Transparent
        Me.datestr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datestr.ForeColor = System.Drawing.Color.White
        Me.datestr.Location = New System.Drawing.Point(1066, 14)
        Me.datestr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.datestr.Name = "datestr"
        Me.datestr.Size = New System.Drawing.Size(71, 33)
        Me.datestr.TabIndex = 4
        Me.datestr.Text = "......."
        '
        'scantxtbox
        '
        Me.scantxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scantxtbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.scantxtbox.Location = New System.Drawing.Point(448, 120)
        Me.scantxtbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.scantxtbox.Name = "scantxtbox"
        Me.scantxtbox.Size = New System.Drawing.Size(517, 35)
        Me.scantxtbox.TabIndex = 2
        '
        'attendancetbl
        '
        Me.attendancetbl.AllowUserToAddRows = False
        Me.attendancetbl.AllowUserToDeleteRows = False
        Me.attendancetbl.AllowUserToResizeRows = False
        Me.attendancetbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.attendancetbl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.attendancetbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.attendancetbl.Location = New System.Drawing.Point(54, 205)
        Me.attendancetbl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.attendancetbl.Name = "attendancetbl"
        Me.attendancetbl.RowHeadersWidth = 62
        Me.attendancetbl.Size = New System.Drawing.Size(1184, 553)
        Me.attendancetbl.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(266, 122)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QR CODE"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Attendance_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 848)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Attendance_Panel"
        Me.Text = "Attendance_Panel"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.attendancetbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents timeLbl As Label
    Friend WithEvents datestr As Label
    Friend WithEvents scantxtbox As TextBox
    Friend WithEvents attendancetbl As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
End Class
