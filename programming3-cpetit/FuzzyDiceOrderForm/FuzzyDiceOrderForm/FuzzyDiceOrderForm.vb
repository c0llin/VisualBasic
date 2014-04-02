' Exercise 8.12 Solution
' FuzzyDiceOrderForm.vb

Public Class FuzzyDiceOrderForm

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        ' declare variables
        Dim total, subtotal As Decimal
        Dim taxcollected As Single
        Const tax As Single = 0.05
        Const shipping As Single = 1.5
        Const wbPrice As Single = 6.25
        Const rbPrice As Integer = 5
        Const bbPrice As Single = 7.5
        Dim wbTotal, rbTotal, bbTotal, shipping_count As Integer
        'get user input
       



        'validate user requests

        If (whiteblackCheckBox.Checked = False AndAlso
             redblackCheckBox.Checked = False AndAlso
             blueblackCheckBox.Checked = False) Then
            ' error msg
            MessageBox.Show( _
                "Please check item you wish to purchase", _
                "No Item Selected", MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        ElseIf whiteBlackQuantityTextBox.Text = "0" AndAlso whiteblackCheckBox.Checked = True Then
            MessageBox.Show( _
                "Please enter item amount you wish to purchase", _
                "No Item Selected", MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        ElseIf redBlackQuantityTextBox.Text = "0" AndAlso redblackCheckBox.Checked = True Then
            MessageBox.Show( _
                "Please enter item amount you wish to purchase", _
                "No Item Selected", MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        ElseIf blueBlackQuantityTextBox.Text = "0" AndAlso blueblackCheckBox.Checked = True Then
            MessageBox.Show( _
                "Please enter item amount you wish to purchase", _
                "No Item Selected", MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        ElseIf whiteBlackQuantityTextBox.Text <> "0" AndAlso whiteblackCheckBox.Checked = False Then
            MessageBox.Show( _
                "Please enter item amount you wish to purchase", _
                "No Item Selected", MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        ElseIf redBlackQuantityTextBox.Text <> "0" AndAlso redblackCheckBox.Checked = False Then
            MessageBox.Show( _
                "Please enter item amount you wish to purchase", _
                "No Item Selected", MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        ElseIf blueBlackQuantityTextBox.Text <> "0" AndAlso blueblackCheckBox.Checked = False Then
            MessageBox.Show( _
                "Please enter item amount you wish to purchase", _
                "No Item Selected", MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End If

        ' checks if billing info is entered

        If orderNumberTextBox.Text = "" Then
            MessageBox.Show("Please Enter Order Number", "No Order Number", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        If nameTextBox.Text = "" OrElse
            (addressLine1TextBox.Text = "" Or
             cityStateZipTextBox.Text = "") Then
            MessageBox.Show("Please Enter Billing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        ' claculate totals if all conditions met, updates shipping count
        If whiteBlackQuantityTextBox.Text <> "0" And whiteblackCheckBox.Checked = True Then
            wbTotal = Val(whiteBlackQuantityTextBox.Text)
            subtotal = wbTotal * wbPrice
            whiteBlackTotalsLabel.Text = Format(subtotal, "c")
            shipping_count += wbTotal
        End If

        If redBlackQuantityTextBox.Text <> "0" And redblackCheckBox.Checked = True Then
            rbTotal = Val(redBlackQuantityTextBox.Text)
            subtotal = subtotal + (rbPrice * rbTotal)
            redBlackTotalsLabel.Text = Format(subtotal, "c")
            shipping_count += rbTotal
        End If

        If blueBlackQuantityTextBox.Text <> "0" And blueblackCheckBox.Checked = True Then
            bbTotal = Val(blueBlackQuantityTextBox.Text)
            subtotal += (bbPrice * bbTotal)
            blueBlackTotalsLabel.Text = Format(subtotal, "c")
            shipping_count += bbTotal
        End If


        taxcollected = subtotal * tax


        'output results
        subtotalResultLabel.Text = Format(subtotal, "c")

        taxResultLabel.Text = Format(taxcollected, "c")


        ' shipping logic
        If shipping_count > 20 Then
            shippingResultLabel.Text = "$0.00"
        Else
            shippingResultLabel.Text = Format(shipping, "c")
            subtotal += shipping
        End If

        ' gives total with money format
        total = subtotal + taxcollected

        totalResultLabel.Text = Format(total, "c")

    End Sub

    Private Sub orderNumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles orderNumberTextBox.TextChanged

    End Sub
End Class

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

'Write an app that allows users to process orders for
'fuzzy dice, as shown in Fig. 8.26. The app should calculate the total price of the order, including
'tax and shipping. TextBoxes for inputting the order number, the customer name and the
'shipping address are provided. Provide CheckBoxes for selecting the fuzzy dice color. The
'app should also contain a Button that, when clicked, calculates the subtotals for each type of
'fuzzy dice ordered and the total of the entire order (including tax and shipping). Use 5% for
'the tax rate. Shipping charges are $1.50 for up to 20 pairs of dice. If more than 20 pairs are
'ordered, shipping is free.