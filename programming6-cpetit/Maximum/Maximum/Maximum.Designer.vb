<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaximumForm
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
      Me.firstLabel = New System.Windows.Forms.Label
      Me.secondLabel = New System.Windows.Forms.Label
      Me.thirdLabel = New System.Windows.Forms.Label
      Me.maximumLabel = New System.Windows.Forms.Label
      Me.firstTextBox = New System.Windows.Forms.TextBox
      Me.secondTextBox = New System.Windows.Forms.TextBox
      Me.thirdTextBox = New System.Windows.Forms.TextBox
      Me.outputLabel = New System.Windows.Forms.Label
      Me.maximumButton = New System.Windows.Forms.Button
      Me.SuspendLayout()
      '
      'firstLabel
      '
      Me.firstLabel.AutoSize = True
      Me.firstLabel.Location = New System.Drawing.Point(13, 16)
      Me.firstLabel.Name = "firstLabel"
      Me.firstLabel.Size = New System.Drawing.Size(91, 15)
      Me.firstLabel.TabIndex = 0
      Me.firstLabel.Text = "Enter first value:"
      '
      'secondLabel
      '
      Me.secondLabel.AutoSize = True
      Me.secondLabel.Location = New System.Drawing.Point(13, 52)
      Me.secondLabel.Name = "secondLabel"
      Me.secondLabel.Size = New System.Drawing.Size(109, 15)
      Me.secondLabel.TabIndex = 1
      Me.secondLabel.Text = "Enter second value:"
      '
      'thirdLabel
      '
      Me.thirdLabel.AutoSize = True
      Me.thirdLabel.Location = New System.Drawing.Point(13, 88)
      Me.thirdLabel.Name = "thirdLabel"
      Me.thirdLabel.Size = New System.Drawing.Size(96, 15)
      Me.thirdLabel.TabIndex = 2
      Me.thirdLabel.Text = "Enter third value:"
      '
      'maximumLabel
      '
      Me.maximumLabel.AutoSize = True
      Me.maximumLabel.Location = New System.Drawing.Point(13, 141)
      Me.maximumLabel.Name = "maximumLabel"
      Me.maximumLabel.Size = New System.Drawing.Size(64, 15)
      Me.maximumLabel.TabIndex = 3
      Me.maximumLabel.Text = "Maximum:"
      '
      'firstTextBox
      '
      Me.firstTextBox.Location = New System.Drawing.Point(129, 13)
      Me.firstTextBox.Name = "firstTextBox"
      Me.firstTextBox.Size = New System.Drawing.Size(75, 23)
      Me.firstTextBox.TabIndex = 4
      Me.firstTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'secondTextBox
      '
      Me.secondTextBox.Location = New System.Drawing.Point(129, 49)
      Me.secondTextBox.Name = "secondTextBox"
      Me.secondTextBox.Size = New System.Drawing.Size(75, 23)
      Me.secondTextBox.TabIndex = 5
      Me.secondTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'thirdTextBox
      '
      Me.thirdTextBox.Location = New System.Drawing.Point(129, 85)
      Me.thirdTextBox.Name = "thirdTextBox"
      Me.thirdTextBox.Size = New System.Drawing.Size(75, 23)
      Me.thirdTextBox.TabIndex = 6
      Me.thirdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'outputLabel
      '
      Me.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.outputLabel.Location = New System.Drawing.Point(129, 137)
      Me.outputLabel.Name = "outputLabel"
      Me.outputLabel.Size = New System.Drawing.Size(75, 23)
      Me.outputLabel.TabIndex = 7
      Me.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'maximumButton
      '
      Me.maximumButton.Location = New System.Drawing.Point(129, 174)
      Me.maximumButton.Name = "maximumButton"
      Me.maximumButton.Size = New System.Drawing.Size(75, 23)
      Me.maximumButton.TabIndex = 8
      Me.maximumButton.Text = "Maximum"
      Me.maximumButton.UseVisualStyleBackColor = True
      '
      'MaximumForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(219, 208)
      Me.Controls.Add(Me.maximumButton)
      Me.Controls.Add(Me.outputLabel)
      Me.Controls.Add(Me.thirdTextBox)
      Me.Controls.Add(Me.secondTextBox)
      Me.Controls.Add(Me.firstTextBox)
      Me.Controls.Add(Me.maximumLabel)
      Me.Controls.Add(Me.thirdLabel)
      Me.Controls.Add(Me.secondLabel)
      Me.Controls.Add(Me.firstLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "MaximumForm"
      Me.Text = "Maximum"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents firstLabel As System.Windows.Forms.Label
   Friend WithEvents secondLabel As System.Windows.Forms.Label
   Friend WithEvents thirdLabel As System.Windows.Forms.Label
   Friend WithEvents maximumLabel As System.Windows.Forms.Label
   Friend WithEvents firstTextBox As System.Windows.Forms.TextBox
   Friend WithEvents secondTextBox As System.Windows.Forms.TextBox
   Friend WithEvents thirdTextBox As System.Windows.Forms.TextBox
   Friend WithEvents outputLabel As System.Windows.Forms.Label
   Friend WithEvents maximumButton As System.Windows.Forms.Button

End Class
