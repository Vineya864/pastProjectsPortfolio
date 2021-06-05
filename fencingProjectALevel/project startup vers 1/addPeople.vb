Imports System.Data.OleDb ' impor the databases command 

Public Class addcompetitors
    Dim prevoius As Boolean = False 'set up selection varables 
    Dim previousID As Integer
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
    Dim inc As Integer
    Dim numberofPeople As Integer = 1

    Private Sub addPeople_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'on leoad set up the data base connection
        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;"
        thedatabase = "/FencingCompData.mdb"
        fullpath = "\\ccgsintake12\12VineyA$\vb examples for project\working project startup vers 3\project startup vers 1" ' set up data path
		dbsource = "data source= " & fullpath & thedatabase
        con.ConnectionString = dbprovider & dbsource
        con.Open() 'connection open
        'finding data
        sql = "SELECT * FROM competitorData"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "data_comp")
        con.Close()
        maxrows = ds.Tables("data_comp").Rows.Count
        inc = -1


    End Sub


    Private Sub upload_Click(sender As Object, e As EventArgs) Handles upload.Click 'up load button

        maxrows = maxrows + 1 'set up macxamam row
        Dim size As Integer
        size = compStart.numBox.Text
        Dim gender As String
        If gender1.Checked Then 'gender radio button 
            gender = "Male"
        Else
            gender = "Female"
        End If

        Dim str As String
        If prevoius = True Then
            uploadCompetitor()
        Else
            If Age.Text = "" Then 'validation
                Age.Text = "00"
            End If
            con.Open() 'open connection and save data fo the new commeptitor
            str = "insert into competitorData ([Competitor Id], [name], [Surname], [age], [gender]) values ( ?, ?, ?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, con)
            cmd.Parameters.Add(New OleDbParameter("Competitor Id", CType(maxrows, Integer)))
            cmd.Parameters.Add(New OleDbParameter("name", CType(FirstName.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Surname", CType(Surname.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("age", CType(Age.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("gender", CType(gender, String)))

            Try
                previousID = maxrows
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
                uploadCompetitor()

            Catch ex As Exception
                MsgBox("An error has occured this is caused buy two competitors being assiend the same id number pleaase re enter the information should this error continue it may be nessersary to deleate records from the database")
                con.Close()
            End Try
        End If
        prevoius = False
        FirstName.Text = "" 'reset to 0
        Surname.Text = ""
        Age.Text = ""
        If numberofPeople > size Then
            MsgBox("maximum number of people reached ") 'close window as score sheet full
            numberofPeople = 1
            Me.Hide()
        End If
    End Sub

    Sub uploadCompetitor()
        Select Case numberofPeople
            Case Is = 1 'set up which boxes to fill in the score sheet
                Scoresheet.aID.Text = previousID 'set up the id for a 
                Scoresheet.AName.Text = FirstName.Text 'pass the name for a
                Scoresheet.AName2.Text = previousID 'set up the second id 

                Scoresheet.aID.Show() 'show the texboxes
                Scoresheet.AName.Show()
                Scoresheet.AName2.Show()
            Case Is = 2
                Scoresheet.Bid.Text = previousID 'set up the b name and id 
                Scoresheet.Bname.Text = FirstName.Text
                Scoresheet.Bname2.Text = previousID
                Scoresheet.Bid.Show() 'show the b name and id boxes
                Scoresheet.Bname.Show()
                Scoresheet.Bname2.Show()
            Case Is = 3
                Scoresheet.CId.Text = previousID ' set up c id and name 
                Scoresheet.Cname.Text = FirstName.Text
                Scoresheet.Cname2.Text = Scoresheet.CId.Text
                Scoresheet.CId.Show() ' show name and id 
                Scoresheet.Cname.Show()
                Scoresheet.Cname2.Show()
            Case Is = 4
                Scoresheet.dId.Text = previousID ' set up name and id 
                Scoresheet.dName.Text = FirstName.Text
                Scoresheet.dName2.Text = Scoresheet.dId.Text
                Scoresheet.dId.Show()
                Scoresheet.dName.Show() 'show id and name boxes 
                Scoresheet.dName2.Show()
            Case Is = 5
                Scoresheet.eId.Text = previousID ' set up c id and name 
                Scoresheet.ename.Text = FirstName.Text
                Scoresheet.ename2.Text = Scoresheet.eId.Text
                Scoresheet.eId.Show() 'show id and name boxes 
                Scoresheet.ename.Show()
                Scoresheet.ename2.Show()
            Case Is = 6
                Scoresheet.fId.Text = previousID ' set up c id and name 
                Scoresheet.fname.Text = FirstName.Text
                Scoresheet.fname2.Text = Scoresheet.fId.Text
                Scoresheet.fId.Show() 'show id and name boxes 
                Scoresheet.fname.Show()
                Scoresheet.fname2.Show()
        End Select
        numberofPeople = numberofPeople + 1
        MsgBox("compettitor added ")
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click 'selection of an old compeititor
        Dim int As Integer = 0

        previousID = InputBox("what is the ID of the competitor ") 'selecting the compeitor 
        sql = "SELECT *  FROM [CompetitorData]" 'sql stament
        Dim da1 = New OleDb.OleDbDataAdapter(sql, con)
        da1.Fill(ds, "data_com")
        maxrows = ds.Tables("data_com").Rows.Count
        maxrows = maxrows - 1
        While ds.Tables("data_com").Rows(int).Item(0) <> previousID 'search the database 
            int = int + 1
            FirstName.Text = ds.Tables("data_com").Rows(int).Item(1)
            Surname.Text = ds.Tables("data_com").Rows(int).Item(2)
            Age.Text = ds.Tables("data_com").Rows(int).Item(3)
            If int < ds.Tables("data_com").Rows(maxrows - 1).Item(0) Then

            Else
                FirstName.Text = ""
                Surname.Text = "" 'not found
                MsgBox("not in Data base")
                Exit While
            End If
            If previousID = ds.Tables("data_com").Rows(int).Item(0) Then
                prevoius = True 'if found
            End If
        End While
        'close the connection
        con.Close()
        'NameTextBox.Text = ds.Tables("data_names").Rows(inc).Item(1)
    End Sub
End Class