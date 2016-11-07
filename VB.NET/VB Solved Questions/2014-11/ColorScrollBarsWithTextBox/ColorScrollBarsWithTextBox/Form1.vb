Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TrackBarGreen_Scroll(sender As Object, e As EventArgs) Handles TrackBarGreen.Scroll
        ChangeText(TrackBarRed.Value, TrackBarGreen.Value, TrackBarBlue.Value)
    End Sub

    Private Sub TrackBarBlue_Scroll(sender As Object, e As EventArgs) Handles TrackBarBlue.Scroll
        ChangeText(TrackBarRed.Value, TrackBarGreen.Value, TrackBarBlue.Value)
    End Sub

    Private Sub TrackBarRed_Scroll(sender As Object, e As EventArgs) Handles TrackBarRed.Scroll
        ChangeText(TrackBarRed.Value, TrackBarGreen.Value, TrackBarBlue.Value)
    End Sub

    Sub ChangeText(ByVal red As Integer, ByVal green As Integer, ByVal blue As Integer)
        TextBox1.BackColor = System.Drawing.Color.FromArgb(red, green, blue)
        TextBox1.Text = red & "," & blue & "," & green
    End Sub
End Class
