<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim InoLabel As System.Windows.Forms.Label
        Dim InameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ItemsdbDataSet = New AddUpdateToItemTable.itemsdbDataSet()
        Me.ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemTableAdapter = New AddUpdateToItemTable.itemsdbDataSetTableAdapters.itemTableAdapter()
        Me.TableAdapterManager = New AddUpdateToItemTable.itemsdbDataSetTableAdapters.TableAdapterManager()
        Me.ItemBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItemBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.InoTextBox = New System.Windows.Forms.TextBox()
        Me.InameTextBox = New System.Windows.Forms.TextBox()
        InoLabel = New System.Windows.Forms.Label()
        InameLabel = New System.Windows.Forms.Label()
        CType(Me.ItemsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'InoLabel
        '
        InoLabel.AutoSize = True
        InoLabel.Location = New System.Drawing.Point(41, 89)
        InoLabel.Name = "InoLabel"
        InoLabel.Size = New System.Drawing.Size(24, 13)
        InoLabel.TabIndex = 1
        InoLabel.Text = "ino:"
        '
        'InameLabel
        '
        InameLabel.AutoSize = True
        InameLabel.Location = New System.Drawing.Point(41, 115)
        InameLabel.Name = "InameLabel"
        InameLabel.Size = New System.Drawing.Size(38, 13)
        InameLabel.TabIndex = 3
        InameLabel.Text = "iname:"
        '
        'ItemsdbDataSet
        '
        Me.ItemsdbDataSet.DataSetName = "itemsdbDataSet"
        Me.ItemsdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemBindingSource
        '
        Me.ItemBindingSource.DataMember = "item"
        Me.ItemBindingSource.DataSource = Me.ItemsdbDataSet
        '
        'ItemTableAdapter
        '
        Me.ItemTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.itemTableAdapter = Me.ItemTableAdapter
        Me.TableAdapterManager.UpdateOrder = AddUpdateToItemTable.itemsdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ItemBindingNavigator
        '
        Me.ItemBindingNavigator.AddNewItem = Me.BindingNavigatorCountItem
        Me.ItemBindingNavigator.BindingSource = Me.ItemBindingSource
        Me.ItemBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ItemBindingNavigator.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemBindingSource, "iname", True))
        Me.ItemBindingNavigator.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ItemBindingSource, "iname", True))
        Me.ItemBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ItemBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ItemBindingNavigatorSaveItem})
        Me.ItemBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ItemBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ItemBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ItemBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ItemBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ItemBindingNavigator.Name = "ItemBindingNavigator"
        Me.ItemBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ItemBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.ItemBindingNavigator.TabIndex = 0
        Me.ItemBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ItemBindingNavigatorSaveItem
        '
        Me.ItemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ItemBindingNavigatorSaveItem.Image = CType(resources.GetObject("ItemBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ItemBindingNavigatorSaveItem.Name = "ItemBindingNavigatorSaveItem"
        Me.ItemBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ItemBindingNavigatorSaveItem.Text = "Save Data"
        '
        'InoTextBox
        '
        Me.InoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemBindingSource, "ino", True))
        Me.InoTextBox.Location = New System.Drawing.Point(85, 86)
        Me.InoTextBox.Name = "InoTextBox"
        Me.InoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InoTextBox.TabIndex = 2
        '
        'InameTextBox
        '
        Me.InameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemBindingSource, "iname", True))
        Me.InameTextBox.Location = New System.Drawing.Point(85, 112)
        Me.InameTextBox.Name = "InameTextBox"
        Me.InameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InameTextBox.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(InoLabel)
        Me.Controls.Add(Me.InoTextBox)
        Me.Controls.Add(InameLabel)
        Me.Controls.Add(Me.InameTextBox)
        Me.Controls.Add(Me.ItemBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ItemsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemBindingNavigator.ResumeLayout(False)
        Me.ItemBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ItemsdbDataSet As AddUpdateToItemTable.itemsdbDataSet
    Friend WithEvents ItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemTableAdapter As AddUpdateToItemTable.itemsdbDataSetTableAdapters.itemTableAdapter
    Friend WithEvents TableAdapterManager As AddUpdateToItemTable.itemsdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ItemBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents InoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InameTextBox As System.Windows.Forms.TextBox

End Class
