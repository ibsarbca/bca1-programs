Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class ForgotPassword

    Private Sub ShowPasswordButton_Click(sender As Object, e As EventArgs) Handles NewPasswordButton.Click

        NewPasswordDialog.ShowDialog()


        Dim conn = New SqlConnection("Data Source=DEFIANT\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True")
        conn.Open()

        Dim query = String.Format("SELECT control_number FROM users WHERE control_number = {0} and username = '{1}'", ControlNumberTextBox.Text, UsernameTextBox.Text)
        Dim command = New SqlCommand(query, conn)
        Dim controlNumberFromDB = command.ExecuteScalar()
        conn.Close()

        If ControlNumberTextBox.Text = controlNumberFromDB.ToString() Then
            MsgBox("New Password: " & NewPasswordDialog.newPassword)
            query = String.Format("UPDATE users SET password='{0}' WHERE username = '{1}'", NewPasswordDialog.newPassword, UsernameTextBox.Text)
            command = New SqlCommand(query, conn)

            conn.Open()
            command.ExecuteNonQuery()
            conn.Close()
        End If



    End Sub
End Class