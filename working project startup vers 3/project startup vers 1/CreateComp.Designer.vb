<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class compStart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(compStart))
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.DateBox = New System.Windows.Forms.TextBox()
        Me.weapBox = New System.Windows.Forms.TextBox()
        Me.numBox = New System.Windows.Forms.TextBox()
        Me.FencingCompDataDataSet1 = New project_startup_vers_1.FencingCompDataDataSet1()
        Me.CompDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompDataTableAdapter = New project_startup_vers_1.FencingCompDataDataSet1TableAdapters.compDataTableAdapter()
        Me.TableAdapterManager = New project_startup_vers_1.FencingCompDataDataSet1TableAdapters.TableAdapterManager()
        Me.Startbtn = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Datelabel = New System.Windows.Forms.Label()
        Me.Weaplabel = New System.Windows.Forms.Label()
        Me.sizeLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Navigation = New System.Windows.Forms.ToolStripDropDownButton()
        Me.MainMenubtn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRecords = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStatistics = New System.Windows.Forms.ToolStripMenuItem()
        Me.PracticeMatch = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompOptions = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Change = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeSize = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeName = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeWeapon = New System.Windows.Forms.ToolStripMenuItem()
        Me.UseSavedCompetition = New System.Windows.Forms.ToolStripMenuItem()
        Me.logedAs = New System.Windows.Forms.ToolStripLabel()
        Me.CreateBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.FencingCompDataDataSet2 = New project_startup_vers_1.FencingCompDataDataSet2()
        Me.RefCompititionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RefCompititionsTableAdapter = New project_startup_vers_1.FencingCompDataDataSet2TableAdapters.RefCompititionsTableAdapter()
        Me.TableAdapterManager1 = New project_startup_vers_1.FencingCompDataDataSet2TableAdapters.TableAdapterManager()
        Me.downBtn = New System.Windows.Forms.Button()
        Me.upBtn = New System.Windows.Forms.Button()
        Me.scoreBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.FencingCompDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.FencingCompDataDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefCompititionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(24, 194)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(100, 20)
        Me.NameBox.TabIndex = 2
        '
        'DateBox
        '
        Me.DateBox.Location = New System.Drawing.Point(157, 194)
        Me.DateBox.Name = "DateBox"
        Me.DateBox.Size = New System.Drawing.Size(100, 20)
        Me.DateBox.TabIndex = 3
        '
        'weapBox
        '
        Me.weapBox.Location = New System.Drawing.Point(24, 240)
        Me.weapBox.Name = "weapBox"
        Me.weapBox.Size = New System.Drawing.Size(100, 20)
        Me.weapBox.TabIndex = 4
        '
        'numBox
        '
        Me.numBox.Location = New System.Drawing.Point(157, 240)
        Me.numBox.Name = "numBox"
        Me.numBox.Size = New System.Drawing.Size(100, 20)
        Me.numBox.TabIndex = 5
        '
        'FencingCompDataDataSet1
        '
        Me.FencingCompDataDataSet1.DataSetName = "FencingCompDataDataSet1"
        Me.FencingCompDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompDataBindingSource
        '
        Me.CompDataBindingSource.DataMember = "compData"
        Me.CompDataBindingSource.DataSource = Me.FencingCompDataDataSet1
        '
        'CompDataTableAdapter
        '
        Me.CompDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.compDataTableAdapter = Me.CompDataTableAdapter
        Me.TableAdapterManager.competitorDataTableAdapter = Nothing
        Me.TableAdapterManager.ScoreDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = project_startup_vers_1.FencingCompDataDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Startbtn
        '
        Me.Startbtn.Location = New System.Drawing.Point(157, 89)
        Me.Startbtn.Name = "Startbtn"
        Me.Startbtn.Size = New System.Drawing.Size(75, 23)
        Me.Startbtn.TabIndex = 8
        Me.Startbtn.Text = "Launch"
        Me.Startbtn.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(23, 175)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(107, 13)
        Me.NameLabel.TabIndex = 9
        Me.NameLabel.Text = "Name Of Competition"
        '
        'Datelabel
        '
        Me.Datelabel.AutoSize = True
        Me.Datelabel.Location = New System.Drawing.Point(159, 175)
        Me.Datelabel.Name = "Datelabel"
        Me.Datelabel.Size = New System.Drawing.Size(102, 13)
        Me.Datelabel.TabIndex = 10
        Me.Datelabel.Text = "Date Of Competition"
        '
        'Weaplabel
        '
        Me.Weaplabel.AutoSize = True
        Me.Weaplabel.Location = New System.Drawing.Point(42, 224)
        Me.Weaplabel.Name = "Weaplabel"
        Me.Weaplabel.Size = New System.Drawing.Size(48, 13)
        Me.Weaplabel.TabIndex = 11
        Me.Weaplabel.Text = "Weapon"
        '
        'sizeLabel
        '
        Me.sizeLabel.AutoSize = True
        Me.sizeLabel.Location = New System.Drawing.Point(162, 224)
        Me.sizeLabel.Name = "sizeLabel"
        Me.sizeLabel.Size = New System.Drawing.Size(99, 13)
        Me.sizeLabel.TabIndex = 12
        Me.sizeLabel.Text = "Size Of Competition"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Navigation, Me.CompOptions, Me.logedAs})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(393, 32)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Navigation
        '
        Me.Navigation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Navigation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenubtn, Me.ViewRecords, Me.PracticeMatch})
        Me.Navigation.Image = CType(resources.GetObject("Navigation.Image"), System.Drawing.Image)
        Me.Navigation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Navigation.Name = "Navigation"
        Me.Navigation.Size = New System.Drawing.Size(116, 29)
        Me.Navigation.Text = "Navigation"
        '
        'MainMenubtn
        '
        Me.MainMenubtn.Name = "MainMenubtn"
        Me.MainMenubtn.Size = New System.Drawing.Size(198, 30)
        Me.MainMenubtn.Text = "Main Menu"
        '
        'ViewRecords
        '
        Me.ViewRecords.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewDatabase, Me.ViewStatistics})
        Me.ViewRecords.Name = "ViewRecords"
        Me.ViewRecords.Size = New System.Drawing.Size(198, 30)
        Me.ViewRecords.Text = "View Records"
        '
        'ViewDatabase
        '
        Me.ViewDatabase.Name = "ViewDatabase"
        Me.ViewDatabase.Size = New System.Drawing.Size(200, 30)
        Me.ViewDatabase.Text = "View Database"
        '
        'ViewStatistics
        '
        Me.ViewStatistics.Name = "ViewStatistics"
        Me.ViewStatistics.Size = New System.Drawing.Size(200, 30)
        Me.ViewStatistics.Text = "View Statistics"
        '
        'PracticeMatch
        '
        Me.PracticeMatch.Name = "PracticeMatch"
        Me.PracticeMatch.Size = New System.Drawing.Size(198, 30)
        Me.PracticeMatch.Text = "Practice Match"
        '
        'CompOptions
        '
        Me.CompOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CompOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Change, Me.UseSavedCompetition})
        Me.CompOptions.Image = CType(resources.GetObject("CompOptions.Image"), System.Drawing.Image)
        Me.CompOptions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CompOptions.Name = "CompOptions"
        Me.CompOptions.Size = New System.Drawing.Size(198, 29)
        Me.CompOptions.Text = "Competition Options"
        '
        'Change
        '
        Me.Change.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeSize, Me.ChangeDate, Me.ChangeName, Me.ChangeWeapon})
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(270, 30)
        Me.Change.Text = "Change Information"
        '
        'ChangeSize
        '
        Me.ChangeSize.Name = "ChangeSize"
        Me.ChangeSize.Size = New System.Drawing.Size(216, 30)
        Me.ChangeSize.Text = "Change Size"
        '
        'ChangeDate
        '
        Me.ChangeDate.Name = "ChangeDate"
        Me.ChangeDate.Size = New System.Drawing.Size(216, 30)
        Me.ChangeDate.Text = "Change Date"
        '
        'ChangeName
        '
        Me.ChangeName.Name = "ChangeName"
        Me.ChangeName.Size = New System.Drawing.Size(216, 30)
        Me.ChangeName.Text = "Change Name"
        '
        'ChangeWeapon
        '
        Me.ChangeWeapon.Name = "ChangeWeapon"
        Me.ChangeWeapon.Size = New System.Drawing.Size(216, 30)
        Me.ChangeWeapon.Text = "Change Weapon"
        '
        'UseSavedCompetition
        '
        Me.UseSavedCompetition.Name = "UseSavedCompetition"
        Me.UseSavedCompetition.Size = New System.Drawing.Size(270, 30)
        Me.UseSavedCompetition.Text = "Use Saved Competition"
        '
        'logedAs
        '
        Me.logedAs.Name = "logedAs"
        Me.logedAs.Size = New System.Drawing.Size(120, 25)
        Me.logedAs.Text = "Not signed In"
        '
        'CreateBtn
        '
        Me.CreateBtn.Location = New System.Drawing.Point(147, 28)
        Me.CreateBtn.Name = "CreateBtn"
        Me.CreateBtn.Size = New System.Drawing.Size(99, 50)
        Me.CreateBtn.TabIndex = 14
        Me.CreateBtn.Text = "Assisted Competition Creation"
        Me.CreateBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(157, 127)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(75, 45)
        Me.SaveBtn.TabIndex = 15
        Me.SaveBtn.Text = "Saver For Later Use"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'FencingCompDataDataSet2
        '
        Me.FencingCompDataDataSet2.DataSetName = "FencingCompDataDataSet2"
        Me.FencingCompDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RefCompititionsBindingSource
        '
        Me.RefCompititionsBindingSource.DataMember = "RefCompititions"
        Me.RefCompititionsBindingSource.DataSource = Me.FencingCompDataDataSet2
        '
        'RefCompititionsTableAdapter
        '
        Me.RefCompititionsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.competitorDataTableAdapter = Nothing
        Me.TableAdapterManager1.compititionDataTableAdapter = Nothing
        Me.TableAdapterManager1.RefCompititionsTableAdapter = Me.RefCompititionsTableAdapter
        Me.TableAdapterManager1.ScoreDataTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = project_startup_vers_1.FencingCompDataDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'downBtn
        '
        Me.downBtn.Location = New System.Drawing.Point(279, 239)
        Me.downBtn.Name = "downBtn"
        Me.downBtn.Size = New System.Drawing.Size(28, 19)
        Me.downBtn.TabIndex = 18
        Me.downBtn.Text = "<"
        Me.downBtn.UseVisualStyleBackColor = True
        '
        'upBtn
        '
        Me.upBtn.Location = New System.Drawing.Point(331, 239)
        Me.upBtn.Name = "upBtn"
        Me.upBtn.Size = New System.Drawing.Size(27, 19)
        Me.upBtn.TabIndex = 17
        Me.upBtn.Text = ">"
        Me.upBtn.UseVisualStyleBackColor = True
        '
        'scoreBox
        '
        Me.scoreBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreBox.Location = New System.Drawing.Point(301, 198)
        Me.scoreBox.Name = "scoreBox"
        Me.scoreBox.ReadOnly = True
        Me.scoreBox.Size = New System.Drawing.Size(36, 48)
        Me.scoreBox.TabIndex = 16
        Me.scoreBox.Text = "10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 22)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Maximum point"
        '
        'compStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 265)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.downBtn)
        Me.Controls.Add(Me.upBtn)
        Me.Controls.Add(Me.scoreBox)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.CreateBtn)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.sizeLabel)
        Me.Controls.Add(Me.Weaplabel)
        Me.Controls.Add(Me.Datelabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Startbtn)
        Me.Controls.Add(Me.numBox)
        Me.Controls.Add(Me.weapBox)
        Me.Controls.Add(Me.DateBox)
        Me.Controls.Add(Me.NameBox)
        Me.Name = "compStart"
        Me.Text = "Create Your Competition"
        CType(Me.FencingCompDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.FencingCompDataDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefCompititionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameBox As System.Windows.Forms.TextBox
    Friend WithEvents DateBox As System.Windows.Forms.TextBox
    Friend WithEvents weapBox As System.Windows.Forms.TextBox
    Friend WithEvents numBox As System.Windows.Forms.TextBox
    Friend WithEvents FencingCompDataDataSet1 As project_startup_vers_1.FencingCompDataDataSet1
    Friend WithEvents CompDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompDataTableAdapter As project_startup_vers_1.FencingCompDataDataSet1TableAdapters.compDataTableAdapter
    Friend WithEvents TableAdapterManager As project_startup_vers_1.FencingCompDataDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Startbtn As Button
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents Datelabel As System.Windows.Forms.Label
    Friend WithEvents Weaplabel As System.Windows.Forms.Label
    Friend WithEvents sizeLabel As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Navigation As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents MainMenubtn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewRecords As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDatabase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewStatistics As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompOptions As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Change As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeSize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateBtn As System.Windows.Forms.Button
    Friend WithEvents ChangeDate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeName As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeWeapon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PracticeMatch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents UseSavedCompetition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FencingCompDataDataSet2 As project_startup_vers_1.FencingCompDataDataSet2
    Friend WithEvents RefCompititionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RefCompititionsTableAdapter As project_startup_vers_1.FencingCompDataDataSet2TableAdapters.RefCompititionsTableAdapter
    Friend WithEvents TableAdapterManager1 As project_startup_vers_1.FencingCompDataDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents logedAs As System.Windows.Forms.ToolStripLabel
    Friend WithEvents downBtn As System.Windows.Forms.Button
    Friend WithEvents upBtn As System.Windows.Forms.Button
    Friend WithEvents scoreBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
