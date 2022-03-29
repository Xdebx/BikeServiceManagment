Imports MySql.Data.MySqlClient
Public Class BikeServices
    Private Sub BikeServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load, cmdREFRESH.Click
        Dim i As Integer
        conn.Open()
        dset.Clear()
        Try
            sql = "SELECT * FROM Bike_Services"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Bike_services")
            DataGridView1.DataSource = dset
            DataGridView1.DataMember = "Bike_services"

            sql = "SELECT Service_ID FROM Bike_Services"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "serveeee")
            cmb1.Items.Clear()
            For i = 0 To dset.Tables("serveeee").Rows.Count - 1
                cmb1.Items.Add(dset.Tables("serveeee").Rows(i).Item(0))
            Next
        Catch ex As Exception
        End Try
        conn.Close()
    End Sub

    Private Sub cmdINSERT_Click(sender As Object, e As EventArgs) Handles cmdINSERT.Click
        dset.Clear()
        conn.Open()
        Try
            ServiceID = Val(txtServiceId.Text)
            ServiceDesc = txtServicedesc.Text
            CostService = Val(txtServiceCost.Text)

            Dim ans = MessageBox.Show("Do you want To save this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "INSERT INTO Bike_Services(Service_Desc,Cost_Service) VALUES('" & ServiceDesc & "', '" & CostService & "')"
                dbcomm = New MySqlCommand(sql, conn)

                Dim i As Integer = dbcomm.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Data Inserted", MsgBoxStyle.Information, "Info")
                Else
                    MsgBox("Input a valid service ID", MsgBoxStyle.Critical, "Info")
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
        sql = "SELECT * FROM Bike_Services WHERE Service_ID = '" & cmb1.Text & "'"
        DataAdapter1 = New MySqlDataAdapter(sql, conn)
        DataAdapter1.Fill(dset, "Servvv")
        DataGridView1.DataSource = dset
        DataGridView1.DataMember = "Servvv"

        conn.Close()
    End Sub

    Private Sub cmdUPDATE_Click(sender As Object, e As EventArgs) Handles cmdUPDATE.Click
        conn.Open()
        dset.Clear()
        Try
            ServiceID = Val(txtServiceId.Text)
            ServiceDesc = txtServicedesc.Text
            CostService = Val(txtServiceCost.Text)

            Dim ans = MessageBox.Show("Do you want to Update this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "UPDATE Bike_Services SET Service_Desc = '" & ServiceDesc & "' , Cost_Service = '" & CostService & "' WHERE Service_ID = " & Val(ServiceID) & ""

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
            ServiceID = Val(txtServiceId.Text)
            ServiceDesc = txtServicedesc.Text
            CostService = Val(txtServiceCost.Text)

            Dim ans = MessageBox.Show("Do you want to Delete this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "DELETE FROM Bike_Services WHERE Service_ID = " & ServiceID & ""

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

    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged
        txtServiceId.Text = cmb1.Items(cmb1.SelectedIndex)
        conn.Open()
        dset.Clear()
        sql = "SELECT * FROM Bike_Services WHERE Service_ID = '" & cmb1.Text & "'"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            txtServicedesc.Text = dbread("Service_Desc")
            txtServiceCost.Text = dbread("Cost_Service")
        End While
        conn.Close()
    End Sub
End Class