Public Class frmtransaction
    Dim address As String
    Dim gender As String

    Private Sub transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlcon.HorizontalScroll.Maximum = 0
        pnlcon.AutoScroll = True


    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        openCon()

        address = txtbrgy.Text + ", " + txtmun.Text + ", " + txtprov.Text
        Try
            cmd.Connection = con
            cmd.CommandText = " INSERT INTO `member`(`mem_fname`, `mem_lname`, `mem_mname`, `mem_extname`, `mem_address`, `mem_sex`, `mem_cp`) VALUES ('" & txtfname.Text & "','" & txtlname.Text & "','" & txtmname.Text & "','" & txtext.Text & "', '" & address & "', '" & gender & "', '" & txtcp.Text & "')"
            'INSERT INTO tbl_sample (`FNAME`, `AGE`, `GENDER`, `BDAY`, `COURSE`) VALUES ('" & txtName.Text & "', '" &
            '    txtAge.Text & "', '" & gender & "', '" & dtBday.Value.Date & "', '" & cmbProgram.SelectedItem & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Successfullly Added Record!")
            con.Close()
            Call loadTable()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub radMale_CheckedChanged(sender As Object, e As EventArgs) Handles radMale.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub radFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radFemale.CheckedChanged
        gender = "Female"
    End Sub

    Sub loadTable()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM member"
            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)
            frmFarmers.dgrdmember.DataSource = table
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



End Class