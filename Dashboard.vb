Public Class frmDashboard

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub frmDashboard_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
    End Sub


End Class