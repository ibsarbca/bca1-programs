Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports System.Diagnostics

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MoviebookingDataSet.movies' table. You can move, or remove it, as needed.
        Me.MoviesTableAdapter.Fill(Me.MoviebookingDataSet.movies)

    End Sub

    Private Sub BookButton_Click(sender As Object, e As EventArgs) Handles BookButton.Click
        ' Get rows and make changes
        ' Get date from the form
        Dim dateAndTime As DateTime = ComboBox1.SelectedValue
        If Not isBookable(dateAndTime) Then
            MsgBox("Ticket not bookable one hour before the movie")
            Return
        End If

        ' Initialize everything
        Dim conn = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename='E:\Mumbai\bca1-programs\VB.NET\VB Solved Questions\2014-11\MovieBooking\MovieBooking\moviebooking.mdf';Integrated Security=True;Connect Timeout=30")

        Dim adapter = New SqlDataAdapter("SELECT * FROM movies", conn)
        Dim ds = New DataSet()
        adapter.Fill(ds, "movies")

        ' Create the expression that we use to select the specific row.
        Dim expr = String.Format("dateAndTime = #" & dateAndTime & "#")

        Dim row = ds.Tables(0).Select(expr).First() ' It should return one row anyway
        row("isBooked") = "Y"

        ' Create update command
        Dim cmdBuilder = New SqlCommandBuilder(adapter)
        adapter.UpdateCommand = cmdBuilder.GetUpdateCommand(True)

        ' Push changes to database
        adapter.Update(ds, "movies")

        MsgBox("Booking Complete")
    End Sub

    Public Function isBookable(ByVal dt As DateTime) As Boolean
        Dim difference = dt - DateTime.Now()
        If difference.Days = 0 Then
            If difference.Hours > 1 Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If

    End Function

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ' Again, code is redundant because one needs to practice
        ' Get date from the Form.
        Dim dateAndTime As DateTime = ComboBox1.SelectedValue

        If Not isCancellable(dateAndTime) Then
            MsgBox("Ticket not cancellable less than two hours before movie.")
            Return
        End If

            ' Initialize everything
            Dim conn = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename='E:\Mumbai\bca1-programs\VB.NET\VB Solved Questions\2014-11\MovieBooking\MovieBooking\moviebooking.mdf';Integrated Security=True;Connect Timeout=30")
            Dim adapter = New SqlDataAdapter("SELECT * FROM Movies", conn)
            Dim ds = New DataSet()
            adapter.Fill(ds, "movies")

            ' Create the expression that we use to select the specific row
            Dim expr = String.Format("dateAndTime = #" & dateAndTime & "#")

            Dim row = ds.Tables(0).Select(expr).First() ' Since we expect one row anyway.
            row("isBooked") = "N"

            ' Create update command
            Dim cmdBuilder = New SqlCommandBuilder(adapter)
            adapter.UpdateCommand = cmdBuilder.GetUpdateCommand(True)

            ' Push changes to database
        adapter.Update(ds, "movies")

        MsgBox("Cancellation Complete")
    End Sub

    Public Function isCancellable(ByRef dt As DateTime) As Boolean
        Dim difference = dt - DateTime.Now()
        If difference.Days = 0 Then
            If difference.Hours <= 2 Then
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

End Class
