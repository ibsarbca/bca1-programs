Imports System.Data.SqlClient
Imports System.Data


Public Class ManagerForm
    Public conn As SqlConnection
    Public ds As DataSet
    Public adapter As SqlDataAdapter

    Private selectedAccountNo As Integer

    Private Sub ManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection(My.MySettings.Default.bankingdbConnectionString)
        ds = New DataSet()
        adapter = New SqlDataAdapter("SELECT * FROM ACCOUNTS", conn)
        adapter.Fill(ds, "Accounts")

        For Each row In ds.Tables(0).Rows
            AccountNoComboBox.Items.Add(row("accountno"))
        Next
    End Sub

    Private Sub AccountNoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AccountNoComboBox.SelectedIndexChanged
        selectedAccountNo = AccountNoComboBox.SelectedItem.ToString()
        Dim row = ds.Tables(0).Select("accountno = " & selectedAccountNo).First()
        NameLabel.Text = row("customerName")
        BalanceLabel.Text = row("balance")

        ' Make things a little easier by putting the values here
        StatusComboBox.Items.Add("pending")
        StatusComboBox.Items.Add("approved")
        StatusComboBox.Items.Add("rejected")

        StatusComboBox.SelectedText = row("status")
    End Sub

    Private Sub StatusComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StatusComboBox.SelectedIndexChanged
        Dim status = StatusComboBox.SelectedItem.ToString()
        MsgBox(selectedAccountNo)

        ' Meh, to hell with it.

        adapter.UpdateCommand = New SqlCommand()
        adapter.UpdateCommand.CommandText = "UPDATE Accounts SET status = '" & status & "' WHERE accountno = " & selectedAccountNo
        adapter.UpdateCommand.Connection = conn
        conn.Open()
        adapter.UpdateCommand.ExecuteNonQuery()
        conn.Close()
    End Sub
End Class