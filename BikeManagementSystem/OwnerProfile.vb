Public Class OwnerProfile
    Private Sub OwnerProfile_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to close the app", "Exit", MessageBoxButtons.YesNo)

        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Login.Show()
        End If
    End Sub
End Class