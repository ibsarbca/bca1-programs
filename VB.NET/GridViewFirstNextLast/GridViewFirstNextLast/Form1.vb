Imports GridViewFirstNextLast.DB

Public Class Form1

   


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DB

        Dim gridData = db.GetDataTable()

        DataGridView1.DataSource = gridData.DataSet
        DataGridView1.DataMember = "student"

        ' Set the current row to the first row
        DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
        ' SetTextBoxes(currentRow.Cells(0).Value.ToString(), currentRow.Cells(1).Value.ToString(), currentRow.Cells(2).Value.ToString())
        SetTextBoxes()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        ' From SO: http://stackoverflow.com/questions/9403466/proper-way-to-select-previous-and-next-row-using-a-hotkey-via-datagridview
        '

        ' Get number of records displayed first
        Dim numRows = DataGridView1.RowCount - 1

        ' get current row
        Dim currentIndex = DataGridView1.CurrentRow.Index

        If currentIndex < numRows Then
            ' Change the selected row to next row down in the data set
            DataGridView1.CurrentCell = DataGridView1(0, currentIndex + 1)
        Else
            DataGridView1.CurrentCell = DataGridView1(0, 0)
        End If

        SetTextBoxes()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim currentRow = DataGridView1.SelectedRows()
    End Sub

    Public Sub SetTextBoxes()
        Dim row = DataGridView1.CurrentRow
        txtId.Text = row.Cells("id").Value.ToString()
        txtName.Text = row.Cells("stdname").Value.ToString()
        txtCourse.Text = row.Cells("course").Value.ToString()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        ' From SO: http://stackoverflow.com/questions/9403466/proper-way-to-select-previous-and-next-row-using-a-hotkey-via-datagridview
        '

        ' Get number of records displayed first
        Dim numRows = DataGridView1.RowCount - 1

        ' get current row
        Dim currentIndex = DataGridView1.CurrentRow.Index

        If currentIndex > 0 Then
            ' Change the selected row to next row down in the data set
            DataGridView1.CurrentCell = DataGridView1(0, currentIndex - 1)
        Else
            DataGridView1.CurrentCell = DataGridView1(0, numRows)
        End If

        SetTextBoxes()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click

        ' Get number of records displayed first
        Dim numRows = DataGridView1.RowCount - 1
        DataGridView1.CurrentCell = DataGridView1(0, numRows - 1)

        SetTextBoxes()
    End Sub
End Class
