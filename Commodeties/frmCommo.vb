Public Class frmCommo

    Private Sub frmCommo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCommodities()


    End Sub
    Sub loadCommodities()
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
    End Sub
End Class