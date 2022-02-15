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
        GlobalId = dgvDistribute.CurrentRow.Cells(0).Value
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `distributed` WHERE distributed_id = '" & GlobalId & "' "
            reader = cmd.ExecuteReader()
            Do While reader.Read = True
                frmDistrib.lblItems.Text = reader("distributed_item")
                frmDistrib.lblVenue.Text = reader("distributed_venue")

                frmDistrib.lblDate.Text = reader("distributed_date")


            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            con.Close()
        End Try
        frmDistrib.lblItems.Text =
        frmDistrib.ShowDialog()
    End Sub
End Class