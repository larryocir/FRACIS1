Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim rowcount As Integer
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        End
    End Sub

    Sub clear()
        txtUser.Clear()
        txtPass.Clear()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        con.Close()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        openCon()
        Try
            With cmd
                .Connection = con
                .CommandText = "SELECT  acc_id, acc_name, acc_position, acc_uname, acc_password FROM account where acc_uname = '" & txtUser.Text & "' and acc_password = '" & txtPass.Text & "'"
                rowcount = cmd.ExecuteScalar
                reader = cmd.ExecuteReader()


                If rowcount > 0 Then
                    Do While reader.Read = True
                        UserID = reader(2)
                        Name = reader(1)
                    Loop
                    If UserID = "Admin" Then
                        frmMain.lblName.Text = Name
                        MsgBox("Successfully Login!")
                        con.Close()
                        clear()
                        frmMain.Show()
                        Me.Hide()

                    Else
                        frmMain.lblName.Text = Name
                        frmMain.btnAccount.Visible =False
                        MsgBox("Successfully Login!")
                        con.Close()
                        clear()
                        frmMain.Show()
                        Me.Hide()
                    End If

                Else
                        MsgBox("Invalid Username or Passowrd!")
                    clear()
                    con.Close()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        ''create the SQL query to check if data exist in database
        'sql = "SELECT * FROM account where acc_uname = '" & txtUser.Text & "' and acc_password = '" & txtPass.Text & "'"
        ''Implement Try catch method to capture error when detected
        'Try
        '    'to establish connection given the sql query and database connection in mysql_connect
        '    dbcomm = New MySqlCommand(sql, dbconn)
        '    'to execute the SQL command
        '    dbread = dbcomm.ExecuteReader()
        '    'open connection and read data from database
        '    dbread.Read()
        '    'if dbread has values from database
        '    If dbread.HasRows = True Then
        '        MsgBox("Successfully Login!")
        '        frmMain.Show()
        '        Me.Hide()
        '        dbread.Close()
        '    Else
        '        MsgBox("Invalid Username or Passowrd!")
        '        clear()
        '        dbread.Close()
        '    End If
        '    dbread.Close()
        'Catch ex As Exception
        '    'to capture error so system will not crash or close abruptly
        '    MsgBox(ex.ToString)
        '    dbread.Close()
        '    Exit Sub
        'End Try

    End Sub

End Class