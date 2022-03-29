Imports MySql.Data.MySqlClient
Public Class OperatingExpenses
    Private Sub OperatingExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load, cmdREFRESH.Click
        Dim i As Integer
        conn.Open()
        dset.Clear()
        Try
            sql = "SELECT * FROM Operating_expenses"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Operating_expenses")
            DataGridView1.DataSource = dset
            DataGridView1.DataMember = "Operating_expenses"

            sql = "SELECT OE_ID FROM Operating_expenses"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Operating")
            cmb1.Items.Clear()
            For i = 0 To dset.Tables("Operating").Rows.Count - 1
                cmb1.Items.Add(dset.Tables("Operating").Rows(i).Item(0))
            Next

            sql = "SELECT Owner_ID FROM Owner"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Own")
            cmb2.Items.Clear()
            For i = 0 To dset.Tables("Own").Rows.Count - 1
                cmb2.Items.Add(dset.Tables("Own").Rows(i).Item(0))
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
            OEID = Val(txtOEId.Text)
            OENAME = txtOEdesc.Text
            OEPRICE = Val(txtOEPrice.Text)
            OwnerID = Val(txtOwnerID.Text)
            Dim ans = MessageBox.Show("Do you want To save this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "INSERT INTO Operating_expenses(OE_desc, Price, Owner_ID) VALUES ('" & OENAME & "','" & OEPRICE & "','" & OwnerID & "')"
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

    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged
        txtOEId.Text = cmb1.Items(cmb1.SelectedIndex)
        conn.Open()
        sql = "SELECT * FROM Operating_expenses WHERE OE_ID = '" & cmb1.Text & "'"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            txtOEdesc.Text = dbread("OE_desc")
            txtOEPrice.Text = dbread("Price")
        End While
        conn.Close()
    End Sub

    Private Sub cmdISELECT_Click(sender As Object, e As EventArgs) Handles cmdISELECT.Click
        conn.Open()
        dset.Clear()
        MsgBox("Search Found!", MsgBoxStyle.Information, "Info")
        sql = "SELECT * FROM Operating_expenses WHERE OE_ID = '" & cmb1.Text & "'"
        DataAdapter1 = New MySqlDataAdapter(sql, conn)
        DataAdapter1.Fill(dset, "OE")
        DataGridView1.DataSource = dset
        DataGridView1.DataMember = "OE"
        conn.Close()
    End Sub

    Private Sub cmdUPDATE_Click(sender As Object, e As EventArgs) Handles cmdUPDATE.Click
        conn.Open()
        dset.Clear()
        Try
            OEID = Val(txtOEId.Text)
            OENAME = txtOEdesc.Text
            OEPRICE = Val(txtOEPrice.Text)

            Dim ans = MessageBox.Show("Do you want to Update this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "UPDATE Operating_expenses  SET OE_desc = '" & OENAME & "', Price = '" & OEPRICE & "' WHERE OE_ID = " & OEID & ""

                dbcomm = New MySqlCommand(sql, conn)

                Dim i As Integer = dbcomm.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Data is Updated", MsgBoxStyle.Information, "Info")
                Else
                    MsgBox("Input a valid brand ID", MsgBoxStyle.Critical, "Info")
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
            OEID = Val(txtOEId.Text)
            OENAME = txtOEdesc.Text
            OEPRICE = Val(txtOEPrice.Text)

            Dim ans = MessageBox.Show("Do you want to Delete this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "DELETE FROM Operating_expenses WHERE OE_ID = " & OEID & ""

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

    Private Sub cmb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb2.SelectedIndexChanged
        txtOwnerID.Text = cmb2.Items(cmb2.SelectedIndex)
    End Sub
End Class