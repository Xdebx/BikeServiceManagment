Imports MySql.Data.MySqlClient
Public Class CustomerBikeTransaction
    Dim table As New DataTable
    Private Sub CustomerBikeTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load, cmdRefresh.Click
        Dim i As Integer
        conn.Open()
        dset.Clear()
        Try
            sql = "SELECT BST.MechService_ID,BST.Date_Start,BST.Date_Finish,S.Service_ID,S.Service_desc,S.Cost_Service,M.Mechanic_ID,M.Mechanic_name,M.Mechanic_address,C.Cus_ID,C.Cus_name,C.Cus_phone,C.Cus_addr FROM BikeService_Trans BST INNER JOIN Bike_Services S ON (BST.Service_ID = S.Service_ID) INNER JOIN Mechanics M ON (BST.Mechanic_ID = M.Mechanic_ID ) INNER JOIN Customer C ON (BST.Cus_ID = C.Cus_ID ) "
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "BikeService_Trans_Mechanics_Customer_Services")
            Dgrid2.DataSource = dset
            Dgrid2.DataMember = "BikeService_Trans_Mechanics_Customer_Services"

            sql = "SELECT Service_ID FROM Bike_Services"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Bike_Services")
            cmb1.Items.Clear()
            For i = 0 To dset.Tables("Bike_Services").Rows.Count - 1
                cmb1.Items.Add(dset.Tables("Bike_Services").Rows(i).Item(0))
            Next

            sql = "SELECT Cus_ID FROM Customer"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Customer")
            cmb2.Items.Clear()
            For i = 0 To dset.Tables("Customer").Rows.Count - 1
                cmb2.Items.Add(dset.Tables("Customer").Rows(i).Item(0))
            Next

            sql = "SELECT Mechanic_ID FROM Mechanics"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Mechanics")
            cmb3.Items.Clear()
            For i = 0 To dset.Tables("Mechanics").Rows.Count - 1
                cmb3.Items.Add(dset.Tables("Mechanics").Rows(i).Item(0))
            Next

        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
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
        txtCustID.Text = cmb2.Items(cmb2.SelectedIndex)
        conn.Open()

        sql = "SELECT * FROM Customer WHERE Cus_ID = '" & cmb2.Text & "'"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            txtCusname.Text = dbread("Cus_name")
            txtCustnumber.Text = dbread("Cus_phone")
            txtCusAddr.Text = dbread("Cus_addr")
        End While
        conn.Close()
    End Sub

    Private Sub cmb3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb3.SelectedIndexChanged
        txtMechID.Text = cmb3.Items(cmb3.SelectedIndex)
        conn.Open()

        sql = "SELECT * FROM Mechanics WHERE Mechanic_ID = '" & cmb3.Text & "'"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            txtMechname.Text = dbread("Mechanic_name")
            txtMechAddr.Text = dbread("Mechanic_address")
        End While
        conn.Close()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dgrid1.Rows.Add(txtOD.Text, txtOS.Text, txtServID.Text, txtServDesc.Text, txtCostService.Text, txtCustID.Text, txtCusname.Text, txtCustnumber.Text, txtCusAddr.Text, txtMechID.Text, txtMechname.Text, txtMechAddr.Text)
        Dim TOTAL As Double
        For r As Integer = 0 To Dgrid1.RowCount - 1

            TOTAL += Dgrid1.Rows(r).Cells(4).Value
        Next
        Label4.Text = TOTAL.ToString("C2")
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Dim index As Integer
        index = Dgrid1.CurrentCell.RowIndex
        Dgrid1.Rows.RemoveAt(index)

        txtMechAddr.Clear()
        txtCostService.Clear()
        txtCusAddr.Clear()
        txtCusname.Clear()
        txtCustID.Clear()
        txtCustnumber.Clear()
        txtMechID.Clear()
        txtMechname.Clear()
        txtOD.Clear()
        txtOS.Clear()
        txtServDesc.Clear()
        txtServID.Clear()
    End Sub

    Private Sub cmdFinisOrder_Click(sender As Object, e As EventArgs) Handles cmdFinisOrder.Click
        conn.Open()
        dset.Clear()
        Try
            'Insert

            DateORDER = txtOD.Text
            DateSHIPPED = txtOS.Text
            CusID = Val(txtCustID.Text)
            ServiceID = Val(txtServID.Text)
            MechID = Val(txtMechID.Text)

            For Each row As DataGridViewRow In Dgrid1.Rows
                sql = "INSERT INTO BikeService_Trans(Date_Start,Date_Finish,Service_ID,Mechanic_ID,Cus_ID) VALUES ('" & row.Cells(0).Value & "', '" & row.Cells(1).Value & "', '" & row.Cells(2).Value & "','" & row.Cells(9).Value & "', '" & row.Cells(5).Value & "')"
                dbcomm = New MySqlCommand(sql, conn)
                dbcomm.ExecuteNonQuery()
            Next

            Dim output As DialogResult = MessageBox.Show("Do you want to Add Another Puchase", "Add another Item?", MessageBoxButtons.YesNo)
            If output = DialogResult.No Then
            ElseIf output = DialogResult.Yes Then
                cmb2.Focus()
            End If
            MsgBox("Data Inserted", MsgBoxStyle.Information, "Info")
        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
        End Try

        Dim Dtable As New DataTable
        With Dtable
            .Columns.Add("Date_Start")
            .Columns.Add("Date_Finish")
            .Columns.Add("Service_ID")
            .Columns.Add("Service Description")
            .Columns.Add("Service Cost")
            .Columns.Add("Customer ID")
            .Columns.Add("Customer Name")
            .Columns.Add("Mehanic_ID")
            .Columns.Add("Mechanic Name")
        End With
        For Each row As DataGridViewRow In Me.Dgrid1.Rows
            Dtable.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(9).Value, row.Cells(10).Value)
        Next
        Dim reportdocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportdocument = New CrystalReport1
        reportdocument.SetDataSource(Dtable)
        reportdocument.SetParameterValue(0, Label4.Text)
        Form1.CrystalReportViewer1.ReportSource = reportdocument
        Form1.ShowDialog()
        Form1.Dispose()
        conn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        table.Clear()
        Try

            sql = "SELECT BST.MechService_ID,BST.Date_Start,BST.Date_Finish,S.Service_ID,S.Service_desc,S.Cost_Service,M.Mechanic_ID,M.Mechanic_name,M.Mechanic_address,C.Cus_ID,C.Cus_name,C.Cus_phone,C.Cus_addr FROM BikeService_Trans BST INNER JOIN Bike_Services S ON (BST.Service_ID = S.Service_ID) INNER JOIN Mechanics M ON (BST.Mechanic_ID = M.Mechanic_ID ) INNER JOIN Customer C ON (BST.Cus_ID = C.Cus_ID) WHERE MechService_ID = " & Val(txtSearch.Text) & ""
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