<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PresentValueForm
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
        Me.rateTextBox = New System.Windows.Forms.TextBox()
        Me.futureValueTextBox = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.yearlyAccountLabel = New System.Windows.Forms.Label()
        Me.yearsLabel = New System.Windows.Forms.Label()
        Me.interestLabel = New System.Windows.Forms.Label()
        Me.futureValueLabel = New System.Windows.Forms.Label()
        Me.yearUpDown = New System.Windows.Forms.NumericUpDown()
        Me.resultTextBox = New System.Windows.Forms.TextBox()
        CType(Me.yearUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rateTextBox
        '
        Me.rateTextBox.Location = New System.Drawing.Point(94, 48)
        Me.rateTextBox.Name = "rateTextBox"
        Me.rateTextBox.Size = New System.Drawing.Size(100, 23)
        Me.rateTextBox.TabIndex = 1
        Me.rateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'futureValueTextBox
        '
        Me.futureValueTextBox.Location = New System.Drawing.Point(94, 14)
        Me.futureValueTextBox.Name = "futureValueTextBox"
        Me.futureValueTextBox.Size = New System.Drawing.Size(100, 23)
        Me.futureValueTextBox.TabIndex = 0
        Me.futureValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(215, 14)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 3
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'yearlyAccountLabel
        '
        Me.yearlyAccountLabel.AutoSize = True
        Me.yearlyAccountLabel.Location = New System.Drawing.Point(13, 122)
        Me.yearlyAccountLabel.Name = "yearlyAccountLabel"
        Me.yearlyAccountLabel.Size = New System.Drawing.Size(135, 15)
        Me.yearlyAccountLabel.TabIndex = 6
        Me.yearlyAccountLabel.Text = "Annual amount needed:"
        Me.yearlyAccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'yearsLabel
        '
        Me.yearsLabel.AutoSize = True
        Me.yearsLabel.Location = New System.Drawing.Point(13, 84)
        Me.yearsLabel.Name = "yearsLabel"
        Me.yearsLabel.Size = New System.Drawing.Size(38, 15)
        Me.yearsLabel.TabIndex = 5
        Me.yearsLabel.Text = "Years:"
        Me.yearsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'interestLabel
        '
        Me.interestLabel.AutoSize = True
        Me.interestLabel.Location = New System.Drawing.Point(13, 51)
        Me.interestLabel.Name = "interestLabel"
        Me.interestLabel.Size = New System.Drawing.Size(72, 15)
        Me.interestLabel.TabIndex = 4
        Me.interestLabel.Text = "Interest rate:"
        Me.interestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'futureValueLabel
        '
        Me.futureValueLabel.AutoSize = True
        Me.futureValueLabel.Location = New System.Drawing.Point(13, 17)
        Me.futureValueLabel.Name = "futureValueLabel"
        Me.futureValueLabel.Size = New System.Drawing.Size(75, 15)
        Me.futureValueLabel.TabIndex = 2
        Me.futureValueLabel.Text = "Future value:"
        Me.futureValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'yearUpDown
        '
        Me.yearUpDown.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.yearUpDown.Location = New System.Drawing.Point(94, 84)
        Me.yearUpDown.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.yearUpDown.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.yearUpDown.Name = "yearUpDown"
        Me.yearUpDown.ReadOnly = True
        Me.yearUpDown.Size = New System.Drawing.Size(100, 23)
        Me.yearUpDown.TabIndex = 7
        Me.yearUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.yearUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'resultTextBox
        '
        Me.resultTextBox.Location = New System.Drawing.Point(16, 141)
        Me.resultTextBox.Multiline = True
        Me.resultTextBox.Name = "resultTextBox"
        Me.resultTextBox.ReadOnly = True
        Me.resultTextBox.Size = New System.Drawing.Size(274, 96)
        Me.resultTextBox.TabIndex = 8
        '
        'PresentValueForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 249)
        Me.Controls.Add(Me.resultTextBox)
        Me.Controls.Add(Me.yearUpDown)
        Me.Controls.Add(Me.rateTextBox)
        Me.Controls.Add(Me.futureValueTextBox)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.yearlyAccountLabel)
        Me.Controls.Add(Me.yearsLabel)
        Me.Controls.Add(Me.interestLabel)
        Me.Controls.Add(Me.futureValueLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PresentValueForm"
        Me.Text = "Present Value Calculator"
        CType(Me.yearUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents rateTextBox As System.Windows.Forms.TextBox
   Friend WithEvents futureValueTextBox As System.Windows.Forms.TextBox
   Friend WithEvents calculateButton As System.Windows.Forms.Button
   Friend WithEvents yearlyAccountLabel As System.Windows.Forms.Label
   Friend WithEvents yearsLabel As System.Windows.Forms.Label
   Friend WithEvents interestLabel As System.Windows.Forms.Label
    Friend WithEvents futureValueLabel As System.Windows.Forms.Label
    Friend WithEvents yearUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents resultTextBox As System.Windows.Forms.TextBox

End Class
