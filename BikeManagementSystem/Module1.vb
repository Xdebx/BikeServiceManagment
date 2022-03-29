Imports MySql.Data.MySqlClient
Module Module_DB
    Public conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=mydb_pascua;User=root;Password=;SslMode=none;")
    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader
    Public DataAdapter1 As MySqlDataAdapter
    Public da As New MySqlDataAdapter
    Public ds As DataSet
    Public db As New MySqlCommand
    Public dset As New DataSet


    Public id As Integer
    Public user_id As Integer
    Public CusID As Integer
    Public CusName As String
    Public CusAddr As String
    Public CusPhone As Integer

    Public ProdID As Integer
    Public ProdDesc As String
    Public CostPrice As Integer
    Public Price As Integer
    Public ProdQTY As Integer
    Public ItemCatNAME As String
    Public BrandNAME As String

    Public AccessID As Integer
    Public AccessDesc As String
    Public AccessCP As Integer
    Public AccessPrice As Integer
    Public AccessQTY As Integer

    Public ServiceID As Integer
    Public ServiceDesc As String
    Public CostService As Integer

    Public SupID As Integer
    Public SupName As String
    Public SupAddress As String
    Public SupPhone As Integer



    Public OEID As Integer
    Public OENAME As String
    Public OEPRICE As Integer
    Public OwnerID As New Integer

    Public TravelFEE As Integer
    Public DateORDER As String
    Public DateSHIPPED As String
    Public Sourced As String

    Public ShipFEE As Integer

    Public MechID As Integer
    Public MechNAME As String
    Public MechADDR As String
    Public MECHUSERNAME As String
    Public MechWAGE As Double

    Public AccessBrand As String

    Public Function InsertMysqlCommand(ByVal sql As String) As Boolean

        db = New MySqlCommand(sql)
        If db.ExecuteNonQuery() > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Module

