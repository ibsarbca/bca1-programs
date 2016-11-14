Public Class Form1

    Public initHeight As Integer
    Public initWidth As Integer
    Public initFontSize As Integer
    Public initPosition As System.Drawing.Point

    Private Sub SizeTrackBar_Scroll(sender As Object, e As EventArgs) Handles SizeTrackBar.Scroll
        TextBox1.Height = initHeight + SizeTrackBar.Value
        TextBox1.Width = initWidth + SizeTrackBar.Value
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initHeight = TextBox1.Height
        initWidth = TextBox1.Width
        initFontSize = TextBox1.Font.Size
        initPosition = TextBox1.Location
    End Sub

    Private Sub FontTrackBar_Scroll(sender As Object, e As EventArgs) Handles FontTrackBar.Scroll
        Dim font = New System.Drawing.Font(TextBox1.Font.FontFamily.ToString, initFontSize + FontTrackBar.Value)
        TextBox1.Font = font
    End Sub

    Private Sub PositionTrackBar_Scroll(sender As Object, e As EventArgs) Handles PositionTrackBar.Scroll
        TextBox1.Location = New System.Drawing.Point(initPosition.X + PositionTrackBar.Value, initPosition.Y)
    End Sub
End Class
