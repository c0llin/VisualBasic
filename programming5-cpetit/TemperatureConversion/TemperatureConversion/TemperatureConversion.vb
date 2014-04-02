Public Class TemperatureConversionForm
    Function ConvertF(ByVal input As Double) As Double
        ' fahrenheit = (9 / 5) * celsius + 32
        Dim f As Double ' declare variable
        f = (9 / 5) * input + 32 ' conversion
        Return f ' returns value

    End Function ' convertF

    Function ConvertC(ByVal input As Double) As Double
        'celsius = (5 / 9) * (fahrenheit - 32)
        Dim c As Double ' declare variable
        c = (5 / 9) * (input - 32) ' conversion
        Return c ' returns value
    End Function ' ConvertC


    Private Sub convertFahrenheitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convertFahrenheitButton.Click
        ' declares variables
        Dim c, f As Decimal
        'gets user input
        c = Val(degreeTextBox.Text)
        ' calls functions and preforms conversions
        f = Format(ConvertF(c), "F")

        'outputs results
        outputLabel.Text = Format(c, "g") & " degrees Celsius is equal to " & f & " degrees Fahrenheit."

    End Sub ' convertFahrenheithButton_Click

    Private Sub convertCelsiusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convertCelsiusButton.Click
        'delcares variables
        Dim c, f As Decimal
        ' get user input
        f = Val(degreeTextBox.Text)
        ' calls functions on user input and formats
        c = Format(ConvertC(f), "f")

        'output results
        outputLabel.Text = Format(f, "g") & " degrees Fahrenheit is equal to " & c & " degrees Celcius."

    End Sub ' convertCelsiusButton_Click

    Private Sub degreeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles degreeTextBox.TextChanged

        outputLabel.Text = String.Empty

    End Sub ' degreeTextBox_TextChanged
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