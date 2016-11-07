<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateForm
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
        Me.RollNoLabel = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.ClassLabel = New System.Windows.Forms.Label()
        Me.ClassTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.RollNoTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RollNoLabel
        '
        Me.RollNoLabel.AutoSize = True
        Me.RollNoLabel.Location = New System.Drawing.Point(58, 46)
        Me.RollNoLabel.Name = "RollNoLabel"
        Me.RollNoLabel.Size = New System.Drawing.Size(21, 13)
        Me.RollNoLabel.TabIndex = 1
        Me.RollNoLabel.Text = "ID:"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(61, 103)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(156, 23)
        Me.SearchButton.TabIndex = 2
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(58, 148)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Name"
        '
        'ClassLabel
        '
        Me.ClassLabel.AutoSize = True
        Me.ClassLabel.Location = New System.Drawing.Point(58, 203)
        Me.ClassLabel.Name = "ClassLabel"
        Me.ClassLabel.Size = New System.Drawing.Size(32, 13)
        Me.ClassLabel.TabIndex = 3
        Me.ClassLabel.Text = "Class"
        '
        'ClassTextBox
        '
        Me.ClassTextBox.Location = New System.Drawing.Point(61, 219)
        Me.ClassTextBox.Name = "ClassTextBox"
        Me.ClassTextBox.Size = New System.Drawing.Size(156, 20)
        Me.ClassTextBox.TabIndex = 0
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(61, 164)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(156, 20)
        Me.NameTextBox.TabIndex = 0
        '
        'RollNoTextBox
        '
        Me.RollNoTextBox.Location = New System.Drawing.Point(61, 62)
        Me.RollNoTextBox.Name = "RollNoTextBox"
        Me.RollNoTextBox.Size = New System.Drawing.Size(156, 20)
        Me.RollNoTextBox.TabIndex = 0
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(61, 263)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(156, 23)
        Me.UpdateButton.TabIndex = 2
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'UpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 323)
        Me.Controls.Add(Me.ClassLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.RollNoLabel)
        Me.Controls.Add(Me.ClassTextBox)
        Me.Controls.Add(Me.RollNoTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Name = "UpdateForm"
        Me.Text = "UpdateForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RollNoLabel As System.Windows.Forms.Label
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents ClassLabel As System.Windows.Forms.Label
    Friend WithEvents ClassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RollNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
End Class
