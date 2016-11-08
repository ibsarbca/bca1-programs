Imports System.Data.SqlClient

Public Class ModifyForm

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim conn = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename='E:\Mumbai\bca1-programs\VB.NET\VB Solved Questions\2014-04\LoginForm\login.mdf';Integrated Security=True;Connect Timeout=30")
        Dim query = String.Format("UPDATE USERS SET password = '{0}' WHERE password = '{1}'", UsernameTextBox.Text, PasswordTextBox.Text)
        Dim cmd = New SqlCommand(query, conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Done")
    End Sub
End Class