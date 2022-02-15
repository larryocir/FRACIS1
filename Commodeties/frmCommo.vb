Public Class frmCommo

    Private Sub frmCommo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbCommo.SelectedItem = "Crops"


    End Sub
    'Sub loadCrops()
    '    openCon()
    '    Try
    '        cmd.Connection = con
    '        cmd.CommandText = "SELECT crops_id, crops_type, crops_cat, crops_landarea, member.mem_lname, member.mem_fname, member.mem_mname, member.mem_barangay, member.mem_municipality, member.mem_province, member.mem_cp FROM `crops`, member where member.mem_id = crops.mem_id"
    '        reader = cmd.ExecuteReader()
    '        'dgrdmember.DataSource = table

    '        dgrdcommo.Rows.Clear()
    '        Do While reader.Read = True
    '            dgrdcommo.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4) + ", " + reader(5) + " " + reader(6), reader(7) + ", " + reader(8) + ", " + reader(9), reader(10))
    '        Loop
    '        Label4.Visible = False
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    Finally

    '        cmd.Dispose()
    '        con.Close()
    '    End Try
    'End Sub

    Private Sub cmbCommo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCommo.SelectedIndexChanged
        If cmbCommo.SelectedItem = "Crops" Then
            DataGridViewLayoutCrops()
            cmbCat.Items.Clear()
            cmbCat.Items.Add("All Crops")
            cmbCat.Items.Add("Rice")
            cmbCat.Items.Add("Coconut")
            cmbCat.Items.Add("Corn")
            cmbCat.Items.Add("HVCDP")

            cmbCat.SelectedItem = "All Crops"
        Else
            DataGridViewLayoutAnimals()
            cmbCat.Items.Clear()
            cmbCat.Items.Add("Livestock")
            cmbCat.Items.Add("Poultry")
            cmbCat.Items.Add("Other Animals")

        End If
    End Sub

    Private Sub cmbCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCat.SelectedIndexChanged
        If cmbCommo.SelectedItem = "Crops" Then
            If cmbCat.SelectedItem = "All Crops" Then
                openCon()
                Try
                    cmd.Connection = con
                    cmd.CommandText = "SELECT crops_id, crops_type, crops_cat, crops_landarea, member.mem_lname, member.mem_fname, member.mem_mname, member.mem_barangay, member.mem_municipality, member.mem_province, member.mem_cp FROM `crops`, member where member.mem_id = crops.mem_id"
                    reader = cmd.ExecuteReader()
                    'dgrdmember.DataSource = table


                    dgrdcommo.Rows.Clear()
                    Do While reader.Read = True
                        dgrdcommo.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4) + ", " + reader(5) + " " + reader(6), reader(7) + ", " + reader(8) + ", " + reader(9), reader(10))
                    Loop
                    Label4.Visible = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally

                    cmd.Dispose()
                    con.Close()
                End Try
            ElseIf cmbCat.SelectedItem = "Rice" Then
                openCon()
                Try
                    cmd.Connection = con
                    cmd.CommandText = "SELECT crops_id, crops_type, crops_cat, crops_landarea, member.mem_lname, member.mem_fname, member.mem_mname, member.mem_barangay, member.mem_municipality, member.mem_province, member.mem_cp FROM `crops`, member where member.mem_id = crops.mem_id and crops.crops_cat = 'Rice'"
                    reader = cmd.ExecuteReader()
                    'dgrdmember.DataSource = table

                    dgrdcommo.Rows.Clear()
                    Do While reader.Read = True
                        dgrdcommo.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4) + ", " + reader(5) + " " + reader(6), reader(7) + ", " + reader(8) + ", " + reader(9), reader(10))
                    Loop
                    Label4.Visible = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally

                    cmd.Dispose()
                    con.Close()
                End Try
            ElseIf cmbCat.SelectedItem = "Coconut" Then
                openCon()
                Try
                    cmd.Connection = con
                    cmd.CommandText = "SELECT crops_id, crops_type, crops_cat, crops_landarea, member.mem_lname, member.mem_fname, member.mem_mname, member.mem_barangay, member.mem_municipality, member.mem_province, member.mem_cp FROM `crops`, member where member.mem_id = crops.mem_id and crops.crops_cat = 'Coconut'"
                    reader = cmd.ExecuteReader()
                    'dgrdmember.DataSource = table

                    dgrdcommo.Rows.Clear()
                    Do While reader.Read = True
                        dgrdcommo.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4) + ", " + reader(5) + " " + reader(6), reader(7) + ", " + reader(8) + ", " + reader(9), reader(10))
                    Loop
                    Label4.Visible = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally

                    cmd.Dispose()
                    con.Close()
                End Try
            ElseIf cmbCat.SelectedItem = "Corn" Then
                openCon()
                Try
                    cmd.Connection = con
                    cmd.CommandText = "SELECT crops_id, crops_type, crops_cat, crops_landarea, member.mem_lname, member.mem_fname, member.mem_mname, member.mem_barangay, member.mem_municipality, member.mem_province, member.mem_cp FROM `crops`, member where member.mem_id = crops.mem_id and crops.crops_cat = 'Corn'"
                    reader = cmd.ExecuteReader()
                    'dgrdmember.DataSource = table

                    dgrdcommo.Rows.Clear()
                    Do While reader.Read = True
                        dgrdcommo.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4) + ", " + reader(5) + " " + reader(6), reader(7) + ", " + reader(8) + ", " + reader(9), reader(10))
                    Loop
                    Label4.Visible = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally

                    cmd.Dispose()
                    con.Close()
                End Try
            Else
                openCon()
                Try
                    cmd.Connection = con
                    cmd.CommandText = "SELECT crops_id, crops_type, crops_cat, crops_landarea, member.mem_lname, member.mem_fname, member.mem_mname, member.mem_barangay, member.mem_municipality, member.mem_province, member.mem_cp FROM `crops`, member where member.mem_id = crops.mem_id and crops.crops_cat = 'HVCDP'"
                    reader = cmd.ExecuteReader()
                    'dgrdmember.DataSource = table

                    dgrdcommo.Rows.Clear()
                    Do While reader.Read = True
                        dgrdcommo.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4) + ", " + reader(5) + " " + reader(6), reader(7) + ", " + reader(8) + ", " + reader(9), reader(10))
                    Loop
                    Label4.Visible = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally

                    cmd.Dispose()
                    con.Close()
                End Try

            End If
        End If

    End Sub

    Sub DataGridViewLayoutCrops()
        dgrdcommo.ColumnCount = 7
        dgrdcommo.Columns(0).Name = "ID"
        dgrdcommo.Columns(0).Visible = False
        dgrdcommo.Columns(1).Name = "Crops Type"
        dgrdcommo.Columns(1).Width = 120
        dgrdcommo.Columns(2).Name = "Crops Category"
        dgrdcommo.Columns(2).Width = 120
        dgrdcommo.Columns(3).Name = "Land Area"
        dgrdcommo.Columns(3).Width = 120
        dgrdcommo.Columns(4).Name = "Owner"
        dgrdcommo.Columns(4).Width = 250
        dgrdcommo.Columns(5).Name = "Address"
        dgrdcommo.Columns(5).Width = 250
        dgrdcommo.Columns(6).Name = "Contact Number"
        dgrdcommo.Columns(6).Width = 150
        dgrdcommo.Rows.Clear()
    End Sub

    Sub DataGridViewLayoutAnimals()
        dgrdcommo.ColumnCount = 7
        dgrdcommo.Columns(0).Name = "ID"
        dgrdcommo.Columns(0).Visible = False
        dgrdcommo.Columns(1).Name = "Animal Type"
        dgrdcommo.Columns(1).Width = 120
        dgrdcommo.Columns(2).Name = "Animal Category"
        dgrdcommo.Columns(2).Width = 120
        dgrdcommo.Columns(3).Name = "Number"
        dgrdcommo.Columns(3).Width = 120
        dgrdcommo.Columns(4).Name = "Owner"
        dgrdcommo.Columns(4).Width = 250
        dgrdcommo.Columns(5).Name = "Address"
        dgrdcommo.Columns(5).Width = 250
        dgrdcommo.Columns(6).Name = "Contact Number"
        dgrdcommo.Columns(6).Width = 150
        dgrdcommo.Rows.Clear()
    End Sub

End Class