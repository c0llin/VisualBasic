Public Class CreditCheckerForm

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        ' declare variables

        Dim balance, charges, credits, credit_limit, newBalance As Decimal
        Dim account As Integer

        ' get user inputs

        account = Val(accountNumberTextBox.Text)
        charges = Val(totalChargesTextBox.Text)
        credits = Val(totalCreditsTextBox.Text)
        credit_limit = Val(creditLimitTextBox.Text)
        balance = Val(startBalanceTextBox.Text)

        'math

        newBalance = balance - credits + charges


        ' logic

        If newBalance > credit_limit Then
            errorLabel.Text = "Error: Credit Limit Exceeded!"
        End If


        'output results
        newBalanceResultLabel.Text = Format(newBalance, "c")

    End Sub

    Private Sub accountNumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles accountNumberTextBox.TextChanged

        'clears label
        errorLabel.Text = String.Empty
        totalChargesTextBox.Text = String.Empty
        totalCreditsTextBox.Text = String.Empty
        totalCreditsTextBox.Text = String.Empty

    End Sub

    Private Sub startBalanceTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startBalanceTextBox.TextChanged
        'clears label
        errorLabel.Text = String.Empty
    End Sub

    Private Sub totalChargesTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles totalChargesTextBox.TextChanged
        'clears label
        errorLabel.Text = String.Empty
    End Sub

    Private Sub totalCreditsTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles totalCreditsTextBox.TextChanged
        'clears label
        errorLabel.Text = String.Empty
    End Sub

    Private Sub creditLimitTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles creditLimitTextBox.TextChanged
        'clears label
        errorLabel.Text = String.Empty
    End Sub
End Class ' CreditCheckerForm

' **************************************************************************
' * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
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