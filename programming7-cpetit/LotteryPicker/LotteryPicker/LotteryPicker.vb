Public Class LotteryPickerForm
    'function generates a random number within a range
    Dim randomObject As New Random()
    Function lottonumber(ByVal lowrange As Integer, ByVal highrange As Integer) As String
        ' declare variables

        Dim number As Integer

        number = randomObject.Next(lowrange, 1 + highrange)

        'return string
        Return number.ToString("D2")
    End Function ' lottonumber

    Function lottoresult(ByVal range As Integer) As String

        Dim number As String

        Select Case range
            Case 3
                number = lottonumber(0, 9)
                number &= " " & lottonumber(0, 9)
                number &= " " & lottonumber(0, 9)
            Case 4
                number = lottonumber(0, 9)
                number &= " " & lottonumber(0, 9)
                number &= " " & lottonumber(0, 9)
                number &= " " & lottonumber(0, 9)
            Case 5
                number = lottonumber(0, 39)
                number &= " " & lottonumber(0, 39)
                number &= " " & lottonumber(0, 39)
                number &= " " & lottonumber(0, 39)
            Case Else
                number = lottonumber(0, 49)
                number &= " " & lottonumber(0, 49)
                number &= " " & lottonumber(0, 49)
                number &= " " & lottonumber(0, 49)
                number &= " " & lottonumber(0, 49)
                number &= " " & lottonumber(0, 42)
        End Select


        ' call lottonumber function
        Return number

    End Function 'lottoresult 



    Private Sub generateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generateButton.Click
        Dim pick3 As String
        Dim pick4 As String
        Dim pick5 As String
        Dim powerball As String
        Dim powerballnum As String

        ' pick 3
        pick3 = lottoresult(3)

        ' pick 4
        pick4 = lottoresult(4)
        ' pick 5
        pick5 = lottoresult(5)
        ' powerball

        powerball = lottoresult(6)
        'take last to numbers from string
        powerballnum = powerball.Substring(15)
        'remove last two numbers from string
        powerball = powerball.Remove(15)
        'length 17

        'output results
        output3Label.Text = pick3
        output4Label.Text = pick4
        output5Label.Text = pick5
        output5Plus1Label.Text = powerball
        outputExtra1Label.Text = powerballnum



    End Sub 'generateButton_Click
End Class ' LotteryPickerForm

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