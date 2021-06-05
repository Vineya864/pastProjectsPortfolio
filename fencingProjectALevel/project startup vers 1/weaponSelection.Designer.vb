<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class weaponSelection
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
        Me.foil = New System.Windows.Forms.RadioButton()
        Me.epee = New System.Windows.Forms.RadioButton()
        Me.saber = New System.Windows.Forms.RadioButton()
        Me.subbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'foil
        '
        Me.foil.AutoSize = True
        Me.foil.Location = New System.Drawing.Point(0, 0)
        Me.foil.Name = "foil"
        Me.foil.Size = New System.Drawing.Size(41, 17)
        Me.foil.TabIndex = 0
        Me.foil.TabStop = True
        Me.foil.Text = "Foil"
        Me.foil.UseVisualStyleBackColor = True
        '
        'epee
        '
        Me.epee.AutoSize = True
        Me.epee.Location = New System.Drawing.Point(96, 0)
        Me.epee.Name = "epee"
        Me.epee.Size = New System.Drawing.Size(50, 17)
        Me.epee.TabIndex = 1
        Me.epee.TabStop = True
        Me.epee.Text = "Epee"
        Me.epee.UseVisualStyleBackColor = True
        '
        'saber
        '
        Me.saber.AutoSize = True
        Me.saber.Location = New System.Drawing.Point(206, 0)
        Me.saber.Name = "saber"
        Me.saber.Size = New System.Drawing.Size(53, 17)
        Me.saber.TabIndex = 2
        Me.saber.TabStop = True
        Me.saber.Text = "Saber"
        Me.saber.UseVisualStyleBackColor = True
        '
        'subbtn
        '
        Me.subbtn.Location = New System.Drawing.Point(96, 44)
        Me.subbtn.Name = "subbtn"
        Me.subbtn.Size = New System.Drawing.Size(75, 23)
        Me.subbtn.TabIndex = 3
        Me.subbtn.Text = "submit"
        Me.subbtn.UseVisualStyleBackColor = True
        '
        'weaponSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 91)
        Me.Controls.Add(Me.subbtn)
        Me.Controls.Add(Me.saber)
        Me.Controls.Add(Me.epee)
        Me.Controls.Add(Me.foil)
        Me.Name = "weaponSelection"
        Me.Text = "Weapon Selection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents foil As System.Windows.Forms.RadioButton
    Friend WithEvents epee As System.Windows.Forms.RadioButton
    Friend WithEvents saber As System.Windows.Forms.RadioButton
    Friend WithEvents subbtn As System.Windows.Forms.Button
End Class
