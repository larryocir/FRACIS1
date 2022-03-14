Public Class frmDistributed

    Private Sub frmDistributed_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadDistribution()

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmNewDistribution.ShowDialog()

    End Sub

    Sub loadDistribution()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `distributed`"
            reader = cmd.ExecuteReader()
            'dgrdmember.DataSource = table
            Dim i As Integer = 1
            dgvDistribute.Rows.Clear()
            Do While reader.Read = True

                dgvDistribute.Rows.Add(reader(0), i, reader(1), reader(2), reader(3), reader(4))
                i = i + 1
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            con.Close()
        End Try
    End Sub




    Private Sub dgvDistribute_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDistribute.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = dgvDistribute.Rows(e.RowIndex)
        End If
        DistriID = dgvDistribute.CurrentRow.Cells(0).Value
        DistributeItem = dgvDistribute.CurrentRow.Cells(2).Value
        DistributeUnit = dgvDistribute.CurrentRow.Cells(3).Value
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `distributed` WHERE distributed_id = '" & DistriID & "' "
            reader = cmd.ExecuteReader()
            Do While reader.Read = True
                frmDistrib.lblItems.Text = reader(1)
                frmDistrib.lblVenue.Text = reader(3)

                frmDistrib.lblDate.Text = reader(4)


            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            con.Close()
        End Try

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT received.received_id, distributed.distributed_id, member.mem_id, member.mem_rsbsa_no, member.mem_lname, member.mem_fname, member.mem_mname, member.mem_barangay, member.mem_cp, distributed.distributed_item, distributed.distributed_unit,  mem_extname  FROM `distributed`, member, received Where distributed.distributed_id = '" & DistriID & "' AND member.mem_id = received.mem_id and distributed.distributed_id = received.distributed_id and distributed.distributed_item =  '" & DistributeItem & "'"
            reader = cmd.ExecuteReader()


            frmDistrib.dgrdreceiver.Rows.Clear()
            Do While reader.Read = True
                frmDistrib.dgrdreceiver.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4) + ", " + reader(5) + " " + reader(6) + " " + reader(11), reader(7), reader(8), reader(9), reader(10))
            Loop

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally

            cmd.Dispose()
            con.Close()
        End Try


        frmDistrib.ShowDialog()
    End Sub


End Class