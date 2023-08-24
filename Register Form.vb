Imports MySql.Data.MySqlClient

Public Class Register_Form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Login_Form.Show()
    End Sub

    Private Sub Register_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(fullname.Text) OrElse String.IsNullOrEmpty(phonenum.Text) OrElse String.IsNullOrEmpty(user.Text) OrElse String.IsNullOrEmpty(pass.Text) OrElse String.IsNullOrEmpty(cpass.Text) Then
            MessageBox.Show("Please check inputs!")
            Return
        End If
        If pass.Text <> cpass.Text Then
            MessageBox.Show("Passwords do not match.")
            Return
        End If

        ' check if user already exists in the database
        If CheckIfUserExists(user.Text) Then
            MessageBox.Show("User already exists!")
            Return
        End If

        ' insert new user into database
        InsertNewUser(fullname.Text, phonenum.Text, user.Text, pass.Text, cpass.Text)

        ' create student registration table
        CreateStudentRegistrationTable(user.Text)

        ' create attendance table for the user
        CreateAttendanceTable(user.Text)

        MessageBox.Show("Account created successfully!")
        Me.Hide()
        Login_Form.Show()

    End Sub
    Private Sub ShowPassword(show As Boolean)
        If show Then
            pass.UseSystemPasswordChar = False
            cpass.UseSystemPasswordChar = False
        Else
            pass.UseSystemPasswordChar = True
            cpass.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub showPass_CheckedChanged(sender As Object, e As EventArgs) Handles showPass.CheckedChanged
        ShowPassword(showPass.Checked)
    End Sub

    Private Sub fullname_KeyDown(sender As Object, e As KeyEventArgs) Handles fullname.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub

        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub cpass_KeyDown(sender As Object, e As KeyEventArgs) Handles cpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2_Click(Nothing, Nothing)
        Else
            Exit Sub

        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub Button2_KeyUp(sender As Object, e As KeyEventArgs) Handles Button2.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub

        End If
        e.SuppressKeyPress = True
    End Sub
End Class