<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuessNumberForm
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
        Me.questionLabel = New System.Windows.Forms.Label()
        Me.guessLabel = New System.Windows.Forms.Label()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.newGameButton = New System.Windows.Forms.Button()
        Me.guessTextBox = New System.Windows.Forms.TextBox()
        Me.outputLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'questionLabel
        '
        Me.questionLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionLabel.Location = New System.Drawing.Point(20, 14)
        Me.questionLabel.Name = "questionLabel"
        Me.questionLabel.Size = New System.Drawing.Size(224, 41)
        Me.questionLabel.TabIndex = 3
        Me.questionLabel.Text = "I have a number between 1 and 100. Can you guess my number?"
        Me.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'guessLabel
        '
        Me.guessLabel.AutoSize = True
        Me.guessLabel.Location = New System.Drawing.Point(20, 82)
        Me.guessLabel.Name = "guessLabel"
        Me.guessLabel.Size = New System.Drawing.Size(41, 15)
        Me.guessLabel.TabIndex = 4
        Me.guessLabel.Text = "Guess:"
        '
        'resultLabel
        '
        Me.resultLabel.AutoSize = True
        Me.resultLabel.Location = New System.Drawing.Point(20, 122)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(42, 15)
        Me.resultLabel.TabIndex = 5
        Me.resultLabel.Text = "Result:"
        '
        'enterButton
        '
        Me.enterButton.Location = New System.Drawing.Point(169, 79)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(75, 23)
        Me.enterButton.TabIndex = 1
        Me.enterButton.Text = "Enter"
        Me.enterButton.UseVisualStyleBackColor = True
        '
        'newGameButton
        '
        Me.newGameButton.Enabled = False
        Me.newGameButton.Location = New System.Drawing.Point(169, 118)
        Me.newGameButton.Name = "newGameButton"
        Me.newGameButton.Size = New System.Drawing.Size(75, 23)
        Me.newGameButton.TabIndex = 2
        Me.newGameButton.Text = "New Game"
        Me.newGameButton.UseVisualStyleBackColor = True
        '
        'guessTextBox
        '
        Me.guessTextBox.Location = New System.Drawing.Point(68, 79)
        Me.guessTextBox.Name = "guessTextBox"
        Me.guessTextBox.Size = New System.Drawing.Size(87, 23)
        Me.guessTextBox.TabIndex = 0
        Me.guessTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'outputLabel
        '
        Me.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outputLabel.Location = New System.Drawing.Point(68, 118)
        Me.outputLabel.Name = "outputLabel"
        Me.outputLabel.Size = New System.Drawing.Size(87, 23)
        Me.outputLabel.TabIndex = 6
        Me.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GuessNumberForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 152)
        Me.Controls.Add(Me.outputLabel)
        Me.Controls.Add(Me.guessTextBox)
        Me.Controls.Add(Me.newGameButton)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.guessLabel)
        Me.Controls.Add(Me.questionLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "GuessNumberForm"
        Me.Text = "Guess the Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents questionLabel As System.Windows.Forms.Label
   Friend WithEvents guessLabel As System.Windows.Forms.Label
   Friend WithEvents resultLabel As System.Windows.Forms.Label
   Friend WithEvents enterButton As System.Windows.Forms.Button
   Friend WithEvents newGameButton As System.Windows.Forms.Button
   Friend WithEvents guessTextBox As System.Windows.Forms.TextBox
   Friend WithEvents outputLabel As System.Windows.Forms.Label

End Class
