Public Class ArithmeticCalculatorForm

    Private Sub enterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterButton.Click

        ' declare variables

        Dim value As Single

        ' clear previous results
        If resultLabel.Text <> "" Then
            resultLabel.Text = String.Empty
            ListBox.Items.Clear()
            ' disable additon button
            addButton.Enabled = False

            ' disable multiply button 
            multiplyButton.Enabled = False
        End If

        

        ' get user input and insert number in operands listbox 
        value = Val(inputTextBox.Text)
        ListBox.Items.Add(value & vbCrLf)

        ' allow add multiply buttons when two or more numbers in listbox
        If ListBox.Items.Count >= 2 Then
            addButton.Enabled = True
            multiplyButton.Enabled = True
        End If

        inputTextBox.Clear()
        inputTextBox.Focus()

    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click

        ' declare variables


        Dim sum As Single = 0
        Dim counter As Single = 0

        Do
            ' read values from listbox
            sum += Val(ListBox.Items(counter)) ' adds values
            counter += 1 ' increment counter
        Loop Until counter = ListBox.Items.Count

        'output results
        resultLabel.Text = CStr(sum)


        '


    End Sub ' additionButton_Click

    Private Sub multiplyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiplyButton.Click
        Dim value As Single = 0
        Dim counter As Single = 1
        Dim sum As Single

        value = Val(ListBox.Items(0)) ' stores first value

        Do
            ' read values from listbox
            sum = Val(ListBox.Items(counter)) ' stores remaining values
            value *= sum ' multiplies values
            counter += 1 ' increment counter
        Loop Until counter = ListBox.Items.Count

        'outputs result

        resultLabel.Text = CStr(value)


    End Sub ' multiplyButton_Click

    
End Class ' ArithmeticCalculatorForm

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