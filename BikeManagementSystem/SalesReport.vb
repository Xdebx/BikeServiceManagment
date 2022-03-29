Imports MySql.Data.MySqlClient
Public Class SalesReport
    Private Sub SalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        dset.Clear()
        Try
            sql = "SELECT o.Order_ID,o.Order_Date,o.Order_Shipped,o.Shipping_Fee,c.Cus_ID,c.Cus_Name,c.Cus_addr,p.Prod_ID,p.Prod_desc,p.Sell_Price,a.ID_Accessories,a.Access_Desc,a.Sell_Price FROM Order_Transaction o INNER JOIN Customer c ON (o.Cus_ID = c.Cus_ID) INNER JOIN Products p ON (o.Prod_id = p.Prod_id) INNER JOIN Accessories a ON (a.ID_Accessories = o.ID_Accessories)"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Order_Customer_Product_Accessories")
            Dgrid1.DataSource = dset
            Dgrid1.DataMember = "Order_Customer_Product_Accessories"


            sql = "SELECT BST.MechService_ID,BST.Date_Start,BST.Date_Finish,S.Service_ID,S.Service_desc,S.Cost_Service,M.Mechanic_ID,M.Mechanic_name,M.Mechanic_address,C.Cus_ID,C.Cus_name,C.Cus_phone,C.Cus_addr FROM BikeService_Trans BST INNER JOIN Bike_Services S ON (BST.Service_ID = S.Service_ID) INNER JOIN Mechanics M ON (BST.Mechanic_ID = M.Mechanic_ID ) INNER JOIN Customer C ON (BST.Cus_ID = C.Cus_ID ) "
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "BikeService_Trans_Mechanics_Customer_Services")
            Dgrid2.DataSource = dset
            Dgrid2.DataMember = "BikeService_Trans_Mechanics_Customer_Services"

        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
        End Try
        conn.Close()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ServiceReport()
        OrderReport()
    End Sub

    Public Sub OrderReport()
        Dim TOTAL As Double
        For t As Integer = 0 To Dgrid1.RowCount - 1
            TOTAL += (Dgrid1.Rows(t).Cells(9).Value + Dgrid1.Rows(t).Cells(12).Value)
        Next
        txtOrderSaleGrandTotal.Text = FormatCurrency(TOTAL)
    End Sub
    Public Sub ServiceReport()
        Dim TOTAL As Double
        For t As Integer = 0 To Dgrid2.RowCount - 1
            TOTAL += (Dgrid2.Rows(t).Cells(5).Value)
        Next
        txtServiceSalesGrandTotal.Text = FormatCurrency(TOTAL)
    End Sub

    Private Sub cmdMonthly_Click(sender As Object, e As EventArgs) Handles cmdMonthly.Click
        Dim table As New DataTable
        Dim currrdate As String = Convert.ToDateTime(DateTimePicker1.Value).ToString("YYYY-MM")

        'conn.Open()
        'dset.Clear()
        conn.Open()
        table.Clear()
        Try
            sql = "SELECT * FROM Order_Transaction WHERE Order_Date = '" & currrdate & "'"
            'sql = "SELECT o.Order_ID,o.Order_Date,o.Order_Shipped,o.Shipping_Fee,c.Cus_ID,c.Cus_Name,c.Cus_addr,p.Prod_ID,p.Prod_desc,p.Sell_Price,a.ID_Accessories,a.Access_Desc,a.Sell_Price FROM Order_Transaction o INNER JOIN Customer c ON (o.Cus_ID = c.Cus_ID) INNER JOIN Products p ON (o.Prod_id = p.Prod_id) INNER JOIN Accessories a ON (a.ID_Accessories = o.ID_Accessories) WHERE Order_Date = '#" & DateTimePicker1.Text & "#'"
            dbcomm = New MySqlCommand(sql, conn)
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(table)
            Dgrid1.DataSource = table

        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
        End Try

        ' sql = "SELECT * FROM Order_Transaction WHERE Order_Date = '" & curdate & "'"
        'sql = "SELECT o.Order_ID,o.Order_Date,o.Order_Shipped,o.Shipping_Fee,c.Cus_ID,c.Cus_Name,c.Cus_addr,p.Prod_ID,p.Prod_desc,p.Sell_Price,a.ID_Accessories,a.Access_Desc,a.Sell_Price FROM Order_Transaction o INNER JOIN Customer c ON (o.Cus_ID = c.Cus_ID) INNER JOIN Products p ON (o.Prod_id = p.Prod_id) INNER JOIN Accessories a ON (a.ID_Accessories = o.ID_Accessories) WHERE Order_Date = '" & curdate & "'"
        'DataAdapter1 = New MySqlDataAdapter(sql, conn)
        'DataAdapter1.Fill(dset, "Order_Customer_Product_Accessories")
        'Dgrid1.DataSource = dset
        'Dgrid1.DataMember = "Order_Customer_Product_Accessories"
        conn.Close()
    End Sub

    Private Sub cmdDaily_Click(sender As Object, e As EventArgs) Handles cmdDaily.Click

        conn.Open()



        conn.Close()
    End Sub
End Class