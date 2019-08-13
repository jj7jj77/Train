<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calendar
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
        Me.DisplayGradBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.GraduationDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GradDateTxtBx = New System.Windows.Forms.TextBox()
        Me.lblGradDate = New System.Windows.Forms.Label()
        Me.lblYrs = New System.Windows.Forms.Label()
        Me.YrsLeftTxtBx = New System.Windows.Forms.TextBox()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.lblPastYrs = New System.Windows.Forms.Label()
        Me.DaysPastGradTxtBx = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'DisplayGradBtn
        '
        Me.DisplayGradBtn.Location = New System.Drawing.Point(326, 38)
        Me.DisplayGradBtn.Name = "DisplayGradBtn"
        Me.DisplayGradBtn.Size = New System.Drawing.Size(75, 42)
        Me.DisplayGradBtn.TabIndex = 2
        Me.DisplayGradBtn.Text = "Display &Graduation"
        Me.DisplayGradBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(326, 256)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExitBtn.TabIndex = 1
        Me.ExitBtn.Text = "E&xit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'GraduationDateTimePicker
        '
        Me.GraduationDateTimePicker.Location = New System.Drawing.Point(66, 221)
        Me.GraduationDateTimePicker.Name = "GraduationDateTimePicker"
        Me.GraduationDateTimePicker.Size = New System.Drawing.Size(211, 20)
        Me.GraduationDateTimePicker.TabIndex = 4
        Me.GraduationDateTimePicker.Value = New Date(2019, 8, 10, 0, 0, 0, 0)
        '
        'GradDateTxtBx
        '
        Me.GradDateTxtBx.Location = New System.Drawing.Point(168, 31)
        Me.GradDateTxtBx.Name = "GradDateTxtBx"
        Me.GradDateTxtBx.Size = New System.Drawing.Size(100, 20)
        Me.GradDateTxtBx.TabIndex = 1
        '
        'lblGradDate
        '
        Me.lblGradDate.AutoSize = True
        Me.lblGradDate.Location = New System.Drawing.Point(63, 38)
        Me.lblGradDate.Name = "lblGradDate"
        Me.lblGradDate.Size = New System.Drawing.Size(84, 13)
        Me.lblGradDate.TabIndex = 4
        Me.lblGradDate.Text = "Graduation Year"
        '
        'lblYrs
        '
        Me.lblYrs.AutoSize = True
        Me.lblYrs.Location = New System.Drawing.Point(23, 166)
        Me.lblYrs.Name = "lblYrs"
        Me.lblYrs.Size = New System.Drawing.Size(124, 13)
        Me.lblYrs.TabIndex = 5
        Me.lblYrs.Text = "Years Left Til Graduation"
        '
        'YrsLeftTxtBx
        '
        Me.YrsLeftTxtBx.BackColor = System.Drawing.SystemColors.ControlLight
        Me.YrsLeftTxtBx.Location = New System.Drawing.Point(168, 161)
        Me.YrsLeftTxtBx.Name = "YrsLeftTxtBx"
        Me.YrsLeftTxtBx.ReadOnly = True
        Me.YrsLeftTxtBx.Size = New System.Drawing.Size(100, 20)
        Me.YrsLeftTxtBx.TabIndex = 6
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(326, 146)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(75, 23)
        Me.ClearBtn.TabIndex = 7
        Me.ClearBtn.Text = "&Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'lblPastYrs
        '
        Me.lblPastYrs.AutoSize = True
        Me.lblPastYrs.Location = New System.Drawing.Point(37, 102)
        Me.lblPastYrs.Name = "lblPastYrs"
        Me.lblPastYrs.Size = New System.Drawing.Size(110, 13)
        Me.lblPastYrs.TabIndex = 8
        Me.lblPastYrs.Text = "Days Past Graduation"
        '
        'DaysPastGradTxtBx
        '
        Me.DaysPastGradTxtBx.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DaysPastGradTxtBx.Location = New System.Drawing.Point(168, 95)
        Me.DaysPastGradTxtBx.Name = "DaysPastGradTxtBx"
        Me.DaysPastGradTxtBx.ReadOnly = True
        Me.DaysPastGradTxtBx.Size = New System.Drawing.Size(100, 20)
        Me.DaysPastGradTxtBx.TabIndex = 9
        '
        'Calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(431, 307)
        Me.Controls.Add(Me.DaysPastGradTxtBx)
        Me.Controls.Add(Me.lblPastYrs)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.YrsLeftTxtBx)
        Me.Controls.Add(Me.lblYrs)
        Me.Controls.Add(Me.lblGradDate)
        Me.Controls.Add(Me.GradDateTxtBx)
        Me.Controls.Add(Me.GraduationDateTimePicker)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.DisplayGradBtn)
        Me.Name = "Calendar"
        Me.Text = "Calendar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayGradBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents GraduationDateTimePicker As DateTimePicker
    Friend WithEvents GradDateTxtBx As TextBox
    Friend WithEvents lblGradDate As Label
    Friend WithEvents lblYrs As Label
    Friend WithEvents YrsLeftTxtBx As TextBox
    Friend WithEvents ClearBtn As Button
    Friend WithEvents lblPastYrs As Label
    Friend WithEvents DaysPastGradTxtBx As TextBox
End Class
