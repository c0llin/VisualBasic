<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurrencyConverterForm
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
        Me.dollarsLabel = New System.Windows.Forms.Label()
        Me.currencyLabel = New System.Windows.Forms.Label()
        Me.convertedLabel = New System.Windows.Forms.Label()
        Me.convertedResultLabel = New System.Windows.Forms.Label()
        Me.dollarsTextBox = New System.Windows.Forms.TextBox()
        Me.currencyTextBox = New System.Windows.Forms.TextBox()
        Me.convertButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dollarsLabel
        '
        Me.dollarsLabel.AutoSize = True
        Me.dollarsLabel.Location = New System.Drawing.Point(13, 13)
        Me.dollarsLabel.Name = "dollarsLabel"
        Me.dollarsLabel.Size = New System.Drawing.Size(103, 15)
        Me.dollarsLabel.TabIndex = 0
        Me.dollarsLabel.Text = "Dollars to convert:"
        Me.dollarsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'currencyLabel
        '
        Me.currencyLabel.AutoSize = True
        Me.currencyLabel.Location = New System.Drawing.Point(13, 44)
        Me.currencyLabel.Name = "currencyLabel"
        Me.currencyLabel.Size = New System.Drawing.Size(134, 15)
        Me.currencyLabel.TabIndex = 1
        Me.currencyLabel.Text = "Convert from Dollars to:"
        Me.currencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'convertedLabel
        '
        Me.convertedLabel.AutoSize = True
        Me.convertedLabel.Location = New System.Drawing.Point(13, 75)
        Me.convertedLabel.Name = "convertedLabel"
        Me.convertedLabel.Size = New System.Drawing.Size(110, 15)
        Me.convertedLabel.TabIndex = 2
        Me.convertedLabel.Text = "Converted amount:"
        Me.convertedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'convertedResultLabel
        '
        Me.convertedResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.convertedResultLabel.Location = New System.Drawing.Point(153, 71)
        Me.convertedResultLabel.Name = "convertedResultLabel"
        Me.convertedResultLabel.Size = New System.Drawing.Size(100, 23)
        Me.convertedResultLabel.TabIndex = 3
        Me.convertedResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dollarsTextBox
        '
        Me.dollarsTextBox.Location = New System.Drawing.Point(153, 10)
        Me.dollarsTextBox.Name = "dollarsTextBox"
        Me.dollarsTextBox.Size = New System.Drawing.Size(100, 23)
        Me.dollarsTextBox.TabIndex = 4
        Me.dollarsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'currencyTextBox
        '
        Me.currencyTextBox.Location = New System.Drawing.Point(153, 40)
        Me.currencyTextBox.Name = "currencyTextBox"
        Me.currencyTextBox.Size = New System.Drawing.Size(100, 23)
        Me.currencyTextBox.TabIndex = 5
        Me.currencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'convertButton
        '
        Me.convertButton.Location = New System.Drawing.Point(153, 108)
        Me.convertButton.Name = "convertButton"
        Me.convertButton.Size = New System.Drawing.Size(100, 23)
        Me.convertButton.TabIndex = 6
        Me.convertButton.Text = "Convert"
        Me.convertButton.UseVisualStyleBackColor = True
        '
        'CurrencyConverterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 143)
        Me.Controls.Add(Me.convertButton)
        Me.Controls.Add(Me.currencyTextBox)
        Me.Controls.Add(Me.dollarsTextBox)
        Me.Controls.Add(Me.convertedResultLabel)
        Me.Controls.Add(Me.convertedLabel)
        Me.Controls.Add(Me.currencyLabel)
        Me.Controls.Add(Me.dollarsLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "CurrencyConverterForm"
        Me.Text = "Currency Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents dollarsLabel As System.Windows.Forms.Label
   Friend WithEvents currencyLabel As System.Windows.Forms.Label
   Friend WithEvents convertedLabel As System.Windows.Forms.Label
   Friend WithEvents convertedResultLabel As System.Windows.Forms.Label
   Friend WithEvents dollarsTextBox As System.Windows.Forms.TextBox
   Friend WithEvents currencyTextBox As System.Windows.Forms.TextBox
   Friend WithEvents convertButton As System.Windows.Forms.Button

End Class
