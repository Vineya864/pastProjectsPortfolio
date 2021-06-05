Imports System.Data.OleDb 'import some new commands 
Public Class database
    Dim int As Integer 'set up the varabales
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim astint As Integer
    Dim dbprovider As String
    Dim dbsource As String
    Dim mydocumentsfolder As String
    Dim thedatabase As String
    Dim fullpath As String
    Dim maxrows As Integer
    Dim con As New OleDb.OleDbConnection
    Dim passwordcheck As Boolean
    Dim passwordchanged As Boolean
    Dim savetrial As Boolean


    Private Sub ReturnToMainMenu_Click(sender As Object, e As EventArgs) Handles ReturnToMainMenu.Click 'navigation to main menu
        Me.Close()
        mainMenu.Show()
    End Sub

    Private Sub PracticeMatch_Click(sender As Object, e As EventArgs) Handles PracticeMatch.Click 'navigation parctie mathc
        Me.Close()
        practice.Show()
    End Sub

    Private Sub CreateCompetitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateCompetition.Click 'navigation creat a new 
        mainMenu.fullNeeded(compStart) 'check the acces
        Me.Close()
    End Sub
    Private Sub ScoreSheetm_Click(sender As Object, e As EventArgs) Handles ScoreSheetNavigate.Click
        'load up the score sheet
        If Scoresheet.AName.Text <> "" Then 'check the scroe sheet is open
            If loginwindow.access = "part" Then 'if access is part lock for changes 

                Scoresheet.Show()
                Scoresheet.access = False
                Me.Close()
            Else
                Scoresheet.access = True 'allow changes
                mainMenu.fullNeeded(ScoreSheetNavigate) 'use the normal check command 
                Me.Close() 'close the screen
            End If
        Else
            MsgBox("there is currently no competion running", , "Error")
        End If ' if there is no compeition
    End Sub
    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click 'call the log out function
        loginwindow.logoutfunction()
     

        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.RefCompititions' table. You can move, or remove it, as needed.
        Me.RefCompititionsTableAdapter.Fill(Me.ProjectDataSet.RefCompititions)
        passwordcheck = False
        passwordchanged = False
        'TODO: This line of code loads data into the 'ProjectDataSet.acountInfo' table. You can move, or remove it, as needed.
        Me.AcountInfoTableAdapter.Fill(Me.ProjectDataSet.acountInfo)

        'TODO: This line of code loads data into the 'ProjectDataSet.competitorData' table. You can move, or remove it, as needed.
        Me.CompetitorDataTableAdapter.Fill(Me.ProjectDataSet.competitorData)
        mainMenu.Hide()
        'TODO: This line of code loads data into the 'ProjectDataSet.compititionData' table. You can move, or remove it, as needed.
        Me.CompititionDataTableAdapter.Fill(Me.ProjectDataSet.compititionData)
        'TODO: This line of code loads data into the 'ProjectDataSet.ScoreData' table. You can move, or remove it, as needed.
        Me.ScoreDataTableAdapter.Fill(Me.ProjectDataSet.ScoreData)


    End Sub
    'Sub showselected()
    '    scoreIDBox.Text = ScoreDataDataGridView1.Item(0, ScoreDataDataGridView1.CurrentRow.Index).Value
    '    CompIdBox.Text = ScoreDataDataGridView1.Item(1, ScoreDataDataGridView1.CurrentRow.Index).Value
    '    CompetitorIdBox.Text = ScoreDataDataGridView1.Item(2, ScoreDataDataGridView1.CurrentRow.Index).Value
    '    AverageScoreBox.Text = ScoreDataDataGridView1.Item(3, ScoreDataDataGridView1.CurrentRow.Index).Value
    '    AverageScoreAgainstBox.Text = ScoreDataDataGridView1.Item(4, ScoreDataDataGridView1.CurrentRow.Index).Value
    '    PositionBox.Text = ScoreDataDataGridView1.Item(5, ScoreDataDataGridView1.CurrentRow.Index).Value
    '    AverageWinBox.Text = ScoreDataDataGridView1.Item(6, ScoreDataDataGridView1.CurrentRow.Index).Value
    'End Sub


    Private Sub Dbtn_Click(sender As Object, e As EventArgs) Handles DownBtnScoreData.Click 'move up button
        ScoreDataBindingSource.MoveNext()
    End Sub

    Private Sub Ubtn_Click(sender As Object, e As EventArgs) Handles UpBtnscoreData.Click 'move down button
        ScoreDataBindingSource.MovePrevious()
    End Sub
    Sub scoresetup()
        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;"
        thedatabase = "/FencingCompData.mdb"
        fullpath = "\working project startup vers 3\project startup vers 1" 'files'create conection pathway
        dbsource = "data source= " & fullpath & thedatabase
        con.ConnectionString = dbprovider & dbsource 'assemble the full string
   
        sql = "SELECT * FROM ScoreData" 'fill the data set
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "data_names")
        con.Close()
        maxrows = ds.Tables("data_names").Rows.Count 'set up max rowx
        savetrial = True
    End Sub
    Private Sub updateBtnScoreData_Click(sender As Object, e As EventArgs) Handles updateBtnScoreData.Click 'this button will change data in the text box 
        scoresetup()
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim change As String 'this will be the varable that controles what data is saved 
        'svaing start
        change = Comp_IdTextBox.Text                                    ' Comp Id change
        sql = "UPDATE ScoreData SET [comp Id] = " & change & " WHERE [scoreId] =  " & ScoreIDTextBox.Text & "" 'sql command
        Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmd) 'call function
        'repeate
        change = Competitor_IdTextBox.Text              'competitor Id change
        sql = "UPDATE ScoreData SET [competitor Id] = " & change & " WHERE [scoreId] =  " & ScoreIDTextBox.Text & ""
        Dim cmdC As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmdC)
        'repeate
        change = Average_points_scoredTextBox.Text      'average Points scored  change
        sql = "UPDATE ScoreData SET [Average points scored] = " & change & " WHERE [scoreId] =  " & ScoreIDTextBox.Text & ""
        Dim cmdAS As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmdAS)
        'repeate
        change = Average_points_scored_againstTextBox.Text ' average points scored against change
        sql = "UPDATE ScoreData SET [Average points scored against] = " & change & " WHERE [scoreId] =  " & ScoreIDTextBox.Text & ""
        Dim cmdAH As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmdAH)
        'repeate
        change = Average_winTextBox.Text  'average win change
        sql = "UPDATE ScoreData SET [Average win] = " & change & " WHERE [scoreId] =  " & ScoreIDTextBox.Text & ""
        Dim cmdAW As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmdAW)
        'repeate
        change = PositionTextBox.Text 'position change
        sql = "UPDATE ScoreData SET [position] = " & change & " WHERE [scoreId] =  " & ScoreIDTextBox.Text & ""
        Dim cmdP As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmdP)
        'confermation message
        ' move the selection up and then back to refresh the daa grid 
        refreshrecord(ScoreDataBindingSource) 'call the refresh function
        con.Close()
    End Sub
    Sub refreshrecord(source) 'this will be given the binding source for the grid and use it to refresh the specific recored 
        source.moveNext() 'move 

        source.MovePrevious() 'go back to the origonal
        If savetrial = True Then
            MsgBox("record changed", , "Success")
        End If

    End Sub
    Sub runComand(cmd) 'function that runs the commands
        If savetrial = True Then 'check the saves before have worked
            Try
                con.Open() 'open data conection
                cmd.ExecuteNonQuery() 'run command
                cmd.Dispose() 're set command 
                con.Close() 'close conection
            Catch ex As Exception 'if the changes cannt be saved
                MsgBox("Make sure you have enter the data in the correct format", vbCritical, "An Error Has Occured") 'error message critical form 
                savetrial = False 'save didnt work
            End Try
        End If
    End Sub

    'not sure what this does appered when i loaded the grid view 
    'Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        Me.ScoreDataTableAdapter.FillBy(Me.ProjectDataSet.ScoreData)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub UPbtnCompData_Click(sender As Object, e As EventArgs) Handles UPbtnCompData.Click
        CompititionDataBindingSource.MovePrevious()
    End Sub

    Private Sub DownBtnCompData_Click(sender As Object, e As EventArgs) Handles DownBtnCompData.Click
        CompititionDataBindingSource.MoveNext()
    End Sub

    Sub Compeitionsetup()
        'set up conection
        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;"
        thedatabase = "/FencingCompData.mdb"
        fullpath = "\working project startup vers 3\project startup vers 1" 'files 'creat conetctyion detatils
        dbsource = "data source= " & fullpath & thedatabase
        con.ConnectionString = dbprovider & dbsource
        'con.Open()
        'finding data
        sql = "SELECT * FROM CompititionData" 'sql statment
        da = New OleDb.OleDbDataAdapter(sql, con) 'set data adapter
        da.Fill(ds, "data_names") 'fill data set
        con.Close() 'close connetction
        maxrows = ds.Tables("data_names").Rows.Count 'set up max rowx
        savetrial = True
    End Sub

    Private Sub compUpdata_Click(sender As Object, e As EventArgs) Handles CompUpdate.Click 'trial updata button for competiton data
        Compeitionsetup()
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim change As String 'this will be the varable that controles what data is saved 



        change = Comp_sizeTextBox.Text 'size change
        sql = "UPDATE CompititionData SET [Comp size] = " & change & " WHERE [Comp Id] =  " & Comp_IdTextBoxComp.Text & ""
        Dim cmdSize As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmdSize)

        Dim CompDate As Date 'change date
        CompDate = Comp_DateDateTimePicker.Text
        sql = "UPDATE CompititionData SET [Comp Date] = " & change & " WHERE [Comp Id] =  " & Comp_IdTextBoxComp.Text & ""
        Dim cmdDate As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmdDate)
        'change weapon
        change = WeaponTextBox.Text
        sql = "UPDATE CompititionData SET [Weapon] = '" & change & "' WHERE [Comp Id] =  " & Comp_IdTextBoxComp.Text & ""
        Dim cmdWeap As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmdWeap)

        change = Comp_NameTextBox.Text 'name change
        sql = "UPDATE CompititionData SET [Comp Name] = '" & change & "' WHERE [Comp Id] =  " & Comp_IdTextBoxComp.Text & ""
        Dim cmdCN As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmdCN)
        'confermation message

        refreshrecord(CompititionDataBindingSource) 'call the function to refresh the message
        con.Close()
    End Sub


    Private Sub competitorUpBtn_Click(sender As Object, e As EventArgs) Handles competitorUpBtn.Click
        CompetitorDataBindingSource.MovePrevious()
    End Sub
    Private Sub CompetitorDownBtn_Click(sender As Object, e As EventArgs) Handles CompetitorDownBtn.Click
        CompetitorDataBindingSource.MoveNext()
    End Sub

    Sub Compsetup()
        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;"
        thedatabase = "/FencingCompData.mdb"
        fullpath = "\working project startup vers 3\project startup vers 1" 'files 'creat conetctyion detatils
        dbsource = "data source= " & fullpath & thedatabase
        con.ConnectionString = dbprovider & dbsource
        'con.Open()
        'finding data
        sql = "SELECT * FROM CompetitorData" 'set sql statment 
        da = New OleDb.OleDbDataAdapter(sql, con) 'set data adapter
        da.Fill(ds, "data_names") 'fil data set
        con.Close() 'close connection
        maxrows = ds.Tables("data_names").Rows.Count 'set up max rowx
        savetrial = True
    End Sub


    Private Sub CompetitorUpdateBtn_Click(sender As Object, e As EventArgs) Handles CompetitorUpdateBtn.Click
        Compsetup()
        Dim change As String
        change = NameTextBox.Text 'name change
        sql = "UPDATE CompetitorData SET [name] = '" & change & "' WHERE [Competitor Id] =  " & Competitor_IdTextBox1.Text & ""
        Dim cmdName As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmdName)

        'surname change
        change = SurnameTextBox.Text
        sql = "UPDATE CompetitorData SET [surname] = '" & change & "' WHERE [Competitor Id] =  " & Competitor_IdTextBox1.Text & ""
        Dim cmdSName As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmdSName)

        'age change

        change = AgeTextBox.Text
        sql = "UPDATE CompetitorData SET [age] = '" & change & "' WHERE [Competitor Id] =  " & Competitor_IdTextBox1.Text & ""
        Dim cmdage As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmdage)

        'gender change
        change = GenderTextBox.Text
        sql = "UPDATE CompetitorData SET [gender] = '" & change & "' WHERE [Competitor Id] =  " & Competitor_IdTextBox1.Text & ""
        Dim cmdgender As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmdgender)
        'refresh grid
        refreshrecord(CompetitorDataBindingSource)
        con.Close()
    End Sub
    Sub cypher(ByRef password)
        Dim length As Integer
        Dim count = password
        length = Len(count)
        Dim pass() As Char = count.ToCharArray 'count the arrays length
        Dim Convertion(length) 'converted array
        Dim Num As Integer = 0
        For Num = 0 To (Len(pass) - 1)
            Convertion(Num) = Asc(pass(Num)) + 3 'cypher
            pass(Num) = Chr(Convertion(Num))

        Next
        password = String.Join(",", pass) 'join it back together
    End Sub
    Sub uncypher(ByRef cyphertext) 'this changes the plain text to the cypher text so that it can be compared to the database
        'cypher value of three
        Dim length As Integer
        Dim count = cyphertext
        length = Len(count)
        Dim pass() As Char = count.ToCharArray 'count the arrays length
        Dim Convertion(length) 'converted array
        Dim Num As Integer = 0
        For Num = 0 To (Len(pass) - 1)
            Convertion(Num) = Asc(pass(Num)) - 3 'cypher
            pass(Num) = Chr(Convertion(Num))

        Next
        cyphertext = String.Join(",", pass) 'join it back together
    End Sub
    Private Sub CypherBtn_Click_1(sender As Object, e As EventArgs) Handles cypherBtn.Click  'test for devrypting the password
        Dim password As String
        password = PasswordTextBox.Text 'set password to textbox
        uncypher(password) 'call function
        PasswordTextBox.Text = password 'set texbox to password
        cypherBtn.Enabled = False 'disable button
        passwordcheck = True 'tell password check that the password has been deripted
    End Sub
    Sub callCypher() 'function to set up the cypher function
        If passwordcheck = True Then 'if the password has been uncyphered
            Dim password As String 'set password varable
            password = PasswordTextBox.Text 'set as text box
            cypher(password) 'send to function
            PasswordTextBox.Text = password 'set textbox back to password
            passwordcheck = False 'restet varables
            cypherBtn.Enabled = True
        End If

    End Sub
    Private Sub Accountdown_Click(sender As Object, e As EventArgs) Handles Accountdown.Click 'move down
        callCypher() 'call cypher fucntion
        AcountInfoBindingSource.MoveNext()
        passwordchanged = False
    End Sub

    Private Sub AccountUp_Click(sender As Object, e As EventArgs) Handles AccountUp.Click 'move up 
        callCypher() 'call function
        AcountInfoBindingSource.MovePrevious()
        passwordchanged = False
    End Sub
    Sub AccountsSetup()
        'set up connection
        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;"
        thedatabase = "/FencingCompData.mdb"
        fullpath = "\working project startup vers 3\project startup vers 1" 'files 'creat conetctyion detatils
        dbsource = "data source= " & fullpath & thedatabase
        con.ConnectionString = dbprovider & dbsource
        'con.Open()
        'finding data
        sql = "SELECT * FROM acountInfo" 'from acount info tabel
        da = New OleDb.OleDbDataAdapter(sql, con) 'set up data adapter
        da.Fill(ds, "data_names") 'fill data set
        con.Close() 'close connection
        maxrows = ds.Tables("data_names").Rows.Count 'set up max rowx
        savetrial = True
    End Sub
    Private Sub AccountsUpdate_Click(sender As Object, e As EventArgs) Handles AccountsUpdate.Click
        Dim password As String
        AccountsSetup() 'set up connection
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim change As String 'set change value
        change = UserNameTextBox.Text 'name change
        sql = "UPDATE acountInfo SET [UserName] = '" & change & "' WHERE [ID] =  " & IDTextBox.Text & ""
        Dim cmdUName As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmdUName)
        If passwordchanged = True Then
            passwordcheck = True
            password = PasswordTextBox.Text 'password
            cypher(password) 'send to function
            PasswordTextBox.Text = password 'set textbox back to password
            sql = "UPDATE acountInfo SET [Password] = '" & PasswordTextBox.Text & "' WHERE [ID] =  " & IDTextBox.Text & ""
            Dim cmdPass As OleDbCommand = New OleDbCommand(sql, con)
            runComand(cmdPass)
        End If
        'accesss
        'send to function
        change = AccessTextBox.Text 'set textbox back to password
        sql = "UPDATE acountInfo SET [Access] = '" & change & "' WHERE [ID] =  " & IDTextBox.Text & ""
        Dim cmdAccess As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmdAccess)

        refreshrecord(AcountInfoBindingSource)
        cypherBtn.Enabled = True
        passwordcheck = False
        passwordchanged = False
        con.Close()
    End Sub


    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged 'check that the pasword has been changed before saving
        passwordchanged = True
    End Sub




    Sub Refsetup()
        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;"
        thedatabase = "/FencingCompData.mdb"
        fullpath = "\working project startup vers 3\project startup vers 1" 'files 'creat conetctyion detatils
        dbsource = "data source= " & fullpath & thedatabase
        con.ConnectionString = dbprovider & dbsource
        'con.Open()
        'finding data
        sql = "SELECT * FROM RefCompititions" 'set sql statment 
        da = New OleDb.OleDbDataAdapter(sql, con) 'set data adapter
        da.Fill(ds, "data_names") 'fil data set
        con.Close() 'close connection
        maxrows = ds.Tables("data_names").Rows.Count 'set up max rowx
        savetrial = True
    End Sub


    Private Sub RefUpBtn_Click_1(sender As Object, e As EventArgs) Handles RefUpBtn.Click
        RefCompititionsBindingSource.MovePrevious() 'move up

    End Sub

    Private Sub RefDownBtn_Click(sender As Object, e As EventArgs) Handles RefDownBtn.Click
        RefCompititionsBindingSource.MoveNext() 'move down
    End Sub

    Private Sub RefUpdate_Click(sender As Object, e As EventArgs) Handles RefUpdate.Click
        Dim change As String
        Refsetup()
        change = Comp_IdTextBox1.Text 'set textbox back to password
        sql = "UPDATE RefCompititions SET [Comp Id] = '" & change & "' WHERE [Ref ID] =  " & Comp_IdTextBox1.Text & ""
        Dim cmdRefID As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmdRefID)

        change = Comp_NameTextBox1.Text 'set textbox back to password
        sql = "UPDATE RefCompititions SET [Comp name] = '" & change & "' WHERE [Ref ID] =  " & Comp_IdTextBox1.Text & ""
        Dim cmdRefName As OleDbCommand = New OleDbCommand(sql, con)
        runComand(cmdRefName)


        refreshrecord(RefCompititionsBindingSource)
        con.Close()
    End Sub

    Sub GridDelete(cmd, GridView) 'delete fucntion 
        Try
            con.Open()

            cmd.ExecuteNonQuery() 'run the comand
            cmd.Dispose() 'get rind of comand
            con.Close() 'close conection
            GridView.Rows.Remove(GridView.SelectedRows(0)) 'clear the view on the data grid
            MsgBox("record Deleted", , "Record Deleted")
        Catch ex As Exception 'if error ocurs

            MsgBox("an error has occured please make sure a record has been selected and that it is not used in another tabel", , "Error") 'send error message
            con.Close()
        End Try

    End Sub
    Private Sub DeleteScoreBtn_Click_1(sender As Object, e As EventArgs) Handles DeleteScoreBtn.Click 'delete button
        scoresetup()

        ScoreDataDataGridView1.CurrentRow().Selected = True 'select the rest of the cells in record

        sql = "DELETE * FROM ScoreData  where [ScoreID]= " & ScoreIDTextBox.Text & "" 'delete command
        Dim cmdDS As OleDbCommand = New OleDbCommand(sql, con)
        GridDelete(cmdDS, ScoreDataDataGridView1) 'launch function
    End Sub

    Private Sub CompDataDeleteBtn_Click(sender As Object, e As EventArgs) Handles CompDataDeleteBtn.Click
        Compeitionsetup()

        sql = "DELETE * FROM CompititionData where [Comp Id]= " & Comp_IdTextBoxComp.Text & "" 'deleat comand
        CompititionDataDataGridView.CurrentRow().Selected = True 'select rest of cells in record
        Dim cmdDComp As OleDbCommand = New OleDbCommand(sql, con)
        GridDelete(cmdDComp, CompititionDataDataGridView) 'launch function
    End Sub


    Private Sub DeleteCompetBtn_Click(sender As Object, e As EventArgs) Handles DeleteCompetBtn.Click
        Compsetup()

        sql = "DELETE * FROM CompetitorData where [Competitor Id]= " & Competitor_IdTextBox1.Text & "" 'deleat comand
        CompetitorDataDataGridView.CurrentRow().Selected = True 'select rest of cells in record
        Dim cmdDCompet As OleDbCommand = New OleDbCommand(sql, con)
        GridDelete(cmdDCompet, CompetitorDataDataGridView) 'launch function
    End Sub

    Private Sub AccountDelete_Click(sender As Object, e As EventArgs) Handles AccountDeleteBtn.Click
        AccountsSetup()

        sql = "DELETE * FROM AcountInfo where [ID]= " & IDTextBox.Text & "" 'deleat comand
        AcountInfoDataGridView.CurrentRow().Selected = True 'select rest of cells in record
        Dim cmdDCompet As OleDbCommand = New OleDbCommand(sql, con)
        GridDelete(cmdDCompet, AcountInfoDataGridView) 'launch function
        callCypher() 'call cypher fucntion

        passwordchanged = False '
    End Sub

    Private Sub RefDelete_Click(sender As Object, e As EventArgs) Handles RefDelete.Click
        Refsetup()


        sql = "DELETE * FROM RefCompititions where [Ref ID]= " & Ref_IDTextBox.Text & "" 'deleat comand
        RefCompititionsDataGridView.CurrentRow().Selected = True 'select rest of cells in record
        Dim cmdDRef As OleDbCommand = New OleDbCommand(sql, con)
        GridDelete(cmdDRef, RefCompititionsDataGridView) 'launch function

    End Sub

    'Private Sub AddscoreBtn_Click(sender As Object, e As EventArgs) Handles AddScoreBtn.Click
    '    scoresetup() 'setup
    '    maxrows = maxrows + 1 'set primary key
    '    con.Open() 'open connection
    '    sql = "insert into ScoreData ([ScoreID], [Comp Id], [Competitor Id], [average points scored],[average points scored against],[position],[average win]) values ( ?, ?, ?,?,?,?,?)" 'sql stament
    '    Dim cmd As OleDbCommand = New OleDbCommand(sql, con) 'enter values

    '    cmd.Parameters.Add(New OleDbParameter("ScoreID", CType(maxrows, Integer)))
    '    cmd.Parameters.Add(New OleDbParameter("Comp Id", CType(Comp_IdTextBoxComp.Text, Integer)))
    '    cmd.Parameters.Add(New OleDbParameter("competitor Id", CType(Competitor_IdTextBox1.Text, Integer)))
    '    cmd.Parameters.Add(New OleDbParameter("average points scored", CType(0, Integer)))
    '    cmd.Parameters.Add(New OleDbParameter("average points scored against", CType(0, Integer)))
    '    cmd.Parameters.Add(New OleDbParameter("position", CType(0, Integer)))
    '    cmd.Parameters.Add(New OleDbParameter("average win", CType(0, Integer)))
    '    Try
    '        cmd.ExecuteNonQuery() 'run comand
    '        cmd.Dispose() 'get rind of command
    '        con.Close()

    '        'ds.Tables("data_names").Clear()

    '        MsgBox("Record Completed")

    '        loaddata() 'refreash data grid
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        con.Close()
    '    End Try

    'End Sub
    'Private Sub loaddata()
    '    ScoreDataDataGridView1.DataSource = Nothing 'clear
    '    ScoreDataDataGridView1.Refresh()
    '    Dim str As String = "select * from ScoreData"
    '    Using cmd As New OleDb.OleDbCommand(str, con) 'get data again
    '        Using da As New OleDbDataAdapter(cmd)
    '            Using newtable As New DataTable
    '                da.Fill(newtable) 'fill new set
    '                ScoreDataDataGridView1.DataSource = newtable 'set as table
    '            End Using
    '        End Using
    '    End Using
    'End Sub
    Private Sub LogInBtn_Click(sender As Object, e As EventArgs) Handles LogInBtn.Click
        loginwindow.Show()
    End Sub
    Sub tabLabelChange(change) 'change the label function
        TabLabel.Text = change 'change text
    End Sub
    Private Sub ScoreDataTab_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ScoreDataTab.Enter 'score tab
        tabLabelChange("Score Data Table") 'call function
    End Sub
    Private Sub compTab_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles compTab.Enter 'competition data tab
        tabLabelChange("Competition Data Table") 'call function
    End Sub
    Private Sub competitorTab_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles competitorTab.Enter ' competitor data tab
        tabLabelChange("Competitor Data Table") 'call function
    End Sub

    Private Sub AccountInfo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles AccountInfo.Enter 'account info tab
        tabLabelChange("Acount Data Table") 'call function
    End Sub
    Private Sub compRefTab_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles compRefTab.Enter 'competitions tab
        tabLabelChange("Saved Competitions Table") 'call function
    End Sub

    Private Sub AddScoreBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ViewGraphsBtn_Click(sender As Object, e As EventArgs) Handles ViewGraphsBtn.Click
        mainMenu.partNeeded(records)
        Me.Close()
    End Sub
End Class
'Dim dr As datarow = dt.newrow
'dr.itemarray = New Object() {Me.txtAccountNumber.Text, Me.txtAccountnumberScaleOfFinance.Text, Me.cmbxCropCode.SelectedIndex, Me.mskdeffectivedate.Text}
'dt.rows.add(dr)