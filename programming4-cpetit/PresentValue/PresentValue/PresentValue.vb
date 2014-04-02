Public Class PresentValueForm

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        ' declare variables
        Dim presentValue, futureValue, rate As Decimal




        ' obtain user input
        futureValue = Val(futureValueTextBox.Text)
        rate = Val(rateTextBox.Text)


        ' calculate present value and show result
        ' present value = future value / (1 + interest rate) ^ years
        ' add a header
        resultTextBox.Clear() 'clear Textbox
        resultTextBox.Text = "Year" & vbTab & "Amount on Deposit Needed" & vbCrLf

        For counter As Integer = 5 To yearUpDown.Value Step 5
            presentValue = futureValue / (1 + rate / 100) ^ counter 'Present value
            ' append the new line to the end of TextBox
            resultTextBox.Text &= counter & vbTab & Format(presentValue, "c") & vbCrLf

        Next




    End Sub ' calculateButton_Click

    Private Sub futureValueTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles futureValueTextBox.TextChanged
        resultTextBox.Clear() 'clear textbox
    End Sub

    Private Sub rateTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rateTextBox.TextChanged
        resultTextBox.Clear() ' clear textbox
    End Sub
End Class ' PresentValueForm

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