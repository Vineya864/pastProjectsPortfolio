Public Class mainMenu
    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        loginwindow.access = ""
    End Sub
    Sub fullNeeded(form) 'full accecs needed to access the given form
        If loginwindow.access = "complete" Then 'if compleate access
            form.Show() 'load form
            Me.Hide()
        ElseIf loginwindow.access = "part" Then 'part access
            MsgBox("You do not have access to this feature", , "unable to process request") 'error
        Else
            MsgBox("You do not have access to this please login to access this feature", , "unable to process request") 'no access
        End If
    End Sub
    Sub partNeeded(form) 'part needed
        If loginwindow.access = "complete" Or loginwindow.access = "part" Then 'acces to full acces or part acces
            form.show()
            Me.Hide()
        Else
            MsgBox("You do not have access to this please login to access this feature", , "unable to process request") 'else reject
        End If

    End Sub
    Private Sub compstartbtn_Click(sender As Object, e As EventArgs) Handles compstartbtn.Click ' brings up the comp creator
        If loginwindow.access = "part" Then
            If Scoresheet.AName.Text <> "" Then
                Scoresheet.Show()
                Scoresheet.access = False
                MsgBox("you cannot create a competion but here is the current competion", , "Scoresheet") 'loads up the score sheet if they dont have access to create a competition
            Else
                MsgBox("you do not have access to this feature and there is no competion currently running", , "unable to process request") 'if there si no competition running
            End If
        Else
            fullNeeded(compStart)
        End If

    End Sub

    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles Closebtn.Click 'closes the program
        Dim check As String 'set a check varable
        check = MsgBox("Are you sure you want to exit any unsaved data will be lost?", vbYesNo, "Close Program") 'get user input
        If check = DialogResult.Yes Then 'if yes then
            Application.Exit() 'close
        End If

    End Sub

    Private Sub PastScorebtn_Click(sender As Object, e As EventArgs) Handles PastScorebtn.Click 'brings up the charts
        partNeeded(records)
    End Sub

    Private Sub Practice_Click(sender As Object, e As EventArgs) Handles PracticeBtn.Click 'bring sup practice menu

        practice.Show()
    End Sub


    Private Sub LogInBtn_Click(sender As Object, e As EventArgs) Handles LogInBtn.Click 'login
        loginwindow.Show()
    End Sub

    Private Sub accountBtn_Click(sender As Object, e As EventArgs) Handles accountBtn.Click 'create a new login-full access needed
        fullNeeded(newAccount)
        Me.Show() 'main menu on top
        newAccount.TopMost = True 'create acount on top

    End Sub
  
    Private Sub ScoreSheetNavigate_Click(sender As Object, e As EventArgs) Handles ScoreSheetNavigate.Click 'loads the score sheet
        If Scoresheet.AName.Text <> "" Then
            If loginwindow.access = "part" Then 'locked so can be seen not eddited

                Scoresheet.Show()
                Scoresheet.access = False

            Else
                Scoresheet.access = True 'full access
                fullNeeded(Scoresheet)
            End If
        Else
            MsgBox("there is currently no competion running", , "unable to process request")
        End If
    End Sub

    Private Sub PracticeMatchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PracticeMatchToolStripMenuItem.Click
        practice.Show()
        Me.Hide()
    End Sub

    Private Sub logOut_Click(sender As Object, e As EventArgs) Handles logOut.Click 'logout button
        loginwindow.logoutfunction()

    End Sub

    Private Sub databaseBtn_Click(sender As Object, e As EventArgs) Handles databaseBtn.Click
        fullNeeded(database)

    End Sub

    Private Sub ViewRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPastscores.Click
        partNeeded(records) 'check access
    End Sub

    Private Sub CreateCompetitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateCompetitionToolStripMenuItem.Click
        fullNeeded(compStart) 'check access
    End Sub
End Class
