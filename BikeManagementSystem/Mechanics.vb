Imports MySql.Data.MySqlClient
Public Class Mechanics
    Private Sub Mechanics_Load(sender As Object, e As EventArgs) Handles MyBase.Load, cmdREFRESH.Click
        Dim i As Integer
        conn.Open()
        dset.Clear()
        Try
            sql = "SELECT * FROM Mechanics"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Mechanics")
            DataGridView1.DataSource = dset
            DataGridView1.DataMember = "Mechanics"

            sql = "SELECT Mechanic_ID FROM Mechanics ORDER BY MEchanic_ID"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Mech")
            cmb1.Items.Clear()
            For i = 0 To dset.Tables("Mech").Rows.Count - 1
                cmb1.Items.Add(dset.Tables("Mech").Rows(i).Item(0))
            Next
            sql = "SELECT Username FROM Userlog"
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            DataAdapter1.Fill(dset, "Userlog")
            cmb2.Items.Clear()
            For i = 0 To dset.Tables("Userlog").Rows.Count - 1
                cmb2.Items.Add(dset.Tables("Userlog").Rows(i).Item(0))
            Next
        Catch ex As Exception
            MsgBox("Error in collecting data at Database. Error is: AWIT")
        End Try
        conn.Close()
    End Sub

    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged
        txtMechid.Text = cmb1.Items(cmb1.SelectedIndex)
        conn.Open()

        sql = "SELECT Mechanic_name, Mechanic_address,Wage,Username FROM Mechanics WHERE Mechanic_ID = '" & cmb1.Text & "'"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            txtMechname.Text = dbread("Mechanic_name")
            txtMechaddress.Text = dbread("Mechanic_address")
            txtWage.Text = dbread("Wage")
            txtUsername.Text = dbread("Username")
        End While
        conn.Close()
    End Sub

    Private Sub cmdINSERT_Click(sender As Object, e As EventArgs) Handles cmdINSERT.Click
        conn.Open()
        dset.Clear()
        Try
            MechID = Val(txtMechid.Text)
            MechNAME = txtMechname.Text
            MechADDR = txtMechaddress.Text
            MECHUSERNAME = txtUsername.Text

            Dim ans = MessageBox.Show("Do you want To save this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "INSERT INTO Mechanics(Mechanic_name,Mechanic_address,Username) VALUES ('" & MechNAME & "','" & MechADDR & "','" & MECHUSERNAME & "')"
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

    Private Sub cmb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb2.SelectedIndexChanged
        txtUsername.Text = cmb2.Items(cmb2.SelectedIndex)
    End Sub

    Private Sub cmdUPDATE_Click(sender As Object, e As EventArgs) Handles cmdUPDATE.Click
        conn.Open()
        dset.Clear()
        Try
            MechID = Val(txtMechid.Text)
            MechNAME = txtMechname.Text
            MechADDR = txtMechaddress.Text
            MECHUSERNAME = txtUsername.Text

            Dim ans = MessageBox.Show("Do you want to Update this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "UPDATE Mechanics SET Mechanic_name = '" & MechNAME & "', Mechanic_address = '" & MechADDR & "'  WHERE Mechanic_ID = " & Val(MechID) & ""

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
            MechID = Val(txtMechid.Text)
            MechNAME = txtMechname.Text
            MechADDR = txtMechaddress.Text
            MECHUSERNAME = txtUsername.Text

            Dim ans = MessageBox.Show("Do you want to Delete this record?", "save record", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = "DELETE FROM Mechanics WHERE Mechanic_ID = " & MechID & ""

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

    Private Sub cmdISELECT_Click(sender As Object, e As EventArgs) Handles cmdISELECT.Click
        conn.Open()
        dset.Clear()
        MsgBox("Search Found!", MsgBoxStyle.Information, "Info")
        sql = "SELECT * FROM Mechanics WHERE Mechanic_ID = '" & cmb1.Text & "'"
        DataAdapter1 = New MySqlDataAdapter(sql, conn)
        DataAdapter1.Fill(dset, "Mech")
        DataGridView1.DataSource = dset
        DataGridView1.DataMember = "Mech"
        conn.Close()
    End Sub
End Class