Public Class CubeForm

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        Dim area = Convert.ToSingle(LengthTextBox.Text)
        area = area * area * area
        Result.Label1.Text = area
        Result.Show()
    End Sub
End Class