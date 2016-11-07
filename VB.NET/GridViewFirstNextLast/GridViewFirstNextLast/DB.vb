Imports System.Data.Sql
Imports System.Data.SqlClient

''' <summary>
''' This class handles all the Database connectivity stuff that is required by the assembly
''' </summary>
''' <remarks></remarks>
Public Class DB
    Public Shared conn As SqlConnection

    ' This is a constructor
    Sub New()
        conn = New SqlConnection("Data Source=localhost\sqlexpress;Initial Catalog=mydb;Integrated Security=True")
    End Sub

    ''' <summary>
    ''' Returns a dataset containing all rows from the table "student"
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function GetDataTable() As DataTable
        Dim selectQuery = "SELECT * FROM STUDENT"
        Dim dataAdapter As New SqlDataAdapter(selectQuery, conn)
        conn.Open()
        Dim dataSet As New DataSet()
        dataAdapter.Fill(dataSet, "student")
        Dim dataTable = dataSet.Tables("student")
        conn.Close()

        Return dataTable
    End Function

End Class
