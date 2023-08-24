Imports MySql.Data.MySqlClient


Public Class Attendance_Panel

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datestr.Text = Format(Now, "hh:mm:ss tt")


        timeLbl.Text = Format(Now, "MM/dd/yyyy")


    End Sub

    Private Sub Attendance_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        disp()
    End Sub

    Private Sub scantxtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles scantxtbox.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then 'Check if the Enter key is pressed
            Dim studentNumber As String = scantxtbox.Text
            Dim query As String = "SELECT `LAST_NAME`, `FIRST_NAME`, `MIDDLE_NAME` FROM " & Login_Form.user.Text & "_student_reg WHERE `STUDENT_NUMBER` = @studentNumber"

            Try
                Using conn As New MySqlConnection("server=localhost; username=root;" & "password=; database= qrbasedams_db")
                    conn.Open()
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentNumber", studentNumber)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        Dim lastName As String = reader("LAST_NAME").ToString()
                        Dim firstName As String = reader("FIRST_NAME").ToString()
                        Dim middleName As String = reader("MIDDLE_NAME").ToString()

                        reader.Close()

                        cmd = New MySqlCommand("SELECT COUNT(*) FROM " & Login_Form.user.Text & "_attendance WHERE `STUDENT_NUMBER` = @studentNumber AND DATE(`DATE`) = @today", conn)
                        cmd.Parameters.AddWithValue("@studentNumber", studentNumber)
                        cmd.Parameters.AddWithValue("@today", DateTime.Now.Date)
                        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                        If count >= 2 Then
                            MessageBox.Show("This student has already been scanned twice today.")
                        Else
                            If count Mod 2 = 0 Then
                                cmd = New MySqlCommand("INSERT INTO " & Login_Form.user.Text & "_attendance (`STUDENT_NUMBER`, `TIMEIN`, `DATE`) VALUES (@studentNumber, @timeIn, @today)", conn)
                                cmd.Parameters.AddWithValue("@studentNumber", studentNumber)
                                cmd.Parameters.AddWithValue("@lastName", lastName)
                                cmd.Parameters.AddWithValue("@firstName", firstName)
                                cmd.Parameters.AddWithValue("@middleName", middleName)
                                cmd.Parameters.AddWithValue("@timeIn", DateTime.Now.ToString("hh:mm:ss tt"))
                                cmd.Parameters.AddWithValue("@today", DateTime.Now.Date)
                                cmd.ExecuteNonQuery()
                                'MessageBox.Show("TimeIn has been Recorded!")
                                disp()

                            Else
                                cmd = New MySqlCommand("UPDATE " & Login_Form.user.Text & "_attendance SET `TIMEOUT` = @timeOut WHERE `STUDENT_NUMBER` = @studentNumber AND DATE(`DATE`) = @today", conn)
                                cmd.Parameters.AddWithValue("@studentNumber", studentNumber)
                                cmd.Parameters.AddWithValue("@timeOut", DateTime.Now.ToString("hh:mm:ss tt"))
                                cmd.Parameters.AddWithValue("@today", DateTime.Now.Date)
                                cmd.ExecuteNonQuery()
                                ' MessageBox.Show("TimeOut has been Recorded!")
                                disp()
                            End If
                        End If
                    Else
                        MessageBox.Show("No student found with the given number.")
                    End If
                    reader.Close()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                scantxtbox.Text = ""
            End Try
        End If
    End Sub

    Private Sub disp()
        Try
            Dim connectionString As String = "server=localhost;username=root;password=;database=qrbasedams_db"
            Dim query As String = "SELECT a.`STUDENT_NUMBER`, s.`LAST_NAME`, s.`FIRST_NAME`, s.`MIDDLE_NAME`, a.`DATE`, a.`TIMEIN`, a.`TIMEOUT` FROM " & Login_Form.user.Text & "_attendance a INNER JOIN " & Login_Form.user.Text & "_student_reg s ON a.`STUDENT_NUMBER` = s.`STUDENT_NUMBER`"
            Dim dataTable As New DataTable()

            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim command As New MySqlCommand(query, connection)
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(dataTable)
            End Using

            If dataTable.Columns.Count = 7 Then
                ' Set the column header names
                dataTable.Columns(0).ColumnName = "STUDENT NUMBER"
                dataTable.Columns(1).ColumnName = "LAST NAME"
                dataTable.Columns(2).ColumnName = "FIRST NAME"
                dataTable.Columns(3).ColumnName = "MIDDLE NAME"
                dataTable.Columns(4).ColumnName = "DATE"
                dataTable.Columns(5).ColumnName = "TIMEIN"
                dataTable.Columns(6).ColumnName = "TIMEOUT"

                attendancetbl.DataSource = dataTable
            Else
                MessageBox.Show("Error: Not enough columns in attendance table.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MoveAttendanceDataToArchive()
        disp()
    End Sub

    Private Sub attendancetbl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles attendancetbl.CellContentClick

    End Sub

    Private Sub scantxtbox_TextChanged(sender As Object, e As EventArgs) Handles scantxtbox.TextChanged

    End Sub
End Class