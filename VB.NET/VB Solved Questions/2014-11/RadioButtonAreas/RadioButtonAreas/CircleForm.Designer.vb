<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CircleForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.RadiusTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter Radius"
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(52, 152)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(75, 23)
        Me.GoButton.TabIndex = 4
        Me.GoButton.Text = "GO!"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'RadiusTextBox
        '
        Me.RadiusTextBox.Location = New System.Drawing.Point(52, 68)
        Me.RadiusTextBox.Name = "RadiusTextBox"
        Me.RadiusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RadiusTextBox.TabIndex = 3
        '
        'CircleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.RadiusTextBox)
        Me.Name = "CircleForm"
        Me.Text = "CircleForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GoButton As System.Windows.Forms.Button
    Friend WithEvents RadiusTextBox As System.Windows.Forms.TextBox
End Class
