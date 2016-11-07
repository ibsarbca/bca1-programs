Imports System.Data.Sql
Imports System.Data.SqlClient

''' Author's Note
''' 
''' The connection code here repeats itself because it may be in the best interest of the reader or whoever is practicing
''' this to practice the procedure over and over again.
''' 
''' It is for this reason that this code is not abstracted away it's own class. However, a stub for such a class is provided.
''' This is the DatabaseConnectingClass that is part of this project.

Public Class UpdateForm

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim conn As SqlConnection
        Dim connectionString = "Data Source=DEFIANT\SQLEXPRESS;Initial Catalog=students;Integrated Security=True"

        conn = New SqlConnection(connectionString)

        conn.Open()

        Dim commandString = String.Format("SELECT * FROM student_details WHERE rollno = '{0}'", RollNoTextBox.Text.ToString())
        Dim command As SqlCommand = New SqlCommand(commandString, conn)

        Dim reader As SqlDataReader = command.ExecuteReader()

        While reader.Read
            NameTextBox.Text = reader.GetString(1)
            ClassTextBox.Text = reader.GetString(2)
        End While

        conn.Close()

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim conn As SqlConnection
        Dim connectionString = "Data Source=DEFIANT\SQLEXPRESS;Initial Catalog=students;Integrated Security=True"

        conn = New SqlConnection(connectionString)

        conn.Open()

        Dim commandString = String.Format("UPDATE student_details SET student_name='{0}', class='{1}' WHERE rollno='{2}'", NameTextBox.Text, ClassTextBox.Text, RollNoTextBox.Text.ToString())
        Dim command As SqlCommand = New SqlCommand(commandString, conn)

        command.ExecuteNonQuery()
        MsgBox("Update complete")

        conn.Close()
    End Sub
End Class