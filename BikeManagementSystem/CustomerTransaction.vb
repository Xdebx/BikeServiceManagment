Imports MySql.Data.MySqlClient
Public Class CustomerTransaction
    Dim table As New DataTable
    Private Sub CustomerTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load, cmdReload.Click
        Dim i As Integer
        conn.Open()
        dset.Clear()
        Try
            sql = "SELECT o.Order_ID,o.Order_Date,o.Order_Shipped,o.Shipping_Fee,c.Cus_ID,c.Cus_Name,c.Cus_addr,p.Prod_ID,p.Prod_desc,p.Prod_Quantity,a.ID_Accessories,a.Access_Desc,a.Access_Quantity FROM Order_Transaction o INNER JOIN Customer c ON (o.Cus_ID = c.Cus_ID) INNER JOIN Products p ON (o.Prod_id = p.Prod_id) INNER JOIN Accessories a ON (a.ID_Accessories = o.ID_Accessories)"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Order_Customer_Product_Accessories")
            Dgrid2.DataSource = dset
            Dgrid2.DataMember = "Order_Customer_Product_Accessories"

            sql = "SELECT Cus_ID FROM Customer"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Customer")
            cmb1.Items.Clear()
            For i = 0 To dset.Tables("Customer").Rows.Count - 1
                cmb1.Items.Add(dset.Tables("Customer").Rows(i).Item(0))
            Next

            sql = "SELECT Order_ID FROM Order_Transaction"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Order_Transaction")
            cmb2.Items.Clear()
            For i = 0 To dset.Tables("Order_Transaction").Rows.Count - 1
                cmb2.Items.Add(dset.Tables("Order_Transaction").Rows(i).Item(0))
            Next

            sql = "SELECT Prod_ID FROM Products"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Products")
            cmb3.Items.Clear()
            For i = 0 To dset.Tables("Products").Rows.Count - 1
                cmb3.Items.Add(dset.Tables("Products").Rows(i).Item(0))
            Next

            sql = "SELECT ID_Accessories FROM Accessories"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Accessories")
            cmb4.Items.Clear()
            For i = 0 To dset.Tables("Accessories").Rows.Count - 1
                cmb4.Items.Add(dset.Tables("Accessories").Rows(i).Item(0))
            Next

        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
        End Try
        conn.Close()
    End Sub
    Private Sub cmdADDtoCART_Click(sender As Object, e As EventArgs) Handles cmdADDtoCART.Click
        Dgrid1.Rows.Add(Val(cmb1.SelectedItem), txtCusname.Text, txtAddr.Text, txtDO.Text, txtDS.Text, txtShipping.Text, Val(cmb3.SelectedItem), txtProdDesc.Text, txtProdQTY.Text, txtProdBrand.Text, Val(cmb4.SelectedItem), txtAccessDesc.Text, txtAccessQTY.Text, txtAccessBrand.Text)
    End Sub

    Private Sub cmdDelDataGrid_Click(sender As Object, e As EventArgs) Handles cmdDelDataGrid.Click
        Dim index As Integer
        index = Dgrid1.CurrentCell.RowIndex
        Dgrid1.Rows.RemoveAt(index)

        txtAddr.Clear()
        txtCusID.Clear()
        txtCusname.Clear()
        txtCusname.Clear()
        txtOrderID.Clear()
        txtShipping.Clear()
        txtDO.Clear()
        txtDS.Clear()
        txtProdID.Clear()
        txtProdDesc.Clear()
        txtProdQTY.Clear()
        txtAccessID.Clear()
        txtAccessDesc.Clear()
        txtAccessQTY.Clear()
    End Sub
    Private Sub cmb1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged
        txtCusID.Text = cmb1.Items(cmb1.SelectedIndex)
        conn.Open()

        sql = "SELECT * FROM Customer WHERE Cus_ID = '" & cmb1.Text & "'"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            txtCusname.Text = dbread("Cus_name")
            txtAddr.Text = dbread("Cus_addr")
        End While
        conn.Close()
    End Sub
    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb2.SelectedIndexChanged
        txtOrderID.Text = cmb2.Items(cmb2.SelectedIndex)
    End Sub

    Private Sub cmb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb3.SelectedIndexChanged
        txtProdID.Text = cmb3.Items(cmb3.SelectedIndex)
        conn.Open()

        sql = "SELECT * FROM Products WHERE Prod_ID = '" & cmb3.Text & "'"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            txtProdDesc.Text = dbread("Prod_desc")
            txtProdBrand.Text = dbread("BrandName")
        End While
        conn.Close()
    End Sub

    Private Sub cmb3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb4.SelectedIndexChanged
        txtAccessID.Text = cmb4.Items(cmb4.SelectedIndex)
        conn.Open()

        sql = "SELECT * FROM Accessories WHERE ID_Accessories = '" & cmb4.Text & "'"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            txtAccessDesc.Text = dbread("Access_Desc")
            txtAccessBrand.Text = dbread("BrandName")
        End While
        conn.Close()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        conn.Open()
        table.Clear()
        Try
            sql = "SELECT o.Order_ID,o.Order_Date,o.Order_Shipped,o.Shipping_Fee,c.Cus_ID,c.Cus_Name,c.Cus_addr,p.Prod_ID,p.Prod_desc,p.Prod_Quantity,a.ID_Accessories,a.Access_Desc,a.Access_Quantity FROM Order_Transaction o INNER JOIN Customer c ON (o.Cus_ID = c.Cus_ID) INNER JOIN Products p ON (o.Prod_id = p.Prod_id) INNER JOIN Accessories a ON (a.ID_Accessories = o.ID_Accessories) WHERE Order_Id = " & Val(txtSearch.Text) & ""
            dbcomm = New MySqlCommand(sql, conn)
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(table)
            Dgrid2.DataSource = table

            dbread = dbcomm.ExecuteReader()
        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
        End Try
        conn.Close()
    End Sub

    Private Sub cmdDONEorder_Click(sender As Object, e As EventArgs) Handles cmdDONEorder.Click
        conn.Open()
        dset.Clear()
        Try
            'Insert
            ShipFEE = Val(txtShipping.Text)
            DateORDER = txtDO.Text
            DateSHIPPED = txtDS.Text
            ProdID = Val(txtProdID.Text)
            AccessID = Val(txtAccessID.Text)
            CusID = Val(txtCusID.Text)

            'Update statement for stock 
            ProdQTY = Val(txtProdQTY.Text)
            AccessQTY = Val(txtAccessQTY.Text)

            For Each row As DataGridViewRow In Dgrid1.Rows
                    sql = "INSERT INTO Order_Transaction(Cus_ID,Order_Date,Order_Shipped,Shipping_Fee,Prod_ID,ID_Accessories) VALUES ('" & row.Cells(0).Value & "', '" & row.Cells(3).Value & "', '" & (row.Cells(4).Value) & "','" & row.Cells(5).Value & "', '" & row.Cells(6).Value & "', '" & row.Cells(10).Value & "')"
                    dbcomm = New MySqlCommand(sql, conn)
                    dbcomm.ExecuteNonQuery()
                Next

            For Each row As DataGridViewRow In Dgrid1.Rows
                sql = "UPDATE Products SET Prod_Quantity = Prod_Quantity - " & Val(row.Cells(8).Value) & " WHERE Prod_ID = " & row.Cells(6).Value & ""
                dbcomm = New MySqlCommand(sql, conn)
                dbcomm.ExecuteNonQuery()

                sql = "UPDATE Accessories SET Access_Quantity = Access_Quantity - " & row.Cells(12).Value & " WHERE ID_Accessories = " & row.Cells(10).Value & ""
                dbcomm = New MySqlCommand(sql, conn)
                dbcomm.ExecuteNonQuery()
            Next

            Dim output As DialogResult = MessageBox.Show("Do you want to Add Another Puchase", "Add another Item?", MessageBoxButtons.YesNo)
            If output = DialogResult.No Then
            ElseIf output = DialogResult.Yes Then
            End If
            MsgBox("Data Inserted", MsgBoxStyle.Information, "Info")
        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
        End Try
        conn.Close()
    End Sub


End Class