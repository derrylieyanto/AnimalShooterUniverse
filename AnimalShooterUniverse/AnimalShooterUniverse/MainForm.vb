Public Class MainForm
    Dim t As Double 
    Dim v As Double
    Dim a As Double
    Dim y As Double
    Dim x As Double
    Dim flag As Integer
    Dim cat As New Cat
    Dim dog As New Dog
    Dim waktu As Integer



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If projectile1.Left < 15000 And projectile1.Top < 9000 Then
            v = CDbl(pb1.Value)
            a = 70
            t = t + 1
            y = (v * Math.Sin(a * 3.141592654 / 180) * t) - (4.9 * (t ^ 2))
            x = v * Math.Cos(a * 3.141592654 / 180) * t
            projectile1.Location = New Point(projectile1.Left + x, projectile1.Top - y)
            If projectile1.Bounds.IntersectsWith(char2.Bounds) Then
                Timer1.Enabled = False
                projectile1.Visible = False
                hpbar2.Value = CInt(hpbar2.Value) - cat.Damage()
                MsgBox("HIT !!!")
                flag = 1
            ElseIf projectile1.Bounds.IntersectsWith(wall.Bounds) Then
                Timer1.Enabled = False
                projectile1.Visible = False
                MsgBox("MISS !!!")
                flag = 1
            End If
        Else
            Timer1.Enabled = False
            projectile1.Visible = False
            MsgBox("MISS !!!")
            flag = 1
        End If
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If projectile2.Left < 15000 And projectile2.Top < 9000 Then
            v = CDbl(pb2.Value)
            a = 70
            t = t + 1
            y = ((v * Math.Sin(a * 3.141592654 / 180) * t) - (4.9 * (t ^ 2)))
            x = (v * Math.Cos(a * 3.141592654 / 180) * t)
            projectile2.Location = New Point(projectile2.Left - x, projectile2.Top - y)
            If projectile2.Bounds.IntersectsWith(char1.Bounds) Then
                Timer2.Enabled = False
                projectile2.Visible = False
                hpbar1.Value = CInt(hpbar1.Value) - dog.Damage()
                MsgBox("HIT !!!")
                flag = 0
            ElseIf projectile2.Bounds.IntersectsWith(wall.Bounds) Then
                Timer2.Enabled = False
                projectile2.Visible = False
                MsgBox("MISS !!!")
                flag = 0
            End If
        Else
            Timer2.Enabled = False
            projectile2.Visible = False
            MsgBox("MISS !!!")
            flag = 0
        End If

    End Sub


    Private Sub char1_MouseDown(sender As Object, e As MouseEventArgs) Handles char1.MouseDown
        If flag = 0 Then
            pb1.Visible = True
            pb1.Value = 20
            powerTimer.Enabled = True
        End If
    End Sub

    Private Sub char1_MouseUp(sender As Object, e As MouseEventArgs) Handles char1.MouseUp
        If flag = 0 Then
            pb1.Visible = False
            powerTimer.Enabled = False
            projectile1.Visible = True
            projectile1.Location = New Point(130, 449)
            t = 0
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub powerTimer_Tick(sender As Object, e As EventArgs) Handles powerTimer.Tick
        If flag = 0 Then
            If CInt(pb1.Value) > 41 Then
                pb1.Value = pb1.Value - 1
            Else
                pb1.Value = pb1.Value + 1
            End If

        Else
            If CInt(pb2.Value) > 42 Then
                pb2.Value = pb2.Value - 1
            Else
                pb2.Value = pb2.Value + 1
            End If
        End If
    End Sub

    Private Sub char2_MouseDown(sender As Object, e As MouseEventArgs) Handles char2.MouseDown
        If flag = 1 Then
            pb2.Visible = True
            pb2.Value = 20
            powerTimer.Enabled = True
        End If
    End Sub

    Private Sub char2_MouseUp(sender As Object, e As MouseEventArgs) Handles char2.MouseUp
        If flag = 1 Then
            pb2.Visible = False
            powerTimer.Enabled = False
            projectile2.Visible = True
            projectile2.Location = New Point(863, 449)
            t = 0
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub mainTimer_Tick(sender As Object, e As EventArgs) Handles mainTimer.Tick
        txtTimer.Text = waktu
        If flag = 0 Then
            lblTurn.Text = "Turn : Player 1"
        Else
            lblTurn.Text = "Turn : Player 2"
        End If
        If hpbar1.Value = 0 Then
            mainTimer.Enabled = False
            MsgBox("Player 2 WIN !!!")
            Application.Exit()
        ElseIf hpbar2.Value = 0 Then
            mainTimer.Enabled = False
            MsgBox("Player 1 WIN !!!")
            Application.Exit()
        End If
        waktu = waktu + 1
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        waktu = 0
        flag = 0
        mainTimer.Enabled = True
        hpbar1.Maximum = cat.Life()
        hpbar1.Value = cat.Life()
        hpbar2.Maximum = dog.Life()
        hpbar2.Value = dog.Life()
    End Sub


End Class