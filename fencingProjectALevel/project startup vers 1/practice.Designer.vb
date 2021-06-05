<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class practice
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(practice))
        Me.Aname = New System.Windows.Forms.TextBox()
        Me.Bname = New System.Windows.Forms.TextBox()
        Me.AScore1 = New System.Windows.Forms.Button()
        Me.AScore2 = New System.Windows.Forms.Button()
        Me.AScore3 = New System.Windows.Forms.Button()
        Me.Ascore4 = New System.Windows.Forms.Button()
        Me.AScore5 = New System.Windows.Forms.Button()
        Me.BScore5 = New System.Windows.Forms.Button()
        Me.BScore4 = New System.Windows.Forms.Button()
        Me.BScore3 = New System.Windows.Forms.Button()
        Me.BScore2 = New System.Windows.Forms.Button()
        Me.BScore1 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Navigation = New System.Windows.Forms.ToolStripDropDownButton()
        Me.backBtn = New System.Windows.Forms.ToolStripMenuItem()
        Me.recordsStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateACompetition = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScoreSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDatabaseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Options = New System.Windows.Forms.ToolStripDropDownButton()
        Me.EnterNames = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogInBtn = New System.Windows.Forms.ToolStripButton()
        Me.logedAs = New System.Windows.Forms.ToolStripLabel()
        Me.logoutbtn = New System.Windows.Forms.ToolStripButton()
        Me.CompTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.StartTimerBtn = New System.Windows.Forms.Button()
        Me.CommitBtn = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Aname
        '
        Me.Aname.Location = New System.Drawing.Point(32, 87)
        Me.Aname.Name = "Aname"
        Me.Aname.ReadOnly = True
        Me.Aname.Size = New System.Drawing.Size(100, 20)
        Me.Aname.TabIndex = 0
        '
        'Bname
        '
        Me.Bname.Location = New System.Drawing.Point(32, 157)
        Me.Bname.Name = "Bname"
        Me.Bname.ReadOnly = True
        Me.Bname.Size = New System.Drawing.Size(100, 20)
        Me.Bname.TabIndex = 1
        '
        'AScore1
        '
        Me.AScore1.Location = New System.Drawing.Point(168, 84)
        Me.AScore1.Name = "AScore1"
        Me.AScore1.Size = New System.Drawing.Size(25, 23)
        Me.AScore1.TabIndex = 2
        Me.AScore1.Text = "1"
        Me.AScore1.UseVisualStyleBackColor = True
        '
        'AScore2
        '
        Me.AScore2.Location = New System.Drawing.Point(221, 84)
        Me.AScore2.Name = "AScore2"
        Me.AScore2.Size = New System.Drawing.Size(25, 23)
        Me.AScore2.TabIndex = 3
        Me.AScore2.Text = "2"
        Me.AScore2.UseVisualStyleBackColor = True
        '
        'AScore3
        '
        Me.AScore3.Location = New System.Drawing.Point(274, 84)
        Me.AScore3.Name = "AScore3"
        Me.AScore3.Size = New System.Drawing.Size(23, 23)
        Me.AScore3.TabIndex = 4
        Me.AScore3.Text = "3"
        Me.AScore3.UseVisualStyleBackColor = True
        '
        'Ascore4
        '
        Me.Ascore4.Location = New System.Drawing.Point(325, 84)
        Me.Ascore4.Name = "Ascore4"
        Me.Ascore4.Size = New System.Drawing.Size(23, 23)
        Me.Ascore4.TabIndex = 5
        Me.Ascore4.Text = "4"
        Me.Ascore4.UseVisualStyleBackColor = True
        '
        'AScore5
        '
        Me.AScore5.Location = New System.Drawing.Point(376, 84)
        Me.AScore5.Name = "AScore5"
        Me.AScore5.Size = New System.Drawing.Size(23, 23)
        Me.AScore5.TabIndex = 6
        Me.AScore5.Text = "5"
        Me.AScore5.UseVisualStyleBackColor = True
        '
        'BScore5
        '
        Me.BScore5.Location = New System.Drawing.Point(376, 154)
        Me.BScore5.Name = "BScore5"
        Me.BScore5.Size = New System.Drawing.Size(23, 23)
        Me.BScore5.TabIndex = 11
        Me.BScore5.Text = "5"
        Me.BScore5.UseVisualStyleBackColor = True
        '
        'BScore4
        '
        Me.BScore4.Location = New System.Drawing.Point(325, 154)
        Me.BScore4.Name = "BScore4"
        Me.BScore4.Size = New System.Drawing.Size(23, 23)
        Me.BScore4.TabIndex = 10
        Me.BScore4.Text = "4"
        Me.BScore4.UseVisualStyleBackColor = True
        '
        'BScore3
        '
        Me.BScore3.Location = New System.Drawing.Point(274, 154)
        Me.BScore3.Name = "BScore3"
        Me.BScore3.Size = New System.Drawing.Size(23, 23)
        Me.BScore3.TabIndex = 9
        Me.BScore3.Text = "3"
        Me.BScore3.UseVisualStyleBackColor = True
        '
        'BScore2
        '
        Me.BScore2.Location = New System.Drawing.Point(221, 154)
        Me.BScore2.Name = "BScore2"
        Me.BScore2.Size = New System.Drawing.Size(25, 23)
        Me.BScore2.TabIndex = 8
        Me.BScore2.Text = "2"
        Me.BScore2.UseVisualStyleBackColor = True
        '
        'BScore1
        '
        Me.BScore1.Location = New System.Drawing.Point(168, 154)
        Me.BScore1.Name = "BScore1"
        Me.BScore1.Size = New System.Drawing.Size(25, 23)
        Me.BScore1.TabIndex = 7
        Me.BScore1.Text = "1"
        Me.BScore1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Navigation, Me.Options, Me.LogInBtn, Me.logedAs, Me.logoutbtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(420, 25)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Navigation
        '
        Me.Navigation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Navigation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.backBtn, Me.recordsStrip, Me.CreateACompetition, Me.ScoreSheetToolStripMenuItem, Me.ViewDatabaseToolStripMenuItem1})
        Me.Navigation.Image = CType(resources.GetObject("Navigation.Image"), System.Drawing.Image)
        Me.Navigation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Navigation.Name = "Navigation"
        Me.Navigation.Size = New System.Drawing.Size(78, 22)
        Me.Navigation.Text = "Navigation"
        '
        'backBtn
        '
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(187, 22)
        Me.backBtn.Text = "Return to Main menu"
        '
        'recordsStrip
        '
        Me.recordsStrip.Name = "recordsStrip"
        Me.recordsStrip.Size = New System.Drawing.Size(187, 22)
        Me.recordsStrip.Text = "Veiw Records"
        '
        'CreateACompetition
        '
        Me.CreateACompetition.Name = "CreateACompetition"
        Me.CreateACompetition.Size = New System.Drawing.Size(187, 22)
        Me.CreateACompetition.Text = "Create a Competition"
        '
        'ScoreSheetToolStripMenuItem
        '
        Me.ScoreSheetToolStripMenuItem.Name = "ScoreSheetToolStripMenuItem"
        Me.ScoreSheetToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ScoreSheetToolStripMenuItem.Text = "Score sheet"
        '
        'ViewDatabaseToolStripMenuItem1
        '
        Me.ViewDatabaseToolStripMenuItem1.Name = "ViewDatabaseToolStripMenuItem1"
        Me.ViewDatabaseToolStripMenuItem1.Size = New System.Drawing.Size(187, 22)
        Me.ViewDatabaseToolStripMenuItem1.Text = "View Database"
        '
        'Options
        '
        Me.Options.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Options.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterNames, Me.ChangeTime})
        Me.Options.Image = CType(resources.GetObject("Options.Image"), System.Drawing.Image)
        Me.Options.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(144, 22)
        Me.Options.Text = "Practice Match Options"
        '
        'EnterNames
        '
        Me.EnterNames.Name = "EnterNames"
        Me.EnterNames.Size = New System.Drawing.Size(143, 22)
        Me.EnterNames.Text = "Enter Names"
        '
        'ChangeTime
        '
        Me.ChangeTime.Name = "ChangeTime"
        Me.ChangeTime.Size = New System.Drawing.Size(143, 22)
        Me.ChangeTime.Text = "change Time"
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
        'logoutbtn
        '
        Me.logoutbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.logoutbtn.Image = CType(resources.GetObject("logoutbtn.Image"), System.Drawing.Image)
        Me.logoutbtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.logoutbtn.Name = "logoutbtn"
        Me.logoutbtn.Size = New System.Drawing.Size(49, 22)
        Me.logoutbtn.Text = "Logout"
        '
        'CompTimer
        '
        Me.CompTimer.Interval = 1000
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Location = New System.Drawing.Point(197, 25)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(25, 13)
        Me.LabelTime.TabIndex = 15
        Me.LabelTime.Text = "180"
        '
        'StartTimerBtn
        '
        Me.StartTimerBtn.Location = New System.Drawing.Point(173, 55)
        Me.StartTimerBtn.Name = "StartTimerBtn"
        Me.StartTimerBtn.Size = New System.Drawing.Size(75, 23)
        Me.StartTimerBtn.TabIndex = 16
        Me.StartTimerBtn.Text = "Start Timer"
        Me.StartTimerBtn.UseVisualStyleBackColor = True
        '
        'CommitBtn
        '
        Me.CommitBtn.Location = New System.Drawing.Point(45, 114)
        Me.CommitBtn.Name = "CommitBtn"
        Me.CommitBtn.Size = New System.Drawing.Size(75, 37)
        Me.CommitBtn.TabIndex = 17
        Me.CommitBtn.Text = "Commit changes"
        Me.CommitBtn.UseVisualStyleBackColor = True
        '
        'practice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 200)
        Me.Controls.Add(Me.CommitBtn)
        Me.Controls.Add(Me.StartTimerBtn)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BScore5)
        Me.Controls.Add(Me.BScore4)
        Me.Controls.Add(Me.BScore3)
        Me.Controls.Add(Me.BScore2)
        Me.Controls.Add(Me.BScore1)
        Me.Controls.Add(Me.AScore5)
        Me.Controls.Add(Me.Ascore4)
        Me.Controls.Add(Me.AScore3)
        Me.Controls.Add(Me.AScore2)
        Me.Controls.Add(Me.AScore1)
        Me.Controls.Add(Me.Bname)
        Me.Controls.Add(Me.Aname)
        Me.Name = "practice"
        Me.Text = "Practice Match"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Aname As TextBox
    Friend WithEvents Bname As TextBox
    Friend WithEvents AScore1 As Button
    Friend WithEvents AScore2 As Button
    Friend WithEvents AScore3 As Button
    Friend WithEvents Ascore4 As Button
    Friend WithEvents AScore5 As Button
    Friend WithEvents BScore5 As Button
    Friend WithEvents BScore4 As Button
    Friend WithEvents BScore3 As Button
    Friend WithEvents BScore2 As Button
    Friend WithEvents BScore1 As Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Navigation As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents backBtn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents recordsStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Options As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents EnterNames As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateACompetition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompTimer As System.Windows.Forms.Timer
    Friend WithEvents LabelTime As System.Windows.Forms.Label
    Friend WithEvents ChangeTime As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents logedAs As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ScoreSheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogInBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents logoutbtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents StartTimerBtn As System.Windows.Forms.Button
    Friend WithEvents CommitBtn As System.Windows.Forms.Button
    Friend WithEvents ViewDatabaseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
