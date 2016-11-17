Imports System.Data.SqlClient

Public Class LoginForm



    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim conn = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\dhaval\Documents\bankingdb.mdf;Integrated Security=True;Connect Timeout=30")

        Dim query = String.Format("SELECT * FROM users WHERE username='{0}' and password='{1}'", UsernameTextBox.Text, PasswordTextBox.Text)
        Dim cmd = New SqlCommand(query, conn)

        conn.Open()
        Dim result = cmd.ExecuteScalar() ' Makes sure only one columnis returned
        If Not result Is Nothing Then
            Dim frm
            If Form1.userType = "Manager" Then
                frm = New ManagerForm()
                frm.Show()
            End If
            If Form1.userType = "Cashier" Then
                frm = New CashierForm()
                frm.Show()
            End If


        End If
    End Sub
End Class