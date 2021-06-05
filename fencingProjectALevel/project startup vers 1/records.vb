Public Class records
    Dim maxrows As Integer 'sets up the varables that are needed thoruight the form
    Dim Tmaxrows As Integer
    Dim compareScoreID As Integer
    Dim startID As Integer
    Dim Wmaxrows As Integer
    Dim inc As Integer
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim int As Integer
    Dim Tcon As New OleDb.OleDbConnection
    Dim Tda As OleDb.OleDbDataAdapter
    Dim Wcon As New OleDb.OleDbConnection
    Dim Wda As OleDb.OleDbDataAdapter
    Dim findID As Integer


    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        searchPosText.Hide() 'hide search text box

        mainMenu.Hide() 'hide main menu
        CompareBar.Hide() 'hides the comparison charts till there needed
        RecPercentageCompareBox.Hide() 'hide percent box
        comparePercentLabel.Hide() 'hide the percent label
        AwinCompare.Hide() 'hide the compare graphs
        findID = 0 'find id set
        int = -1
        Dim dbprovider As String 'set up database provider
        Dim dbsource As String 'databse socure
        Dim thedatabase As String 'databse name
        Dim fullpath As String 'completed pathway


        SelfCompareBtn.Hide()
        Compare.Hide()
        compareWinnerBtn.Hide()
        'sets up the path to the database for competitor data
        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;" 'link to database
        thedatabase = "/FencingCompData.mdb" 'database name
        fullpath = "\Fencing Program\working project startup vers 3\project startup vers 1" 'files
        dbsource = "data source= " & fullpath & thedatabase 'the path way
        con.ConnectionString = dbprovider & dbsource 'connection string
        con.Open()
        'fill data set
        sql = "SELECT * FROM competitorData" 'make sql stamtent
        da = New OleDb.OleDbDataAdapter(sql, con) 'set dataadapter
        da.Fill(ds, "data_comp") 'fill data set data_comp''''''''''''''''''''''used in the competitor data inofrmation
        con.Close() 'close conection
        'set up the path tto the database for competition data
        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;" 'link to database
        thedatabase = "/FencingCompData.mdb" 'database name
        fullpath = "\Fencing Program\working project startup vers 3\project startup vers 1" 'files
        dbsource = "data source= " & fullpath & thedatabase 'the path way
        Wcon.ConnectionString = dbprovider & dbsource 'connection string
        Wcon.Open()

        'finding data
        sql = "SELECT * FROM compititionData"
        da = New OleDb.OleDbDataAdapter(sql, Wcon) 'fill data set data_competition''''''''''''''''''''''used in the competiton data inoformation
        da.Fill(ds, "data_competition")
        Wcon.Close()

        'set up connection for the score data data set

        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;" 'link to database
        thedatabase = "/FencingCompData.mdb" 'database name
        fullpath = "\Fencing Program\working project startup vers 3\project startup vers 1" 'files
        dbsource = "data source= " & fullpath & thedatabase 'the path way
        Tcon.ConnectionString = dbprovider & dbsource 'connection string

        Tcon.Open()

    End Sub


    Sub setupnextresult() 'clear the graphs and buttons so that a new person can be shown
        SelfCompareBtn.Show() 'shiw buttons
        searchPosText.Show()
        Compare.Show()
        compareWinnerBtn.Show()
        CompareBar.Hide() 'hide old graphs
        comparePercentLabel.Hide() 'hide old labels

        RecPercentageCompareBox.Hide()
        RecPercentageBox.Show()
        HitsRSChart.Show()
        AwinCompare.Hide() 'hide average compare box
        AvHitChart.Show()
    End Sub
    Private Sub NextBtn_Click_1(sender As Object, e As EventArgs) Handles NextBtn.Click
        'this code cycles through so  that the next compeitor can be seen 
        setupnextresult() 'call the setup next function
        maxrows = ds.Tables("data_comp").Rows.Count 'set up the two diffrent max row values
        Wmaxrows = ds.Tables("data_comp").Rows.Count
        sql = "SELECT *  FROM [CompetitorData]" 'filling dataset 
        Dim da1 = New OleDb.OleDbDataAdapter(sql, con)
        da1.Fill(ds, "data_com")
        maxrows = ds.Tables("data_com").Rows.Count 'fill the maxrows
        maxrows = maxrows - 1 'stop maxrows from beignexeeded
        sql = "SELECT * FROM ScoreData"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "data_Score")
        Tmaxrows = ds.Tables("data_Score").Rows.Count
        Tmaxrows = Tmaxrows - 1
        If int = Tmaxrows Then 'loops back round if at maximum
            int = 1
        Else
            int = int + 1
        End If
        AvHitChart.Series("hits").Points.Clear() 'clear the points on the chart aleardy
        AvHitChart.Series("hits").Points.AddXY("Wins", ds.Tables("data_Score").Rows(int).Item(6)) 'plot the graph
        compareScoreID = ds.Tables("data_Score").Rows(int).Item(0)
        startID = ds.Tables("data_Score").Rows(int).Item(2) 'set the start id this will be used in the compare functions and compare buttons
        AvHitChart.Series("hits").Points.AddXY("Loses", 100 - (ds.Tables("data_Score").Rows(int).Item(6))) 'plot the pie chart
        RecPercentageBox.Text = ds.Tables("data_Score").Rows(int).Item(6) & "%" 'whirte the percentage in the box
        HitsRSChart.Series("Hits").Points.Clear() 'clear the points already there
        HitsRSChart.Series("Hits").Points.AddXY("Scored", ds.Tables("data_Score").Rows(int).Item(3)) 'wirte new points
        HitsRSChart.Series("Hits").Points.AddXY("Receved", ds.Tables("data_Score").Rows(int).Item(4))
        RecPositionBox.Text = ds.Tables("data_Score").Rows(int).Item(5) 'put postion in texbox
        While findID <> maxrows 'cyle thorugh the options 
            If findID = maxrows Then
                findID = 1
            End If
            RecIDBox.Text = ds.Tables("data_com").Rows(findID).Item(0) 'fill the textboxes
            RecFirstNameBox.Text = ds.Tables("data_com").Rows(findID).Item(1)
            RecSecondNameBox.Text = ds.Tables("data_com").Rows(findID).Item(2)
            RecAgeBox.Text = ds.Tables("data_com").Rows(findID).Item(3)
            RecGenderBox.Text = ds.Tables("data_com").Rows(findID).Item(4)
            If ds.Tables("data_Score").Rows(int).Item(2) = RecIDBox.Text Then

                Exit While
            Else
                findID = findID + 1 'search the next row
            End If
        End While

        findID = 0 'make find id 0 again
        While findID <> Wmaxrows 'search the next table
            If findID = Wmaxrows Then
                findID = 1 'cycle back round
            End If
            RecWeapon.Text = ds.Tables("data_competition").Rows(findID).Item(4) 'set texbox to value
            'find the type of competition
            If ds.Tables("data_competition").Rows(findID).Item(0) = ds.Tables("data_Score").Rows(int).Item(1) Then
                Exit While 'eaxit when found
            Else
                findID = findID + 1 'search next row
            End If
        End While
    End Sub


    Private Sub BackBtn_Click(sender As Object, e As EventArgs) 'go back to main menue

        mainMenu.Show()
        Me.Close()



    End Sub

    Sub comparison(search) 'validation for the search for comparison function
        If search = "1st" Or search = "FIRST" Or search = "first" Or search = "1" Then
            search = "1"
        ElseIf search = "2nd" Or search = "SECOND" Or search = "second" Or search = "2" Then
            search = "2"
        ElseIf search = "3rd" Or search = "THIRD" Or search = "third" Or search = "3" Then
            search = "3"
        ElseIf search = "4th" Or search = "Fourth" Or search = "FOURTH" Or search = "4" Then
            search = "4"
        ElseIf search = "5th" Or search = "Fith" Or search = "FITH" Or search = "5" Then
            search = "5"

        ElseIf search = "6th" Or search = "Sixth" Or search = "SIXTH" Or search = "6" Then
            search = "6"
        Else
            MsgBox("no recored with this position", , "Error") 'end the function and display message
            Exit Sub
        End If
        'show the new graphs
        compareshow() 'launch the compare show funciton
        comparePercentLabel.Show() 'show the label
        'plot the first set of points
        CompareBar.Series("Searched score").Points.Clear() 'clear points
        CompareBar.Series("Searched score").Points.AddXY("Scored", ds.Tables("data_Score").Rows(int).Item(3)) 'addpoints
        CompareBar.Series("Searched score").Points.AddXY("Receved", (ds.Tables("data_Score").Rows(int).Item(4)))
        findID = 0
        While findID <> maxrows 'search score data for the id selected
            'find the second set of points
            If search = ds.Tables("data_Score").Rows(findID).Item(5) And ds.Tables("data_Score").Rows(findID).Item(1) = ds.Tables("data_Score").Rows(findID).Item(1) Then 'if position match and if 
                CompareBar.Series("Compare score").Points.Clear() 'comp id match
                CompareBar.Series("Compare score").Points.AddXY("Scored", ds.Tables("data_Score").Rows(findID).Item(3)) 'draw bar graph
                CompareBar.Series("Compare score").Points.AddXY("Receved", (ds.Tables("data_Score").Rows(findID).Item(4)))
                RecPercentageCompareBox.Text = ds.Tables("data_Score").Rows(findID).Item(6) & "%"
                AwinCompare.Series("hits").Points.Clear() 'reset pie chart
                AwinCompare.Series("hits").Points.AddXY("Wins", ds.Tables("data_Score").Rows(findID).Item(6)) 'draw pie chart
                AwinCompare.Series("hits").Points.AddXY("Loses", 100 - (ds.Tables("data_Score").Rows(findID).Item(6)))
                Exit While
            Else
                findID = findID + 1 'look at next row
            End If
            If findID = maxrows Then
                MsgBox("no record for this position", , "No value found") 'this record may have been deleted
            End If
        End While
    End Sub


    Private Sub databaseBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReturnToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToMainMenuToolStripMenuItem.Click 'navigation to main menu
        Me.Hide()
        mainMenu.Show()
    End Sub

    Private Sub PracticeMatchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PracticeMatchToolStripMenuItem.Click 'navigation parctie mathc
        Me.Hide()
        practice.Show()
    End Sub

    Private Sub CreateCompetitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateCompetitionToolStripMenuItem.Click 'navigation creat a new 
        mainMenu.fullNeeded(compStart) 'check the acces
        Me.Hide()
    End Sub

    Private Sub ViewDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDatabaseToolStripMenuItem.Click
        mainMenu.fullNeeded(database)
        Me.Hide()
    End Sub


    Private Sub Compare_Click(sender As Object, e As EventArgs) Handles Compare.Click 'button to compare
        Dim search As String
        search = searchPosText.Text
        comparison(search) 'send the value to compare function
    End Sub
    'find the winner to compare
    Private Sub compareWinnerBtn_Click(sender As Object, e As EventArgs) Handles compareWinnerBtn.Click
        comparison("1") 'makes it look for first place
    End Sub
    Sub compareshow() 'show the comear graphs
        CompareBar.Show()
        HitsRSChart.Hide()
        AvHitChart.Hide()
        AwinCompare.Show()
        RecPercentageBox.Hide()
        RecPercentageCompareBox.Show()
        percentLabel.Hide()
    End Sub
    Private Sub SelfCompareBtn_Click(sender As Object, e As EventArgs) Handles SelfCompareBtn.Click  'find and compare to other scores recorded for this competitor
        Dim compareMaxrows As Integer 'set up a max row varable
        compareMaxrows = ds.Tables("data_Score").Rows.Count
        compareshow() 'launch compare setup
        CompareBar.Series("Searched score").Points.Clear() 'clear any pre saved points
        CompareBar.Series("Searched score").Points.AddXY("Scored", ds.Tables("data_Score").Rows(int).Item(3)) 'plot original points
        CompareBar.Series("Searched score").Points.AddXY("Receved", (ds.Tables("data_Score").Rows(int).Item(4)))
        CompareBar.Series("Compare score").Points.Clear() 'clear any pre saved points
        AwinCompare.Series("hits").Points.Clear() 'clear any pre saved points
        'not drawing points for pie chart for the first record
        While findID <= compareMaxrows 'seaarch for the next points in the score data
            Try

                If findID >= maxrows Then
                    MsgBox("no other scores recorded", , "No value found") 'gives end message and sets up a new search
                    findID = 0
                    Exit While

                    'if it is the recorded id and not form the same competition and not the first id enterd (this last part is to stop it looping round 
                ElseIf RecIDBox.Text = ds.Tables("data_Score").Rows(findID).Item(2) And ds.Tables("data_Score").Rows(findID).Item(0) <> compareScoreID And ds.Tables("data_Score").Rows(findID).Item(0) <> startID Then
                    CompareBar.Series("Compare score").Points.Clear() 'draws searched graph
                    CompareBar.Series("Compare score").Points.AddXY("Scored", ds.Tables("data_Score").Rows(findID).Item(3))
                    CompareBar.Series("Compare score").Points.AddXY("Receved", (ds.Tables("data_Score").Rows(findID).Item(4)))
                    RecPercentageCompareBox.Text = ds.Tables("data_Score").Rows(findID).Item(6) & "%"
                    ' AwinCompare.Series("hits").Points.Clear() 'draws the seached sco5re for pie chart
                    AwinCompare.Series("hits").Points.AddXY("Wins", ds.Tables("data_Score").Rows(findID).Item(6))
                    AwinCompare.Series("hits").Points.AddXY("Loses", 100 - (ds.Tables("data_Score").Rows(findID).Item(6)))
                    compareScoreID = ds.Tables("data_Score").Rows(findID).Item(0)
                    Exit While
                Else
                    findID = findID + 1 'search next row
                End If
            Catch ex As Exception
                MsgBox("no other scores recorded", , "No value found") 'gives end message and sets up a new search
                findID = 0
                Exit While
            End Try
        End While
    End Sub

    Private Sub LogInBtn_Click(sender As Object, e As EventArgs) Handles LogInBtn.Click 'login
        loginwindow.Show()
    End Sub

    Private Sub SearchForBtn_Click(sender As Object, e As EventArgs) Handles SearchForBtn.Click 'search for a sepcific competitor 
        setupnextresult() 'set up graphs again
        maxrows = ds.Tables("data_comp").Rows.Count 'set up the max rtows
        Wmaxrows = ds.Tables("data_comp").Rows.Count
        sql = "SELECT *  FROM [CompetitorData]" 'fill the data set
        Dim da1 = New OleDb.OleDbDataAdapter(sql, con)
        da1.Fill(ds, "data_com")
        maxrows = ds.Tables("data_com").Rows.Count
        maxrows = maxrows - 1
        Dim search As Integer
        Try
            search = Searchtext.Text
        Catch ex As Exception
            MsgBox("cannot search for this please enter a number", , "error")
            Exit Sub
        End Try
        sql = "SELECT * FROM ScoreData" 'fill the second date set
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "data_Score")
        Tmaxrows = ds.Tables("data_Score").Rows.Count
        Tmaxrows = Tmaxrows - 1
        int = 0
        While int <= Tmaxrows 'search thrugh using int compared to maxrows of the score data
            If int >= Tmaxrows Then
                MsgBox("no record found") 'if not found 
                Exit While
            ElseIf search = ds.Tables("data_Score").Rows(int).Item(2) Then 'draw the graph points
                AvHitChart.Series("hits").Points.Clear() 'clear the points
                AvHitChart.Series("hits").Points.AddXY("Wins", ds.Tables("data_Score").Rows(int).Item(6)) 'plot amount one
                compareScoreID = ds.Tables("data_Score").Rows(int).Item(0)
                startID = ds.Tables("data_Score").Rows(int).Item(2) 'set start id to the id found 
                AvHitChart.Series("hits").Points.AddXY("Loses", 100 - (ds.Tables("data_Score").Rows(int).Item(6))) 'plot amount lost
                RecPercentageBox.Text = ds.Tables("data_Score").Rows(int).Item(6) & "%"
                HitsRSChart.Series("Hits").Points.Clear() 'clear barchart
                HitsRSChart.Series("Hits").Points.AddXY("Scored", ds.Tables("data_Score").Rows(int).Item(3)) 'plot barchart
                HitsRSChart.Series("Hits").Points.AddXY("Receved", ds.Tables("data_Score").Rows(int).Item(4))
                RecPositionBox.Text = ds.Tables("data_Score").Rows(int).Item(5)
                findID = 0 'set finid to 0
                While findID <> maxrows 'searc through using the find id to find competior data ''''''''''nested while ''
                    If findID >= maxrows Then 'if exeeds max rows
                        MsgBox("not found")
                    End If
                    RecIDBox.Text = ds.Tables("data_com").Rows(findID).Item(0) 'fill the textboxes
                    RecFirstNameBox.Text = ds.Tables("data_com").Rows(findID).Item(1)
                    RecSecondNameBox.Text = ds.Tables("data_com").Rows(findID).Item(2)
                    RecAgeBox.Text = ds.Tables("data_com").Rows(findID).Item(3)
                    RecGenderBox.Text = ds.Tables("data_com").Rows(findID).Item(4)
                    If search = RecIDBox.Text Then
                        Exit While
                    Else
                        findID = findID + 1 'serch next line
                    End If
                End While
                Exit While
            Else : int = int + 1 'search next line
            End If
            findID = 0
            While findID <> Wmaxrows ''second nested while to find the competion data
                If findID = Wmaxrows Then
                    findID = 1
                End If
                RecWeapon.Text = ds.Tables("data_competition").Rows(findID).Item(4) 'set wepon box text
                If ds.Tables("data_competition").Rows(findID).Item(0) = ds.Tables("data_Score").Rows(int).Item(1) Then
                    Exit While 'end the hile loop record found
                Else
                    findID = findID + 1 'seach next line
                End If
            End While
        End While
    End Sub

    Private Sub ScoreSheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScoreSheetToolStripMenuItem.Click
        'load up the score sheet
        If Scoresheet.AName.Text <> "" Then
            If loginwindow.access = "part" Then

                Scoresheet.Show()
                Scoresheet.access = False
                Me.Close()
            Else
                Scoresheet.access = True
                mainMenu.fullNeeded(Scoresheet)
                Me.Close()
            End If
        Else
            MsgBox("there is currently no competion running", vbCritical, "Unable to process request")
        End If
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        loginwindow.logoutfunction()
        mainMenu.Show()
        Me.Close()
    End Sub

End Class