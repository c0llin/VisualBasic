<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemperatureConversionForm
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
      Me.degreeLabel = New System.Windows.Forms.Label
      Me.outputLabel = New System.Windows.Forms.Label
      Me.degreeTextBox = New System.Windows.Forms.TextBox
      Me.convertFahrenheitButton = New System.Windows.Forms.Button
      Me.convertCelsiusButton = New System.Windows.Forms.Button
      Me.SuspendLayout()
      '
      'degreeLabel
      '
      Me.degreeLabel.AutoSize = True
      Me.degreeLabel.Location = New System.Drawing.Point(15, 19)
      Me.degreeLabel.Name = "degreeLabel"
      Me.degreeLabel.Size = New System.Drawing.Size(52, 15)
      Me.degreeLabel.TabIndex = 0
      Me.degreeLabel.Text = "Degrees:"
      '
      'outputLabel
      '
      Me.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.outputLabel.Location = New System.Drawing.Point(18, 56)
      Me.outputLabel.Name = "outputLabel"
      Me.outputLabel.Size = New System.Drawing.Size(208, 49)
      Me.outputLabel.TabIndex = 1
      Me.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'degreeTextBox
      '
      Me.degreeTextBox.Location = New System.Drawing.Point(151, 16)
      Me.degreeTextBox.Name = "degreeTextBox"
      Me.degreeTextBox.Size = New System.Drawing.Size(75, 23)
      Me.degreeTextBox.TabIndex = 2
      Me.degreeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'convertFahrenheitButton
      '
      Me.convertFahrenheitButton.Location = New System.Drawing.Point(18, 125)
      Me.convertFahrenheitButton.Name = "convertFahrenheitButton"
      Me.convertFahrenheitButton.Size = New System.Drawing.Size(75, 44)
      Me.convertFahrenheitButton.TabIndex = 3
      Me.convertFahrenheitButton.Text = "Convert to Fahrenheit"
      Me.convertFahrenheitButton.UseVisualStyleBackColor = True
      '
      'convertCelsiusButton
      '
      Me.convertCelsiusButton.Location = New System.Drawing.Point(151, 125)
      Me.convertCelsiusButton.Name = "convertCelsiusButton"
      Me.convertCelsiusButton.Size = New System.Drawing.Size(75, 44)
      Me.convertCelsiusButton.TabIndex = 4
      Me.convertCelsiusButton.Text = "Convert to Celsius"
      Me.convertCelsiusButton.UseVisualStyleBackColor = True
      '
      'TemperatureConversionForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(244, 182)
      Me.Controls.Add(Me.convertCelsiusButton)
      Me.Controls.Add(Me.convertFahrenheitButton)
      Me.Controls.Add(Me.degreeTextBox)
      Me.Controls.Add(Me.outputLabel)
      Me.Controls.Add(Me.degreeLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "TemperatureConversionForm"
      Me.Text = "Temperature Converter"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents degreeLabel As System.Windows.Forms.Label
   Friend WithEvents outputLabel As System.Windows.Forms.Label
   Friend WithEvents degreeTextBox As System.Windows.Forms.TextBox
   Friend WithEvents convertFahrenheitButton As System.Windows.Forms.Button
   Friend WithEvents convertCelsiusButton As System.Windows.Forms.Button

End Class
