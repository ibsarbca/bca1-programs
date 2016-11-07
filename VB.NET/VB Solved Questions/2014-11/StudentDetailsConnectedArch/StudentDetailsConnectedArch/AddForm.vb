Imports System.Data.SqlClient


Public Class AddForm

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim conn As SqlConnection
        Dim connectionString = "Data Source=DEFIANT\SQLEXPRESS;Initial Catalog=students;Integrated Security=True"

        conn = New SqlConnection(connectionString)

        conn.Open()

        Dim commandString = String.Format("INSERT INTO student_details(student_name, class) VALUES('{0}','{1}')", NameTextBox.Text, ClassTextBox.Text)
        Dim command = New SqlCommand(commandString, conn)

        command.ExecuteNonQuery()

        MsgBox("Save complete")
        conn.Close()
    End Sub
End Class