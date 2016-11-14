Imports COMDLL

Public Class Form1

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        ResultTextBox.Text = SomeCOMClass.Add(Convert.ToInt32(FirstNumberTextBox.Text), Convert.ToInt32(SecondNumberTextBox.Text))

    End Sub
End Class
