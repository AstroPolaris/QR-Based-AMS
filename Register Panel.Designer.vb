<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_Panel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register_Panel))
        Me.txtMiddle = New System.Windows.Forms.TextBox()
        Me.qrCodePB = New System.Windows.Forms.PictureBox()
        Me.txtStuNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.generateBttn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.sex = New System.Windows.Forms.ComboBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.qrCodePB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMiddle
        '
        Me.txtMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMiddle.Location = New System.Drawing.Point(45, 302)
        Me.txtMiddle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.Size = New System.Drawing.Size(203, 26)
        Me.txtMiddle.TabIndex = 2
        '
        'qrCodePB
        '
        Me.qrCodePB.Location = New System.Drawing.Point(41, 124)
        Me.qrCodePB.Margin = New System.Windows.Forms.Padding(2)
        Me.qrCodePB.Name = "qrCodePB"
        Me.qrCodePB.Size = New System.Drawing.Size(220, 193)
        Me.qrCodePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.qrCodePB.TabIndex = 0
        Me.qrCodePB.TabStop = False
        '
        'txtStuNumber
        '
        Me.txtStuNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStuNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStuNumber.Location = New System.Drawing.Point(45, 369)
        Me.txtStuNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStuNumber.Name = "txtStuNumber"
        Me.txtStuNumber.Size = New System.Drawing.Size(203, 26)
        Me.txtStuNumber.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(42, 339)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "STUDENT  NO."
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAge.Location = New System.Drawing.Point(367, 226)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(99, 26)
        Me.txtAge.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(363, 197)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "AGE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(363, 120)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "SEX"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(42, 271)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MIDDLE INITIAL:"
        '
        'txtFName
        '
        Me.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFName.Location = New System.Drawing.Point(45, 226)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(203, 26)
        Me.txtFName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(42, 197)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FIRST NAME:"
        '
        'txtLName
        '
        Me.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLName.Location = New System.Drawing.Point(45, 149)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(203, 26)
        Me.txtLName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 120)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LAST NAME:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.qrCodePB)
        Me.Panel2.Controls.Add(Me.generateBttn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(565, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(298, 551)
        Me.Panel2.TabIndex = 0
        '
        'generateBttn
        '
        Me.generateBttn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.generateBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generateBttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generateBttn.Location = New System.Drawing.Point(57, 353)
        Me.generateBttn.Margin = New System.Windows.Forms.Padding(2)
        Me.generateBttn.Name = "generateBttn"
        Me.generateBttn.Size = New System.Drawing.Size(182, 40)
        Me.generateBttn.TabIndex = 0
        Me.generateBttn.Text = "GENERATE QR- CODE"
        Me.generateBttn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.txtStuNumber)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.sex)
        Me.Panel1.Controls.Add(Me.txtAge)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtMiddle)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtFName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtLName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(863, 551)
        Me.Panel1.TabIndex = 4
        '
        'sex
        '
        Me.sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sex.FormattingEnabled = True
        Me.sex.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.sex.Location = New System.Drawing.Point(367, 148)
        Me.sex.Margin = New System.Windows.Forms.Padding(2)
        Me.sex.Name = "sex"
        Me.sex.Size = New System.Drawing.Size(100, 28)
        Me.sex.TabIndex = 4
        '
        'Register_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 551)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register_Panel"
        Me.Text = "Register_Panel"
        CType(Me.qrCodePB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtMiddle As TextBox
    Friend WithEvents qrCodePB As PictureBox
    Friend WithEvents txtStuNumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents generateBttn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents sex As ComboBox
End Class
