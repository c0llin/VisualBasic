<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArithmeticCalculatorForm
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
        Me.operandsLabel = New System.Windows.Forms.Label()
        Me.inputLabel = New System.Windows.Forms.Label()
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.multiplyButton = New System.Windows.Forms.Button()
        Me.ouputLabel = New System.Windows.Forms.Label()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'operandsLabel
        '
        Me.operandsLabel.AutoSize = True
        Me.operandsLabel.Location = New System.Drawing.Point(13, 16)
        Me.operandsLabel.Name = "operandsLabel"
        Me.operandsLabel.Size = New System.Drawing.Size(79, 15)
        Me.operandsLabel.TabIndex = 6
        Me.operandsLabel.Text = "Operands list:"
        Me.operandsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'inputLabel
        '
        Me.inputLabel.AutoSize = True
        Me.inputLabel.Location = New System.Drawing.Point(137, 16)
        Me.inputLabel.Name = "inputLabel"
        Me.inputLabel.Size = New System.Drawing.Size(84, 15)
        Me.inputLabel.TabIndex = 7
        Me.inputLabel.Text = "Enter operand:"
        Me.inputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(140, 34)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(81, 23)
        Me.inputTextBox.TabIndex = 0
        Me.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'enterButton
        '
        Me.enterButton.Location = New System.Drawing.Point(140, 63)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(81, 23)
        Me.enterButton.TabIndex = 1
        Me.enterButton.Text = "Enter"
        Me.enterButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Enabled = False
        Me.addButton.Location = New System.Drawing.Point(140, 108)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(81, 23)
        Me.addButton.TabIndex = 2
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'multiplyButton
        '
        Me.multiplyButton.Enabled = False
        Me.multiplyButton.Location = New System.Drawing.Point(140, 137)
        Me.multiplyButton.Name = "multiplyButton"
        Me.multiplyButton.Size = New System.Drawing.Size(81, 23)
        Me.multiplyButton.TabIndex = 3
        Me.multiplyButton.Text = "Multiply"
        Me.multiplyButton.UseVisualStyleBackColor = True
        '
        'ouputLabel
        '
        Me.ouputLabel.AutoSize = True
        Me.ouputLabel.Location = New System.Drawing.Point(137, 180)
        Me.ouputLabel.Name = "ouputLabel"
        Me.ouputLabel.Size = New System.Drawing.Size(42, 15)
        Me.ouputLabel.TabIndex = 4
        Me.ouputLabel.Text = "Result:"
        Me.ouputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'resultLabel
        '
        Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.resultLabel.Location = New System.Drawing.Point(140, 195)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(81, 23)
        Me.resultLabel.TabIndex = 5
        Me.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.ItemHeight = 15
        Me.ListBox.Location = New System.Drawing.Point(9, 34)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(110, 184)
        Me.ListBox.TabIndex = 8
        '
        'ArithmeticCalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 232)
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.ouputLabel)
        Me.Controls.Add(Me.multiplyButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.inputLabel)
        Me.Controls.Add(Me.operandsLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ArithmeticCalculatorForm"
        Me.Text = "Arithmetic Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents operandsLabel As System.Windows.Forms.Label
   Friend WithEvents inputLabel As System.Windows.Forms.Label
   Friend WithEvents inputTextBox As System.Windows.Forms.TextBox
   Friend WithEvents enterButton As System.Windows.Forms.Button
   Friend WithEvents addButton As System.Windows.Forms.Button
   Friend WithEvents multiplyButton As System.Windows.Forms.Button
   Friend WithEvents ouputLabel As System.Windows.Forms.Label
    Friend WithEvents resultLabel As System.Windows.Forms.Label
    Friend WithEvents ListBox As System.Windows.Forms.ListBox

End Class
