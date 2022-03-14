Imports Microsoft.Office.Interop
Public Class frmReport

    Dim FilterBrgy As String

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbBarangay.SelectedItem = "ALL"
    End Sub

    Private Sub btnShowReport_Click(sender As Object, e As EventArgs) Handles btnShowReport.Click
        If radMMember.Checked Then
            MEMBERQUERY()
        ElseIf radMMCommodities.Checked Then
            CROPSQUERY()
        ElseIf radMMAnimals.Checked = True Then
            ANIMALSQUERY()
        End If
    End Sub

    Private Sub btnDownloadReport_Click(sender As Object, e As EventArgs) Handles btnDownloadReport.Click
        If dgrdreport.RowCount = 0 Then
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

                    xlApp = New Excel.Application
                    xlWorkBook = xlApp.Workbooks.Add(misValue)
                    xlWorkSheet = xlWorkBook.Sheets("sheet1")

                    With xlWorkSheet

                        With .Range(.Cells(rowIndex, 1), .Cells(rowIndex, dgrdreport.Columns.Count))
                            .HorizontalAlignment = Excel.Constants.xlCenter
                            .VerticalAlignment = Excel.Constants.xlCenter
                            .MergeCells = True
                            .Value = "MASTERLIST OF MEMBER"
                            .Font.Bold = True
                            .Font.Size = 24
                            .RowHeight = 40

                        End With

                        rowIndex += 2
                        For Each column As DataGridViewColumn In dgrdreport.Columns
                            .Cells(rowIndex, column.Index + 1) = column.HeaderText
                        Next

                        .Range(.Cells(rowIndex, 1), .Cells(rowIndex, dgrdreport.Columns.Count)).Font.Bold = True

                        rowIndex += 1
                        .Columns(1).ColumnWidth = 20
                        .Columns(2).ColumnWidth = 20
                        .Columns(3).ColumnWidth = 20
                        .Columns(4).ColumnWidth = 20
                        .Columns(5).ColumnWidth = 10
                        .Columns(6).ColumnWidth = 20
                        .Columns(7).ColumnWidth = 20
                        .Columns(8).ColumnWidth = 20
                        .Columns(9).ColumnWidth = 20
                        .Columns(9).HorizontalAlignment = Excel.Constants.xlLeft
                        .Columns(10).ColumnWidth = 10
                        .Columns(11).ColumnWidth = 20
                        .Columns(11).NumberFormat = "00000000000"
                        .Columns(11).HorizontalAlignment = Excel.Constants.xlLeft
                        .Columns(12).HorizontalAlignment = Excel.Constants.xlLeft
                        .Columns(13).HorizontalAlignment = Excel.Constants.xlLeft
                        .Columns(14).HorizontalAlignment = Excel.Constants.xlLeft
                        .Columns(15).HorizontalAlignment = Excel.Constants.xlLeft

                        For i = 0 To dgrdreport.RowCount - 1
                            For j = 0 To dgrdreport.ColumnCount - 1
                                ' .Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()

                                For k As Integer = 1 To dgrdreport.Columns.Count
                                    '.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                                    .Cells(rowIndex, j + 1) = dgrdreport(j, i).Value.ToString()
                                Next

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

    Sub MEMBERQUERY()
        DataGridViewLayoutReportMember()
        If cmbBarangay.SelectedItem = "ALL" Then
            openCon()
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT mem_rsbsa_no, mem_fname, mem_lname, mem_mname, mem_extname, mem_barangay, mem_municipality, mem_province, mem_dob, mem_sex, mem_cp FROM `member`"
                reader = cmd.ExecuteReader()
                'dgrdmember.DataSource = table

                dgrdreport.Rows.Clear()
                If reader.HasRows Then
                    Do While reader.Read = True
                        dgrdreport.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9), reader(10))
                    Loop
                    Label4.Visible = False
                Else
                    Label4.Visible = True
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                cmd.Parameters.Clear()
                cmd.Dispose()
                con.Close()
            End Try
        Else
            openCon()
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT mem_rsbsa_no, mem_fname, mem_lname, mem_mname, mem_extname, mem_barangay, mem_municipality, mem_province, mem_dob, mem_sex, mem_cp FROM `member` WHERE member.mem_barangay = '" & FilterBrgy & "'"
                reader = cmd.ExecuteReader()
                'dgrdmember.DataSource = table

                dgrdreport.Rows.Clear()
                If reader.HasRows Then
                    Do While reader.Read = True
                        dgrdreport.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9), reader(10))
                    Loop
                    Label4.Visible = False
                Else
                    Label4.Visible = True
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                cmd.Parameters.Clear()
                cmd.Dispose()
                con.Close()
            End Try
        End If
    End Sub

    Sub CROPSQUERY()
        DataGridViewLayoutReportMemberWCrops()
        If cmbBarangay.SelectedItem = "ALL" Then
            openCon()
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT DISTINCT(crops.mem_id), member.mem_id as ID, mem_rsbsa_no, mem_fname, mem_lname, mem_mname, mem_extname, mem_barangay, mem_municipality, mem_province, mem_dob, mem_sex, mem_cp,(Select SUM(crops.crops_landarea) FROM crops WHERE crops_cat = 'Rice'And crops.mem_id = ID) AS Rice, (Select Sum(crops.crops_landarea) FROM crops WHERE crops_cat = 'Coconut'And crops.mem_id = ID) AS Coconut, (Select SUM(crops.crops_landarea) FROM crops WHERE crops_cat = 'Corn'And crops.mem_id = ID) AS Corn, (Select Sum(crops.crops_landarea) FROM crops WHERE crops.mem_id = ID AND crops_cat = 'HVCDP') AS HVCDP FROM `crops`, member WHERE member.mem_id = crops.mem_id 
                                        ORDER BY `crops`.`mem_id` ASC"
                reader = cmd.ExecuteReader()
                'dgrdmember.DataSource = table

                dgrdreport.Rows.Clear()
                If reader.HasRows Then
                    Do While reader.Read = True
                        dgrdreport.Rows.Add(reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9), reader(10), reader(11), reader(12), reader(13), reader(14), reader(15), reader(16))
                    Loop
                    Label4.Visible = False
                Else
                    Label4.Visible = True
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                cmd.Parameters.Clear()
                cmd.Dispose()
                con.Close()
            End Try
        Else
            openCon()
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT DISTINCT(crops.mem_id), member.mem_id as ID, mem_rsbsa_no, mem_fname, mem_lname, mem_mname, mem_extname, mem_barangay, mem_municipality, mem_province, mem_dob, mem_sex, mem_cp,(Select SUM(crops.crops_landarea) FROM crops WHERE crops_cat = 'Rice'And crops.mem_id = ID) AS Rice, (Select Sum(crops.crops_landarea) FROM crops WHERE crops_cat = 'Coconut'And crops.mem_id = ID) AS Coconut, (Select SUM(crops.crops_landarea) FROM crops WHERE crops_cat = 'Corn'And crops.mem_id = ID) AS Corn, (Select Sum(crops.crops_landarea) FROM crops WHERE crops.mem_id = ID AND crops_cat = 'HVCDP') AS HVCDP FROM `crops`, member WHERE member.mem_id = crops.mem_id 
                                        AND member.mem_barangay = '" & FilterBrgy & "' ORDER BY `crops`.`mem_id` ASC"
                reader = cmd.ExecuteReader()
                'dgrdmember.DataSource = table

                dgrdreport.Rows.Clear()
                If reader.HasRows Then
                    Do While reader.Read = True
                        dgrdreport.Rows.Add(reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9), reader(10), reader(11), reader(12), reader(13), reader(14), reader(15), reader(16))
                    Loop
                    Label4.Visible = False
                Else
                    Label4.Visible = True
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                cmd.Parameters.Clear()
                cmd.Dispose()
                con.Close()
            End Try
        End If
    End Sub

    Sub ANIMALSQUERY()
        DataGridViewLayoutReportMemberWAnimals()
        If cmbBarangay.SelectedItem = "ALL" Then
            openCon()
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT DISTINCT(animal.mem_id), member.mem_id as ID, mem_rsbsa_no, mem_fname, mem_lname, mem_mname, mem_extname, mem_barangay, mem_municipality, mem_province, mem_dob, mem_sex, mem_cp, (Select SUM(animal.animal_no) FROM animal WHERE animal_cat = 'Poultry'And animal.mem_id = ID) AS Poultry, (Select Sum(animal.animal_no) FROM animal WHERE animal_cat = 'Livestock'And animal.mem_id = ID) AS Livestock, (Select SUM(animal.animal_no) FROM animal WHERE animal_cat = 'Other Animals'And animal.mem_id = ID) AS Other_Animal FROM `member`, animal WHERE member.mem_id = animal.mem_id
                                        ORDER BY `animal`.`mem_id` ASC"
                reader = cmd.ExecuteReader()
                'dgrdmember.DataSource = table

                dgrdreport.Rows.Clear()
                If reader.HasRows Then
                    Do While reader.Read = True
                        dgrdreport.Rows.Add(reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9), reader(10), reader(11), reader(12), reader(13), reader(14), reader(15))
                    Loop
                    Label4.Visible = False
                Else
                    Label4.Visible = True
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                cmd.Parameters.Clear()
                cmd.Dispose()
                con.Close()
            End Try
        Else
            openCon()
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT DISTINCT(animal.mem_id), member.mem_id as ID, mem_rsbsa_no, mem_fname, mem_lname, mem_mname, mem_extname, mem_barangay, mem_municipality, mem_province, mem_dob, mem_sex, mem_cp, (Select SUM(animal.animal_no) FROM animal WHERE animal_cat = 'Poultry'And animal.mem_id = ID) AS Poultry, (Select Sum(animal.animal_no) FROM animal WHERE animal_cat = 'Livestock'And animal.mem_id = ID) AS Livestock, (Select SUM(animal.animal_no) FROM animal WHERE animal_cat = 'Other Animals'And animal.mem_id = ID) AS Other_Animal FROM `member`, animal WHERE member.mem_id = animal.mem_id
                                        AND member.mem_barangay = '" & FilterBrgy & "' ORDER BY `animal`.`mem_id` ASC"
                reader = cmd.ExecuteReader()
                'dgrdmember.DataSource = table

                dgrdreport.Rows.Clear()
                If reader.HasRows Then
                    Do While reader.Read = True
                        dgrdreport.Rows.Add(reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9), reader(10), reader(11), reader(12), reader(13), reader(14), reader(15))
                    Loop
                    Label4.Visible = False
                Else
                    Label4.Visible = True
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                cmd.Parameters.Clear()
                cmd.Dispose()
                con.Close()
            End Try
        End If
    End Sub

    Sub DataGridViewLayoutReportMember()
        dgrdreport.ColumnCount = 11
        dgrdreport.Columns(0).Name = "RSBSA Number"
        dgrdreport.Columns(0).Width = 150
        dgrdreport.Columns(1).Name = "Last Name"
        dgrdreport.Columns(1).Width = 150
        dgrdreport.Columns(2).Name = "First Name"
        dgrdreport.Columns(2).Width = 150
        dgrdreport.Columns(3).Name = "Middle Name"
        dgrdreport.Columns(3).Width = 150
        dgrdreport.Columns(4).Name = "Ext. Name"
        dgrdreport.Columns(4).Width = 100
        dgrdreport.Columns(5).Name = "Barangay"
        dgrdreport.Columns(5).Width = 150
        dgrdreport.Columns(6).Name = "Municipality"
        dgrdreport.Columns(6).Width = 100
        dgrdreport.Columns(7).Name = "Province"
        dgrdreport.Columns(7).Width = 120
        dgrdreport.Columns(8).Name = "Birthday"
        dgrdreport.Columns(8).Width = 100
        dgrdreport.Columns(9).Name = "Gender"
        dgrdreport.Columns(9).Width = 80
        dgrdreport.Columns(10).Name = "Contact Number"
        dgrdreport.Columns(10).Width = 130
        dgrdreport.Rows.Clear()
    End Sub

    Sub DataGridViewLayoutReportMemberWCrops()
        dgrdreport.ColumnCount = 15
        dgrdreport.Columns(0).Name = "RSBSA Number"
        dgrdreport.Columns(0).Width = 150
        dgrdreport.Columns(1).Name = "Last Name"
        dgrdreport.Columns(1).Width = 150
        dgrdreport.Columns(2).Name = "First Name"
        dgrdreport.Columns(2).Width = 150
        dgrdreport.Columns(3).Name = "Middle Name"
        dgrdreport.Columns(3).Width = 150
        dgrdreport.Columns(4).Name = "Ext. Name"
        dgrdreport.Columns(4).Width = 100
        dgrdreport.Columns(5).Name = "Barangay"
        dgrdreport.Columns(5).Width = 150
        dgrdreport.Columns(6).Name = "Municipality"
        dgrdreport.Columns(6).Width = 100
        dgrdreport.Columns(7).Name = "Province"
        dgrdreport.Columns(7).Width = 120
        dgrdreport.Columns(8).Name = "Birthday"
        dgrdreport.Columns(8).Width = 100
        dgrdreport.Columns(9).Name = "Gender"
        dgrdreport.Columns(9).Width = 80
        dgrdreport.Columns(10).Name = "Contact Number"
        dgrdreport.Columns(10).Width = 130
        dgrdreport.Columns(11).Name = "Rice"
        dgrdreport.Columns(11).Width = 80
        dgrdreport.Columns(12).Name = "Coconut"
        dgrdreport.Columns(12).Width = 80
        dgrdreport.Columns(13).Name = "Corn"
        dgrdreport.Columns(13).Width = 80
        dgrdreport.Columns(14).Name = "HVCDP"
        dgrdreport.Columns(14).Width = 80


        dgrdreport.Rows.Clear()
    End Sub

    Sub DataGridViewLayoutReportMemberWAnimals()
        dgrdreport.ColumnCount = 14
        dgrdreport.Columns(0).Name = "RSBSA Number"
        dgrdreport.Columns(0).Width = 150
        dgrdreport.Columns(1).Name = "Last Name"
        dgrdreport.Columns(1).Width = 150
        dgrdreport.Columns(2).Name = "First Name"
        dgrdreport.Columns(2).Width = 150
        dgrdreport.Columns(3).Name = "Middle Name"
        dgrdreport.Columns(3).Width = 150
        dgrdreport.Columns(4).Name = "Ext. Name"
        dgrdreport.Columns(4).Width = 100
        dgrdreport.Columns(5).Name = "Barangay"
        dgrdreport.Columns(5).Width = 150
        dgrdreport.Columns(6).Name = "Municipality"
        dgrdreport.Columns(6).Width = 100
        dgrdreport.Columns(7).Name = "Province"
        dgrdreport.Columns(7).Width = 120
        dgrdreport.Columns(8).Name = "Birthday"
        dgrdreport.Columns(8).Width = 100
        dgrdreport.Columns(9).Name = "Gender"
        dgrdreport.Columns(9).Width = 80
        dgrdreport.Columns(10).Name = "Contact Number"
        dgrdreport.Columns(10).Width = 130
        dgrdreport.Columns(11).Name = "Poultry"
        dgrdreport.Columns(11).Width = 80
        dgrdreport.Columns(12).Name = "Livestock"
        dgrdreport.Columns(12).Width = 80
        dgrdreport.Columns(13).Name = "Other Animals"
        dgrdreport.Columns(13).Width = 80



        dgrdreport.Rows.Clear()
    End Sub

    Private Sub cmbBarangay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBarangay.SelectedIndexChanged
        FilterBrgy = cmbBarangay.SelectedItem
        If dgrdreport.RowCount > 0 Then
            If radMMember.Checked = True Then
                MEMBERQUERY()
            ElseIf radMMCommodities.Checked = True Then
                CROPSQUERY()
            ElseIf radMMAnimals.Checked = True Then
                ANIMALSQUERY()
            End If
        End If
    End Sub
End Class