Public Class SalarySurveyForm

    ' salary range array
    Dim salaries As String() = New String(8) {"$200-299", "$300-399", "$400-499", "$500-599", "$600-699", "$700-799", "$800-899", "$900-999", "Over $999"}
    ' salary counter array
    Dim range(0 To 8) As Integer




    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        ' variables 
        Dim sales As Double
        Dim salary As Double
        ' get user input
        sales = Convert.ToDouble(Val(inputSalesTextBox.Text))


        ' calculate bonus
        ' if > 5000 then 200 + 5000 (.09)
        If sales >= 5000 Then
            salary = 200 + sales * 0.09
        Else
            salary = 200
        End If

        'output salaryy w/ currancy format
        totalSalaryValueLabel.Text = FormatCurrency(CStr(salary))

        'case statement
        Select Case salary
            Case 200 To 299
                range(0) += 1
            Case 300 To 399
                range(1) += 1
            Case 400 To 499
                range(2) += 1
            Case 500 To 599
                range(3) += 1
            Case 600 To 699
                range(4) += 1
            Case 700 To 799
                range(5) += 1
            Case 800 To 899
                range(6) += 1
            Case 900 To 999
                range(7) += 1
            Case Else
                range(8) += 1
        End Select




    End Sub ' calculatebutton_click

    Private Sub inputSalesTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputSalesTextBox.TextChanged
        'clear label on text change
        totalSalaryValueLabel.Text = String.Empty
        'clear listbox
        salaryTotalsListBox.Items.Clear()
    End Sub ' inputsalestextbox_textchanged

    Private Sub totalsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles totalsButton.Click
        'clear b4 running
        salaryTotalsListBox.Items.Clear()
        ' header

        salaryTotalsListBox.Items.Insert(0, "Salary Range:" & vbTab & "Total:")

        'loop
        For index As Integer = 0 To range.GetUpperBound(0)
            ' add the array elements to the total
            ' sets 1 to 10 on left side
            salaryTotalsListBox.Items.Add(salaries(index) & vbTab & vbtab & CStr(range(index)))

        Next



    End Sub ' totalsbutton_click
End Class ' SalarySurveyForm

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