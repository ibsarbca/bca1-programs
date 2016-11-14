Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Select Case ListBox1.SelectedItem
            Case "Red"
                BackColor = Color.Red
            Case "Blue"
                BackColor = Color.Blue
            Case "Green"
                BackColor = Color.Green
            Case "Yellow"
                BackColor = Color.Yellow
            Case "Purple"
                BackColor = Color.Purple
            Case "Black"
                BackColor = Color.Black
        End Select
    End Sub
End Class
