Public Class NewPasswordDialog

    Public Shared newPassword As String

    Private Sub NewPasswordDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        newPassword = NewPasswordTextBox.Text
        Return
    End Sub
End Class