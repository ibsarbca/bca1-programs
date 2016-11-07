Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Sql

Public Class Form1

    Shared adapter As SqlDataAdapter
    Shared ds As DataSet
    Shared conn As SqlConnection
    Shared builder As SqlCommandBuilder
    
    Private Sub ImageLocationTextBox_Click(sender As Object, e As EventArgs) Handles ImageLocationTextBox.Click
        Dim dialog = New OpenFileDialog()
        dialog.ShowDialog()

        ImageLocationTextBox.Text = dialog.FileName
        PictureBox1.ImageLocation = dialog.FileName

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
    
        Dim table = ds.Tables("Candidate")
        Dim newRow = table.NewRow()
        newRow("name") = NameTextBox.Text
        newRow("addr") = AddrTextBox.Text
        newRow("imageLocation") = ImageLocationTextBox.Text

        table.Rows.Add(newRow)

        adapter.Update(ds, "Candidate")
    End Sub

    Private Sub ShowLastRecordButton_Click(sender As Object, e As EventArgs) Handles ShowLastRecordButton.Click
        adapter.Fill(ds, "Candidate")
        Dim row = ds.Tables("Candidate").Rows(ds.Tables("Candidate").Rows.Count - 1)
        IDValueLabel.Text = row("id")
        NameTextBox.Text = row("name")
        AddrTextBox.Text = row("addr")
        ImageLocationTextBox.Text = row("imageLocation")
        PictureBox1.ImageLocation = row("imageLocation")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Data Source=DEFIANT\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True")
        adapter = New SqlDataAdapter("SELECT * FROM Candidate", conn)
        builder = New SqlCommandBuilder(adapter)
        ds = New DataSet()
        adapter.Fill(ds, "Candidate")

    End Sub
End Class
