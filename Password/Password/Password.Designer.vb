<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordForm
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
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.passwordAgainLabel = New System.Windows.Forms.Label()
        Me.passwordAgainTextBox = New System.Windows.Forms.TextBox()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.logInButton = New System.Windows.Forms.Button()
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.messageTextBox = New System.Windows.Forms.TextBox()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(13, 13)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(97, 15)
        Me.nameLabel.TabIndex = 8
        Me.nameLabel.Text = "Enter your name:"
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Location = New System.Drawing.Point(13, 44)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(117, 15)
        Me.passwordLabel.TabIndex = 9
        Me.passwordLabel.Text = "Enter your password:"
        Me.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'passwordAgainLabel
        '
        Me.passwordAgainLabel.AutoSize = True
        Me.passwordAgainLabel.Location = New System.Drawing.Point(13, 75)
        Me.passwordAgainLabel.Name = "passwordAgainLabel"
        Me.passwordAgainLabel.Size = New System.Drawing.Size(135, 15)
        Me.passwordAgainLabel.TabIndex = 10
        Me.passwordAgainLabel.Text = "Re-enter your password:"
        Me.passwordAgainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'passwordAgainTextBox
        '
        Me.passwordAgainTextBox.Location = New System.Drawing.Point(177, 72)
        Me.passwordAgainTextBox.Name = "passwordAgainTextBox"
        Me.passwordAgainTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordAgainTextBox.Size = New System.Drawing.Size(117, 23)
        Me.passwordAgainTextBox.TabIndex = 2
        Me.passwordAgainTextBox.Text = "Hello2World"
        Me.passwordAgainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(177, 41)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextBox.Size = New System.Drawing.Size(117, 23)
        Me.passwordTextBox.TabIndex = 1
        Me.passwordTextBox.Text = "Hello2World"
        Me.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(177, 10)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(117, 23)
        Me.nameTextBox.TabIndex = 0
        Me.nameTextBox.Text = "Joe Purple"
        Me.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'logInButton
        '
        Me.logInButton.Location = New System.Drawing.Point(321, 9)
        Me.logInButton.Name = "logInButton"
        Me.logInButton.Size = New System.Drawing.Size(75, 23)
        Me.logInButton.TabIndex = 3
        Me.logInButton.Text = "Log in"
        Me.logInButton.UseVisualStyleBackColor = True
        '
        'messageLabel
        '
        Me.messageLabel.AutoSize = True
        Me.messageLabel.Location = New System.Drawing.Point(13, 106)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(147, 15)
        Me.messageLabel.TabIndex = 11
        Me.messageLabel.Text = "Enter your secret message:"
        Me.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'messageTextBox
        '
        Me.messageTextBox.Location = New System.Drawing.Point(16, 135)
        Me.messageTextBox.Multiline = True
        Me.messageTextBox.Name = "messageTextBox"
        Me.messageTextBox.Size = New System.Drawing.Size(278, 71)
        Me.messageTextBox.TabIndex = 4
        Me.messageTextBox.Text = "Welcome to Simply VB 2010"
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(321, 154)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(75, 23)
        Me.saveButton.TabIndex = 5
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'logoutButton
        '
        Me.logoutButton.Location = New System.Drawing.Point(321, 41)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(75, 23)
        Me.logoutButton.TabIndex = 6
        Me.logoutButton.Text = "Log out"
        Me.logoutButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(321, 183)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 7
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'PasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 218)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.logoutButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.messageTextBox)
        Me.Controls.Add(Me.messageLabel)
        Me.Controls.Add(Me.logInButton)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.passwordAgainTextBox)
        Me.Controls.Add(Me.passwordAgainLabel)
        Me.Controls.Add(Me.passwordLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PasswordForm"
        Me.Text = "Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents nameLabel As System.Windows.Forms.Label
   Friend WithEvents passwordLabel As System.Windows.Forms.Label
   Friend WithEvents passwordAgainLabel As System.Windows.Forms.Label
   Friend WithEvents passwordAgainTextBox As System.Windows.Forms.TextBox
   Friend WithEvents passwordTextBox As System.Windows.Forms.TextBox
   Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents logInButton As System.Windows.Forms.Button
   Friend WithEvents messageLabel As System.Windows.Forms.Label
   Friend WithEvents messageTextBox As System.Windows.Forms.TextBox
   Friend WithEvents saveButton As System.Windows.Forms.Button
   Friend WithEvents logoutButton As System.Windows.Forms.Button
   Friend WithEvents clearButton As System.Windows.Forms.Button

End Class
