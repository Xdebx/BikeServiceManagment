Imports MySql.Data.MySqlClient
Public Class Supplier
    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load, cmdREFRESH.Click
        Dim i As Integer
        conn.Open()
        dset.Clear()
        Try
            sql = "SELECT * FROM Supplier"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Sup")
            DataGridView1.DataSource = dset
            DataGridView1.DataMember = "Sup"

            sql = "SELECT Sup_ID FROM Supplier"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Supplier")
            cmb1.Items.Clear()
            For i = 0 To dset.Tables("Supplier").Rows.Count - 1
                cmb1.Items.Add(dset.Tables("Supplier").Rows(i).Item(0))
            Next
        Catch ex As Exception
        End Try
        conn.Close()
    End Sub

    Private Sub cmdINSERT_Click(sender As Object, e As EventArgs) Handles cmdINSERT.Click
        conn.Open()
        dset.Clear()
        Try
            SupID = Val(txtSupid.Text)
            SupName = txtSupname.Text
            SupPhone = Val(txtSupphone.Text)
            SupAddress = txtSupaddress.Text

            Dim ans = MessageBox.Show("Do you want To save this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "INSERT INTO Supplier(Sup_name,Sup_addr,Sup_phone) VALUES('" & SupName & "', '" & SupAddress & "', '" & SupPhone & "')"
                dbcomm = New MySqlCommand(sql, conn)

                Dim i As Integer = dbcomm.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Data Inserted", MsgBoxStyle.Information, "Info")
                Else
                    MsgBox("Input a valid customer ID", MsgBoxStyle.Critical, "Info")
                End If
            End If
        Catch ex As Exception
        End Try
        conn.Close()
    End Sub

    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged
        txtSupid.Text = cmb1.Items(cmb1.SelectedIndex)
        conn.Open()
        sql = "SELECT * FROM Supplier WHERE Sup_ID = '" & cmb1.Text & "'"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            txtSupname.Text = dbread("Sup_name")
            txtSupphone.Text = dbread("Sup_phone")
            txtSupaddress.Text = dbread("Sup_addr")
        End While
        conn.Close()
    End Sub

    Private Sub cmdUPDATE_Click(sender As Object, e As EventArgs) Handles cmdUPDATE.Click
        conn.Open()
        dset.Clear()
        Try
            SupID = Val(txtSupid.Text)
            SupName = txtSupname.Text
            SupPhone = Val(txtSupphone.Text)
            SupAddress = txtSupaddress.Text

            Dim ans = MessageBox.Show("do you want to Update this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "UPDATE Supplier SET Sup_name = '" & SupName & "' , Sup_addr = '" & SupAddress & "', Sup_phone = '" & SupPhone & "' WHERE Sup_ID = " & Val(SupID) & ""

                dbcomm = New MySqlCommand(sql, conn)

                Dim i As Integer = dbcomm.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Data is Updated", MsgBoxStyle.Information, "Info")
                Else
                    MsgBox("Input a valid supplier ID", MsgBoxStyle.Critical, "Info")

                End If
            End If
        Catch ex As Exception
        End Try
        conn.Close()
    End Sub

    Private Sub cmdISELECT_Click(sender As Object, e As EventArgs) Handles cmdISELECT.Click
        conn.Open()
        dset.Clear()
        MsgBox("Search Found!", MsgBoxStyle.Information, "Info")
        sql = "SELECT * FROM Supplier WHERE Sup_ID = '" & cmb1.Text & "'"
        DataAdapter1 = New MySqlDataAdapter(sql, conn)
        DataAdapter1.Fill(dset, "Sup")
        DataGridView1.DataSource = dset
        DataGridView1.DataMember = "Sup"

        conn.Close()
    End Sub

    Private Sub cmdDELETE_Click(sender As Object, e As EventArgs) Handles cmdDELETE.Click
        conn.Open()
        dset.Clear()
        Try
            SupID = Val(txtSupid.Text)
            SupName = txtSupname.Text
            SupPhone = Val(txtSupphone.Text)
            SupAddress = txtSupaddress.Text

            Dim ans = MessageBox.Show("Do you want to Delete this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "DELETE FROM Supplier WHERE Sup_ID = " & SupID & ""

                dbcomm = New MySqlCommand(sql, conn)

                Dim i As Integer = dbcomm.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Data is Deleted", MsgBoxStyle.Information, "Info")
                Else
                    MsgBox("Input a valid supplier ID", MsgBoxStyle.Critical, "Info")
                End If
            End If
        Catch ex As Exception
        End Try
        conn.Close()
    End Sub
End Class