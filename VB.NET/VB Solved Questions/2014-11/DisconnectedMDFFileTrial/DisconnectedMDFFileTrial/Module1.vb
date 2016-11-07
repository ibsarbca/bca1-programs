Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data

Module Module1

    Sub Main()
        '   DisonnectedToNormalDB()
        DisconnectedTrial()
        Console.Read()
    End Sub

    Sub DisonnectedToNormalDB()
        Dim conn = New SqlConnection("Data Source=DEFIANT\SQLEXPRESS;Initial Catalog=mdtrial;Integrated Security=True")
        Dim adapter = New SqlDataAdapter("SELECT * FROM Student", conn)
        Dim ds = New DataSet()
        adapter.Fill(ds, "Student")
        Dim cmdBuilder = New SqlCommandBuilder(adapter)

        Dim table As DataTable = ds.Tables("Student")
        Dim newRow As DataRow = table.NewRow()
        newRow("name") = "Dhaval"
        table.Rows.Add(newRow)

        'table.AcceptChanges()

        adapter.Update(ds, "Student")

        PrintDataSet(ds)




    End Sub

    Sub PrintDataSet(ByRef ds As DataSet)
        For Each table As DataTable In ds.Tables
            For curRow = 0 To table.Rows.Count - 1
                For curCol = 0 To table.Columns.Count - 1
                    Console.Write(table.Rows(curRow)(curCol) & "    ")
                Next
                Console.WriteLine()
            Next
        Next

    End Sub

    Sub DisconnectedTrial()
        Dim conn = New SqlConnection("Data Source=.;AttachDbFilename=E:\Mumbai\bca1-programs\VB.NET\VB Solved Questions\2014-11\DisconnectedMDFFileTrial\DisconnectedMDFFileTrial\bin\Debug\mddb.mdf;Integrated Security=True;Connect Timeout=30")
        Try
            Dim adapter = New SqlDataAdapter("SELECT * FROM Student", conn)
            Dim builder = New SqlCommandBuilder(adapter)

            Dim ds = New DataSet()
            adapter.Fill(ds, "Student")


            Dim table As DataTable = ds.Tables("Student")
            Dim newRow As DataRow = table.NewRow()
            newRow("stuId") = 222
            newRow("stuName") = "Dhaval"
            table.Rows.Add(newRow)

            'table.AcceptChanges()

            adapter.Update(ds, "Student")

            PrintDataSet(ds)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module