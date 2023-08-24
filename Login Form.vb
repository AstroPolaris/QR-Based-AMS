Imports MySql.Data.MySqlClient


Public Class Login_Form
    Private Sub user_KeyDown(sender As Object, e As KeyEventArgs) Handles user.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub

        End If
        e.SuppressKeyPress = True

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim conn As New MySqlConnection("server=localhost;port=3306;user=root;password=;database=admin_acc;")
            conn.Open()

            ' create SQL command to retrieve user with the entered username and password
            Dim cmd As New MySqlCommand()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM account WHERE BINARY TRIM(username) = @username AND BINARY password = @password"
            cmd.Parameters.AddWithValue("@username", user.Text.Trim())
            cmd.Parameters.AddWithValue("@password", pass.Text)

            ' execute the SQL command and retrieve the user data
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                ' if there is a matching user, show the main form and hide the login form
                Main_Form.Show()
                Me.Hide()
            Else
                ' if there is no matching user, show an error message
                MessageBox.Show("Invalid username or password.")
            End If

            ' close the database connection
            reader.Close()
            conn.Close()


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try
        ' create database connection




    End Sub

    Private Sub pass_KeyDown(sender As Object, e As KeyEventArgs) Handles pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2_Click(Nothing, Nothing)
        Else
            Exit Sub

        End If
        e.SuppressKeyPress = True
    End Sub





    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Register_Form.Show()
        Me.Hide()





    End Sub
    Private Sub ShowPassword(show As Boolean)
        If show Then
            pass.UseSystemPasswordChar = False
        Else
            pass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub showPass_CheckedChanged(sender As Object, e As EventArgs) Handles showPass.CheckedChanged
        ShowPassword(showPass.Checked)
    End Sub

    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize user textbox
        If user.Text = "username" Then
            user.ForeColor = Color.Gray
        Else
            user.ForeColor = Color.Black
        End If

        ' Initialize password textbox
        If pass.Text = "password" Then
            pass.UseSystemPasswordChar = False
            pass.ForeColor = Color.Gray
        Else
            pass.UseSystemPasswordChar = True
            pass.ForeColor = Color.Black
        End If
    End Sub
    Private Sub user_Enter(sender As Object, e As EventArgs) Handles user.Enter
        If user.Text = "username" Then
            user.Text = ""
            user.ForeColor = Color.Black
        End If
    End Sub

    Private Sub user_Leave(sender As Object, e As EventArgs) Handles user.Leave
        If user.Text = "" Then
            user.Text = "username"
            user.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub pass_Enter(sender As Object, e As EventArgs) Handles pass.Enter
        If pass.Text = "password" Then
            pass.Text = ""
            pass.UseSystemPasswordChar = True
            pass.ForeColor = Color.Black
        End If
    End Sub

    Private Sub pass_Leave(sender As Object, e As EventArgs) Handles pass.Leave
        If pass.Text = "" Then
            pass.Text = "password"
            pass.UseSystemPasswordChar = False
            pass.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub pass_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged

    End Sub

    Private Sub user_TextChanged(sender As Object, e As EventArgs) Handles user.TextChanged

    End Sub

    Private Sub pass_KeyUp(sender As Object, e As KeyEventArgs) Handles pass.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub

        End If
        e.SuppressKeyPress = True
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the program?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Close the program
            Me.Close()
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class