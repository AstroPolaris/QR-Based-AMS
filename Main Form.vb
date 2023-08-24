

Public Class Main_Form

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Login_Form.Show()
        Me.Close()

    End Sub

    Private Sub homeBttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles homeBttn.Click
        contentPanel.Controls.Clear()
        Home_Panel.TopLevel = False
        Home_Panel.Visible = True
        contentPanel.Controls.Add(Home_Panel)
        Home_Panel.Dock = DockStyle.Fill
        Home_Panel.Show()


    End Sub

    Private Sub registerBttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registerBttn.Click
        contentPanel.Controls.Clear()
        Register_Panel.TopLevel = False
        Register_Panel.Visible = True
        contentPanel.Controls.Add(Register_Panel)
        Register_Panel.Dock = DockStyle.Fill
        Register_Panel.Show()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentBttn.Click
        contentPanel.Controls.Clear()
        Student_Panel.TopLevel = False
        Student_Panel.Visible = True
        contentPanel.Controls.Add(Student_Panel)
        Student_Panel.Dock = DockStyle.Fill
        Student_Panel.Show()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        contentPanel.Controls.Clear()

        Attendance_Panel.TopLevel = False
        Attendance_Panel.Visible = True
        contentPanel.Controls.Add(Attendance_Panel)
        Attendance_Panel.Dock = DockStyle.Fill
        Attendance_Panel.Show()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        contentPanel.Controls.Clear()

        Report_Panel.TopLevel = False
        Report_Panel.Visible = True
        contentPanel.Controls.Add(Report_Panel)
        Report_Panel.Dock = DockStyle.Fill
        Report_Panel.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Login_Form.Show()
            Login_Form.user.Text = ""
            Login_Form.pass.Text = ""

        End If

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class