Public Class CurrencyConverterForm

    Private Sub convertButton_Click(sender As System.Object, e As System.EventArgs) Handles convertButton.Click

        ' declare variable
        Dim amount As Decimal
        Const EURO_RATE As Decimal = 0.74
        Const YEN_RATE As Decimal = 76.9
        Const PESO_RATE As Decimal = 14
        Dim currency As String


        ' get user input
        amount = Val(dollarsTextBox.Text)
        currency = currencyTextBox.Text

        ' convert values

        If UCase(currency) = "EURO" Then
            amount = amount * EURO_RATE
        Else
            If UCase(currency) = "YEN" Then
                amount = amount * YEN_RATE
            Else
                If UCase(currency) = "PESO" Then
                    amount *= PESO_RATE
                End If
            End If
        End If

        ' output to resultLabel
        convertedResultLabel.Text = String.Format("{0:F}", amount)


    End Sub

    Private Sub dollarsTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles dollarsTextBox.TextChanged
        ' clear result
        convertedResultLabel.Text = String.Empty
    End Sub

    Private Sub currencyTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles currencyTextBox.TextChanged
        ' clear result
        convertedResultLabel.Text = String.Empty

    End Sub
End Class ' CurrencyConverterForm

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