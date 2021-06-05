Public Class weaponSelection
    Private Sub weaponSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        foil.Checked = True

    End Sub
    Function selection() 'the selection process
        'if a radio button is checked send this information
        If foil.Checked Then
            Return ("Foil")
        ElseIf epee.Checked Then
            Return ("Epee")
        Else
            Return ("saber")
        End If
    End Function
    Private Sub subbtn_Click(sender As Object, e As EventArgs) Handles subbtn.Click 'updates the data for the other form 
        compStart.weapBox.Text = selection() 'make the textbox the result of the fucntion

        compStart.weapselect = True 'let the program know that a selction was made


        Me.Close() 'close the window

    End Sub


End Class