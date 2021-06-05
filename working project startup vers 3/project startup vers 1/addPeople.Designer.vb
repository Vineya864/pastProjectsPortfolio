<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addcompetitors
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
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.Surname = New System.Windows.Forms.TextBox()
        Me.Age = New System.Windows.Forms.TextBox()
        Me.gender1 = New System.Windows.Forms.RadioButton()
        Me.gender2 = New System.Windows.Forms.RadioButton()
        Me.upload = New System.Windows.Forms.Button()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(95, 35)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(100, 20)
        Me.FirstName.TabIndex = 0
        '
        'Surname
        '
        Me.Surname.Location = New System.Drawing.Point(95, 79)
        Me.Surname.Name = "Surname"
        Me.Surname.Size = New System.Drawing.Size(100, 20)
        Me.Surname.TabIndex = 1
        '
        'Age
        '
        Me.Age.Location = New System.Drawing.Point(128, 118)
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(34, 20)
        Me.Age.TabIndex = 2
        '
        'gender1
        '
        Me.gender1.AutoSize = True
        Me.gender1.Location = New System.Drawing.Point(82, 155)
        Me.gender1.Name = "gender1"
        Me.gender1.Size = New System.Drawing.Size(48, 17)
        Me.gender1.TabIndex = 3
        Me.gender1.TabStop = True
        Me.gender1.Text = "Male"
        Me.gender1.UseVisualStyleBackColor = True
        '
        'gender2
        '
        Me.gender2.AutoSize = True
        Me.gender2.Location = New System.Drawing.Point(161, 155)
        Me.gender2.Name = "gender2"
        Me.gender2.Size = New System.Drawing.Size(56, 17)
        Me.gender2.TabIndex = 4
        Me.gender2.TabStop = True
        Me.gender2.Text = "female"
        Me.gender2.UseVisualStyleBackColor = True
        '
        'upload
        '
        Me.upload.Location = New System.Drawing.Point(108, 198)
        Me.upload.Name = "upload"
        Me.upload.Size = New System.Drawing.Size(75, 23)
        Me.upload.TabIndex = 5
        Me.upload.Text = "Submit"
        Me.upload.UseVisualStyleBackColor = True
        '
        'previousBtn
        '
        Me.previousBtn.Location = New System.Drawing.Point(108, 227)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(75, 50)
        Me.previousBtn.TabIndex = 6
        Me.previousBtn.Text = "Select a previous competitor"
        Me.previousBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "First name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(136, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Age"
        '
        'addcompetitors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 284)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.upload)
        Me.Controls.Add(Me.gender2)
        Me.Controls.Add(Me.gender1)
        Me.Controls.Add(Me.Age)
        Me.Controls.Add(Me.Surname)
        Me.Controls.Add(Me.FirstName)
        Me.Name = "addcompetitors"
        Me.Text = "Add a Competitor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FirstName As System.Windows.Forms.TextBox
    Friend WithEvents Surname As System.Windows.Forms.TextBox
    Friend WithEvents Age As System.Windows.Forms.TextBox
    Friend WithEvents gender1 As System.Windows.Forms.RadioButton
    Friend WithEvents gender2 As System.Windows.Forms.RadioButton
    Friend WithEvents upload As System.Windows.Forms.Button
    Friend WithEvents previousBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
