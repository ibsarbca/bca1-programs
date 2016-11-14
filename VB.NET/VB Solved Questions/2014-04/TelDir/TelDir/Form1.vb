Public Class Form1

    Private Sub Tel_dirBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tel_dirBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tel_dirBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tel_dirdbDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Tel_dirdbDataSet.tel_dir' table. You can move, or remove it, as needed.
        Me.Tel_dirTableAdapter.Fill(Me.Tel_dirdbDataSet.tel_dir)

    End Sub
End Class
