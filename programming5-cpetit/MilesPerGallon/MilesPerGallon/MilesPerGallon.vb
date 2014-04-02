Public Class MilesPerGallonForm

    Function MilesPerGallon(ByVal miles As Decimal, ByVal gallons As Decimal)
        ' preforms mpg calc, returns results to 2 decimal places
        Return Format(miles / gallons, "f")


    End Function 'MilesPerGallon



    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        'gets user inputs, validates, runs miles per gal function, returns results

        outputLabel.Text = MilesPerGallon(Val(milesTextBox.Text), Val(gallonsTextBox.Text))


    End Sub ' calculateButton_Click
End Class ' MilesPerGallonForm

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