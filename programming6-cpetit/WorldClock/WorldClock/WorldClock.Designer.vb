<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorldClockForm
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
        Me.components = New System.ComponentModel.Container()
        Me.laLabel = New System.Windows.Forms.Label()
        Me.atlantaLabel = New System.Windows.Forms.Label()
        Me.londonLabel = New System.Windows.Forms.Label()
        Me.tokyoLabel = New System.Windows.Forms.Label()
        Me.laTimeLabel = New System.Windows.Forms.Label()
        Me.atlantaTimeLabel = New System.Windows.Forms.Label()
        Me.londonTimeLabel = New System.Windows.Forms.Label()
        Me.tokyoTimeLabel = New System.Windows.Forms.Label()
        Me.clockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'laLabel
        '
        Me.laLabel.AutoSize = True
        Me.laLabel.Location = New System.Drawing.Point(14, 24)
        Me.laLabel.Name = "laLabel"
        Me.laLabel.Size = New System.Drawing.Size(73, 15)
        Me.laLabel.TabIndex = 0
        Me.laLabel.Text = "Los Angeles:"
        '
        'atlantaLabel
        '
        Me.atlantaLabel.AutoSize = True
        Me.atlantaLabel.Location = New System.Drawing.Point(14, 60)
        Me.atlantaLabel.Name = "atlantaLabel"
        Me.atlantaLabel.Size = New System.Drawing.Size(48, 15)
        Me.atlantaLabel.TabIndex = 1
        Me.atlantaLabel.Text = "Atlanta:"
        '
        'londonLabel
        '
        Me.londonLabel.AutoSize = True
        Me.londonLabel.Location = New System.Drawing.Point(14, 96)
        Me.londonLabel.Name = "londonLabel"
        Me.londonLabel.Size = New System.Drawing.Size(51, 15)
        Me.londonLabel.TabIndex = 2
        Me.londonLabel.Text = "London:"
        '
        'tokyoLabel
        '
        Me.tokyoLabel.AutoSize = True
        Me.tokyoLabel.Location = New System.Drawing.Point(14, 134)
        Me.tokyoLabel.Name = "tokyoLabel"
        Me.tokyoLabel.Size = New System.Drawing.Size(43, 15)
        Me.tokyoLabel.TabIndex = 3
        Me.tokyoLabel.Text = "Tokyo:"
        '
        'laTimeLabel
        '
        Me.laTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.laTimeLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.laTimeLabel.Location = New System.Drawing.Point(97, 17)
        Me.laTimeLabel.Name = "laTimeLabel"
        Me.laTimeLabel.Size = New System.Drawing.Size(187, 25)
        Me.laTimeLabel.TabIndex = 4
        Me.laTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'atlantaTimeLabel
        '
        Me.atlantaTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.atlantaTimeLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atlantaTimeLabel.Location = New System.Drawing.Point(97, 53)
        Me.atlantaTimeLabel.Name = "atlantaTimeLabel"
        Me.atlantaTimeLabel.Size = New System.Drawing.Size(187, 25)
        Me.atlantaTimeLabel.TabIndex = 5
        Me.atlantaTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'londonTimeLabel
        '
        Me.londonTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.londonTimeLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.londonTimeLabel.Location = New System.Drawing.Point(97, 89)
        Me.londonTimeLabel.Name = "londonTimeLabel"
        Me.londonTimeLabel.Size = New System.Drawing.Size(187, 25)
        Me.londonTimeLabel.TabIndex = 6
        Me.londonTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tokyoTimeLabel
        '
        Me.tokyoTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tokyoTimeLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tokyoTimeLabel.Location = New System.Drawing.Point(97, 127)
        Me.tokyoTimeLabel.Name = "tokyoTimeLabel"
        Me.tokyoTimeLabel.Size = New System.Drawing.Size(187, 25)
        Me.tokyoTimeLabel.TabIndex = 7
        Me.tokyoTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clockTimer
        '
        Me.clockTimer.Enabled = True
        Me.clockTimer.Interval = 1000
        '
        'WorldClockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 166)
        Me.Controls.Add(Me.tokyoTimeLabel)
        Me.Controls.Add(Me.londonTimeLabel)
        Me.Controls.Add(Me.atlantaTimeLabel)
        Me.Controls.Add(Me.laTimeLabel)
        Me.Controls.Add(Me.tokyoLabel)
        Me.Controls.Add(Me.londonLabel)
        Me.Controls.Add(Me.atlantaLabel)
        Me.Controls.Add(Me.laLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "WorldClockForm"
        Me.Text = "World Clock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents laLabel As System.Windows.Forms.Label
   Friend WithEvents atlantaLabel As System.Windows.Forms.Label
   Friend WithEvents londonLabel As System.Windows.Forms.Label
   Friend WithEvents tokyoLabel As System.Windows.Forms.Label
   Friend WithEvents laTimeLabel As System.Windows.Forms.Label
   Friend WithEvents atlantaTimeLabel As System.Windows.Forms.Label
   Friend WithEvents londonTimeLabel As System.Windows.Forms.Label
    Friend WithEvents tokyoTimeLabel As System.Windows.Forms.Label
    Friend WithEvents clockTimer As System.Windows.Forms.Timer

End Class
