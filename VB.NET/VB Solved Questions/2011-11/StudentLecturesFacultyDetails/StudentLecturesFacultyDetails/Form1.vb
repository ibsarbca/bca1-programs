Imports System.Data.SqlClient
Imports System.Data

Public Class Form1

    Dim conn As SqlConnection
    Dim adapter As SqlDataAdapter
    Dim ds As DataSet
    Dim cmdBuilder As SqlCommandBuilder

    Shared connString = "Data Source=DEFIANT\SQLEXPRESS;Initial Catalog=collegedb;Integrated Security=True"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection(connString)
        ds = New DataSet()
        adapter = New SqlDataAdapter("SELECT * FROM StudentLectureFacultyJoin", conn)
        adapter.Fill(ds, "Table1")

        ' Since there's no easy way to get distinct values of student id (without using LINQ or some such), we copy all the values in a list which will give distict values
        Dim studentIdList = New List(Of Integer)
        For Each row In ds.Tables(0).Rows()
            studentIdList.Add(row("studentid"))
        Next
        ' And then we add the values to the StudentIdComboBox
        For Each item In studentIdList.Distinct()
            StudentIdComboBox.Items.Add(item)
        Next


    End Sub

    Private Sub StudentIdComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StudentIdComboBox.SelectedIndexChanged
        ' This table would contain only the lectureName and the facultyName of the selected studentid
        Dim lectureFacultyTable = New DataTable()
        lectureFacultyTable.Columns.Add(ds.Tables(0).Columns("lectureName").ColumnName)
        lectureFacultyTable.Columns.Add(ds.Tables(0).Columns("facultyName").ColumnName)

        For Each row In ds.Tables(0).Select("studentid = " & StudentIdComboBox.Text)
            lectureFacultyTable.Rows.Add(row("lectureName"), row("facultyName"))
        Next

        DataGridView1.DataSource = lectureFacultyTable

        ' show lables
        NameLabel.Text = ds.Tables(0).Select("studentid = " & StudentIdComboBox.Text).First()("name")

        CourseLabel.Text = ds.Tables(0).Select("studentid = " & StudentIdComboBox.Text).First()("classname")

    End Sub
End Class
