Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports ClosedXML.Excel


Public Class Student_Panel
    Dim conn As MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim SQL As String
    Dim id As Integer
    Dim what As String




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles savebttn.Click
        If what = "save" Then
            MsgBox("Invalid changes!")
        End If
        If what = "UPDATE" Then
            ' Check if any changes are made
            If lname.Text = studentTable.CurrentRow.Cells("LAST_NAME").Value AndAlso
           fname.Text = studentTable.CurrentRow.Cells("FIRST_NAME").Value AndAlso
           minitial.Text = studentTable.CurrentRow.Cells("MIDDLE_NAME").Value AndAlso
           sex.Text = studentTable.CurrentRow.Cells("SEX").Value AndAlso
           age.Text = studentTable.CurrentRow.Cells("AGE").Value.ToString() Then
                MsgBox("No changes made for this student.")
                Return
            End If
            Try
                conn.Open() ' Open the database connection
                SQL = "UPDATE " & Login_Form.user.Text & "_student_reg SET `LAST_NAME` = '" & lname.Text & "', `FIRST_NAME` =  '" & fname.Text & "', `MIDDLE_NAME` =  '" & minitial.Text & "', `SEX`  =  '" & sex.SelectedItem & "', `AGE` =  '" & Val(age.Text) & "' WHERE `ID` = '" & id & "'"
                query_executer(SQL)
                MsgBox("Data has been updated!")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close() ' Close the database connection
            End Try
        End If

        Dim txt
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.Text = ""
                sex.Text = Nothing

            End If
        Next txt

        studentTable.Columns.Clear()
        loaddgv(studentTable, "SELECT * FROM " & Login_Form.user.Text & "_student_reg")
        AddHeader()
    End Sub


    Private Sub Student_Panel_Load(sender As Object, ByVale As System.EventArgs) Handles MyBase.Load
        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost; username=root;" & "password=; database=qrbasedams_db"
        loaddgv(studentTable, "SELECT * FROM " & Login_Form.user.Text & "_student_reg")
        studentTable.Refresh()

        Try
            conn.Open()
            loaddgv(studentTable, "select * from " & Login_Form.user.Text & "_student_reg")
            what = "save"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        AddHeader()
        conn.Close()


    End Sub



    Public Sub AddHeader()

        Dim picdel As New DataGridViewImageColumn
        Dim img As Image = Image.FromFile("C:\Users\63948\source\repos\QR-Based AMS\bin\images\delete.png")
        picdel.Image = img
        studentTable.Columns.Add(picdel)
        picdel.HeaderText = "DELETE"
        picdel.Name = "img"

        Dim picedit As New DataGridViewImageColumn
        Dim img1 As Image = Image.FromFile("C:\Users\63948\source\repos\QR-Based AMS\bin\images\edit.png")
        picedit.Image = img1
        studentTable.Columns.Add(picedit)
        picedit.HeaderText = "UPDATE"
        picedit.Name = "img1"

        studentTable.Columns(0).Visible = False
        studentTable.Columns("STUDENT_NUMBER").HeaderText = "STUDENT NUMBER"
        studentTable.Columns("LAST_NAME").HeaderText = "LAST NAME"
        studentTable.Columns("FIRST_NAME").HeaderText = "FIRST NAME"
        studentTable.Columns("MIDDLE_NAME").HeaderText = "MIDDLE NAME"
        studentTable.Columns("SEX").HeaderText = "SEX"
        studentTable.Columns("AGE").HeaderText = "AGE"



    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles updateBttn.Click
        Dim txt
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.Text = ""
                sex.Text = Nothing

            End If
        Next txt



    End Sub

    Private Sub studentTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentTable.CellContentClick

        If studentTable.CurrentCell.ColumnIndex.Equals(7) And e.RowIndex >= 0 Then
            id = Val(studentTable.Rows(e.RowIndex).Cells(0).Value)
            Dim a As String
            a = MsgBox("Delete this data?", vbYesNo, "Delete data?")
            If a = vbYes Then


                SQL = "DELETE FROM " & Login_Form.user.Text & "_student_reg  WHERE ID = '" & id & " ' "
                query_executer(SQL)
                MsgBox("deleted")

                studentTable.Columns.Clear()
                loaddgv(studentTable, "select * from " & Login_Form.user.Text & "_student_reg")
                AddHeader()
            Else
                Exit Sub

            End If
        End If


        If studentTable.CurrentCell IsNot Nothing AndAlso studentTable.CurrentCell.ColumnIndex.Equals(8) And e.RowIndex >= 0 Then
            If e.RowIndex >= 0 Then
                Dim row As New DataGridViewRow
                row = studentTable.Rows(e.RowIndex)

                id = Val(row.Cells(0).Value.ToString)
                studentnum.Text = row.Cells(1).Value.ToString
                lname.Text = row.Cells(2).Value.ToString
                fname.Text = row.Cells(3).Value.ToString
                minitial.Text = row.Cells(4).Value.ToString
                sex.Text = row.Cells(5).Value.ToString
                age.Text = row.Cells(6).Value.ToString
                what = "UPDATE"
            End If
        End If







    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fileName As String = String.Format("Student_Report _{0:yyyy_MM_dd}.xlsx", DateTime.Now)
        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook |*.xlsx", .FileName = fileName, .InitialDirectory = "C:\Users\63948\source\repos\QR-Based AMS\Reports\Student Report"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As XLWorkbook = New XLWorkbook()
                        Dim worksheet = workbook.Worksheets.Add("Sheet1")
                        Dim columnIndex As Integer = 1
                        For Each column As DataGridViewColumn In studentTable.Columns
                            If column.Index < studentTable.Columns.Count - 2 Then
                                worksheet.Cell(1, columnIndex).Value = column.HeaderText
                                worksheet.Cell(1, columnIndex).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left
                                columnIndex += 1
                            End If
                        Next

                        Dim rowIndex As Integer = 2
                        For Each row As DataGridViewRow In studentTable.Rows
                            columnIndex = 1
                            For Each cell As DataGridViewCell In row.Cells
                                If cell.OwningColumn.Index < studentTable.Columns.Count - 2 Then
                                    worksheet.Cell(rowIndex, columnIndex).Value = cell.Value.ToString()
                                    worksheet.Cell(rowIndex, columnIndex).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left
                                    columnIndex += 1
                                End If
                            Next
                            rowIndex += 1
                        Next
                        workbook.SaveAs(sfd.FileName)
                    End Using
                    MessageBox.Show("File has been exported successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End Using
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        If searchBox.Text.Trim() <> "" Then
            SQL = "SELECT * FROM " & Login_Form.user.Text & "_student_reg WHERE STUDENT_NUMBER LIKE '%" & searchBox.Text & "%' OR LAST_NAME LIKE '%" & searchBox.Text & "%' OR FIRST_NAME LIKE '%" & searchBox.Text & "%' OR MIDDLE_NAME LIKE '%" & searchBox.Text & "%' OR SEX LIKE '%" & searchBox.Text & "%' OR AGE LIKE '%" & searchBox.Text & "%'"
        Else
            SQL = "SELECT * FROM " & Login_Form.user.Text & "_student_reg"
        End If
        loaddgv(studentTable, SQL)
    End Sub

    Private Sub studentnum_TextChanged(sender As Object, e As EventArgs) Handles studentnum.TextChanged

    End Sub

    Private Sub studentnum_KeyDown(sender As Object, e As KeyEventArgs) Handles studentnum.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub

        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub sex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sex.SelectedIndexChanged

    End Sub

    Private Sub sex_KeyDown(sender As Object, e As KeyEventArgs) Handles sex.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(Nothing, Nothing)
        Else
            Exit Sub

        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            conn.Open() ' Open the database connection
            SQL = "UPDATE " & Login_Form.user.Text & "_student_reg SET `LAST_NAME` = '" & lname.Text & "', `FIRST_NAME` =  '" & fname.Text & "', `MIDDLE_NAME` =  '" & minitial.Text & "', `SEX`  =  '" & sex.SelectedItem & "', `AGE` =  '" & Val(age.Text) & "' WHERE `ID` = '" & id & "'"
            query_executer(SQL)
            MsgBox("Data has been refreshed!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close() ' Close the database connection
        End Try
        studentTable.Columns.Clear()
        loaddgv(studentTable, "SELECT * FROM " & Login_Form.user.Text & "_student_reg")
        AddHeader()
    End Sub
End Class