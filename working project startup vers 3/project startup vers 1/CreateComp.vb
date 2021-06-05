Imports System.Data.OleDb 'imporr database commands
Public Class compStart
    Public weapselect As Boolean 'set up selection va rables
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
    Dim savedcomp As Boolean
    Dim saveSearch As Boolean
    Dim saveSearchID As Integer

    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load 'hides the main menu
        savedcomp = False
        'Startbtn.Hide()
        'SaveBtn.Hide()
        mainMenu.Hide()
        
        practice.Hide() 'hide any open forms 
        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;" 'link to database
        thedatabase = "/FencingCompData.mdb" 'database name
		fullpath = "E:\working project startup vers 3\project startup vers 1" 'files
		dbsource = "data source= " & fullpath & thedatabase 'the path way
        con.ConnectionString = dbprovider & dbsource 'connection string
        con.Open()
        'finding data
        sql = "SELECT * FROM compititionData" 'set up the command 
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "data_comp") 'fil;l data set
        con.Close()
        maxrows = ds.Tables("data_comp").Rows.Count 'set up maxrows 
        inc = -1
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
    Sub setup() 'the set up function
        Dim numberOfCompetitorschar As String
        Dim nameOfComp As String
        Dim DateofComp As String
        Dim trueDate As Date 'defings varables that are needed
        Dim numberOfCompetitorsint As Integer
        numberOfCompetitorschar = InputBox("number of competitors: ", "Competition Creation Walk through ") 'number of people
        If numberOfCompetitorschar = "" Then
            numberOfCompetitorsint = 5 'if no answer five
        Else
            Try 'make sure the input is given as a number
                numberOfCompetitorsint = numberOfCompetitorschar
            Catch ex As Exception 'if not given as a number defult to five
                numberOfCompetitorsint = 5
            End Try
        End If
        While numberOfCompetitorsint > 6 'makes sure the number is lower then 6
            MsgBox("number too high please choose a number below 7", vbExclamation, "Error") 'validate
            numberOfCompetitorsint = InputBox("number of competitors: ", "Competition Creation Walk through ")
        End While
        numBox.Text = numberOfCompetitorsint 'set the textbox as a integer
        nameOfComp = InputBox("Please enter the name of the competition: ", "Competition Creation Walk through ") 'give name input
        If nameOfComp = "" Then 'if no entry give a defult
            nameOfComp = "Un-Named" ' validate
        End If
        NameBox.Text = nameOfComp 'set name as textbox text
        DateofComp = InputBox("Please enter the date of  the competition: ", "Competition Creation Walk through ") ' input the date
        Try 'check that the date is given in the right format
            trueDate = DateofComp 'if yes
        Catch ex As Exception 'else give a defult
            trueDate = "1.1.11"
        End Try
        DateBox.Text = trueDate 'set textbox to date
        If weapselect = False Then
            'Me.Hide()
            weaponSelection.Show() 'brings up weapon selection window
        End If
    End Sub

  
    Sub savedata(ByRef succesfull) 'save data comand
        If savedcomp = False Then ' if not a pre made competiton
            maxrows = maxrows + 3 'set the max rows for the primary key this is needed so that the id can be passed to the score sheet
            Dim str As String
            con.Open() 'open conection
            str = "insert into compititionData ([Comp Id], [Comp Name], [Comp Size], [Comp Date], [weapon]) values ( ?, ?, ?,?,?)" 'make sql stament 
            Dim cmd As OleDbCommand = New OleDbCommand(str, con) 'set values 
            cmd.Parameters.Add(New OleDbParameter("Comp Id", CType(maxrows, Integer)))
            cmd.Parameters.Add(New OleDbParameter("Comp Name", CType(NameBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Comp Size", CType(numBox.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("Comp Date", CType(DateBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("weapon", CType(weapBox.Text, String)))
            Scoresheet.CompIDBox.Text = maxrows 'pass the id
            Scoresheet.CompNameBox.Text = NameBox.Text 'pass the name
            Try
                cmd.ExecuteNonQuery() 'run command 
                cmd.Dispose() 'dispose of the command
                con.Close() 'close the connection
                succesfull = True ' set the boolean value to true
            Catch ex As Exception
                MsgBox("an error has ocured when saving the information this can be caused when records have been deleted from the database please try to launch the competition again", , "Error") 'error message if fail
                con.Close() 'close connection
                succesfull = False 'set boolean value to false
            End Try
        End If
    End Sub
    Sub validation(ByRef checked) 'function to check that the infomation is correct
        Try
            Dim checkdate As Date 'check date
            checkdate = DateBox.Text 'if not in date format will cause the catch exception to be triggered
            Dim checksize As Integer

            checksize = numBox.Text
            If numBox.Text < 7 Then 'check size
                checked = True 'pass comfermation on
            Else
                checked = False 'check failed
                MsgBox("plese select a size below 7", , "error") 'error message  larger then 7
            End If

        Catch ex As Exception
            MsgBox("one or more of the options have not been entered correctly", , "error") 'if there is en error
            checked = False
        End Try
    End Sub
    Private Sub Startbtn_Click(sender As Object, e As EventArgs) Handles Startbtn.Click 'saves to the data base
        Dim succesfull As Boolean = False
        Dim checked As Boolean 'set up the needed varables
        If saveSearch = True Then
            Scoresheet.CompIDBox.Text = saveSearchID 'pass the id
            Scoresheet.CompNameBox.Text = NameBox.Text 'pass the name
            Scoresheet.Show()
            Scoresheet.access = True
            Exit Sub
        End If
        checked = False
        allfilled(checked) 'check there is all the imformation
        If checked = True Then 'if it passes first check
            validation(checked) 'call validation function check all imformation is corrrect
        End If

        If checked = True Then 'if it passes second check
            savedata(succesfull) 'call the save data function
            If succesfull = True Then 'if it save properly
                Scoresheet.Show() 'show the score sheet
                Scoresheet.access = True
            End If
        Else
            MsgBox("one of the paramiters has not been filled correctly", , "Unable to launch Competition") 'error message
        End If
    End Sub

    Sub allfilled(ByRef checked) 'validate
        If weapBox.Text <> "" And DateBox.Text <> "" And NameBox.Text <> "" And numBox.Text <> "" Then 'check all the textboxes contain values
            checked = True 'passed this level of validation
        Else 'if they dont
            checked = False 'reject the launch request
        End If
    End Sub

    Private Sub ViewDatabase_Click(sender As Object, e As EventArgs) Handles ViewDatabase.Click
        mainMenu.fullNeeded(database)
    End Sub

    Private Sub ViewStatistics_Click(sender As Object, e As EventArgs) Handles ViewStatistics.Click
        records.Show() 'bring up records
        Me.Close()

    End Sub

    Private Sub MainMenubtn_Click(sender As Object, e As EventArgs) Handles MainMenubtn.Click
        mainMenu.Show()
        Me.Close()

    End Sub

  


    Private Sub ChangeSize_Click(sender As Object, e As EventArgs) Handles ChangeSize.Click 'change the size in the set up
        Dim numberOfCompetitorsint As Integer 'set varables to reseve nubers 
        Dim numberOfCompetitorschar As String
        numberOfCompetitorschar = InputBox("number of competitors: ", , "Competition Creation Walk through ") 'number 'this will serve as validation if the box is left blank it will not crash the program
        If numberOfCompetitorschar = "" Then
            numberOfCompetitorsint = 5 'if blanck defult to five
        Else
            Try
                numberOfCompetitorsint = numberOfCompetitorschar 'try to set that as number
            Catch ex As Exception
                MsgBox("the value you have entered is not alowed please enter a new value", vbExclamation, "attention") 'warning message if fail
            End Try


        End If
        While numberOfCompetitorsint > 6 'if two high
            MsgBox("number too high please choose a number below 7", vbExclamation, "Error") 'validate
            numberOfCompetitorschar = InputBox("number of competitors: ", , "Competition Creation Walk through ")
            Try
                numberOfCompetitorsint = numberOfCompetitorschar 'try to set that as number
            Catch ex As Exception
                MsgBox("the value you have entered is not alowed please enter a new value", vbExclamation, "attention") 'warning message if fail
            End Try
        End While
        numBox.Text = numberOfCompetitorsint 'show selection
    End Sub

    Private Sub CreateBtn_Click(sender As Object, e As EventArgs) Handles CreateBtn.Click
        setup() 'call the setup function 
        CreateBtn.Hide() 'hide the button
    End Sub
   

    Private Sub ChangeDate_Click(sender As Object, e As EventArgs) Handles ChangeDate.Click
        datePicker.Show() 'shoiw data picker window      
    End Sub

    Private Sub ChangeName_Click(sender As Object, e As EventArgs) Handles ChangeName.Click
        Dim nameOfComp As String
		nameOfComp = InputBox("Please enter the name of the competition: ", "Changing The name of the Competition") 'ask for imput
		If nameOfComp = "" Then
            nameOfComp = "Un-Named" 'name and validate
        End If
        NameBox.Text = nameOfComp
    End Sub

    Private Sub ChangeWeapon_Click(sender As Object, e As EventArgs) Handles ChangeWeapon.Click
        weaponSelection.Show() 'brings up weapon selection window
    End Sub

    Private Sub PracticeMatch_Click(sender As Object, e As EventArgs) Handles PracticeMatch.Click 'navigation
        Me.Close()
        practice.Show()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click 'when save for later is pressed
        Dim succesfull As Boolean = False
        Dim checked As Boolean 'set up the needed varables
        checked = False
        allfilled(checked) 'check there is all the imformation
        If checked = True Then 'if it passes first check
            validation(checked) 'call validation function check all imformation is corrrect
        End If

        If checked = True Then 'if it passes second check
            savedata(succesfull) 'call the save data function
            If succesfull = True Then 'if it save properly
                Dim str As String 'set up the string
                '      dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;" 'link to database for the new table
                '      thedatabase = "/FencingCompData.mdb"
                'fullpath = "E:\working project startup vers 3\project startup vers 1"
                'dbsource = "data source= " & fullpath & thedatabase
                '      con.ConnectionString = dbprovider & dbsource
                con.Open()
                sql = "SELECT * FROM RefData" 'fill a new data set
                Dim refMaxrows As Integer 'set a new ax row 
                Dim daR As OleDb.OleDbDataAdapter

                daR = New OleDb.OleDbDataAdapter(sql, con)
                da.Fill(ds, "data_later")
                con.Close()
                con.Open() 'open conection
                refMaxrows = ds.Tables("data_later").Rows.Count 'set max rows
                inc = -1
                str = "insert into RefCompititions ([Ref ID], [Comp Id],[Comp Name]) values( ?, ?,?)" 'set up insert comand
                Dim cmdR As OleDbCommand = New OleDbCommand(str, con)
                'save varables
                cmdR.Parameters.Add(New OleDbParameter("Ref ID", CType(refMaxrows, Integer)))
                cmdR.Parameters.Add(New OleDbParameter("Comp Id", CType(maxrows, Integer)))
                cmdR.Parameters.Add(New OleDbParameter("Comp Name", CType(NameBox.Text, String)))
                'hide text boxes 
                Try 'try command
                    cmdR.ExecuteNonQuery() 'run command
                    cmdR.Dispose() 'command dispose
                    con.Close() 'close connection
                    MsgBox("the refrence number for this competition is: " & refMaxrows, , "Competion Saved") 'give user refrense number
                    refMaxrows = refMaxrows + 1 'set new maxrow
                    'if failed
                Catch ex As Exception 'expalin the error
                    MsgBox("an error has ocured when saving the information this can be caused when records have been deleted from the database please try to launch the competition again", , "Error")
                End Try

            End If
        Else
            MsgBox("one of the paramiters has not been filled correctly", , "Unable to launch Competition") 'error message
        End If

    End Sub



    Private Sub UseSavedCompetition_Click(sender As Object, e As EventArgs) Handles UseSavedCompetition.Click
        saveSearch = False
        Dim check As Boolean
        check = False
        con.Open() 'open connection
        sql = "SELECT * FROM RefCompititions" 'set the sql command 
        Dim refMaxrows As Integer 'set the maxrows
        Dim daR As OleDb.OleDbDataAdapter
        daR = New OleDb.OleDbDataAdapter(sql, con)
        daR.Fill(ds, "data_later") 'fill the data set
        refMaxrows = ds.Tables("data_later").Rows.Count 'count the rows
        con.Close()
        Dim SearchId As Integer
        Dim checksearch As String ' get the search quiry
        checksearch = InputBox("Please enter the refrence number ", "Pre Saved Compeition") 'get the information
        While checksearch = " " 'validate
            checksearch = InputBox("please enter the refrence number ", "Pre Saved Compeition")
        End While
        SearchId = checksearch
        Dim Int As Integer = 0
        Dim found As Integer
        Dim success As Boolean = False 'search through the data set fot he information
        While Int < refMaxrows
            If SearchId = ds.Tables("data_later").Rows(Int).Item(0) Then 'if found get information and dleeate this record
                success = True
                found = ds.Tables("data_later").Rows(Int).Item(0)
                check = True
                saveSearch = True
                saveSearchID = ds.Tables("data_later").Rows(Int).Item(1) 'pass the id to a new varabel to search the second table
                delete(SearchId) 'delete the saved record
                Exit While
            End If
            Int = Int + 1 'search next row
            If Int >= refMaxrows Then 'if not found 
                MsgBox("there is no recorded with this Id", vbExclamation, "Error") 'error
            End If
        End While
        If check = True Then ' if found 
            con.Open() 'open connection
            'refresh data table
            sql = "SELECT * FROM compititionData" 'set up sql stament 
            Dim Maxrows As Integer
            Dim da As OleDb.OleDbDataAdapter
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "data_comp") 'fill data set
            Maxrows = ds.Tables("data_comp").Rows.Count 'recount the rows
            con.Close() 'close connection
            success = False
            Int = 0
            While Int <= Maxrows 'linea search of the data table
                Int = Int + 1 'search the row
                If found = ds.Tables("data_comp").Rows(Int).Item(0) Then
                    'if found
                    success = True
                    Exit While 'exit while loop 
                ElseIf Int > Maxrows Then 'if not found
                    MsgBox("There is no recored with this ID", , "error") 'propt user
                    Exit While
                End If
            End While
            If success = True Then 'if found
                savefound(Int) 'call the function to fill text box
                savedcomp = True 'competion is already saved
                Scoresheet.CompIDBox.Text = found 'send the id over to the score sheet
                Scoresheet.CompNameBox.Text = NameBox.Text 'send the name to the score sheet
            End If
        End If
    End Sub
    Sub savefound(int)
        MsgBox("Found saved competition", , "Saved file has been found") 'show the information
        MsgBox("Please check that the maximum score is correct", , "Warning") 'prompt the user to the score
        NameBox.Text = ds.Tables("data_comp").Rows(int).Item(1)
        numBox.Text = ds.Tables("data_comp").Rows(int).Item(2) 'fill the textboxes 
        DateBox.Text = ds.Tables("data_comp").Rows(int).Item(3)
        weapBox.Text = ds.Tables("data_comp").Rows(int).Item(4)
    End Sub


    Sub delete(searchedID) 'deleate function
        '      dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;" 'link to database
        '      thedatabase = "/FencingCompData.mdb"


        'fullpath = "E:\working project startup vers 3\project startup vers 1"
        'dbsource = "data source= " & fullpath & thedatabase
        '      con.ConnectionString = dbprovider & dbsource
        con.Open() 'open conection
        sql = "SELECT * FROM RefCompititions" ' set up command
        Dim refMaxrows As Integer
        Dim daR As OleDb.OleDbDataAdapter

        daR = New OleDb.OleDbDataAdapter(sql, con)
        daR.Fill(ds, "data_later") 'fill data set
        refMaxrows = ds.Tables("data_later").Rows.Count
        con.Close()
        con.Open() 'open conection
        Dim comand As String
        comand = "DELETE * FROM RefCompititions where [Ref ID]= " & searchedID & "" 'delete comand
        Dim cmdR As OleDbCommand = New OleDbCommand(comand, con)
        cmdR.ExecuteNonQuery()
        cmdR.Dispose()
        con.Close()


    End Sub

    Private Sub NameBox_TextChanged(sender As Object, e As EventArgs) Handles NameBox.TextChanged

    End Sub
    Private Sub DateBox_TextChanged(sender As Object, e As EventArgs) Handles DateBox.TextChanged

    End Sub
    Private Sub weapBox_TextChanged(sender As Object, e As EventArgs) Handles weapBox.TextChanged

    End Sub
    Private Sub numBox_TextChanged(sender As Object, e As EventArgs) Handles numBox.TextChanged

    End Sub
    Private Sub NameLabel_Click(sender As Object, e As EventArgs) Handles NameLabel.Click

    End Sub
    Private Sub Datelabel_Click(sender As Object, e As EventArgs) Handles Datelabel.Click

    End Sub
    Private Sub Weaplabel_Click(sender As Object, e As EventArgs) Handles Weaplabel.Click

    End Sub
    Private Sub sizeLabel_Click(sender As Object, e As EventArgs) Handles sizeLabel.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class


