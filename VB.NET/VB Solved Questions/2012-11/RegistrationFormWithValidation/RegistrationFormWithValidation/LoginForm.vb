Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Configuration

Public Class LoginForm

    Private Sub ForgotPasswordButton_Click(sender As Object, e As EventArgs) Handles ForgotPasswordButton.Click
        Dim frm As ForgotPassword = New ForgotPassword()
        frm.Show()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim conn = New SqlConnection("Data Source=DEFIANT\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True")
        Dim query = String.Format("SELECT username FROM users WHERE username='{0}' and password='{1}'", UsernameTextBox.Text, PasswordTextBox.Text)
        Dim cmd = New SqlCommand(query, conn)

        conn.Open()
        Dim username = cmd.ExecuteScalar()
        If username Is Nothing Or username = "" Then
            MsgBox("Login Failed")
        Else
            MsgBox("Login Successful")
        End If
        conn.Close()
    End Sub

    Private Sub NewUserButton_Click(sender As Object, e As EventArgs) Handles NewUserButton.Click
        Dim frm = New NewUserForm()
        frm.Show()
    End Sub
End Class