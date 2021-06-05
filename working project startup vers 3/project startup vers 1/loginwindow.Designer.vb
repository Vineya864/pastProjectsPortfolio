<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginwindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginwindow))
        Me.Logintextbox = New System.Windows.Forms.TextBox()
        Me.passwordText = New System.Windows.Forms.TextBox()
        Me.login = New System.Windows.Forms.Button()
        Me.errorlabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Navigation = New System.Windows.Forms.ToolStripDropDownButton()
        Me.practiceMatch = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScoreSheetNavigate = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuNavigate = New System.Windows.Forms.ToolStripMenuItem()
        Me.logedAs = New System.Windows.Forms.ToolStripLabel()
        Me.errorlabel2 = New System.Windows.Forms.Label()
        Me.Logout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Logintextbox
        '
        Me.Logintextbox.Location = New System.Drawing.Point(74, 44)
        Me.Logintextbox.Name = "Logintextbox"
        Me.Logintextbox.Size = New System.Drawing.Size(100, 20)
        Me.Logintextbox.TabIndex = 0
        '
        'passwordText
        '
        Me.passwordText.Location = New System.Drawing.Point(74, 84)
        Me.passwordText.Name = "passwordText"
        Me.passwordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordText.Size = New System.Drawing.Size(100, 20)
        Me.passwordText.TabIndex = 1
        '
        'login
        '
        Me.login.Location = New System.Drawing.Point(84, 160)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(75, 23)
        Me.login.TabIndex = 2
        Me.login.Text = "Login"
        Me.login.UseVisualStyleBackColor = True
        '
        'errorlabel
        '
        Me.errorlabel.AutoSize = True
        Me.errorlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.errorlabel.ForeColor = System.Drawing.Color.Red
        Me.errorlabel.Location = New System.Drawing.Point(48, 107)
        Me.errorlabel.Name = "errorlabel"
        Me.errorlabel.Size = New System.Drawing.Size(50, 13)
        Me.errorlabel.TabIndex = 3
        Me.errorlabel.Text = "errorlabel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Navigation, Me.logedAs, Me.Logout})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(274, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Navigation
        '
        Me.Navigation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Navigation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.practiceMatch, Me.ScoreSheetNavigate, Me.MainMenuNavigate})
        Me.Navigation.Image = CType(resources.GetObject("Navigation.Image"), System.Drawing.Image)
        Me.Navigation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Navigation.Name = "Navigation"
        Me.Navigation.Size = New System.Drawing.Size(78, 22)
        Me.Navigation.Text = "Navigation"
        '
        'practiceMatch
        '
        Me.practiceMatch.Name = "practiceMatch"
        Me.practiceMatch.Size = New System.Drawing.Size(153, 22)
        Me.practiceMatch.Text = "Practice Match"
        '
        'ScoreSheetNavigate
        '
        Me.ScoreSheetNavigate.Name = "ScoreSheetNavigate"
        Me.ScoreSheetNavigate.Size = New System.Drawing.Size(153, 22)
        Me.ScoreSheetNavigate.Text = "Score Sheet"
        '
        'MainMenuNavigate
        '
        Me.MainMenuNavigate.Name = "MainMenuNavigate"
        Me.MainMenuNavigate.Size = New System.Drawing.Size(153, 22)
        Me.MainMenuNavigate.Text = "Main menu"
        '
        'logedAs
        '
        Me.logedAs.Name = "logedAs"
        Me.logedAs.Size = New System.Drawing.Size(78, 22)
        Me.logedAs.Text = "Not signed In"
        '
        'errorlabel2
        '
        Me.errorlabel2.AutoSize = True
        Me.errorlabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.errorlabel2.ForeColor = System.Drawing.Color.Red
        Me.errorlabel2.Location = New System.Drawing.Point(90, 132)
        Me.errorlabel2.Name = "errorlabel2"
        Me.errorlabel2.Size = New System.Drawing.Size(50, 13)
        Me.errorlabel2.TabIndex = 7
        Me.errorlabel2.Text = "errorlabel"
        '
        'Logout
        '
        Me.Logout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Logout.Image = CType(resources.GetObject("Logout.Image"), System.Drawing.Image)
        Me.Logout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(48, 22)
        Me.Logout.Text = "logOut"
        '
        'loginwindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 229)
        Me.Controls.Add(Me.errorlabel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.errorlabel)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.passwordText)
        Me.Controls.Add(Me.Logintextbox)
        Me.Name = "loginwindow"
        Me.Text = "Login"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Logintextbox As System.Windows.Forms.TextBox
    Friend WithEvents passwordText As System.Windows.Forms.TextBox
    Friend WithEvents login As System.Windows.Forms.Button
    Friend WithEvents errorlabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Navigation As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents practiceMatch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScoreSheetNavigate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents logedAs As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MainMenuNavigate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents errorlabel2 As System.Windows.Forms.Label
    Friend WithEvents Logout As System.Windows.Forms.ToolStripButton
End Class
