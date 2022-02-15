Imports System.Windows.Forms.DataVisualization.Charting
Public Class frmDashboard

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MemberCount()
        Animals_no()
        Crops_no()
        LoadChart()
        LoadChart2()
        LoadChart3()



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

                lblFarmerNo.Text = ROWCOUNT
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

                lblCropsNo.Text = ROWCOUNT
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

    Sub LoadChart()
        Try
            openCon()
            With Chart1
                .Series.Clear()
                .Series.Add("Series1")
            End With
            cmd.Connection = con
            cmd.CommandText = "SELECT DISTINCT(mem_barangay) as Barangay, (SELECT COUNT(mem_barangay)  FROM member where mem_barangay = Barangay) as Bilang from member 
                                ORDER BY `Barangay`  ASC "
            adapter.SelectCommand = cmd
            adapter.Fill(data, "Member_Number")
            Chart1.DataSource = data.Tables("Member_Number")
            Dim series1 As Series = Chart1.Series("Series1")
            series1.ChartType = SeriesChartType.Column

            series1.Name = "Member_Number"

            With Chart1
                .Series(series1.Name).XValueMember = "Barangay"
                .Series(series1.Name).YValueMembers = "Bilang"
                .Series(0).LabelFormat = "{#,##0}"

                .Series(0).IsValueShownAsLabel = True
                '.Series(0).LegendText = "#VALX (#PERCENT)"
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try




    End Sub

    Sub LoadChart2()
        Try
            openCon()
            With Chart2
                .Series.Clear()
                .Series.Add("Series1")
            End With
            cmd.Connection = con
            cmd.CommandText = "SELECT DISTINCT(crops_cat) as Crops, (SELECT COUNT(crops_cat)  FROM crops where crops_cat = Crops) as Bilang from crops  
                                ORDER BY `Crops`  ASC"
            adapter.SelectCommand = cmd
            adapter.Fill(data, "Member_Number")
            Chart2.DataSource = data.Tables("Member_Number")
            Dim series1 As Series = Chart2.Series("Series1")
            series1.ChartType = SeriesChartType.Pie

            series1.Name = "Member_Number"

            With Chart2
                .Series(series1.Name).XValueMember = "Crops"
                .Series(series1.Name).YValueMembers = "Bilang"
                .Series(0).LabelFormat = "{#,##0}"

                .Series(0).IsValueShownAsLabel = True
                .Series(0).LegendText = "#VALX (#PERCENT)"
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try




    End Sub

    Sub LoadChart3()
        Try
            openCon()
            With Chart3
                .Series.Clear()
                .Series.Add("Series1")
            End With
            cmd.Connection = con
            cmd.CommandText = "SELECT DISTINCT(animal_cat) as Animals, (SELECT SUM(animal_no) FROM animal where animal_cat = Animals) as Bilang from animal  
                                ORDER BY `Animals`  ASC"
            adapter.SelectCommand = cmd
            adapter.Fill(data, "Member_Number")
            Chart3.DataSource = data.Tables("Member_Number")
            Dim series1 As Series = Chart3.Series("Series1")
            series1.ChartType = SeriesChartType.Pie

            series1.Name = "Member_Number"

            With Chart3
                .Series(series1.Name).XValueMember = "Animals"
                .Series(series1.Name).YValueMembers = "Bilang"
                .Series(0).LabelFormat = "{#,##0}"

                .Series(0).IsValueShownAsLabel = True
                .Series(0).LegendText = "#VALX (#PERCENT)"

            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try




    End Sub



    '    BPublic Class Form2
    'Dim cn As New MySqlconnection
    'Oreferences
    'Private Sub Form2_Load(sender As Object, e As Eventargs) Handles MyBase.Load
    'With cn
    '.ConnectionString = "server-localhost;user id-root;password ;database-brgyhealth"
    'End With
    'End Sub
    'Oreferences
    'Sub LoadChart()
    'With Chart1
    'Series.Clear ()
    '.Series. Add("Series1")
    'End with
    'Đim da As New MysqlDataAdapter("select brgy, population from tblbarangay where municipal like
    'Dim ds As New Dataset
    'da. Fill(ds, "Population")
    'Chartl.DataSource - ds. Tables("Population")
    'Din series1 AS Series - Chart1.Series("Series1")
    'series1.ChartType - SeriesChartType. Pie
    'series1.Name - "POPULATION"
    'With Charti
    'Series (series1. Name).XValueMember - "brgy"
    'Series(series1.Name). YValueMembers - "population"
    '.Series (e). LabelFormat - "(#,##0)"
    'End with
    'End Sub
End Class