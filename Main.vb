Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlContainer.Controls.Clear()
        frmDashboard.TopLevel = False
        pnlContainer.Controls.Add(frmDashboard)
        frmDashboard.Show()
        'mysql_connect()
        ' Color.FromArgb(26, 188, 156)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        End
    End Sub

    Private Sub btnDash_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        pnlContainer.Controls.Clear()
        frmDashboard.TopLevel = False
        pnlContainer.Controls.Add(frmDashboard)
        frmDashboard.Show()
        btnDash.BackColor = Color.PaleTurquoise
        btnfarmers.BackColor = Color.FromArgb(46, 204, 113)
        btnCommo.BackColor = Color.FromArgb(46, 204, 113)
        btnMap.BackColor = Color.FromArgb(46, 204, 113)
        btnDistributed.BackColor = Color.FromArgb(46, 204, 113)
        btnReport.BackColor = Color.FromArgb(46, 204, 113)

    End Sub

    Private Sub btnfarmers_Click(sender As Object, e As EventArgs) Handles btnfarmers.Click

        pnlContainer.Controls.Clear()
        frmFarmers.TopLevel = False
        pnlContainer.Controls.Add(frmFarmers)
        frmFarmers.Show()

        btnfarmers.BackColor = Color.PaleTurquoise
        btnDash.BackColor = Color.FromArgb(46, 204, 113)
        btnCommo.BackColor = Color.FromArgb(46, 204, 113)
        btnMap.BackColor = Color.FromArgb(46, 204, 113)
        btnDistributed.BackColor = Color.FromArgb(46, 204, 113)
        btnReport.BackColor = Color.FromArgb(46, 204, 113)
        btnImports.BackColor = Color.FromArgb(46, 204, 113)
    End Sub


    Private Sub btnCommo_Click(sender As Object, e As EventArgs) Handles btnCommo.Click
        pnlContainer.Controls.Clear()
        frmCommo.TopLevel = False
        pnlContainer.Controls.Add(frmCommo)
        frmCommo.Show()

        btnCommo.BackColor = Color.PaleTurquoise
        btnDash.BackColor = Color.FromArgb(46, 204, 113)
        btnfarmers.BackColor = Color.FromArgb(46, 204, 113)
        btnMap.BackColor = Color.FromArgb(46, 204, 113)
        btnDistributed.BackColor = Color.FromArgb(46, 204, 113)
        btnReport.BackColor = Color.FromArgb(46, 204, 113)
        btnImports.BackColor = Color.FromArgb(46, 204, 113)
    End Sub

    Private Sub btnMap_Click(sender As Object, e As EventArgs) Handles btnMap.Click
        pnlContainer.Controls.Clear()
        frmMap.TopLevel = False
        pnlContainer.Controls.Add(frmMap)
        frmMap.Show()
        frmMap.PicMap.Image = My.Resources.Map_of_Sipocot
        frmMap.pnlInfo.Visible = False

        btnMap.BackColor = Color.PaleTurquoise
        btnDash.BackColor = Color.FromArgb(46, 204, 113)
        btnfarmers.BackColor = Color.FromArgb(46, 204, 113)
        btnCommo.BackColor = Color.FromArgb(46, 204, 113)
        btnDistributed.BackColor = Color.FromArgb(46, 204, 113)
        btnReport.BackColor = Color.FromArgb(46, 204, 113)
        btnImports.BackColor = Color.FromArgb(46, 204, 113)
    End Sub

    Private Sub btnDistributed_Click(sender As Object, e As EventArgs) Handles btnDistributed.Click
        pnlContainer.Controls.Clear()
        frmDistributed.TopLevel = False
        pnlContainer.Controls.Add(frmDistributed)
        frmDistributed.Show()

        btnDistributed.BackColor = Color.PaleTurquoise
        btnDash.BackColor = Color.FromArgb(46, 204, 113)
        btnfarmers.BackColor = Color.FromArgb(46, 204, 113)
        btnCommo.BackColor = Color.FromArgb(46, 204, 113)
        btnMap.BackColor = Color.FromArgb(46, 204, 113)
        btnReport.BackColor = Color.FromArgb(46, 204, 113)
        btnImports.BackColor = Color.FromArgb(46, 204, 113)
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        pnlContainer.Controls.Clear()
        frmReport.TopLevel = False
        pnlContainer.Controls.Add(frmReport)
        frmReport.Show()

        btnReport.BackColor = Color.PaleTurquoise
        btnDash.BackColor = Color.FromArgb(46, 204, 113)
        btnfarmers.BackColor = Color.FromArgb(46, 204, 113)
        btnCommo.BackColor = Color.FromArgb(46, 204, 113)
        btnMap.BackColor = Color.FromArgb(46, 204, 113)
        btnDistributed.BackColor = Color.FromArgb(46, 204, 113)
        btnImports.BackColor = Color.FromArgb(46, 204, 113)
    End Sub


    Private Sub btnImports_Click_1(sender As Object, e As EventArgs) Handles btnImports.Click
        pnlContainer.Controls.Clear()
        frmImport.TopLevel = False
        pnlContainer.Controls.Add(frmImport)
        frmImport.Show()

        btnImports.BackColor = Color.PaleTurquoise
        btnDash.BackColor = Color.FromArgb(46, 204, 113)
        btnfarmers.BackColor = Color.FromArgb(46, 204, 113)
        btnCommo.BackColor = Color.FromArgb(46, 204, 113)
        btnMap.BackColor = Color.FromArgb(46, 204, 113)
        btnDistributed.BackColor = Color.FromArgb(46, 204, 113)
        btnReport.BackColor = Color.FromArgb(46, 204, 113)
    End Sub
End Class