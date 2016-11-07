<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ClassTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(79, 81)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(131, 20)
        Me.NameTextBox.TabIndex = 0
        '
        'ClassTextBox
        '
        Me.ClassTextBox.Location = New System.Drawing.Point(79, 131)
        Me.ClassTextBox.Name = "ClassTextBox"
        Me.ClassTextBox.Size = New System.Drawing.Size(131, 20)
        Me.ClassTextBox.TabIndex = 1
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(79, 184)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(131, 23)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ClassTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Name = "AddForm"
        Me.Text = "AddForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
End Class
