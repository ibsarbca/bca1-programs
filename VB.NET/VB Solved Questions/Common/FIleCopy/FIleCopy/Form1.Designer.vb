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
        Me.SourceTextBox = New System.Windows.Forms.TextBox()
        Me.DestTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ShowFilesButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'SourceTextBox
        '
        Me.SourceTextBox.Location = New System.Drawing.Point(79, 54)
        Me.SourceTextBox.Name = "SourceTextBox"
        Me.SourceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SourceTextBox.TabIndex = 0
        '
        'DestTextBox
        '
        Me.DestTextBox.Location = New System.Drawing.Point(79, 115)
        Me.DestTextBox.Name = "DestTextBox"
        Me.DestTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DestTextBox.TabIndex = 0
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(94, 167)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 1
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ShowFilesButton
        '
        Me.ShowFilesButton.Location = New System.Drawing.Point(94, 208)
        Me.ShowFilesButton.Name = "ShowFilesButton"
        Me.ShowFilesButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowFilesButton.TabIndex = 1
        Me.ShowFilesButton.Text = "Show Files"
        Me.ShowFilesButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ShowFilesButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.DestTextBox)
        Me.Controls.Add(Me.SourceTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SourceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DestTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents ShowFilesButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
