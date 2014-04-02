Public Class ComparingRatesForm

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        ' declare variables
        Dim p As Decimal
        Dim value As Decimal

        'clear previous results
        displayTextBox.Clear()

        ' get user input
        p = Val(principalTextBox.Text)
        ' set header
        displayTextBox.Text = "Rate(%)" & vbTab & vbTab & "Amount after 10 years" & vbCrLf
        ' run calculations & print
        ' a = p(1+r)^n where a is value at nth year, p is principal, r is rate in percent, n is years 10
        For i As Integer = 5 To 11 Step 1
            value = p * (1 + i / 100) ^ 10 ' compounded
            ' new line of textbox
            displayTextBox.Text &= i & vbTab & vbTab & Format(value, "c") & vbCrLf
        Next

    End Sub 'calculateButton_Click

    Private Sub principalTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles principalTextBox.TextChanged
        displayTextBox.Clear() 'clear textbox
    End Sub
End Class ' ComparingRatesForm

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