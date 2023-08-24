Imports ClosedXML.Excel
Imports MySql.Data.MySqlClient


Public Class Report_Panel



    Private loggedIn As Boolean = False
    Public Sub SetLoggedInStatus(status As Boolean)
        loggedIn = status
    End Sub
    Private Sub Report_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reporttbl.Columns.Clear()

    End Sub

    Public Property SelectedDate As DateTime
        Get
            Return DateTimePicker1.Value
        End Get
        Set(value As DateTime)
            DateTimePicker1.Value = value
        End Set
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If loggedIn Then
            MessageBox.Show("Already logged in.")
        Else
            Archive_Form.Show()
        End If

    End Sub

    Public Function GetSelectedDate() As Date
        Return DateTimePicker1.Value.Date
    End Function


    Private Sub DateTimePicker1_CloseUp(sender As Object, e As EventArgs) Handles DateTimePicker1.CloseUp
        If Not loggedIn Then
            MessageBox.Show("You must login first.")
        Else
            Dim selectedDate As Date = DateTimePicker1.Value.Date
            LoadAttendanceDataFromArchiveDb(selectedDate)
        End If
    End Sub




    Private Sub exportbttn_Click(sender As Object, e As EventArgs) Handles exportbttn.Click
        If Not loggedIn Then
            MessageBox.Show("You must login first.")
        Else
            If reporttbl.Rows.Count = 0 Then
                MessageBox.Show("There is nothing to export.")
            Else
                Dim fileName As String = String.Format("AttendanceReport _{0:yyyy_MM_dd}.xlsx", DateTime.Now)

                Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook |*.xlsx", .FileName = fileName, .InitialDirectory = "C:\Users\63948\source\repos\QR-Based AMS\Reports\Attendance Report"}
                    If sfd.ShowDialog() = DialogResult.OK Then
                        Try
                            Using workbook As XLWorkbook = New XLWorkbook()
                                Dim worksheet = workbook.Worksheets.Add("Sheet1")
                                Dim columnIndex As Integer = 1

                                ' Write column headers to the worksheet
                                For Each column As DataGridViewColumn In reporttbl.Columns
                                    worksheet.Cell(1, columnIndex).Value = column.HeaderText
                                    worksheet.Cell(1, columnIndex).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left
                                    columnIndex += 1
                                Next

                                ' Write data to the worksheet
                                Dim rowIndex As Integer = 2
                                For Each row As DataGridViewRow In reporttbl.Rows
                                    columnIndex = 1
                                    For Each cell As DataGridViewCell In row.Cells
                                        If Not cell.Value Is Nothing Then
                                            worksheet.Cell(rowIndex, columnIndex).Value = cell.Value.ToString()
                                        End If
                                        worksheet.Cell(rowIndex, columnIndex).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left
                                        columnIndex += 1
                                    Next
                                    rowIndex += 1
                                Next

                                ' Save the workbook
                                workbook.SaveAs(sfd.FileName)
                            End Using

                            MessageBox.Show("File has been exported successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                    End If
                End Using
            End If
        End If
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        Dim searchValue As String = searchBox.Text
        reporttbl.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        For Each row As DataGridViewRow In reporttbl.Rows
            Dim foundMatch As Boolean = False
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(searchValue.ToLower()) Then
                    foundMatch = True
                    Exit For
                End If
            Next
            row.Visible = foundMatch
        Next

    End Sub
End Class