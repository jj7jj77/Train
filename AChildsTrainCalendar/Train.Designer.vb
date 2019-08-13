<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Train
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Train))
        Me.TrainTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TrainPictureBox = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TrainPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrainTimer
        '
        Me.TrainTimer.Enabled = True
        '
        'TrainPictureBox
        '
        Me.TrainPictureBox.Image = CType(resources.GetObject("TrainPictureBox.Image"), System.Drawing.Image)
        Me.TrainPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.TrainPictureBox.Name = "TrainPictureBox"
        Me.TrainPictureBox.Size = New System.Drawing.Size(68, 73)
        Me.TrainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TrainPictureBox.TabIndex = 2
        Me.TrainPictureBox.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'Train
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.TrainPictureBox)
        Me.Name = "Train"
        Me.Text = "Train"
        CType(Me.TrainPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TrainTimer As Timer
    Friend WithEvents TrainPictureBox As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
