Public Class maxPoint
    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        scoreBox.Text = 10 'on load the score starts as 10
    End Sub
    Private Sub upBtn_Click(sender As Object, e As EventArgs) Handles upBtn.Click
        scoreBox.Text = scoreBox.Text + 1 'increase the scor eby 1
    End Sub

    Private Sub downBtn_Click(sender As Object, e As EventArgs) Handles downBtn.Click
        If scoreBox.Text = 1 Then
            MsgBox("can't have a 0 score") 'stops it going inot minhnuse numbers 
        Else
            scoreBox.Text = scoreBox.Text - 1 'decreases the scor eby one
        End If


    End Sub

    Private Sub launchbtn_Click(sender As Object, e As EventArgs) Handles launchbtn.Click 'starts the competistion
        Scoresheet.Show()
        compStart.Hide()
        Me.Hide()
    End Sub
End Class