Public Class frmtransac

    Private Sub frmtransac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Button3.Enabled = False
        If cbCivilStatus.SelectedIndex = 1 Then
            txtSpouse.Enabled = True
        End If
        TabControl1.SelectedTab = TabPage1

    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    TabControl1.SelectedTab = TabPage1
    '    Button2.BackColor = Color.FromArgb(26, 188, 156)
    '    Button3.BackColor = Color.FromArgb(46, 204, 113)
    '    Button4.BackColor = Color.FromArgb(46, 204, 113)

    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    TabControl1.SelectedTab = TabPage2
    '    Button3.BackColor = Color.FromArgb(26, 188, 156)
    '    Button4.BackColor = Color.FromArgb(46, 204, 113)
    '    Button2.BackColor = Color.FromArgb(46, 204, 113)
    'End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    TabControl1.SelectedTab = TabPage3
    '    Button4.BackColor = Color.FromArgb(26, 188, 156)
    '    Button3.BackColor = Color.FromArgb(46, 204, 113)
    '    Button2.BackColor = Color.FromArgb(46, 204, 113)

    'End Sub


    Private Sub btnSaveUpdate_Click(sender As Object, e As EventArgs) Handles btnSaveUpdate.Click
        If cmbbarangay.SelectedItem = Nothing Then
            BARANGAY = cmbbarangay.Text
        Else
            BARANGAY = cmbbarangay.SelectedItem
        End If
        If radMale.Checked = True Then
            SEX = "Male"
        Else
            SEX = "Female"
        End If
        SGRSBSA_NUMBER()
        openCon()
        Try
            If btnSaveUpdate.Text = "Save" Then
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO `member`(`mem_system_generated_rsbsa_no`, `mem_rsbsa_no`, `mem_fname`, `mem_lname`, `mem_mname`, `mem_extname`, `mem_barangay`, `mem_municipality`, `mem_province`, `mem_dob`, `mem_pob`, `mem_sex`, `mem_cp`, `mem_civilstatus`, `mem_spouse`) VALUES 
                                (@SGRSBSA, @RSBSA, @FNAME, @LNAME, @MNAME, @EXTNAME, @BARANGAY, @MUNICIPALITY, @PROVINCE, @DOB, @POB, @SEX, @CONTACT, @CIVILSTATUS, @SPOUSE)"
                With cmd
                    .Parameters.AddWithValue("@SGRSBSA", SGRSBSA)
                    .Parameters.AddWithValue("@RSBSA", txtRSBSA.Text)
                    .Parameters.AddWithValue("@FNAME", txtfname.Text)
                    .Parameters.AddWithValue("@LNAME", txtlname.Text)
                    .Parameters.AddWithValue("@MNAME", txtmname.Text)
                    .Parameters.AddWithValue("@EXTNAME", txtExtName.Text)
                    .Parameters.AddWithValue("@BARANGAY", BARANGAY)
                    .Parameters.AddWithValue("@MUNICIPALITY", txtMunicipality.Text)
                    .Parameters.AddWithValue("@PROVINCE", txtProvince.Text)
                    .Parameters.AddWithValue("@DOB", Format(dtpDateOfBirth.Value, "yyyy-MM-dd"))
                    .Parameters.AddWithValue("@POB", txtPlaceOfBirth.Text)
                    .Parameters.AddWithValue("@SEX", SEX)
                    .Parameters.AddWithValue("@CONTACT", txtContactNo.Text)
                    .Parameters.AddWithValue("@CIVILSTATUS", cbCivilStatus.SelectedItem)
                    .Parameters.AddWithValue("@SPOUSE", txtSpouse.Text)
                End With
                cmd.ExecuteNonQuery()

            ElseIf btnSaveUpdate.Text = "Update" Then
                cmd.Connection = con
                cmd.CommandText = "UPDATE `member` SET `mem_system_generated_rsbsa_no`= @SGRSBSA,`mem_rsbsa_no`= @RSBSA,`mem_fname`= @FNAME,
                                `mem_lname`= @LNAME,`mem_mname`= @MNAME,`mem_extname`= @EXTNAME,`mem_barangay`= @BARANGAY,`mem_municipality`= @MUNICIPALITY,
                                `mem_province`= @PROVINCE,`mem_dob`= @DOB,`mem_pob`= @POB,`mem_sex`= @SEX,`mem_cp`= @CONTACT,`mem_civilstatus`=@CIVILSTATUS,
                                `mem_spouse`= @SPOUSE WHERE `mem_id`= @MEM_ID"
                With cmd
                    .Parameters.AddWithValue("@SGRSBSA", txtSGR.Text)
                    .Parameters.AddWithValue("@RSBSA", txtRSBSA.Text)
                    .Parameters.AddWithValue("@FNAME", txtfname.Text)
                    .Parameters.AddWithValue("@LNAME", txtlname.Text)
                    .Parameters.AddWithValue("@MNAME", txtmname.Text)
                    .Parameters.AddWithValue("@EXTNAME", txtExtName.Text)
                    .Parameters.AddWithValue("@BARANGAY", BARANGAY)
                    .Parameters.AddWithValue("@MUNICIPALITY", txtMunicipality.Text)
                    .Parameters.AddWithValue("@PROVINCE", txtProvince.Text)
                    .Parameters.AddWithValue("@DOB", Format(dtpDateOfBirth.Value, "yyyy-MM-dd"))
                    .Parameters.AddWithValue("@POB", txtPlaceOfBirth.Text)
                    .Parameters.AddWithValue("@SEX", SEX)
                    .Parameters.AddWithValue("@CONTACT", txtContactNo.Text)
                    .Parameters.AddWithValue("@CIVILSTATUS", cbCivilStatus.SelectedItem)
                    .Parameters.AddWithValue("@SPOUSE", txtSpouse.Text)
                    .Parameters.AddWithValue("@MEM_ID", GlobalId)
                End With
                cmd.ExecuteNonQuery()
            End If
            SGRSBSA = ""
            con.Close()
            InsertFarmProfile()
            CHECKBOX_INSERT()
            Call loadTable()
            MsgBox("Successfullly Added Record!")
            ClearAll()
            ClearTextBox(Me)
            ClearCheckBox(Me)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            con.Close()
        End Try



    End Sub

    Private Sub cbCivilStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCivilStatus.SelectedIndexChanged

        If cbCivilStatus.SelectedIndex = 1 Then
            txtSpouse.Enabled = True
            txtSpouse.BackColor = Color.White
            txtSpouse.Focus()
        Else
            txtSpouse.Enabled = False
            txtSpouse.BackColor = Color.FromArgb(227, 227, 227)
            txtSpouse.Clear()
        End If

    End Sub

    Private Sub dtpDateOfBirth_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateOfBirth.ValueChanged
        dtpDateOfBirth.MaxDate = DateTime.Today
        DATEOFBRITH = Format(dtpDateOfBirth.Value, "yyyy-MM-dd")

    End Sub

    'Sub countsgmember()
    '    openCon()
    '    Dim ROWCOUNT As Integer
    '    Dim COUNT As String
    '    With cmd
    '        .Connection = con
    '        .CommandText = "SELECT COUNT(mem_barangay) FROM member WHERE mem_barangay = '" & cmbbarangay.SelectedItem & "'"
    '        ROWCOUNT = cmd.ExecuteScalar
    '        COUNT = ROWCOUNT + 1.ToString
    '        COUNT = COUNT.PadLeft(6, "0")
    '        BRGYSUFFIX = cmbbarangay.SelectedIndex + 1.ToString
    '        BRGYSUFFIX = BRGYSUFFIX.PadLeft(3, "0")
    '        SGRSBSA = SGPREFIX + BRGYSUFFIX + "-" + COUNT
    '        con.Close()
    '    End With
    'End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    countsgmember()
    '    txtRSBSA.Text = SGRSBSA
    'End Sub

    Private Sub cbTypeOwnership_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTypeOwnership.SelectedIndexChanged
        If cbTypeOwnership.SelectedIndex <> 0 Then
            txtOwner.Enabled = True
            txtOwner.BackColor = Color.White
            txtOwner.Focus()

        Else
            txtOwner.Enabled = False
            txtOwner.BackColor = Color.FromArgb(227, 227, 227)
            txtOwner.Clear()
        End If
    End Sub


    'COMMODITIES CHECKED CHANGED
    Private Sub chkRice_CheckedChanged(sender As Object, e As EventArgs) Handles chkRice.CheckedChanged
        If chkRice.Checked = True Then
            txtRice.Enabled = True
            txtRice.BackColor = Color.White
            txtRice.Focus()

        Else
            txtRice.Enabled = False
            txtRice.Clear()
            txtRice.BackColor = Color.FromArgb(227, 227, 227)
        End If
    End Sub

    Private Sub chkCorn_CheckedChanged(sender As Object, e As EventArgs) Handles chkCorn.CheckedChanged
        If chkCorn.Checked = True Then
            txtCorn.Enabled = True
            txtCorn.BackColor = Color.White
            txtCorn.Focus()
        Else
            txtCorn.Enabled = False
            txtCorn.Clear()
            txtCorn.BackColor = Color.FromArgb(227, 227, 227)
        End If
    End Sub

    Private Sub chkCoconut_CheckedChanged(sender As Object, e As EventArgs) Handles chkCoconut.CheckedChanged
        If chkCoconut.Checked = True Then
            txtCoconut.Enabled = True
            txtCoconut.BackColor = Color.White
            txtCoconut.Focus()
        Else
            txtCoconut.Enabled = False
            txtCoconut.Clear()
            txtCoconut.BackColor = Color.FromArgb(227, 227, 227)
        End If
    End Sub

    Private Sub chkHVCDP_CheckedChanged(sender As Object, e As EventArgs) Handles chkHVCDP.CheckedChanged
        If chkHVCDP.Checked = True Then
            chkVegetables.Enabled = True
            chkFruits.Enabled = True
            chkRootCrops.Enabled = True
        Else
            chkVegetables.Enabled = False
            chkFruits.Enabled = False
            chkRootCrops.Enabled = False
            txtRootCrops.Clear()
            txtFruits.Clear()
            txtVegetables.Clear()
        End If
    End Sub

    Private Sub chkVegetables_CheckedChanged(sender As Object, e As EventArgs) Handles chkVegetables.CheckedChanged
        If chkVegetables.Checked = True Then
            txtVegetables.Enabled = True
            txtVegetables.BackColor = Color.White
            txtVegetables.Focus()
        Else
            txtVegetables.Enabled = False
            txtVegetables.Clear()
            txtVegetables.BackColor = Color.FromArgb(227, 227, 227)
        End If
    End Sub

    Private Sub chkFruits_CheckedChanged(sender As Object, e As EventArgs) Handles chkFruits.CheckedChanged
        If chkFruits.Checked = True Then
            txtFruits.Enabled = True
            txtFruits.BackColor = Color.White
            txtFruits.Focus()
        Else
            txtFruits.Enabled = False
            txtFruits.Clear()
            txtFruits.BackColor = Color.FromArgb(227, 227, 227)
        End If
    End Sub

    Private Sub chkRootCrops_CheckedChanged(sender As Object, e As EventArgs) Handles chkRootCrops.CheckedChanged
        If chkRootCrops.Checked = True Then
            txtRootCrops.Enabled = True
            txtRootCrops.BackColor = Color.White
            txtRootCrops.Focus()
        Else
            txtRootCrops.Enabled = False
            txtRootCrops.Clear()
            txtRootCrops.BackColor = Color.FromArgb(227, 227, 227)
        End If
    End Sub

    Private Sub chkCarabao_CheckedChanged(sender As Object, e As EventArgs) Handles chkCarabao.CheckedChanged
        If chkCarabao.Checked = True Then
            txtCarabao.Enabled = True
            txtCarabao.BackColor = Color.White
            txtCarabao.Focus()
        Else
            txtCarabao.Enabled = False
            txtCarabao.Clear()
            txtCarabao.BackColor = Color.FromArgb(227, 227, 227)
        End If
    End Sub

    Private Sub chkCattle_CheckedChanged(sender As Object, e As EventArgs) Handles chkCattle.CheckedChanged
        If chkCattle.Checked = True Then
            txtCattle.Enabled = True
            txtCattle.BackColor = Color.White
            txtCattle.Focus()
        Else
            txtCattle.Enabled = False
            txtCattle.Clear()
            txtCattle.BackColor = Color.FromArgb(227, 227, 227)
        End If
    End Sub

    Private Sub chkSwine_CheckedChanged(sender As Object, e As EventArgs) Handles chkSwine.CheckedChanged
        If chkSwine.Checked = True Then
            txtSwine.Enabled = True
            txtSwine.BackColor = Color.White
            txtSwine.Focus()
        Else
            txtSwine.Enabled = False
            txtSwine.Clear()
            txtSwine.BackColor = Color.FromArgb(227, 227, 227)
        End If
    End Sub

    Private Sub chkGoat_CheckedChanged(sender As Object, e As EventArgs) Handles chkGoat.CheckedChanged
        If chkGoat.Checked = True Then
            txtGoat.Enabled = True
            txtGoat.BackColor = Color.White
            txtGoat.Focus()
        Else
            txtGoat.Enabled = False
            txtGoat.Clear()
            txtGoat.BackColor = Color.FromArgb(227, 227, 227)
        End If
    End Sub

    Private Sub chkChicken_CheckedChanged(sender As Object, e As EventArgs) Handles chkChicken.CheckedChanged
        If chkChicken.Checked = True Then
            txtChicken.Enabled = True
            txtChicken.BackColor = Color.White
            txtChicken.Focus()
        Else
            txtChicken.Enabled = False
            txtChicken.Clear()
            txtChicken.BackColor = Color.FromArgb(227, 227, 227)
        End If
    End Sub

    Private Sub chkDuck_CheckedChanged(sender As Object, e As EventArgs) Handles chkDuck.CheckedChanged
        If chkDuck.Checked = True Then
            txtDuck.Enabled = True
            txtDuck.BackColor = Color.White
            txtDuck.Focus()
        Else
            txtDuck.Enabled = False
            txtDuck.Clear()
            txtDuck.BackColor = Color.FromArgb(227, 227, 227)
        End If
    End Sub

    Private Sub chkTurkey_CheckedChanged(sender As Object, e As EventArgs) Handles chkTurkey.CheckedChanged
        If chkTurkey.Checked = True Then
            txtTurkey.Enabled = True
            txtTurkey.BackColor = Color.White
            txtTurkey.Focus()
        Else
            txtTurkey.Enabled = False
            txtTurkey.Clear()
            txtTurkey.BackColor = Color.FromArgb(227, 227, 227)
        End If
    End Sub

    Private Sub chkGoose_CheckedChanged(sender As Object, e As EventArgs) Handles chkGoose.CheckedChanged
        If chkGoose.Checked = True Then
            txtGoose.Enabled = True
            txtGoose.BackColor = Color.White
            txtGoose.Focus()
        Else
            txtGoose.Enabled = False
            txtGoose.Clear()
            txtGoose.BackColor = Color.FromArgb(227, 227, 227)
        End If
    End Sub

    Private Sub chkDog_CheckedChanged(sender As Object, e As EventArgs) Handles chkDog.CheckedChanged
        If chkDog.Checked = True Then
            txtDog.Enabled = True
            txtDog.BackColor = Color.White
            txtDog.Focus()
        Else
            txtDog.Enabled = False
            txtDog.Clear()
            txtDog.BackColor = Color.FromArgb(227, 227, 227)
        End If
    End Sub

    Private Sub chkCat_CheckedChanged(sender As Object, e As EventArgs) Handles chkCat.CheckedChanged
        If chkCat.Checked = True Then
            txtCat.Enabled = True
            txtCat.BackColor = Color.White
            txtCat.Focus()
        Else
            txtCat.Enabled = False
            txtCat.Clear()
            txtCat.BackColor = Color.FromArgb(227, 227, 227)
        End If
    End Sub


    Private Sub txtFarmArea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFarmArea.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))

    End Sub

    'BUTTON NEXT/PREVIOUS
    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click
        TabControl1.SelectedTab = TabPage2
        Button3.BackColor = Color.FromArgb(26, 188, 156)
        Button4.BackColor = Color.FromArgb(46, 204, 113)
        Button2.BackColor = Color.FromArgb(46, 204, 113)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        TabControl1.SelectedTab = TabPage1
        Button2.BackColor = Color.FromArgb(26, 188, 156)
        Button3.BackColor = Color.FromArgb(46, 204, 113)
        Button4.BackColor = Color.FromArgb(46, 204, 113)
    End Sub

    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        TabControl1.SelectedTab = TabPage3
        Button4.BackColor = Color.FromArgb(26, 188, 156)
        Button3.BackColor = Color.FromArgb(46, 204, 113)
        Button2.BackColor = Color.FromArgb(46, 204, 113)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrevious2_Click(sender As Object, e As EventArgs) Handles btnPrevious2.Click
        TabControl1.SelectedTab = TabPage2
        Button3.BackColor = Color.FromArgb(26, 188, 156)
        Button4.BackColor = Color.FromArgb(46, 204, 113)
        Button2.BackColor = Color.FromArgb(46, 204, 113)
    End Sub

    'INSERT FARM PROFILE
    Sub InsertFarmProfile()
        MAXXID()

        openCon()
        Try
            If btnSaveUpdate.Text = "Save" Then
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO `farm_profile`(`farm_location`, `farm_type`, `farm_area`, `farm_ownertype`, `farm_owner`, `farm_boundary_north`, `farm_boundary_south`, `farm_boundary_east`, `farm_boundary_west`, `mem_id`) 
                                VALUES (@LOCATION, @FARMTYPE, @FARM_AREA, @OWNERTYPE, @OWNER, @NORTH, @SOUTH, @EAST,@WEST, @FARMMEM_ID)"
                With cmd
                    .Parameters.AddWithValue("@LOCATION", txtLocation.Text)
                    .Parameters.AddWithValue("@FARMTYPE", cbFarmType.Text)
                    .Parameters.AddWithValue("@FARM_AREA", txtFarmArea.Text)
                    .Parameters.AddWithValue("@OWNERTYPE", cbTypeOwnership.Text)
                    .Parameters.AddWithValue("@OWNER", txtOwner.Text)
                    .Parameters.AddWithValue("@NORTH", txtNorth.Text)
                    .Parameters.AddWithValue("@SOUTH", txtSouth.Text)
                    .Parameters.AddWithValue("@EAST", txtEast.Text)
                    .Parameters.AddWithValue("@WEST", txtWest.Text)
                    .Parameters.AddWithValue("@FARMMEM_ID", MAXID)
                End With
                cmd.ExecuteNonQuery()

            ElseIf btnSaveUpdate.Text = "Update" Then
                cmd.Connection = con
                cmd.CommandText = "UPDATE `farm_profile` SET `farm_location`= @LOCATION,`farm_type`= @FARMTYPE ,`farm_area`= @FARM_AREA ,`farm_ownertype`= @OWNERTYPE,`farm_owner`= @OWNER,
                                    `farm_boundary_north`= @NORTH,`farm_boundary_south`= @SOUTH,`farm_boundary_east`= @EAST,`farm_boundary_west`= @WEST WHERE `farm_profile`.`farm_id` = FARM_ID AND `farm_profile`.`mem_id` = @FARMMEM_ID"
                With cmd
                    .Parameters.AddWithValue("@LOCATION", txtLocation.Text)
                    .Parameters.AddWithValue("@FARMTYPE", cbFarmType.Text)
                    .Parameters.AddWithValue("@FARM_AREA", txtFarmArea.Text)
                    .Parameters.AddWithValue("@OWNERTYPE", cbTypeOwnership.Text)
                    .Parameters.AddWithValue("@OWNER", txtOwner.Text)
                    .Parameters.AddWithValue("@NORTH", txtNorth.Text)
                    .Parameters.AddWithValue("@SOUTH", txtSouth.Text)
                    .Parameters.AddWithValue("@EAST", txtEast.Text)
                    .Parameters.AddWithValue("@WEST", txtWest.Text)
                    .Parameters.AddWithValue("@FARMMEM_ID", GlobalId)
                    .Parameters.AddWithValue("@FARM_ID", FARM_ID)
                End With
                cmd.ExecuteNonQuery()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    'MAX ID
    Sub MAXXID()
        openCon()
        With cmd
            .Connection = con
            .CommandText = "SELECT MAX(mem_id) FROM `member`"
            MAXID = cmd.ExecuteScalar
            .Dispose()
            con.Close()
        End With
    End Sub

    'SGRSBSA NUMBER
    Sub SGRSBSA_NUMBER()
        openCon()
        Dim ROWCOUNT As Integer
        Dim COUNT As String
        With cmd
            .Connection = con
            .CommandText = "SELECT COUNT(mem_barangay) FROM member WHERE mem_barangay = '" & cmbbarangay.SelectedItem & "'"
            ROWCOUNT = cmd.ExecuteScalar
            COUNT = ROWCOUNT + 1.ToString
            COUNT = COUNT.PadLeft(6, "0")
            BRGYSUFFIX = cmbbarangay.SelectedIndex + 1.ToString
            BRGYSUFFIX = BRGYSUFFIX.PadLeft(3, "0")
            SGRSBSA = SGPREFIX + BRGYSUFFIX + "-" + COUNT
            .Dispose()
            con.Close()
        End With
    End Sub

    'COMMODITIES KEY PRESS NUMBER ONLY 
    Private Sub txtRice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRice.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub txtCorn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorn.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub txtCoconut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCoconut.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub txtVegetables_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVegetables.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub txtFruits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFruits.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub txtRootCrops_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRootCrops.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub txtCarabao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCarabao.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCattle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCattle.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSwine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSwine.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtGoat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGoat.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtChicken_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtChicken.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDuck_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDuck.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTurkey_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTurkey.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtGoose_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGoose.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDog_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDog.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCat.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    'COMMODITIES CHECKBOX INSERT
    Sub CHECKBOX_INSERT()
        If chkRice.Checked = True Then
            CROP_LANDAREA = txtRice.Text
            CROP_CATEGORIES = "Rice"
            CROP_TYPE = "Rice"
            CROP_ID = RICEID
            MEM_ID = GlobalId
            Success = Checkbox_Crops_function(CROP_LANDAREA, CROP_CATEGORIES, CROP_TYPE, CROP_ID, MEM_ID)
        End If

        If chkCorn.Checked = True Then
            CROP_LANDAREA = txtCorn.Text
            CROP_CATEGORIES = "Corn"
            CROP_TYPE = "Corn"
            CROP_ID = CORNID
            MEM_ID = GlobalId
            Success = Checkbox_Crops_function(CROP_LANDAREA, CROP_CATEGORIES, CROP_TYPE, CROP_ID, MEM_ID)
        End If

        If chkCoconut.Checked = True Then
            CROP_LANDAREA = txtCoconut.Text
            CROP_CATEGORIES = "Coconut"
            CROP_TYPE = "Coconut"
            CROP_ID = COCONUTID
            MEM_ID = GlobalId
            Success = Checkbox_Crops_function(CROP_LANDAREA, CROP_CATEGORIES, CROP_TYPE, CROP_ID, MEM_ID)
        End If

        If chkVegetables.Checked = True Then
            CROP_LANDAREA = txtVegetables.Text
            CROP_CATEGORIES = "HVCDP"
            CROP_TYPE = "Vegetables"
            CROP_ID = VEGETABLESID
            MEM_ID = GlobalId
            Success = Checkbox_Crops_function(CROP_LANDAREA, CROP_CATEGORIES, CROP_TYPE, CROP_ID, MEM_ID)
        End If

        If chkFruits.Checked = True Then
            CROP_LANDAREA = txtFruits.Text
            CROP_CATEGORIES = "HVCDP"
            CROP_TYPE = "Fruits"
            CROP_ID = FRUITSID
            MEM_ID = GlobalId
            Success = Checkbox_Crops_function(CROP_LANDAREA, CROP_CATEGORIES, CROP_TYPE, CROP_ID, MEM_ID)
        End If
        If chkRootCrops.Checked = True Then
            CROP_LANDAREA = txtRootCrops.Text
            CROP_CATEGORIES = "HVCDP"
            CROP_TYPE = "Root Crops"
            CROP_ID = ROOTCROPSID
            MEM_ID = GlobalId
            Success = Checkbox_Crops_function(CROP_LANDAREA, CROP_CATEGORIES, CROP_TYPE, CROP_ID, MEM_ID)
        End If

        If chkCarabao.Checked = True Then
            ANIMAL_QTY = txtCarabao.Text
            ANIMAL_CATEGORIES = "Livestock"
            ANIMAL_TYPE = "Carabao"
            ANIMAL_ID = CARABAOID
            MEM_ID = GlobalId
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If chkCattle.Checked = True Then
            ANIMAL_QTY = txtCattle.Text
            ANIMAL_CATEGORIES = "Livestock"
            ANIMAL_TYPE = "Cattle"
            ANIMAL_ID = CATTLEID
            MEM_ID = GlobalId
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If chkSwine.Checked = True Then
            ANIMAL_QTY = txtSwine.Text
            ANIMAL_CATEGORIES = "Livestock"
            ANIMAL_TYPE = "Swine"
            ANIMAL_ID = SWINEID
            MEM_ID = GlobalId
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If chkGoat.Checked = True Then
            ANIMAL_QTY = txtGoat.Text
            ANIMAL_CATEGORIES = "Livestock"
            ANIMAL_TYPE = "Goat"
            ANIMAL_ID = GOATID
            MEM_ID = GlobalId
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If chkChicken.Checked = True Then
            ANIMAL_QTY = txtChicken.Text
            ANIMAL_CATEGORIES = "Poultry"
            ANIMAL_TYPE = "Chicken"
            ANIMAL_ID = CHICKENID
            MEM_ID = GlobalId
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If chkDuck.Checked = True Then
            ANIMAL_QTY = txtDuck.Text
            ANIMAL_CATEGORIES = "Poultry"
            ANIMAL_TYPE = "Duck"
            ANIMAL_ID = DUCKID
            MEM_ID = GlobalId
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If chkTurkey.Checked = True Then
            ANIMAL_QTY = txtTurkey.Text
            ANIMAL_CATEGORIES = "Poultryy"
            ANIMAL_TYPE = "Turkey"
            ANIMAL_ID = TURKEYID
            MEM_ID = GlobalId
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If chkGoose.Checked = True Then
            ANIMAL_QTY = txtGoose.Text
            ANIMAL_CATEGORIES = "Poultry"
            ANIMAL_TYPE = "Goose"
            ANIMAL_ID = GOOSEID
            MEM_ID = GlobalId
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If chkDog.Checked = True Then
            ANIMAL_QTY = txtDog.Text
            ANIMAL_CATEGORIES = "Other Animals"
            ANIMAL_TYPE = "Dog"
            ANIMAL_ID = DOGID
            MEM_ID = GlobalId
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If chkCat.Checked = True Then
            ANIMAL_QTY = txtCat.Text
            ANIMAL_CATEGORIES = "Other Animals"
            ANIMAL_TYPE = "Cat"
            ANIMAL_ID = CATTLEID
            MEM_ID = GlobalId
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

    End Sub


    'FUNCTIONS
    Function Checkbox_Crops_function(ByVal crop_landarea As String, ByVal crop_categories As String, ByVal crop_type As String, ByVal crop_id As Integer, ByVal mem_id As Integer) As Boolean
        MAXXID()
        openCon()
        Try
            If btnSaveUpdate.Text = "Save" Then
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO `crops`(`crops_type`, `crops_cat`, `crops_landarea`, `mem_id`) VALUES 
                                    (@CROP_TYPE,@CROP_CAT,@CROP_AREA,@MEM_ID)"
                With cmd
                    .Parameters.AddWithValue("@CROP_TYPE", crop_type)
                    .Parameters.AddWithValue("@CROP_CAT", crop_categories)
                    .Parameters.AddWithValue("@CROP_AREA", crop_landarea)
                    .Parameters.AddWithValue("@MEM_ID", MAXID)
                End With
                result = cmd.ExecuteNonQuery()
                If result > 0 Then
                    Return True
                Else
                    Return False
                End If

            ElseIf btnSaveUpdate.Text = "Update" Then
                If crop_id = Nothing Or crop_id = 0 Then
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO `crops`(`crops_type`, `crops_cat`, `crops_landarea`, `mem_id`) VALUES 
                                    (@CROP_TYPE,@CROP_CAT,@CROP_AREA,@MEM_ID)"
                    With cmd
                        .Parameters.AddWithValue("@CROP_TYPE", crop_type)
                        .Parameters.AddWithValue("@CROP_CAT", crop_categories)
                        .Parameters.AddWithValue("@CROP_AREA", crop_landarea)
                        .Parameters.AddWithValue("@MEM_ID", mem_id)
                    End With
                    result = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE `crops` SET `crops_type`= @CROP_TYPE,`crops_cat`= @CROP_CAT,`crops_landarea`= @CROP_AREA 
                                    WHERE `crops`.`crops_id` = @CROP_ID AND `crops`.`mem_id` = @MEM_ID"
                    With cmd
                        .Parameters.AddWithValue("@CROP_TYPE", crop_type)
                        .Parameters.AddWithValue("@CROP_CAT", crop_categories)
                        .Parameters.AddWithValue("@CROP_AREA", crop_landarea)
                        .Parameters.AddWithValue("@MEM_ID", mem_id)
                        .Parameters.AddWithValue("@CROP_ID", crop_id)

                    End With
                    result = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If

            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            con.Close()
        End Try
    End Function

    Function Checkbox_Animals_function(ByVal animal_qty As String, ByVal animal_cat As String, ByVal animal_type As String, ByVal animal_id As Integer, ByVal mem_id As Integer) As Boolean
        MAXXID()
        openCon()
        Try
            If btnSaveUpdate.Text = "Save" Then
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO `animal`( `animal_type`, `animal_cat`, `animal_no`, `mem_id`) 
                                VALUES (@ANIMAL_TYPE, @ANIMAL_CAT, @ANIMAL_QTY,@MEM_ID)"
                With cmd
                    .Parameters.AddWithValue("@ANIMAL_TYPE", animal_type)
                    .Parameters.AddWithValue("@ANIMAL_CAT", animal_cat)
                    .Parameters.AddWithValue("@ANIMAL_QTY", animal_qty)
                    .Parameters.AddWithValue("@MEM_ID", MAXID)
                End With
                result = cmd.ExecuteNonQuery()
                If result > 0 Then
                    Return True
                Else
                    Return False
                End If
            ElseIf btnSaveUpdate.Text = "Update" Then
                If animal_id = Nothing Or animal_id = 0 Then
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO `animal`( `animal_type`, `animal_cat`, `animal_no`, `mem_id`) 
                                VALUES (@ANIMAL_TYPE, @ANIMAL_CAT, @ANIMAL_QTY,@MEM_ID)"
                    With cmd
                        .Parameters.AddWithValue("@ANIMAL_TYPE", animal_type)
                        .Parameters.AddWithValue("@ANIMAL_CAT", animal_cat)
                        .Parameters.AddWithValue("@ANIMAL_QTY", animal_qty)
                        .Parameters.AddWithValue("@MEM_ID", mem_id)
                    End With
                    result = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE `animal` SET `animal_type`= @ANIMAL_TYPE,`animal_cat`= @ANIMAL_CAT, `animal_no`= @ANIMAL_QTY 
                                    WHERE `animal`.`animal_id` = @ANIMAL_ID AND `animal`.`mem_id` = @MEM_ID"
                    With cmd
                        .Parameters.AddWithValue("@ANIMAL_TYPE", animal_type)
                        .Parameters.AddWithValue("@ANIMAL_CAT", animal_cat)
                        .Parameters.AddWithValue("@ANIMAL_QTY", animal_qty)
                        .Parameters.AddWithValue("@MEM_ID", mem_id)
                        .Parameters.AddWithValue("@ANIMAL_ID", animal_id)
                    End With
                    result = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If


            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            con.Close()
        End Try
    End Function


    'LOADTABLE
    Sub loadTable()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM member"
            reader = cmd.ExecuteReader()
            'dgrdmember.DataSource = table

            frmFarmers.dgrdmember.Rows.Clear()
            Do While reader.Read = True
                frmFarmers.dgrdmember.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9), reader(10), reader(12), reader(13), reader(14), reader(15))
            Loop
            frmFarmers.Label4.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally

            cmd.Dispose()
            con.Close()
        End Try


    End Sub

    Public Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    Sub ClearAll()
        cmbbarangay.Text = ""
        cbCivilStatus.Text = ""
        cbFarmType.Text = ""
        cbTypeOwnership.Text = ""
        radFemale.Checked = False
        radMale.Checked = False

    End Sub

    Public Sub ClearCheckBox(ByVal root As Control)
        For Each cc As Control In root.Controls
            ClearCheckBox(cc)
            If TypeOf cc Is CheckBox Then
                CType(cc, CheckBox).Checked = False
            End If
        Next cc
    End Sub


End Class