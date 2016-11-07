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
        Me.DateComboBox = New System.Windows.Forms.ComboBox()
        Me.TimeComboBox = New System.Windows.Forms.ComboBox()
        Me.MoviebookingComboBoxDataSet = New MovieBooking.moviebookingComboBoxDataSet()
        Me.MoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoviesTableAdapter = New MovieBooking.moviebookingComboBoxDataSetTableAdapters.moviesTableAdapter()
        Me.BookButton = New System.Windows.Forms.Button()
        CType(Me.MoviebookingComboBoxDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateComboBox
        '
        Me.DateComboBox.DataSource = Me.MoviesBindingSource
        Me.DateComboBox.DisplayMember = "movieDate"
        Me.DateComboBox.FormattingEnabled = True
        Me.DateComboBox.Location = New System.Drawing.Point(54, 56)
        Me.DateComboBox.Name = "DateComboBox"
        Me.DateComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DateComboBox.TabIndex = 0
        Me.DateComboBox.ValueMember = "movieDate"
        '
        'TimeComboBox
        '
        Me.TimeComboBox.DataSource = Me.MoviesBindingSource
        Me.TimeComboBox.DisplayMember = "movieTime"
        Me.TimeComboBox.FormattingEnabled = True
        Me.TimeComboBox.Location = New System.Drawing.Point(54, 103)
        Me.TimeComboBox.Name = "TimeComboBox"
        Me.TimeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TimeComboBox.TabIndex = 1
        Me.TimeComboBox.ValueMember = "movieTime"
        '
        'MoviebookingComboBoxDataSet
        '
        Me.MoviebookingComboBoxDataSet.DataSetName = "moviebookingComboBoxDataSet"
        Me.MoviebookingComboBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MoviesBindingSource
        '
        Me.MoviesBindingSource.DataMember = "movies"
        Me.MoviesBindingSource.DataSource = Me.MoviebookingComboBoxDataSet
        '
        'MoviesTableAdapter
        '
        Me.MoviesTableAdapter.ClearBeforeFill = True
        '
        'BookButton
        '
        Me.BookButton.Location = New System.Drawing.Point(54, 162)
        Me.BookButton.Name = "BookButton"
        Me.BookButton.Size = New System.Drawing.Size(75, 23)
        Me.BookButton.TabIndex = 2
        Me.BookButton.Text = "Book"
        Me.BookButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BookButton)
        Me.Controls.Add(Me.TimeComboBox)
        Me.Controls.Add(Me.DateComboBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MoviebookingComboBoxDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TimeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MoviebookingComboBoxDataSet As MovieBooking.moviebookingComboBoxDataSet
    Friend WithEvents MoviesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MoviesTableAdapter As MovieBooking.moviebookingComboBoxDataSetTableAdapters.moviesTableAdapter
    Friend WithEvents BookButton As System.Windows.Forms.Button

End Class
