Imports System.Drawing

Public Class Form1
    ' Object of Structure System.Drawing.Point, holds the initial position of 
    ' the PictureBox
    Dim initialPosition As Point

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialPosition = PictureBox1.Location
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        ' Start the timer object
        Timer1.Start()

        
    End Sub

    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        Timer1.Stop()
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        PictureBox1.Location = initialPosition
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' And move the picturebox left, i.e along the X axis.
        ' At each tick
        PictureBox1.Location = New Point(PictureBox1.Location.X + 1, PictureBox1.Location.Y)
    End Sub
End Class
