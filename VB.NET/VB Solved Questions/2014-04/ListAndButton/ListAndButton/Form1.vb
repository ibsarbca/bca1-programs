Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        SelectedItemButton.Text = ListBox1.SelectedItem
    End Sub
End Class
