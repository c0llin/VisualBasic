Public Class WorldClockForm

    Private Sub clockTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clockTimer.Tick

        'get time
        Dim currentTime As Date = Date.Now
        ' display time
        laTimeLabel.Text = currentTime.AddHours(-3)
        atlantaTimeLabel.Text = Date.Now
        londonTimeLabel.Text = currentTime.AddHours(5)
        tokyoTimeLabel.Text = currentTime.AddHours(14)

        ' diplay time per zone
    End Sub
End Class ' WorldClockForm

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