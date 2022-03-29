Imports MySql.Data.MySqlClient
Public Class MechanicProfile
    Private Sub MechanicProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        conn.Close()
        conn.Open()
        dset.Clear()
        Try

            sql = "SELECT BST.MechService_ID,BST.Date_Start,BST.Date_Finish,S.Service_ID,S.Service_desc,S.Cost_Service,M.Mechanic_ID,M.Mechanic_name,M.Mechanic_address,M.Wage FROM BikeService_Trans BST INNER JOIN Bike_Services S ON (BST.Service_ID = S.Service_ID) INNER JOIN Mechanics M ON (BST.Mechanic_ID = M.Mechanic_ID )"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "BikeService_Trans_Mechanics_Customer_Services")
            Dgrid1.DataSource = dset
            Dgrid1.DataMember = "BikeService_Trans_Mechanics_Customer_Services"
            'sql = "SELECT * FROM Mechanics"
            'DataAdapter1 = New MySqlDataAdapter(sql, conn)
            'DataAdapter1.Fill(dset, "4 tables")
            'Dgrid1.DataSource = dset
            'Dgrid1.DataMember = "4 tables"

            sql = "SELECT MechService_ID FROM BikeService_Trans"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Mechanics")
            cmb1.Items.Clear()
            For i = 0 To dset.Tables("Mechanics").Rows.Count - 1
                cmb1.Items.Add(dset.Tables("Mechanics").Rows(i).Item(0))
            Next

            'sql = "SELECT Mechanic_ID,Mechanic_name, Mechanic_address, Username,Wage FROM Mechanics WHERE Username = '" & Login.txtUsername.Text & "'"
            'dbcomm = New MySqlCommand(sql, conn)
            'dbread = dbcomm.ExecuteReader()

            'dbread.Read()
            'txtMechIDD.Text = dbread("Mechanic_ID")
            'txtMechNAME.Text = dbread("Mechanic_name")
            'txtMechADDR.Text = dbread("Mechanic_address")
            'txtSalary.Text = dbread("Wage")
            'txtUsername.Text = dbread("Username")

        Catch ex As Exception
        End Try
        conn.Close()
    End Sub

    Private Sub MechanicProfile_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to close the app", "Exit", MessageBoxButtons.YesNo)

        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Login.Show()
        End If
    End Sub

    Private Sub cmSearch_Click(sender As Object, e As EventArgs) Handles cmSearch.Click
        conn.Open()
        dset.Clear()
        MsgBox("Search Found!", MsgBoxStyle.Information, "Info")
        sql = "SELECT BST.MechService_ID,BST.Date_Start,BST.Date_Finish,S.Service_ID,S.Service_desc,S.Cost_Service,M.Mechanic_ID,M.Mechanic_name,M.Mechanic_address,M.Wage FROM BikeService_Trans BST INNER JOIN Bike_Services S ON (BST.Service_ID = S.Service_ID) INNER JOIN Mechanics M ON (BST.Mechanic_ID = M.Mechanic_ID ) WHERE MechService_ID = '" & cmb1.Text & "'"
        DataAdapter1 = New MySqlDataAdapter(sql, conn)
        DataAdapter1.Fill(dset, "BikeService_Trans_Mechanics_Customer_Services")
        Dgrid1.DataSource = dset
        Dgrid1.DataMember = "BikeService_Trans_Mechanics_Customer_Services"
        conn.Close()
    End Sub

    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged
        txtMechIDD.Text = cmb1.Items(cmb1.SelectedIndex)
    End Sub
End Class