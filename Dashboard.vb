Public Class frmDashboard

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MemberCount()
        Animals_no()
        Crops_no()


    End Sub

    Private Sub frmDashboard_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
    End Sub

    Sub MemberCount()
        Try
            openCon()
            Dim ROWCOUNT As Integer
            'Dim COUNT As String
            With cmd
                .Connection = con
                .CommandText = "SELECT COUNT(mem_id) FROM member"
                ROWCOUNT = cmd.ExecuteScalar

                lblCropsNo.Text = ROWCOUNT
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Sub Crops_no()
        Try
            openCon()
            Dim ROWCOUNT As Integer
            'Dim COUNT As String
            With cmd
                .Connection = con
                .CommandText = "SELECT Count(crops_id) FROM crops"
                ROWCOUNT = cmd.ExecuteScalar

                lblFarmerNo.Text = ROWCOUNT
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Sub Animals_no()
        Try
            openCon()
            Dim ROWCOUNT As Integer
            'Dim COUNT As String
            With cmd
                .Connection = con
                .CommandText = "SELECT SUM(animal_no) FROM animal"
                ROWCOUNT = cmd.ExecuteScalar

                lblAnimalNo.Text = ROWCOUNT
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

End Class