<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maxPoint
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
        Me.scoreBox = New System.Windows.Forms.TextBox()
        Me.upBtn = New System.Windows.Forms.Button()
        Me.downBtn = New System.Windows.Forms.Button()
        Me.launchbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'scoreBox
        '
        Me.scoreBox.Location = New System.Drawing.Point(115, 96)
        Me.scoreBox.Name = "scoreBox"
        Me.scoreBox.Size = New System.Drawing.Size(30, 20)
        Me.scoreBox.TabIndex = 0
        '
        'upBtn
        '
        Me.upBtn.Location = New System.Drawing.Point(115, 71)
        Me.upBtn.Name = "upBtn"
        Me.upBtn.Size = New System.Drawing.Size(27, 19)
        Me.upBtn.TabIndex = 1
        Me.upBtn.Text = ">"
        Me.upBtn.UseVisualStyleBackColor = True
        '
        'downBtn
        '
        Me.downBtn.Location = New System.Drawing.Point(115, 122)
        Me.downBtn.Name = "downBtn"
        Me.downBtn.Size = New System.Drawing.Size(27, 23)
        Me.downBtn.TabIndex = 2
        Me.downBtn.Text = "<"
        Me.downBtn.UseVisualStyleBackColor = True
        '
        'launchbtn
        '
        Me.launchbtn.Location = New System.Drawing.Point(88, 151)
        Me.launchbtn.Name = "launchbtn"
        Me.launchbtn.Size = New System.Drawing.Size(75, 23)
        Me.launchbtn.TabIndex = 3
        Me.launchbtn.Text = "Select"
        Me.launchbtn.UseVisualStyleBackColor = True
        '
        'maxPoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.launchbtn)
        Me.Controls.Add(Me.downBtn)
        Me.Controls.Add(Me.upBtn)
        Me.Controls.Add(Me.scoreBox)
        Me.Name = "maxPoint"
        Me.Text = "maximum point score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents scoreBox As System.Windows.Forms.TextBox
    Friend WithEvents upBtn As System.Windows.Forms.Button
    Friend WithEvents downBtn As System.Windows.Forms.Button
    Friend WithEvents launchbtn As System.Windows.Forms.Button
End Class
