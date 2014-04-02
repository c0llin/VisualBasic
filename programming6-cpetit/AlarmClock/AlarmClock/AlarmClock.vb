Public Class AlarmClockForm

    Private Sub setButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setButton.Click

        ' disable set button 
        setButton.Enabled = False
        ' disable datetimepicker
        DateTimePicker.Enabled = False
        ' enable reset button
        resetButton.Enabled = True

    End Sub 'setButton_Click

    Private Sub alarmTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alarmTimer.Tick
        ' declare variables, get time
        Dim currentTime As Date = Date.Now
        Dim alarmTime As Date
        Dim i As Integer

        'display time 
        currentTimeLabel.Text = String.Format("{0:hh:mm:ss tt}", currentTime)

        'alarm logic
        If setButton.Enabled = True Then
            alarmTime = DateTimePicker.Value
            i = Date.Compare(alarmTime, currentTime)
            If i >= 0 Then
                Beep()
            End If
        End If


    End Sub

    Private Sub resetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetButton.Click
        ' enable set button 
        setButton.Enabled = True
        ' enable datetimepicker
        DateTimePicker.Enabled = True
        ' disable reset button
        resetButton.Enabled = False
    End Sub ' resetButton_Click
End Class ' AlarmClockForm

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