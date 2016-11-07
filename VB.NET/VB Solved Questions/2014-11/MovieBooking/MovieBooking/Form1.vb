Imports System.Data.SqlClient
Imports System.Data

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MoviebookingComboBoxDataSet.movies' table. You can move, or remove it, as needed.
        Me.MoviesTableAdapter.Fill(Me.MoviebookingComboBoxDataSet.movies)

    End Sub

    Private Sub BookButton_Click(sender As Object, e As EventArgs) Handles BookButton.Click
        Dim movieDate As Date = DateComboBox.SelectedValue
        Dim movieDateStr As String = movieDate.Date.Date.ToShortDateString()

        Dim movieTimeStr = TimeComboBox.SelectedValue.ToString()

        ' Fill dataset.
        ' Pardon the redundant code. It is used for practice.
        Dim conn = New SqlConnection(My.MySettings.Default.moviebookingConnectionString)
        Dim adapter = New SqlDataAdapter("SELECT * FROM movies", conn)
        Dim ds = New DataSet()
        Dim cmd = New SqlCommandBuilder(adapter)

        adapter.Fill(ds, "movies")

        Dim expr = String.Format("movieDate = #{0}# and movieTime='{1}'", movieDateStr, movieTimeStr)

        Dim row = ds.Tables("movies").Select(expr)(0)

        row("isBooked") = "Y"
        'ds.Tables("movies").AcceptChanges()

        cmd.GetUpdateCommand(True)
        
        adapter.Update(ds, "movies")
        
    End Sub
End Class
