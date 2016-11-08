Public Class Form1

    Private Sub ItemBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ItemBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ItemBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ItemsdbDataSet)
        Dim adapter = Me.TableAdapterManager.itemTableAdapter
        Me.TableAdapterManager.itemTableAdapter.Update(Me.ItemsdbDataSet.item)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ItemsdbDataSet.item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.ItemsdbDataSet.item)

    End Sub

End Class
