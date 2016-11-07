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
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AddrLabel = New System.Windows.Forms.Label()
        Me.ImageLocationLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddrTextBox = New System.Windows.Forms.TextBox()
        Me.ImageLocationTextBox = New System.Windows.Forms.TextBox()
        Me.IDValueLabel = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShowLastRecordButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Location = New System.Drawing.Point(32, 42)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(21, 13)
        Me.IDLabel.TabIndex = 0
        Me.IDLabel.Text = "ID:"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(32, 72)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name"
        '
        'AddrLabel
        '
        Me.AddrLabel.AutoSize = True
        Me.AddrLabel.Location = New System.Drawing.Point(32, 99)
        Me.AddrLabel.Name = "AddrLabel"
        Me.AddrLabel.Size = New System.Drawing.Size(29, 13)
        Me.AddrLabel.TabIndex = 0
        Me.AddrLabel.Text = "Addr"
        '
        'ImageLocationLabel
        '
        Me.ImageLocationLabel.AutoSize = True
        Me.ImageLocationLabel.Location = New System.Drawing.Point(32, 130)
        Me.ImageLocationLabel.Name = "ImageLocationLabel"
        Me.ImageLocationLabel.Size = New System.Drawing.Size(36, 13)
        Me.ImageLocationLabel.TabIndex = 0
        Me.ImageLocationLabel.Text = "Image"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(110, 69)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'AddrTextBox
        '
        Me.AddrTextBox.Location = New System.Drawing.Point(110, 96)
        Me.AddrTextBox.Name = "AddrTextBox"
        Me.AddrTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddrTextBox.TabIndex = 2
        '
        'ImageLocationTextBox
        '
        Me.ImageLocationTextBox.Location = New System.Drawing.Point(110, 127)
        Me.ImageLocationTextBox.Name = "ImageLocationTextBox"
        Me.ImageLocationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImageLocationTextBox.TabIndex = 3
        '
        'IDValueLabel
        '
        Me.IDValueLabel.AutoSize = True
        Me.IDValueLabel.Location = New System.Drawing.Point(110, 41)
        Me.IDValueLabel.Name = "IDValueLabel"
        Me.IDValueLabel.Size = New System.Drawing.Size(0, 13)
        Me.IDValueLabel.TabIndex = 2
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(35, 196)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 4
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(243, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 71)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ShowLastRecordButton
        '
        Me.ShowLastRecordButton.Location = New System.Drawing.Point(257, 196)
        Me.ShowLastRecordButton.Name = "ShowLastRecordButton"
        Me.ShowLastRecordButton.Size = New System.Drawing.Size(97, 39)
        Me.ShowLastRecordButton.TabIndex = 5
        Me.ShowLastRecordButton.Text = "Show Last Record"
        Me.ShowLastRecordButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 261)
        Me.Controls.Add(Me.ShowLastRecordButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.IDValueLabel)
        Me.Controls.Add(Me.ImageLocationTextBox)
        Me.Controls.Add(Me.AddrTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.ImageLocationLabel)
        Me.Controls.Add(Me.AddrLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.IDLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IDLabel As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents AddrLabel As System.Windows.Forms.Label
    Friend WithEvents ImageLocationLabel As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImageLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDValueLabel As System.Windows.Forms.Label
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ShowLastRecordButton As System.Windows.Forms.Button

End Class
