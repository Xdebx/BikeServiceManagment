Imports MySql.Data.MySqlClient
Public Class Brand
    Private Sub Brand_Load(sender As Object, e As EventArgs) Handles MyBase.Load, cmdREFRESH.Click
        Dim i As Integer
        conn.Open()
        dset.Clear()
        Try
            sql = "SELECT * FROM Brand"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Brannnd")
            DataGridView1.DataSource = dset
            DataGridView1.DataMember = "Brannnd"

            sql = "SELECT BrandNAME FROM Brand"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Brand")
            cmb1.Items.Clear()
            For i = 0 To dset.Tables("Brand").Rows.Count - 1
                cmb1.Items.Add(dset.Tables("Brand").Rows(i).Item(0))
            Next
        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
        End Try
        conn.Close()
    End Sub

    Private Sub cmdINSERT_Click(sender As Object, e As EventArgs) Handles cmdINSERT.Click
        conn.Open()
        dset.Clear()
        Try
            BrandNAME = (txtBrandNAME.Text)

            Dim ans = MessageBox.Show("Do you want To save this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "INSERT INTO Brand(BrandNAME) VALUES('" & BrandNAME & "')"
                dbcomm = New MySqlCommand(sql, conn)

                Dim i As Integer = dbcomm.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Data Inserted", MsgBoxStyle.Information, "Info")
                Else
                    MsgBox("Input a valid brand ID", MsgBoxStyle.Critical, "Info")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
        End Try
        conn.Close()
    End Sub
    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged
        txtBrandNAME.Text = cmb1.Items(cmb1.SelectedIndex)
        conn.Open()

        sql = "SELECT * FROM Brand WHERE Brand_ID = '" & cmb1.Text & "'"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            txtBranddesc.Text = dbread("Brand_desc")
        End While
        conn.Close()
    End Sub
    Private Sub cmdUPDATE_Click(sender As Object, e As EventArgs) Handles cmdUPDATE.Click
        conn.Open()
        dset.Clear()
        Try
            BrandNAME = (txtBrandNAME.Text)

            Dim ans = MessageBox.Show("Do you want to Update this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "UPDATE Brand SET BrandName = '" & BrandNAME & "'"

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

    Private Sub cmdISELECT_Click(sender As Object, e As EventArgs) Handles cmdISELECT.Click
        conn.Open()
        dset.Clear()
        MsgBox("Search Found!", MsgBoxStyle.Information, "Info")
        sql = "SELECT * FROM Brand WHERE Brand_ID = '" & cmb1.Text & "'"
        DataAdapter1 = New MySqlDataAdapter(sql, conn)
        DataAdapter1.Fill(dset, "brand")
        DataGridView1.DataSource = dset
        DataGridView1.DataMember = "Brand"
        conn.Close()
    End Sub

    Private Sub cmdDELETE_Click(sender As Object, e As EventArgs) Handles cmdDELETE.Click
        conn.Open()
        dset.Clear()
        Try
            BrandNAME = (txtBrandNAME.Text)

            Dim ans = MessageBox.Show("Do you want to Delete this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "DELETE FROM Brand WHERE BrandName = " & BrandNAME & ""

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
End Class