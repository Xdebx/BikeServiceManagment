Imports MySql.Data.MySqlClient
Public Class Customer
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load, cmdREFRESH.Click
        Dim i As Integer
        conn.Open()
        dset.Clear()
        Try
            sql = "SELECT * FROM customer"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Cus")
            DataGridView1.DataSource = dset
            DataGridView1.DataMember = "Cus"

            sql = "SELECT Cus_ID FROM customer"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "customer")
            cmb1.Items.Clear()
            For i = 0 To dset.Tables("customer").Rows.Count - 1
                cmb1.Items.Add(dset.Tables("customer").Rows(i).Item(0))
            Next
        Catch ex As Exception
        End Try
        conn.Close()
    End Sub
    Private Sub cmdINSERT_Click(sender As Object, e As EventArgs) Handles cmdINSERT.Click
        conn.Open()
        dset.Clear()
        Try
            CusID = Val(txtCusid.Text)
            CusName = txtCusname.Text
            CusPhone = Val(txtCusphone.Text)
            CusAddr = txtCusaddress.Text

            Dim ans = MessageBox.Show("Do you want To save this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "INSERT into Customer(Cus_name,Cus_phone,Cus_addr) VALUES ('" & CusName & "', '" & CusPhone & "', '" & CusAddr & "')"
                dbcomm = New MySqlCommand(sql, conn)

                Dim i As Integer = dbcomm.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Data Inserted", MsgBoxStyle.Information, "Info")
                Else
                    MsgBox("Input a valid customer ID", MsgBoxStyle.Critical, "Info")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
        End Try
        conn.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged
        txtCusid.Text = cmb1.Items(cmb1.SelectedIndex)
        conn.Open()
        cmb1.Items.Clear()
        sql = "SELECT * FROM customer WHERE Cus_ID = '" & cmb1.Text & "'"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            txtCusname.Text = dbread("Cus_name")
            txtCusphone.Text = dbread("Cus_phone")
            txtCusaddress.Text = dbread("Cus_addr")
        End While
        conn.Close()
    End Sub

    Private Sub cmdISELECT_Click(sender As Object, e As EventArgs) Handles cmdISELECT.Click
        conn.Open()
        dset.Clear()
        MsgBox("Search Found!", MsgBoxStyle.Information, "Info")
        sql = "SELECT * FROM customer WHERE Cus_ID = '" & cmb1.Text & "'"
        DataAdapter1 = New MySqlDataAdapter(sql, conn)
        DataAdapter1.Fill(dset, "Cus")
        DataGridView1.DataSource = dset
        DataGridView1.DataMember = "Cus"


        conn.Close()
    End Sub

    Private Sub cmdUPDATE_Click(sender As Object, e As EventArgs) Handles cmdUPDATE.Click
        conn.Open()
        dset.Clear()
        Try
            CusID = Val(txtCusid.Text)
            CusName = txtCusname.Text
            CusPhone = Val(txtCusphone.Text)
            CusAddr = txtCusaddress.Text

            Dim ans = MessageBox.Show("do you want to Update this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "UPDATE customer SET Cus_name = '" & CusName & "' , Cus_phone = '" & CusPhone & "', Cus_addr = '" & CusAddr & "' WHERE Cus_ID = " & Val(CusID) & ""

                dbcomm = New MySqlCommand(sql, conn)

                Dim i As Integer = dbcomm.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Data is Updated", MsgBoxStyle.Information, "Info")
                Else
                    MsgBox("Input a valid customer ID", MsgBoxStyle.Critical, "Info")
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
            CusID = Val(txtCusid.Text)
            CusName = txtCusname.Text
            CusPhone = Val(txtCusphone.Text)
            CusAddr = txtCusaddress.Text

            Dim ans = MessageBox.Show("Do you want to Delete this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "DELETE FROM customer WHERE Cus_ID = " & CusID & ""

                dbcomm = New MySqlCommand(sql, conn)

                Dim i As Integer = dbcomm.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Data is Deleted", MsgBoxStyle.Information, "Info")
                Else
                    MsgBox("Input a valid customer ID", MsgBoxStyle.Critical, "Info")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
        End Try
        conn.Close()
    End Sub
End Class