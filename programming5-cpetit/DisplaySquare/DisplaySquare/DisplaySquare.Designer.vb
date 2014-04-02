<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplaySquareForm
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
        Me.sizeLabel = New System.Windows.Forms.Label()
        Me.fillLabel = New System.Windows.Forms.Label()
        Me.sizeTextBox = New System.Windows.Forms.TextBox()
        Me.fillTextBox = New System.Windows.Forms.TextBox()
        Me.displaySquareButton = New System.Windows.Forms.Button()
        Me.outputTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'sizeLabel
        '
        Me.sizeLabel.AutoSize = True
        Me.sizeLabel.Location = New System.Drawing.Point(12, 16)
        Me.sizeLabel.Name = "sizeLabel"
        Me.sizeLabel.Size = New System.Drawing.Size(68, 15)
        Me.sizeLabel.TabIndex = 0
        Me.sizeLabel.Text = "Square size:"
        '
        'fillLabel
        '
        Me.fillLabel.AutoSize = True
        Me.fillLabel.Location = New System.Drawing.Point(12, 51)
        Me.fillLabel.Name = "fillLabel"
        Me.fillLabel.Size = New System.Drawing.Size(77, 15)
        Me.fillLabel.TabIndex = 1
        Me.fillLabel.Text = "Fill character:"
        '
        'sizeTextBox
        '
        Me.sizeTextBox.Location = New System.Drawing.Point(96, 13)
        Me.sizeTextBox.Name = "sizeTextBox"
        Me.sizeTextBox.Size = New System.Drawing.Size(25, 23)
        Me.sizeTextBox.TabIndex = 2
        Me.sizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fillTextBox
        '
        Me.fillTextBox.Location = New System.Drawing.Point(96, 48)
        Me.fillTextBox.Name = "fillTextBox"
        Me.fillTextBox.Size = New System.Drawing.Size(25, 23)
        Me.fillTextBox.TabIndex = 3
        Me.fillTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'displaySquareButton
        '
        Me.displaySquareButton.Location = New System.Drawing.Point(142, 13)
        Me.displaySquareButton.Name = "displaySquareButton"
        Me.displaySquareButton.Size = New System.Drawing.Size(106, 23)
        Me.displaySquareButton.TabIndex = 4
        Me.displaySquareButton.Text = "Display Square"
        Me.displaySquareButton.UseVisualStyleBackColor = True
        '
        'outputTextBox
        '
        Me.outputTextBox.Location = New System.Drawing.Point(16, 87)
        Me.outputTextBox.Multiline = True
        Me.outputTextBox.Name = "outputTextBox"
        Me.outputTextBox.ReadOnly = True
        Me.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.outputTextBox.Size = New System.Drawing.Size(232, 133)
        Me.outputTextBox.TabIndex = 5
        Me.outputTextBox.WordWrap = False
        '
        'DisplaySquareForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 230)
        Me.Controls.Add(Me.outputTextBox)
        Me.Controls.Add(Me.displaySquareButton)
        Me.Controls.Add(Me.fillTextBox)
        Me.Controls.Add(Me.sizeTextBox)
        Me.Controls.Add(Me.fillLabel)
        Me.Controls.Add(Me.sizeLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DisplaySquareForm"
        Me.Text = "Display Square"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents sizeLabel As System.Windows.Forms.Label
   Friend WithEvents fillLabel As System.Windows.Forms.Label
   Friend WithEvents sizeTextBox As System.Windows.Forms.TextBox
   Friend WithEvents fillTextBox As System.Windows.Forms.TextBox
   Friend WithEvents displaySquareButton As System.Windows.Forms.Button
   Friend WithEvents outputTextBox As System.Windows.Forms.TextBox

End Class
