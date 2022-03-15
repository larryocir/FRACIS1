Public Class frmCreateAccount

    Dim position As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If btnSave.Text = "Save" Then
            openCon()
            Try

                cmd.Connection = con
                cmd.CommandText = "INSERT INTO `account`( `acc_uname`, `acc_password`, `acc_name`, `acc_position`) VALUES (@Uname, @Password,  @Name, @Position)"
                With cmd
                    .Parameters.AddWithValue("@Name", txtName.Text)
                    .Parameters.AddWithValue("@Uname", txtUsername.Text)
                    .Parameters.AddWithValue("@Position", cmbPosition.SelectedItem)
                    .Parameters.AddWithValue("@Password", txtPass.Text)
                End With
                cmd.ExecuteNonQuery()
                clear()
                con.Close()
                Call loadAccount()
                MsgBox("New Account successfully added.")

                Me.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                cmd.Parameters.Clear()
                cmd.Dispose()
                con.Close()
            End Try

        Else
            If cmbPosition.Text = "Admin" Then
                position = cmbPosition.SelectedItem = "Admin"

            Else
                position = "Staff"
            End If
            openCon()
            Try

                cmd.Connection = con
                cmd.CommandText = "UPDATE `account` SET `acc_uname`= @Uname,`acc_password`= @Password,`acc_name`= @Name,`acc_position`= @Position WHERE acc_id = " & GlobalId & ""
                With cmd
                    .Parameters.AddWithValue("@Name", txtName.Text)
                    .Parameters.AddWithValue("@Uname", txtUsername.Text)
                    .Parameters.AddWithValue("@Position", position)
                    .Parameters.AddWithValue("@Password", txtPass.Text)
                End With
                cmd.ExecuteNonQuery()
                clear()
                con.Close()
                Call loadAccount()
                MsgBox("New Account successfully updated.")
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



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        clear()
        Me.Close()
    End Sub
    Sub loadAccount()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT acc_id, acc_name, acc_password, acc_uname, acc_password FROM `account`"
            reader = cmd.ExecuteReader()

            frmAccount.dgrdAccount.Rows.Clear()
            Do While reader.Read = True

                frmAccount.dgrdAccount.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4))

            Loop
            clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Sub clear()
        txtName.Clear()
        txtPass.Clear()
        txtUsername.Clear()
        cmbPosition.Text = ""
    End Sub

End Class