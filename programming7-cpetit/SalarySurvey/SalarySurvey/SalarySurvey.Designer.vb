<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalarySurveyForm
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
        Me.salesLabel = New System.Windows.Forms.Label()
        Me.inputSalesTextBox = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.totalsButton = New System.Windows.Forms.Button()
        Me.totalSalaryLabel = New System.Windows.Forms.Label()
        Me.surveyResultsLabel = New System.Windows.Forms.Label()
        Me.salaryTotalsListBox = New System.Windows.Forms.ListBox()
        Me.totalSalaryValueLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'salesLabel
        '
        Me.salesLabel.AutoSize = True
        Me.salesLabel.Location = New System.Drawing.Point(14, 16)
        Me.salesLabel.Name = "salesLabel"
        Me.salesLabel.Size = New System.Drawing.Size(65, 15)
        Me.salesLabel.TabIndex = 0
        Me.salesLabel.Text = "Enter sales:"
        '
        'inputSalesTextBox
        '
        Me.inputSalesTextBox.Location = New System.Drawing.Point(110, 13)
        Me.inputSalesTextBox.Name = "inputSalesTextBox"
        Me.inputSalesTextBox.Size = New System.Drawing.Size(87, 23)
        Me.inputSalesTextBox.TabIndex = 1
        Me.inputSalesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(110, 78)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(87, 23)
        Me.calculateButton.TabIndex = 2
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'totalsButton
        '
        Me.totalsButton.Location = New System.Drawing.Point(17, 78)
        Me.totalsButton.Name = "totalsButton"
        Me.totalsButton.Size = New System.Drawing.Size(87, 23)
        Me.totalsButton.TabIndex = 3
        Me.totalsButton.Text = "Show Totals"
        Me.totalsButton.UseVisualStyleBackColor = True
        '
        'totalSalaryLabel
        '
        Me.totalSalaryLabel.AutoSize = True
        Me.totalSalaryLabel.Location = New System.Drawing.Point(14, 47)
        Me.totalSalaryLabel.Name = "totalSalaryLabel"
        Me.totalSalaryLabel.Size = New System.Drawing.Size(70, 15)
        Me.totalSalaryLabel.TabIndex = 4
        Me.totalSalaryLabel.Text = "Total salary:"
        '
        'surveyResultsLabel
        '
        Me.surveyResultsLabel.AutoSize = True
        Me.surveyResultsLabel.Location = New System.Drawing.Point(14, 121)
        Me.surveyResultsLabel.Name = "surveyResultsLabel"
        Me.surveyResultsLabel.Size = New System.Drawing.Size(82, 15)
        Me.surveyResultsLabel.TabIndex = 6
        Me.surveyResultsLabel.Text = "Survey results:"
        '
        'salaryTotalsListBox
        '
        Me.salaryTotalsListBox.FormattingEnabled = True
        Me.salaryTotalsListBox.ItemHeight = 15
        Me.salaryTotalsListBox.Location = New System.Drawing.Point(17, 139)
        Me.salaryTotalsListBox.Name = "salaryTotalsListBox"
        Me.salaryTotalsListBox.Size = New System.Drawing.Size(180, 154)
        Me.salaryTotalsListBox.TabIndex = 7
        '
        'totalSalaryValueLabel
        '
        Me.totalSalaryValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalSalaryValueLabel.Location = New System.Drawing.Point(110, 43)
        Me.totalSalaryValueLabel.Name = "totalSalaryValueLabel"
        Me.totalSalaryValueLabel.Size = New System.Drawing.Size(87, 23)
        Me.totalSalaryValueLabel.TabIndex = 8
        Me.totalSalaryValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SalarySurveyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 305)
        Me.Controls.Add(Me.totalSalaryValueLabel)
        Me.Controls.Add(Me.salaryTotalsListBox)
        Me.Controls.Add(Me.surveyResultsLabel)
        Me.Controls.Add(Me.totalSalaryLabel)
        Me.Controls.Add(Me.totalsButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.inputSalesTextBox)
        Me.Controls.Add(Me.salesLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SalarySurveyForm"
        Me.Text = "Salary Survey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents salesLabel As System.Windows.Forms.Label
   Friend WithEvents inputSalesTextBox As System.Windows.Forms.TextBox
   Friend WithEvents calculateButton As System.Windows.Forms.Button
   Friend WithEvents totalsButton As System.Windows.Forms.Button
   Friend WithEvents totalSalaryLabel As System.Windows.Forms.Label
   Friend WithEvents surveyResultsLabel As System.Windows.Forms.Label
   Friend WithEvents salaryTotalsListBox As System.Windows.Forms.ListBox
   Friend WithEvents totalSalaryValueLabel As System.Windows.Forms.Label

End Class
