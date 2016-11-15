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
        Me.CashierButton = New System.Windows.Forms.Button()
        Me.ManagerButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CashierButton
        '
        Me.CashierButton.Location = New System.Drawing.Point(51, 76)
        Me.CashierButton.Name = "CashierButton"
        Me.CashierButton.Size = New System.Drawing.Size(176, 23)
        Me.CashierButton.TabIndex = 0
        Me.CashierButton.Text = "Cashier Login"
        Me.CashierButton.UseVisualStyleBackColor = True
        '
        'ManagerButton
        '
        Me.ManagerButton.Location = New System.Drawing.Point(51, 142)
        Me.ManagerButton.Name = "ManagerButton"
        Me.ManagerButton.Size = New System.Drawing.Size(176, 23)
        Me.ManagerButton.TabIndex = 0
        Me.ManagerButton.Text = "Manager Login"
        Me.ManagerButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ManagerButton)
        Me.Controls.Add(Me.CashierButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CashierButton As System.Windows.Forms.Button
    Friend WithEvents ManagerButton As System.Windows.Forms.Button

End Class
