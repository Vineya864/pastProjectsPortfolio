<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class records
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(records))
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.FencingCompDataDataSet = New project_startup_vers_1.FencingCompDataDataSet()
        Me.Competitor_dataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Competitor_dataTableAdapter = New project_startup_vers_1.FencingCompDataDataSetTableAdapters.competitor_dataTableAdapter()
        Me.TableAdapterManager = New project_startup_vers_1.FencingCompDataDataSetTableAdapters.TableAdapterManager()
        Me.Score_dataTableAdapter = New project_startup_vers_1.FencingCompDataDataSetTableAdapters.Score_dataTableAdapter()
        Me.RecIDBox = New System.Windows.Forms.TextBox()
        Me.Score_dataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecFirstNameBox = New System.Windows.Forms.TextBox()
        Me.RecSecondNameBox = New System.Windows.Forms.TextBox()
        Me.RecAgeBox = New System.Windows.Forms.TextBox()
        Me.RecGenderBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Compare = New System.Windows.Forms.Button()
        Me.RecWeapon = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RecPositionBox = New System.Windows.Forms.TextBox()
        Me.HitScoredRec = New System.Windows.Forms.TabPage()
        Me.CompareBar = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.HitsRSChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Avwin = New System.Windows.Forms.TabPage()
        Me.comparePercentLabel = New System.Windows.Forms.Label()
        Me.percentLabel = New System.Windows.Forms.Label()
        Me.RecPercentageBox = New System.Windows.Forms.TextBox()
        Me.AvHitChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.RecPercentageCompareBox = New System.Windows.Forms.TextBox()
        Me.AwinCompare = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Navigation = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ReturnToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PracticeMatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateCompetitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScoreSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogInBtn = New System.Windows.Forms.ToolStripButton()
        Me.logedAs = New System.Windows.Forms.ToolStripLabel()
        Me.LogoutBtn = New System.Windows.Forms.ToolStripButton()
        Me.FencingCompDataDataSet1 = New project_startup_vers_1.FencingCompDataDataSet()
        Me.compareWinnerBtn = New System.Windows.Forms.Button()
        Me.SearchForBtn = New System.Windows.Forms.Button()
        Me.Searchtext = New System.Windows.Forms.TextBox()
        Me.searchPosText = New System.Windows.Forms.TextBox()
        Me.SelfCompareBtn = New System.Windows.Forms.Button()
        CType(Me.FencingCompDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Competitor_dataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Score_dataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HitScoredRec.SuspendLayout()
        CType(Me.CompareBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HitsRSChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Avwin.SuspendLayout()
        CType(Me.AvHitChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AwinCompare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.FencingCompDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NextBtn
        '
        Me.NextBtn.Location = New System.Drawing.Point(100, 352)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(89, 50)
        Me.NextBtn.TabIndex = 1
        Me.NextBtn.Text = "Next Competitor"
        Me.NextBtn.UseVisualStyleBackColor = True
        '
        'FencingCompDataDataSet
        '
        Me.FencingCompDataDataSet.DataSetName = "FencingCompDataDataSet"
        Me.FencingCompDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Competitor_dataBindingSource
        '
        Me.Competitor_dataBindingSource.DataMember = "competitor data"
        Me.Competitor_dataBindingSource.DataSource = Me.FencingCompDataDataSet
        '
        'Competitor_dataTableAdapter
        '
        Me.Competitor_dataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.comp_dataTableAdapter = Nothing
        Me.TableAdapterManager.competitor_dataTableAdapter = Me.Competitor_dataTableAdapter
        Me.TableAdapterManager.Score_dataTableAdapter = Me.Score_dataTableAdapter
        Me.TableAdapterManager.UpdateOrder = project_startup_vers_1.FencingCompDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Score_dataTableAdapter
        '
        Me.Score_dataTableAdapter.ClearBeforeFill = True
        '
        'RecIDBox
        '
        Me.RecIDBox.Location = New System.Drawing.Point(100, 80)
        Me.RecIDBox.Name = "RecIDBox"
        Me.RecIDBox.ReadOnly = True
        Me.RecIDBox.Size = New System.Drawing.Size(100, 20)
        Me.RecIDBox.TabIndex = 3
        '
        'Score_dataBindingSource
        '
        Me.Score_dataBindingSource.DataMember = "Score data"
        Me.Score_dataBindingSource.DataSource = Me.FencingCompDataDataSet
        '
        'RecFirstNameBox
        '
        Me.RecFirstNameBox.Location = New System.Drawing.Point(100, 121)
        Me.RecFirstNameBox.Name = "RecFirstNameBox"
        Me.RecFirstNameBox.ReadOnly = True
        Me.RecFirstNameBox.Size = New System.Drawing.Size(100, 20)
        Me.RecFirstNameBox.TabIndex = 63
        '
        'RecSecondNameBox
        '
        Me.RecSecondNameBox.Location = New System.Drawing.Point(100, 162)
        Me.RecSecondNameBox.Name = "RecSecondNameBox"
        Me.RecSecondNameBox.ReadOnly = True
        Me.RecSecondNameBox.Size = New System.Drawing.Size(100, 20)
        Me.RecSecondNameBox.TabIndex = 64
        '
        'RecAgeBox
        '
        Me.RecAgeBox.Location = New System.Drawing.Point(100, 203)
        Me.RecAgeBox.Name = "RecAgeBox"
        Me.RecAgeBox.ReadOnly = True
        Me.RecAgeBox.Size = New System.Drawing.Size(100, 20)
        Me.RecAgeBox.TabIndex = 65
        '
        'RecGenderBox
        '
        Me.RecGenderBox.Location = New System.Drawing.Point(100, 244)
        Me.RecGenderBox.Name = "RecGenderBox"
        Me.RecGenderBox.ReadOnly = True
        Me.RecGenderBox.Size = New System.Drawing.Size(100, 20)
        Me.RecGenderBox.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(124, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Surname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(135, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Age"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(128, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Gender"
        '
        'Compare
        '
        Me.Compare.Location = New System.Drawing.Point(393, 374)
        Me.Compare.Name = "Compare"
        Me.Compare.Size = New System.Drawing.Size(114, 57)
        Me.Compare.TabIndex = 72
        Me.Compare.Text = "Compare to competition Other Positions"
        Me.Compare.UseVisualStyleBackColor = True
        '
        'RecWeapon
        '
        Me.RecWeapon.Location = New System.Drawing.Point(100, 285)
        Me.RecWeapon.Name = "RecWeapon"
        Me.RecWeapon.ReadOnly = True
        Me.RecWeapon.Size = New System.Drawing.Size(100, 20)
        Me.RecWeapon.TabIndex = 73
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(127, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Weapon"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(129, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "postion"
        '
        'RecPositionBox
        '
        Me.RecPositionBox.Location = New System.Drawing.Point(127, 326)
        Me.RecPositionBox.Name = "RecPositionBox"
        Me.RecPositionBox.ReadOnly = True
        Me.RecPositionBox.Size = New System.Drawing.Size(43, 20)
        Me.RecPositionBox.TabIndex = 76
        '
        'HitScoredRec
        '
        Me.HitScoredRec.Controls.Add(Me.CompareBar)
        Me.HitScoredRec.Controls.Add(Me.HitsRSChart)
        Me.HitScoredRec.Location = New System.Drawing.Point(4, 22)
        Me.HitScoredRec.Name = "HitScoredRec"
        Me.HitScoredRec.Padding = New System.Windows.Forms.Padding(3)
        Me.HitScoredRec.Size = New System.Drawing.Size(319, 314)
        Me.HitScoredRec.TabIndex = 1
        Me.HitScoredRec.Text = "Hits Receved To hits Scored"
        Me.HitScoredRec.UseVisualStyleBackColor = True
        '
        'CompareBar
        '
        ChartArea1.Name = "ChartArea1"
        Me.CompareBar.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.CompareBar.Legends.Add(Legend1)
        Me.CompareBar.Location = New System.Drawing.Point(6, 13)
        Me.CompareBar.Name = "CompareBar"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Searched score"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Compare score"
        Me.CompareBar.Series.Add(Series1)
        Me.CompareBar.Series.Add(Series2)
        Me.CompareBar.Size = New System.Drawing.Size(291, 270)
        Me.CompareBar.TabIndex = 77
        Me.CompareBar.Text = "Chart1"
        '
        'HitsRSChart
        '
        ChartArea2.Name = "ChartArea1"
        Me.HitsRSChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.HitsRSChart.Legends.Add(Legend2)
        Me.HitsRSChart.Location = New System.Drawing.Point(6, 13)
        Me.HitsRSChart.Name = "HitsRSChart"
        Me.HitsRSChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Hits"
        Me.HitsRSChart.Series.Add(Series3)
        Me.HitsRSChart.Size = New System.Drawing.Size(249, 270)
        Me.HitsRSChart.TabIndex = 0
        Me.HitsRSChart.Text = "Chart1"
        Me.HitsRSChart.UseWaitCursor = True
        '
        'Avwin
        '
        Me.Avwin.Controls.Add(Me.comparePercentLabel)
        Me.Avwin.Controls.Add(Me.percentLabel)
        Me.Avwin.Controls.Add(Me.RecPercentageBox)
        Me.Avwin.Controls.Add(Me.AvHitChart)
        Me.Avwin.Controls.Add(Me.RecPercentageCompareBox)
        Me.Avwin.Controls.Add(Me.AwinCompare)
        Me.Avwin.Location = New System.Drawing.Point(4, 22)
        Me.Avwin.Name = "Avwin"
        Me.Avwin.Padding = New System.Windows.Forms.Padding(3)
        Me.Avwin.Size = New System.Drawing.Size(319, 314)
        Me.Avwin.TabIndex = 0
        Me.Avwin.Text = "Average Win Rate"
        Me.Avwin.UseVisualStyleBackColor = True
        '
        'comparePercentLabel
        '
        Me.comparePercentLabel.AutoSize = True
        Me.comparePercentLabel.Location = New System.Drawing.Point(216, 223)
        Me.comparePercentLabel.Name = "comparePercentLabel"
        Me.comparePercentLabel.Size = New System.Drawing.Size(101, 13)
        Me.comparePercentLabel.TabIndex = 79
        Me.comparePercentLabel.Text = "Percentage of Wins"
        '
        'percentLabel
        '
        Me.percentLabel.AutoSize = True
        Me.percentLabel.Location = New System.Drawing.Point(210, 243)
        Me.percentLabel.Name = "percentLabel"
        Me.percentLabel.Size = New System.Drawing.Size(101, 13)
        Me.percentLabel.TabIndex = 2
        Me.percentLabel.Text = "Percentage of Wins"
        '
        'RecPercentageBox
        '
        Me.RecPercentageBox.Location = New System.Drawing.Point(239, 259)
        Me.RecPercentageBox.Name = "RecPercentageBox"
        Me.RecPercentageBox.ReadOnly = True
        Me.RecPercentageBox.Size = New System.Drawing.Size(34, 20)
        Me.RecPercentageBox.TabIndex = 1
        '
        'AvHitChart
        '
        ChartArea3.Name = "ChartArea1"
        Me.AvHitChart.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.AvHitChart.Legends.Add(Legend3)
        Me.AvHitChart.Location = New System.Drawing.Point(6, 27)
        Me.AvHitChart.Name = "AvHitChart"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series4.Legend = "Legend1"
        Series4.Name = "hits"
        Me.AvHitChart.Series.Add(Series4)
        Me.AvHitChart.Size = New System.Drawing.Size(299, 269)
        Me.AvHitChart.TabIndex = 0
        Me.AvHitChart.Text = "Chart1"
        '
        'RecPercentageCompareBox
        '
        Me.RecPercentageCompareBox.Location = New System.Drawing.Point(235, 256)
        Me.RecPercentageCompareBox.Name = "RecPercentageCompareBox"
        Me.RecPercentageCompareBox.ReadOnly = True
        Me.RecPercentageCompareBox.Size = New System.Drawing.Size(45, 20)
        Me.RecPercentageCompareBox.TabIndex = 78
        '
        'AwinCompare
        '
        ChartArea4.Name = "ChartArea1"
        Me.AwinCompare.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.AwinCompare.Legends.Add(Legend4)
        Me.AwinCompare.Location = New System.Drawing.Point(5, 34)
        Me.AwinCompare.Name = "AwinCompare"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series5.Legend = "Legend1"
        Series5.Name = "hits"
        Me.AwinCompare.Series.Add(Series5)
        Me.AwinCompare.Size = New System.Drawing.Size(300, 277)
        Me.AwinCompare.TabIndex = 77
        Me.AwinCompare.Text = "Chart1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Avwin)
        Me.TabControl1.Controls.Add(Me.HitScoredRec)
        Me.TabControl1.Location = New System.Drawing.Point(273, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(327, 340)
        Me.TabControl1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Navigation, Me.LogInBtn, Me.logedAs, Me.LogoutBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(629, 25)
        Me.ToolStrip1.TabIndex = 77
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Navigation
        '
        Me.Navigation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Navigation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnToMainMenuToolStripMenuItem, Me.PracticeMatchToolStripMenuItem, Me.CreateCompetitionToolStripMenuItem, Me.ViewDatabaseToolStripMenuItem, Me.ScoreSheetToolStripMenuItem})
        Me.Navigation.Image = CType(resources.GetObject("Navigation.Image"), System.Drawing.Image)
        Me.Navigation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Navigation.Name = "Navigation"
        Me.Navigation.Size = New System.Drawing.Size(78, 22)
        Me.Navigation.Text = "Navigation"
        '
        'ReturnToMainMenuToolStripMenuItem
        '
        Me.ReturnToMainMenuToolStripMenuItem.Name = "ReturnToMainMenuToolStripMenuItem"
        Me.ReturnToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ReturnToMainMenuToolStripMenuItem.Text = "Return to main Menu"
        '
        'PracticeMatchToolStripMenuItem
        '
        Me.PracticeMatchToolStripMenuItem.Name = "PracticeMatchToolStripMenuItem"
        Me.PracticeMatchToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.PracticeMatchToolStripMenuItem.Text = "Practice Match"
        '
        'CreateCompetitionToolStripMenuItem
        '
        Me.CreateCompetitionToolStripMenuItem.Name = "CreateCompetitionToolStripMenuItem"
        Me.CreateCompetitionToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CreateCompetitionToolStripMenuItem.Text = "Create Competition"
        '
        'ViewDatabaseToolStripMenuItem
        '
        Me.ViewDatabaseToolStripMenuItem.Name = "ViewDatabaseToolStripMenuItem"
        Me.ViewDatabaseToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ViewDatabaseToolStripMenuItem.Text = "View Database"
        '
        'ScoreSheetToolStripMenuItem
        '
        Me.ScoreSheetToolStripMenuItem.Name = "ScoreSheetToolStripMenuItem"
        Me.ScoreSheetToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ScoreSheetToolStripMenuItem.Text = "Score Sheet"
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
        'LogoutBtn
        '
        Me.LogoutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.LogoutBtn.Image = CType(resources.GetObject("LogoutBtn.Image"), System.Drawing.Image)
        Me.LogoutBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(46, 22)
        Me.LogoutBtn.Text = "logout"
        '
        'FencingCompDataDataSet1
        '
        Me.FencingCompDataDataSet1.DataSetName = "FencingCompDataDataSet"
        Me.FencingCompDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'compareWinnerBtn
        '
        Me.compareWinnerBtn.Location = New System.Drawing.Point(279, 374)
        Me.compareWinnerBtn.Name = "compareWinnerBtn"
        Me.compareWinnerBtn.Size = New System.Drawing.Size(114, 57)
        Me.compareWinnerBtn.TabIndex = 78
        Me.compareWinnerBtn.Text = "compare to winner"
        Me.compareWinnerBtn.UseVisualStyleBackColor = True
        '
        'SearchForBtn
        '
        Me.SearchForBtn.Location = New System.Drawing.Point(106, 408)
        Me.SearchForBtn.Name = "SearchForBtn"
        Me.SearchForBtn.Size = New System.Drawing.Size(75, 23)
        Me.SearchForBtn.TabIndex = 80
        Me.SearchForBtn.Text = "Search"
        Me.SearchForBtn.UseVisualStyleBackColor = True
        '
        'Searchtext
        '
        Me.Searchtext.Location = New System.Drawing.Point(127, 437)
        Me.Searchtext.Name = "Searchtext"
        Me.Searchtext.Size = New System.Drawing.Size(34, 20)
        Me.Searchtext.TabIndex = 81
        Me.Searchtext.Text = "ID"
        '
        'searchPosText
        '
        Me.searchPosText.Location = New System.Drawing.Point(425, 437)
        Me.searchPosText.Name = "searchPosText"
        Me.searchPosText.Size = New System.Drawing.Size(44, 20)
        Me.searchPosText.TabIndex = 82
        Me.searchPosText.Text = "Position"
        '
        'SelfCompareBtn
        '
        Me.SelfCompareBtn.Location = New System.Drawing.Point(507, 374)
        Me.SelfCompareBtn.Name = "SelfCompareBtn"
        Me.SelfCompareBtn.Size = New System.Drawing.Size(114, 57)
        Me.SelfCompareBtn.TabIndex = 83
        Me.SelfCompareBtn.Text = "Compare to Other competitions"
        Me.SelfCompareBtn.UseVisualStyleBackColor = True
        '
        'records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 462)
        Me.Controls.Add(Me.SelfCompareBtn)
        Me.Controls.Add(Me.searchPosText)
        Me.Controls.Add(Me.Searchtext)
        Me.Controls.Add(Me.SearchForBtn)
        Me.Controls.Add(Me.compareWinnerBtn)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.RecPositionBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Compare)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RecWeapon)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RecGenderBox)
        Me.Controls.Add(Me.RecAgeBox)
        Me.Controls.Add(Me.RecSecondNameBox)
        Me.Controls.Add(Me.RecFirstNameBox)
        Me.Controls.Add(Me.RecIDBox)
        Me.Controls.Add(Me.NextBtn)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "records"
        Me.Text = "Statistics"
        CType(Me.FencingCompDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Competitor_dataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Score_dataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HitScoredRec.ResumeLayout(False)
        CType(Me.CompareBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HitsRSChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Avwin.ResumeLayout(False)
        Me.Avwin.PerformLayout()
        CType(Me.AvHitChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AwinCompare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.FencingCompDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NextBtn As System.Windows.Forms.Button
    Friend WithEvents FencingCompDataDataSet As project_startup_vers_1.FencingCompDataDataSet
    Friend WithEvents Competitor_dataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Competitor_dataTableAdapter As project_startup_vers_1.FencingCompDataDataSetTableAdapters.competitor_dataTableAdapter
    Friend WithEvents TableAdapterManager As project_startup_vers_1.FencingCompDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RecIDBox As System.Windows.Forms.TextBox
    Friend WithEvents Score_dataTableAdapter As project_startup_vers_1.FencingCompDataDataSetTableAdapters.Score_dataTableAdapter
    Friend WithEvents Score_dataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecFirstNameBox As System.Windows.Forms.TextBox
    Friend WithEvents RecSecondNameBox As System.Windows.Forms.TextBox
    Friend WithEvents RecAgeBox As System.Windows.Forms.TextBox
    Friend WithEvents RecGenderBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Compare As System.Windows.Forms.Button
    Friend WithEvents RecWeapon As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RecPositionBox As System.Windows.Forms.TextBox
    Friend WithEvents HitScoredRec As System.Windows.Forms.TabPage
    Friend WithEvents HitsRSChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Avwin As System.Windows.Forms.TabPage
    Friend WithEvents percentLabel As System.Windows.Forms.Label
    Friend WithEvents RecPercentageBox As System.Windows.Forms.TextBox
    Friend WithEvents AvHitChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents CompareBar As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents AwinCompare As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents comparePercentLabel As System.Windows.Forms.Label
    Friend WithEvents RecPercentageCompareBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Navigation As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ReturnToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PracticeMatchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateCompetitionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FencingCompDataDataSet1 As project_startup_vers_1.FencingCompDataDataSet
    Friend WithEvents compareWinnerBtn As System.Windows.Forms.Button
    Friend WithEvents LogInBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents SearchForBtn As System.Windows.Forms.Button
    Friend WithEvents logedAs As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ScoreSheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Searchtext As System.Windows.Forms.TextBox
    Friend WithEvents searchPosText As System.Windows.Forms.TextBox
    Friend WithEvents SelfCompareBtn As System.Windows.Forms.Button
End Class
