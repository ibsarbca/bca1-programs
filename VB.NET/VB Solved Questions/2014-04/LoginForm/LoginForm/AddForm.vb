Imports System.Data
Imports System.Data.SqlClient

Public Class AddForm

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim conn = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename='E:\Mumbai\bca1-programs\VB.NET\VB Solved Questions\2014-04\LoginForm\login.mdf';Integrated Security=True;Connect Timeout=30")
        conn.Open()
        Dim query = String.Format("INSERT INTO users VALUES('{0}', '{1}')", UsernameTextBox.Text, PasswordTextBox.Text)
        Dim cmd = New SqlCommand(query, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Done")
    End Sub
End Class