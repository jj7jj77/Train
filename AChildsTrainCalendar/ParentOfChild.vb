Public Class ParentOfChild

    'Module-level declarations
    Dim ChildOneCountInteger As Integer
    Dim ChildTwoCountInteger As Integer

    'enable the timer
    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        DateToolStripStatusLabel.Text = Now.ToShortDateString()
        TimeToolStripStatusLabel.Text = Now.ToLongDateString()
    End Sub

    'Display the data and time in the status bar
    Private Sub Parent_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        ClockTimer_Tick(sender, e)
    End Sub

    'ends the program
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ChildOneFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChildOneFormToolStripMenuItem.Click, ChildOneToolStripButton.Click
        'Displays the Child One Form
        Dim AChildOneForm As New ChildOneForm
        With AChildOneForm
            .MdiParent = Me  'parent of that child form
            ChildOneCountInteger += 1 ' label child document
            .Text = "Child One Document " & ChildOneCountInteger.ToString()
            .Show()
        End With
    End Sub

    Private Sub ChildTwoFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChildTwoFormToolStripMenuItem.Click, ChildTwoToolStripButton.Click
        'Display Child Two Form
        Dim AChildTwoForm As New ChildTwoForm
        With AChildTwoForm
            .MdiParent = Me
            ChildTwoCountInteger += 1
            .Text = "Child Two Document " & ChildTwoCountInteger.ToString()
            .Show()
        End With
    End Sub

    Private Sub TileHorizontallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontallyToolStripMenuItem.Click
        'Arrange the child forms horizontally
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileVerticallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticallyToolStripMenuItem.Click
        'Arrande the child forms vertially
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        'Cascade the child form
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub CalendarBtn_Click(sender As Object, e As EventArgs) Handles CalendarBtn.Click
        Me.Close()
        Calendar.Show()
    End Sub
End Class