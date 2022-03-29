Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Public Class Login
#Region "Mydeclared"
    Dim tbl As New DataTable
    Dim NewConnection As New DBConnection
    Dim Da2 As MySqlDataAdapter
#End Region
    Public Function DecryptData(ByVal Converrrrrt As String) As String
        Dim bytes() As Byte
        Dim SB As New StringBuilder()
        If String.IsNullOrEmpty(Converrrrrt) Then
            Throw New ArgumentNullException
        End If
        bytes = Encoding.Default.GetBytes(Converrrrrt)
        bytes = MD5.Create().ComputeHash(bytes)
        For x As Integer = 0 To bytes.Length - 1
            SB.Append(bytes(x).ToString("x2"))
        Next
        Return SB.ToString

    End Function

    Private Sub cmdLOGIN_Click(sender As Object, e As EventArgs) Handles cmdLOGIN.Click
        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
            MessageBox.Show("Please enter credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        conn.Open()
        Dim Hashcode As Login
        Hashcode = New Login()
        'Da2 = New MySqlDataAdapter("SELECT Username, Password, UserType FROM Userlog WHERE Username = '" & txtUsername.Text & "' & Password = '" & Hashcode.DecryptData(txtPassword.Text) & "' & UserType = '" & txtType.Text & "'", NewConnection.Open)
        'tbl.Clear()
        'Da2.Fill(tbl)
        'If tbl.Rows.Count = Nothing Then
        '    MsgBox("Wrong Credentials")
        'Else
        '    MechanicProfile.Show()
        '    Me.Hide()
        '    txtPassword.Clear()
        '    txtUsername.Clear()
        '    txtType.Clear()
        If rbtOwner.Checked = True Then
            Da2 = New MySqlDataAdapter("SELECT Username, Password, UserType FROM Userlog WHERE Username = '" & txtUsername.Text & "' & Password = '" & Hashcode.DecryptData(txtPassword.Text) & "' & UserType = '" & txtType.Text & "'", NewConnection.Open)
            tbl.Clear()
            Da2.Fill(tbl)
            MessageBox.Show("Welcome Owner", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MAINFORM.Show()
            Me.Hide()
            txtPassword.Clear()
            txtUsername.Clear()
            txtType.Clear()
        ElseIf rbtMechanic.Checked = True Then
            Da2 = New MySqlDataAdapter("SELECT Username, Password, UserType FROM Userlog WHERE Username = '" & txtUsername.Text & "' & Password = '" & Hashcode.DecryptData(txtPassword.Text) & "' & UserType = '" & txtType.Text & "'", NewConnection.Open)
            tbl.Clear()
            Da2.Fill(tbl)
            MessageBox.Show("Welcome Mechanics", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MechanicProfile.Show()
            Me.Hide()
            txtPassword.Clear()
            txtUsername.Clear()
            txtType.Clear()
        Else
            MsgBox("Wrong Credentials")
        End If
        conn.Close()
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to close the app", "Exit", MessageBoxButtons.YesNo)

        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub checkB_CheckedChanged(sender As Object, e As EventArgs) Handles checkB.CheckedChanged
        If checkB.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub cmdCREATE_Click(sender As Object, e As EventArgs) Handles cmdCREATE.Click
        Dim Hashcode As Login
        Hashcode = New Login()
        Try
            conn.Open()
            sql = "INSERT INTO Userlog (Username, Password, UserType ) VALUES(' " & txtUsername.Text & "', '" & Hashcode.DecryptData(txtPassword.Text) & "', '" & txtType.Text & "')"
            dbcomm = New MySqlCommand(sql, conn)
            dbcomm.ExecuteNonQuery()
            conn.Close()
            MsgBox("Data Inserted!", MsgBoxStyle.Information, "Notice")
            txtPassword.Clear()
            txtUsername.Clear()
            txtType.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rbtOwner_CheckedChanged(sender As Object, e As EventArgs) Handles rbtOwner.CheckedChanged
        txtType.Text = rbtOwner.Text
    End Sub

    Private Sub rbtMechanic_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMechanic.CheckedChanged
        txtType.Text = rbtMechanic.Text
    End Sub
End Class