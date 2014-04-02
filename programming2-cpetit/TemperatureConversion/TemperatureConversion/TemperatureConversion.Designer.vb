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
        Me.celsiusLabel = New System.Windows.Forms.Label()
        Me.fahrenheitLabel = New System.Windows.Forms.Label()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.convertButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'celsiusLabel
        '
        Me.celsiusLabel.AutoSize = True
        Me.celsiusLabel.Location = New System.Drawing.Point(13, 18)
        Me.celsiusLabel.Name = "celsiusLabel"
        Me.celsiusLabel.Size = New System.Drawing.Size(154, 15)
        Me.celsiusLabel.TabIndex = 0
        Me.celsiusLabel.Text = "Enter a Celsius temperature:"
        '
        'fahrenheitLabel
        '
        Me.fahrenheitLabel.AutoSize = True
        Me.fahrenheitLabel.Location = New System.Drawing.Point(13, 50)
        Me.fahrenheitLabel.Name = "fahrenheitLabel"
        Me.fahrenheitLabel.Size = New System.Drawing.Size(124, 15)
        Me.fahrenheitLabel.TabIndex = 1
        Me.fahrenheitLabel.Text = "Fahrenheit equivalent:"
        '
        'resultLabel
        '
        Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.resultLabel.Location = New System.Drawing.Point(173, 46)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(56, 23)
        Me.resultLabel.TabIndex = 2
        Me.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(173, 16)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(56, 23)
        Me.inputTextBox.TabIndex = 3
        Me.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'convertButton
        '
        Me.convertButton.Location = New System.Drawing.Point(242, 14)
        Me.convertButton.Name = "convertButton"
        Me.convertButton.Size = New System.Drawing.Size(75, 23)
        Me.convertButton.TabIndex = 4
        Me.convertButton.Text = "Convert"
        Me.convertButton.UseVisualStyleBackColor = True
        '
        'TemperatureConversionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 82)
        Me.Controls.Add(Me.convertButton)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.fahrenheitLabel)
        Me.Controls.Add(Me.celsiusLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "TemperatureConversionForm"
        Me.Text = "Temperature Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents celsiusLabel As System.Windows.Forms.Label
   Friend WithEvents fahrenheitLabel As System.Windows.Forms.Label
   Friend WithEvents resultLabel As System.Windows.Forms.Label
   Friend WithEvents inputTextBox As System.Windows.Forms.TextBox
   Friend WithEvents convertButton As System.Windows.Forms.Button

End Class
