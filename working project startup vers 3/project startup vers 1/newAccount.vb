Imports System.Data.OleDb
Public Class newAccount

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
    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        errorlabel.Hide()
        dbprovider = "provider=Microsoft.Jet.OLEDB.4.0;" 'link to database
        thedatabase = "/FencingCompData.mdb" 'database name
        fullpath = "\Fencing Program\working project startup vers 3\project startup vers 1" 'files
        dbsource = "data source= " & fullpath & thedatabase 'the path way
        con.ConnectionString = dbprovider & dbsource 'connection string
        con.Open()
        'finding data
        sql = "SELECT * FROM acountInfo" 'set command
        da = New OleDb.OleDbDataAdapter(sql, con) 'set data adapter
        da.Fill(ds, "data_acounts") 'fill the dataset
        con.Close() 'close connection
        maxrows = ds.Tables("data_acounts").Rows.Count 'set up a max rwo value
        inc = 0



        partAC.Checked = True
    End Sub
    Sub whichAccess(ByRef access)
        If completeAC.Checked Then
            access = "complete"
        ElseIf partAC.Checked Then
            access = "part"
        End If
    End Sub
    Public Sub cypher(ByRef text)
        Dim count = text 'pass the info
        Dim length As Integer 'creat the length
        length = Len(count) 'set the length
        Dim pass() As Char = count.ToCharArray 'send to an array
        Dim Convertion(length) 'convert
        Dim Num As Integer = 0 'set number to 0
        For Num = 0 To (Len(pass) - 1) 'from 0 to length of arraty
            Convertion(Num) = Asc(pass(Num)) + 3 'cypher
            pass(Num) = Chr(Convertion(Num))

        Next

        text = String.Join(",", pass) 'build again.

    End Sub
    Sub checkAndSAve(access)
        While inc <= maxrows 'cycle through the database
            If username.Text = ds.Tables("data_acounts").Rows(inc).Item(1) Then 'if there is a user with this name
                MsgBox("this user name is already used please select another", vbCritical, "Unable to process request")
                Exit While
            End If
            inc = inc + 1 'increase by one to search next row
            If inc >= maxrows Then 'if no more records to search
                Dim passtext As String
                passtext = passwordText.Text
                cypher(passtext) 'encyrpt the password


                Dim str As String
                con.Open() 'open connection
                str = "insert into acountInfo ( [UserName], [Password], [Access]) values ( ?, ?,?)" 'sql command for save
                Dim cmd As OleDbCommand = New OleDbCommand(str, con) 'save command

                cmd.Parameters.Add(New OleDbParameter("UserName", CType(username.Text, String))) 'enter information
                cmd.Parameters.Add(New OleDbParameter("Password", CType(passtext, String)))
                cmd.Parameters.Add(New OleDbParameter("Access", CType(access, String)))
                Try
                    cmd.ExecuteNonQuery() 'run the program
                    cmd.Dispose() 'bin command
                    con.Close() 'close connection
                    MsgBox("acount made", , "Save succesfull") 'save succesfull
                    mainMenu.Show() 'back to main menu
                    Me.Close()
                    Exit While
                Catch ex As Exception
                    errorlabel.Show() 'error
                    errorlabel.Text = "the information you have eneterd has been rejected please change the information" 'if there is an error in the information
                    Exit While
                End Try

            End If
        End While
    End Sub
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click 'when save is pressed
        Dim access As String 'declear access
        access = "!" 'fil the access with a varable so not a null value
        username.Text = username.Text.ToUpper() 'convert username
        whichAccess(access) 'find true access level
        checkAndSAve(access) 'save

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


    Private Sub PracticeMatch_Click(sender As Object, e As EventArgs) Handles PracticeMatch.Click
        practice.Show()
        Me.Close()
    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub

    Private Sub logedAs_Click(sender As Object, e As EventArgs) Handles logedAs.Click

    End Sub
End Class