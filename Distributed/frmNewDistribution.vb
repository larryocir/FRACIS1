Public Class frmNewDistribution

    Private Sub frmNewDistribution_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSaveUpdate_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openCon()
        Try

            cmd.Connection = con
            cmd.CommandText = "INSERT INTO `distributed`(`distributed_item`, `distributed_venue`, `distributed_date`) VALUES (@ITEM, @VENUE, @DATE)"
            With cmd
                .Parameters.AddWithValue("@ITEM", txtItem.Text)
                .Parameters.AddWithValue("@VENUE", txtVenue.Text)
                .Parameters.AddWithValue("@DATE", Format(dtpDate.Value, "yyyy-MM-dd"))
            End With
            cmd.ExecuteNonQuery()
            con.Close()
            Call loadDistribution()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Sub loadDistribution()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `distributed`"
            reader = cmd.ExecuteReader()
            'dgrdmember.DataSource = table
            Dim i As Integer = 1
            frmDistributed.dgvDistribute.Rows.Clear()
            Do While reader.Read = True

                frmDistributed.dgvDistribute.Rows.Add(reader(0), i, reader(1), reader(2), reader(3))
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


End Class