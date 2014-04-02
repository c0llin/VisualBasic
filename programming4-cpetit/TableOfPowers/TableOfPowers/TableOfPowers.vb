Public Class TableOfPowersForm

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        ' Declare vaiables 
        Dim upperLimit As Integer
        Dim counter As Integer = 1


        ' Get user input
        upperLimit = Val(inputTextBox.Text)

        ' Calculate and update the ListBox
        'clear the list box
        resultListBox.Items.Clear()

        ' add header
        resultListBox.Items.Add("N" & ControlChars.Tab & "N^2" & ControlChars.Tab & "N^3")


        Do Until counter > upperLimit

            resultListBox.Items.Add(counter & vbTab & counter ^ 2 & vbTab & counter ^ 3)
            ' Increment the counter 
            counter += 1
        Loop
    End Sub

    Private Sub inputTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputTextBox.TextChanged
        'clears list box
        resultListBox.Items.Clear()
    End Sub
End Class ' TableOfPowersForm































































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