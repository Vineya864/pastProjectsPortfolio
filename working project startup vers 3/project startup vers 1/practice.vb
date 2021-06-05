Public Class practice
    Dim Ascore As Integer
    Dim Bscore As Integer
    Dim timecheck As Boolean
    Private Sub practice_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'hides the main menu
        mainMenu.Hide()
        CommitBtn.Hide()
        timecheck = False
    End Sub


    Sub buttonPressed(button, ByRef score) 'function for adding to the score
        button.Backcolor = Color.Black 'set button colour
        score = button.text 'set score
        CompTimer.Enabled = False 'stop timer
    End Sub
    'scoreing buttons start
    Private Sub AScore1_Click(sender As Object, e As EventArgs) Handles AScore1.Click
        buttonPressed(AScore1, Ascore)
        'score one A
    End Sub

    Private Sub AScore2_Click(sender As Object, e As EventArgs) Handles AScore2.Click
        buttonPressed(AScore1, Ascore)
        buttonPressed(AScore2, Ascore)
        'score is two
    End Sub

    Private Sub AScore3_Click(sender As Object, e As EventArgs) Handles AScore3.Click
        buttonPressed(AScore2, Ascore)
        buttonPressed(AScore1, Ascore)
        buttonPressed(AScore3, Ascore)
        'score is three
    End Sub

    Private Sub AScore4_Click(sender As Object, e As EventArgs) Handles Ascore4.Click
        buttonPressed(AScore3, Ascore) 'prevous scores
        buttonPressed(AScore2, Ascore)
        buttonPressed(AScore1, Ascore)
        buttonPressed(Ascore4, Ascore) 'currnet score 
        'score is four
    End Sub
    Sub winner(name, scoreW, scoreL) 'get values
        MsgBox("Victory", , "Victory") 'message winner
        MsgBox(name & " wins", , "victory") 'say who one
        MsgBox(scoreW & " :To: " & scoreL, , "victory") 'tell the scores
    End Sub
    Private Sub AScore5_Click(sender As Object, e As EventArgs) Handles AScore5.Click
        buttonPressed(AScore3, Ascore)
        buttonPressed(AScore2, Ascore)
        buttonPressed(AScore1, Ascore)
        buttonPressed(Ascore4, Ascore)
        buttonPressed(AScore5, Ascore)
        'score is five winner
        winner(Aname.Text, Ascore, Bscore) 'call winner function
    End Sub

    Private Sub BScore1_Click(sender As Object, e As EventArgs) Handles BScore1.Click
        buttonPressed(BScore1, Bscore) 'point 1
    End Sub
    Private Sub BScore2_Click(sender As Object, e As EventArgs) Handles BScore2.Click
        buttonPressed(BScore1, Bscore)
        buttonPressed(BScore2, Bscore) 'point2
    End Sub
    Private Sub BScore3_Click(sender As Object, e As EventArgs) Handles BScore3.Click
        buttonPressed(BScore1, Bscore)
        buttonPressed(BScore2, Bscore)
        buttonPressed(BScore3, Bscore) 'point3
    End Sub
    Private Sub BScore4_Click(sender As Object, e As EventArgs) Handles BScore4.Click
        buttonPressed(BScore1, Bscore)
        buttonPressed(BScore2, Bscore)
        buttonPressed(BScore3, Bscore)
        buttonPressed(BScore4, Bscore) 'point 4
    End Sub
    Private Sub BScore5_Click(sender As Object, e As EventArgs) Handles BScore5.Click
        buttonPressed(BScore1, Bscore)
        buttonPressed(BScore2, Bscore)
        buttonPressed(BScore3, Bscore)
        buttonPressed(BScore4, Bscore)
        buttonPressed(BScore5, Bscore)
        'point 5
        winner(Bname.Text, Bscore, Ascore) 'call winner function

    End Sub

    'scoring buttons end



    Private Sub backBtn_Click_1(sender As Object, e As EventArgs) Handles backBtn.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub ViewStatisticsBtn_Click(sender As Object, e As EventArgs)

    End Sub
    Sub enternamesFunction()
        Aname.ReadOnly = False 'allows the text box to be writen to
        Bname.ReadOnly = False
        CommitBtn.Show() 'show the commit button
        EnterNames.Text = "Change Names" 'change the toolstrip item name 
    End Sub
    'entering competitors
    Private Sub EnterNames_Click(sender As Object, e As EventArgs) Handles EnterNames.Click 'enter name s
        enternamesFunction()
    End Sub



    Private Sub CreateACompetition_Click(sender As Object, e As EventArgs) Handles CreateACompetition.Click 'navigation to comp creator
        mainMenu.fullNeeded(compStart)

    End Sub


    'timer functions

    Private Sub CompTimer_Tick(sender As Object, e As EventArgs) Handles CompTimer.Tick 'timer fucntion
        LabelTime.Text = Val(LabelTime.Text) - 1 'minus one from the time
        If LabelTime.Text = 0 Then 'if the times up
            CompTimer.Enabled = False 'stop the timer
            LabelTime.BackColor = Color.Red 'change the text back colour to red
            Flash()
            MsgBox("The timer has elapsed", , "Out Of Time") 'send a message box to the user
        End If

    End Sub
    'start timer
    Private Async Sub Flash() 'cause the lables to flash 'async lets the code still run whilst this function works in the background
        While LabelTime.Text = "0" 'untill new time entered
            Await Task.Delay(200) 'once every 200 milliseconds
            LabelTime.Visible = Not LabelTime.Visible

        End While
        LabelTime.BackColor = Nothing 'set colour back to noremal so not highlighted 
        LabelTime.Visible = True 'set them up to be visible again
    End Sub

    'change time
    Private Sub ChangeTime_Click(sender As Object, e As EventArgs) Handles ChangeTime.Click ' enter the timer time 
        Dim Time As Integer 'set a time value
        Try
            Time = InputBox("Enter Time: ", "Change the time") ' input the time to a input box 
            LabelTime.Text = Time 'set the label
        Catch ex As Exception 'if wrong format given 
            MsgBox("This time is not accepted", , "Error") 'errormessage
        End Try

    End Sub

 

    Private Sub logedAs_Click(sender As Object, e As EventArgs) Handles logedAs.Click

    End Sub

    Private Sub ScoreSheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScoreSheetToolStripMenuItem.Click
        'load up the score sheet 
        If Scoresheet.AName.Text <> "" Then 'if there is currently a competition running 
            If loginwindow.access = "part" Then
                'if they dont have full access lock out the score sheet for edditing
                Scoresheet.Show()
                Scoresheet.access = False

            Else
                Scoresheet.access = True 'if they dont have part access
                mainMenu.fullNeeded(Scoresheet) ' check with the main check function
            End If
        Else
            MsgBox("there is currently no competion running") ' if there is no competition running 
        End If
    End Sub

    Private Sub LogInBtn_Click(sender As Object, e As EventArgs) Handles LogInBtn.Click
        loginwindow.Show() 'login
    End Sub


    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        loginwindow.logoutfunction() 'logout
    End Sub


    Private Sub StartTimerBtn_Click(sender As Object, e As EventArgs) Handles StartTimerBtn.Click
        'start the timer 
        CompTimer.Enabled = True
    End Sub

    Private Sub commitBtn_Click(sender As Object, e As EventArgs) Handles CommitBtn.Click 'commit changes button
        Aname.ReadOnly = True 'top textbox read only
        Bname.ReadOnly = True 'bottom text box read only
        CommitBtn.Hide() 'hide button
    End Sub



    Private Sub LabelTime_Click(sender As Object, e As EventArgs) Handles LabelTime.Click

    End Sub

    Private Sub ViewDatabaseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewDatabaseToolStripMenuItem1.Click

    End Sub

    Private Sub recordsStrip_Click(sender As Object, e As EventArgs) Handles recordsStrip.Click
        mainMenu.partNeeded(records) 'check access and load form
        Me.Close() 'close current window
    End Sub
End Class