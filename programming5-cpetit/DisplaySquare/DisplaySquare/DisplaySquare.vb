Public Class DisplaySquareForm

    Sub DisplaySquare(ByVal size As Integer, ByVal fillCharacter As String)
        ' declare counters for loops
        Dim row, column As Integer
        Dim output As String ' store output characters

        For row = 1 To size ' loop until reach the size
            For column = 1 To size ' loop until reach the size
                output &= fillCharacter
            Next

            ' start new line
            output &= vbCrLf
        Next
        ' show output in UI
        outputTextBox.Text = output

    End Sub ' DisplaySquare



    Private Sub displaySquareButton_Click(sender As System.Object, e As System.EventArgs) Handles displaySquareButton.Click
        'call displaysquare to print a square
        DisplaySquare(Val(sizeTextBox.Text), fillTextBox.Text)
    End Sub ' displaySquareButton_Click
End Class ' DisplaySquareForm

