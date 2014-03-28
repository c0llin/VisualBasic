Public Class GuessNumberForm

    ' creat a randomObject
    'Dim randomObject As Random = New Random

    Dim randomObject As New Random

    ' generate a random number

    Dim randomNumber As Integer = randomObject.Next(1, 101) ' returns a number between 1 - 100

    Private Sub enterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterButton.Click

        ' get user input
        Dim guessNumber As Integer = Convert.ToInt32(guessTextBox.Text)

        ' check number
        If guessNumber = randomNumber Then
            outputLabel.Text = "Correct!"
            newGameButton.Enabled = True
            enterButton.Enabled = False
        ElseIf guessNumber > randomNumber Then
            outputLabel.Text = "Too high..."
        ElseIf guessNumber < randomNumber Then
            outputLabel.Text = "Too low..."
        End If

        ' focus the TextBox

        guessTextBox.Focus()

    End Sub ' enterButton_Click

    Private Sub newGameButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newGameButton.Click
        ' start a new game

        randomNumber = randomObject.Next(1, 101)
        enterButton.Enabled = True

        newGameButton.Enabled = False

        guessTextBox.Clear()
        outputLabel.Text = String.Empty
        guessTextBox.Focus()



    End Sub ' newGameButton_Click

    Private Sub guessTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guessTextBox.TextChanged
        ' Clear output label
        outputLabel.Text = ""

    End Sub 'guessTextBox_TextChanged
End Class ' GuessNumberForm

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