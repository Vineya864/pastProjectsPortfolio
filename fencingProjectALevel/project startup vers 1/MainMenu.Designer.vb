<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainMenu))
        Me.Closebtn = New System.Windows.Forms.Button()
        Me.compstartbtn = New System.Windows.Forms.Button()
        Me.PracticeBtn = New System.Windows.Forms.Button()
        Me.PastScorebtn = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Navigation = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PracticeMatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateCompetitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScoreSheetNavigate = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogInBtn = New System.Windows.Forms.ToolStripButton()
        Me.logedAs = New System.Windows.Forms.ToolStripLabel()
        Me.logOut = New System.Windows.Forms.ToolStripButton()
        Me.accountBtn = New System.Windows.Forms.Button()
        Me.databaseBtn = New System.Windows.Forms.Button()
        Me.ViewPastscores = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Closebtn
        '
        Me.Closebtn.Location = New System.Drawing.Point(105, 265)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(75, 23)
        Me.Closebtn.TabIndex = 0
        Me.Closebtn.Text = "Close All"
        Me.Closebtn.UseVisualStyleBackColor = True
        '
        'compstartbtn
        '
        Me.compstartbtn.Location = New System.Drawing.Point(105, 28)
        Me.compstartbtn.Name = "compstartbtn"
        Me.compstartbtn.Size = New System.Drawing.Size(75, 43)
        Me.compstartbtn.TabIndex = 1
        Me.compstartbtn.Text = "Create Competition"
        Me.compstartbtn.UseVisualStyleBackColor = True
        '
        'PracticeBtn
        '
        Me.PracticeBtn.Location = New System.Drawing.Point(105, 77)
        Me.PracticeBtn.Name = "PracticeBtn"
        Me.PracticeBtn.Size = New System.Drawing.Size(75, 40)
        Me.PracticeBtn.TabIndex = 2
        Me.PracticeBtn.Text = "Practice Match"
        Me.PracticeBtn.UseVisualStyleBackColor = True
        '
        'PastScorebtn
        '
        Me.PastScorebtn.Location = New System.Drawing.Point(105, 123)
        Me.PastScorebtn.Name = "PastScorebtn"
        Me.PastScorebtn.Size = New System.Drawing.Size(75, 45)
        Me.PastScorebtn.TabIndex = 3
        Me.PastScorebtn.Text = "view past scores"
        Me.PastScorebtn.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Navigation, Me.LogInBtn, Me.logedAs, Me.logOut})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(284, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Navigation
        '
        Me.Navigation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Navigation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PracticeMatchToolStripMenuItem, Me.CreateCompetitionToolStripMenuItem, Me.ViewDatabaseToolStripMenuItem, Me.ScoreSheetNavigate, Me.ViewPastscores})
        Me.Navigation.Image = CType(resources.GetObject("Navigation.Image"), System.Drawing.Image)
        Me.Navigation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Navigation.Name = "Navigation"
        Me.Navigation.Size = New System.Drawing.Size(78, 22)
        Me.Navigation.Text = "Navigation"
        '
        'PracticeMatchToolStripMenuItem
        '
        Me.PracticeMatchToolStripMenuItem.Name = "PracticeMatchToolStripMenuItem"
        Me.PracticeMatchToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.PracticeMatchToolStripMenuItem.Text = "Practice Match"
        '
        'CreateCompetitionToolStripMenuItem
        '
        Me.CreateCompetitionToolStripMenuItem.Name = "CreateCompetitionToolStripMenuItem"
        Me.CreateCompetitionToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CreateCompetitionToolStripMenuItem.Text = "Create Competition"
        '
        'ViewDatabaseToolStripMenuItem
        '
        Me.ViewDatabaseToolStripMenuItem.Name = "ViewDatabaseToolStripMenuItem"
        Me.ViewDatabaseToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ViewDatabaseToolStripMenuItem.Text = "View Database"
        '
        'ScoreSheetNavigate
        '
        Me.ScoreSheetNavigate.Name = "ScoreSheetNavigate"
        Me.ScoreSheetNavigate.Size = New System.Drawing.Size(178, 22)
        Me.ScoreSheetNavigate.Text = "Score Sheet"
        '
        'LogInBtn
        '
        Me.LogInBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.LogInBtn.Image = CType(resources.GetObject("LogInBtn.Image"), System.Drawing.Image)
        Me.LogInBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LogInBtn.Name = "LogInBtn"
        Me.LogInBtn.Size = New System.Drawing.Size(44, 22)
        Me.LogInBtn.Text = "Log In"
        '
        'logedAs
        '
        Me.logedAs.Name = "logedAs"
        Me.logedAs.Size = New System.Drawing.Size(78, 22)
        Me.logedAs.Text = "Not signed In"
        '
        'logOut
        '
        Me.logOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.logOut.Image = CType(resources.GetObject("logOut.Image"), System.Drawing.Image)
        Me.logOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.logOut.Name = "logOut"
        Me.logOut.Size = New System.Drawing.Size(51, 22)
        Me.logOut.Text = "LogOut"
        '
        'accountBtn
        '
        Me.accountBtn.Location = New System.Drawing.Point(105, 174)
        Me.accountBtn.Name = "accountBtn"
        Me.accountBtn.Size = New System.Drawing.Size(75, 39)
        Me.accountBtn.TabIndex = 5
        Me.accountBtn.Text = "create acount"
        Me.accountBtn.UseVisualStyleBackColor = True
        '
        'databaseBtn
        '
        Me.databaseBtn.Location = New System.Drawing.Point(105, 219)
        Me.databaseBtn.Name = "databaseBtn"
        Me.databaseBtn.Size = New System.Drawing.Size(75, 40)
        Me.databaseBtn.TabIndex = 6
        Me.databaseBtn.Text = "View Database"
        Me.databaseBtn.UseVisualStyleBackColor = True
        '
        'ViewPastscores
        '
        Me.ViewPastscores.Name = "ViewPastscores"
        Me.ViewPastscores.Size = New System.Drawing.Size(178, 22)
        Me.ViewPastscores.Text = "View Past Scores"
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 300)
        Me.Controls.Add(Me.databaseBtn)
        Me.Controls.Add(Me.accountBtn)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PastScorebtn)
        Me.Controls.Add(Me.PracticeBtn)
        Me.Controls.Add(Me.compstartbtn)
        Me.Controls.Add(Me.Closebtn)
        Me.Name = "mainMenu"
        Me.Text = "Main menu"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Closebtn As System.Windows.Forms.Button
    Friend WithEvents compstartbtn As System.Windows.Forms.Button
    Friend WithEvents PracticeBtn As System.Windows.Forms.Button
    Friend WithEvents PastScorebtn As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Navigation As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents PracticeMatchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateCompetitionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogInBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents accountBtn As System.Windows.Forms.Button
    Friend WithEvents databaseBtn As System.Windows.Forms.Button
    Friend WithEvents logedAs As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ScoreSheetNavigate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents logOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ViewPastscores As System.Windows.Forms.ToolStripMenuItem

End Class
