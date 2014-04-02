Public Class MaximumForm
   ' obtain values in each TextBox, call procedure Maximum
   Private Sub maximumButton_Click(sender As System.Object,
      e As System.EventArgs) Handles maximumButton.Click

        'declare variable
        Dim max As Double
        'pass threee input to the function call
        'have max to carry the results 
        Maximum(Convert.ToDouble(firstTextBox.Text), Convert.ToDouble(secondTextBox.Text), _
                CDbl(thirdTextBox.Text), max)


        ' outputs max

        outputLabel.Text = CStr(max) ' max.ToString(); Convert.ToString(max);
   End Sub ' MaximumButton_Click

   ' find maximum of three parameter values
    Sub Maximum(one As Double, two As Double,
       three As Double, ByRef final As Double)

        Dim temporaryMaximum As Double

        temporaryMaximum = Math.Max(one, two)
        final = Math.Max(temporaryMaximum, three)


    End Sub ' Maximum
End Class ' MaximumForm

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