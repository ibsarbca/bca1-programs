Public Class MainForm

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedItem = ListBox1.SelectedItem.ToString()
        ListBox2.Items.Add(selectedItem)
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedItem = ListBox2.SelectedItem.ToString()
        ListBox1.Items.Add(selectedItem)
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub
End Class
