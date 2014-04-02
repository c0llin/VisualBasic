Public Class AccountInformationForm

    Private Sub enterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterButton.Click

        ' copies string from name textbox to name label & displays
        copiedNameLabel.Text = nameTextBox.Text

        ' copies string from account # label to account # label & displays
        copiedAccountNumberLabel.Text = accountNumberTextBox.Text

        ' takes string in deposit ammout textbox and adds value to balance label updating each time 
        balanceAmountLabel.Text = Val(depositAmountTextBox.Text) + Val(balanceAmountLabel.Text)
    End Sub
End Class

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