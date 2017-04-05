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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.MoviesBindingSource
        Me.ComboBox1.DisplayMember = "dateAndTime"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(58, 62)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.ValueMember = "dateAndTime"
        '
        'MoviesBindingSource
        '
        Me.MoviesBindingSource.DataMember = "movies"
        '
        'BookButton
        '
        Me.BookButton.Location = New System.Drawing.Point(106, 127)
        Me.BookButton.Name = "BookButton"
        Me.BookButton.Size = New System.Drawing.Size(75, 23)
        Me.BookButton.TabIndex = 3
        Me.BookButton.Text = "Book"
        Me.BookButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(106, 176)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 5
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BookButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MoviesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button

End Class
