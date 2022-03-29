Imports MySql.Data.MySqlClient
Public Class Accessories
    Private Sub Accessories_Load(sender As Object, e As EventArgs) Handles MyBase.Load, cmdREFRESH.Click
        Dim i As Integer
        conn.Open()
        dset.Clear()
        Try
            sql = "SELECT * FROM Accessories"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Accessories")
            DataGridView1.DataSource = dset
            DataGridView1.DataMember = "Accessories"

            sql = "SELECT ID_Accessories FROM Accessories"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Accesss")
            cmb1.Items.Clear()
            For i = 0 To dset.Tables("Accesss").Rows.Count - 1
                cmb1.Items.Add(dset.Tables("Accesss").Rows(i).Item(0))
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
            AccessID = Val(txtAccessId.Text)
            AccessDesc = txtAccessdesc.Text
            AccessCP = Val(txtAccesscp.Text)
            AccessPrice = Val(txtAccessprice.Text)
            ItemCatNAME = (txtItemCat.Text)
            AccessBrand = txtAccessBrand.Text

            Dim ans = MessageBox.Show("Do you want To save this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "INSERT INTO Accessories(Access_desc,Cost_Price,Sell_Price,ItemCatName,BrandName) VALUES ('" & AccessDesc & "', '" & AccessCP & "', '" & AccessPrice & "' ,'" & ItemCatNAME & "','" & AccessBrand & "')"
                dbcomm = New MySqlCommand(sql, conn)

                Dim i As Integer = dbcomm.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Data Inserted", MsgBoxStyle.Information, "Info")
                Else
                    MsgBox("Input a valid service ID", MsgBoxStyle.Critical, "Info")
                End If
            End If

        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
        End Try
        conn.Close()
    End Sub
    Private Sub cmdISELECT_Click(sender As Object, e As EventArgs) Handles cmdISELECT.Click
        conn.Open()
        dset.Clear()
        MsgBox("Search Found!", MsgBoxStyle.Information, "Info")
        sql = "SELECT * FROM Accessories WHERE ID_Accessories = '" & cmb1.Text & "'"
        DataAdapter1 = New MySqlDataAdapter(sql, conn)
        DataAdapter1.Fill(dset, "Accessoriessss")
        DataGridView1.DataSource = dset
        DataGridView1.DataMember = "Accessoriessss"
        conn.Close()
    End Sub

    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged
        txtAccessId.Text = cmb1.Items(cmb1.SelectedIndex)
        conn.Open()
        dset.Clear()
        sql = "SELECT * FROM Accessories WHERE ID_Accessories = '" & cmb1.Text & "'"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            txtAccessdesc.Text = dbread("Access_desc")
            txtAccesscp.Text = dbread("Cost_Price")
            txtAccessprice.Text = dbread("Sell_Price")
            txtItemCat.Text = dbread("ItemCatName")
        End While
        conn.Close()
    End Sub

    Private Sub cmb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb2.SelectedIndexChanged
        txtItemCat.Text = cmb2.Items(cmb2.SelectedIndex)
    End Sub

    Private Sub cmdUPDATE_Click(sender As Object, e As EventArgs) Handles cmdUPDATE.Click
        conn.Open()
        dset.Clear()
        Try
            AccessID = Val(txtAccessId.Text)
            AccessDesc = txtAccessdesc.Text
            AccessCP = Val(txtAccesscp.Text)
            AccessPrice = Val(txtAccessprice.Text)
            ItemCatNAME = (txtItemCat.Text)

            Dim ans = MessageBox.Show("Do you want to Update this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "UPDATE Accessories SET Access_Desc = '" & AccessDesc & "' , Cost_Price = '" & AccessCP & "', Sell_Price = '" & AccessPrice & "', ItemCatName = '" & ItemCatNAME & "' WHERE ID_Accessories = " & Val(txtAccessId.Text) & ""

                dbcomm = New MySqlCommand(sql, conn)

                Dim i As Integer = dbcomm.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Data is Updated", MsgBoxStyle.Information, "Info")
                Else
                    MsgBox("Input a valid service ID", MsgBoxStyle.Critical, "Info")
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
            AccessID = Val(txtAccessId.Text)
            AccessDesc = txtAccessdesc.Text
            AccessCP = Val(txtAccesscp.Text)
            AccessPrice = Val(txtAccessprice.Text)
            ItemCatNAME = (txtItemCat.Text)

            Dim ans = MessageBox.Show("Do you want to Delete this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "DELETE FROM Accessories WHERE ID_Accessories = " & AccessID & ""

                dbcomm = New MySqlCommand(sql, conn)

                Dim i As Integer = dbcomm.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Data is Deleted", MsgBoxStyle.Information, "Info")
                Else
                    MsgBox("Input a valid service ID", MsgBoxStyle.Critical, "Info")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
        End Try
        conn.Close()
    End Sub

    Private Sub cmb3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb3.SelectedIndexChanged
        txtAccessBrand.Text = cmb3.Items(cmb3.SelectedIndex)
    End Sub
End Class