Public Class frmMap

    Private Sub frmMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblALDEZAR_Click(sender As Object, e As EventArgs) Handles lblALDEZAR.Click
        PicMap.Image = My.Resources.Aldezar
        pnlInfo.Visible = True
        MAP_BARANGAY = "ALDEZAR"
        lblbarangay.Text = barangay_number(MAP_BARANGAY)
    End Sub

    Private Sub lblAWAYAN_Click(sender As Object, e As EventArgs) Handles lblAWAYAN.Click
        PicMap.Image = My.Resources.Awayan
    End Sub
    Private Sub lblAZUCENA_Click(sender As Object, e As EventArgs) Handles lblAZUCENA.Click
        PicMap.Image = My.Resources.Azucena
    End Sub
    Private Sub lblBAGONG_SIRANG_Click(sender As Object, e As EventArgs) Handles lblBAGONG_SIRANG.Click
        PicMap.Image = My.Resources.Bagong_Sirang
    End Sub
    Private Sub lblBINAHIAN_Click(sender As Object, e As EventArgs) Handles lblBINAHIAN.Click
        PicMap.Image = My.Resources.Binahian
    End Sub
    Private Sub lblBOLO_NORTE_Click(sender As Object, e As EventArgs) Handles lblBOLO_NORTE.Click
        PicMap.Image = My.Resources.Bolo_Norte
    End Sub
    Private Sub lblBOLO_SUR_Click(sender As Object, e As EventArgs) Handles lblBOLO_SUR.Click
        PicMap.Image = My.Resources.Bolo_Sur
    End Sub
    Private Sub lblBULAN_Click(sender As Object, e As EventArgs) Handles lblBULAN.Click
        PicMap.Image = My.Resources.Bulan
    End Sub
    Private Sub lblBULAWAN_Click(sender As Object, e As EventArgs) Handles lblBULAWAN.Click
        PicMap.Image = My.Resources.Bulawan
    End Sub
    Private Sub lblCABUYAO_Click(sender As Object, e As EventArgs) Handles lblCABUYAO.Click
        PicMap.Image = My.Resources.Cabuyao
    End Sub
    Private Sub lblCAIMA_Click(sender As Object, e As EventArgs) Handles lblCAIMA.Click
        PicMap.Image = My.Resources.Caima
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        PicMap.Image = My.Resources.Calagbangan
    End Sub
    Private Sub lblCALAMPINAY_Click(sender As Object, e As EventArgs) Handles lblCALAMPINAY.Click
        PicMap.Image = My.Resources.Calampinay
    End Sub
    Private Sub lblCARAYRAYAN_Click(sender As Object, e As EventArgs) Handles lblCARAYRAYAN.Click
        PicMap.Image = My.Resources.Carayrayan
    End Sub
    Private Sub lblCOTMO_Click(sender As Object, e As EventArgs) Handles lblCOTMO.Click
        PicMap.Image = My.Resources.Cotmo
    End Sub
    Private Sub lblGABI_Click(sender As Object, e As EventArgs) Handles lblGABI.Click
        PicMap.Image = My.Resources.Gabi
    End Sub
    Private Sub lvlGAONGAN_Click(sender As Object, e As EventArgs) Handles lvlGAONGAN.Click
        PicMap.Image = My.Resources.Gaongan
    End Sub
    Private Sub lblIMPIG_Click(sender As Object, e As EventArgs) Handles lblIMPIG.Click
        PicMap.Image = My.Resources.Impig
    End Sub
    Private Sub lblLIPILIP_Click(sender As Object, e As EventArgs) Handles lblLIPILIP.Click
        PicMap.Image = My.Resources.Lipilip
    End Sub
    Private Sub lblLUBIGAN_JR_Click(sender As Object, e As EventArgs) Handles lblLUBIGAN_JR.Click
        PicMap.Image = My.Resources.Lubigan_Jr
    End Sub
    Private Sub lblLUBIGAN_SR_Click(sender As Object, e As EventArgs) Handles lblLUBIGAN_SR.Click
        PicMap.Image = My.Resources.Lubigan_Sr
    End Sub
    Private Sub lblMALAGUICO_Click(sender As Object, e As EventArgs) Handles lblMALAGUICO.Click
        PicMap.Image = My.Resources.Malaguico
    End Sub
    Private Sub lblMALUBAGO_Click(sender As Object, e As EventArgs) Handles lblMALUBAGO.Click
        PicMap.Image = My.Resources.Malubago
    End Sub
    Private Sub lblMANANGLE_Click(sender As Object, e As EventArgs) Handles lblMANANGLE.Click
        PicMap.Image = My.Resources.Manangle
    End Sub
    Private Sub lblMANGAPO_Click(sender As Object, e As EventArgs) Handles lblMANGAPO.Click
        PicMap.Image = My.Resources.Mangapo
    End Sub

    Private Sub lblAlteza_Click(sender As Object, e As EventArgs) Handles lblAlteza.Click
        PicMap.Image = My.Resources.Alteza
    End Sub

    Private Sub lblAnib_Click(sender As Object, e As EventArgs) Handles lblAnib.Click
        PicMap.Image = My.Resources.Anib
    End Sub

    Private Sub lblMANGGA_Click(sender As Object, e As EventArgs) Handles lblMANGGA.Click
        PicMap.Image = My.Resources.Mangga
    End Sub

    Private Sub lblMANLUBANG_Click(sender As Object, e As EventArgs) Handles lblMANLUBANG.Click
        PicMap.Image = My.Resources.Manlubang
    End Sub

    Private Sub lblMANTILA_Click(sender As Object, e As EventArgs) Handles lblMANTILA.Click
        PicMap.Image = My.Resources.Mantilla
    End Sub

    Private Sub lblNORTH_CENTRO_Click(sender As Object, e As EventArgs) Handles lblNORTH_CENTRO.Click
        PicMap.Image = My.Resources.North_Centrol
    End Sub

    Private Sub lblNORTH_VILLAZAR_Click(sender As Object, e As EventArgs) Handles lblNORTH_VILLAZAR.Click
        PicMap.Image = My.Resources.North_Villazar
    End Sub

    Private Sub lblSAGRADA_FAMILIA_Click(sender As Object, e As EventArgs) Handles lblSAGRADA_FAMILIA.Click
        PicMap.Image = My.Resources.Sagrada_Familia
    End Sub

    Private Sub lblSALANDA_Click(sender As Object, e As EventArgs) Handles lblSALANDA.Click
        PicMap.Image = My.Resources.Salanda
    End Sub

    Private Sub lblSALVACION_Click(sender As Object, e As EventArgs) Handles lblSALVACION.Click
        PicMap.Image = My.Resources.Salvacion
    End Sub

    Private Sub lblSAN_ISIDRO_Click(sender As Object, e As EventArgs) Handles lblSAN_ISIDRO.Click
        PicMap.Image = My.Resources.San_Isidro
    End Sub

    Private Sub lblSAN_VICENTE_Click(sender As Object, e As EventArgs) Handles lblSAN_VICENTE.Click
        PicMap.Image = My.Resources.San_Vicente
    End Sub

    Private Sub lblSERRANZANA_Click(sender As Object, e As EventArgs) Handles lblSERRANZANA.Click
        PicMap.Image = My.Resources.Serranzana
    End Sub

    Private Sub lblSOUTH_CENTRO_Click(sender As Object, e As EventArgs) Handles lblSOUTH_CENTRO.Click
        PicMap.Image = My.Resources.South_Centro
    End Sub

    Private Sub lblSOUTH_VILLAZAR_Click(sender As Object, e As EventArgs) Handles lblSOUTH_VILLAZAR.Click
        PicMap.Image = My.Resources.South_Villazar
    End Sub

    Private Sub lblTAISAN_Click(sender As Object, e As EventArgs) Handles lblTAISAN.Click
        PicMap.Image = My.Resources.Taisan
    End Sub

    Private Sub lblTARA_Click(sender As Object, e As EventArgs) Handles lblTARA.Click
        PicMap.Image = My.Resources.Tara
    End Sub

    Private Sub lblTIBLE_Click(sender As Object, e As EventArgs) Handles lblTIBLE.Click
        PicMap.Image = My.Resources.Tible
    End Sub

    Private Sub lblTULA_TULA_Click(sender As Object, e As EventArgs) Handles lblTULA_TULA.Click
        PicMap.Image = My.Resources.Tula_Tula
    End Sub

    Private Sub lblVIGAAN_Click(sender As Object, e As EventArgs) Handles lblVIGAAN.Click
        PicMap.Image = My.Resources.Vigaan
    End Sub

    Private Sub lblYABO_Click(sender As Object, e As EventArgs) Handles lblYABO.Click
        PicMap.Image = My.Resources.Yabo
    End Sub

    Function barangay_number(ByVal barangay As String)
        openCon()
        Try

        Catch ex As Exception

        End Try
    End Function
End Class