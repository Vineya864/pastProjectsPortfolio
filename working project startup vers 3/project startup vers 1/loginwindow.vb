
Public Class loginwindow
    Public Shared access ' declares the access level so that it can be draw from each of the forms
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



    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load 'on load up the data set and the conection to the data base are made 
        errorlabel.Hide()
        errorlabel2.Hide()
        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;" 'link to database
        thedatabase = "/FencingCompData.mdb" 'database name
		fullpath = "E:\working project startup vers 3\project startup vers 1" 'files
		dbsource = "data source= " & fullpath & thedatabase 'the path way
        con.ConnectionString = dbprovider & dbsource 'connection string
        con.Open()
        'finding data
        sql = "SELECT * FROM acountInfo" 'sql statment
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "data_acounts") 'fill the data adapter
        con.Close()
        maxrows = ds.Tables("data_acounts").Rows.Count ' count the max rows
        inc = -1

    End Sub

    Public Sub cypher(ByRef cyphertext) 'this changes the plain text to the cypher text so that it can be compared to the database
        'cypher value of three
        Dim length As Integer
        Dim count = cyphertext
        length = Len(count)
        Dim pass() As Char = count.ToCharArray 'count the arrays length
        Dim Convertion(length) 'converted array
        Dim Num As Integer = 0
        For Num = 0 To (Len(pass) - 1)
            Convertion(Num) = Asc(pass(Num)) + 3 'cypher
            pass(Num) = Chr(Convertion(Num))
        Next
        cyphertext = String.Join(",", pass) 'join it back together

    End Sub
    Private Async Sub Flash() 'cause the lables to flash 'async lets the code still run whilst this function works in the background
        For i = 0 To 10 'ten times 
            Await Task.Delay(120) 'once every 120 milliseconds
            errorlabel.Visible = Not errorlabel.Visible
            errorlabel2.Visible = Not errorlabel2.Visible
        Next
        errorlabel.Visible = True 'set them up to be visible again
        errorlabel2.Visible = True
    End Sub
    Private Sub sendlog()
        mainMenu.logedAs.Text = Logintextbox.Text 'send the user name to all the forms 
        records.logedAs.Text = Logintextbox.Text
        compStart.logedAs.Text = Logintextbox.Text
        practice.logedAs.Text = Logintextbox.Text
        Scoresheet.logedAs.Text = Logintextbox.Text
        results.logedAs.Text = Logintextbox.Text
        database.logedAs.Text = Logintextbox.Text
        newAccount.logedAs.Text = Logintextbox.Text
    End Sub
    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click 'when login presssed
        inc = 0 'search of the first record
        Logintextbox.Text = Logintextbox.Text.ToUpper() 'set text to upper case
        Dim cyphertext As String
        cyphertext = passwordText.Text
        cypher(cyphertext) 'sewnd the pasword to uncypher
        While inc < maxrows 'search the database
            If Logintextbox.Text = ds.Tables("data_acounts").Rows(inc).Item(1) Then 'if alowed send data
                If cyphertext = ds.Tables("data_acounts").Rows(inc).Item(2) Then 'match it to the database
                    access = ds.Tables("data_acounts").Rows(inc).Item(3)
                    errorlabel.Text = "welcome"
                    sendlog() 'call the sendlog function
                    Me.Close() 'close the window
                Else
                    passwordincorect()
                End If
                Exit While 'end the loop
            End If
            inc = inc + 1 'search the next row
            If inc >= maxrows Then
                passwordincorect() 'call the incorrect function
            End If
        End While
    End Sub


    Sub passwordincorect()
        errorlabel.Show()
        errorlabel2.Show()
        errorlabel.Text = "The user name or password that you have " 'no acount with this name
        errorlabel2.Text = "enterd is incorect"
        Flash()
    End Sub






    Private Sub ScoreSheetNavigate_Click(sender As Object, e As EventArgs) Handles ScoreSheetNavigate.Click 'loads the score sheet
        If Scoresheet.AName.Text <> "" Then
            If loginwindow.access = "part" Then 'locked so can be seen not eddited

                Scoresheet.Show()
                Scoresheet.access = False

            Else
                Scoresheet.access = True 'full access
                mainMenu.fullNeeded(Scoresheet)
            End If
        Else
            MsgBox("there is currently no competion running")
        End If
    End Sub

    Private Sub PracticeMatch_Click(sender As Object, e As EventArgs) Handles practiceMatch.Click 'bring up the practise menue
        practice.Show()
        Me.Close()
    End Sub




    Private Sub MainMenunavigate_Click(sender As Object, e As EventArgs) Handles MainMenuNavigate.Click
        mainMenu.Show()
        Me.Close()
    End Sub
    Public Sub logoutfunction()
        MsgBox("you are now logged out", , "logged out")
        mainMenu.logedAs.Text = "not logged In" 'change all forms so that they show the user they are no longer logged in 
        records.logedAs.Text = "not logged In"
        compStart.logedAs.Text = "not logged In"
        practice.logedAs.Text = "not logged In"
        Scoresheet.logedAs.Text = "not logged In"
        results.logedAs.Text = "Not Logged In"
        Me.logedAs.Text = "Not Logged In"
        database.logedAs.Text = "Not Logged In"
        access = ""
    End Sub
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click 'call the logout function
        logoutfunction()

    End Sub
End Class