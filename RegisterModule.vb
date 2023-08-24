Imports MySql.Data.MySqlClient

Module RegisterModule


    Public Function GetConnection() As MySqlConnection
            Return New MySqlConnection("server=localhost;port=3306;user=root;password=;database=admin_acc;")
        End Function

    Public Function CheckIfUserExists(username As String) As Boolean
        Dim conn As MySqlConnection = GetConnection()
        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM account WHERE username = @username", conn)
        cmd.Parameters.AddWithValue("@username", username)
        conn.Open()
        Dim count As Integer = cmd.ExecuteScalar()
        conn.Close()
        Return count > 0
    End Function





    Public Sub InsertNewUser(fullname As String, cpnumber As String, username As String, password As String, cpassword As String)
            Dim conn As MySqlConnection = GetConnection()
            Dim cmd As New MySqlCommand("INSERT INTO account (fullname, cpnumber, username, password, cpassword) VALUES (@fullname, @cpnumber, @username, @password, @cpassword)", conn)
            cmd.Parameters.AddWithValue("@fullname", fullname)
            cmd.Parameters.AddWithValue("@cpnumber", cpnumber)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@cpassword", cpassword)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Sub

        Public Sub CreateStudentRegistrationTable(username As String)
            Dim conn As MySqlConnection = GetConnection()
            Dim cmd As New MySqlCommand("CREATE TABLE IF NOT EXISTS qrbasedams_db." & username & "_student_reg (ID INT NOT NULL AUTO_INCREMENT, STUDENT_NUMBER VARCHAR(50), LAST_NAME VARCHAR(150), FIRST_NAME VARCHAR(150), MIDDLE_NAME VARCHAR(50), SEX VARCHAR(10), AGE INT, PRIMARY KEY (ID))", conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Sub

    Public Sub CreateAttendanceTable(username As String)
        Dim conn As MySqlConnection = GetConnection()
        Dim cmd As New MySqlCommand("CREATE TABLE IF NOT EXISTS qrbasedams_db." & username & "_attendance (ID INT NOT NULL AUTO_INCREMENT, STUDENT_NUMBER VARCHAR(50), DATE DATE, TIMEIN TIME, TIMEOUT TIME, PRIMARY KEY (ID))", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub



End Module


