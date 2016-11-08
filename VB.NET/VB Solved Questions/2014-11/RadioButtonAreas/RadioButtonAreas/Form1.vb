Public Class Form1

    Private Sub SquareRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SquareRadioButton.CheckedChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        If SquareRadioButton.Checked Then
            SquareForm.ShowDialog()
        ElseIf CircleRadioButton.Checked Then
            CircleForm.ShowDialog()
        ElseIf CubeRadioButton.Checked Then
            CubeForm.ShowDialog()
        End If

    End Sub
End Class
