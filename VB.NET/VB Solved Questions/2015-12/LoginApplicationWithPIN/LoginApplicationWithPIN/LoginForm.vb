Imports System.Data.SqlClient
Imports System.Configuration

Public Class LoginForm

    Shared counter As Integer

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        counter = 0
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        Dim conn = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\dhaval\Documents\logindb.mdf;Integrated Security=True;Connect Timeout=30")

        ' Make it so it doesn't throw an exception when PIN is empty. 
        If PINTextBox.Text = "" Or PINTextBox.Text = Nothing Then
            PINTextBox.Text = 0
        End If

        Dim query = String.Format("SELECT PIN FROM users WHERE username='{0}' and password='{1}' and PIN = {2}", UsernameTextBox.Text, PasswordTextBox.Text, PINTextBox.Text)


        Dim cmd = New SqlCommand(query, conn)
        conn.Open()
        If cmd.ExecuteScalar() < 1 Then
            counter += 1
            MsgBox("Invalid values. Please try again")
            UsernameTextBox.Clear()
            PINTextBox.Clear()
            PasswordTextBox.Clear()

            If counter >= 3 Then
                ' Theoretically the ability to change the password has not been asked. Only that the user must change his password.
                ' This functionality can be implemented easily by cloning the ForgotPassword form and retooling it to change a password.
                ' Therefore, it has been skipped.
                MsgBox("Error. Too many incorrect attempts. Change password")
                Me.Close()
            End If

        Else
            MsgBox("Login Successful")
        End If
        conn.Close()
    End Sub


    Private Sub ForgotPasswordButton_Click(sender As Object, e As EventArgs) Handles ForgotPasswordButton.Click
        Dim frm = New ForgotPasswordForm()
        frm.Show()
    End Sub
End Class
