<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LotteryPickerForm
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
        Me.threeLabel = New System.Windows.Forms.Label()
        Me.fourLabel = New System.Windows.Forms.Label()
        Me.fiveLabel = New System.Windows.Forms.Label()
        Me.fivePlusOneLabel = New System.Windows.Forms.Label()
        Me.output5Plus1Label = New System.Windows.Forms.Label()
        Me.outputExtra1Label = New System.Windows.Forms.Label()
        Me.output5Label = New System.Windows.Forms.Label()
        Me.output4Label = New System.Windows.Forms.Label()
        Me.output3Label = New System.Windows.Forms.Label()
        Me.generateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'threeLabel
        '
        Me.threeLabel.AutoSize = True
        Me.threeLabel.Location = New System.Drawing.Point(14, 17)
        Me.threeLabel.Name = "threeLabel"
        Me.threeLabel.Size = New System.Drawing.Size(122, 15)
        Me.threeLabel.TabIndex = 1
        Me.threeLabel.Text = "Three number lottery:"
        '
        'fourLabel
        '
        Me.fourLabel.AutoSize = True
        Me.fourLabel.Location = New System.Drawing.Point(14, 53)
        Me.fourLabel.Name = "fourLabel"
        Me.fourLabel.Size = New System.Drawing.Size(116, 15)
        Me.fourLabel.TabIndex = 2
        Me.fourLabel.Text = "Four number lottery:"
        '
        'fiveLabel
        '
        Me.fiveLabel.AutoSize = True
        Me.fiveLabel.Location = New System.Drawing.Point(14, 89)
        Me.fiveLabel.Name = "fiveLabel"
        Me.fiveLabel.Size = New System.Drawing.Size(113, 15)
        Me.fiveLabel.TabIndex = 3
        Me.fiveLabel.Text = "Five number lottery:"
        '
        'fivePlusOneLabel
        '
        Me.fivePlusOneLabel.AutoSize = True
        Me.fivePlusOneLabel.Location = New System.Drawing.Point(14, 125)
        Me.fivePlusOneLabel.Name = "fivePlusOneLabel"
        Me.fivePlusOneLabel.Size = New System.Drawing.Size(133, 15)
        Me.fivePlusOneLabel.TabIndex = 4
        Me.fivePlusOneLabel.Text = "Five number + 1 lottery:"
        '
        'output5Plus1Label
        '
        Me.output5Plus1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.output5Plus1Label.Location = New System.Drawing.Point(154, 121)
        Me.output5Plus1Label.Name = "output5Plus1Label"
        Me.output5Plus1Label.Size = New System.Drawing.Size(100, 23)
        Me.output5Plus1Label.TabIndex = 8
        Me.output5Plus1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'outputExtra1Label
        '
        Me.outputExtra1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outputExtra1Label.ForeColor = System.Drawing.Color.Red
        Me.outputExtra1Label.Location = New System.Drawing.Point(260, 121)
        Me.outputExtra1Label.Name = "outputExtra1Label"
        Me.outputExtra1Label.Size = New System.Drawing.Size(31, 23)
        Me.outputExtra1Label.TabIndex = 9
        Me.outputExtra1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'output5Label
        '
        Me.output5Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.output5Label.Location = New System.Drawing.Point(154, 85)
        Me.output5Label.Name = "output5Label"
        Me.output5Label.Size = New System.Drawing.Size(137, 23)
        Me.output5Label.TabIndex = 7
        Me.output5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'output4Label
        '
        Me.output4Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.output4Label.Location = New System.Drawing.Point(154, 49)
        Me.output4Label.Name = "output4Label"
        Me.output4Label.Size = New System.Drawing.Size(137, 23)
        Me.output4Label.TabIndex = 6
        Me.output4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'output3Label
        '
        Me.output3Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.output3Label.Location = New System.Drawing.Point(154, 13)
        Me.output3Label.Name = "output3Label"
        Me.output3Label.Size = New System.Drawing.Size(137, 23)
        Me.output3Label.TabIndex = 5
        Me.output3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'generateButton
        '
        Me.generateButton.Location = New System.Drawing.Point(200, 159)
        Me.generateButton.Name = "generateButton"
        Me.generateButton.Size = New System.Drawing.Size(91, 23)
        Me.generateButton.TabIndex = 0
        Me.generateButton.Text = "Generate"
        Me.generateButton.UseVisualStyleBackColor = True
        '
        'LotteryPickerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 191)
        Me.Controls.Add(Me.generateButton)
        Me.Controls.Add(Me.output3Label)
        Me.Controls.Add(Me.output4Label)
        Me.Controls.Add(Me.output5Label)
        Me.Controls.Add(Me.outputExtra1Label)
        Me.Controls.Add(Me.output5Plus1Label)
        Me.Controls.Add(Me.fivePlusOneLabel)
        Me.Controls.Add(Me.fiveLabel)
        Me.Controls.Add(Me.fourLabel)
        Me.Controls.Add(Me.threeLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "LotteryPickerForm"
        Me.Text = "Lottery Picker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents threeLabel As System.Windows.Forms.Label
   Friend WithEvents fourLabel As System.Windows.Forms.Label
   Friend WithEvents fiveLabel As System.Windows.Forms.Label
   Friend WithEvents fivePlusOneLabel As System.Windows.Forms.Label
   Friend WithEvents output5Plus1Label As System.Windows.Forms.Label
   Friend WithEvents outputExtra1Label As System.Windows.Forms.Label
   Friend WithEvents output5Label As System.Windows.Forms.Label
   Friend WithEvents output4Label As System.Windows.Forms.Label
   Friend WithEvents output3Label As System.Windows.Forms.Label
   Friend WithEvents generateButton As System.Windows.Forms.Button

End Class
