<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_Panel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Panel))
        Me.studentTable = New System.Windows.Forms.DataGridView()
        Me.savebttn = New System.Windows.Forms.Button()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.studentnum = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.age = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.minitial = New System.Windows.Forms.TextBox()
        Me.sex = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.updateBttn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.studentTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'studentTable
        '
        Me.studentTable.AllowUserToAddRows = False
        Me.studentTable.AllowUserToDeleteRows = False
        Me.studentTable.AllowUserToResizeRows = False
        Me.studentTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.studentTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.studentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.studentTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.studentTable.Location = New System.Drawing.Point(394, 128)
        Me.studentTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.studentTable.Name = "studentTable"
        Me.studentTable.ReadOnly = True
        Me.studentTable.RowHeadersWidth = 62
        Me.studentTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.studentTable.Size = New System.Drawing.Size(887, 652)
        Me.studentTable.TabIndex = 13
        '
        'savebttn
        '
        Me.savebttn.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.savebttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savebttn.Location = New System.Drawing.Point(124, 789)
        Me.savebttn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.savebttn.Name = "savebttn"
        Me.savebttn.Size = New System.Drawing.Size(152, 35)
        Me.savebttn.TabIndex = 15
        Me.savebttn.Text = "SAVE"
        Me.savebttn.UseVisualStyleBackColor = True
        '
        'searchBox
        '
        Me.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.searchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.searchBox.Location = New System.Drawing.Point(801, 74)
        Me.searchBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(480, 26)
        Me.searchBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(696, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SEARCH"
        '
        'studentnum
        '
        Me.studentnum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.studentnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentnum.Location = New System.Drawing.Point(51, 185)
        Me.studentnum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.studentnum.Name = "studentnum"
        Me.studentnum.ReadOnly = True
        Me.studentnum.Size = New System.Drawing.Size(310, 35)
        Me.studentnum.TabIndex = 0
        '
        'lname
        '
        Me.lname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lname.Location = New System.Drawing.Point(51, 288)
        Me.lname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(310, 35)
        Me.lname.TabIndex = 1
        '
        'age
        '
        Me.age.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.age.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age.Location = New System.Drawing.Point(51, 572)
        Me.age.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(310, 35)
        Me.age.TabIndex = 4
        '
        'fname
        '
        Me.fname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fname.Location = New System.Drawing.Point(51, 383)
        Me.fname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(310, 35)
        Me.fname.TabIndex = 2
        '
        'minitial
        '
        Me.minitial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.minitial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minitial.Location = New System.Drawing.Point(51, 477)
        Me.minitial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.minitial.Name = "minitial"
        Me.minitial.Size = New System.Drawing.Size(310, 35)
        Me.minitial.TabIndex = 3
        '
        'sex
        '
        Me.sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sex.FormattingEnabled = True
        Me.sex.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.sex.Location = New System.Drawing.Point(51, 668)
        Me.sex.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sex.Name = "sex"
        Me.sex.Size = New System.Drawing.Size(310, 37)
        Me.sex.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 152)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "STUDENT NUMBER "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 540)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 29)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "AGE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 635)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 29)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "SEX"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 445)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "MIDDLE INITIAL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 351)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 29)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "FIRST NAME"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 255)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 29)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "LAST NAME"
        '
        'updateBttn
        '
        Me.updateBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateBttn.Location = New System.Drawing.Point(124, 745)
        Me.updateBttn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.updateBttn.Name = "updateBttn"
        Me.updateBttn.Size = New System.Drawing.Size(152, 35)
        Me.updateBttn.TabIndex = 14
        Me.updateBttn.Text = "RESET"
        Me.updateBttn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1129, 789)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 35)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "EXPORT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(394, 790)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 35)
        Me.Button2.TabIndex = 18
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Student_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 848)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.updateBttn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sex)
        Me.Controls.Add(Me.minitial)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.studentnum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.savebttn)
        Me.Controls.Add(Me.studentTable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Student_Panel"
        Me.Text = "Student_Panel"
        CType(Me.studentTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents studentTable As DataGridView
    Friend WithEvents savebttn As Button
    Friend WithEvents searchBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents studentnum As TextBox
    Friend WithEvents lname As TextBox
    Friend WithEvents age As TextBox
    Friend WithEvents fname As TextBox
    Friend WithEvents minitial As TextBox
    Friend WithEvents sex As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents updateBttn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
