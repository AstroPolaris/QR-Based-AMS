Imports MessagingToolkit.QRCode.Codec
Imports MySql.Data.MySqlClient

Public Class Register_Panel
    Public Event StudentAdded()


    Private Sub generateBttn_Click(sender As Object, e As EventArgs) Handles generateBttn.Click
        Dim objqrcode As QRCodeEncoder = New QRCodeEncoder
        Dim img As Image
        Dim btm As Bitmap
        Dim str As String
        Dim sql As String

        If String.IsNullOrEmpty(txtStuNumber.Text) OrElse String.IsNullOrEmpty(txtLName.Text) OrElse String.IsNullOrEmpty(txtFName.Text) OrElse String.IsNullOrEmpty(txtMiddle.Text) OrElse String.IsNullOrEmpty(sex.Text) OrElse String.IsNullOrEmpty(txtAge.Text) Then
            MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim studentNumber As String = txtStuNumber.Text.Trim()
            If IsStudentNumberTaken(studentNumber) Then
                MessageBox.Show("Student Number already taken, You can update it in the STUDENT section or change it anyway.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return

            End If
            str = txtStuNumber.Text

            objqrcode.QRCodeScale = 6
            img = objqrcode.Encode(str)
            btm = New Bitmap(img)
            btm.Save("qrimage.jpg")

            qrCodePB.ImageLocation = "qrimage.jpg"

            sql = "INSERT INTO " & Login_Form.user.Text & "_student_reg (`STUDENT_NUMBER`,`LAST_NAME`,`FIRST_NAME`,`MIDDLE_NAME`,`SEX`,`AGE`) VALUES ('" & txtStuNumber.Text & "', '" & txtLName.Text & "','" & txtFName.Text & "','" & txtMiddle.Text & "' ,'" & sex.SelectedItem & "', " & txtAge.Text & ")"
            query_executer(sql)
            loaddgv(Student_Panel.studentTable, "SELECT * FROM " & Login_Form.user.Text & "_student_reg")
            Student_Panel.AddHeader()


            MsgBox("Successfully Saved!")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call Simpan_QR()


        qrCodePB.Image = Nothing
        Student_Panel.studentTable.Columns.Clear()

        txtAge.Clear()
        txtFName.Clear()
        txtLName.Clear()
        txtMiddle.Clear()
        txtStuNumber.Clear()
        sex.Text = Nothing
    End Sub
    Private Sub Simpan_QR()
        Try
            SaveFileDialog1.InitialDirectory = "C:\Users\63948\source\repos\QR-Based AMS\Students QR-Code"
            SaveFileDialog1.FileName = txtLName.Text + "," + txtFName.Text + " " + txtMiddle.Text + "."
            SaveFileDialog1.Filter = "PNG Image|*.png"

            Dim img As New Bitmap(qrCodePB.Image)
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                img.Save(SaveFileDialog1.FileName)
                qrCodePB.Image = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed to Generate", MessageBoxButtons.OK)

        End Try

    End Sub
    Private Function IsStudentNumberTaken(ByVal studentNumber As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM " & Login_Form.user.Text & "_student_reg WHERE STUDENT_NUMBER='" & studentNumber & "'"
        Dim conn As New MySqlConnection("server=localhost; username=root; password=; database=qrbasedams_db")
        Dim cmd As New MySqlCommand(sql, conn)

        Try
            conn.Open()
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtLName_TextChanged(sender As Object, e As EventArgs) Handles txtLName.TextChanged

    End Sub

    Private Sub txtLName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub

        End If
        e.SuppressKeyPress = True
    End Sub



    Private Sub txtAge_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAge.KeyDown
        If e.KeyCode = Keys.Enter Then
            generateBttn_Click(Nothing, Nothing)
        Else
            Exit Sub

        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtAge_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAge.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub

        End If
        e.SuppressKeyPress = True
    End Sub

End Class