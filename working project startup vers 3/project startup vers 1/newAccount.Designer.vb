<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newAccount))
        Me.username = New System.Windows.Forms.TextBox()
        Me.passwordText = New System.Windows.Forms.TextBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.completeAC = New System.Windows.Forms.RadioButton()
        Me.partAC = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.errorlabel = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Navigation = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PracticeMatch = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateCompetition = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScoreSheetNavigate = New System.Windows.Forms.ToolStripMenuItem()
        Me.logedAs = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(74, 31)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(100, 20)
        Me.username.TabIndex = 0
        '
        'passwordText
        '
        Me.passwordText.Location = New System.Drawing.Point(74, 66)
        Me.passwordText.Name = "passwordText"
        Me.passwordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordText.Size = New System.Drawing.Size(100, 20)
        Me.passwordText.TabIndex = 1
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(88, 153)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(75, 23)
        Me.saveBtn.TabIndex = 2
        Me.saveBtn.Text = "Submit"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'completeAC
        '
        Me.completeAC.AutoSize = True
        Me.completeAC.Location = New System.Drawing.Point(74, 117)
        Me.completeAC.Name = "completeAC"
        Me.completeAC.Size = New System.Drawing.Size(38, 17)
        Me.completeAC.TabIndex = 3
        Me.completeAC.TabStop = True
        Me.completeAC.Text = "full"
        Me.completeAC.UseVisualStyleBackColor = True
        '
        'partAC
        '
        Me.partAC.AutoSize = True
        Me.partAC.Location = New System.Drawing.Point(130, 117)
        Me.partAC.Name = "partAC"
        Me.partAC.Size = New System.Drawing.Size(44, 17)
        Me.partAC.TabIndex = 4
        Me.partAC.TabStop = True
        Me.partAC.Text = "Part"
        Me.partAC.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "User Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Access level"
        '
        'errorlabel
        '
        Me.errorlabel.AutoSize = True
        Me.errorlabel.Location = New System.Drawing.Point(-3, 182)
        Me.errorlabel.Name = "errorlabel"
        Me.errorlabel.Size = New System.Drawing.Size(50, 13)
        Me.errorlabel.TabIndex = 9
        Me.errorlabel.Text = "errorlabel"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Navigation, Me.logedAs})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(274, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Navigation
        '
        Me.Navigation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Navigation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PracticeMatch, Me.CreateCompetition, Me.ViewDatabase, Me.ScoreSheetNavigate})
        Me.Navigation.Image = CType(resources.GetObject("Navigation.Image"), System.Drawing.Image)
        Me.Navigation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Navigation.Name = "Navigation"
        Me.Navigation.Size = New System.Drawing.Size(78, 22)
        Me.Navigation.Text = "Navigation"
        '
        'PracticeMatch
        '
        Me.PracticeMatch.Name = "PracticeMatch"
        Me.PracticeMatch.Size = New System.Drawing.Size(178, 22)
        Me.PracticeMatch.Text = "Practice Match"
        '
        'CreateCompetition
        '
        Me.CreateCompetition.Name = "CreateCompetition"
        Me.CreateCompetition.Size = New System.Drawing.Size(178, 22)
        Me.CreateCompetition.Text = "Create Competition"
        '
        'ViewDatabase
        '
        Me.ViewDatabase.Name = "ViewDatabase"
        Me.ViewDatabase.Size = New System.Drawing.Size(178, 22)
        Me.ViewDatabase.Text = "View Database"
        '
        'ScoreSheetNavigate
        '
        Me.ScoreSheetNavigate.Name = "ScoreSheetNavigate"
        Me.ScoreSheetNavigate.Size = New System.Drawing.Size(178, 22)
        Me.ScoreSheetNavigate.Text = "Score Sheet"
        '
        'logedAs
        '
        Me.logedAs.Name = "logedAs"
        Me.logedAs.Size = New System.Drawing.Size(78, 22)
        Me.logedAs.Text = "Not signed In"
        '
        'newAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 229)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.errorlabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.partAC)
        Me.Controls.Add(Me.completeAC)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.passwordText)
        Me.Controls.Add(Me.username)
        Me.Name = "newAccount"
        Me.Text = "Create a New Acount"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents passwordText As System.Windows.Forms.TextBox
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents completeAC As System.Windows.Forms.RadioButton
    Friend WithEvents partAC As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents errorlabel As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Navigation As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents PracticeMatch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateCompetition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDatabase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScoreSheetNavigate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents logedAs As System.Windows.Forms.ToolStripLabel
End Class
