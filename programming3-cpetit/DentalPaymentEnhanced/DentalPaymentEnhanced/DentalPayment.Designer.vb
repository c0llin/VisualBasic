<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DentalPaymentForm
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
        Me.xrayCheckBox = New System.Windows.Forms.CheckBox()
        Me.cavityCheckBox = New System.Windows.Forms.CheckBox()
        Me.cleanCheckBox = New System.Windows.Forms.CheckBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.totalResultLabel = New System.Windows.Forms.Label()
        Me.xrayCostLabel = New System.Windows.Forms.Label()
        Me.fillingCostLabel = New System.Windows.Forms.Label()
        Me.cleanCostLabel = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.fluorideCheckBox = New System.Windows.Forms.CheckBox()
        Me.canalCheckBox = New System.Windows.Forms.CheckBox()
        Me.otherCheckBox = New System.Windows.Forms.CheckBox()
        Me.otherTextBox = New System.Windows.Forms.TextBox()
        Me.canalLabel = New System.Windows.Forms.Label()
        Me.fluorideLabel = New System.Windows.Forms.Label()
        Me.dollarsignLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'xrayCheckBox
        '
        Me.xrayCheckBox.Location = New System.Drawing.Point(22, 203)
        Me.xrayCheckBox.Name = "xrayCheckBox"
        Me.xrayCheckBox.Size = New System.Drawing.Size(122, 17)
        Me.xrayCheckBox.TabIndex = 23
        Me.xrayCheckBox.Text = "X-Ray"
        Me.xrayCheckBox.UseVisualStyleBackColor = True
        '
        'cavityCheckBox
        '
        Me.cavityCheckBox.Location = New System.Drawing.Point(22, 158)
        Me.cavityCheckBox.Name = "cavityCheckBox"
        Me.cavityCheckBox.Size = New System.Drawing.Size(122, 17)
        Me.cavityCheckBox.TabIndex = 22
        Me.cavityCheckBox.Text = "Cavity Filling"
        Me.cavityCheckBox.UseVisualStyleBackColor = True
        '
        'cleanCheckBox
        '
        Me.cleanCheckBox.Location = New System.Drawing.Point(22, 113)
        Me.cleanCheckBox.Name = "cleanCheckBox"
        Me.cleanCheckBox.Size = New System.Drawing.Size(122, 17)
        Me.cleanCheckBox.TabIndex = 21
        Me.cleanCheckBox.Text = "Cleaning"
        Me.cleanCheckBox.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(179, 427)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(70, 24)
        Me.calculateButton.TabIndex = 20
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'totalLabel
        '
        Me.totalLabel.Location = New System.Drawing.Point(144, 387)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(41, 21)
        Me.totalLabel.TabIndex = 19
        Me.totalLabel.Text = "Total:"
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'totalResultLabel
        '
        Me.totalResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalResultLabel.Location = New System.Drawing.Point(192, 387)
        Me.totalResultLabel.Name = "totalResultLabel"
        Me.totalResultLabel.Size = New System.Drawing.Size(56, 21)
        Me.totalResultLabel.TabIndex = 18
        Me.totalResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xrayCostLabel
        '
        Me.xrayCostLabel.Location = New System.Drawing.Point(209, 198)
        Me.xrayCostLabel.Name = "xrayCostLabel"
        Me.xrayCostLabel.Size = New System.Drawing.Size(38, 24)
        Me.xrayCostLabel.TabIndex = 17
        Me.xrayCostLabel.Text = "85"
        Me.xrayCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fillingCostLabel
        '
        Me.fillingCostLabel.Location = New System.Drawing.Point(211, 151)
        Me.fillingCostLabel.Name = "fillingCostLabel"
        Me.fillingCostLabel.Size = New System.Drawing.Size(38, 24)
        Me.fillingCostLabel.TabIndex = 16
        Me.fillingCostLabel.Text = "150"
        Me.fillingCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cleanCostLabel
        '
        Me.cleanCostLabel.Location = New System.Drawing.Point(211, 105)
        Me.cleanCostLabel.Name = "cleanCostLabel"
        Me.cleanCostLabel.Size = New System.Drawing.Size(38, 24)
        Me.cleanCostLabel.TabIndex = 15
        Me.cleanCostLabel.Text = "35"
        Me.cleanCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(132, 65)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(117, 20)
        Me.nameTextBox.TabIndex = 14
        '
        'nameLabel
        '
        Me.nameLabel.Location = New System.Drawing.Point(19, 65)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(91, 21)
        Me.nameLabel.TabIndex = 13
        Me.nameLabel.Text = "Patient name:"
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'titleLabel
        '
        Me.titleLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(19, 19)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(235, 28)
        Me.titleLabel.TabIndex = 12
        Me.titleLabel.Text = "Dental Payment Form"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fluorideCheckBox
        '
        Me.fluorideCheckBox.AutoSize = True
        Me.fluorideCheckBox.Location = New System.Drawing.Point(22, 248)
        Me.fluorideCheckBox.Name = "fluorideCheckBox"
        Me.fluorideCheckBox.Size = New System.Drawing.Size(63, 17)
        Me.fluorideCheckBox.TabIndex = 24
        Me.fluorideCheckBox.Text = "Fluoride"
        Me.fluorideCheckBox.UseVisualStyleBackColor = True
        '
        'canalCheckBox
        '
        Me.canalCheckBox.AutoSize = True
        Me.canalCheckBox.Location = New System.Drawing.Point(22, 293)
        Me.canalCheckBox.Name = "canalCheckBox"
        Me.canalCheckBox.Size = New System.Drawing.Size(79, 17)
        Me.canalCheckBox.TabIndex = 25
        Me.canalCheckBox.Text = "Root Canal"
        Me.canalCheckBox.UseVisualStyleBackColor = True
        '
        'otherCheckBox
        '
        Me.otherCheckBox.AutoSize = True
        Me.otherCheckBox.Location = New System.Drawing.Point(22, 338)
        Me.otherCheckBox.Name = "otherCheckBox"
        Me.otherCheckBox.Size = New System.Drawing.Size(52, 17)
        Me.otherCheckBox.TabIndex = 26
        Me.otherCheckBox.Text = "Other"
        Me.otherCheckBox.UseVisualStyleBackColor = True
        '
        'otherTextBox
        '
        Me.otherTextBox.Location = New System.Drawing.Point(212, 336)
        Me.otherTextBox.Name = "otherTextBox"
        Me.otherTextBox.Size = New System.Drawing.Size(36, 20)
        Me.otherTextBox.TabIndex = 27
        '
        'canalLabel
        '
        Me.canalLabel.AutoSize = True
        Me.canalLabel.Location = New System.Drawing.Point(222, 294)
        Me.canalLabel.Name = "canalLabel"
        Me.canalLabel.Size = New System.Drawing.Size(25, 13)
        Me.canalLabel.TabIndex = 28
        Me.canalLabel.Text = "800"
        Me.canalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fluorideLabel
        '
        Me.fluorideLabel.AutoSize = True
        Me.fluorideLabel.Location = New System.Drawing.Point(228, 249)
        Me.fluorideLabel.Name = "fluorideLabel"
        Me.fluorideLabel.Size = New System.Drawing.Size(19, 13)
        Me.fluorideLabel.TabIndex = 29
        Me.fluorideLabel.Text = "50"
        Me.fluorideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dollarsignLabel
        '
        Me.dollarsignLabel.AutoSize = True
        Me.dollarsignLabel.Location = New System.Drawing.Point(193, 339)
        Me.dollarsignLabel.Name = "dollarsignLabel"
        Me.dollarsignLabel.Size = New System.Drawing.Size(13, 13)
        Me.dollarsignLabel.TabIndex = 30
        Me.dollarsignLabel.Text = "$"
        Me.dollarsignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DentalPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 463)
        Me.Controls.Add(Me.dollarsignLabel)
        Me.Controls.Add(Me.fluorideLabel)
        Me.Controls.Add(Me.canalLabel)
        Me.Controls.Add(Me.otherTextBox)
        Me.Controls.Add(Me.otherCheckBox)
        Me.Controls.Add(Me.canalCheckBox)
        Me.Controls.Add(Me.fluorideCheckBox)
        Me.Controls.Add(Me.xrayCheckBox)
        Me.Controls.Add(Me.cavityCheckBox)
        Me.Controls.Add(Me.cleanCheckBox)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.totalResultLabel)
        Me.Controls.Add(Me.xrayCostLabel)
        Me.Controls.Add(Me.fillingCostLabel)
        Me.Controls.Add(Me.cleanCostLabel)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Name = "DentalPaymentForm"
        Me.Text = "Dental Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents xrayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents cavityCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents cleanCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents totalResultLabel As System.Windows.Forms.Label
    Friend WithEvents xrayCostLabel As System.Windows.Forms.Label
    Friend WithEvents fillingCostLabel As System.Windows.Forms.Label
    Friend WithEvents cleanCostLabel As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents titleLabel As System.Windows.Forms.Label
    Friend WithEvents fluorideCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents canalCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents otherCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents otherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents canalLabel As System.Windows.Forms.Label
    Friend WithEvents fluorideLabel As System.Windows.Forms.Label
    Friend WithEvents dollarsignLabel As System.Windows.Forms.Label

End Class
