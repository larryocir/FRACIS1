Public Class frmDashboard

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub frmDashboard_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        MsgBox("Click farmer")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        MsgBox("Click 99999")
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        MsgBox("Click total")
    End Sub
End Class