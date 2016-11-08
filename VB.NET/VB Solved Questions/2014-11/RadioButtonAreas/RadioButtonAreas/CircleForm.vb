Public Class CircleForm

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        Dim area = Convert.ToSingle(RadiusTextBox.Text)
        area = 3.14 * area * area
        Result.Label1.Text = area
        Result.Show()
    End Sub
End Class