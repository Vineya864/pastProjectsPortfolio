<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class datePicker
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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(-1, 2)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Location = New System.Drawing.Point(73, 162)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(75, 23)
        Me.SubmitBtn.TabIndex = 1
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Location = New System.Drawing.Point(154, 167)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(39, 13)
        Me.dateLabel.TabIndex = 2
        Me.dateLabel.Text = "Label1"
        '
        'datePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(221, 184)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "datePicker"
        Me.Text = "Select a Date"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents SubmitBtn As System.Windows.Forms.Button
    Friend WithEvents dateLabel As System.Windows.Forms.Label
End Class
