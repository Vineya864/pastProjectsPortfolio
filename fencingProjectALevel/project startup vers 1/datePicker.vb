Public Class datePicker

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        dateLabel.Text = MonthCalendar1.SelectionStart 'make the label show the selected date
    End Sub
    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click ' submit button to change the date
        Dim dateofComp As String
        Dim trueDate As Date
        dateofComp = dateLabel.Text
        If dateofComp = "" Then 'if no date selected set to defalut this is all the validation that is needed as there is no other input
            trueDate = "1.1.01"
        Else
            trueDate = dateofComp 'sets the date
        End If
        Me.Hide() 'hide the form 
        compStart.DateBox.Text = trueDate 'send the date over
    End Sub
    Private Sub datePicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'set the lable to the date
        dateLabel.Text = MonthCalendar1.SelectionStart
    End Sub
End Class