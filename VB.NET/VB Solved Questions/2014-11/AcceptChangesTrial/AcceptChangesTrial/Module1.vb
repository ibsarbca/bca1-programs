Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data

Module Module1

    Sub Main()
        Dim conn = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\dhaval\Documents\acceptChangesTrialDB.mdf;Integrated Security=True;Connect Timeout=30")
        Dim adapter = New SqlDataAdapter("SELECT * FROM variables", conn)
        Dim ds = New DataSet()
        adapter.Fill(ds, "variables")

        Dim cb = New SqlCommandBuilder(adapter)
        cb.GetUpdateCommand(True)

        Dim row = ds.Tables(0).Rows(0)
        row("val") = "ONE MILLION"

        adapter.Update(ds, "variables")
    End Sub

End Module
