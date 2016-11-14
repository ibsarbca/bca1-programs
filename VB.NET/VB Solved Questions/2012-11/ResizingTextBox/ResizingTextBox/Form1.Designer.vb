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
        Me.SizeTrackBar = New System.Windows.Forms.TrackBar()
        Me.FontTrackBar = New System.Windows.Forms.TrackBar()
        Me.PositionTrackBar = New System.Windows.Forms.TrackBar()
        CType(Me.SizeTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FontTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(82, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'SizeTrackBar
        '
        Me.SizeTrackBar.Location = New System.Drawing.Point(40, 127)
        Me.SizeTrackBar.Maximum = 100
        Me.SizeTrackBar.Name = "SizeTrackBar"
        Me.SizeTrackBar.Size = New System.Drawing.Size(180, 45)
        Me.SizeTrackBar.TabIndex = 1
        '
        'FontTrackBar
        '
        Me.FontTrackBar.Location = New System.Drawing.Point(40, 178)
        Me.FontTrackBar.Name = "FontTrackBar"
        Me.FontTrackBar.Size = New System.Drawing.Size(180, 45)
        Me.FontTrackBar.TabIndex = 1
        '
        'PositionTrackBar
        '
        Me.PositionTrackBar.Location = New System.Drawing.Point(40, 229)
        Me.PositionTrackBar.Maximum = 50
        Me.PositionTrackBar.Name = "PositionTrackBar"
        Me.PositionTrackBar.Size = New System.Drawing.Size(180, 45)
        Me.PositionTrackBar.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 330)
        Me.Controls.Add(Me.PositionTrackBar)
        Me.Controls.Add(Me.FontTrackBar)
        Me.Controls.Add(Me.SizeTrackBar)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SizeTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FontTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SizeTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents FontTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents PositionTrackBar As System.Windows.Forms.TrackBar

End Class
