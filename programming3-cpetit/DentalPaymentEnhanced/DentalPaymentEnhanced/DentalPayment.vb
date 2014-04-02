Public Class DentalPaymentForm
   ' handles Click event
   Private Sub calculateButton_Click(sender As System.Object,
      e As System.EventArgs) Handles calculateButton.Click
      ' clear text displayed in Label
      totalResultLabel.Text = String.Empty
        ' var for other


      ' if no name entered and no CheckBox checked, diplay message
        If (nameTextBox.Text = "") OrElse
           (cleanCheckBox.Checked = False AndAlso
           xrayCheckBox.Checked = False AndAlso
           cavityCheckBox.Checked = False AndAlso
           canalCheckBox.Checked = False AndAlso
           fluorideCheckBox.Checked = False AndAlso
           otherCheckBox.Checked = False) Then
            ' display error message in dialog
            MessageBox.Show( _
               "Please enter a name and check at least one item",
               "Missing information", MessageBoxButtons.OK,
               MessageBoxIcon.Warning)

        ElseIf otherTextBox.Text = "" AndAlso otherCheckBox.Checked = True Then
            MessageBox.Show("Please enter an amout of Other fee", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' add prices
            ' Total contains amount to bill patient & var for other
            Dim total As Decimal = 0
            Dim other As Decimal

            ' if patient had a cleaning
            If cleanCheckBox.Checked = True Then
                total += 35
            End If

            ' if patient had cavity filled
            If cavityCheckBox.Checked = True Then
                total += 150
            End If

            ' if patient had X-Ray taken
            If xrayCheckBox.Checked = True Then
                total += 85
            End If

            ' fluoride checked

            If fluorideCheckBox.Checked = True Then
                total += 50
            End If

            ' if root canal checked
            If canalCheckBox.Checked = True Then
                total += 800
            End If

            ' if other checked
            If otherCheckBox.Checked = True Then
                other = Val(otherTextBox.Text)
                total += other
            End If

            ' display total
            totalResultLabel.Text = String.Format("{0:C}", total)
        End If
   End Sub ' calculateButton_Click

    Private Sub nameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nameTextBox.TextChanged
        'clears on new name
        totalResultLabel.Text = String.Empty

    End Sub

    Private Sub otherTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles otherTextBox.TextChanged
        ' clears with new name
        totalResultLabel.Text = String.Empty
    End Sub
End Class ' DentalPaymentForm

' **************************************************************************
' * (C) Copyright 1992-2013 by Deitel & Associates, Inc. and               *
' * Pearson Education, Inc. All Rights Reserved.                           *
' *                                                                        *
' * DISCLAIMER: The authors and publisher of this book have used their     *
' * best efforts in preparing the book. These efforts include the          *
' * development, research, and testing of the theories and programs        *
' * to determine their effectiveness. The authors and publisher make       *
' * no warranty of any kind, expressed or implied, with regard to these    *
' * programs or to the documentation contained in these books. The authors *
' * and publisher shall not be liable in any event for incidental or       *
' * consequential damages in connection with, or arising out of, the       *
' * furnishing, performance, or use of these programs.                     *
' **************************************************************************