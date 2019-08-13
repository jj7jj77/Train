Public Class Train

    'PUT control box in Properties to false to take the X out when finalizing application
    Private Sub Train_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        TrainTimer.Enabled = True
    End Sub

    Private Sub TrainTimer_Tick(sender As Object, e As EventArgs) Handles TrainTimer.Tick
        ' Move the graphic across the form. 
        Static XInteger As Integer = TrainPictureBox.Left
        Static YInteger As Integer = TrainPictureBox.Top
        Static WidthInteger As Integer = TrainPictureBox.Width
        Static HeightInteger As Integer = TrainPictureBox.Height


        YInteger += 10
        XInteger += 10

        TrainPictureBox.Left = 0
        TrainPictureBox.Top= 0

        If YInteger > Me.Height Then
            YInteger += 20

            TrainPictureBox.Top = 0
            TrainPictureBox.Left = 0
        End If

        ' Move image.
        TrainPictureBox.SetBounds(XInteger, YInteger, WidthInteger, HeightInteger)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False    'ends timer
        Me.Hide()    'hides train form after child form shown
        ParentOfChild.Show()
    End Sub
End Class