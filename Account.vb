Public Class frmAccount



    Private Sub frmAccount_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmCreateAccount.btnSave.Text = "Save"
        loadAccount()
    End Sub

    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
        frmCreateAccount.ShowDialog()
    End Sub


    Private Sub dgrdAccount_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgrdAccount.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = dgrdAccount.Rows(e.RowIndex)
        End If
        GlobalId = dgrdAccount.CurrentRow.Cells(0).Value
        frmCreateAccount.btnSave.Text = "Update"

        frmCreateAccount.txtName.Text = dgrdAccount.CurrentRow.Cells(1).Value
        frmCreateAccount.cmbPosition.SelectedItem = dgrdAccount.CurrentRow.Cells(2).Value
        frmCreateAccount.txtUsername.Text = dgrdAccount.CurrentRow.Cells(3).Value
        frmCreateAccount.txtPass.Text = dgrdAccount.CurrentRow.Cells(4).Value
        frmCreateAccount.ShowDialog()
    End Sub

    Sub loadAccount()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT acc_id, acc_name, acc_password, acc_uname, acc_password FROM `account`"
            reader = cmd.ExecuteReader()

            dgrdAccount.Rows.Clear()
            Do While reader.Read = True

                dgrdAccount.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4))

            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        GlobalId = dgrdAccount.CurrentRow.Cells(0).Value
        openCon()
        Try
            With cmd
                .Connection = con
                .CommandText = ("DELETE FROM `account` WHERE acc_id = " & GlobalId & "")
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
        End Try
    End Sub
End Class