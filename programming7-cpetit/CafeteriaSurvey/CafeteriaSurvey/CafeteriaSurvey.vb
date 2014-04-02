Public Class CafeteriaSurveyForm
    'load combobox data source

    'create arrays & counter variable
    Dim choices As Integer() = New Integer(9) {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
    Dim responses(0 To 10) As Integer
    Dim responseCounter As Integer = 0



   ' displays histogram
   Sub DisplayHistogram()
        ' header
        outputTextBox.Text = "Rating" & vbTab & "Frequency" & vbCrLf

        'loop
        For index As Integer = 1 To responses.GetUpperBound(0)
            ' add the array elements to the total
            ' sets 1 to 10 on left side
            outputTextBox.Text &= index & vbTab

            Dim a As String
            ' add * for each number in index
            For i As Integer = 1 To responses(index)
                outputTextBox.Text &= "*"
            Next
            ' line feed
            outputTextBox.Text &= vbCrLf

        Next
    End Sub ' DisplayHistogram

    Private Sub submitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submitButton.Click
        ' declare variable
        Dim choice As Integer

        'get user input
        choice = CInt(ComboBox.Text)

        ' add to array
        responses(choice) += 1

        ' increment responseCounter
        responseCounter += 1
        ' calls subroutine 
        DisplayHistogram()


        ' disables submit button at 20 responses
        If responseCounter = 20 Then
            submitButton.Enabled = False
        End If




    End Sub ' sumbitButton_Click

    Private Sub CafeteriaSurveyForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load combobox data source

        ComboBox.DataSource = choices

    End Sub 'CafeteriaSurveyForm_Load
End Class ' CafeteriaSurveyForm

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