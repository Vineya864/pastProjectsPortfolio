Imports System.Data.OleDb
Public Class Scoresheet
    Dim addDbprovider As String
    Dim Addprevoius As Boolean = False 'set up selection varables 
    Dim AddpreviousID As Integer
    Dim Addcon As New OleDb.OleDbConnection
    Dim AddDbsource As String
    Dim Addmydocumentsfolder As String
    Dim Addthedatabase As String
    Dim Addfullpath As String
    Dim AddDs As New DataSet
    Dim AddDa As OleDb.OleDbDataAdapter
    Dim Addsql As String
    Dim Addmaxrows As Integer
    Dim Addinc As Integer
    Dim AddnumberofPeople As Integer = 1



    Dim scoreOne As Integer 'set up varable sthat are needed throughout the program
    Dim scoreTwo As Integer
    'set up the positions values
    Public Bpos As Integer = 0
    Public Apos As Integer = 0
    Public Cpos As Integer = 0
    Public Dpos As Integer = 0
    Public Epos As Integer = 0
    Public Fpos As Integer = 0
    'set up the win rate varables
    Public Bwinrate As Single
    Public Awinrate As Single
    Public Cwinrate As Single
    Public Dwinrate As Single
    Public Ewinrate As Single
    Public Fwinrate As Single
    'set up the average score varables
    Public Ascore As Single
    Public AHit As Single
    Public Bscore As Single
    Public BHit As Single
    Public AaverageS As Single
    Public AaverageH As Single
    Public BaverageS As Single
    Public BaverageH As Single
    Public Cscore As Single
    Public CHit As Single
    Public CaverageS As Single
    Public CaverageH As Single
    Public Dscore As Single
    Public DHit As Single
    Public DaverageS As Single
    Public DaverageH As Single
    Public Escore As Single
    Public EHit As Single
    Public EaverageS As Single
    Public EaverageH As Single
    Public Fscore As Single
    Public FHit As Single
    Public FaverageS As Single
    Public FaverageH As Single

    'set up the indicator varables
    Public Aindicator As Single
    Public Bindicator As Single
    Public Cindicator As Single
    Public Dindicator As Single
    Public Eindicator As Single
    Public Findicator As Single
    Public access As Boolean

    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        access = True 'on load hide all the buttons and set edditing acces to true

        maxPoint.Hide()
        compStart.Hide()
        cVaBtn.Hide()
        cVbBtn.Hide()
        dVaBtn.Hide()
        blank3btn.Hide()
        aVcBtn.Hide()
        bVcBtn.Hide()
        blank4Btn.Hide()
        aVdBtn.Hide()
        bVdBtn.Hide()
        cVdBtn.Hide()
        blankBtn5.Hide()
        aVeBtn.Hide()
        bVeBtn.Hide()
        cVeBtn.Hide()
        blank6btn.Hide()
        aVfBtn.Hide()
        bVfBtn.Hide()
        cVfBtn.Hide()
        eVaBtn.Hide()
        eVbBtn.Hide()
        eVcBtn.Hide()
        eVdBtn.Hide()
        eVfBtn.Hide()
        fVaBtn.Hide()
        fVbBtn.Hide()
        fVcBtn.Hide()
        fVdBtn.Hide()
        fVeBtn.Hide()
        dVeBtn.Hide()
        dVfBtn.Hide()
        dVcBtn.Hide()
        dVbBtn.Hide()
        AName.Hide()
        AName2.Hide()
        Bname2.Hide()
        Bname.Hide()
        aID.Hide()
        Bid.Hide()
        CId.Hide()
        Cname.Hide()
        Cname2.Hide()
        dName2.Hide()
        dName.Hide()
        dId.Hide()

        ename2.Hide()
        ename.Hide()
        eId.Hide()
        fname2.Hide()
        fname.Hide()
        fId.Hide()
        Dim number As Integer = compStart.numBox.Text 'find the size of the competion
        Select Case number
            Case Is = 3
                blank3btn.Show() 'show boxes for the aporperate sizeing 
                aVcBtn.Show()
                bVcBtn.Show()
                cVaBtn.Show()
                cVbBtn.Show()
            Case Is = 4
                blank3btn.Show()
                blank4Btn.Show()
                aVcBtn.Show()
                aVdBtn.Show()
                bVcBtn.Show()
                bVdBtn.Show()
                dVaBtn.Show()
                dVbBtn.Show()
                dVcBtn.Show()
                cVaBtn.Show()
                cVbBtn.Show()
                cVdBtn.Show()
            Case Is = 5
                blank3btn.Show()
                blank4Btn.Show()
                blankBtn5.Show()
                aVcBtn.Show()
                aVeBtn.Show()
                aVdBtn.Show()
                bVcBtn.Show()
                bVeBtn.Show()
                bVdBtn.Show()
                dVaBtn.Show()
                dVbBtn.Show()
                dVcBtn.Show()
                dVeBtn.Show()
                cVaBtn.Show()
                cVbBtn.Show()
                cVdBtn.Show()
                cVeBtn.Show()
                eVaBtn.Show()
                eVbBtn.Show()
                eVcBtn.Show()
                eVdBtn.Show()
            Case Is = 6
                blank3btn.Show()
                blank4Btn.Show()
                blankBtn5.Show()
                blank6btn.Show()
                aVcBtn.Show()
                aVeBtn.Show()
                aVdBtn.Show()
                aVfBtn.Show()
                bVcBtn.Show()
                bVeBtn.Show()
                bVdBtn.Show()
                bVfBtn.Show()
                dVaBtn.Show()
                dVbBtn.Show()
                dVcBtn.Show()
                dVeBtn.Show()
                dVfBtn.Show()
                cVaBtn.Show()
                cVbBtn.Show()
                cVdBtn.Show()
                cVeBtn.Show()
                cVfBtn.Show()
                eVaBtn.Show()
                eVbBtn.Show()
                eVcBtn.Show()
                eVdBtn.Show()
                eVfBtn.Show()
                fVaBtn.Show()
                fVbBtn.Show()
                fVcBtn.Show()
                fVdBtn.Show()
                fVeBtn.Show()
        End Select
    End Sub 'set up ends
    '///////////////////////////////////////////////////////////////////score buttons/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    Sub blank() 'if a blanck button is pressed 
        MsgBox("this is not a valid option", MsgBoxStyle.Exclamation, "Error")
    End Sub
    Private Sub blankBtn_Click(sender As Object, e As EventArgs) Handles blankBtn.Click
        blank()
    End Sub
    Private Sub blank2btn_Click(sender As Object, e As EventArgs) Handles blank2btn.Click
        blank()
    End Sub
    Private Sub blank3btn_Click(sender As Object, e As EventArgs) Handles blank3btn.Click
        blank()
    End Sub
    Private Sub blank4Btn_Click(sender As Object, e As EventArgs) Handles blank4Btn.Click
        blank()
    End Sub
    Private Sub blankBtn5_Click(sender As Object, e As EventArgs) Handles blankBtn5.Click
        blank()
    End Sub
    Private Sub blank6btn_Click(sender As Object, e As EventArgs) Handles blank6btn.Click
        blank()
    End Sub
    'blank end 

    Sub enterScore(ByRef scoreOne, ByRef scoreTwo) 'enteroing the scores and working out who won
        Dim max As Integer 'get the maximum score
        max = compStart.scoreBox.Text
        scoreOne = InputBox("what was the first score", "First Score") 'get user input
        If scoreOne = "" Then 'if no answer
            scoreOne = 0
        End If
        While (scoreOne > max) 'validate
            MsgBox("this number is too high", , "Error")
            scoreOne = InputBox("what was the first score", "First Score") 'ask again
        End While
        scoreTwo = InputBox("what was the second score", "Second Score") 'get second user input
        If scoreTwo = "" Then 'if nothing
            scoreTwo = 0 ' set it to 0
        End If
        While scoreTwo > max 'validate
            MsgBox("this number is too high", , "Error")
            scoreTwo = InputBox("what was the second score", "Second Score") 'ask again
        End While
    End Sub

    Private Sub aVbBtn_Click(sender As Object, e As EventArgs) Handles aVbBtn.Click 'all buttons calll the fucntion and then show the results
        If access = True Then 'if access level
            enterScore(scoreOne, scoreTwo) 'call function
            aVbBtn.Text = scoreOne
            bVaBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub
    Private Sub bVaBtn_Click(sender As Object, e As EventArgs) Handles bVaBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            aVbBtn.Text = scoreTwo
            bVaBtn.Text = scoreOne
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If

    End Sub
    Private Sub aVcBtn_Click(sender As Object, e As EventArgs) Handles aVcBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            aVcBtn.Text = scoreOne
            cVaBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub
    Private Sub bVcBtn_Click(sender As Object, e As EventArgs) Handles bVcBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            bVcBtn.Text = scoreOne
            cVbBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub
    Private Sub cVbBtn_Click(sender As Object, e As EventArgs) Handles cVbBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            cVbBtn.Text = scoreOne
            bVcBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub
    Private Sub dVaBtn_Click(sender As Object, e As EventArgs) Handles dVaBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            dVaBtn.Text = scoreOne
            aVdBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub
    Private Sub eVaBtn_Click(sender As Object, e As EventArgs) Handles eVaBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            eVaBtn.Text = scoreOne
            aVeBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub
    Private Sub fVaBtn_Click(sender As Object, e As EventArgs) Handles fVaBtn.Click
        enterScore(scoreOne, scoreTwo)
        fVaBtn.Text = scoreOne
        aVfBtn.Text = scoreTwo
    End Sub
    Private Sub cVaBtn_Click(sender As Object, e As EventArgs) Handles cVaBtn.Click

        If access = True Then
            enterScore(scoreOne, scoreTwo)
            cVaBtn.Text = scoreOne
            aVcBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If

    End Sub

    Private Sub dVbBtn_Click(sender As Object, e As EventArgs) Handles dVbBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            dVbBtn.Text = scoreOne
            bVdBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub eVbBtn_Click(sender As Object, e As EventArgs) Handles eVbBtn.Click

        If access = True Then
            enterScore(scoreOne, scoreTwo)
            eVbBtn.Text = scoreOne
            bVeBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If

    End Sub

    Private Sub fVbBtn_Click(sender As Object, e As EventArgs) Handles fVbBtn.Click

        If access = True Then
            enterScore(scoreOne, scoreTwo)
            fVbBtn.Text = scoreOne
            bVfBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")

        End If

    End Sub

    Private Sub dVcBtn_Click(sender As Object, e As EventArgs) Handles dVcBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            dVcBtn.Text = scoreOne
            cVdBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub eVcBtn_Click(sender As Object, e As EventArgs) Handles eVcBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            eVcBtn.Text = scoreOne
            cVeBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub fVcBtn_Click(sender As Object, e As EventArgs) Handles fVcBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            fVcBtn.Text = scoreOne
            cVfBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub aVdBtn_Click(sender As Object, e As EventArgs) Handles aVdBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            aVdBtn.Text = scoreOne
            dVaBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub bVdBtn_Click(sender As Object, e As EventArgs) Handles bVdBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            bVdBtn.Text = scoreOne
            dVbBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub cVdBtn_Click(sender As Object, e As EventArgs) Handles cVdBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            cVdBtn.Text = scoreOne
            dVcBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub eVdBtn_Click(sender As Object, e As EventArgs) Handles eVdBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)

            eVdBtn.Text = scoreOne
            dVeBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub fVdBtn_Click(sender As Object, e As EventArgs) Handles fVdBtn.Click

        If access = True Then
            enterScore(scoreOne, scoreTwo)
            fVdBtn.Text = scoreOne
            dVfBtn.Text = scoreTwo

        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub aVeBtn_Click(sender As Object, e As EventArgs) Handles aVeBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            aVeBtn.Text = scoreOne
            eVaBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub bVeBtn_Click(sender As Object, e As EventArgs) Handles bVeBtn.Click
        If access = True Then

            enterScore(scoreOne, scoreTwo)
            bVeBtn.Text = scoreOne
            eVbBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub cVeBtn_Click(sender As Object, e As EventArgs) Handles cVeBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            cVeBtn.Text = scoreOne
            eVcBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub dVeBtn_Click(sender As Object, e As EventArgs) Handles dVeBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            dVeBtn.Text = scoreOne
            eVdBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub fVeBtn_Click(sender As Object, e As EventArgs) Handles fVeBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            fVeBtn.Text = scoreOne
            eVfBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub aVfBtn_Click(sender As Object, e As EventArgs) Handles aVfBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            aVfBtn.Text = scoreOne
            fVaBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub bVfBtn_Click(sender As Object, e As EventArgs) Handles bVfBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            bVfBtn.Text = scoreOne
            fVbBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub cVfBtn_Click(sender As Object, e As EventArgs) Handles cVfBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            cVfBtn.Text = scoreOne
            fVcBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub dVfBtn_Click(sender As Object, e As EventArgs) Handles dVfBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            dVfBtn.Text = scoreOne
            fVdBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub eVfBtn_Click(sender As Object, e As EventArgs) Handles eVfBtn.Click
        If access = True Then
            enterScore(scoreOne, scoreTwo)
            eVfBtn.Text = scoreOne
            fVeBtn.Text = scoreTwo
        Else
            MsgBox("the scoresheet has been locked for editing", vbCritical, "Unable to process request")
        End If
    End Sub
    '///////////////////////////////////////////////////////////////////score buttons end /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub addPeople_Click(sender As Object, e As EventArgs) 'add people shows the add people form
        addcompetitors.Show()
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////End Buttons///////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub EndBtn_Click(sender As Object, e As EventArgs) Handles EndBtn.Click 'works out the end scores 
        If access = True Then
            Dim number As Integer = compStart.numBox.Text
            Select Case number
                Case Is = 2
                    Try 'checks all the scores have been entered
                        Ascore = aVbBtn.Text
                        AHit = bVaBtn.Text
                        Bscore = bVaBtn.Text
                        BHit = aVbBtn.Text
                        AaverageS = Ascore / 1
                        AaverageH = AHit / 1
                        BaverageS = Bscore / 1 'finding averages
                        BaverageH = BHit / 1
                        Dim Bwin As Integer
                        If bVaBtn.Text = compStart.scoreBox.Text Then
                            Bwin = Bwin + 1
                        End If
                        Dim Awin As Integer
                        If aVbBtn.Text = compStart.scoreBox.Text Then 'finding winner of each metch
                            Awin = Awin + 1
                        End If
                        If Awin > Bwin Then
                            Apos = 1
                            Bpos = 2
                        Else
                            Bpos = 1
                            Apos = 2
                        End If
                        Bwinrate = Bwin * 100 'finding average winrate
                        Awinrate = Awin * 100
                        Aindicator = Ascore - AHit   'working out indicators
                        Bindicator = Bscore - BHit
                        result()
                    Catch ex As Exception 'if errror orucrs propt the user to correct data 
                        MsgBox("one or more of the scores has not been entered", vbCritical, "Unable to process request")
                    End Try
                Case Is = 3 'this uses the same process as case is 2 but on a larger scale 
                    Try
                        Ascore = aVbBtn.Text
                        Ascore = Ascore + aVcBtn.Text
                        AHit = bVaBtn.Text
                        AHit = bVaBtn.Text + cVaBtn.Text
                        Bscore = bVaBtn.Text
                        Bscore = Bscore + bVcBtn.Text
                        BHit = aVbBtn.Text
                        BHit = BHit + cVbBtn.Text
                        AaverageS = Ascore / 2
                        AaverageH = AHit / 2
                        BaverageS = Bscore / 2
                        BaverageH = BHit / 2
                        Cscore = cVaBtn.Text
                        Cscore = Cscore + cVbBtn.Text
                        CHit = aVcBtn.Text
                        CHit = CHit + bVcBtn.Text
                        CaverageS = Cscore / 2
                        CaverageH = CHit / 2
                        Dim Bwin As Integer
                        Dim Awin As Integer
                        Dim cwin As Integer
                        If bVaBtn.Text = compStart.scoreBox.Text Then
                            Bwin = Bwin + 1
                        End If
                        If bVcBtn.Text = compStart.scoreBox.Text Then
                            Bwin = Bwin + 1
                        End If
                        If aVbBtn.Text = compStart.scoreBox.Text Then
                            Awin = Awin + 1
                        End If
                        If aVcBtn.Text = compStart.scoreBox.Text Then
                            Awin = Awin + 1
                        End If
                        If cVbBtn.Text = compStart.scoreBox.Text Then
                            cwin = cwin + 1
                        End If
                        If cVaBtn.Text = compStart.scoreBox.Text Then
                            cwin = cwin + 1
                        End If
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        Dim listlength As Integer = 3
                        Dim poslist(listlength) As String
                        poslist = {Bwin, Awin, cwin}
                        Dim temp As String
                        Dim swapmade As Boolean = True
                        While swapmade = True
                            swapmade = False
                            For position = 0 To listlength - 2
                                If poslist(position) < poslist(position + 1) Then
                                    temp = poslist(position)
                                    poslist(position) = poslist(position + 1)
                                    poslist(position + 1) = temp
                                    swapmade = True
                                End If
                            Next
                        End While
                        For position = 0 To (listlength - 1)
                            If poslist(position) = Awin And Apos = 0 Then
                                Apos = position + 1
                            End If
                            If poslist(position) = cwin And Cpos = 0 Then
                                Cpos = position + 1

                            End If
                            If poslist(position) = Bwin And Bpos = 0 Then
                                Bpos = position + 1
                            End If
                        Next
                        Aindicator = Ascore - AHit
                        Bindicator = Bscore - BHit
                        Cindicator = Cscore - CHit
                        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        Bwinrate = Bwin * 50
                        Awinrate = Awin * 50
                        Cwinrate = cwin * 50
                        result()
                    Catch ex As Exception
                        MsgBox("one or more of the scores has not been entered", vbCritical, "Unable to process request")
                    End Try
                Case Is = 4 'this uses the same process as case is 2 but on a larger scale 
                    Try
                        Ascore = aVbBtn.Text
                        Ascore = Ascore + aVcBtn.Text 'set up a sxore
                        Ascore = Ascore + aVdBtn.Text
                        AHit = bVaBtn.Text
                        AHit = AHit + cVaBtn.Text
                        AHit = AHit + dVaBtn.Text ' A hits 
                        Bscore = bVaBtn.Text
                        Bscore = Bscore + bVcBtn.Text ' b score
                        Bscore = Bscore + bVdBtn.Text
                        BHit = aVbBtn.Text
                        BHit = BHit + cVbBtn.Text 'b hit
                        BHit = BHit + dVbBtn.Text
                        AaverageS = Ascore / 3
                        AaverageH = AHit / 3 ' averages a and b
                        BaverageS = Bscore / 3
                        BaverageH = BHit / 3
                        Cscore = cVaBtn.Text 'c score
                        Cscore = Cscore + cVbBtn.Text
                        Cscore = Cscore + cVdBtn.Text
                        CHit = cVaBtn.Text 'c hit
                        CHit = CHit + bVcBtn.Text
                        CHit = CHit + dVcBtn.Text
                        CaverageS = Cscore / 3 ' average work out
                        CaverageH = CHit / 3
                        Dscore = dVaBtn.Text ' d score 
                        Dscore = Dscore + dVbBtn.Text
                        Dscore = Dscore + dVcBtn.Text
                        DHit = aVdBtn.Text
                        DHit = DHit + bVdBtn.Text 'd hits
                        DHit = DHit + cVdBtn.Text
                        DaverageS = Dscore / 3
                        DaverageH = DHit / 3 ' d avarages
                        Dim Bwin As Integer 'seting up the win varables
                        Dim Awin As Integer
                        Dim Dwin As Integer
                        Dim cwin As Integer
                        ''get number of wins for each compeiitior 
                        If bVaBtn.Text = compStart.scoreBox.Text Then
                            Bwin = Bwin + 1
                        End If
                        If bVcBtn.Text = compStart.scoreBox.Text Then
                            Bwin = Bwin + 1
                        End If
                        If bVdBtn.Text = compStart.scoreBox.Text Then
                            Bwin = Bwin + 1
                        End If
                        If aVbBtn.Text = compStart.scoreBox.Text Then
                            Awin = Awin + 1
                        End If
                        If aVcBtn.Text = compStart.scoreBox.Text Then
                            Awin = Awin + 1
                        End If
                        If aVdBtn.Text = compStart.scoreBox.Text Then
                            Awin = Awin + 1
                        End If
                        If cVbBtn.Text = compStart.scoreBox.Text Then
                            cwin = cwin + 1
                        End If
                        If cVaBtn.Text = compStart.scoreBox.Text Then
                            cwin = cwin + 1
                        End If
                        If cVdBtn.Text = compStart.scoreBox.Text Then
                            cwin = cwin + 1
                        End If
                        If dVaBtn.Text = compStart.scoreBox.Text Then
                            Dwin = Dwin + 1
                        End If
                        If dVbBtn.Text = compStart.scoreBox.Text Then
                            Dwin = Dwin + 1
                        End If
                        If dVcBtn.Text = compStart.scoreBox.Text Then
                            Dwin = Dwin + 1
                        End If
                        'sorting algorithms()
                        Dim listlength As Integer = 4
                        Dim poslist(listlength) As String
                        poslist = {Bwin, Awin, cwin, Dwin}
                        Dim temp As String
                        Dim swapmade As Boolean = True
                        While swapmade = True
                            swapmade = False
                            For position = 0 To listlength - 2
                                If poslist(position) < poslist(position + 1) Then

                                    temp = poslist(position)
                                    poslist(position) = poslist(position + 1)
                                    poslist(position + 1) = temp
                                    swapmade = True
                                End If
                            Next
                        End While
                        For position = 0 To (listlength - 1)
                            If poslist(position) = Awin And Apos = 0 Then
                                Apos = position + 1
                            End If
                            If poslist(position) = Bwin And Bpos = 0 Then
                                Bpos = position + 1
                            End If
                            If poslist(position) = cwin And Cpos = 0 Then
                                Cpos = position + 1
                            End If
                            If poslist(position) = Dwin And Dpos = 0 Then
                                Dpos = position + 1

                            End If
                        Next
                        Aindicator = Ascore - AHit 'work out indicators for each person
                        Bindicator = Bscore - BHit
                        Cindicator = Cscore - CHit
                        Dindicator = Dscore - DHit
                        Bwinrate = Bwin * 33 'set up win rate
                        Awinrate = Awin * 33
                        Cwinrate = cwin * 33
                        Dwinrate = Dwin * 33
                        result()
                    Catch ex As Exception 'error message 
                        MsgBox("one or more of the scores has not been entered", vbCritical, "Unable to process request")
                    End Try
                Case Is = 5 'this uses the same process as case is 2 but on a larger scale 
                    Try
                        Ascore = aVbBtn.Text
                        Ascore = Ascore + aVcBtn.Text
                        Ascore = Ascore + aVdBtn.Text
                        Ascore = Ascore + aVeBtn.Text
                        AHit = bVaBtn.Text
                        AHit = AHit + cVaBtn.Text
                        AHit = AHit + dVaBtn.Text
                        AHit = AHit + eVaBtn.Text
                        Bscore = bVaBtn.Text
                        Bscore = Bscore + bVcBtn.Text
                        Bscore = Bscore + bVdBtn.Text
                        Bscore = Bscore + bVeBtn.Text
                        BHit = aVbBtn.Text
                        BHit = BHit + cVbBtn.Text
                        BHit = BHit + dVbBtn.Text
                        BHit = BHit + eVbBtn.Text
                        AaverageS = Ascore / 4
                        AaverageH = AHit / 4
                        BaverageS = Bscore / 4
                        BaverageH = BHit / 4
                        Cscore = cVaBtn.Text
                        Cscore = Cscore + cVbBtn.Text
                        Cscore = Cscore + cVdBtn.Text
                        Cscore = Cscore + cVeBtn.Text
                        CHit = aVcBtn.Text
                        CHit = CHit + bVcBtn.Text
                        CHit = CHit + dVcBtn.Text
                        CHit = CHit + eVcBtn.Text
                        CaverageS = Cscore / 4
                        CaverageH = CHit / 4
                        Dscore = dVaBtn.Text
                        Dscore = Dscore + dVbBtn.Text
                        Dscore = Dscore + dVcBtn.Text
                        Dscore = Dscore + dVeBtn.Text
                        DHit = aVdBtn.Text
                        DHit = DHit + bVdBtn.Text
                        DHit = DHit + cVdBtn.Text
                        DHit = DHit + eVdBtn.Text
                        DaverageS = Dscore / 4
                        DaverageH = DHit / 4
                        Escore = eVaBtn.Text
                        Escore = Escore + eVbBtn.Text
                        Escore = Escore + eVcBtn.Text
                        Escore = Escore + eVdBtn.Text
                        EHit = aVeBtn.Text
                        EHit = EHit + bVeBtn.Text
                        EHit = EHit + cVeBtn.Text
                        EHit = EHit + dVeBtn.Text
                        EaverageS = Escore / 4
                        EaverageH = EHit / 4
                        Dim Bwin As Integer
                        Dim Awin As Integer
                        Dim Dwin As Integer
                        Dim cwin As Integer
                        Dim ewin As Integer
                        If bVaBtn.Text = compStart.scoreBox.Text Then
                            Bwin = Bwin + 1
                        End If
                        If bVcBtn.Text = compStart.scoreBox.Text Then
                            Bwin = Bwin + 1
                        End If
                        If bVdBtn.Text = compStart.scoreBox.Text Then
                            Bwin = Bwin + 1
                        End If
                        If bVeBtn.Text = compStart.scoreBox.Text Then
                            Bwin = Bwin + 1
                        End If
                        If aVbBtn.Text = compStart.scoreBox.Text Then
                            Awin = Awin + 1
                        End If
                        If aVcBtn.Text = compStart.scoreBox.Text Then
                            Awin = Awin + 1
                        End If
                        If aVdBtn.Text = compStart.scoreBox.Text Then
                            Awin = Awin + 1
                        End If
                        If aVeBtn.Text = compStart.scoreBox.Text Then
                            Awin = Awin + 1
                        End If
                        If cVbBtn.Text = compStart.scoreBox.Text Then
                            cwin = cwin + 1
                        End If
                        If cVaBtn.Text = compStart.scoreBox.Text Then
                            cwin = cwin + 1
                        End If
                        If cVdBtn.Text = compStart.scoreBox.Text Then
                            cwin = cwin + 1
                        End If
                        If cVeBtn.Text = compStart.scoreBox.Text Then
                            cwin = cwin + 1
                        End If
                        If dVaBtn.Text = compStart.scoreBox.Text Then
                            Dwin = Dwin + 1
                        End If
                        If dVbBtn.Text = compStart.scoreBox.Text Then
                            Dwin = Dwin + 1
                        End If
                        If dVcBtn.Text = compStart.scoreBox.Text Then
                            Dwin = Dwin + 1
                        End If
                        If dVeBtn.Text = compStart.scoreBox.Text Then
                            Dwin = Dwin + 1
                        End If
                        If eVaBtn.Text = compStart.scoreBox.Text Then
                            ewin = ewin + 1
                        End If
                        If eVbBtn.Text = compStart.scoreBox.Text Then
                            ewin = ewin + 1
                        End If
                        If eVcBtn.Text = compStart.scoreBox.Text Then
                            ewin = ewin + 1
                        End If
                        If eVdBtn.Text = compStart.scoreBox.Text Then
                            ewin = ewin + 1
                        End If
                        Dim listlength As Integer = 5
                        Dim poslist(listlength) As String
                        poslist = {Bwin, Awin, cwin, Dwin, ewin}
                        Dim temp As String
                        Dim swapmade As Boolean = True
                        While swapmade = True
                            swapmade = False
                            For position = 0 To listlength - 2
                                If poslist(position) < poslist(position + 1) Then
                                    temp = poslist(position)
                                    poslist(position) = poslist(position + 1)
                                    poslist(position + 1) = temp
                                    swapmade = True
                                End If
                            Next
                        End While
                        For position = 0 To (listlength - 1)
                            If poslist(position) = Awin And Apos = 0 Then
                                Apos = position + 1
                            End If
                            If poslist(position) = Bwin And Bpos = 0 Then
                                Bpos = position + 1
                            End If
                            If poslist(position) = cwin And Cpos = 0 Then
                                Cpos = position + 1
                            End If
                            If poslist(position) = Dwin And Dpos = 0 Then
                                Dpos = position + 1
                            End If
                            If poslist(position) = ewin And Epos = 0 Then
                                Epos = position + 1
                            End If
                        Next
                        Bwinrate = Bwin * 25
                        Awinrate = Awin * 25
                        Cwinrate = cwin * 25
                        Dwinrate = Dwin * 25
                        Ewinrate = ewin * 25
                        Aindicator = Ascore - AHit
                        Bindicator = Bscore - BHit
                        Cindicator = Cscore - CHit
                        Dindicator = Dscore - DHit
                        Eindicator = Escore - EHit
                        result()
                    Catch ex As Exception
                        MsgBox("one or more of the scores has not been entered", vbCritical, "Unable to process request")
                    End Try
                Case Is = 6 'this uses the same process as case is 2 but on a larger scale 
                    Try
                        Ascore = aVbBtn.Text
                        Ascore = Ascore + aVcBtn.Text
                        Ascore = Ascore + aVdBtn.Text
                        Ascore = Ascore + aVeBtn.Text
                        Ascore = Ascore + aVfBtn.Text
                        AHit = bVaBtn.Text
                        AHit = AHit + cVaBtn.Text
                        AHit = AHit + dVaBtn.Text
                        AHit = AHit + eVaBtn.Text
                        AHit = AHit + fVaBtn.Text
                        Bscore = bVaBtn.Text
                        Bscore = Bscore + bVcBtn.Text
                        Bscore = Bscore + bVdBtn.Text
                        Bscore = Bscore + bVeBtn.Text
                        Bscore = Bscore + bVfBtn.Text
                        BHit = aVbBtn.Text
                        BHit = BHit + cVbBtn.Text
                        BHit = BHit + dVbBtn.Text
                        BHit = BHit + eVbBtn.Text
                        BHit = BHit + fVbBtn.Text
                        AaverageS = Ascore / 5
                        AaverageH = AHit / 5
                        BaverageS = Bscore / 5
                        BaverageH = BHit / 5
                        Cscore = cVaBtn.Text
                        Cscore = Cscore + cVbBtn.Text
                        Cscore = Cscore + cVdBtn.Text
                        Cscore = Cscore + cVeBtn.Text
                        Cscore = Cscore + cVfBtn.Text
                        CHit = aVcBtn.Text
                        CHit = CHit + bVcBtn.Text
                        CHit = CHit + dVcBtn.Text
                        CHit = CHit + eVcBtn.Text
                        CHit = CHit + fVcBtn.Text
                        CaverageS = Cscore / 5
                        CaverageH = CHit / 5
                        Dscore = dVaBtn.Text
                        Dscore = Dscore + dVbBtn.Text
                        Dscore = Dscore + dVcBtn.Text
                        Dscore = Dscore + dVeBtn.Text
                        Dscore = Dscore + dVfBtn.Text
                        DHit = aVdBtn.Text
                        DHit = DHit + bVdBtn.Text
                        DHit = DHit + cVdBtn.Text
                        DHit = DHit + eVdBtn.Text
                        DHit = DHit + fVdBtn.Text
                        DaverageS = Dscore / 5
                        DaverageH = DHit / 5
                        Escore = eVaBtn.Text
                        Escore = Escore + eVbBtn.Text
                        Escore = Escore + eVcBtn.Text
                        Escore = Escore + eVdBtn.Text
                        Escore = Escore + eVfBtn.Text
                        EHit = EHit + bVeBtn.Text
                        DHit = EHit + cVeBtn.Text
                        EHit = EHit + dVeBtn.Text
                        EHit = EHit + fVeBtn.Text
                        EaverageS = Escore / 5
                        EaverageH = EHit / 5
                        Fscore = fVaBtn.Text
                        Fscore = Fscore + fVbBtn.Text
                        Fscore = Fscore + fVcBtn.Text
                        Fscore = Fscore + fVdBtn.Text
                        Fscore = Fscore + fVeBtn.Text
                        FHit = aVfBtn.Text
                        FHit = FHit + bVfBtn.Text
                        FHit = FHit + cVfBtn.Text
                        FHit = FHit + dVfBtn.Text
                        FHit = FHit + eVfBtn.Text
                        FaverageS = Fscore / 5
                        FaverageH = FHit / 5
                        Dim Bwin As Integer
                        Dim Awin As Integer
                        Dim Dwin As Integer
                        Dim cwin As Integer
                        Dim ewin As Integer
                        If bVaBtn.Text = compStart.scoreBox.Text Then
                            Bwin = Bwin + 1
                        End If
                        If bVcBtn.Text = compStart.scoreBox.Text Then
                            Bwin = Bwin + 1
                        End If
                        If bVfBtn.Text = compStart.scoreBox.Text Then
                            Bwin = Bwin + 1
                        End If
                        If bVdBtn.Text + compStart.scoreBox.Text Then
                            Bwin = Bwin + 1
                        End If
                        If bVeBtn.Text + compStart.scoreBox.Text Then
                            Bwin = Bwin + 1
                        End If
                        If aVbBtn.Text = compStart.scoreBox.Text Then
                            Awin = Awin + 1
                        End If
                        If aVfBtn.Text = compStart.scoreBox.Text Then
                            Awin = Awin + 1
                        End If
                        If aVcBtn.Text = compStart.scoreBox.Text Then
                            Awin = Awin + 1
                        End If
                        If aVdBtn.Text = compStart.scoreBox.Text Then
                            Awin = Awin + 1
                        End If
                        If aVeBtn.Text = compStart.scoreBox.Text Then
                            Awin = Awin + 1
                        End If
                        If cVbBtn.Text = compStart.scoreBox.Text Then
                            cwin = cwin + 1
                        End If
                        If cVaBtn.Text = compStart.scoreBox.Text Then
                            cwin = cwin + 1
                        End If
                        If cVfBtn.Text = compStart.scoreBox.Text Then
                            cwin = cwin + 1
                        End If
                        If cVdBtn.Text = compStart.scoreBox.Text Then
                            cwin = cwin + 1
                        End If
                        If cVeBtn.Text = compStart.scoreBox.Text Then
                            cwin = cwin + 1
                        End If
                        If dVaBtn.Text = compStart.scoreBox.Text Then
                            Dwin = Dwin + 1
                        End If
                        If dVbBtn.Text = compStart.scoreBox.Text Then
                            Dwin = Dwin + 1
                        End If
                        If dVfBtn.Text = compStart.scoreBox.Text Then
                            Dwin = Dwin + 1
                        End If
                        If dVcBtn.Text = compStart.scoreBox.Text Then
                            Dwin = Dwin + 1
                        End If
                        If dVeBtn.Text = compStart.scoreBox.Text Then
                            Dwin = Dwin + 1
                        End If
                        If eVaBtn.Text = compStart.scoreBox.Text Then
                            ewin = ewin + 1
                        End If
                        If eVbBtn.Text = compStart.scoreBox.Text Then
                            ewin = ewin + 1
                        End If
                        If eVcBtn.Text = compStart.scoreBox.Text Then
                            ewin = ewin + 1
                        End If
                        If eVdBtn.Text = compStart.scoreBox.Text Then
                            ewin = ewin + 1
                        End If
                        If eVfBtn.Text = compStart.scoreBox.Text Then
                            ewin = ewin + 1
                        End If
                        Dim fwin As Integer
                        If fVaBtn.Text = maxPoint.scoreBox.Text Then
                            fwin = fwin + 1
                        End If
                        If fVbBtn.Text = maxPoint.scoreBox.Text Then
                            fwin = fwin + 1
                        End If
                        If fVcBtn.Text = maxPoint.scoreBox.Text Then
                            fwin = fwin + 1
                        End If
                        If fVdBtn.Text = maxPoint.scoreBox.Text Then
                            fwin = fwin + 1
                        End If
                        If fVeBtn.Text = maxPoint.scoreBox.Text Then
                            fwin = fwin + 1
                        End If
                        Dim listlength As Integer = 6
                        Dim poslist(listlength) As String
                        poslist = {Bwin, Awin, cwin, Dwin, ewin, fwin}
                        Dim temp As String
                        Dim swapmade As Boolean = True
                        While swapmade = True
                            swapmade = False
                            For position = 0 To listlength - 2
                                If poslist(position) < poslist(position + 1) Then
                                    temp = poslist(position)
                                    poslist(position) = poslist(position + 1)
                                    poslist(position + 1) = temp
                                    swapmade = True
                                End If
                            Next
                        End While
                        For position = 0 To (listlength - 1)
                            If poslist(position) = Awin And Apos = 0 Then
                                Apos = position + 1
                            End If
                            If poslist(position) = Bwin And Bpos = 0 Then
                                Bpos = position + 1
                            End If
                            If poslist(position) = cwin And Cpos = 0 Then
                                Cpos = position + 1
                            End If
                            If poslist(position) = Dwin And Dpos = 0 Then
                                Dpos = position + 1
                            End If
                            If poslist(position) = ewin And Epos = 0 Then
                                Epos = position + 1
                            End If
                            If poslist(position) = fwin And Fpos = 0 Then
                                Fpos = position + 1
                            End If
                        Next
                        Bwinrate = Bwin * 20 ' work out win rate and indicator s
                        Awinrate = Awin * 20
                        Cwinrate = cwin * 20
                        Dwinrate = Dwin * 20
                        Ewinrate = ewin * 20
                        Fwinrate = fwin * 20
                        Aindicator = Ascore - AHit
                        Bindicator = Bscore - BHit
                        Cindicator = Cscore - CHit
                        Dindicator = Dscore - DHit
                        Eindicator = Escore - EHit
                        Findicator = Fscore - FHit
                        result()
                    Catch ex As Exception
                        MsgBox("one or more of the scores has not been entered", vbCritical, "Unable to process request")
                    End Try
            End Select
        End If
        access = False 'locks the score sheet so cant be eddited
    End Sub
    Sub result() 'function to set up the results table
        results.topPos.Text = Apos
        results.firstname.Text = AName.Text
        results.SecondPOs.Text = Bpos
        results.secondname.Text = Bname.Text
        results.ThirdPos.Text = Cpos
        results.thirdname.Text = Cname.Text
        results.fourthname.Text = dName.Text
        results.FourthPos.Text = Dpos
        results.Fithpos.Text = Epos
        results.fithname.Text = ename.Text
        results.sixthname.Text = fname.Text
        results.SixthPos.Text = Fpos
        results.Show() 'show result
    End Sub
    Sub playerdata(score1, score2, score3, score4, score5, id) 'functionto display live palyer information
        Dim con As New OleDb.OleDbConnection
        Dim dbprovider As String
        Dim dbsource As String 'set up databaas econaection
        Dim thedatabase As String
        Dim fullpath As String
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String
        Dim maxrows As Integer
        Dim inc As Integer
        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;" ' make up the cponnection
        thedatabase = "/FencingCompData.mdb"
		fullpath = "E:\working project startup vers 3\project startup vers 1" 'files
		dbsource = "data source= " & fullpath & thedatabase
        con.ConnectionString = dbprovider & dbsource
        con.Open()
        'finding data
        sql = "SELECT * FROM competitorData" 'sql stament 
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "data_comp")
        con.Close()
        maxrows = ds.Tables("data_comp").Rows.Count
        inc = -1
        Dim int As Integer = 0
        sql = "SELECT *  FROM [CompetitorData]" ' sql stament 
        Dim da1 = New OleDb.OleDbDataAdapter(sql, con)
        da1.Fill(ds, "data_com") 'fill data set
        maxrows = ds.Tables("data_com").Rows.Count
        maxrows = maxrows - 1
        While ds.Tables("data_com").Rows(int).Item(0) <> id
            int = int + 1 'populate form 
            progress.IDBox.Text = id
            progress.SnameBox.Text = ds.Tables("data_com").Rows(int).Item(2)
            progress.AgeBox.Text = ds.Tables("data_com").Rows(int).Item(3)
            progress.FNameBox.Text = ds.Tables("data_com").Rows(int).Item(1)
        End While
        progress.PrScore.Series("Scores").Points.Clear()
        progress.PrScore.Series("Scores").Points.AddXY("1", score1) 'draw graph
        progress.PrScore.Series("Scores").Points.AddXY("2", score2)
        progress.PrScore.Series("Scores").Points.AddXY("3", score3)
        progress.PrScore.Series("Scores").Points.AddXY("4", score4)
        progress.PrScore.Series("Scores").Points.AddXY("5", score5)
        progress.Show()
    End Sub



    Private Sub fname__Click(sender As Object, e As EventArgs) Handles fname.Click 'buttons that call the palyer data function
        playerdata(fVaBtn.Text, fVbBtn.Text, fVcBtn.Text, fVdBtn.Text, fVeBtn.Text, fId.Text)
    End Sub
    Private Sub Aname_Click(sender As Object, e As EventArgs) Handles AName.Click
        playerdata(aVbBtn.Text, aVcBtn.Text, aVdBtn.Text, aVeBtn.Text, aVfBtn.Text, aID.Text)
    End Sub

    Private Sub Cname__Click(sender As Object, e As EventArgs) Handles Cname.Click
        playerdata(cVaBtn.Text, cVbBtn.Text, cVdBtn.Text, cVeBtn.Text, cVfBtn.Text, CId.Text)
    End Sub
    Private Sub Dname__Click(sender As Object, e As EventArgs) Handles dName.Click
        playerdata(dVaBtn.Text, dVbBtn.Text, dVcBtn.Text, dVeBtn.Text, dVfBtn.Text, dId.Text)
    End Sub
    Private Sub Ename__Click(sender As Object, e As EventArgs) Handles ename.Click
        playerdata(eVaBtn.Text, eVbBtn.Text, eVcBtn.Text, eVdBtn.Text, eVfBtn.Text, eId.Text)
    End Sub
    Private Sub Bname__Click(sender As Object, e As EventArgs) Handles Bname.Click
        playerdata(bVaBtn.Text, bVcBtn.Text, bVdBtn.Text, bVeBtn.Text, bVfBtn.Text, Bid.Text)
    End Sub


    Sub closecheck(form) 'function to make sure they want to close the form
        Dim yes As String
        yes = MsgBox(" are you sure you want to continue. ", vbYesNo, "attention")
        If yes = DialogResult.Yes Then
            form.Show()
        End If
    End Sub



    Private Sub ViewResults_Click(sender As Object, e As EventArgs) Handles ViewResults.Click 'see results if they have already been calcualted
        If results.proved = True Then
            results.Show()
        Else
            MsgBox("results have not yet been calcualted", , "Unable to process request")
        End If
    End Sub

    Private Sub MainMenubtn_Click(sender As Object, e As EventArgs) Handles MainMenubtn.Click 'back to amin menu
        closecheck(mainMenu)
        Me.Hide()
    End Sub

    Private Sub ViewStatistics_Click(sender As Object, e As EventArgs) Handles ViewStatistics.Click 'see graphs
        mainMenu.partNeeded(records)
        Me.Hide()

    End Sub

    Private Sub PracticeMatch_Click(sender As Object, e As EventArgs) Handles PracticeMatch.Click ' show practicce match
        closecheck(practice)
        Me.Hide()
    End Sub




    Private Sub stopBtn_Click(sender As Object, e As EventArgs) Handles stopBtn.Click 'stop the competition early
        If access = True Then 'check there access
            Dim yes As String
            yes = MsgBox("this action will delate any un saved data are you sure you want to continue. ", vbYesNo, "attention") 'yes no button
            If yes = DialogResult.Yes Then
                mainMenu.Show()
                Me.Close()
            End If
        Else
            MsgBox("you dont have access to this at the moment as the score sheet is locked for eddtiting", vbCritical, "Unable to process request")
        End If
    End Sub
    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        loginwindow.logoutfunction() ' logout 
        mainMenu.Show()
        Me.Hide()
    End Sub
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        loginwindow.Show() 'login
    End Sub
    ''add people
    Sub addCompSetup()
        addDbprovider = "provider=Microsoft.Jet.OLEDB.4.0;" 'set up connection
        Addthedatabase = "/FencingCompData.mdb"
		Addfullpath = "E:\working project startup vers 3\project startup vers 1" 'files ' set up data path
		AddDbsource = "data source= " & Addfullpath & Addthedatabase
        Addcon.ConnectionString = addDbprovider & AddDbsource
        Addcon.Open() 'connection open
        'finding data
        Addsql = "SELECT * FROM competitorData" 'sql command
        AddDa = New OleDb.OleDbDataAdapter(Addsql, Addcon)
        AddDa.Fill(AddDs, "data_comp")
        Addcon.Close() 'close connection
        Addmaxrows = AddDs.Tables("data_comp").Rows.Count 'set up the maximum row count 
        Addinc = -1
    End Sub
    Private Sub upload_Click(sender As Object, e As EventArgs) Handles upload.Click
        addCompSetup()
        Addmaxrows = Addmaxrows + 1 'set up macxamam row
        Dim size As Integer
        size = compStart.numBox.Text
        Dim gender As String
        If gender1.Checked Then 'gender radio button 
            gender = "Male"
        Else
            gender = "Female"
        End If
        Dim str As String
        If Addprevoius = True Then
            uploadCompetitor()
        Else
            If Age.Text = "" Then 'validation
                Age.Text = "00"
            End If
            Addcon.Open() 'open connection and save data fo the new commeptitor
            str = "insert into competitorData ([Competitor Id], [name], [Surname], [age], [gender]) values ( ?, ?, ?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, Addcon)
            cmd.Parameters.Add(New OleDbParameter("Competitor Id", CType(Addmaxrows, Integer)))
            cmd.Parameters.Add(New OleDbParameter("name", CType(FirstName.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Surname", CType(Surname.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("age", CType(Age.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("gender", CType(gender, String)))

            Try
                AddpreviousID = Addmaxrows
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                Addcon.Close()
                uploadCompetitor()
            Catch ex As Exception
                MsgBox("An error has occured this is caused buy two competitors being assiend the same id number pleaase re enter the information should this error continue it may be nessersary to deleate records from the database", vbCritical, "Unable to process request")
                Addcon.Close()
            End Try
        End If
        Addprevoius = False
        FirstName.Text = "" 'reset to 0
        Surname.Text = ""
        Age.Text = ""
        If AddnumberofPeople > size Then
            MsgBox("maximum number of people reached ", , "unable to and more competitiors ") 'gray out window
            AddnumberofPeople = 1
            FirstName.ReadOnly = True 'set all the textboxes to read only and disable the buttons
            FirstName.BackColor = Color.LightGray
            Surname.BackColor = Color.LightGray
            Age.BackColor = Color.LightGray
            Surname.ReadOnly = True
            Age.ReadOnly = True
            upload.Enabled = False
            previousBtn.Enabled = False
            backgroundBox.BackColor = Color.LightGray
            previousIDTEXT.ReadOnly = True
        End If
    End Sub

    Sub uploadCompetitor()
        Select Case AddnumberofPeople
            Case Is = 1 'set up which boxes to fill in the score sheet
                aID.Text = AddpreviousID 'set up the id for a 
                AName.Text = FirstName.Text 'pass the name for a
                AName2.Text = AddpreviousID 'set up the second id 
                aID.Show() 'show the texboxes
                AName.Show()
                AName2.Show()
            Case Is = 2
                Bid.Text = AddpreviousID 'set up the b name and id 
                Bname.Text = FirstName.Text
                Bname2.Text = AddpreviousID
                Bid.Show() 'show the b name and id boxes
                Bname.Show()
                Bname2.Show()
            Case Is = 3
                CId.Text = AddpreviousID ' set up c id and name 
                Cname.Text = FirstName.Text
                Cname2.Text = CId.Text
                CId.Show() ' show name and id 
                Cname.Show()
                Cname2.Show()
            Case Is = 4
                dId.Text = AddpreviousID ' set up name and id 
                dName.Text = FirstName.Text
                dName2.Text = dId.Text
                dId.Show()
                dName.Show() 'show id and name boxes 
                dName2.Show()
            Case Is = 5
                eId.Text = AddpreviousID ' set up c id and name 
                ename.Text = FirstName.Text
                ename2.Text = eId.Text
                eId.Show() 'show id and name boxes 
                ename.Show()
                ename2.Show()
            Case Is = 6
                fId.Text = AddpreviousID ' set up c id and name 
                fname.Text = FirstName.Text
                fname2.Text = fId.Text
                fId.Show() 'show id and name boxes 
                fname.Show()
                fname2.Show()
        End Select
        AddnumberofPeople = AddnumberofPeople + 1
        MsgBox("compettitor added ", , "success")
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click 'selection of an old compeititor
        Dim int As Integer = 0 'search from the start 
        addCompSetup() 'set up connection
        Try
            AddpreviousID = previousIDTEXT.Text 'selecting the compeitor 
        Catch ex As Exception
            MsgBox("Cannot search for this Make sure search is in the right format", vbCritical, "Error")
            Exit Sub
        End Try
        Addsql = "SELECT *  FROM [CompetitorData]" 'sql stament
        Dim da1 = New OleDb.OleDbDataAdapter(Addsql, Addcon)
        da1.Fill(AddDs, "data_com")
        Addmaxrows = AddDs.Tables("data_com").Rows.Count
        Addmaxrows = Addmaxrows - 1
        While AddDs.Tables("data_com").Rows(int).Item(0) <> AddpreviousID And int < Addmaxrows 'search the database 
            int = int + 1
            FirstName.Text = AddDs.Tables("data_com").Rows(int).Item(1)
            Surname.Text = AddDs.Tables("data_com").Rows(int).Item(2)
            Age.Text = AddDs.Tables("data_com").Rows(int).Item(3)
            If int < AddDs.Tables("data_com").Rows(Addmaxrows - 1).Item(0) Then

            Else
                FirstName.Text = ""
                Surname.Text = "" 'not found
                MsgBox("not in Data base", vbCritical, "Unable to process request")
                Exit While
            End If
            If AddpreviousID = AddDs.Tables("data_com").Rows(int).Item(0) Then
                Addprevoius = True 'if found
            End If
        End While
        'close the connection
        Addcon.Close()
    End Sub

    Private Sub AName_TextChanged(sender As Object, e As EventArgs) Handles AName.TextChanged

    End Sub
End Class