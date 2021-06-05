Imports System.Data.OleDb

Public Class results
    Dim failed As Boolean = False               'setting up varables
    Dim lastID As Integer
    Dim lastID2 As Integer
    Dim LastID3 As Integer
    Dim lastID4 As Integer
    Dim lastID5 As Integer
    Dim lastID6 As Integer
    Dim inc As Integer
    Dim con As New OleDb.OleDbConnection
    Dim dbprovider As String
    Dim dbsource As String
    Dim mydocumentsfolder As String
    Dim thedatabase As String
    Dim fullpath As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim maxrows As Integer
    Public proved As Boolean
    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load 'loading positions
        proved = True
        Dim size As Integer = compStart.numBox.Text 'get the size of competition
        Select Case size 'show the correct boxes for the size of the competition
            Case Is = 2
                ThirdPos.Hide()
                thirdname.Hide()
                FourthPos.Hide()
                fourthname.Hide()
                Fithpos.Hide()
                fithname.Hide()
                SixthPos.Hide()
                sixthname.Hide()
            Case Is = 3
                FourthPos.Hide()
                fourthname.Hide()
                Fithpos.Hide()
                fithname.Hide()
                SixthPos.Hide()
                sixthname.Hide()
            Case Is = 4
                Fithpos.Hide()
                fithname.Hide()
                SixthPos.Hide()
                sixthname.Hide()
            Case Is = 5
                SixthPos.Hide()
                sixthname.Hide()
        End Select
		dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;" 'link to database
		thedatabase = "/FencingCompData.mdb"
        fullpath = "\working project startup vers 3\project startup vers 1" 'make the pathway
		dbsource = "data source= " & fullpath & thedatabase
		con.ConnectionString = dbprovider & dbsource
		con.Open()
		con.Close()
	End Sub
    Sub delete(lastID) 'function for deleating the scores when a competuitio n fails
        con.Open() 'open connection
        sql = "SELECT * FROM ScoreData" 'sql stament 
        Dim delMaxrows As Integer 'set up max row
        Dim da As OleDb.OleDbDataAdapter
        da = New OleDb.OleDbDataAdapter(sql, con) 'fill the data addapter and data set
        da.Fill(ds, "data_score") 'fil data set
        delMaxrows = ds.Tables("data_score").Rows.Count 'count max rows
        con.Close() 'close connection
        con.Open() 'open connection
        Dim comand As String 'set up sql command
        comand = "DELETE * FROM ScoreData where ScoreID= " & lastID & "" 'deleate the id
        Dim cmdR As OleDbCommand = New OleDbCommand(comand, con)
        cmdR.ExecuteNonQuery() 'run
        cmdR.Dispose()
        con.Close() 'close
    End Sub
    Sub SaveA() 'saving the toip score
        
        Dim str As String
        con.Open()
        sql = "SELECT * FROM ScoreData"
        da = New OleDb.OleDbDataAdapter(sql, con) 'fill the data addapter and data set
        da.Fill(ds, "data_Score") 'fill the data set
        maxrows = ds.Tables("data_Score").Rows.Count
        con.Close() 'close conection
        con.Open() 'reset the connection
        str = "insert into ScoreData ([ScoreID], [Comp Id], [Competitor Id], [average points scored],[average points scored against],[position],[average win]) values ( ?, ?, ?,?,?,?,?)" 'insert sql stament
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        maxrows = maxrows + 1 'set up the id number
        lastID = maxrows 'set up the primary key
        'add the values
        cmd.Parameters.Add(New OleDbParameter("ScoreID", CType(maxrows, Integer))) 'id
        cmd.Parameters.Add(New OleDbParameter("Comp Id", CType(Scoresheet.CompIDBox.Text, Integer))) 'competion number
        cmd.Parameters.Add(New OleDbParameter("competitor Id", CType(Scoresheet.aID.Text, Integer))) 'competittor number
        cmd.Parameters.Add(New OleDbParameter("average points scored", CType(Scoresheet.AaverageS, Integer))) 'points scoresd
        cmd.Parameters.Add(New OleDbParameter("average points scored against", CType(Scoresheet.AaverageH, Integer))) 'points hir
        cmd.Parameters.Add(New OleDbParameter("position", CType(topPos.Text, Integer))) 'position
        cmd.Parameters.Add(New OleDbParameter("average win", CType(Scoresheet.Awinrate, Integer))) 'percentage win
        Try
            cmd.ExecuteNonQuery() 'run the code
            cmd.Dispose() 'get rid of the command
            con.Close() 'close the coection
            MsgBox("score saved", , "Save Successfull")
        Catch ex As Exception
            MsgBox("A conflict has occured no data was saved please try to resave the Data", vbCritical, "Error") 'failed to save
            con.Close() 'close connection
            failed = True
        End Try
    End Sub

    Sub saveB() 'saving secomnd s core see save A for comments
        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;"
        thedatabase = "/FencingCompData.mdb"
        fullpath = "\working project startup vers 3\project startup vers 1" 'connection pathway
        dbsource = "data source= " & fullpath & thedatabase
        con.ConnectionString = dbprovider & dbsource
        Dim str As String 'set up string for sql statement 
        con.Open() 'open the connection
        sql = "SELECT * FROM ScoreData" 'fill data set
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "data_Score")
        maxrows = ds.Tables("data_Score").Rows.Count 'set the max row cound
        con.Close() 'close connection
        con.Open() 'open connection
        str = "insert into ScoreData ([ScoreID], [Comp Id], [Competitor Id], [average points scored],[average points scored against],[position],[average win]) values ( ?, ?, ?,?,?,?,?)" 'sql statment
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        maxrows = maxrows + 1 'set up primary key
        lastID2 = maxrows 'save this id to the previous id function for the delete
        cmd.Parameters.Add(New OleDbParameter("ScoreID", CType(maxrows, Integer))) 'data to be saved
        cmd.Parameters.Add(New OleDbParameter("Comp Id", CType(Scoresheet.CompIDBox.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("competitor Id", CType(Scoresheet.Bid.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("average points scored", CType(Scoresheet.BaverageS, Integer)))
        cmd.Parameters.Add(New OleDbParameter("average points scored against", CType(Scoresheet.BaverageH, Integer)))
        cmd.Parameters.Add(New OleDbParameter("position", CType(SecondPOs.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("average win", CType(Scoresheet.Bwinrate, Integer)))
        Try
            cmd.ExecuteNonQuery() 'run command
            cmd.Dispose() 'get rid of command
            con.Close() 'close the coection
            MsgBox("score saved", , "Save Successfull")
        Catch ex As Exception
            MsgBox("A conflict has occured no data was saved please try to resave the Data", vbCritical, "Error") 'error message
            con.Close() 'close the coection
            delete(lastID) 'set last id to be deleated if error
            failed = True
        End Try
    End Sub
    Sub saveC() 'saving third score see save A for comments
        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;"
        thedatabase = "/FencingCompData.mdb"
        fullpath = "\working project startup vers 3\project startup vers 1" 'set up path way
        dbsource = "data source= " & fullpath & thedatabase
        con.ConnectionString = dbprovider & dbsource
        Dim str As String
        con.Open()
        sql = "SELECT * FROM ScoreData" 'fill data adapter
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "data_Score")
        maxrows = ds.Tables("data_Score").Rows.Count
        con.Close()
        con.Open()
        str = "insert into ScoreData ([ScoreID], [Comp Id], [Competitor Id], [average points scored],[average points scored against],[position],[average win]) values ( ?, ?, ?,?,?,?,?)" 'sql command
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        maxrows = maxrows + 1
        LastID3 = maxrows
        cmd.Parameters.Add(New OleDbParameter("ScoreID", CType(maxrows, Integer))) 'save values
        cmd.Parameters.Add(New OleDbParameter("Comp Id", CType(Scoresheet.CompIDBox.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("competitor Id", CType(Scoresheet.CId.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("average points scored", CType(Scoresheet.CaverageS, Integer)))
        cmd.Parameters.Add(New OleDbParameter("average points scored against", CType(Scoresheet.CaverageH, Integer)))
        cmd.Parameters.Add(New OleDbParameter("position", CType(ThirdPos.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("average win", CType(Scoresheet.Cwinrate, Integer)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close() 'close connection
            MsgBox("score saved", , "Save Successfull")
        Catch ex As Exception
            MsgBox("A conflict has occured no data was saved please try to resave the Data", vbCritical, "Error") 'error
            con.Close() 'close connection
            delete(lastID) 'deleat previous data
            delete(lastID2)
            failed = True
        End Try
    End Sub
    Sub saveD() 'saving sixth score see save A for comments
        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;"
        thedatabase = "/FencingCompData.mdb"
        fullpath = "\working project startup vers 3\project startup vers 1" 'create pathway
        dbsource = "data source= " & fullpath & thedatabase
        con.ConnectionString = dbprovider & dbsource
        Dim str As String
        con.Open()
        sql = "SELECT * FROM ScoreData" 'fill data adapter
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "data_Score")
        maxrows = ds.Tables("data_Score").Rows.Count
        con.Close()
        con.Open()
        str = "insert into ScoreData ([ScoreID], [Comp Id], [Competitor Id], [average points scored],[average points scored against],[position],[average win]) values ( ?, ?, ?,?,?,?,?)" 'save data sql command
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        maxrows = maxrows + 1
        lastID4 = maxrows
        cmd.Parameters.Add(New OleDbParameter("ScoreID", CType(maxrows, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Comp Id", CType(Scoresheet.CompIDBox.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("competitor Id", CType(Scoresheet.dId.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("average points scored", CType(Scoresheet.DaverageS, Integer)))
        cmd.Parameters.Add(New OleDbParameter("average points scored against", CType(Scoresheet.DaverageH, Integer)))
        cmd.Parameters.Add(New OleDbParameter("position", CType(FourthPos.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("average win", CType(Scoresheet.Dwinrate, Integer)))
        Try
            cmd.ExecuteNonQuery() 'run command
            cmd.Dispose()
            con.Close()
            'close connection
            MsgBox("score saved", , "Save Successfull")
        Catch ex As Exception
            MsgBox("A conflict has occured no data was saved please try to resave the Data", vbCritical, "Error") 'error
            con.Close()
            delete(lastID) 'delate a 
            delete(lastID2) 'deleate B
            delete(LastID3) 'deleat C
            failed = True
        End Try
    End Sub
    Sub saveE() 'saving fith score see save A for comments
        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;"
        thedatabase = "/FencingCompData.mdb"
        fullpath = "\working project startup vers 3\project startup vers 1" 'pathway
        dbsource = "data source= " & fullpath & thedatabase
        con.ConnectionString = dbprovider & dbsource
        Dim str As String
        con.Open()
        sql = "SELECT * FROM ScoreData"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "data_Score") 'fill data adapter
        maxrows = ds.Tables("data_Score").Rows.Count
        con.Close()
        con.Open()
        str = "insert into ScoreData ([ScoreID], [Comp Id], [Competitor Id], [average points scored],[average points scored against],[position],[average win]) values ( ?, ?, ?,?,?,?,?)" 'sql statment
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        maxrows = maxrows + 1
        lastID5 = maxrows
        cmd.Parameters.Add(New OleDbParameter("ScoreID", CType(maxrows, Integer))) 'save data
        cmd.Parameters.Add(New OleDbParameter("Comp Id", CType(Scoresheet.CompIDBox.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("competitor Id", CType(Scoresheet.eId.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("average points scored", CType(Scoresheet.EaverageS, Integer)))
        cmd.Parameters.Add(New OleDbParameter("average points scored against", CType(Scoresheet.EaverageH, Integer)))
        cmd.Parameters.Add(New OleDbParameter("position", CType(Fithpos.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("average win", CType(Scoresheet.Ewinrate, Integer)))
        Try
            cmd.ExecuteNonQuery() 'run command
            cmd.Dispose() 'dispose of command
            con.Close() 'close connection
            MsgBox("score saved", , "Save Successfull")
        Catch ex As Exception
            MsgBox("A conflict has occured no data was saved please try to resave the Data", vbCritical, "Error")
            con.Close() 'close connection
            delete(lastID) 'deleate A
            delete(lastID4) 'de;leat d
            delete(lastID2) 'deleate b
            delete(LastID3) 'delatec
            failed = True
        End Try
    End Sub
    Sub saveF() 'saving sixth score see save A for comments
        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;" 'set connection
        thedatabase = "/FencingCompData.mdb"
        fullpath = "\working project startup vers 3\project startup vers 1" 'files
        dbsource = "data source= " & fullpath & thedatabase
        con.ConnectionString = dbprovider & dbsource
        Dim str As String
        con.Open() 'open conection
        sql = "SELECT * FROM ScoreData" 'set data set
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "data_Score") 'fill data set
        maxrows = ds.Tables("data_Score").Rows.Count
        con.Close()
        con.Open()
        str = "insert into ScoreData ([ScoreID], [Comp Id], [Competitor Id], [average points scored],[average points scored against],[position],[average win]) values ( ?, ?, ?,?,?,?,?)" 'sql stament
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        lastID6 = maxrows 'set id for deleate
        maxrows = maxrows + 1 'set this id
        cmd.Parameters.Add(New OleDbParameter("ScoreID", CType(maxrows, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Comp Id", CType(Scoresheet.CompIDBox.Text, Integer))) 'save data
        cmd.Parameters.Add(New OleDbParameter("competitor Id", CType(Scoresheet.fId.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("average points scored", CType(Scoresheet.FaverageS, Integer)))
        cmd.Parameters.Add(New OleDbParameter("average points scored against", CType(Scoresheet.FaverageH, Integer)))
        cmd.Parameters.Add(New OleDbParameter("position", CType(SixthPos.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("average win", CType(Scoresheet.Fwinrate, Integer)))
        Try
            cmd.ExecuteNonQuery() 'run command
            cmd.Dispose()
            con.Close() 'close connection
            MsgBox("score saved", , "Save Successfull") 'success
        Catch ex As Exception
            MsgBox("A conflict has occured no data was saved please try to resave the Data", vbCritical, "Error") 'error
            con.Close() 'close connection
            delete(lastID) 'deleate the fisrt score save
            delete(lastID4) 'deleate second score saved
            delete(lastID2) 'deleate third score saved
            delete(LastID3) 'deleat fourth score saved
            delete(lastID5) 'deleate fith score saved 
            failed = True
        End Try
    End Sub
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click 'save button
        Dim size As Integer = compStart.numBox.Text
        failed = False
        Select Case size 'call the save comands for the diffrent scores 
            Case Is = 2 'comp of two people
                SaveA()
                If failed = False Then 'if there has been no failed saves 
                    saveB()
                End If
            Case Is = 3 'comp of 3 people
                SaveA()
                If failed = False Then 'if there has been no failed saves 
                    saveB()
                End If
                If failed = False Then 'if there has been no failed saves 
                    saveC()
                End If
            Case Is = 4 'comp of four people
                SaveA()
                If failed = False Then 'if there has been no failed saves 
                    saveB()
                End If
                If failed = False Then 'if there has been no failed saves 
                    saveC()
                End If
                If failed = False Then 'if there has been no failed saves 
                    saveD()
                End If
            Case Is = 5 'comp of five people
                SaveA()
                If failed = False Then 'if there has been no failed saves 
                    saveB()
                End If
                If failed = False Then 'if there has been no failed saves 
                    saveC()
                End If
                If failed = False Then 'if there has been no failed saves 
                    saveD()
                End If
                If failed = False Then 'if there has been no failed saves 
                    saveE()
                End If
            Case Is = 6 'comp of 6 people
                SaveA()
                If failed = False Then 'if there has been no failed saves 
                    saveB()
                End If
                If failed = False Then 'if there has been no failed saves 
                    saveC()
                End If
                If failed = False Then 'if there has been no failed saves 
                    saveD()
                End If
                If failed = False Then 'if there has been no failed saves 
                    saveE()
                End If
                If failed = False Then 'if there has been no failed saves 
                    saveF()
                End If
        End Select
    End Sub
    Sub enterScore(ByRef scoreOne, ByRef scoreTwo, disbute, IndicatorA, indicatorC, Aname, Bname) 'draw match tie bracker
        If IndicatorA < indicatorC Then 'work out idicators if the top score is lower
            scoreOne = 0
            scoreTwo = 10
        ElseIf indicatorC < IndicatorA Then 'work out idicators if the top score is higher
            scoreOne = 10
            scoreTwo = 0
        ElseIf indicatorC = IndicatorA Then 'run a match if they are the same then copies the code from the score sheet
            MsgBox("match for position number :" & disbute, , "Resolve ties")
            MsgBox("between " & Aname & " : " & Bname, , "Resolve ties") 'say whos playing
            Dim max As Integer
            max = compStart.scoreBox.Text 'set max score
            scoreOne = InputBox("what was the first score", "Resolve ties") 'first score
            If scoreOne = "" Then
                scoreOne = 0
            End If
            While (scoreOne > max)
                MsgBox("this number is too high", vbExclamation, "Error") 'validate
                scoreOne = InputBox("what was the first score", "Resolve ties")
            End While
            scoreTwo = InputBox("what was the second score", "resolve ties") 'second score
            If scoreTwo = "" Then
                scoreTwo = 0
            End If
            While scoreTwo > max
                MsgBox("this number is too high", vbExclamation, "Error") 'validate
                scoreTwo = InputBox("what was the second score", "resolve ties")
            End While
        End If

    End Sub


    Private Sub ResolveBtn_Click(sender As Object, e As EventArgs) Handles ResolveBtn.Click 'solving draws
        Dim scoreOne As Integer 'set up the needed values for the resolve function
        Dim scoreTwo As Integer
        Dim disbute As Integer
        Dim check As Integer
        check = 0
        Dim size As Integer = compStart.numBox.Text
        Select Case size  'this code runs down the list of competitors to find where and where any draws/ conflict have ocured
            Case Is = 3
                While check <> 6
                    disbute = topPos.Text
                    If topPos.Text = SecondPOs.Text Then 'if the same as score A
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Aindicator, Scoresheet.Bindicator, firstname.Text, secondname.Text)
                        If scoreOne > scoreTwo Then 'find winner
                            topPos.Text = topPos.Text
                            SecondPOs.Text = SecondPOs.Text + 1 'set new positions
                        Else
                            topPos.Text = topPos.Text + 1
                            SecondPOs.Text = SecondPOs.Text
                        End If
                    End If
                    If topPos.Text = ThirdPos.Text Then 'check nest result
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Aindicator, Scoresheet.Cindicator, firstname.Text, thirdname.Text)
                        If scoreOne > scoreTwo Then 'find winner
                            topPos.Text = topPos.Text
                            ThirdPos.Text = ThirdPos.Text + 1 'set position
                        Else
                            topPos.Text = topPos.Text + 1
                            ThirdPos.Text = ThirdPos.Text
                        End If
                    End If
                    disbute = SecondPOs.Text 'if same as score B
                    If SecondPOs.Text = ThirdPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Bindicator, Scoresheet.Cindicator, secondname.Text, thirdname.Text)
                        If scoreOne > scoreTwo Then
                            SecondPOs.Text = SecondPOs.Text
                            ThirdPos.Text = ThirdPos.Text + 1
                        Else
                            SecondPOs.Text = SecondPOs.Text + 1
                            ThirdPos.Text = ThirdPos.Text
                        End If
                    End If
                    check = topPos.Text 'validate
                    check = check + SecondPOs.Text
                    check = check + ThirdPos.Text
                End While
            Case Is = 4
                While check <> 10
                    disbute = topPos.Text
                    If topPos.Text = SecondPOs.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Aindicator, Scoresheet.Bindicator, firstname.Text, secondname.Text)
                        If scoreOne > scoreTwo Then
                            topPos.Text = topPos.Text
                            SecondPOs.Text = SecondPOs.Text + 1
                        Else
                            topPos.Text = topPos.Text + 1
                            SecondPOs.Text = SecondPOs.Text
                        End If
                    End If
                    If topPos.Text = ThirdPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Aindicator, Scoresheet.Cindicator, firstname.Text, thirdname.Text)
                        If scoreOne > scoreTwo Then
                            topPos.Text = topPos.Text
                            ThirdPos.Text = ThirdPos.Text + 1
                        Else
                            topPos.Text = topPos.Text + 1
                            ThirdPos.Text = ThirdPos.Text
                        End If
                    End If
                    If topPos.Text = FourthPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Aindicator, Scoresheet.Dindicator, firstname.Text, fourthname.Text)
                        If scoreOne > scoreTwo Then
                            topPos.Text = topPos.Text
                            FourthPos.Text = FourthPos.Text + 1
                        Else
                            topPos.Text = topPos.Text + 1
                            FourthPos.Text = FourthPos.Text
                        End If
                    End If
                    disbute = SecondPOs.Text
                    If SecondPOs.Text = ThirdPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Bindicator, Scoresheet.Cindicator, secondname.Text, thirdname.Text)
                        If scoreOne > scoreTwo Then
                            SecondPOs.Text = SecondPOs.Text
                            ThirdPos.Text = ThirdPos.Text + 1
                        Else
                            SecondPOs.Text = SecondPOs.Text + 1
                            ThirdPos.Text = ThirdPos.Text
                        End If
                    End If
                    If SecondPOs.Text = FourthPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Bindicator, Scoresheet.Dindicator, secondname.Text, fourthname.Text)
                        If scoreOne > scoreTwo Then
                            SecondPOs.Text = SecondPOs.Text
                            FourthPos.Text = FourthPos.Text + 1
                        Else
                            SecondPOs.Text = SecondPOs.Text + 1
                            FourthPos.Text = FourthPos.Text
                        End If
                    End If
                    disbute = ThirdPos.Text
                    If FourthPos.Text = ThirdPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Dindicator, Scoresheet.Cindicator, fourthname.Text, thirdname.Text)
                        If scoreOne > scoreTwo Then
                            FourthPos.Text = FourthPos.Text
                            ThirdPos.Text = ThirdPos.Text + 1
                        Else
                            FourthPos.Text = FourthPos.Text + 1
                            ThirdPos.Text = ThirdPos.Text
                        End If
                    End If
                    disbute = FourthPos.Text
                    check = topPos.Text 'validate
                    check = check + SecondPOs.Text
                    check = check + ThirdPos.Text
                    check = check + FourthPos.Text
                End While
            Case Is = 5
                While check <> 15
                    disbute = topPos.Text
                    If topPos.Text = SecondPOs.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Aindicator, Scoresheet.Bindicator, firstname.Text, secondname.Text)
                        If scoreOne > scoreTwo Then
                            topPos.Text = topPos.Text
                            SecondPOs.Text = SecondPOs.Text + 1
                        Else
                            topPos.Text = topPos.Text + 1
                            SecondPOs.Text = SecondPOs.Text
                        End If
                    End If
                    If topPos.Text = ThirdPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Aindicator, Scoresheet.Cindicator, firstname.Text, thirdname.Text)
                        If scoreOne > scoreTwo Then
                            topPos.Text = topPos.Text
                            ThirdPos.Text = ThirdPos.Text + 1
                        Else
                            topPos.Text = topPos.Text + 1
                            ThirdPos.Text = ThirdPos.Text
                        End If
                    End If
                    If topPos.Text = FourthPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Aindicator, Scoresheet.Dindicator, firstname.Text, fourthname.Text)
                        If scoreOne > scoreTwo Then
                            topPos.Text = topPos.Text
                            FourthPos.Text = FourthPos.Text + 1
                        Else
                            topPos.Text = topPos.Text + 1
                            FourthPos.Text = FourthPos.Text
                        End If
                    End If
                    If topPos.Text = Fithpos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Aindicator, Scoresheet.Eindicator, firstname.Text, fithname.Text)
                        If scoreOne > scoreTwo Then
                            topPos.Text = topPos.Text
                            Fithpos.Text = Fithpos.Text + 1
                        Else
                            topPos.Text = topPos.Text + 1
                            Fithpos.Text = Fithpos.Text
                        End If
                    End If
                    disbute = SecondPOs.Text
                    If SecondPOs.Text = ThirdPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Bindicator, Scoresheet.Cindicator, secondname.Text, thirdname.Text)
                        If scoreOne > scoreTwo Then
                            SecondPOs.Text = SecondPOs.Text
                            ThirdPos.Text = ThirdPos.Text + 1
                        Else
                            SecondPOs.Text = SecondPOs.Text + 1
                            ThirdPos.Text = ThirdPos.Text
                        End If
                    End If
                    If SecondPOs.Text = FourthPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Bindicator, Scoresheet.Dindicator, secondname.Text, fourthname.Text)
                        If scoreOne > scoreTwo Then
                            SecondPOs.Text = SecondPOs.Text
                            FourthPos.Text = FourthPos.Text + 1
                        Else
                            SecondPOs.Text = SecondPOs.Text + 1
                            FourthPos.Text = FourthPos.Text
                        End If
                    End If
                    If SecondPOs.Text = Fithpos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Bindicator, Scoresheet.Eindicator, secondname.Text, fithname.Text)
                        If scoreOne > scoreTwo Then
                            SecondPOs.Text = SecondPOs.Text
                            Fithpos.Text = Fithpos.Text + 1
                        Else
                            SecondPOs.Text = SecondPOs.Text + 1
                            Fithpos.Text = Fithpos.Text
                        End If
                    End If
                    disbute = ThirdPos.Text
                    If ThirdPos.Text = FourthPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Cindicator, Scoresheet.Dindicator, thirdname.Text, fourthname.Text)

                        If scoreOne > scoreTwo Then
                            ThirdPos.Text = ThirdPos.Text
                            FourthPos.Text = FourthPos.Text + 1
                        Else
                            ThirdPos.Text = ThirdPos.Text + 1
                            FourthPos.Text = FourthPos.Text
                        End If
                    End If
                    If ThirdPos.Text = Fithpos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Cindicator, Scoresheet.Eindicator, thirdname.Text, fithname.Text)
                        If scoreOne > scoreTwo Then
                            ThirdPos.Text = ThirdPos.Text
                            Fithpos.Text = Fithpos.Text + 1
                        Else
                            ThirdPos.Text = ThirdPos.Text + 1
                            Fithpos.Text = Fithpos.Text
                        End If
                    End If
                    disbute = FourthPos.Text
                    If FourthPos.Text = Fithpos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Dindicator, Scoresheet.Eindicator, fourthname.Text, fithname.Text)
                        If scoreOne > scoreTwo Then
                            FourthPos.Text = FourthPos.Text
                            Fithpos.Text = Fithpos.Text + 1
                        Else
                            FourthPos.Text = FourthPos.Text + 1
                            Fithpos.Text = Fithpos.Text
                        End If
                    End If
                    check = topPos.Text 'validate
                    check = check + SecondPOs.Text
                    check = check + ThirdPos.Text
                    check = check + FourthPos.Text
                    check = check + Fithpos.Text
                End While
            Case Is = 6
                While check <> 21
                    disbute = topPos.Text
                    If topPos.Text = SecondPOs.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Aindicator, Scoresheet.Bindicator, firstname.Text, secondname.Text)
                        If scoreOne > scoreTwo Then
                            topPos.Text = topPos.Text
                            SecondPOs.Text = SecondPOs.Text + 1
                        Else
                            topPos.Text = topPos.Text + 1
                            SecondPOs.Text = SecondPOs.Text
                        End If
                    End If
                    If topPos.Text = ThirdPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Aindicator, Scoresheet.Cindicator, firstname.Text, thirdname.Text)
                        If scoreOne > scoreTwo Then
                            topPos.Text = topPos.Text
                            ThirdPos.Text = ThirdPos.Text + 1
                        Else
                            topPos.Text = topPos.Text + 1
                            ThirdPos.Text = ThirdPos.Text
                        End If
                    End If
                    If topPos.Text = FourthPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Aindicator, Scoresheet.Dindicator, firstname.Text, fourthname.Text)
                        If scoreOne > scoreTwo Then
                            topPos.Text = topPos.Text
                            FourthPos.Text = FourthPos.Text + 1
                        Else
                            topPos.Text = topPos.Text + 1
                            FourthPos.Text = FourthPos.Text
                        End If
                    End If
                    If topPos.Text = Fithpos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Aindicator, Scoresheet.Eindicator, firstname.Text, fithname.Text)
                        If scoreOne > scoreTwo Then
                            topPos.Text = topPos.Text
                            Fithpos.Text = Fithpos.Text + 1
                        Else
                            topPos.Text = topPos.Text + 1
                            Fithpos.Text = Fithpos.Text
                        End If
                    End If
                    If topPos.Text = SixthPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Aindicator, Scoresheet.Findicator, firstname.Text, sixthname.Text)
                        If scoreOne > scoreTwo Then
                            topPos.Text = topPos.Text
                            SixthPos.Text = SixthPos.Text + 1
                        Else
                            topPos.Text = topPos.Text + 1
                            SixthPos.Text = SixthPos.Text
                        End If
                    End If
                    disbute = SecondPOs.Text
                    If SecondPOs.Text = ThirdPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Bindicator, Scoresheet.Cindicator, secondname.Text, thirdname.Text)
                        If scoreOne > scoreTwo Then
                            SecondPOs.Text = SecondPOs.Text
                            ThirdPos.Text = ThirdPos.Text + 1
                        Else
                            SecondPOs.Text = SecondPOs.Text + 1
                            ThirdPos.Text = ThirdPos.Text
                        End If
                    End If
                    If SecondPOs.Text = FourthPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Bindicator, Scoresheet.Dindicator, secondname.Text, fourthname.Text)
                        If scoreOne > scoreTwo Then
                            SecondPOs.Text = SecondPOs.Text
                            FourthPos.Text = FourthPos.Text + 1
                        Else
                            SecondPOs.Text = SecondPOs.Text + 1
                            FourthPos.Text = FourthPos.Text
                        End If
                    End If
                    If SecondPOs.Text = Fithpos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Bindicator, Scoresheet.Eindicator, secondname.Text, fithname.Text)
                        If scoreOne > scoreTwo Then
                            SecondPOs.Text = SecondPOs.Text
                            Fithpos.Text = Fithpos.Text + 1
                        Else
                            SecondPOs.Text = SecondPOs.Text + 1
                            Fithpos.Text = Fithpos.Text
                        End If
                    End If
                    If SecondPOs.Text = SixthPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Bindicator, Scoresheet.Findicator, secondname.Text, sixthname.Text)
                        If scoreOne > scoreTwo Then
                            SecondPOs.Text = SecondPOs.Text
                            SixthPos.Text = SixthPos.Text + 1
                        Else
                            SecondPOs.Text = SecondPOs.Text + 1
                            SixthPos.Text = SixthPos.Text
                        End If
                    End If
                    disbute = ThirdPos.Text
                    If ThirdPos.Text = FourthPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Cindicator, Scoresheet.Dindicator, thirdname.Text, fourthname.Text)
                        If scoreOne > scoreTwo Then
                            ThirdPos.Text = ThirdPos.Text
                            FourthPos.Text = FourthPos.Text + 1
                        Else
                            ThirdPos.Text = ThirdPos.Text + 1
                            FourthPos.Text = FourthPos.Text
                        End If
                    End If
                    If ThirdPos.Text = Fithpos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Cindicator, Scoresheet.Eindicator, thirdname.Text, fithname.Text)
                        If scoreOne > scoreTwo Then
                            ThirdPos.Text = ThirdPos.Text
                            Fithpos.Text = Fithpos.Text + 1
                        Else
                            ThirdPos.Text = ThirdPos.Text + 1
                            Fithpos.Text = Fithpos.Text
                        End If
                    End If
                    If ThirdPos.Text = SixthPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Cindicator, Scoresheet.Findicator, thirdname.Text, sixthname.Text)
                        If scoreOne > scoreTwo Then
                            ThirdPos.Text = ThirdPos.Text
                            SixthPos.Text = SixthPos.Text + 1
                        Else
                            ThirdPos.Text = ThirdPos.Text + 1
                            SixthPos.Text = SixthPos.Text
                        End If
                    End If
                    disbute = FourthPos.Text
                    If FourthPos.Text = Fithpos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Dindicator, Scoresheet.Eindicator, fourthname.Text, fithname.Text)
                        If scoreOne > scoreTwo Then
                            FourthPos.Text = FourthPos.Text
                            Fithpos.Text = Fithpos.Text + 1
                        Else
                            FourthPos.Text = FourthPos.Text + 1
                            Fithpos.Text = Fithpos.Text
                        End If
                    End If
                    If FourthPos.Text = SixthPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Dindicator, Scoresheet.Findicator, fourthname.Text, sixthname.Text)
                        If scoreOne > scoreTwo Then
                            FourthPos.Text = FourthPos.Text
                            SixthPos.Text = SixthPos.Text + 1
                        Else
                            FourthPos.Text = FourthPos.Text + 1
                            SixthPos.Text = SixthPos.Text
                        End If
                    End If
                    disbute = Fithpos.Text
                    If Fithpos.Text = SixthPos.Text Then 'find winner
                        enterScore(scoreOne, scoreTwo, disbute, Scoresheet.Eindicator, Scoresheet.Findicator, fithname.Text, sixthname.Text)
                        If scoreOne > scoreTwo Then
                            Fithpos.Text = Fithpos.Text
                            SixthPos.Text = Fithpos.Text + 1
                        Else
                            Fithpos.Text = Fithpos.Text + 1
                            SixthPos.Text = SixthPos.Text
                        End If
                    End If
                    check = topPos.Text 'validate
                    check = check + SecondPOs.Text
                    check = check + ThirdPos.Text
                    check = check + FourthPos.Text
                    check = check + Fithpos.Text
                    check = check + SixthPos.Text
                End While
        End Select
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs)  'main menue button
        mainMenu.Show()
        compStart.Close()
        Me.Close()
        Scoresheet.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub



    Private Sub ViewDatabase_Click(sender As Object, e As EventArgs) Handles ViewDatabase.Click

    End Sub

    Private Sub ViewStatistics_Click(sender As Object, e As EventArgs) Handles ViewStatistics.Click
        records.Show()
        Me.Hide()

    End Sub

    Private Sub MainMenubtn_Click(sender As Object, e As EventArgs) Handles MainMenubtn.Click
        mainMenu.Show()
        Me.Hide()
        Scoresheet.Hide()
    End Sub
    Private Sub PracticeMatch_Click(sender As Object, e As EventArgs) Handles PracticeMatch.Click
        Me.Close() 'close window
        practice.Show() 'show window
        Scoresheet.Hide() 'ide score sheet
    End Sub

    Private Sub ViewScoreSheet_Click(sender As Object, e As EventArgs) Handles ViewScoreSheet.Click
        proved = True 'access is not allowed
        Me.Hide()
    End Sub

    Private Sub EdditScoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdditScoresToolStripMenuItem.Click
        If loginwindow.access = "complete" Then 'if they have compleate access
            proved = False
            Scoresheet.access = True 'unlock the score sheet
            Me.Close()
        Else 'if the access is not complete 
            MsgBox("you do not have acces to edit the scores ", , "Error")
        End If
    End Sub

    Private Sub LogInBtn_Click(sender As Object, e As EventArgs) Handles LogInBtn.Click
        loginwindow.Show() 'open the login window
    End Sub
End Class