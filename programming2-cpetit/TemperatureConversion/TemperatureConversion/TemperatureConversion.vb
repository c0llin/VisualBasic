Public Class TemperatureConversionForm

    Private Sub convertButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convertButton.Click

        'declares variables

        Dim inputTemp As Integer
        Dim outputTemp As Integer

        'assigns input textbox to variable

        inputTemp = Val(inputTextBox.Text)

        'assign variable & math

        outputTemp = (9 * inputTemp \ 5) + 32

        'converts to string and assigns to label

        resultLabel.Text = CStr(outputTemp)


    End Sub

    Private Sub inputTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputTextBox.TextChanged

        'clears result when new entry

        resultLabel.Text = String.Empty

    End Sub
End Class ' TemperatureConversionForm

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