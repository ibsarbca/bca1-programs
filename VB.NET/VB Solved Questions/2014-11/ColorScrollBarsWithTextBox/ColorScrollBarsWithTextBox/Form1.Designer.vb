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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TrackBarRed = New System.Windows.Forms.TrackBar()
        Me.TrackBarBlue = New System.Windows.Forms.TrackBar()
        Me.TrackBarGreen = New System.Windows.Forms.TrackBar()
        CType(Me.TrackBarRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TrackBarRed
        '
        Me.TrackBarRed.Location = New System.Drawing.Point(12, 70)
        Me.TrackBarRed.Maximum = 255
        Me.TrackBarRed.Name = "TrackBarRed"
        Me.TrackBarRed.Size = New System.Drawing.Size(260, 45)
        Me.TrackBarRed.TabIndex = 1
        '
        'TrackBarBlue
        '
        Me.TrackBarBlue.Location = New System.Drawing.Point(12, 121)
        Me.TrackBarBlue.Maximum = 255
        Me.TrackBarBlue.Name = "TrackBarBlue"
        Me.TrackBarBlue.Size = New System.Drawing.Size(260, 45)
        Me.TrackBarBlue.TabIndex = 1
        '
        'TrackBarGreen
        '
        Me.TrackBarGreen.Location = New System.Drawing.Point(12, 172)
        Me.TrackBarGreen.Maximum = 255
        Me.TrackBarGreen.Name = "TrackBarGreen"
        Me.TrackBarGreen.Size = New System.Drawing.Size(260, 45)
        Me.TrackBarGreen.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TrackBarGreen)
        Me.Controls.Add(Me.TrackBarBlue)
        Me.Controls.Add(Me.TrackBarRed)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TrackBarRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarGreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TrackBarRed As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarBlue As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarGreen As System.Windows.Forms.TrackBar

End Class
