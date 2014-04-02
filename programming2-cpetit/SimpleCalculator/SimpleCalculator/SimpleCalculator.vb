Public Class SimpleCalculatorForm

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        Dim first As Integer
        Dim second As Integer
        Dim result As Integer

        first = Val(firstNumberTextBox.Text)
        second = Val(secondNumberTextBox.Text)

        result = first + second

        resultLabel.Text = CStr(result)

    End Sub

    Private Sub firstNumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles firstNumberTextBox.TextChanged

        resultLabel.Text = String.Empty

    End Sub

    Private Sub secondNumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles secondNumberTextBox.TextChanged

        resultLabel.Text = String.Empty

    End Sub

    Private Sub subtractButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subtractButton.Click

        Dim first As Integer
        Dim second As Integer
        Dim result As Integer

        first = Val(firstNumberTextBox.Text)
        second = Val(secondNumberTextBox.Text)

        result = first - second

        resultLabel.Text = CStr(result)

    End Sub

    Private Sub multiplyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiplyButton.Click
        Dim first As Integer
        Dim second As Integer
        Dim result As Integer

        first = Val(firstNumberTextBox.Text)
        second = Val(secondNumberTextBox.Text)

        result = first * second

        resultLabel.Text = CStr(result)
    End Sub

    Private Sub divideButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divideButton.Click
        Dim first As Integer
        Dim second As Integer
        Dim result As Integer

        first = Val(firstNumberTextBox.Text)
        second = Val(secondNumberTextBox.Text)

        result = first \ second

        resultLabel.Text = CStr(result)
    End Sub
End Class ' SimpleCalculatorForm

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