Public Class IncomeTaxForm

    Private Sub salaryTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salaryTextBox.TextChanged

        'clears result label on change
        taxResultLabel.Text = String.Empty

    End Sub 'salarytextBox_textChanged

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click

        'declare variables
        Dim tax, salary As Decimal

        ' get user input
        salary = Val(salaryTextBox.Text)
        ' run case
        Select Case salary
            Case 0 To 7825
                'computes taxes at each bracket
                tax = salary * 0.1
                taxResultLabel.Text = Format(tax, "c")

            Case 7826 To 31850
                'computes taxes at each bracket
                tax = 7825 * 0.1 + (salary - 7825) * 0.15
                taxResultLabel.Text = Format(tax, "c")

            Case 31851 To 77100
                'computes taxes at each bracket
                tax += 7825 * 0.1
                tax += (31850 - 7825) * 0.15
                tax += (salary - 31850) * 0.25
                taxResultLabel.Text = Format(tax, "c")

            Case 77101 To 160850
                'computes taxes at each bracket
                tax += 7825 * 0.1
                tax += (31850 - 7825) * 0.15
                tax += (77100 - 31850 - 7825) * 0.25

                tax = (salary - 77100) * 0.28
                taxResultLabel.Text = Format(tax, "c")

            Case 160851 To 349700
                'computes taxes at each bracket
                tax += 7825 * 0.1
                tax += (31850 - 7825) * 0.15
                tax += (77100 - 31850 - 7825) * 0.25
                tax += (160850 - 77100 - 31850 - 7825) * 0.28

                tax = (salary - 160850) * 0.33
                taxResultLabel.Text = Format(tax, "c")

            Case Is > 349700
                'computes taxes at each bracket
                tax += 7825 * 0.1
                tax += (31850 - 7825) * 0.15
                tax += (77100 - 31850 - 7825) * 0.25
                tax += (160850 - 77100 - 31850 - 7825) * 0.28
                tax += (349700 - 160850 - 77100 - 31850 - 7825) * 0.33

                tax = (salary - 349700) * 0.35
                taxResultLabel.Text = Format(tax, "c")

            Case Else
                'enter valid amount
                taxResultLabel.Text = "Invalid Salary"
        End Select



        'retrun result





    End Sub ' calculateButton_Click
End Class ' IncomeTaxForm

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