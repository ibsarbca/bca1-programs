Imports System.Data.SqlClient

Public Class CashierForm

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        Dim conn = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\dhaval\Documents\bankingdb.mdf;Integrated Security=True;Connect Timeout=30")
        Dim query = String.Format("INSERT INTO accounts(customerName, balance) VALUES('{0}', {1})", CustomerNameTextBox.Text, BalanceTextBox.Text)
        conn.Open()
        Dim cmd = New SqlCommand(query, conn)
        If cmd.ExecuteNonQuery() = 1 Then
            MsgBox("Account added successfully")
        Else
            MsgBox("An error occured")
        End If
        conn.Close()

    End Sub
End Class