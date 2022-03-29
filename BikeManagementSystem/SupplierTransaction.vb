Imports MySql.Data.MySqlClient
Public Class SupplierTransaction
    Dim table As New DataTable
    Private Sub SupplierTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load, cmdReload.Click
        Dim i As Integer
        conn.Open()
        dset.Clear()
        'Try
        sql = "SELECT d.Delivery_ID,d.Travel_Fee,d.Date_Order,d.Date_Shipped,p.Prod_ID,p.Prod_desc,p.Prod_Quantity,a.ID_Accessories,a.Access_Desc,a.Access_Quantity FROM DeliveryInfo d INNER JOIN Products p ON (d.Prod_id = p.Prod_id) INNER JOIN Accessories a ON (a.ID_Accessories = d.ID_Accessories)"
        DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Delivery_Product_Accessories")
            Dgrid2.DataSource = dset
            Dgrid2.DataMember = "Delivery_Product_Accessories"

            sql = "SELECT Delivery_ID FROM DeliveryInfo"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "DeliveryInfo")
            cmb1.Items.Clear()
            For i = 0 To dset.Tables("DeliveryInfo").Rows.Count - 1
                cmb1.Items.Add(dset.Tables("DeliveryInfo").Rows(i).Item(0))
            Next

            sql = "SELECT TypeName FROM Type"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Type")
            cmb2.Items.Clear()
            For i = 0 To dset.Tables("Type").Rows.Count - 1
                cmb2.Items.Add(dset.Tables("type").Rows(i).Item(0))
            Next

            sql = "SELECT Prod_ID FROM Products"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Prod")
            cmb3.Items.Clear()
            For i = 0 To dset.Tables("Prod").Rows.Count - 1
                cmb3.Items.Add(dset.Tables("Prod").Rows(i).Item(0))
            Next

            sql = "SELECT ID_Accessories FROM Accessories"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Accessories")
            cmb4.Items.Clear()
            For i = 0 To dset.Tables("Accessories").Rows.Count - 1
                cmb4.Items.Add(dset.Tables("Accessories").Rows(i).Item(0))
            Next
        'Catch ex As Exception
        'End Try
        conn.Close()
    End Sub

    Private Sub cmdADDtoCART_Click_1(sender As Object, e As EventArgs) Handles cmdADDtoCART.Click
        Dgrid1.Rows.Add(txtTravel.Text, txtDO.Text, txtDS.Text, txtSourced.Text, Val(cmb3.SelectedItem), txtProdDesc.Text, txtProdBrand.Text, txtProdQTY.Text, Val(cmb4.SelectedItem), txtAccessDesc.Text, txtAccessBrand.Text, txtAccessQTY.Text)
    End Sub

    Private Sub cmdDONEorder_Click(sender As Object, e As EventArgs) Handles cmdDONEorder.Click
        conn.Open()
        dset.Clear()
        Try
            'Insert
            TravelFEE = Val(txtTravel.Text)
            DateORDER = txtDO.Text
            DateSHIPPED = txtDS.Text
            ProdID = Val(txtProdID.Text)
            AccessID = Val(txtAccessID.Text)
            Sourced = txtSourced.Text

            'Update statement for stock 
            ProdQTY = Val(txtProdQTY.Text)
            AccessQTY = Val(txtAccessQTY.Text)


            For Each row As DataGridViewRow In Dgrid1.Rows
                    sql = "INSERT INTO DeliveryInfo(Travel_Fee,Date_Order,Date_Shipped,TypeName,Prod_ID,ID_Accessories) VALUES ('" & row.Cells(0).Value & "', '" & row.Cells(1).Value & "', '" & row.Cells(2).Value & "','" & row.Cells(3).Value & "', '" & row.Cells(4).Value & "', '" & row.Cells(8).Value & "')"
                    dbcomm = New MySqlCommand(sql, conn)
                    dbcomm.ExecuteNonQuery()
                Next

                For Each row As DataGridViewRow In Dgrid1.Rows
                    sql = "UPDATE Products SET Prod_Quantity = Prod_Quantity + " & Val(row.Cells(7).Value) & " WHERE Prod_ID = " & row.Cells(4).Value & ""
                    dbcomm = New MySqlCommand(sql, conn)
                    dbcomm.ExecuteNonQuery()

                    sql = "UPDATE Accessories SET Access_Quantity = Access_Quantity + " & row.Cells(11).Value & " WHERE ID_Accessories = " & row.Cells(8).Value & ""
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

    Private Sub cmdDelDataGrid_Click(sender As Object, e As EventArgs) Handles cmdDelDataGrid.Click
        Dim index As Integer
        index = Dgrid1.CurrentCell.RowIndex
        Dgrid1.Rows.RemoveAt(index)

        txtDeliveryID.Clear()
        txtTravel.Clear()
        txtDO.Clear()
        txtDS.Clear()
        txtSourced.Clear()
        txtProdID.Clear()
        txtProdDesc.Clear()
        txtProdQTY.Clear()
        txtAccessID.Clear()
        txtAccessDesc.Clear()
        txtAccessQTY.Clear()

    End Sub

    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged
        txtDeliveryID.Text = cmb1.Items(cmb1.SelectedIndex)
    End Sub

    Private Sub cmb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb2.SelectedIndexChanged
        txtSourced.Text = cmb2.Items(cmb2.SelectedIndex)
    End Sub

    Private Sub cmb3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb3.SelectedIndexChanged
        txtProdID.Text = cmb3.Items(cmb3.SelectedIndex)
        conn.Open()

        sql = "SELECT * FROM Products WHERE Prod_ID = '" & cmb3.Text & "'"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            txtProdDesc.Text = dbread("Prod_desc")
            txtProdBrand.Text = dbread("Brandname")
        End While
        conn.Close()

    End Sub

    Private Sub cmb4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb4.SelectedIndexChanged
        txtAccessID.Text = cmb4.Items(cmb4.SelectedIndex)
        conn.Open()

        sql = "SELECT * FROM Accessories WHERE ID_Accessories = '" & cmb4.Text & "'"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            txtAccessDesc.Text = dbread("Access_Desc")
            txtAccessBrand.Text = dbread("Brandname")
        End While
        conn.Close()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        conn.Open()
        table.Clear()
        Try

            sql = "SELECT d.Delivery_ID,d.Travel_Fee,d.Date_Order,d.Date_Shipped,p.Prod_ID,p.Prod_desc,p.Prod_Quantity,a.ID_Accessories,a.Access_Desc,a.Access_Quantity FROM DeliveryInfo d INNER JOIN Products p ON (d.Prod_id = p.Prod_id) INNER JOIN Accessories a ON (a.ID_Accessories = d.ID_Accessories) WHERE Delivery_ID = " & Val(txtSearch.Text) & ""
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
End Class