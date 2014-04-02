<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleCalculatorForm
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
        Me.firstNumberLabel = New System.Windows.Forms.Label()
        Me.secondNumberLabel = New System.Windows.Forms.Label()
        Me.outputLabel = New System.Windows.Forms.Label()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.firstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.secondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.divideButton = New System.Windows.Forms.Button()
        Me.subtractButton = New System.Windows.Forms.Button()
        Me.multiplyButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'firstNumberLabel
        '
        Me.firstNumberLabel.AutoSize = True
        Me.firstNumberLabel.Location = New System.Drawing.Point(12, 15)
        Me.firstNumberLabel.Name = "firstNumberLabel"
        Me.firstNumberLabel.Size = New System.Drawing.Size(105, 15)
        Me.firstNumberLabel.TabIndex = 0
        Me.firstNumberLabel.Text = "Enter first number:"
        '
        'secondNumberLabel
        '
        Me.secondNumberLabel.AutoSize = True
        Me.secondNumberLabel.Location = New System.Drawing.Point(12, 50)
        Me.secondNumberLabel.Name = "secondNumberLabel"
        Me.secondNumberLabel.Size = New System.Drawing.Size(123, 15)
        Me.secondNumberLabel.TabIndex = 1
        Me.secondNumberLabel.Text = "Enter second number:"
        '
        'outputLabel
        '
        Me.outputLabel.AutoSize = True
        Me.outputLabel.Location = New System.Drawing.Point(12, 86)
        Me.outputLabel.Name = "outputLabel"
        Me.outputLabel.Size = New System.Drawing.Size(42, 15)
        Me.outputLabel.TabIndex = 2
        Me.outputLabel.Text = "Result:"
        '
        'resultLabel
        '
        Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.resultLabel.Location = New System.Drawing.Point(141, 82)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(60, 23)
        Me.resultLabel.TabIndex = 3
        Me.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'firstNumberTextBox
        '
        Me.firstNumberTextBox.Location = New System.Drawing.Point(141, 12)
        Me.firstNumberTextBox.Name = "firstNumberTextBox"
        Me.firstNumberTextBox.Size = New System.Drawing.Size(60, 23)
        Me.firstNumberTextBox.TabIndex = 4
        Me.firstNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'secondNumberTextBox
        '
        Me.secondNumberTextBox.Location = New System.Drawing.Point(141, 47)
        Me.secondNumberTextBox.Name = "secondNumberTextBox"
        Me.secondNumberTextBox.Size = New System.Drawing.Size(60, 23)
        Me.secondNumberTextBox.TabIndex = 5
        Me.secondNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(217, 12)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(24, 24)
        Me.addButton.TabIndex = 6
        Me.addButton.Text = "+"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'divideButton
        '
        Me.divideButton.Location = New System.Drawing.Point(247, 42)
        Me.divideButton.Name = "divideButton"
        Me.divideButton.Size = New System.Drawing.Size(24, 24)
        Me.divideButton.TabIndex = 7
        Me.divideButton.Text = "/"
        Me.divideButton.UseVisualStyleBackColor = True
        '
        'subtractButton
        '
        Me.subtractButton.Location = New System.Drawing.Point(247, 12)
        Me.subtractButton.Name = "subtractButton"
        Me.subtractButton.Size = New System.Drawing.Size(24, 24)
        Me.subtractButton.TabIndex = 8
        Me.subtractButton.Text = "-"
        Me.subtractButton.UseVisualStyleBackColor = True
        '
        'multiplyButton
        '
        Me.multiplyButton.Location = New System.Drawing.Point(217, 42)
        Me.multiplyButton.Name = "multiplyButton"
        Me.multiplyButton.Size = New System.Drawing.Size(24, 24)
        Me.multiplyButton.TabIndex = 9
        Me.multiplyButton.Text = "*"
        Me.multiplyButton.UseVisualStyleBackColor = True
        '
        'SimpleCalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 117)
        Me.Controls.Add(Me.multiplyButton)
        Me.Controls.Add(Me.subtractButton)
        Me.Controls.Add(Me.divideButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.secondNumberTextBox)
        Me.Controls.Add(Me.firstNumberTextBox)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.outputLabel)
        Me.Controls.Add(Me.secondNumberLabel)
        Me.Controls.Add(Me.firstNumberLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SimpleCalculatorForm"
        Me.Text = "Simple Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents firstNumberLabel As System.Windows.Forms.Label
   Friend WithEvents secondNumberLabel As System.Windows.Forms.Label
   Friend WithEvents outputLabel As System.Windows.Forms.Label
   Friend WithEvents resultLabel As System.Windows.Forms.Label
   Friend WithEvents firstNumberTextBox As System.Windows.Forms.TextBox
   Friend WithEvents secondNumberTextBox As System.Windows.Forms.TextBox
   Friend WithEvents addButton As System.Windows.Forms.Button
   Friend WithEvents divideButton As System.Windows.Forms.Button
   Friend WithEvents subtractButton As System.Windows.Forms.Button
   Friend WithEvents multiplyButton As System.Windows.Forms.Button

End Class
