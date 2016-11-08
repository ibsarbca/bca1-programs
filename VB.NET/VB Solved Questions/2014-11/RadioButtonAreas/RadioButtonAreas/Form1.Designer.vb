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
        Me.SquareRadioButton = New System.Windows.Forms.RadioButton()
        Me.CircleRadioButton = New System.Windows.Forms.RadioButton()
        Me.CubeRadioButton = New System.Windows.Forms.RadioButton()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SquareRadioButton
        '
        Me.SquareRadioButton.AutoSize = True
        Me.SquareRadioButton.Location = New System.Drawing.Point(59, 58)
        Me.SquareRadioButton.Name = "SquareRadioButton"
        Me.SquareRadioButton.Size = New System.Drawing.Size(96, 17)
        Me.SquareRadioButton.TabIndex = 0
        Me.SquareRadioButton.TabStop = True
        Me.SquareRadioButton.Text = "Area of Square"
        Me.SquareRadioButton.UseVisualStyleBackColor = True
        '
        'CircleRadioButton
        '
        Me.CircleRadioButton.AutoSize = True
        Me.CircleRadioButton.Location = New System.Drawing.Point(59, 108)
        Me.CircleRadioButton.Name = "CircleRadioButton"
        Me.CircleRadioButton.Size = New System.Drawing.Size(88, 17)
        Me.CircleRadioButton.TabIndex = 1
        Me.CircleRadioButton.TabStop = True
        Me.CircleRadioButton.Text = "Area of Circle"
        Me.CircleRadioButton.UseVisualStyleBackColor = True
        '
        'CubeRadioButton
        '
        Me.CubeRadioButton.AutoSize = True
        Me.CubeRadioButton.Location = New System.Drawing.Point(59, 160)
        Me.CubeRadioButton.Name = "CubeRadioButton"
        Me.CubeRadioButton.Size = New System.Drawing.Size(100, 17)
        Me.CubeRadioButton.TabIndex = 2
        Me.CubeRadioButton.TabStop = True
        Me.CubeRadioButton.Text = "Volume of Cube"
        Me.CubeRadioButton.UseVisualStyleBackColor = True
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(59, 196)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(152, 23)
        Me.GoButton.TabIndex = 3
        Me.GoButton.Text = "Go!"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.CubeRadioButton)
        Me.Controls.Add(Me.CircleRadioButton)
        Me.Controls.Add(Me.SquareRadioButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SquareRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CircleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CubeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GoButton As System.Windows.Forms.Button

End Class
