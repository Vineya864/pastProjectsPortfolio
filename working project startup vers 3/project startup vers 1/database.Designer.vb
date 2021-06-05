<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class database
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
        Dim ScoreIDLabel As System.Windows.Forms.Label
        Dim Comp_IdLabel As System.Windows.Forms.Label
        Dim Competitor_IdLabel As System.Windows.Forms.Label
        Dim Average_points_scoredLabel As System.Windows.Forms.Label
        Dim Average_points_scored_againstLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim Average_winLabel As System.Windows.Forms.Label
        Dim Comp_IdLabel1 As System.Windows.Forms.Label
        Dim Comp_NameLabel As System.Windows.Forms.Label
        Dim Comp_sizeLabel As System.Windows.Forms.Label
        Dim Comp_DateLabel As System.Windows.Forms.Label
        Dim WeaponLabel As System.Windows.Forms.Label
        Dim Competitor_IdLabel1 As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim AccessLabel As System.Windows.Forms.Label
        Dim Ref_IDLabel As System.Windows.Forms.Label
        Dim Comp_IdLabel2 As System.Windows.Forms.Label
        Dim Comp_NameLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(database))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Navigation = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ReturnToMainMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PracticeMatch = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateCompetition = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewGraphsBtn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScoreSheetNavigate = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogInBtn = New System.Windows.Forms.ToolStripButton()
        Me.logedAs = New System.Windows.Forms.ToolStripLabel()
        Me.LogoutBtn = New System.Windows.Forms.ToolStripButton()
        Me.ProjectDataSet = New project_startup_vers_1.projectDataSet()
        Me.ProjectDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScoreDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScoreDataTableAdapter = New project_startup_vers_1.projectDataSetTableAdapters.ScoreDataTableAdapter()
        Me.TableAdapterManager = New project_startup_vers_1.projectDataSetTableAdapters.TableAdapterManager()
        Me.ScoreDataDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ScoreDataTab = New System.Windows.Forms.TabPage()
        Me.DeleteScoreBtn = New System.Windows.Forms.Button()
        Me.updateBtnScoreData = New System.Windows.Forms.Button()
        Me.UpBtnscoreData = New System.Windows.Forms.Button()
        Me.DownBtnScoreData = New System.Windows.Forms.Button()
        Me.ScoreIDTextBox = New System.Windows.Forms.TextBox()
        Me.Comp_IdTextBox = New System.Windows.Forms.TextBox()
        Me.Competitor_IdTextBox = New System.Windows.Forms.TextBox()
        Me.Average_points_scoredTextBox = New System.Windows.Forms.TextBox()
        Me.Average_points_scored_againstTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.Average_winTextBox = New System.Windows.Forms.TextBox()
        Me.compTab = New System.Windows.Forms.TabPage()
        Me.CompDataDeleteBtn = New System.Windows.Forms.Button()
        Me.CompUpdate = New System.Windows.Forms.Button()
        Me.UPbtnCompData = New System.Windows.Forms.Button()
        Me.DownBtnCompData = New System.Windows.Forms.Button()
        Me.WeaponTextBox = New System.Windows.Forms.TextBox()
        Me.CompititionDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Comp_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Comp_sizeTextBox = New System.Windows.Forms.TextBox()
        Me.Comp_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Comp_IdTextBoxComp = New System.Windows.Forms.TextBox()
        Me.CompititionDataDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.competitorTab = New System.Windows.Forms.TabPage()
        Me.DeleteCompetBtn = New System.Windows.Forms.Button()
        Me.CompetitorUpdateBtn = New System.Windows.Forms.Button()
        Me.competitorUpBtn = New System.Windows.Forms.Button()
        Me.CompetitorDownBtn = New System.Windows.Forms.Button()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.CompetitorDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Competitor_IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.CompetitorDataDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountInfo = New System.Windows.Forms.TabPage()
        Me.AccountDeleteBtn = New System.Windows.Forms.Button()
        Me.AccountsUpdate = New System.Windows.Forms.Button()
        Me.AccountUp = New System.Windows.Forms.Button()
        Me.Accountdown = New System.Windows.Forms.Button()
        Me.cypherBtn = New System.Windows.Forms.Button()
        Me.AccessTextBox = New System.Windows.Forms.TextBox()
        Me.AcountInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.AcountInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compRefTab = New System.Windows.Forms.TabPage()
        Me.RefDelete = New System.Windows.Forms.Button()
        Me.RefUpdate = New System.Windows.Forms.Button()
        Me.RefUpBtn = New System.Windows.Forms.Button()
        Me.RefDownBtn = New System.Windows.Forms.Button()
        Me.Ref_IDTextBox = New System.Windows.Forms.TextBox()
        Me.RefCompititionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Comp_IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.Comp_NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.RefCompititionsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompititionDataTableAdapter = New project_startup_vers_1.projectDataSetTableAdapters.compititionDataTableAdapter()
        Me.CompetitorDataTableAdapter = New project_startup_vers_1.projectDataSetTableAdapters.competitorDataTableAdapter()
        Me.AcountInfoTableAdapter = New project_startup_vers_1.projectDataSetTableAdapters.acountInfoTableAdapter()
        Me.RefCompititionsTableAdapter = New project_startup_vers_1.projectDataSetTableAdapters.RefCompititionsTableAdapter()
        Me.TabLabel = New System.Windows.Forms.Label()
        ScoreIDLabel = New System.Windows.Forms.Label()
        Comp_IdLabel = New System.Windows.Forms.Label()
        Competitor_IdLabel = New System.Windows.Forms.Label()
        Average_points_scoredLabel = New System.Windows.Forms.Label()
        Average_points_scored_againstLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        Average_winLabel = New System.Windows.Forms.Label()
        Comp_IdLabel1 = New System.Windows.Forms.Label()
        Comp_NameLabel = New System.Windows.Forms.Label()
        Comp_sizeLabel = New System.Windows.Forms.Label()
        Comp_DateLabel = New System.Windows.Forms.Label()
        WeaponLabel = New System.Windows.Forms.Label()
        Competitor_IdLabel1 = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        AccessLabel = New System.Windows.Forms.Label()
        Ref_IDLabel = New System.Windows.Forms.Label()
        Comp_IdLabel2 = New System.Windows.Forms.Label()
        Comp_NameLabel1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScoreDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScoreDataDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.ScoreDataTab.SuspendLayout()
        Me.compTab.SuspendLayout()
        CType(Me.CompititionDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompititionDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.competitorTab.SuspendLayout()
        CType(Me.CompetitorDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompetitorDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccountInfo.SuspendLayout()
        CType(Me.AcountInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcountInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.compRefTab.SuspendLayout()
        CType(Me.RefCompititionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefCompititionsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScoreIDLabel
        '
        ScoreIDLabel.AutoSize = True
        ScoreIDLabel.Location = New System.Drawing.Point(29, 25)
        ScoreIDLabel.Name = "ScoreIDLabel"
        ScoreIDLabel.Size = New System.Drawing.Size(52, 13)
        ScoreIDLabel.TabIndex = 86
        ScoreIDLabel.Text = "Score ID:"
        '
        'Comp_IdLabel
        '
        Comp_IdLabel.AutoSize = True
        Comp_IdLabel.Location = New System.Drawing.Point(29, 58)
        Comp_IdLabel.Name = "Comp_IdLabel"
        Comp_IdLabel.Size = New System.Drawing.Size(48, 13)
        Comp_IdLabel.TabIndex = 88
        Comp_IdLabel.Text = "comp Id:"
        '
        'Competitor_IdLabel
        '
        Competitor_IdLabel.AutoSize = True
        Competitor_IdLabel.Location = New System.Drawing.Point(29, 98)
        Competitor_IdLabel.Name = "Competitor_IdLabel"
        Competitor_IdLabel.Size = New System.Drawing.Size(72, 13)
        Competitor_IdLabel.TabIndex = 90
        Competitor_IdLabel.Text = "Competitor Id:"
        '
        'Average_points_scoredLabel
        '
        Average_points_scoredLabel.AutoSize = True
        Average_points_scoredLabel.Location = New System.Drawing.Point(29, 131)
        Average_points_scoredLabel.Name = "Average_points_scoredLabel"
        Average_points_scoredLabel.Size = New System.Drawing.Size(115, 13)
        Average_points_scoredLabel.TabIndex = 92
        Average_points_scoredLabel.Text = "average points scored:"
        '
        'Average_points_scored_againstLabel
        '
        Average_points_scored_againstLabel.AutoSize = True
        Average_points_scored_againstLabel.Location = New System.Drawing.Point(29, 164)
        Average_points_scored_againstLabel.Name = "Average_points_scored_againstLabel"
        Average_points_scored_againstLabel.Size = New System.Drawing.Size(152, 13)
        Average_points_scored_againstLabel.TabIndex = 94
        Average_points_scored_againstLabel.Text = "average points scored against:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(29, 197)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(46, 13)
        PositionLabel.TabIndex = 96
        PositionLabel.Text = "position:"
        '
        'Average_winLabel
        '
        Average_winLabel.AutoSize = True
        Average_winLabel.Location = New System.Drawing.Point(29, 230)
        Average_winLabel.Name = "Average_winLabel"
        Average_winLabel.Size = New System.Drawing.Size(68, 13)
        Average_winLabel.TabIndex = 98
        Average_winLabel.Text = "average win:"
        '
        'Comp_IdLabel1
        '
        Comp_IdLabel1.AutoSize = True
        Comp_IdLabel1.Location = New System.Drawing.Point(76, 55)
        Comp_IdLabel1.Name = "Comp_IdLabel1"
        Comp_IdLabel1.Size = New System.Drawing.Size(49, 13)
        Comp_IdLabel1.TabIndex = 1
        Comp_IdLabel1.Text = "Comp Id:"
        '
        'Comp_NameLabel
        '
        Comp_NameLabel.AutoSize = True
        Comp_NameLabel.Location = New System.Drawing.Point(57, 105)
        Comp_NameLabel.Name = "Comp_NameLabel"
        Comp_NameLabel.Size = New System.Drawing.Size(68, 13)
        Comp_NameLabel.TabIndex = 3
        Comp_NameLabel.Text = "Comp Name:"
        '
        'Comp_sizeLabel
        '
        Comp_sizeLabel.AutoSize = True
        Comp_sizeLabel.Location = New System.Drawing.Point(67, 158)
        Comp_sizeLabel.Name = "Comp_sizeLabel"
        Comp_sizeLabel.Size = New System.Drawing.Size(58, 13)
        Comp_sizeLabel.TabIndex = 5
        Comp_sizeLabel.Text = "Comp size:"
        '
        'Comp_DateLabel
        '
        Comp_DateLabel.AutoSize = True
        Comp_DateLabel.Location = New System.Drawing.Point(57, 200)
        Comp_DateLabel.Name = "Comp_DateLabel"
        Comp_DateLabel.Size = New System.Drawing.Size(63, 13)
        Comp_DateLabel.TabIndex = 7
        Comp_DateLabel.Text = "Comp Date:"
        '
        'WeaponLabel
        '
        WeaponLabel.AutoSize = True
        WeaponLabel.Location = New System.Drawing.Point(70, 248)
        WeaponLabel.Name = "WeaponLabel"
        WeaponLabel.Size = New System.Drawing.Size(51, 13)
        WeaponLabel.TabIndex = 9
        WeaponLabel.Text = "Weapon:"
        '
        'Competitor_IdLabel1
        '
        Competitor_IdLabel1.AutoSize = True
        Competitor_IdLabel1.Location = New System.Drawing.Point(128, 71)
        Competitor_IdLabel1.Name = "Competitor_IdLabel1"
        Competitor_IdLabel1.Size = New System.Drawing.Size(72, 13)
        Competitor_IdLabel1.TabIndex = 1
        Competitor_IdLabel1.Text = "Competitor Id:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(164, 128)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(36, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "name:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(148, 174)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 5
        SurnameLabel.Text = "Surname:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(172, 220)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(28, 13)
        AgeLabel.TabIndex = 7
        AgeLabel.Text = "age:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(157, 261)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(43, 13)
        GenderLabel.TabIndex = 9
        GenderLabel.Text = "gender:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(173, 130)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(131, 179)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(63, 13)
        UserNameLabel.TabIndex = 3
        UserNameLabel.Text = "User Name:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(138, 234)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 5
        PasswordLabel.Text = "Password:"
        '
        'AccessLabel
        '
        AccessLabel.AutoSize = True
        AccessLabel.Location = New System.Drawing.Point(149, 292)
        AccessLabel.Name = "AccessLabel"
        AccessLabel.Size = New System.Drawing.Size(45, 13)
        AccessLabel.TabIndex = 7
        AccessLabel.Text = "Access:"
        '
        'Ref_IDLabel
        '
        Ref_IDLabel.AutoSize = True
        Ref_IDLabel.Location = New System.Drawing.Point(174, 173)
        Ref_IDLabel.Name = "Ref_IDLabel"
        Ref_IDLabel.Size = New System.Drawing.Size(41, 13)
        Ref_IDLabel.TabIndex = 1
        Ref_IDLabel.Text = "Ref ID:"
        '
        'Comp_IdLabel2
        '
        Comp_IdLabel2.AutoSize = True
        Comp_IdLabel2.Location = New System.Drawing.Point(174, 215)
        Comp_IdLabel2.Name = "Comp_IdLabel2"
        Comp_IdLabel2.Size = New System.Drawing.Size(49, 13)
        Comp_IdLabel2.TabIndex = 3
        Comp_IdLabel2.Text = "Comp Id:"
        '
        'Comp_NameLabel1
        '
        Comp_NameLabel1.AutoSize = True
        Comp_NameLabel1.Location = New System.Drawing.Point(174, 255)
        Comp_NameLabel1.Name = "Comp_NameLabel1"
        Comp_NameLabel1.Size = New System.Drawing.Size(68, 13)
        Comp_NameLabel1.TabIndex = 5
        Comp_NameLabel1.Text = "Comp Name:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Navigation, Me.LogInBtn, Me.logedAs, Me.LogoutBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1145, 32)
        Me.ToolStrip1.TabIndex = 78
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Navigation
        '
        Me.Navigation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Navigation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnToMainMenu, Me.PracticeMatch, Me.CreateCompetition, Me.ViewGraphsBtn, Me.ScoreSheetNavigate})
        Me.Navigation.Image = CType(resources.GetObject("Navigation.Image"), System.Drawing.Image)
        Me.Navigation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Navigation.Name = "Navigation"
        Me.Navigation.Size = New System.Drawing.Size(116, 29)
        Me.Navigation.Text = "Navigation"
        '
        'ReturnToMainMenu
        '
        Me.ReturnToMainMenu.Name = "ReturnToMainMenu"
        Me.ReturnToMainMenu.Size = New System.Drawing.Size(252, 30)
        Me.ReturnToMainMenu.Text = "Return to main Menu"
        '
        'PracticeMatch
        '
        Me.PracticeMatch.Name = "PracticeMatch"
        Me.PracticeMatch.Size = New System.Drawing.Size(252, 30)
        Me.PracticeMatch.Text = "Practice Match"
        '
        'CreateCompetition
        '
        Me.CreateCompetition.Name = "CreateCompetition"
        Me.CreateCompetition.Size = New System.Drawing.Size(252, 30)
        Me.CreateCompetition.Text = "Create Competition"
        '
        'ViewGraphsBtn
        '
        Me.ViewGraphsBtn.Name = "ViewGraphsBtn"
        Me.ViewGraphsBtn.Size = New System.Drawing.Size(252, 30)
        Me.ViewGraphsBtn.Text = "View Past scores"
        '
        'ScoreSheetNavigate
        '
        Me.ScoreSheetNavigate.Name = "ScoreSheetNavigate"
        Me.ScoreSheetNavigate.Size = New System.Drawing.Size(252, 30)
        Me.ScoreSheetNavigate.Text = "Score Sheet"
        '
        'LogInBtn
        '
        Me.LogInBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.LogInBtn.Image = CType(resources.GetObject("LogInBtn.Image"), System.Drawing.Image)
        Me.LogInBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LogInBtn.Name = "LogInBtn"
        Me.LogInBtn.Size = New System.Drawing.Size(66, 29)
        Me.LogInBtn.Text = "Log In"
        '
        'logedAs
        '
        Me.logedAs.Name = "logedAs"
        Me.logedAs.Size = New System.Drawing.Size(120, 29)
        Me.logedAs.Text = "Not signed In"
        '
        'LogoutBtn
        '
        Me.LogoutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.LogoutBtn.Image = CType(resources.GetObject("LogoutBtn.Image"), System.Drawing.Image)
        Me.LogoutBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(69, 29)
        Me.LogoutBtn.Text = "logout"
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "projectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProjectDataSetBindingSource
        '
        Me.ProjectDataSetBindingSource.DataSource = Me.ProjectDataSet
        Me.ProjectDataSetBindingSource.Position = 0
        '
        'ScoreDataBindingSource
        '
        Me.ScoreDataBindingSource.DataMember = "ScoreData"
        Me.ScoreDataBindingSource.DataSource = Me.ProjectDataSet
        '
        'ScoreDataTableAdapter
        '
        Me.ScoreDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.acountInfoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.competitorDataTableAdapter = Nothing
        Me.TableAdapterManager.compititionDataTableAdapter = Nothing
        Me.TableAdapterManager.RefCompititionsTableAdapter = Nothing
        Me.TableAdapterManager.ScoreDataTableAdapter = Me.ScoreDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = project_startup_vers_1.projectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ScoreDataDataGridView1
        '
        Me.ScoreDataDataGridView1.AutoGenerateColumns = False
        Me.ScoreDataDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScoreDataDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ScoreDataDataGridView1.DataSource = Me.ScoreDataBindingSource
        Me.ScoreDataDataGridView1.Location = New System.Drawing.Point(374, 0)
        Me.ScoreDataDataGridView1.Name = "ScoreDataDataGridView1"
        Me.ScoreDataDataGridView1.Size = New System.Drawing.Size(743, 534)
        Me.ScoreDataDataGridView1.TabIndex = 78
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ScoreID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ScoreID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "comp Id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "comp Id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Competitor Id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Competitor Id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "average points scored"
        Me.DataGridViewTextBoxColumn4.HeaderText = "average points scored"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "average points scored against"
        Me.DataGridViewTextBoxColumn5.HeaderText = "average points scored against"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "position"
        Me.DataGridViewTextBoxColumn6.HeaderText = "position"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "average win"
        Me.DataGridViewTextBoxColumn7.HeaderText = "average win"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ScoreDataTab)
        Me.TabControl1.Controls.Add(Me.compTab)
        Me.TabControl1.Controls.Add(Me.competitorTab)
        Me.TabControl1.Controls.Add(Me.AccountInfo)
        Me.TabControl1.Controls.Add(Me.compRefTab)
        Me.TabControl1.Location = New System.Drawing.Point(0, 38)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1145, 572)
        Me.TabControl1.TabIndex = 79
        '
        'ScoreDataTab
        '
        Me.ScoreDataTab.AutoScroll = True
        Me.ScoreDataTab.Controls.Add(Me.DeleteScoreBtn)
        Me.ScoreDataTab.Controls.Add(Me.updateBtnScoreData)
        Me.ScoreDataTab.Controls.Add(Me.UpBtnscoreData)
        Me.ScoreDataTab.Controls.Add(Me.DownBtnScoreData)
        Me.ScoreDataTab.Controls.Add(ScoreIDLabel)
        Me.ScoreDataTab.Controls.Add(Me.ScoreIDTextBox)
        Me.ScoreDataTab.Controls.Add(Comp_IdLabel)
        Me.ScoreDataTab.Controls.Add(Me.Comp_IdTextBox)
        Me.ScoreDataTab.Controls.Add(Competitor_IdLabel)
        Me.ScoreDataTab.Controls.Add(Me.Competitor_IdTextBox)
        Me.ScoreDataTab.Controls.Add(Average_points_scoredLabel)
        Me.ScoreDataTab.Controls.Add(Me.Average_points_scoredTextBox)
        Me.ScoreDataTab.Controls.Add(Average_points_scored_againstLabel)
        Me.ScoreDataTab.Controls.Add(Me.Average_points_scored_againstTextBox)
        Me.ScoreDataTab.Controls.Add(PositionLabel)
        Me.ScoreDataTab.Controls.Add(Me.PositionTextBox)
        Me.ScoreDataTab.Controls.Add(Average_winLabel)
        Me.ScoreDataTab.Controls.Add(Me.Average_winTextBox)
        Me.ScoreDataTab.Controls.Add(Me.ScoreDataDataGridView1)
        Me.ScoreDataTab.Location = New System.Drawing.Point(4, 22)
        Me.ScoreDataTab.Name = "ScoreDataTab"
        Me.ScoreDataTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ScoreDataTab.Size = New System.Drawing.Size(1137, 546)
        Me.ScoreDataTab.TabIndex = 0
        Me.ScoreDataTab.Text = "ScoreData"
        Me.ScoreDataTab.UseVisualStyleBackColor = True
        '
        'DeleteScoreBtn
        '
        Me.DeleteScoreBtn.Location = New System.Drawing.Point(187, 403)
        Me.DeleteScoreBtn.Name = "DeleteScoreBtn"
        Me.DeleteScoreBtn.Size = New System.Drawing.Size(75, 23)
        Me.DeleteScoreBtn.TabIndex = 103
        Me.DeleteScoreBtn.Text = "Delete"
        Me.DeleteScoreBtn.UseVisualStyleBackColor = True
        '
        'updateBtnScoreData
        '
        Me.updateBtnScoreData.Location = New System.Drawing.Point(187, 374)
        Me.updateBtnScoreData.Name = "updateBtnScoreData"
        Me.updateBtnScoreData.Size = New System.Drawing.Size(75, 23)
        Me.updateBtnScoreData.TabIndex = 102
        Me.updateBtnScoreData.Text = "Update record"
        Me.updateBtnScoreData.UseVisualStyleBackColor = True
        '
        'UpBtnscoreData
        '
        Me.UpBtnscoreData.Location = New System.Drawing.Point(187, 277)
        Me.UpBtnscoreData.Name = "UpBtnscoreData"
        Me.UpBtnscoreData.Size = New System.Drawing.Size(75, 23)
        Me.UpBtnscoreData.TabIndex = 101
        Me.UpBtnscoreData.Text = "Up"
        Me.UpBtnscoreData.UseVisualStyleBackColor = True
        '
        'DownBtnScoreData
        '
        Me.DownBtnScoreData.Location = New System.Drawing.Point(187, 306)
        Me.DownBtnScoreData.Name = "DownBtnScoreData"
        Me.DownBtnScoreData.Size = New System.Drawing.Size(75, 23)
        Me.DownBtnScoreData.TabIndex = 100
        Me.DownBtnScoreData.Text = "Down"
        Me.DownBtnScoreData.UseVisualStyleBackColor = True
        '
        'ScoreIDTextBox
        '
        Me.ScoreIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ScoreDataBindingSource, "ScoreID", True))
        Me.ScoreIDTextBox.Location = New System.Drawing.Point(187, 25)
        Me.ScoreIDTextBox.Name = "ScoreIDTextBox"
        Me.ScoreIDTextBox.ReadOnly = True
        Me.ScoreIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ScoreIDTextBox.TabIndex = 87
        '
        'Comp_IdTextBox
        '
        Me.Comp_IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ScoreDataBindingSource, "comp Id", True))
        Me.Comp_IdTextBox.Location = New System.Drawing.Point(187, 55)
        Me.Comp_IdTextBox.Name = "Comp_IdTextBox"
        Me.Comp_IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Comp_IdTextBox.TabIndex = 89
        '
        'Competitor_IdTextBox
        '
        Me.Competitor_IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ScoreDataBindingSource, "Competitor Id", True))
        Me.Competitor_IdTextBox.Location = New System.Drawing.Point(187, 91)
        Me.Competitor_IdTextBox.Name = "Competitor_IdTextBox"
        Me.Competitor_IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Competitor_IdTextBox.TabIndex = 91
        '
        'Average_points_scoredTextBox
        '
        Me.Average_points_scoredTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ScoreDataBindingSource, "average points scored", True))
        Me.Average_points_scoredTextBox.Location = New System.Drawing.Point(187, 124)
        Me.Average_points_scoredTextBox.Name = "Average_points_scoredTextBox"
        Me.Average_points_scoredTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Average_points_scoredTextBox.TabIndex = 93
        '
        'Average_points_scored_againstTextBox
        '
        Me.Average_points_scored_againstTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ScoreDataBindingSource, "average points scored against", True))
        Me.Average_points_scored_againstTextBox.Location = New System.Drawing.Point(187, 161)
        Me.Average_points_scored_againstTextBox.Name = "Average_points_scored_againstTextBox"
        Me.Average_points_scored_againstTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Average_points_scored_againstTextBox.TabIndex = 95
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ScoreDataBindingSource, "position", True))
        Me.PositionTextBox.Location = New System.Drawing.Point(187, 190)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PositionTextBox.TabIndex = 97
        '
        'Average_winTextBox
        '
        Me.Average_winTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ScoreDataBindingSource, "average win", True))
        Me.Average_winTextBox.Location = New System.Drawing.Point(187, 223)
        Me.Average_winTextBox.Name = "Average_winTextBox"
        Me.Average_winTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Average_winTextBox.TabIndex = 99
        '
        'compTab
        '
        Me.compTab.AutoScroll = True
        Me.compTab.Controls.Add(Me.CompDataDeleteBtn)
        Me.compTab.Controls.Add(Me.CompUpdate)
        Me.compTab.Controls.Add(Me.UPbtnCompData)
        Me.compTab.Controls.Add(Me.DownBtnCompData)
        Me.compTab.Controls.Add(WeaponLabel)
        Me.compTab.Controls.Add(Me.WeaponTextBox)
        Me.compTab.Controls.Add(Comp_DateLabel)
        Me.compTab.Controls.Add(Me.Comp_DateDateTimePicker)
        Me.compTab.Controls.Add(Comp_sizeLabel)
        Me.compTab.Controls.Add(Me.Comp_sizeTextBox)
        Me.compTab.Controls.Add(Comp_NameLabel)
        Me.compTab.Controls.Add(Me.Comp_NameTextBox)
        Me.compTab.Controls.Add(Comp_IdLabel1)
        Me.compTab.Controls.Add(Me.Comp_IdTextBoxComp)
        Me.compTab.Controls.Add(Me.CompititionDataDataGridView)
        Me.compTab.Location = New System.Drawing.Point(4, 22)
        Me.compTab.Name = "compTab"
        Me.compTab.Padding = New System.Windows.Forms.Padding(3)
        Me.compTab.Size = New System.Drawing.Size(1137, 546)
        Me.compTab.TabIndex = 1
        Me.compTab.Text = "Competition Data"
        Me.compTab.UseVisualStyleBackColor = True
        '
        'CompDataDeleteBtn
        '
        Me.CompDataDeleteBtn.Location = New System.Drawing.Point(127, 468)
        Me.CompDataDeleteBtn.Name = "CompDataDeleteBtn"
        Me.CompDataDeleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.CompDataDeleteBtn.TabIndex = 105
        Me.CompDataDeleteBtn.Text = "Delete"
        Me.CompDataDeleteBtn.UseVisualStyleBackColor = True
        '
        'CompUpdate
        '
        Me.CompUpdate.Location = New System.Drawing.Point(126, 439)
        Me.CompUpdate.Name = "CompUpdate"
        Me.CompUpdate.Size = New System.Drawing.Size(75, 23)
        Me.CompUpdate.TabIndex = 104
        Me.CompUpdate.Text = "Update record"
        Me.CompUpdate.UseVisualStyleBackColor = True
        '
        'UPbtnCompData
        '
        Me.UPbtnCompData.Location = New System.Drawing.Point(126, 347)
        Me.UPbtnCompData.Name = "UPbtnCompData"
        Me.UPbtnCompData.Size = New System.Drawing.Size(75, 23)
        Me.UPbtnCompData.TabIndex = 103
        Me.UPbtnCompData.Text = "Up"
        Me.UPbtnCompData.UseVisualStyleBackColor = True
        '
        'DownBtnCompData
        '
        Me.DownBtnCompData.Location = New System.Drawing.Point(126, 376)
        Me.DownBtnCompData.Name = "DownBtnCompData"
        Me.DownBtnCompData.Size = New System.Drawing.Size(75, 23)
        Me.DownBtnCompData.TabIndex = 102
        Me.DownBtnCompData.Text = "Down"
        Me.DownBtnCompData.UseVisualStyleBackColor = True
        '
        'WeaponTextBox
        '
        Me.WeaponTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompititionDataBindingSource, "Weapon", True))
        Me.WeaponTextBox.Location = New System.Drawing.Point(127, 245)
        Me.WeaponTextBox.Name = "WeaponTextBox"
        Me.WeaponTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WeaponTextBox.TabIndex = 10
        '
        'CompititionDataBindingSource
        '
        Me.CompititionDataBindingSource.DataMember = "compititionData"
        Me.CompititionDataBindingSource.DataSource = Me.ProjectDataSet
        '
        'Comp_DateDateTimePicker
        '
        Me.Comp_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CompititionDataBindingSource, "Comp Date", True))
        Me.Comp_DateDateTimePicker.Location = New System.Drawing.Point(126, 196)
        Me.Comp_DateDateTimePicker.Name = "Comp_DateDateTimePicker"
        Me.Comp_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Comp_DateDateTimePicker.TabIndex = 8
        '
        'Comp_sizeTextBox
        '
        Me.Comp_sizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompititionDataBindingSource, "Comp size", True))
        Me.Comp_sizeTextBox.Location = New System.Drawing.Point(131, 155)
        Me.Comp_sizeTextBox.Name = "Comp_sizeTextBox"
        Me.Comp_sizeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Comp_sizeTextBox.TabIndex = 6
        '
        'Comp_NameTextBox
        '
        Me.Comp_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompititionDataBindingSource, "Comp Name", True))
        Me.Comp_NameTextBox.Location = New System.Drawing.Point(131, 102)
        Me.Comp_NameTextBox.Name = "Comp_NameTextBox"
        Me.Comp_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Comp_NameTextBox.TabIndex = 4
        '
        'Comp_IdTextBoxComp
        '
        Me.Comp_IdTextBoxComp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompititionDataBindingSource, "Comp Id", True))
        Me.Comp_IdTextBoxComp.Location = New System.Drawing.Point(131, 52)
        Me.Comp_IdTextBoxComp.Name = "Comp_IdTextBoxComp"
        Me.Comp_IdTextBoxComp.ReadOnly = True
        Me.Comp_IdTextBoxComp.Size = New System.Drawing.Size(100, 20)
        Me.Comp_IdTextBoxComp.TabIndex = 2
        '
        'CompititionDataDataGridView
        '
        Me.CompititionDataDataGridView.AutoGenerateColumns = False
        Me.CompititionDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompititionDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.CompititionDataDataGridView.DataSource = Me.CompititionDataBindingSource
        Me.CompititionDataDataGridView.Location = New System.Drawing.Point(585, 6)
        Me.CompititionDataDataGridView.Name = "CompititionDataDataGridView"
        Me.CompititionDataDataGridView.Size = New System.Drawing.Size(546, 521)
        Me.CompititionDataDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Comp Id"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Comp Id"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Comp Name"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Comp Name"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Comp size"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Comp size"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Comp Date"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Comp Date"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Weapon"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Weapon"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'competitorTab
        '
        Me.competitorTab.Controls.Add(Me.DeleteCompetBtn)
        Me.competitorTab.Controls.Add(Me.CompetitorUpdateBtn)
        Me.competitorTab.Controls.Add(Me.competitorUpBtn)
        Me.competitorTab.Controls.Add(Me.CompetitorDownBtn)
        Me.competitorTab.Controls.Add(GenderLabel)
        Me.competitorTab.Controls.Add(Me.GenderTextBox)
        Me.competitorTab.Controls.Add(AgeLabel)
        Me.competitorTab.Controls.Add(Me.AgeTextBox)
        Me.competitorTab.Controls.Add(SurnameLabel)
        Me.competitorTab.Controls.Add(Me.SurnameTextBox)
        Me.competitorTab.Controls.Add(NameLabel)
        Me.competitorTab.Controls.Add(Me.NameTextBox)
        Me.competitorTab.Controls.Add(Competitor_IdLabel1)
        Me.competitorTab.Controls.Add(Me.Competitor_IdTextBox1)
        Me.competitorTab.Controls.Add(Me.CompetitorDataDataGridView)
        Me.competitorTab.Location = New System.Drawing.Point(4, 22)
        Me.competitorTab.Name = "competitorTab"
        Me.competitorTab.Size = New System.Drawing.Size(1137, 546)
        Me.competitorTab.TabIndex = 2
        Me.competitorTab.Text = "Competitor"
        Me.competitorTab.UseVisualStyleBackColor = True
        '
        'DeleteCompetBtn
        '
        Me.DeleteCompetBtn.Location = New System.Drawing.Point(220, 492)
        Me.DeleteCompetBtn.Name = "DeleteCompetBtn"
        Me.DeleteCompetBtn.Size = New System.Drawing.Size(75, 23)
        Me.DeleteCompetBtn.TabIndex = 108
        Me.DeleteCompetBtn.Text = "Delete"
        Me.DeleteCompetBtn.UseVisualStyleBackColor = True
        '
        'CompetitorUpdateBtn
        '
        Me.CompetitorUpdateBtn.Location = New System.Drawing.Point(220, 450)
        Me.CompetitorUpdateBtn.Name = "CompetitorUpdateBtn"
        Me.CompetitorUpdateBtn.Size = New System.Drawing.Size(75, 23)
        Me.CompetitorUpdateBtn.TabIndex = 107
        Me.CompetitorUpdateBtn.Text = "Update record"
        Me.CompetitorUpdateBtn.UseVisualStyleBackColor = True
        '
        'competitorUpBtn
        '
        Me.competitorUpBtn.Location = New System.Drawing.Point(220, 344)
        Me.competitorUpBtn.Name = "competitorUpBtn"
        Me.competitorUpBtn.Size = New System.Drawing.Size(75, 23)
        Me.competitorUpBtn.TabIndex = 106
        Me.competitorUpBtn.Text = "Up"
        Me.competitorUpBtn.UseVisualStyleBackColor = True
        '
        'CompetitorDownBtn
        '
        Me.CompetitorDownBtn.Location = New System.Drawing.Point(220, 373)
        Me.CompetitorDownBtn.Name = "CompetitorDownBtn"
        Me.CompetitorDownBtn.Size = New System.Drawing.Size(75, 23)
        Me.CompetitorDownBtn.TabIndex = 105
        Me.CompetitorDownBtn.Text = "Down"
        Me.CompetitorDownBtn.UseVisualStyleBackColor = True
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompetitorDataBindingSource, "gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(206, 258)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GenderTextBox.TabIndex = 10
        '
        'CompetitorDataBindingSource
        '
        Me.CompetitorDataBindingSource.DataMember = "competitorData"
        Me.CompetitorDataBindingSource.DataSource = Me.ProjectDataSet
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompetitorDataBindingSource, "age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(206, 217)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AgeTextBox.TabIndex = 8
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompetitorDataBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(206, 171)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SurnameTextBox.TabIndex = 6
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompetitorDataBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(206, 125)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'Competitor_IdTextBox1
        '
        Me.Competitor_IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompetitorDataBindingSource, "Competitor Id", True))
        Me.Competitor_IdTextBox1.Location = New System.Drawing.Point(206, 68)
        Me.Competitor_IdTextBox1.Name = "Competitor_IdTextBox1"
        Me.Competitor_IdTextBox1.ReadOnly = True
        Me.Competitor_IdTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Competitor_IdTextBox1.TabIndex = 2
        '
        'CompetitorDataDataGridView
        '
        Me.CompetitorDataDataGridView.AutoGenerateColumns = False
        Me.CompetitorDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompetitorDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.CompetitorDataDataGridView.DataSource = Me.CompetitorDataBindingSource
        Me.CompetitorDataDataGridView.Location = New System.Drawing.Point(573, 13)
        Me.CompetitorDataDataGridView.Name = "CompetitorDataDataGridView"
        Me.CompetitorDataDataGridView.Size = New System.Drawing.Size(542, 525)
        Me.CompetitorDataDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Competitor Id"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Competitor Id"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn14.HeaderText = "name"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "age"
        Me.DataGridViewTextBoxColumn16.HeaderText = "age"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "gender"
        Me.DataGridViewTextBoxColumn17.HeaderText = "gender"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'AccountInfo
        '
        Me.AccountInfo.AutoScroll = True
        Me.AccountInfo.Controls.Add(Me.AccountDeleteBtn)
        Me.AccountInfo.Controls.Add(Me.AccountsUpdate)
        Me.AccountInfo.Controls.Add(Me.AccountUp)
        Me.AccountInfo.Controls.Add(Me.Accountdown)
        Me.AccountInfo.Controls.Add(Me.cypherBtn)
        Me.AccountInfo.Controls.Add(AccessLabel)
        Me.AccountInfo.Controls.Add(Me.AccessTextBox)
        Me.AccountInfo.Controls.Add(PasswordLabel)
        Me.AccountInfo.Controls.Add(Me.PasswordTextBox)
        Me.AccountInfo.Controls.Add(UserNameLabel)
        Me.AccountInfo.Controls.Add(Me.UserNameTextBox)
        Me.AccountInfo.Controls.Add(IDLabel)
        Me.AccountInfo.Controls.Add(Me.IDTextBox)
        Me.AccountInfo.Controls.Add(Me.AcountInfoDataGridView)
        Me.AccountInfo.Location = New System.Drawing.Point(4, 22)
        Me.AccountInfo.Name = "AccountInfo"
        Me.AccountInfo.Size = New System.Drawing.Size(1137, 546)
        Me.AccountInfo.TabIndex = 3
        Me.AccountInfo.Text = "Account Info"
        Me.AccountInfo.UseVisualStyleBackColor = True
        '
        'AccountDeleteBtn
        '
        Me.AccountDeleteBtn.Location = New System.Drawing.Point(210, 499)
        Me.AccountDeleteBtn.Name = "AccountDeleteBtn"
        Me.AccountDeleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.AccountDeleteBtn.TabIndex = 110
        Me.AccountDeleteBtn.Text = "Delete"
        Me.AccountDeleteBtn.UseVisualStyleBackColor = True
        '
        'AccountsUpdate
        '
        Me.AccountsUpdate.Location = New System.Drawing.Point(210, 470)
        Me.AccountsUpdate.Name = "AccountsUpdate"
        Me.AccountsUpdate.Size = New System.Drawing.Size(75, 23)
        Me.AccountsUpdate.TabIndex = 109
        Me.AccountsUpdate.Text = "Update record"
        Me.AccountsUpdate.UseVisualStyleBackColor = True
        '
        'AccountUp
        '
        Me.AccountUp.Location = New System.Drawing.Point(210, 377)
        Me.AccountUp.Name = "AccountUp"
        Me.AccountUp.Size = New System.Drawing.Size(75, 23)
        Me.AccountUp.TabIndex = 108
        Me.AccountUp.Text = "Up"
        Me.AccountUp.UseVisualStyleBackColor = True
        '
        'Accountdown
        '
        Me.Accountdown.Location = New System.Drawing.Point(210, 406)
        Me.Accountdown.Name = "Accountdown"
        Me.Accountdown.Size = New System.Drawing.Size(75, 23)
        Me.Accountdown.TabIndex = 107
        Me.Accountdown.Text = "Down"
        Me.Accountdown.UseVisualStyleBackColor = True
        '
        'cypherBtn
        '
        Me.cypherBtn.Location = New System.Drawing.Point(338, 220)
        Me.cypherBtn.Name = "cypherBtn"
        Me.cypherBtn.Size = New System.Drawing.Size(75, 41)
        Me.cypherBtn.TabIndex = 9
        Me.cypherBtn.Text = "decrypt password"
        Me.cypherBtn.UseVisualStyleBackColor = True
        '
        'AccessTextBox
        '
        Me.AccessTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcountInfoBindingSource, "Access", True))
        Me.AccessTextBox.Location = New System.Drawing.Point(200, 289)
        Me.AccessTextBox.Name = "AccessTextBox"
        Me.AccessTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AccessTextBox.TabIndex = 8
        '
        'AcountInfoBindingSource
        '
        Me.AcountInfoBindingSource.DataMember = "acountInfo"
        Me.AcountInfoBindingSource.DataSource = Me.ProjectDataSet
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcountInfoBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(200, 231)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 6
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcountInfoBindingSource, "UserName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(200, 176)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserNameTextBox.TabIndex = 4
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcountInfoBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(200, 127)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'AcountInfoDataGridView
        '
        Me.AcountInfoDataGridView.AutoGenerateColumns = False
        Me.AcountInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AcountInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.AcountInfoDataGridView.DataSource = Me.AcountInfoBindingSource
        Me.AcountInfoDataGridView.Location = New System.Drawing.Point(690, 3)
        Me.AcountInfoDataGridView.Name = "AcountInfoDataGridView"
        Me.AcountInfoDataGridView.Size = New System.Drawing.Size(444, 540)
        Me.AcountInfoDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn18.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn19.HeaderText = "UserName"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Access"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Access"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'compRefTab
        '
        Me.compRefTab.AutoScroll = True
        Me.compRefTab.Controls.Add(Me.RefDelete)
        Me.compRefTab.Controls.Add(Me.RefUpdate)
        Me.compRefTab.Controls.Add(Me.RefUpBtn)
        Me.compRefTab.Controls.Add(Me.RefDownBtn)
        Me.compRefTab.Controls.Add(Ref_IDLabel)
        Me.compRefTab.Controls.Add(Me.Ref_IDTextBox)
        Me.compRefTab.Controls.Add(Comp_IdLabel2)
        Me.compRefTab.Controls.Add(Me.Comp_IdTextBox1)
        Me.compRefTab.Controls.Add(Comp_NameLabel1)
        Me.compRefTab.Controls.Add(Me.Comp_NameTextBox1)
        Me.compRefTab.Controls.Add(Me.RefCompititionsDataGridView)
        Me.compRefTab.Location = New System.Drawing.Point(4, 22)
        Me.compRefTab.Name = "compRefTab"
        Me.compRefTab.Size = New System.Drawing.Size(1137, 546)
        Me.compRefTab.TabIndex = 4
        Me.compRefTab.Text = "Pre Made competitions"
        Me.compRefTab.UseVisualStyleBackColor = True
        '
        'RefDelete
        '
        Me.RefDelete.Location = New System.Drawing.Point(262, 491)
        Me.RefDelete.Name = "RefDelete"
        Me.RefDelete.Size = New System.Drawing.Size(75, 23)
        Me.RefDelete.TabIndex = 112
        Me.RefDelete.Text = "Delete"
        Me.RefDelete.UseVisualStyleBackColor = True
        '
        'RefUpdate
        '
        Me.RefUpdate.Location = New System.Drawing.Point(262, 462)
        Me.RefUpdate.Name = "RefUpdate"
        Me.RefUpdate.Size = New System.Drawing.Size(75, 23)
        Me.RefUpdate.TabIndex = 111
        Me.RefUpdate.Text = "Update record"
        Me.RefUpdate.UseVisualStyleBackColor = True
        '
        'RefUpBtn
        '
        Me.RefUpBtn.Location = New System.Drawing.Point(262, 341)
        Me.RefUpBtn.Name = "RefUpBtn"
        Me.RefUpBtn.Size = New System.Drawing.Size(75, 23)
        Me.RefUpBtn.TabIndex = 110
        Me.RefUpBtn.Text = "Up"
        Me.RefUpBtn.UseVisualStyleBackColor = True
        '
        'RefDownBtn
        '
        Me.RefDownBtn.Location = New System.Drawing.Point(262, 370)
        Me.RefDownBtn.Name = "RefDownBtn"
        Me.RefDownBtn.Size = New System.Drawing.Size(75, 23)
        Me.RefDownBtn.TabIndex = 109
        Me.RefDownBtn.Text = "Down"
        Me.RefDownBtn.UseVisualStyleBackColor = True
        '
        'Ref_IDTextBox
        '
        Me.Ref_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RefCompititionsBindingSource, "Ref ID", True))
        Me.Ref_IDTextBox.Location = New System.Drawing.Point(248, 170)
        Me.Ref_IDTextBox.Name = "Ref_IDTextBox"
        Me.Ref_IDTextBox.ReadOnly = True
        Me.Ref_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Ref_IDTextBox.TabIndex = 2
        '
        'RefCompititionsBindingSource
        '
        Me.RefCompititionsBindingSource.DataMember = "RefCompititions"
        Me.RefCompititionsBindingSource.DataSource = Me.ProjectDataSet
        '
        'Comp_IdTextBox1
        '
        Me.Comp_IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RefCompititionsBindingSource, "Comp Id", True))
        Me.Comp_IdTextBox1.Location = New System.Drawing.Point(248, 211)
        Me.Comp_IdTextBox1.Name = "Comp_IdTextBox1"
        Me.Comp_IdTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Comp_IdTextBox1.TabIndex = 4
        '
        'Comp_NameTextBox1
        '
        Me.Comp_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RefCompititionsBindingSource, "Comp Name", True))
        Me.Comp_NameTextBox1.Location = New System.Drawing.Point(248, 252)
        Me.Comp_NameTextBox1.Name = "Comp_NameTextBox1"
        Me.Comp_NameTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Comp_NameTextBox1.TabIndex = 6
        '
        'RefCompititionsDataGridView
        '
        Me.RefCompititionsDataGridView.AutoGenerateColumns = False
        Me.RefCompititionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RefCompititionsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.RefCompititionsDataGridView.DataSource = Me.RefCompititionsBindingSource
        Me.RefCompititionsDataGridView.Location = New System.Drawing.Point(784, 12)
        Me.RefCompititionsDataGridView.Name = "RefCompititionsDataGridView"
        Me.RefCompititionsDataGridView.Size = New System.Drawing.Size(345, 526)
        Me.RefCompititionsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Ref ID"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Ref ID"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Comp Id"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Comp Id"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Comp Name"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Comp Name"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'CompititionDataTableAdapter
        '
        Me.CompititionDataTableAdapter.ClearBeforeFill = True
        '
        'CompetitorDataTableAdapter
        '
        Me.CompetitorDataTableAdapter.ClearBeforeFill = True
        '
        'AcountInfoTableAdapter
        '
        Me.AcountInfoTableAdapter.ClearBeforeFill = True
        '
        'RefCompititionsTableAdapter
        '
        Me.RefCompititionsTableAdapter.ClearBeforeFill = True
        '
        'TabLabel
        '
        Me.TabLabel.AutoSize = True
        Me.TabLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabLabel.Location = New System.Drawing.Point(590, 25)
        Me.TabLabel.Name = "TabLabel"
        Me.TabLabel.Size = New System.Drawing.Size(125, 40)
        Me.TabLabel.TabIndex = 80
        Me.TabLabel.Text = "Label1"
        '
        'database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 610)
        Me.Controls.Add(Me.TabLabel)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "database"
        Me.Text = "Database Edditor"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScoreDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScoreDataDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ScoreDataTab.ResumeLayout(False)
        Me.ScoreDataTab.PerformLayout()
        Me.compTab.ResumeLayout(False)
        Me.compTab.PerformLayout()
        CType(Me.CompititionDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompititionDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.competitorTab.ResumeLayout(False)
        Me.competitorTab.PerformLayout()
        CType(Me.CompetitorDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompetitorDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccountInfo.ResumeLayout(False)
        Me.AccountInfo.PerformLayout()
        CType(Me.AcountInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcountInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.compRefTab.ResumeLayout(False)
        Me.compRefTab.PerformLayout()
        CType(Me.RefCompititionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefCompititionsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Navigation As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ReturnToMainMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PracticeMatch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateCompetition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewGraphsBtn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScoreSheetNavigate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogInBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents logedAs As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LogoutBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProjectDataSet As project_startup_vers_1.projectDataSet
    Friend WithEvents ProjectDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ScoreDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ScoreDataTableAdapter As project_startup_vers_1.projectDataSetTableAdapters.ScoreDataTableAdapter
    Friend WithEvents TableAdapterManager As project_startup_vers_1.projectDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ScoreDataDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ScoreDataTab As System.Windows.Forms.TabPage
    Friend WithEvents ScoreIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Comp_IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Competitor_IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Average_points_scoredTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Average_points_scored_againstTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PositionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Average_winTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpBtnscoreData As System.Windows.Forms.Button
    Friend WithEvents DownBtnScoreData As System.Windows.Forms.Button
    Friend WithEvents updateBtnScoreData As System.Windows.Forms.Button
    Friend WithEvents CompititionDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompititionDataTableAdapter As project_startup_vers_1.projectDataSetTableAdapters.compititionDataTableAdapter
    Friend WithEvents compTab As System.Windows.Forms.TabPage
    Friend WithEvents CompUpdate As System.Windows.Forms.Button
    Friend WithEvents UPbtnCompData As System.Windows.Forms.Button
    Friend WithEvents DownBtnCompData As System.Windows.Forms.Button
    Friend WithEvents WeaponTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Comp_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Comp_sizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Comp_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Comp_IdTextBoxComp As System.Windows.Forms.TextBox
    Friend WithEvents CompititionDataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents competitorTab As System.Windows.Forms.TabPage
    Friend WithEvents CompetitorDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompetitorDataTableAdapter As project_startup_vers_1.projectDataSetTableAdapters.competitorDataTableAdapter
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Competitor_IdTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CompetitorDataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompetitorUpdateBtn As System.Windows.Forms.Button
    Friend WithEvents competitorUpBtn As System.Windows.Forms.Button
    Friend WithEvents CompetitorDownBtn As System.Windows.Forms.Button
    Friend WithEvents AccountInfo As System.Windows.Forms.TabPage
    Friend WithEvents AcountInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AcountInfoTableAdapter As project_startup_vers_1.projectDataSetTableAdapters.acountInfoTableAdapter
    Friend WithEvents AcountInfoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cypherBtn As System.Windows.Forms.Button
    Friend WithEvents AccountsUpdate As System.Windows.Forms.Button
    Friend WithEvents compRefTab As System.Windows.Forms.TabPage
    Friend WithEvents RefCompititionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RefCompititionsTableAdapter As project_startup_vers_1.projectDataSetTableAdapters.RefCompititionsTableAdapter
    Friend WithEvents AccountUp As System.Windows.Forms.Button
    Friend WithEvents Accountdown As System.Windows.Forms.Button
    Friend WithEvents RefUpBtn As System.Windows.Forms.Button
    Friend WithEvents RefDownBtn As System.Windows.Forms.Button
    Friend WithEvents Ref_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Comp_IdTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Comp_NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RefCompititionsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefUpdate As System.Windows.Forms.Button
    Friend WithEvents DeleteScoreBtn As System.Windows.Forms.Button
    Friend WithEvents CompDataDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteCompetBtn As System.Windows.Forms.Button
    Friend WithEvents AccountDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents RefDelete As System.Windows.Forms.Button
    Friend WithEvents TabLabel As System.Windows.Forms.Label
End Class
