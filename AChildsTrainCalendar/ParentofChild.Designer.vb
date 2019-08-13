<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentOfChild
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
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ChildOneToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ChildTwoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TimeToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DateToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NameLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChildOneFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChildTwoFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalendarBtn = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClockTimer
        '
        Me.ClockTimer.Interval = 1000
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChildOneToolStripButton, Me.ChildTwoToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(586, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ChildOneToolStripButton
        '
        Me.ChildOneToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ChildOneToolStripButton.Image = Global.AChildsTrainCalendar.My.Resources.Resources.funny_emoji
        Me.ChildOneToolStripButton.ImageTransparentColor = System.Drawing.Color.White
        Me.ChildOneToolStripButton.Name = "ChildOneToolStripButton"
        Me.ChildOneToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ChildOneToolStripButton.Text = "ChildOneToolStripButton"
        Me.ChildOneToolStripButton.ToolTipText = "Display a new Child One Form"
        '
        'ChildTwoToolStripButton
        '
        Me.ChildTwoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ChildTwoToolStripButton.Image = Global.AChildsTrainCalendar.My.Resources.Resources.cowboy_emoji
        Me.ChildTwoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ChildTwoToolStripButton.Name = "ChildTwoToolStripButton"
        Me.ChildTwoToolStripButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChildTwoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ChildTwoToolStripButton.Text = "ChildTwoToolStripButton"
        Me.ChildTwoToolStripButton.ToolTipText = "Display a new Child Two Form"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimeToolStripStatusLabel, Me.DateToolStripStatusLabel, Me.NameLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 393)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(586, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TimeToolStripStatusLabel
        '
        Me.TimeToolStripStatusLabel.Name = "TimeToolStripStatusLabel"
        Me.TimeToolStripStatusLabel.Size = New System.Drawing.Size(0, 0)
        Me.TimeToolStripStatusLabel.ToolTipText = "The sysem time"
        '
        'DateToolStripStatusLabel
        '
        Me.DateToolStripStatusLabel.Name = "DateToolStripStatusLabel"
        Me.DateToolStripStatusLabel.Size = New System.Drawing.Size(0, 0)
        Me.DateToolStripStatusLabel.ToolTipText = "The system date"
        '
        'NameLabel
        '
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(30, 17)
        Me.NameLabel.Text = "Julia"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.WindowToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(586, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChildOneFormToolStripMenuItem, Me.ChildTwoFormToolStripMenuItem})
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DisplayToolStripMenuItem.Text = "&Display"
        '
        'ChildOneFormToolStripMenuItem
        '
        Me.ChildOneFormToolStripMenuItem.Name = "ChildOneFormToolStripMenuItem"
        Me.ChildOneFormToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ChildOneFormToolStripMenuItem.Text = "Child &One Form"
        '
        'ChildTwoFormToolStripMenuItem
        '
        Me.ChildTwoFormToolStripMenuItem.Name = "ChildTwoFormToolStripMenuItem"
        Me.ChildTwoFormToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ChildTwoFormToolStripMenuItem.Text = "Child &Two Form"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TileHorizontallyToolStripMenuItem, Me.TileVerticallyToolStripMenuItem, Me.CascadeToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "&Window"
        '
        'TileHorizontallyToolStripMenuItem
        '
        Me.TileHorizontallyToolStripMenuItem.Name = "TileHorizontallyToolStripMenuItem"
        Me.TileHorizontallyToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.TileHorizontallyToolStripMenuItem.Text = "Tile &Horizontally"
        '
        'TileVerticallyToolStripMenuItem
        '
        Me.TileVerticallyToolStripMenuItem.Name = "TileVerticallyToolStripMenuItem"
        Me.TileVerticallyToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.TileVerticallyToolStripMenuItem.Text = "Tile &Vertically"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'CalendarBtn
        '
        Me.CalendarBtn.Location = New System.Drawing.Point(479, 1)
        Me.CalendarBtn.Name = "CalendarBtn"
        Me.CalendarBtn.Size = New System.Drawing.Size(95, 23)
        Me.CalendarBtn.TabIndex = 6
        Me.CalendarBtn.Text = "Go To Calendar"
        Me.CalendarBtn.UseVisualStyleBackColor = True
        '
        'ParentOfChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 415)
        Me.Controls.Add(Me.CalendarBtn)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ParentOfChild"
        Me.Text = "ParentOfChild"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClockTimer As Timer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ChildOneToolStripButton As ToolStripButton
    Friend WithEvents ChildTwoToolStripButton As ToolStripButton
    Friend WithEvents TimeToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents DateToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents NameLabel As ToolStripStatusLabel
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChildOneFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChildTwoFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileHorizontallyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileVerticallyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalendarBtn As Button
End Class
