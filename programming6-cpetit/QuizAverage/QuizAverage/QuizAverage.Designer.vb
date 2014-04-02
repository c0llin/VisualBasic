<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuizAverageForm
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
        Me.scoreLabel = New System.Windows.Forms.Label()
        Me.numberLabel = New System.Windows.Forms.Label()
        Me.averageLabel = New System.Windows.Forms.Label()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.scoreTextBox = New System.Windows.Forms.TextBox()
        Me.numberResultLabel = New System.Windows.Forms.Label()
        Me.averageResultLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'scoreLabel
        '
        Me.scoreLabel.AutoSize = True
        Me.scoreLabel.Location = New System.Drawing.Point(14, 20)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(65, 15)
        Me.scoreLabel.TabIndex = 0
        Me.scoreLabel.Text = "Quiz score:"
        '
        'numberLabel
        '
        Me.numberLabel.AutoSize = True
        Me.numberLabel.Location = New System.Drawing.Point(14, 64)
        Me.numberLabel.Name = "numberLabel"
        Me.numberLabel.Size = New System.Drawing.Size(86, 15)
        Me.numberLabel.TabIndex = 1
        Me.numberLabel.Text = "Number taken:"
        '
        'averageLabel
        '
        Me.averageLabel.AutoSize = True
        Me.averageLabel.Location = New System.Drawing.Point(169, 64)
        Me.averageLabel.Name = "averageLabel"
        Me.averageLabel.Size = New System.Drawing.Size(53, 15)
        Me.averageLabel.TabIndex = 2
        Me.averageLabel.Text = "Average:"
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(172, 16)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(95, 23)
        Me.submitButton.TabIndex = 3
        Me.submitButton.Text = "Submit Score"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'scoreTextBox
        '
        Me.scoreTextBox.Location = New System.Drawing.Point(107, 16)
        Me.scoreTextBox.Name = "scoreTextBox"
        Me.scoreTextBox.Size = New System.Drawing.Size(39, 23)
        Me.scoreTextBox.TabIndex = 4
        '
        'numberResultLabel
        '
        Me.numberResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.numberResultLabel.Location = New System.Drawing.Point(107, 60)
        Me.numberResultLabel.Name = "numberResultLabel"
        Me.numberResultLabel.Size = New System.Drawing.Size(39, 23)
        Me.numberResultLabel.TabIndex = 5
        Me.numberResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'averageResultLabel
        '
        Me.averageResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.averageResultLabel.Location = New System.Drawing.Point(228, 60)
        Me.averageResultLabel.Name = "averageResultLabel"
        Me.averageResultLabel.Size = New System.Drawing.Size(39, 23)
        Me.averageResultLabel.TabIndex = 6
        Me.averageResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QuizAverageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 97)
        Me.Controls.Add(Me.averageResultLabel)
        Me.Controls.Add(Me.numberResultLabel)
        Me.Controls.Add(Me.scoreTextBox)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.averageLabel)
        Me.Controls.Add(Me.numberLabel)
        Me.Controls.Add(Me.scoreLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "QuizAverageForm"
        Me.Text = "Quiz Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents scoreLabel As System.Windows.Forms.Label
   Friend WithEvents numberLabel As System.Windows.Forms.Label
   Friend WithEvents averageLabel As System.Windows.Forms.Label
   Friend WithEvents submitButton As System.Windows.Forms.Button
   Friend WithEvents scoreTextBox As System.Windows.Forms.TextBox
   Friend WithEvents numberResultLabel As System.Windows.Forms.Label
   Friend WithEvents averageResultLabel As System.Windows.Forms.Label

End Class
