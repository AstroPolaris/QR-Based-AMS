Imports MySql.Data.MySqlClient

Module ArchiveDatabaseModule
    Public Const ArchiveDbConnectionString As String = "server=localhost; username=root; password=; database=archive_db"

    Public Sub MoveAttendanceDataToArchive()
        Dim archiveTableName As String = GetArchiveTableName(DateTime.Today)
        Dim archiveTableExists As Boolean = CheckIfTableExists(archiveTableName)

        Try
            Using conn As New MySqlConnection("server=localhost; username=root; password=; database=qrbasedams_db")
                conn.Open()
                Dim query As String = $"SELECT a.`STUDENT_NUMBER`, s.`LAST_NAME`, s.`FIRST_NAME`, s.`MIDDLE_NAME`, a.`DATE`, a.`TIMEIN`, a.`TIMEOUT` FROM {Login_Form.user.Text}_attendance a INNER JOIN {Login_Form.user.Text}_student_reg s ON a.`STUDENT_NUMBER` = s.`STUDENT_NUMBER`"
                Dim cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    Using conn2 As New MySqlConnection(ArchiveDbConnectionString)
                        conn2.Open()
                        While reader.Read()
                            Dim studentNumber As String = reader("STUDENT_NUMBER").ToString()
                            Dim lastName As String = reader("LAST_NAME").ToString()
                            Dim firstName As String = reader("FIRST_NAME").ToString()
                            Dim middleName As String = reader("MIDDLE_NAME").ToString()
                            Dim timeIn As TimeSpan
                            Dim timeOut As TimeSpan
                            Dim dateAttended As Date = Date.Parse(reader("DATE").ToString())
                            If TimeSpan.TryParse(reader("TIMEIN").ToString(), timeIn) AndAlso TimeSpan.TryParse(reader("TIMEOUT").ToString(), timeOut) Then
                                ' Create archive table if it doesn't exist
                                If Not archiveTableExists Then
                                    CreateArchiveTable(archiveTableName)
                                    archiveTableExists = True
                                End If

                                Dim cmd2 As New MySqlCommand($"INSERT INTO {archiveTableName} (`STUDENT NUMBER`, `LAST NAME`, `FIRST NAME`, `MIDDLE NAME`, `TIMEIN`, `TIMEOUT`, `DATE`) VALUES (@studentNumber, @lastName, @firstName, @middleName, @timeIn, @timeOut, @dateAttended)", conn2)

                                cmd2.Parameters.AddWithValue("@studentNumber", studentNumber)
                                cmd2.Parameters.AddWithValue("@lastName", lastName)
                                cmd2.Parameters.AddWithValue("@firstName", firstName)
                                cmd2.Parameters.AddWithValue("@middleName", middleName)
                                cmd2.Parameters.AddWithValue("@timeIn", timeIn)
                                cmd2.Parameters.AddWithValue("@timeOut", timeOut)
                                cmd2.Parameters.AddWithValue("@dateAttended", dateAttended)

                                cmd2.ExecuteNonQuery()
                            Else
                                MessageBox.Show("Error: Invalid format for time data.")
                            End If
                        End While

                        reader.Close()
                    End Using

                    ' Delete data from the current attendance table
                    query = $"DELETE FROM {Login_Form.user.Text}_attendance"
                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Attendance data has been successfully moved to the archive database.")
                Else
                    MessageBox.Show("There is no data to move to the archive database.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Public Function GetArchiveTableName(ByVal dateToUse As Date) As String
        Return $"attendance_tbl_{dateToUse.ToString("yyyyMMdd")}_{Login_Form.user.Text}"
    End Function

    Public Function CheckIfTableExists(ByVal tableName As String) As Boolean
        Using conn As New MySqlConnection(ArchiveDbConnectionString)
            conn.Open()
            Dim cmd As New MySqlCommand($"SHOW TABLES LIKE '{tableName}'", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim exists As Boolean = reader.HasRows
            reader.Close()
            Return exists
        End Using
    End Function
    Private Sub CreateArchiveTable(ByVal tableName As String)
        Using conn As New MySqlConnection(ArchiveDbConnectionString)
            conn.Open()
            Dim cmd As New MySqlCommand($"CREATE TABLE {tableName} (`ID` INT NOT NULL AUTO_INCREMENT, `STUDENT NUMBER` VARCHAR(50) NOT NULL, `LAST NAME` VARCHAR(150) NOT NULL, `FIRST NAME` VARCHAR(150) NOT NULL, `MIDDLE NAME` VARCHAR(50), `TIMEIN` TIME NOT NULL, `TIMEOUT` TIME NOT NULL, `DATE` DATE NOT NULL, PRIMARY KEY(`ID`))", conn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub LoadAttendanceDataFromArchiveDb(selectedDate As Date) 'DateTimePicker
        Try
            Using conn As New MySqlConnection("server=localhost; username=root; password=; database=archive_db")
                conn.Open()

                ' Determine the archive table name based on the selected date
                Dim archiveTableName As String = GetArchiveTableName(selectedDate)

                ' Check if the archive table exists
                Dim archiveTableExists As Boolean = CheckIfTableExists(archiveTableName)

                If archiveTableExists Then
                    ' Select data from the attendance table in the archive database based on the selected date
                    Dim cmd As New MySqlCommand($"SELECT * FROM {archiveTableName} WHERE DATE = @selectedDate", conn)
                    cmd.Parameters.AddWithValue("@selectedDate", selectedDate)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    ' Clear existing data in reporttbl DataGridView
                    Report_Panel.reporttbl.Rows.Clear()

                    ' Load the selected data to reporttbl DataGridView
                    While reader.Read()
                        Dim studentNumber As String = reader("STUDENT NUMBER").ToString()
                        Dim lastName As String = reader("LAST NAME").ToString()
                        Dim firstName As String = reader("FIRST NAME").ToString()
                        Dim middleInitial As String = reader("MIDDLE NAME").ToString()
                        Dim timeIn As TimeSpan = TimeSpan.Parse(reader("TIMEIN").ToString())
                        Dim timeOut As TimeSpan = TimeSpan.Parse(reader("TIMEOUT").ToString())
                        Dim dateAttended As Date = Date.Parse(reader("DATE").ToString())
                        Dim formattedDate As String = dateAttended.ToString("dd/MM/yyyy")


                        Report_Panel.reporttbl.Rows.Add(studentNumber, lastName, firstName, middleInitial, timeIn, timeOut, formattedDate)
                    End While

                    reader.Close()
                Else
                    MessageBox.Show($"There is no attendance data for {selectedDate.ToShortDateString()} in the archive database.")
                    Report_Panel.reporttbl.Rows.Clear()



                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



End Module


