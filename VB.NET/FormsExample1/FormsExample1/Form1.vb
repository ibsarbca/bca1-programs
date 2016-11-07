Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim helloLabel = New Label
        helloLabel.Text = "HELLO WORLD"
        helloLabel.Visible = True
        Controls.Add(helloLabel)

        Dim form2 = New Form
        form2.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show()
    End Sub
End Class
