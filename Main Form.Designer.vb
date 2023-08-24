<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.registerBttn = New System.Windows.Forms.Button()
        Me.homeBttn = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.studentBttn = New System.Windows.Forms.Button()
        Me.contentPanel = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(169, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(210, 222)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 194)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADMINISTRATOR"
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(0, 492)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(210, 54)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "  LOGOUT"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 330)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(210, 54)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "  ATTENDANCE"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'registerBttn
        '
        Me.registerBttn.Dock = System.Windows.Forms.DockStyle.Top
        Me.registerBttn.FlatAppearance.BorderSize = 0
        Me.registerBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registerBttn.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerBttn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.registerBttn.Image = CType(resources.GetObject("registerBttn.Image"), System.Drawing.Image)
        Me.registerBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.registerBttn.Location = New System.Drawing.Point(0, 276)
        Me.registerBttn.Margin = New System.Windows.Forms.Padding(2)
        Me.registerBttn.Name = "registerBttn"
        Me.registerBttn.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.registerBttn.Size = New System.Drawing.Size(210, 54)
        Me.registerBttn.TabIndex = 1
        Me.registerBttn.Text = "  REGISTER"
        Me.registerBttn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.registerBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.registerBttn.UseVisualStyleBackColor = True
        '
        'homeBttn
        '
        Me.homeBttn.Dock = System.Windows.Forms.DockStyle.Top
        Me.homeBttn.FlatAppearance.BorderSize = 0
        Me.homeBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.homeBttn.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeBttn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.homeBttn.Image = CType(resources.GetObject("homeBttn.Image"), System.Drawing.Image)
        Me.homeBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.homeBttn.Location = New System.Drawing.Point(0, 222)
        Me.homeBttn.Margin = New System.Windows.Forms.Padding(2)
        Me.homeBttn.Name = "homeBttn"
        Me.homeBttn.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.homeBttn.Size = New System.Drawing.Size(210, 54)
        Me.homeBttn.TabIndex = 0
        Me.homeBttn.Text = "  HOME"
        Me.homeBttn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.homeBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.homeBttn.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.studentBttn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.registerBttn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.homeBttn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.contentPanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(1076, 551)
        Me.SplitContainer1.SplitterDistance = 210
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 6
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(0, 438)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(210, 54)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "  REPORT"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'studentBttn
        '
        Me.studentBttn.Dock = System.Windows.Forms.DockStyle.Top
        Me.studentBttn.FlatAppearance.BorderSize = 0
        Me.studentBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.studentBttn.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentBttn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.studentBttn.Image = CType(resources.GetObject("studentBttn.Image"), System.Drawing.Image)
        Me.studentBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.studentBttn.Location = New System.Drawing.Point(0, 384)
        Me.studentBttn.Margin = New System.Windows.Forms.Padding(2)
        Me.studentBttn.Name = "studentBttn"
        Me.studentBttn.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.studentBttn.Size = New System.Drawing.Size(210, 54)
        Me.studentBttn.TabIndex = 3
        Me.studentBttn.Text = "  STUDENT"
        Me.studentBttn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.studentBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.studentBttn.UseVisualStyleBackColor = True
        '
        'contentPanel
        '
        Me.contentPanel.BackgroundImage = CType(resources.GetObject("contentPanel.BackgroundImage"), System.Drawing.Image)
        Me.contentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentPanel.Location = New System.Drawing.Point(0, 0)
        Me.contentPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(863, 551)
        Me.contentPanel.TabIndex = 0
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 551)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main_Form"
        Me.Text = "Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents registerBttn As Button
    Friend WithEvents homeBttn As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Button5 As Button
    Friend WithEvents studentBttn As Button
    Friend WithEvents contentPanel As Panel
End Class
