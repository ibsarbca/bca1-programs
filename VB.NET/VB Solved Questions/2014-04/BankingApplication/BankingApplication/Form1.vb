Public Class Form1
    Public Shared userType As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CashierButton_Click(sender As Object, e As EventArgs) Handles CashierButton.Click
        userType = "Cashier"
        Dim frm = New LoginForm()
        frm.Show()
    End Sub

    Private Sub ManagerButton_Click(sender As Object, e As EventArgs) Handles ManagerButton.Click
        userType = "Manager"
        Dim frm = New LoginForm()
        frm.Show()
    End Sub
End Class
