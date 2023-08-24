<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home_Panel
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home_Panel))
        Me.visionPB = New System.Windows.Forms.PictureBox()
        Me.missionPB = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.visionPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.missionPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'visionPB
        '
        Me.visionPB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visionPB.Image = CType(resources.GetObject("visionPB.Image"), System.Drawing.Image)
        Me.visionPB.Location = New System.Drawing.Point(0, 0)
        Me.visionPB.Margin = New System.Windows.Forms.Padding(2)
        Me.visionPB.Name = "visionPB"
        Me.visionPB.Size = New System.Drawing.Size(863, 551)
        Me.visionPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.visionPB.TabIndex = 1
        Me.visionPB.TabStop = False
        '
        'missionPB
        '
        Me.missionPB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.missionPB.Image = CType(resources.GetObject("missionPB.Image"), System.Drawing.Image)
        Me.missionPB.Location = New System.Drawing.Point(0, 0)
        Me.missionPB.Margin = New System.Windows.Forms.Padding(2)
        Me.missionPB.Name = "missionPB"
        Me.missionPB.Size = New System.Drawing.Size(863, 551)
        Me.missionPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.missionPB.TabIndex = 0
        Me.missionPB.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.visionPB)
        Me.Panel1.Controls.Add(Me.missionPB)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(863, 551)
        Me.Panel1.TabIndex = 3
        '
        'Home_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 551)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home_Panel"
        Me.Text = "Home_Panel"
        CType(Me.visionPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.missionPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents visionPB As PictureBox
    Friend WithEvents missionPB As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
End Class
