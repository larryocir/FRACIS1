Public Class frmNewDistribution

    Private Sub frmNewDistribution_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSaveUpdate_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "Save" Then
            openCon()
            Try
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO `distributed`(`distributed_item`, `distributed_venue`, `distributed_date`, distributed_unit) VALUES (@ITEM, @VENUE, @DATE, @UNIT)"
                With cmd
                    .Parameters.AddWithValue("@ITEM", txtItem.Text)
                    .Parameters.AddWithValue("@VENUE", txtVenue.Text)
                    .Parameters.AddWithValue("@UNIT", txtUnits.Text)
                    .Parameters.AddWithValue("@DATE", Format(dtpDate.Value, "yyyy-MM-dd"))
                End With
                cmd.ExecuteNonQuery()
                con.Close()
                Call loadDistribution()
                MsgBox("Successfully added.")
                Clear()
                Me.Close()
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
                cmd.CommandText = "UPDATE `distributed` SET `distributed_item`= @ITEM,`distributed_unit`= @UNIT,`distributed_venue`= @VENUE,`distributed_date`= @DATE WHERE distributed_id = " & GlobalId & ""
                With cmd
                    .Parameters.AddWithValue("@ITEM", txtItem.Text)
                    .Parameters.AddWithValue("@VENUE", txtVenue.Text)
                    .Parameters.AddWithValue("@UNIT", txtUnits.Text)
                    .Parameters.AddWithValue("@DATE", Format(dtpDate.Value, "yyyy-MM-dd"))
                End With
                cmd.ExecuteNonQuery()

                con.Close()
                Clear()
                MsgBox("Successfully update.")
                Call loadDistribution()
                Me.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                cmd.Parameters.Clear()
                cmd.Dispose()
                con.Close()
            End Try

        End If

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

                frmDistributed.dgvDistribute.Rows.Add(reader(0), i, reader(1), reader(2), reader(3), reader(4))
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
    Sub Clear()
        txtItem.Clear()
        txtVenue.Clear()
        txtUnits.Clear()
        dtpDate.Text = ""
    End Sub


End Class