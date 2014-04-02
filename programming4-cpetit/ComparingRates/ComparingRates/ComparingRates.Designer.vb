<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComparingRatesForm
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
        Me.principalLabel = New System.Windows.Forms.Label()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.principalTextBox = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.displayTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'principalLabel
        '
        Me.principalLabel.AutoSize = True
        Me.principalLabel.Location = New System.Drawing.Point(12, 18)
        Me.principalLabel.Name = "principalLabel"
        Me.principalLabel.Size = New System.Drawing.Size(56, 15)
        Me.principalLabel.TabIndex = 0
        Me.principalLabel.Text = "Principal:"
        Me.principalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'resultLabel
        '
        Me.resultLabel.AutoSize = True
        Me.resultLabel.Location = New System.Drawing.Point(12, 51)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(42, 15)
        Me.resultLabel.TabIndex = 1
        Me.resultLabel.Text = "Result:"
        Me.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'principalTextBox
        '
        Me.principalTextBox.Location = New System.Drawing.Point(75, 15)
        Me.principalTextBox.Name = "principalTextBox"
        Me.principalTextBox.Size = New System.Drawing.Size(100, 23)
        Me.principalTextBox.TabIndex = 2
        Me.principalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(199, 15)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 3
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'displayTextBox
        '
        Me.displayTextBox.Location = New System.Drawing.Point(13, 70)
        Me.displayTextBox.Multiline = True
        Me.displayTextBox.Name = "displayTextBox"
        Me.displayTextBox.Size = New System.Drawing.Size(261, 116)
        Me.displayTextBox.TabIndex = 4
        '
        'ComparingRatesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 198)
        Me.Controls.Add(Me.displayTextBox)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.principalTextBox)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.principalLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ComparingRatesForm"
        Me.Text = "Comparing Rates"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents principalLabel As System.Windows.Forms.Label
   Friend WithEvents resultLabel As System.Windows.Forms.Label
   Friend WithEvents principalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents displayTextBox As System.Windows.Forms.TextBox

End Class
