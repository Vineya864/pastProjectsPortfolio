<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class progress
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.PrScore = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.IDBox = New System.Windows.Forms.TextBox()
        Me.FNameBox = New System.Windows.Forms.TextBox()
        Me.SnameBox = New System.Windows.Forms.TextBox()
        Me.AgeBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.backBtn = New System.Windows.Forms.Button()
        CType(Me.PrScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrScore
        '
        ChartArea1.Name = "ChartArea1"
        Me.PrScore.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.PrScore.Legends.Add(Legend1)
        Me.PrScore.Location = New System.Drawing.Point(201, 46)
        Me.PrScore.Name = "PrScore"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Scores"
        Me.PrScore.Series.Add(Series1)
        Me.PrScore.Size = New System.Drawing.Size(237, 206)
        Me.PrScore.TabIndex = 0
        Me.PrScore.Text = "Score Progress"
        '
        'IDBox
        '
        Me.IDBox.Location = New System.Drawing.Point(101, 46)
        Me.IDBox.Name = "IDBox"
        Me.IDBox.ReadOnly = True
        Me.IDBox.Size = New System.Drawing.Size(27, 20)
        Me.IDBox.TabIndex = 1
        '
        'FNameBox
        '
        Me.FNameBox.Location = New System.Drawing.Point(77, 97)
        Me.FNameBox.Name = "FNameBox"
        Me.FNameBox.ReadOnly = True
        Me.FNameBox.Size = New System.Drawing.Size(100, 20)
        Me.FNameBox.TabIndex = 2
        '
        'SnameBox
        '
        Me.SnameBox.Location = New System.Drawing.Point(77, 134)
        Me.SnameBox.Name = "SnameBox"
        Me.SnameBox.ReadOnly = True
        Me.SnameBox.Size = New System.Drawing.Size(100, 20)
        Me.SnameBox.TabIndex = 3
        '
        'AgeBox
        '
        Me.AgeBox.Location = New System.Drawing.Point(101, 171)
        Me.AgeBox.Name = "AgeBox"
        Me.AgeBox.ReadOnly = True
        Me.AgeBox.Size = New System.Drawing.Size(27, 20)
        Me.AgeBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-4, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Second Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Age"
        '
        'backBtn
        '
        Me.backBtn.Location = New System.Drawing.Point(352, 258)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(86, 39)
        Me.backBtn.TabIndex = 9
        Me.backBtn.Text = "return to scoreboard"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'progress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 309)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AgeBox)
        Me.Controls.Add(Me.SnameBox)
        Me.Controls.Add(Me.FNameBox)
        Me.Controls.Add(Me.IDBox)
        Me.Controls.Add(Me.PrScore)
        Me.Name = "progress"
        Me.Text = "Competition Progress"
        CType(Me.PrScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrScore As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents IDBox As System.Windows.Forms.TextBox
    Friend WithEvents FNameBox As System.Windows.Forms.TextBox
    Friend WithEvents SnameBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents backBtn As System.Windows.Forms.Button
End Class
