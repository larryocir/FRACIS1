Imports Microsoft.Office.Interop
Public Class frmImport
    Public RiceArea, CoconutArea, CornArea, FruitsArea, RootCropsArea, VegetablesArea As String
    Public ChickenNum, DuckNum, GooseNum, TurkeyNum, CarabaoNum, CattleNum, GoatNum, SwineNum, DogNum, CatNum As String

    Private Sub frmImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim xlRange As Excel.Range
        Dim xlRow As Integer


        Dim strFilename As String

        With OpenFileDialog1
            .Filter = "Excel Office| *.xls;*.xlsx;*.csv;"
            .ShowDialog()
            strFilename = .FileName
        End With
        Try
            If strFilename <> String.Empty Then
                Dim rowcount As Integer = 0
                xlApp = New Excel.Application
                xlWorkBook = xlApp.Workbooks.Open(strFilename)
                xlWorkSheet = xlWorkBook.Worksheets("Sheet1")
                xlRange = xlWorkSheet.UsedRange
                Panel3.Show()
                'Label1.Text = xlRange.Columns.Count
                For xlRow = 1 To xlRange.Rows.Count
                    rowcount += 1
                    ' If xlRange.Cells(xlRow, 1).Text <> String.Empty And xlRange.Cells(xlRow, 2).Text <> String.Empty And xlRange.Cells(xlRow, 3).Text <> String.Empty And xlRange.Cells(xlRow, 4).Text <> String.Empty And xlRange.Cells(xlRow, 5).Text <> String.Empty And xlRange.Cells(xlRow, 5).Text <> String.Empty Then
                    DataGridView1.Rows.Add(xlRange.Cells(xlRow, 1).Text, xlRange.Cells(xlRow, 2).Text, xlRange.Cells(xlRow, 3).Text, xlRange.Cells(xlRow, 4).Text, xlRange.Cells(xlRow, 5).Text, xlRange.Cells(xlRow, 6).Text,
                                                xlRange.Cells(xlRow, 7).Text, xlRange.Cells(xlRow, 8).Text, xlRange.Cells(xlRow, 9).Text, xlRange.Cells(xlRow, 10).Text, xlRange.Cells(xlRow, 11).Text, xlRange.Cells(xlRow, 12).Text,
                                                xlRange.Cells(xlRow, 13).Text, xlRange.Cells(xlRow, 14).Text, xlRange.Cells(xlRow, 15).Text, xlRange.Cells(xlRow, 16).Text, xlRange.Cells(xlRow, 17).Text, xlRange.Cells(xlRow, 18).Text,
                                                xlRange.Cells(xlRow, 19).Text, xlRange.Cells(xlRow, 20).Text, xlRange.Cells(xlRow, 21).Text, xlRange.Cells(xlRow, 22).Text, xlRange.Cells(xlRow, 23).Text, xlRange.Cells(xlRow, 24).Text,
                                                xlRange.Cells(xlRow, 25).Text, xlRange.Cells(xlRow, 26).Text, xlRange.Cells(xlRow, 27).Text, xlRange.Cells(xlRow, 28).Text, xlRange.Cells(xlRow, 29).Text,
                                                xlRange.Cells(xlRow, 30).Text, xlRange.Cells(xlRow, 31).Text, xlRange.Cells(xlRow, 32).Text, xlRange.Cells(xlRow, 33).Text, xlRange.Cells(xlRow, 34).Text, xlRange.Cells(xlRow, 35).Text, xlRange.Cells(xlRow, 36).Text)
                        lblcount.Text = rowcount & " Records."
                    '   End If
                    Me.Refresh()

                Next
                Panel3.Hide()

                xlWorkBook.Close()
                xlApp.Quit()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim i As Integer
        If MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes Then
            Try
                For i = 0 To DataGridView1.RowCount - 1

                    openCon()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO `member`(`mem_fname`, `mem_lname`, `mem_mname`, `mem_extname`, `mem_barangay`, `mem_municipality`, `mem_province`, `mem_dob`, `mem_pob`, `mem_sex`, `mem_cp`, `mem_civilstatus`, `mem_spouse`) VALUES 
                                (@FNAME, @LNAME, @MNAME, @EXTNAME, @BARANGAY, @MUNICIPALITY, @PROVINCE, @DOB, @POB, @SEX, @CONTACT, @CIVILSTATUS, @SPOUSE)"
                    With cmd
                        .Parameters.AddWithValue("@FNAME", DataGridView1.Rows(i).Cells(0).Value.ToString)
                        .Parameters.AddWithValue("@MNAME", DataGridView1.Rows(i).Cells(1).Value.ToString)
                        .Parameters.AddWithValue("@LNAME", DataGridView1.Rows(i).Cells(2).Value.ToString)
                        .Parameters.AddWithValue("@EXTNAME", DataGridView1.Rows(i).Cells(3).Value.ToString)
                        .Parameters.AddWithValue("@BARANGAY", DataGridView1.Rows(i).Cells(4).Value.ToString)
                        .Parameters.AddWithValue("@MUNICIPALITY", "SIPOCOT")
                        .Parameters.AddWithValue("@PROVINCE", "CAMARINES SUR")
                        .Parameters.AddWithValue("@SEX", DataGridView1.Rows(i).Cells(5).Value.ToString)
                        .Parameters.AddWithValue("@DOB", DataGridView1.Rows(i).Cells(6).Value.ToString)
                        .Parameters.AddWithValue("@POB", DataGridView1.Rows(i).Cells(7).Value.ToString)
                        .Parameters.AddWithValue("@CONTACT", DataGridView1.Rows(i).Cells(8).Value.ToString)
                        .Parameters.AddWithValue("@CIVILSTATUS", DataGridView1.Rows(i).Cells(9).Value.ToString)
                        .Parameters.AddWithValue("@SPOUSE", DataGridView1.Rows(i).Cells(10).Value.ToString)
                        .ExecuteNonQuery()
                        .Parameters.Clear()
                    End With
                    con.Close()

                    MAXXID()

                    openCon()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO `farm_profile`(`farm_location`, `farm_type`, `farm_area`, `farm_ownertype`, `farm_owner`, `farm_boundary_north`, `farm_boundary_south`, `farm_boundary_east`, `farm_boundary_west`, `mem_id`) 
                                VALUES (@LOCATION, @FARMTYPE, @FARM_AREA, @OWNERTYPE, @OWNER, @NORTH, @SOUTH, @EAST,@WEST, @FARMMEM_ID)"
                    With cmd
                        .Parameters.AddWithValue("@LOCATION", DataGridView1.Rows(i).Cells(11).Value.ToString)
                        .Parameters.AddWithValue("@FARMTYPE", DataGridView1.Rows(i).Cells(12).Value.ToString)
                        .Parameters.AddWithValue("@FARM_AREA", DataGridView1.Rows(i).Cells(13).Value.ToString)
                        .Parameters.AddWithValue("@OWNERTYPE", DataGridView1.Rows(i).Cells(14).Value.ToString)
                        .Parameters.AddWithValue("@OWNER", DataGridView1.Rows(i).Cells(15).Value.ToString)
                        .Parameters.AddWithValue("@NORTH", DataGridView1.Rows(i).Cells(16).Value.ToString)
                        .Parameters.AddWithValue("@SOUTH", DataGridView1.Rows(i).Cells(19).Value.ToString)
                        .Parameters.AddWithValue("@EAST", DataGridView1.Rows(i).Cells(17).Value.ToString)
                        .Parameters.AddWithValue("@WEST", DataGridView1.Rows(i).Cells(18).Value.ToString)
                        .Parameters.AddWithValue("@FARMMEM_ID", MAXID)
                        .ExecuteNonQuery()
                        .Parameters.Clear()
                    End With
                    con.Close()

                    RiceArea = DataGridView1.Rows(i).Cells(20).Value.ToString
                    CoconutArea = DataGridView1.Rows(i).Cells(21).Value.ToString
                    CornArea = DataGridView1.Rows(i).Cells(22).Value.ToString
                    FruitsArea = DataGridView1.Rows(i).Cells(23).Value.ToString
                    RootCropsArea = DataGridView1.Rows(i).Cells(24).Value.ToString
                    VegetablesArea = DataGridView1.Rows(i).Cells(25).Value.ToString
                    ChickenNum = DataGridView1.Rows(i).Cells(26).Value.ToString
                    DuckNum = DataGridView1.Rows(i).Cells(27).Value.ToString
                    GooseNum = DataGridView1.Rows(i).Cells(28).Value.ToString
                    TurkeyNum = DataGridView1.Rows(i).Cells(29).Value.ToString
                    CarabaoNum = DataGridView1.Rows(i).Cells(30).Value.ToString
                    CattleNum = DataGridView1.Rows(i).Cells(31).Value.ToString
                    GoatNum = DataGridView1.Rows(i).Cells(32).Value.ToString
                    SwineNum = DataGridView1.Rows(i).Cells(33).Value.ToString
                    DogNum = DataGridView1.Rows(i).Cells(34).Value.ToString
                    CatNum = DataGridView1.Rows(i).Cells(35).Value.ToString

                    CHECKBOX_INSERT()
                    Call loadTable()
                Next

                MsgBox("Record has been successfully saved!", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        DataGridView1.Rows.Clear()
    End Sub

    'MAX ID
    Sub MAXXID()
        openCon()
        With cmd
            .Connection = con
            .CommandText = "SELECT MAX(mem_id) FROM `member`"
            MAXID = cmd.ExecuteScalar
            .Dispose()
            con.Close()
        End With
    End Sub

    Sub CHECKBOX_INSERT()
        If RiceArea <> Nothing Then
            CROP_LANDAREA = RiceArea
            CROP_CATEGORIES = "Rice"
            CROP_TYPE = "Rice"
            Success = Checkbox_Crops_function(CROP_LANDAREA, CROP_CATEGORIES, CROP_TYPE, CROP_ID, MEM_ID)
        End If

        If CoconutArea <> Nothing Then
            CROP_LANDAREA = CoconutArea
            CROP_CATEGORIES = "Coconut"
            CROP_TYPE = "Coconut"
            Success = Checkbox_Crops_function(CROP_LANDAREA, CROP_CATEGORIES, CROP_TYPE, CROP_ID, MEM_ID)
        End If

        If CornArea <> Nothing Then
            CROP_LANDAREA = CornArea
            CROP_CATEGORIES = "Corn"
            CROP_TYPE = "Corn"
            Success = Checkbox_Crops_function(CROP_LANDAREA, CROP_CATEGORIES, CROP_TYPE, CROP_ID, MEM_ID)
        End If

        If FruitsArea <> Nothing Then
            CROP_LANDAREA = FruitsArea
            CROP_CATEGORIES = "HVCDP"
            CROP_TYPE = "Fruits"
            Success = Checkbox_Crops_function(CROP_LANDAREA, CROP_CATEGORIES, CROP_TYPE, CROP_ID, MEM_ID)
        End If

        If RootCropsArea <> Nothing Then
            CROP_LANDAREA = RootCropsArea
            CROP_CATEGORIES = "HVCDP"
            CROP_TYPE = "Root Crops"
            Success = Checkbox_Crops_function(CROP_LANDAREA, CROP_CATEGORIES, CROP_TYPE, CROP_ID, MEM_ID)
        End If

        If VegetablesArea <> Nothing Then
            CROP_LANDAREA = VegetablesArea
            CROP_CATEGORIES = "HVCDP"
            CROP_TYPE = "Vegetables"
            Success = Checkbox_Crops_function(CROP_LANDAREA, CROP_CATEGORIES, CROP_TYPE, CROP_ID, MEM_ID)
        End If

        If ChickenNum <> Nothing Then
            ANIMAL_QTY = ChickenNum
            ANIMAL_CATEGORIES = "Poultry"
            ANIMAL_TYPE = "Chicken"
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If DuckNum <> Nothing Then
            ANIMAL_QTY = DuckNum
            ANIMAL_CATEGORIES = "Poultry"
            ANIMAL_TYPE = "Duck"
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If GooseNum <> Nothing Then
            ANIMAL_QTY = GooseNum
            ANIMAL_CATEGORIES = "Poultry"
            ANIMAL_TYPE = "Goose"
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If TurkeyNum <> Nothing Then
            ANIMAL_QTY = TurkeyNum
            ANIMAL_CATEGORIES = "Poultry"
            ANIMAL_TYPE = "Turkey"
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If CarabaoNum <> Nothing Then
            ANIMAL_QTY = CarabaoNum
            ANIMAL_CATEGORIES = "Livestock"
            ANIMAL_TYPE = "Carabao"
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If CattleNum <> Nothing Then
            ANIMAL_QTY = CattleNum
            ANIMAL_CATEGORIES = "Livestock"
            ANIMAL_TYPE = "Cattle"
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If GoatNum <> Nothing Then
            ANIMAL_QTY = GoatNum
            ANIMAL_CATEGORIES = "Livestock"
            ANIMAL_TYPE = "Goat"
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If SwineNum <> Nothing Then
            ANIMAL_QTY = SwineNum
            ANIMAL_CATEGORIES = "Livestock"
            ANIMAL_TYPE = "Swine"
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If DogNum <> Nothing Then
            ANIMAL_QTY = DogNum
            ANIMAL_CATEGORIES = "Other Animals"
            ANIMAL_TYPE = "Dog"
            ANIMAL_ID = DOGID
            MEM_ID = GlobalId
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

        If CatNum <> Nothing Then
            ANIMAL_QTY = CatNum
            ANIMAL_CATEGORIES = "Other Animals"
            ANIMAL_TYPE = "Cat"
            ANIMAL_ID = CATTLEID
            MEM_ID = GlobalId
            Success = Checkbox_Animals_function(ANIMAL_QTY, ANIMAL_CATEGORIES, ANIMAL_TYPE, ANIMAL_ID, MEM_ID)
        End If

    End Sub


    'FUNCTIONS
    Function Checkbox_Crops_function(ByVal crop_landarea As String, ByVal crop_categories As String, ByVal crop_type As String, ByVal crop_id As Integer, ByVal mem_id As Integer) As Boolean
        MAXXID()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO `crops`(`crops_type`, `crops_cat`, `crops_landarea`, `mem_id`) VALUES 
                                    (@CROP_TYPE,@CROP_CAT,@CROP_AREA,@MEM_ID)"
            With cmd
                .Parameters.AddWithValue("@CROP_TYPE", crop_type)
                .Parameters.AddWithValue("@CROP_CAT", crop_categories)
                .Parameters.AddWithValue("@CROP_AREA", crop_landarea)
                .Parameters.AddWithValue("@MEM_ID", MAXID)
            End With
            result = cmd.ExecuteNonQuery()
            If result > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            con.Close()
        End Try
    End Function

    Function Checkbox_Animals_function(ByVal animal_qty As String, ByVal animal_cat As String, ByVal animal_type As String, ByVal animal_id As Integer, ByVal mem_id As Integer) As Boolean
        MAXXID()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO `animal`( `animal_type`, `animal_cat`, `animal_no`, `mem_id`) 
                                VALUES (@ANIMAL_TYPE, @ANIMAL_CAT, @ANIMAL_QTY,@MEM_ID)"
            With cmd
                .Parameters.AddWithValue("@ANIMAL_TYPE", animal_type)
                .Parameters.AddWithValue("@ANIMAL_CAT", animal_cat)
                .Parameters.AddWithValue("@ANIMAL_QTY", animal_qty)
                .Parameters.AddWithValue("@MEM_ID", MAXID)
            End With
            result = cmd.ExecuteNonQuery()
            If result > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            con.Close()
        End Try
    End Function

    Sub loadTable()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM member"
            reader = cmd.ExecuteReader()

            frmFarmers.dgrdmember.Rows.Clear()
            Do While reader.Read = True
                frmFarmers.dgrdmember.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9), reader(10), reader(12), reader(13), reader(14), reader(15))
            Loop
            frmFarmers.Label4.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally

            cmd.Dispose()
            con.Close()
        End Try


    End Sub


End Class