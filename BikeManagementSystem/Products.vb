Imports MySql.Data.MySqlClient
Public Class Products
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load, cmdREFRESH.Click
        Dim i As Integer
        conn.Open()
        dset.Clear()
        Try

            sql = "SELECT * FROM Products"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "item_prod")
            DataGridView1.DataSource = dset
            DataGridView1.DataMember = "item_prod"


            sql = "SELECT Prod_ID FROM Products ORDER BY Prod_ID"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Prod")
            cmb1.Items.Clear()
            For i = 0 To dset.Tables("Prod").Rows.Count - 1
                cmb1.Items.Add(dset.Tables("Prod").Rows(i).Item(0))
            Next


            sql = "SELECT ItemCatName FROM ItemCategory"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "itemcat")
            cmb2.Items.Clear()
            For i = 0 To dset.Tables("itemcat").Rows.Count - 1
                cmb2.Items.Add(dset.Tables("itemcat").Rows(i).Item(0))
            Next

            sql = "SELECT BrandName FROM Brand"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Brand")
            cmb3.Items.Clear()
            For i = 0 To dset.Tables("Brand").Rows.Count - 1
                cmb3.Items.Add(dset.Tables("Brand").Rows(i).Item(0))
            Next

        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
        End Try
        conn.Close()
    End Sub

    Private Sub cmdINSERT_Click(sender As Object, e As EventArgs) Handles cmdINSERT.Click
        dset.Clear()
        conn.Open()
        Try
            ProdID = Val(txtProdid.Text)
            ProdDesc = txtProddesc.Text
            CostPrice = Val(txtProdcp.Text)
            Price = Val(txtProdprice.Text)

            ItemCatNAME = (txtItemCat.Text)
            BrandNAME = (txtBrandNAME.Text)

            Dim ans = MessageBox.Show("Do you want To save this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "INSERT INTO Products(Prod_desc,Cost_Price,Sell_Price,BrandName,ItemCatName) VALUES('" & ProdDesc & "', '" & CostPrice & "', '" & Price & "' , '" & BrandNAME & "' ,'" & ItemCatNAME & "')"
                dbcomm = New MySqlCommand(sql, conn)

                Dim i As Integer = dbcomm.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Data Inserted", MsgBoxStyle.Information, "Info")
                Else
                    MsgBox("Input a valid products ID", MsgBoxStyle.Critical, "Info")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
        End Try
        conn.Close()
    End Sub

    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged
        txtProdid.Text = cmb1.Items(cmb1.SelectedIndex)
        conn.Open()

        sql = "SELECT * FROM Products WHERE Prod_ID = '" & cmb1.Text & "'"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            txtProddesc.Text = dbread("Prod_desc")
            txtProdcp.Text = dbread("Cost_Price")
            txtProdprice.Text = dbread("Sell_Price")
            txtBrandNAME.Text = dbread("BrandName")
            txtItemCat.Text = dbread("ItemCatname")
        End While
        conn.Close()
    End Sub

    Private Sub cmb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb2.SelectedIndexChanged
        txtItemCat.Text = cmb2.Items(cmb2.SelectedIndex)
    End Sub

    Private Sub cmdISELECT_Click(sender As Object, e As EventArgs) Handles cmdISELECT.Click
        conn.Open()
        dset.Clear()
        MsgBox("Search Found!", MsgBoxStyle.Information, "Info")
        sql = "SELECT * FROM Products WHERE Prod_ID = '" & cmb1.Text & "'"
        DataAdapter1 = New MySqlDataAdapter(sql, conn)
        DataAdapter1.Fill(dset, "Prod")
        DataGridView1.DataSource = dset
        DataGridView1.DataMember = "Prod"

        conn.Close()
    End Sub
    Private Sub cmdUPDATE_Click(sender As Object, e As EventArgs) Handles cmdUPDATE.Click
        conn.Open()
        dset.Clear()
        Try
            ProdID = Val(txtProdid.Text)
            ProdDesc = txtProddesc.Text
            CostPrice = Val(txtProdcp.Text)
            Price = Val(txtProdprice.Text)

            ItemCatNAME = (txtItemCat.Text)
            BrandNAME = (txtBrandNAME.Text)

            Dim ans = MessageBox.Show("do you want to Update this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "UPDATE Products SET Prod_desc = '" & ProdDesc & "' , Cost_Price = '" & CostPrice & "', Sell_Price = '" & Price & "', BrandName = '" & BrandNAME & "', ItemCatName = '" & ItemCatNAME & "' WHERE Prod_ID = " & Val(ProdID) & ""

                dbcomm = New MySqlCommand(sql, conn)

                Dim i As Integer = dbcomm.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Data is Updated", MsgBoxStyle.Information, "Info")
                Else
                    MsgBox("Input a valid product ID", MsgBoxStyle.Critical, "Info")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
        End Try
        conn.Close()
    End Sub

    Private Sub cmdDELETE_Click(sender As Object, e As EventArgs) Handles cmdDELETE.Click
        conn.Open()
        dset.Clear()
        Try
            ProdID = Val(txtProdid.Text)
            ProdDesc = txtProddesc.Text
            CostPrice = Val(txtProdcp.Text)
            Price = Val(txtProdprice.Text)
            ItemCatNAME = Val(txtItemCat.Text)

            Dim ans = MessageBox.Show("Do you want to Delete this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "DELETE FROM Products WHERE Prod_ID = " & ProdID & ""

                dbcomm = New MySqlCommand(sql, conn)

                Dim i As Integer = dbcomm.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Data is Deleted", MsgBoxStyle.Information, "Info")
                Else
                    MsgBox("Input a valid products ID", MsgBoxStyle.Critical, "Info")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
        End Try
        conn.Close()
    End Sub

    Private Sub cmb3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb3.SelectedIndexChanged
        txtBrandNAME.Text = cmb3.Items(cmb3.SelectedIndex)
    End Sub
End Class