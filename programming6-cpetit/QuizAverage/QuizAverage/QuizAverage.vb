Public Class QuizAverageForm
    'declare global variables
    Dim totalScore As Integer
    Dim taken As Integer

    Private Sub submitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submitButton.Click
        ' declare local variables
        Dim avgScore As Decimal
        Dim score As Integer
        'get user input
        score = Convert.ToInt32(scoreTextBox.Text)
        'update scores
        totalScore += score
        taken += 1
        ' calc avg
        avgScore = Convert.ToDecimal(totalScore) / Convert.ToDecimal(taken)
        'display results
        numberResultLabel.Text = Convert.ToString(taken)
        averageResultLabel.Text = Convert.ToString(avgScore)
    End Sub ' submitButton_Click
End Class ' QuizAverageForm

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