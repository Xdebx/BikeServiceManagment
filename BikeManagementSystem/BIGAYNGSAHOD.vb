Imports MySql.Data.MySqlClient
Public Class BIGAYNGSAHOD
    Private Sub BIGAYNGSAHOD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        conn.Open()
        dset.Clear()
        Try

            sql = "SELECT Service_ID FROM Bike_Services"
        DataAdapter1 = New MySqlDataAdapter(sql, conn)
        DataAdapter1.Fill(dset, "Bike_Services")
        cmb1.Items.Clear()
            For i = 0 To dset.Tables("Bike_Services").Rows.Count - 1
                cmb1.Items.Add(dset.Tables("Bike_Services").Rows(i).Item(0))
            Next

            sql = "SELECT Mechanic_ID FROM Mechanics ORDER BY Mechanic_ID"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Mechanics")
            cmb2.Items.Clear()
            For i = 0 To dset.Tables("Mechanics").Rows.Count - 1
                cmb2.Items.Add(dset.Tables("Mechanics").Rows(i).Item(0))
            Next

        Catch ex As Exception
        End Try
        conn.Close()
    End Sub

    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged
        txtServID.Text = cmb1.Items(cmb1.SelectedIndex)
        conn.Open()

        sql = "SELECT * FROM Bike_Services WHERE Service_ID = '" & cmb1.Text & "'"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            txtServDesc.Text = dbread("Service_desc")
            txtCostService.Text = dbread("Cost_Service")
        End While
        conn.Close()
    End Sub

    Private Sub cmb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb2.SelectedIndexChanged
        txtMechID.Text = cmb2.Items(cmb2.SelectedIndex)
        conn.Open()

        sql = "SELECT Mechanic_name,Mechanic_address,Wage FROM Mechanics WHERE Mechanic_ID = '" & cmb2.Text & "'"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            txtMechname.Text = dbread("Mechanic_name")
            txtMechAddr.Text = dbread("Mechanic_address")
            txtSalary.Text = dbread("Wage")
        End While
        conn.Close()
    End Sub

    Private Sub cmdCompute_Click(sender As Object, e As EventArgs) Handles cmdCompute.Click
        Dim Percent As Decimal
        Percent = txtPercentage.Text
        txtAmounTransfer.Text = txtCostService.Text * Percent
    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click
        conn.Open()
        dset.Clear()

        sql = "UPDATE Mechanics SET Wage = Wage + " & txtAmounTransfer.Text & " WHERE Mechanic_ID = " & txtMechID.Text & ""
        dbcomm = New MySqlCommand(sql, conn)
        dbcomm.ExecuteNonQuery()

        MsgBox("Done Transfering Money")
        conn.Close()
    End Sub
End Class