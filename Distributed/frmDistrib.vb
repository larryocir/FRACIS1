Imports Microsoft.Office.Interop
Public Class frmDistrib
    Dim index As Integer
    Dim rowcount As Integer
    Dim rowcounts As Integer
    Dim memberID As Integer
    Private Sub frmDistrib_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 845
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        btnClose.Location = New Point(1271, 4)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        'Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        If Me.Width = 845 Then
            Me.Width = 1300
            'Me.Location = New Point(50%, 50%)
            Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
            Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
            btnClose.Location = New Point(1271, 4)
            loadTable()

        End If

    End Sub

    Private Sub btnSaveDistrib_Click(sender As Object, e As EventArgs) Handles btnSaveDistrib.Click
        For i = 0 To dgrdreceiver.RowCount - 1
            openCon()

            Try
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO `received`(`mem_id`, `distributed_id`) SELECT @MEMBERID, @DISTRIBUTEID Where NOT EXISTS (SELECT mem_id, distributed_id FROM received WHERE mem_id = @MEMBERID and distributed_id = @DISTRIBUTEID)"
                With cmd
                    .Parameters.AddWithValue("@DISTRIBUTEID", dgrdreceiver.Rows(i).Cells(1).Value.ToString)
                    .Parameters.AddWithValue("@MEMBERID", dgrdreceiver.Rows(i).Cells(2).Value.ToString)
                    .ExecuteNonQuery()
                    .Parameters.Clear()
                End With
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                cmd.Dispose()
                con.Close()
            End Try
        Next

        MsgBox("Record has been successfully saved!", vbInformation)
        LoadSave()
    End Sub


    Sub loadTable()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT member.mem_id, mem_lname, mem_fname, mem_mname, mem_extname, mem_barangay FROM `member` WHERE NOT EXISTS (SELECT received.mem_id,received.distributed_id FROM received WHERE received.mem_id = member.mem_id AND received.distributed_id = '" & DistriID & "')"
            reader = cmd.ExecuteReader()
            'dgrdmember.DataSource = table

            dgrvAddReceiver.Rows.Clear()
            Do While reader.Read = True
                dgrvAddReceiver.Rows.Add(reader(0), reader(1) + ", " + reader(2) + " " + reader(3) + " " + reader(4), reader(5))
            Loop

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub


    Private Sub dgrvAddReceiver_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgrvAddReceiver.CellMouseDoubleClick
        GlobalId = dgrvAddReceiver.CurrentRow.Cells(0).Value

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT member.mem_id, member.mem_rsbsa_no, member.mem_lname, member.mem_fname, member.mem_mname, mem_extname , member.mem_barangay, member.mem_cp FROM member WHERE mem_id = '" & GlobalId & "' "
            reader = cmd.ExecuteReader()

            Do While reader.Read = True
                dgrdreceiver.Rows.Add("", DistriID, reader(0), reader(1), reader(2) + ", " + reader(3) + " " + reader(4) + " " + reader(5), reader(6), reader(7), DistributeItem, DistributeUnit)
            Loop

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally

            cmd.Dispose()
            con.Close()
        End Try
        RemoveToDataAdd()

    End Sub

    Sub RemoveToDataAdd()
        For Each row As DataGridViewRow In dgrvAddReceiver.SelectedRows
            dgrvAddReceiver.Rows.Remove(row)
        Next
    End Sub

    Sub RemoveToReceiver()
        For Each row As DataGridViewRow In dgrdreceiver.SelectedRows
            dgrdreceiver.Rows.Remove(row)
        Next
    End Sub



    Private Sub dgrdreceiver_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgrdreceiver.CellMouseDoubleClick
        memberID = dgrdreceiver.CurrentRow.Cells(2).Value


        openCon()
        Try
            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM `received` WHERE distributed_id = '" & DistriID & "' AND mem_id = '" & memberID & "'"
                rowcount = cmd.ExecuteScalar()
                If rowcount = 0 Then
                    con.Close()
                    openCon()
                    Try
                        cmd.Connection = con
                        cmd.CommandText = "SELECT member.mem_id, mem_lname, mem_fname, mem_mname, mem_extname, mem_barangay FROM `member`Where mem_id = '" & memberID & "'"
                        reader = cmd.ExecuteReader()
                        Do While reader.Read = True
                            dgrvAddReceiver.Rows.Add(reader(0), reader(1) + ", " + reader(2) + " " + reader(3) + " " + reader(4), reader(5))
                        Loop
                        RemoveToReceiver()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    Finally
                        cmd.Dispose()
                        con.Close()
                    End Try
                Else
                    If MsgBox("This data is already saved. Do you want you remove this data?", vbYesNo + vbQuestion) = vbYes Then
                        con.Close()
                        LoadAddReceiver()
                        Dim RemoveIndex As Integer
                        RemoveIndex = dgrdreceiver.CurrentRow.Cells(0).Value
                        openCon()
                        Try
                            With cmd
                                .Connection = con
                                .CommandText = ("DELETE FROM `received` WHERE received_id = " & RemoveIndex & "")
                                .ExecuteNonQuery()
                            End With
                            RemoveToReceiver()
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                        Finally
                            cmd.Dispose()
                            con.Close()
                        End Try
                    End If
                    con.Close()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try

    End Sub


    Sub LoadAddReceiver()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT member.mem_id, mem_lname, mem_fname, mem_mname, mem_extname, mem_barangay FROM `member`, received Where received.mem_id = member.mem_id and received.mem_id = '" & memberID & "' AND received.distributed_id ='" & DistriID & "'"
            reader = cmd.ExecuteReader()
            Do While reader.Read = True
                dgrvAddReceiver.Rows.Add(reader(0), reader(1) + ", " + reader(2) + " " + reader(3) + " " + reader(4), reader(5))
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Sub LoadSave()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT received.received_id, distributed.distributed_id, member.mem_id, member.mem_rsbsa_no, member.mem_lname, member.mem_fname, member.mem_mname, member.mem_barangay, member.mem_cp, distributed.distributed_item, distributed.distributed_unit,  mem_extname  FROM `distributed`, member, received Where distributed.distributed_id = '" & DistriID & "' AND member.mem_id = received.mem_id and distributed.distributed_id = received.distributed_id and distributed.distributed_item =  '" & DistributeItem & "'"
            reader = cmd.ExecuteReader()


            dgrdreceiver.Rows.Clear()
            Do While reader.Read = True
                dgrdreceiver.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4) + ", " + reader(5) + " " + reader(6) + " " + reader(11), reader(7), reader(8), reader(9), reader(10))
            Loop

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally

            cmd.Dispose()
            con.Close()
        End Try
    End Sub


    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.Width = 845
        'Me.Location = New Point(50%, 50%)
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        btnClose.Location = New Point(811, 4)
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        If dgrdreceiver.RowCount = 0 Then
            MsgBox("Nothing to Export")
        Else
            Try
                'ButtonExportToExcel.Text = "Please Wait..."
                'ButtonExportToExcel.Enabled = False

                SaveFileDialog1.Filter = "Excel Document (*.xlsx)|*.xlsx"
                If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Dim xlApp As Excel.Application
                    Dim xlWorkBook As Excel.Workbook
                    Dim xlWorkSheet As Excel.Worksheet
                    Dim misValue As Object = System.Reflection.Missing.Value
                    Dim i As Integer
                    Dim j As Integer
                    Dim rowIndex As Integer = 1
                    Dim columnsize As Integer = 10
                    Dim columnj As Integer
                    Dim columnk As Integer

                    xlApp = New Excel.Application
                    xlWorkBook = xlApp.Workbooks.Add(misValue)
                    xlWorkSheet = xlWorkBook.Sheets("sheet1")

                    With xlWorkSheet

                        With .Range(.Cells(rowIndex, ), .Cells(rowIndex, dgrdreceiver.Columns.Count - 3))
                            .HorizontalAlignment = Excel.Constants.xlCenter
                            .VerticalAlignment = Excel.Constants.xlCenter
                            .MergeCells = True
                            .Value = "List of Receiver"
                            .Font.Bold = True
                            .Font.Size = 24
                            .RowHeight = 40

                        End With

                        'rowIndex += 2
                        'For Each column As DataGridViewColumn In dgrdreceiver.Columns
                        '    .Cells(rowIndex, column.Index + 1) = column.HeaderText
                        'Next



                        rowIndex += 3
                        .Columns(1).ColumnWidth = 20
                        .Columns(2).ColumnWidth = 40
                        .Columns(3).ColumnWidth = 25
                        .Columns(4).ColumnWidth = 20
                        .Columns(4).NumberFormat = "00000000000"
                        .Columns(4).HorizontalAlignment = Excel.Constants.xlLeft
                        .Columns(5).ColumnWidth = 10
                        .Columns(6).ColumnWidth = 10




                        For i = 0 To dgrdreceiver.RowCount - 1
                            columnj = 1
                            For j = 3 To dgrdreceiver.ColumnCount - 1
                                ' .Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                                columnk = 1
                                For k As Integer = 4 To dgrdreceiver.Columns.Count
                                    .Cells(3, columnk) = dgrdreceiver.Columns(k - 1).HeaderText
                                    .Range(.Cells(3, 1), .Cells(3, dgrdreceiver.Columns.Count)).Font.Bold = True

                                    .Cells(rowIndex, columnj) = dgrdreceiver(j, i).Value.ToString()
                                    columnk += 1
                                Next
                                columnj += 1
                            Next
                            rowIndex += 1

                        Next
                    End With

                    xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
                    xlWorkBook.Close()
                    xlApp.Quit()

                    releaseObject(xlApp)
                    releaseObject(xlWorkBook)
                    releaseObject(xlWorkSheet)

                    MsgBox("Successfully saved" & vbCrLf & "File are saved at : " & SaveFileDialog1.FileName, MsgBoxStyle.Information, "Information")

                    'ButtonExportToExcel.Text = "Export To MS Excel"
                    'ButtonExportToExcel.Enabled = True
                End If
            Catch ex As Exception
                MessageBox.Show("Failed to save !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End If
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class