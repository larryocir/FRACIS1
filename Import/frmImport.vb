Imports Microsoft.Office.Interop
Public Class frmImport

    Private Sub frmImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim xlRange As Excel.Range
        Dim xlRow As Integer


        Dim strFilename As String

        With OpenFileDialog1
            .Filter = "Excel Office| *.xls;*.xlsx"
            .ShowDialog()
            strFilename = .FileName
        End With

        If strFilename <> String.Empty Then
            Dim rowcount As Integer = 0
            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Open(strFilename)
            xlWorkSheet = xlWorkBook.Worksheets("Sheet1")
            xlRange = xlWorkSheet.UsedRange
            Panel3.Show()
            'Label1.Text = xlRange.Columns.Count
            For xlRow = 2 To xlRange.Rows.Count
                rowcount += 1
                If xlRange.Cells(xlRow, 1).Text <> String.Empty And xlRange.Cells(xlRow, 2).Text <> String.Empty And xlRange.Cells(xlRow, 3).Text <> String.Empty And xlRange.Cells(xlRow, 4).Text <> String.Empty And xlRange.Cells(xlRow, 5).Text <> String.Empty And xlRange.Cells(xlRow, 5).Text <> String.Empty Then
                    DataGridView1.Rows.Add(xlRange.Cells(xlRow, 1).Text, xlRange.Cells(xlRow, 2).Text, xlRange.Cells(xlRow, 3).Text, xlRange.Cells(xlRow, 4).Text, xlRange.Cells(xlRow, 5).Text, xlRange.Cells(xlRow, 6).Text)
                    lblcount.Text = rowcount & " Records."
                End If
                Me.Refresh()

            Next
            Panel3.Hide()

            xlWorkBook.Close()
            xlApp.Quit()

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim i As Integer
        If MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes Then
            For i = 0 To DataGridView1.RowCount - 1
                openCon()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO `tbldata`(`dat_LNAME`, `dat_FNAME`, `dat_BDAY`, `dat_AGE`, `dat_GENDER`, `dat_ADDRESS`) VALUES (@LNAME, @FNAME, @BDAY, @AGE, @GENDER, @ADDRESS )"
                With cmd
                    .Parameters.AddWithValue("@LNAME", DataGridView1.Rows(i).Cells(0).Value.ToString)
                    .Parameters.AddWithValue("@FNAME", DataGridView1.Rows(i).Cells(1).Value.ToString)
                    .Parameters.AddWithValue("@BDAY", DataGridView1.Rows(i).Cells(2).Value.ToString)
                    .Parameters.AddWithValue("@AGE", DataGridView1.Rows(i).Cells(3).Value.ToString)
                    .Parameters.AddWithValue("@GENDER", DataGridView1.Rows(i).Cells(4).Value.ToString)
                    .Parameters.AddWithValue("@ADDRESS", DataGridView1.Rows(i).Cells(5).Value.ToString)
                    .ExecuteNonQuery()
                    .Parameters.Clear()
                End With
                con.Close()
            Next

            MsgBox("Record has been successfully saved!", vbInformation)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        DataGridView1.Rows.Clear()
    End Sub
End Class