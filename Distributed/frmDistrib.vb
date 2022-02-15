Public Class frmDistrib

    Private Sub frmDistrib_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 900

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        'Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        If Me.Width = 900 Then
            Me.Width = 1300
            'Me.Location = New Point(50%, 50%)
            Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
            Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
            btnClose.Location = New Point(1271, 4)
        Else
            Me.Width = 900
            'Me.Location = New Point(50%, 50%)
            Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
            Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
            btnClose.Location = New Point(871, 4)
        End If
    End Sub
End Class