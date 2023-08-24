Imports MySql.Data.MySqlClient

Public Class Archive_Form


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginBttn.Click

        Dim username As String = user.Text.Trim()
        Dim password As String = pass.Text.Trim()

        ' Replace with your actual default username and password for login
        Dim defaultUsername As String = Login_Form.user.Text
        Dim defaultPassword As String = Login_Form.pass.Text

        If username = defaultUsername AndAlso password = defaultPassword Then
            ' If login is successful, connect to archive_db
            Try
                Using conn As New MySqlConnection("server=localhost; username=root; password=; database=archive_db")
                    conn.Open()
                    ' Load data from archive_db to reporttbl DataGridView in ReportPanel form
                    Dim reportPanel As Report_Panel = CType(Application.OpenForms("Report_Panel"), Report_Panel)
                    reportPanel.LoadDataFromArchiveDb(conn)
                    Dim selectedDate As Date = reportPanel.GetSelectedDate()

                    ' Load attendance data from archive_db for the selected date
                    LoadAttendanceDataFromArchiveDb(selectedDate)
                    Dim rpanel As Report_Panel = Application.OpenForms("Report_Panel")

                    rpanel.SetLoggedInStatus(True)




                    Me.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Sub user_KeyDown(sender As Object, e As KeyEventArgs) Handles user.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub

        End If
        e.SuppressKeyPress = True


    End Sub



    Private Sub pass_KeyDown(sender As Object, e As KeyEventArgs) Handles pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(Nothing, Nothing)
        Else
            Exit Sub

        End If
        e.SuppressKeyPress = True
    End Sub


End Class

Public Class Report_Panel
    Inherits Form

    Public Sub LoadDataFromArchiveDb(conn As MySqlConnection)
        Try
            ' Clear existing data in reporttbl DataGridView
            reporttbl.Rows.Clear()

            ' Determine the archive table name based on today's date
            Dim archiveTableName As String = GetArchiveTableName(DateTime.Today)

            ' Check if the archive table exists in the database
            Dim archiveTableExists As Boolean = CheckIfTableExists(conn, archiveTableName)

            If archiveTableExists Then
                ' Load data from the archive table to the reporttbl DataGridView
                Dim cmd As New MySqlCommand($"SELECT * FROM {archiveTableName}", conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                ' Define columns for the DataGridView
                reporttbl.Columns.Add("StudentNumber", "Student Number")
                reporttbl.Columns.Add("LastName", "Last Name")
                reporttbl.Columns.Add("FirstName", "First Name")
                reporttbl.Columns.Add("MiddleName", "Middle Name")
                reporttbl.Columns.Add("TimeIn", "Time In")
                reporttbl.Columns.Add("TimeOut", "Time Out")
                reporttbl.Columns.Add("dateAttended", "Date")


                While reader.Read()
                    Dim studentNumber As String = reader("STUDENT NUMBER").ToString()
                    Dim lastName As String = reader("LAST NAME").ToString()
                    Dim firstName As String = reader("FIRST NAME").ToString()
                    Dim middleName As String = reader("MIDDLE NAME").ToString()
                    Dim timeIn As TimeSpan = TimeSpan.Parse(reader("TIMEIN").ToString())
                    Dim timeOut As TimeSpan = TimeSpan.Parse(reader("TIMEOUT").ToString())
                    Dim dateAttended As Date = Date.Parse(reader("DATE").ToString())

                    reporttbl.Rows.Add(studentNumber, lastName, firstName, middleName, timeIn, timeOut, dateAttended)
                End While


                reader.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    'Private Function GetArchiveTableName(ByVal dateToUse As Date) As String
    'Return $"attendance_tbl_{dateToUse.ToString("yyyyMMdd")}_{Login_Form.user.Text}"
    'End Function

    Private Function CheckIfTableExists(ByVal conn As MySqlConnection, ByVal tableName As String) As Boolean
        Dim cmd As New MySqlCommand($"SHOW TABLES LIKE '{tableName}'", conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Dim exists As Boolean = reader.HasRows
        reader.Close()
        Return exists
    End Function


End Class



