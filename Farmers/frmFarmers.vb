Public Class frmFarmers

    Private Sub frmFarmers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
        loadTable2()
        Label4.Parent = dgrdmember
        Label4.Visible = False


    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmtransac.lblAddEdit.Text = "ADD NEW FARMER"
        frmtransac.btnSaveUpdate.Text = "Save"
        frmtransac.txtSGR.Visible = False
        frmtransac.lblSGR.Visible = False
        frmtransac.ShowDialog()
    End Sub

    'Sub loadTable()
    '    openCon()
    '    Try
    '        cmd.Connection = con
    '        cmd.CommandText = "SELECT * FROM member"
    '        adapter.SelectCommand = cmd
    '        table.Clear()
    '        adapter.Fill(table)
    '        'dgrdmember.DataSource = table


    '        If table.Rows.Count > 0 Then
    '            For i = 0 To table.Rows.Count - 1
    '                dgrdmember.Rows.Add()
    '                For j = 0 To table.Columns.Count - 1
    '                    dgrdmember.Rows(i).Cells(j).Value = table.Rows(i).Item(j).ToString
    '                Next

    '            Next

    '        End If
    '        Label4.Visible = False

    '        con.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    'End Sub

    Sub loadTable2()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM member"
            reader = cmd.ExecuteReader()
            'dgrdmember.DataSource = table

            dgrdmember.Rows.Clear()
            Do While reader.Read = True
                dgrdmember.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9), reader(10), reader(12), reader(13), reader(14), reader(15))
            Loop
            Label4.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            con.Close()
        End Try


    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'openCon()
        'Dim search = txtSearch.Text
        'Try
        '    With cmd
        '        .Connection = con
        '        .CommandText = "SELECT * FROM member WHERE CONCAT_WS(mem_fname, mem_mname, mem_lname) LIKE '%" & search & "%'"
        '        adapter.SelectCommand = cmd
        '        table.Clear()
        '        adapter.Fill(table)
        '        dgrdmember.Rows.Clear()

        '        If table.Rows.Count > 0 Then
        '            For i = 0 To table.Rows.Count - 1
        '                dgrdmember.Rows.Add()
        '                For j = 0 To table.Columns.Count - 1
        '                    dgrdmember.Rows(i).Cells(j).Value = table.Rows(i).Item(j).ToString
        '                Next
        '            Next
        '            Label4.Visible = False

        '        ElseIf search = "" Then
        '            con.Close()
        '            loadTable()
        '        Else
        '            Label4.Visible = True
        '        End If
        '    End With
        '    con.Close()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
        Dim search = txtSearch.Text
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM member WHERE CONCAT_WS(mem_fname, mem_mname, mem_lname) LIKE '%" & search & "%'"
            reader = cmd.ExecuteReader()
            'dgrdmember.DataSource = table


            dgrdmember.Rows.Clear()
            If reader.HasRows Then
                Do While reader.Read = True
                    dgrdmember.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9), reader(10), reader(12), reader(13), reader(14), reader(15))

                Loop

                Label4.Visible = False
            Else
                Label4.Visible = True
            End If


            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmtransac.lblAddEdit.Text = "EDIT FARMER"
        frmtransac.btnSaveUpdate.Text = "Update"
        GlobalId = dgrdmember.CurrentRow.Cells(0).Value
        With frmtransac
            .txtSGR.Visible = True
            .lblSGR.Visible = True

            Try
                openCon()
                With cmd
                    .Connection = con
                    .CommandText = ("SELECT * FROM member WHERE mem_id=" & GlobalId & "")
                    reader = cmd.ExecuteReader()
                    Do While reader.Read = True
                        SGRSBSA = reader("mem_system_generated_rsbsa_no")
                        RSBSA = reader("mem_rsbsa_no")
                        LNAME = reader("mem_lname")
                        FNAME = reader("mem_fname")
                        MNAME = reader("mem_mname")
                        extNAME = reader("mem_extname")
                        BARANGAY = reader("mem_barangay")
                        MUNICIPALITY = reader("mem_municipality")
                        PROVINCE = reader("mem_province")
                        SEX = reader("mem_sex")
                        CONTACT = reader("mem_cp")
                        DATEOFBRITH = reader("mem_dob")
                        PLACEOFBRITH = reader("mem_pob")
                        CIVILSTATUS = reader("mem_civilstatus")
                        NAMEOFSPOUSE = reader("mem_spouse")

                        frmtransac.txtSGR.Text = SGRSBSA
                        frmtransac.txtRSBSA.Text = RSBSA
                        frmtransac.txtlname.Text = LNAME
                        frmtransac.txtfname.Text = FNAME
                        frmtransac.txtmname.Text = MNAME
                        frmtransac.txtExtName.Text = extNAME
                        frmtransac.cmbbarangay.Text = BARANGAY
                        frmtransac.txtMunicipality.Text = MUNICIPALITY
                        frmtransac.txtProvince.Text = PROVINCE
                        frmtransac.txtContactNo.Text = CONTACT
                        frmtransac.dtpDateOfBirth.Text = DATEOFBRITH
                        frmtransac.txtPlaceOfBirth.Text = PLACEOFBRITH
                        frmtransac.cbCivilStatus.Text = CIVILSTATUS
                        frmtransac.txtSpouse.Text = NAMEOFSPOUSE

                        If SEX = "Male" Then
                            frmtransac.radMale.Checked = True
                        Else
                            frmtransac.radFemale.Checked = True
                        End If
                    Loop
                End With
                con.Close()
                ViewEdit_FarmProfile()
                ViewEdit_Crops()
                ViewEdit_Animals()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Finally
                con.Close()
                adapter.Dispose()
            End Try

            .ShowDialog()
        End With
    End Sub

    Sub ViewEdit_Crops()
        openCon()
        Try
            With cmd
                .Connection = con
                .CommandText = ("SELECT crops_type, crops_landarea, crops_id FROM crops WHERE mem_id=" & GlobalId & "")
                reader = cmd.ExecuteReader()
                Do While reader.Read = True
                    Select Case reader(0)
                        Case "Rice"
                            RICEID = reader(2)
                            frmtransac.chkRice.Checked = True
                            frmtransac.txtRice.Text = reader(1)
                        Case "Corn"
                            frmtransac.chkCorn.Checked = True
                            frmtransac.txtCorn.Text = reader(1)
                        Case "Coconut"
                            frmtransac.chkCoconut.Checked = True
                            frmtransac.txtCoconut.Text = reader(1)
                        Case "Vegetables"
                            VEGETABLESID = reader(2)
                            frmtransac.chkHVCDP.Checked = True
                            frmtransac.chkVegetables.Checked = True
                            frmtransac.txtVegetables.Text = reader(1)
                        Case "Fruits"
                            frmtransac.chkHVCDP.Checked = True
                            frmtransac.chkFruits.Checked = True
                            frmtransac.txtFruits.Text = reader(1)
                        Case "Root Crops"
                            ROOTCROPSID = reader(2)
                            frmtransac.chkHVCDP.Checked = True
                            frmtransac.chkRootCrops.Checked = True
                            frmtransac.txtRootCrops.Text = reader(1)
                    End Select
                Loop
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
            adapter.Dispose()
        End Try
    End Sub

    Sub ViewEdit_Animals()
        openCon()
        Try
            With cmd
                .Connection = con
                .CommandText = ("SELECT animal_type, animal_no, animal_id FROM animal WHERE mem_id=" & GlobalId & "")
                reader = cmd.ExecuteReader()
                Do While reader.Read = True
                    Select Case reader(0)
                        Case "Carabao"
                            CARABAOID = reader(2)
                            frmtransac.chkCarabao.Checked = True
                            frmtransac.txtCarabao.Text = reader(1)
                        Case "Cattle"
                            CATTLEID = reader(2)
                            frmtransac.chkCattle.Checked = True
                            frmtransac.txtCattle.Text = reader(1)
                        Case "Swine"
                            SWINEID = reader(2)
                            frmtransac.chkSwine.Checked = True
                            frmtransac.txtSwine.Text = reader(1)
                        Case "Goat"
                            GOATID = reader(2)
                            frmtransac.chkGoat.Checked = True
                            frmtransac.txtGoat.Text = reader(1)
                        Case "Chicken"
                            CHICKENID = reader(2)
                            frmtransac.chkChicken.Checked = True
                            frmtransac.txtChicken.Text = reader(1)
                        Case "Duck"
                            DUCKID = reader(2)
                            frmtransac.chkDuck.Checked = True
                            frmtransac.txtDuck.Text = reader(1)
                        Case "Turkey"
                            TURKEYID = reader(2)
                            frmtransac.chkTurkey.Checked = True
                            frmtransac.txtTurkey.Text = reader(1)
                        Case "Goose"
                            GOOSEID = reader(2)
                            frmtransac.chkGoose.Checked = True
                            frmtransac.txtGoose.Text = reader(1)
                        Case "Dog"
                            DOGID = reader(2)
                            frmtransac.chkDog.Checked = True
                            frmtransac.txtDog.Text = reader(1)
                        Case "Cat"
                            CATTLEID = reader(2)
                            frmtransac.chkCat.Checked = True
                            frmtransac.txtCat.Text = reader(1)
                    End Select
                Loop
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
            adapter.Dispose()
        End Try
    End Sub

    Sub ViewEdit_FarmProfile()
        openCon()
        Try
            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM `farm_profile` WHERE mem_id=" & GlobalId & ""
                reader = cmd.ExecuteReader()
                Do While reader.Read = True
                    FARM_ID = reader("farm_id")
                    FARMLOCATION = reader("farm_location")
                    FARMTYPE = reader("farm_type")
                    FARM_AREA = reader("farm_area")
                    FARM_OWNERTYPE = reader("farm_ownertype")
                    FARM_OWNER = reader("farm_owner")
                    BOUNDARY_NORTH = reader("farm_boundary_north")
                    BOUNDARY_EAST = reader("farm_boundary_east")
                    BOUNDARY_WEST = reader("farm_boundary_west")
                    BOUNDARY_SOUTH = reader("farm_boundary_south")

                    frmtransac.txtLocation.Text = FARMLOCATION
                    frmtransac.cbFarmType.Text = FARMTYPE
                    frmtransac.txtFarmArea.Text = FARM_AREA
                    frmtransac.cbTypeOwnership.Text = FARM_OWNERTYPE
                    frmtransac.txtOwner.Text = FARM_OWNER
                    frmtransac.txtNorth.Text = BOUNDARY_NORTH
                    frmtransac.txtEast.Text = BOUNDARY_EAST
                    frmtransac.txtWest.Text = BOUNDARY_WEST
                    frmtransac.txtSouth.Text = BOUNDARY_SOUTH
                Loop
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
            adapter.Dispose()
        End Try
    End Sub

    Private Sub chkByBarangay_CheckedChanged(sender As Object, e As EventArgs) Handles chkByBarangay.CheckedChanged
        If chkByBarangay.Checked = True Then
            openCon()
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM `member` ORDER BY `member`.`mem_barangay` ASC"
                reader = cmd.ExecuteReader()
                'dgrdmember.DataSource = table

                dgrdmember.Rows.Clear()
                Do While reader.Read = True
                    dgrdmember.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9), reader(10), reader(12), reader(13), reader(14), reader(15))
                Loop
                Label4.Visible = False
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                cmd.Dispose()
                con.Close()
            End Try
        Else
            loadTable2()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        GlobalId = dgrdmember.CurrentRow.Cells(0).Value
        If MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion) = vbYes Then
            Try
                openCon()
                Try
                    With cmd
                        .Connection = con
                        .CommandText = ("DELETE FROM `member` WHERE mem_id = " & GlobalId & "")
                        .ExecuteNonQuery()
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                Finally
                    con.Close()
                End Try


                openCon()
                Try
                    With cmd
                        .Connection = con
                        .CommandText = ("DELETE FROM `crops` WHERE crops_id = " & GlobalId & "")
                        .ExecuteNonQuery()
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                Finally
                    con.Close()
                End Try

                openCon()
                Try
                    With cmd
                        .Connection = con
                        .CommandText = ("DELETE FROM `animal` WHERE animal_id = " & GlobalId & "")
                        .ExecuteNonQuery()
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                Finally
                    con.Close()
                End Try
                MsgBox("Successfully deleted.")
                loadTable2()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Finally
                con.Close()
            End Try
        End If



    End Sub
End Class