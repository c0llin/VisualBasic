<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CafeteriaSurveyForm
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
        Me.rateLabel = New System.Windows.Forms.Label()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.resultsLabel = New System.Windows.Forms.Label()
        Me.outputTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'rateLabel
        '
        Me.rateLabel.AutoSize = True
        Me.rateLabel.Location = New System.Drawing.Point(14, 17)
        Me.rateLabel.Name = "rateLabel"
        Me.rateLabel.Size = New System.Drawing.Size(109, 15)
        Me.rateLabel.TabIndex = 2
        Me.rateLabel.Text = "Rate cafeteria food:"
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(62, 57)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(97, 23)
        Me.submitButton.TabIndex = 0
        Me.submitButton.Text = "Submit Rating"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'resultsLabel
        '
        Me.resultsLabel.AutoSize = True
        Me.resultsLabel.Location = New System.Drawing.Point(14, 97)
        Me.resultsLabel.Name = "resultsLabel"
        Me.resultsLabel.Size = New System.Drawing.Size(82, 15)
        Me.resultsLabel.TabIndex = 3
        Me.resultsLabel.Text = "Survey results:"
        '
        'outputTextBox
        '
        Me.outputTextBox.Location = New System.Drawing.Point(17, 115)
        Me.outputTextBox.Multiline = True
        Me.outputTextBox.Name = "outputTextBox"
        Me.outputTextBox.ReadOnly = True
        Me.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.outputTextBox.Size = New System.Drawing.Size(186, 136)
        Me.outputTextBox.TabIndex = 4
        '
        'ComboBox
        '
        Me.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(129, 11)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(79, 23)
        Me.ComboBox.TabIndex = 5
        '
        'CafeteriaSurveyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 263)
        Me.Controls.Add(Me.ComboBox)
        Me.Controls.Add(Me.outputTextBox)
        Me.Controls.Add(Me.resultsLabel)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.rateLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "CafeteriaSurveyForm"
        Me.Text = "Cafeteria Survey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents rateLabel As System.Windows.Forms.Label
   Friend WithEvents submitButton As System.Windows.Forms.Button
   Friend WithEvents resultsLabel As System.Windows.Forms.Label
    Friend WithEvents outputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox As System.Windows.Forms.ComboBox

End Class
