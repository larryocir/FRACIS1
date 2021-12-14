Imports MySql.Data.MySqlClient
Module dbconnect
     Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public table As New DataTable
    Public reader As MySqlDataReader



    Sub openCon()
        con.ConnectionString = "server=localhost;username=root;password=;database=fracis"
        con.Open()
    End Sub



End Module
