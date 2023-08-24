Imports MySql.Data.MySqlClient


Module Module2
    Public serverstring As String = ("server=localhost; username=root; password=; database=qrbasedams_db")
    Public conn As MySqlConnection = New MySqlConnection(serverstring)
    Public myreader As MySqlDataAdapter
    Public cmd As MySqlCommand = New MySqlCommand

    Public Sub query_executer(ByVal sql As String)
        Try
            cmd.CommandText = sql
            cmd.Connection = conn
            conn.Open()

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")

        End Try
        conn.Close()

    End Sub
    Public Sub loaddgv(ByRef dgv As DataGridView, ByRef sql As String)
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet

        da.SelectCommand = New MySqlCommand(sql, conn)
        da.Fill(ds)
        conn.Close()
        dgv.DataSource = ds.Tables(0)




    End Sub


End Module
