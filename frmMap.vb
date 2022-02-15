Public Class frmMap

    Private Sub frmMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblALDEZAR_Click(sender As Object, e As EventArgs) Handles lblALDEZAR.Click
        PicMap.Image = My.Resources.Aldezar
        pnlInfo.Visible = True
        MAP_BARANGAY = "ALDEZAR"
        lblbarangay.Text = "ALDEZAR"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblAWAYAN_Click(sender As Object, e As EventArgs) Handles lblAWAYAN.Click
        PicMap.Image = My.Resources.Awayan
        pnlInfo.Visible = True
        MAP_BARANGAY = "AWAYAN"
        lblbarangay.Text = "AWAYAN"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblAZUCENA_Click(sender As Object, e As EventArgs) Handles lblAZUCENA.Click
        PicMap.Image = My.Resources.Azucena
        pnlInfo.Visible = True
        MAP_BARANGAY = "AZUCENA"
        lblbarangay.Text = "AZUCENA"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblBAGONG_SIRANG_Click(sender As Object, e As EventArgs) Handles lblBAGONG_SIRANG.Click
        PicMap.Image = My.Resources.Bagong_Sirang
        pnlInfo.Visible = True
        MAP_BARANGAY = "BAGONG SIRANG"
        lblbarangay.Text = "BAGONG SIRANG"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblBINAHIAN_Click(sender As Object, e As EventArgs) Handles lblBINAHIAN.Click
        PicMap.Image = My.Resources.Binahian
        pnlInfo.Visible = True
        MAP_BARANGAY = "BINAHIAN"
        lblbarangay.Text = "BINAHIAN"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
    End Sub

    Private Sub lblBOLO_NORTE_Click(sender As Object, e As EventArgs) Handles lblBOLO_NORTE.Click
        PicMap.Image = My.Resources.Bolo_Norte
        pnlInfo.Visible = True
        MAP_BARANGAY = "BOLO NORTE"
        lblbarangay.Text = "BOLO NORTE"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblBOLO_SUR_Click(sender As Object, e As EventArgs) Handles lblBOLO_SUR.Click
        PicMap.Image = My.Resources.Bolo_Sur
        pnlInfo.Visible = True
        MAP_BARANGAY = "BOLO SUR"
        lblbarangay.Text = "BOLO SUR"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblBULAN_Click(sender As Object, e As EventArgs) Handles lblBULAN.Click
        PicMap.Image = My.Resources.Bulan
        pnlInfo.Visible = True
        MAP_BARANGAY = "BULAN"
        lblbarangay.Text = "BULAN"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub
    Private Sub lblBULAWAN_Click(sender As Object, e As EventArgs) Handles lblBULAWAN.Click
        PicMap.Image = My.Resources.Bulawan
        pnlInfo.Visible = True
        MAP_BARANGAY = "BULAWAN"
        lblbarangay.Text = "BULAWAN"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub
    Private Sub lblCABUYAO_Click(sender As Object, e As EventArgs) Handles lblCABUYAO.Click
        PicMap.Image = My.Resources.Cabuyao
        pnlInfo.Visible = True
        MAP_BARANGAY = "CABUYAO"
        lblbarangay.Text = "CABUYAO"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub
    Private Sub lblCAIMA_Click(sender As Object, e As EventArgs) Handles lblCAIMA.Click
        PicMap.Image = My.Resources.Caima
        pnlInfo.Visible = True
        MAP_BARANGAY = "CAIMA"
        lblbarangay.Text = "CAIMA"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        PicMap.Image = My.Resources.Calagbangan
        pnlInfo.Visible = True
        MAP_BARANGAY = "CALAGBANGAN"
        lblbarangay.Text = "CALAGBANGAN"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub
    Private Sub lblCALAMPINAY_Click(sender As Object, e As EventArgs) Handles lblCALAMPINAY.Click
        PicMap.Image = My.Resources.Calampinay
        pnlInfo.Visible = True
        MAP_BARANGAY = "CALAMPINAY"
        lblbarangay.Text = "CALAMPINAY"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub
    Private Sub lblCARAYRAYAN_Click(sender As Object, e As EventArgs) Handles lblCARAYRAYAN.Click
        PicMap.Image = My.Resources.Carayrayan
        pnlInfo.Visible = True
        MAP_BARANGAY = "CARAYRAYAN"
        lblbarangay.Text = "CARAYRAYAN"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub
    Private Sub lblCOTMO_Click(sender As Object, e As EventArgs) Handles lblCOTMO.Click
        PicMap.Image = My.Resources.Cotmo
        pnlInfo.Visible = True
        MAP_BARANGAY = "COTMO"
        lblbarangay.Text = "COTMO"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub
    Private Sub lblGABI_Click(sender As Object, e As EventArgs) Handles lblGABI.Click
        PicMap.Image = My.Resources.Gabi
        pnlInfo.Visible = True
        MAP_BARANGAY = "GABI"
        lblbarangay.Text = "GABI"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub
    Private Sub lvlGAONGAN_Click(sender As Object, e As EventArgs) Handles lvlGAONGAN.Click
        PicMap.Image = My.Resources.Gaongan
        pnlInfo.Visible = True
        MAP_BARANGAY = "GAONGAN"
        lblbarangay.Text = "GAONGAN"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub
    Private Sub lblIMPIG_Click(sender As Object, e As EventArgs) Handles lblIMPIG.Click
        PicMap.Image = My.Resources.Impig
        pnlInfo.Visible = True
        MAP_BARANGAY = "IMPIG"
        lblbarangay.Text = "IMPIG"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub
    Private Sub lblLIPILIP_Click(sender As Object, e As EventArgs) Handles lblLIPILIP.Click
        PicMap.Image = My.Resources.Lipilip
        pnlInfo.Visible = True
        MAP_BARANGAY = "LIPILIP"
        lblbarangay.Text = "LIPILIP"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub
    Private Sub lblLUBIGAN_JR_Click(sender As Object, e As EventArgs) Handles lblLUBIGAN_JR.Click
        PicMap.Image = My.Resources.Lubigan_Jr
        pnlInfo.Visible = True
        MAP_BARANGAY = "LUBIGAN JR"
        lblbarangay.Text = "LUBIGAN JR"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub
    Private Sub lblLUBIGAN_SR_Click(sender As Object, e As EventArgs) Handles lblLUBIGAN_SR.Click
        PicMap.Image = My.Resources.Lubigan_Sr
        pnlInfo.Visible = True
        MAP_BARANGAY = "LUBIGAN SR"
        lblbarangay.Text = "LUBIGAN SR"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub
    Private Sub lblMALAGUICO_Click(sender As Object, e As EventArgs) Handles lblMALAGUICO.Click
        PicMap.Image = My.Resources.Malaguico
        pnlInfo.Visible = True
        MAP_BARANGAY = "MALAGUICO"
        lblbarangay.Text = "MALAGUICO"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub
    Private Sub lblMALUBAGO_Click(sender As Object, e As EventArgs) Handles lblMALUBAGO.Click
        PicMap.Image = My.Resources.Malubago
        pnlInfo.Visible = True
        MAP_BARANGAY = "MALUBAGO"
        lblbarangay.Text = "MALUBAGO"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub
    Private Sub lblMANANGLE_Click(sender As Object, e As EventArgs) Handles lblMANANGLE.Click
        PicMap.Image = My.Resources.Manangle
        pnlInfo.Visible = True
        MAP_BARANGAY = "MANANGLE"
        lblbarangay.Text = "MANANGLE"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub
    Private Sub lblMANGAPO_Click(sender As Object, e As EventArgs) Handles lblMANGAPO.Click
        PicMap.Image = My.Resources.Mangapo
        pnlInfo.Visible = True
        MAP_BARANGAY = "MANGAPO"
        lblbarangay.Text = "MANGAPO"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblAlteza_Click(sender As Object, e As EventArgs) Handles lblAlteza.Click
        PicMap.Image = My.Resources.Alteza
        pnlInfo.Visible = True
        MAP_BARANGAY = "ALTEZA"
        lblbarangay.Text = "ALTEZA"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblAnib_Click(sender As Object, e As EventArgs) Handles lblAnib.Click
        PicMap.Image = My.Resources.Anib
        pnlInfo.Visible = True
        MAP_BARANGAY = "ANIB"
        lblbarangay.Text = "ANIB"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblMANGGA_Click(sender As Object, e As EventArgs) Handles lblMANGGA.Click
        PicMap.Image = My.Resources.Mangga
        pnlInfo.Visible = True
        MAP_BARANGAY = "MANGGA"
        lblbarangay.Text = "MANGGA"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)

    End Sub

    Private Sub lblMANLUBANG_Click(sender As Object, e As EventArgs) Handles lblMANLUBANG.Click
        PicMap.Image = My.Resources.Manlubang
        pnlInfo.Visible = True
        MAP_BARANGAY = "MANLUBANG"
        lblbarangay.Text = "MANLUBANG"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblMANTILA_Click(sender As Object, e As EventArgs) Handles lblMANTILA.Click
        PicMap.Image = My.Resources.Mantilla
        pnlInfo.Visible = True
        MAP_BARANGAY = "MANTILLA"
        lblbarangay.Text = "MANTILLA"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblNORTH_CENTRO_Click(sender As Object, e As EventArgs) Handles lblNORTH_CENTRO.Click
        PicMap.Image = My.Resources.North_Centrol
        pnlInfo.Visible = True
        MAP_BARANGAY = "NORTH CENTRO"
        lblbarangay.Text = "NORTH CENTRO"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblNORTH_VILLAZAR_Click(sender As Object, e As EventArgs) Handles lblNORTH_VILLAZAR.Click
        PicMap.Image = My.Resources.North_Villazar
        pnlInfo.Visible = True
        MAP_BARANGAY = "NORTH VILLAZAR"
        lblbarangay.Text = "NORTH VILLAZAR"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblSAGRADA_FAMILIA_Click(sender As Object, e As EventArgs) Handles lblSAGRADA_FAMILIA.Click
        PicMap.Image = My.Resources.Sagrada_Familia
        pnlInfo.Visible = True
        MAP_BARANGAY = "SAGRADA FAMILIA"
        lblbarangay.Text = "SAGRADA FAMILIA"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblSALANDA_Click(sender As Object, e As EventArgs) Handles lblSALANDA.Click
        PicMap.Image = My.Resources.Salanda
        pnlInfo.Visible = True
        MAP_BARANGAY = "SALANDA"
        lblbarangay.Text = "SALANDA"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblSALVACION_Click(sender As Object, e As EventArgs) Handles lblSALVACION.Click
        PicMap.Image = My.Resources.Salvacion
        pnlInfo.Visible = True
        MAP_BARANGAY = "SALVACION"
        lblbarangay.Text = "SALVACION"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblSAN_ISIDRO_Click(sender As Object, e As EventArgs) Handles lblSAN_ISIDRO.Click
        PicMap.Image = My.Resources.San_Isidro
        pnlInfo.Visible = True
        MAP_BARANGAY = "SAN ISIDRO"
        lblbarangay.Text = "SAN ISIDRO"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblSAN_VICENTE_Click(sender As Object, e As EventArgs) Handles lblSAN_VICENTE.Click
        PicMap.Image = My.Resources.San_Vicente
        pnlInfo.Visible = True
        MAP_BARANGAY = "SAN VICENTE"
        lblbarangay.Text = "SAN VICENTE"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblSERRANZANA_Click(sender As Object, e As EventArgs) Handles lblSERRANZANA.Click
        PicMap.Image = My.Resources.Serranzana
        pnlInfo.Visible = True
        MAP_BARANGAY = "SERRANZANA"
        lblbarangay.Text = "SERRANZANA"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblSOUTH_CENTRO_Click(sender As Object, e As EventArgs) Handles lblSOUTH_CENTRO.Click
        PicMap.Image = My.Resources.South_Centro
        pnlInfo.Visible = True
        MAP_BARANGAY = "SOUTH CENTRO"
        lblbarangay.Text = "SOUTH CENTRO"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblSOUTH_VILLAZAR_Click(sender As Object, e As EventArgs) Handles lblSOUTH_VILLAZAR.Click
        PicMap.Image = My.Resources.South_Villazar
        pnlInfo.Visible = True
        MAP_BARANGAY = "SOUTH VILLAZAR"
        lblbarangay.Text = "SOUTH VILLAZAR"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblTAISAN_Click(sender As Object, e As EventArgs) Handles lblTAISAN.Click
        PicMap.Image = My.Resources.Taisan
        pnlInfo.Visible = True
        MAP_BARANGAY = "TAISAN"
        lblbarangay.Text = "TAISAN"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblTARA_Click(sender As Object, e As EventArgs) Handles lblTARA.Click
        PicMap.Image = My.Resources.Tara
        pnlInfo.Visible = True
        MAP_BARANGAY = "TARA"
        lblbarangay.Text = "TARA"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblTIBLE_Click(sender As Object, e As EventArgs) Handles lblTIBLE.Click
        PicMap.Image = My.Resources.Tible
        pnlInfo.Visible = True
        MAP_BARANGAY = "TIBLE"
        lblbarangay.Text = "TIBLE"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblTULA_TULA_Click(sender As Object, e As EventArgs) Handles lblTULA_TULA.Click
        PicMap.Image = My.Resources.Tula_Tula
        pnlInfo.Visible = True
        MAP_BARANGAY = "TULA-TULA"
        lblbarangay.Text = "TULA-TULA"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblVIGAAN_Click(sender As Object, e As EventArgs) Handles lblVIGAAN.Click
        PicMap.Image = My.Resources.Vigaan
        pnlInfo.Visible = True
        MAP_BARANGAY = "VIGAAN"
        lblbarangay.Text = "VIGAAN"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)
    End Sub

    Private Sub lblYABO_Click(sender As Object, e As EventArgs) Handles lblYABO.Click
        PicMap.Image = My.Resources.Yabo
        pnlInfo.Visible = True
        MAP_BARANGAY = "YABO"
        lblbarangay.Text = "YABO"
        lblRegMemNo.Text = barangay_number(MAP_BARANGAY)
        lblAgriArea.Text = Agricultural_Area(MAP_BARANGAY).ToString + " (ha)"
        lblRiceNo.Text = rice_number(MAP_BARANGAY)
        lblCornNo.Text = corn_number(MAP_BARANGAY)
        lblCoconutNo.Text = coconut_number(MAP_BARANGAY)
        lblHvcdpNo.Text = hvp_number(MAP_BARANGAY)
        lblLivestockNo.Text = animal_number_livestock(MAP_BARANGAY)
        lblPoultryNo.Text = animal_number_poultry(MAP_BARANGAY)

    End Sub

    Function Agricultural_Area(ByVal barangay As String)
        Try
            openCon()
            Dim ROWCOUNT As Decimal
            'Dim COUNT As String
            With cmd
                .Connection = con
                .CommandText = "SELECT sum(farm_area) FROM member,`farm_profile` WHERE member.mem_id = farm_profile.mem_id and member.mem_barangay = '" & barangay & "'"

                If IsDBNull(cmd.ExecuteScalar) Then
                    ROWCOUNT = 0
                Else
                    ROWCOUNT = cmd.ExecuteScalar
                End If



                Return ROWCOUNT.ToString
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Function

    Function barangay_number(ByVal barangay As String)
        Try
            openCon()
            Dim ROWCOUNT As Integer
            'Dim COUNT As String
            With cmd
                .Connection = con
                .CommandText = "SELECT COUNT(mem_barangay) FROM member WHERE mem_barangay = '" & barangay & "'"
                ROWCOUNT = cmd.ExecuteScalar

                Return ROWCOUNT
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Function

    Function rice_number(ByVal barangay As String)
        Try
            openCon()
            Dim ROWCOUNT As Integer
            'Dim COUNT As String
            With cmd
                .Connection = con
                .CommandText = "SELECT COUNT(crops.crops_type) FROM `member`, crops WHERE member.mem_id = crops.mem_id AND crops.crops_type = 'Rice' AND member.mem_barangay = '" & barangay & "'"
                ROWCOUNT = cmd.ExecuteScalar

                Return ROWCOUNT
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Function

    Function corn_number(ByVal barangay As String)
        Try
            openCon()
            Dim ROWCOUNT As Integer
            'Dim COUNT As String
            With cmd
                .Connection = con
                .CommandText = "SELECT COUNT(crops.crops_type) FROM `member`, crops WHERE member.mem_id = crops.mem_id AND crops.crops_type = 'Corn' AND member.mem_barangay = '" & barangay & "'"
                ROWCOUNT = cmd.ExecuteScalar

                Return ROWCOUNT
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Function

    Function coconut_number(ByVal barangay As String)
        Try
            openCon()
            Dim ROWCOUNT As Integer
            'Dim COUNT As String
            With cmd
                .Connection = con
                .CommandText = "SELECT COUNT(crops.crops_type) FROM `member`, crops WHERE member.mem_id = crops.mem_id AND crops.crops_type = 'Coconut' AND member.mem_barangay = '" & barangay & "'"
                ROWCOUNT = cmd.ExecuteScalar

                Return ROWCOUNT
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Function

    Function hvp_number(ByVal barangay As String)
        Try
            openCon()
            Dim ROWCOUNT As Integer
            'Dim COUNT As String
            With cmd
                .Connection = con
                .CommandText = "SELECT COUNT(crops.crops_cat) FROM `member`, crops WHERE member.mem_id = crops.mem_id AND crops.crops_cat = 'hvcdp' AND member.mem_barangay = '" & barangay & "'"
                ROWCOUNT = cmd.ExecuteScalar

                Return ROWCOUNT
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Function

    Function animal_number_livestock(ByVal barangay As String)
        Try
            openCon()
            Dim ROWCOUNT As Integer
            'Dim COUNT As String
            With cmd
                .Connection = con
                .CommandText = "SELECT SUM(animal.animal_no) FROM member, animal WHERE member.mem_id = animal.mem_id AND member.mem_barangay = '" & barangay & "' AND animal.animal_cat = 'livestock'"
                If IsDBNull(cmd.ExecuteScalar) Then
                    ROWCOUNT = 0
                Else
                    ROWCOUNT = cmd.ExecuteScalar
                End If


                Return ROWCOUNT
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            con.Close()
        End Try
    End Function

    Function animal_number_poultry(ByVal barangay As String)
        Try
            openCon()
            Dim ROWCOUNT As Integer
            'Dim COUNT As String
            With cmd
                .Connection = con
                .CommandText = "SELECT SUM(animal.animal_no) FROM member, animal WHERE member.mem_id = animal.mem_id AND member.mem_barangay = '" & barangay & "' AND animal.animal_cat = 'poultry'"
                If IsDBNull(cmd.ExecuteScalar) Then
                    ROWCOUNT = 0
                Else
                    ROWCOUNT = cmd.ExecuteScalar
                End If

                Return ROWCOUNT
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            con.Close()
        End Try
    End Function


End Class