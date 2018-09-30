Public Class CharSelectForm
    Dim hitungChar1 As Integer = 1
    Dim hitungChar2 As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mainForm As New MainForm
        Me.Hide()
        mainForm.Show()
    End Sub

    Private Sub PbKiri_Click(sender As Object, e As EventArgs) Handles PbKiri.Click
        Select Case hitungChar1
            Case 1
                PbKiri.Image = My.Resources.kucing2
            Case 2
                PbKiri.Image = My.Resources.banteng2
            Case 3
                PbKiri.Image = My.Resources.burungunta2
            Case 4
                PbKiri.Image = My.Resources.hyena2
            Case 5
                PbKiri.Image = My.Resources.kadal2
            Case 6
                PbKiri.Image = My.Resources.keledai2
            Case 7
                PbKiri.Image = My.Resources.kurakura2
            Case 8
                PbKiri.Image = My.Resources.monyet2
            Case 9
                PbKiri.Image = My.Resources.orangutan2
            Case 10
                PbKiri.Image = My.Resources.panda2
            Case 11
                PbKiri.Image = My.Resources.singa2
            Case 12
                PbKiri.Image = My.Resources.trenggiling2
            Case 13
                PbKiri.Image = My.Resources.ular2
            Case 14
                PbKiri.Image = My.Resources.unta2
            Case 15
                PbKiri.Image = My.Resources.anjing2
        End Select
    End Sub

    Private Sub btnChar1Next_Click(sender As Object, e As EventArgs) Handles btnChar1Next.Click
        hitungChar1 = hitungChar1 + 1
        Select Case hitungChar1
            Case 1
                PbKiri.Image = My.Resources.kucing2
            Case 2
                PbKiri.Image = My.Resources.banteng2
            Case 3
                PbKiri.Image = My.Resources.burungunta2
            Case 4
                PbKiri.Image = My.Resources.hyena2
            Case 5
                PbKiri.Image = My.Resources.kadal2
            Case 6
                PbKiri.Image = My.Resources.keledai2
            Case 7
                PbKiri.Image = My.Resources.kurakura2
            Case 8
                PbKiri.Image = My.Resources.monyet2
            Case 9
                PbKiri.Image = My.Resources.orangutan2
            Case 10
                PbKiri.Image = My.Resources.panda2
            Case 11
                PbKiri.Image = My.Resources.singa2
            Case 12
                PbKiri.Image = My.Resources.trenggiling2
            Case 13
                PbKiri.Image = My.Resources.ular2
            Case 14
                PbKiri.Image = My.Resources.unta2
            Case 15
                PbKiri.Image = My.Resources.anjing2
        End Select
    End Sub

    Private Sub btnChar1Prev_Click(sender As Object, e As EventArgs) Handles btnChar1Prev.Click
        If hitungChar1 = 16 Then
            hitungChar1 = 1
        ElseIf hitungChar1 = 0 Then
            hitungChar1 = 15
        End If
        hitungChar1 = hitungChar1 - 1
        Select Case hitungChar1
            Case 1
                PbKiri.Image = My.Resources.kucing2
            Case 2
                PbKiri.Image = My.Resources.banteng2
            Case 3
                PbKiri.Image = My.Resources.burungunta2
            Case 4
                PbKiri.Image = My.Resources.hyena2
            Case 5
                PbKiri.Image = My.Resources.kadal2
            Case 6
                PbKiri.Image = My.Resources.keledai2
            Case 7
                PbKiri.Image = My.Resources.kurakura2
            Case 8
                PbKiri.Image = My.Resources.monyet2
            Case 9
                PbKiri.Image = My.Resources.orangutan2
            Case 10
                PbKiri.Image = My.Resources.panda2
            Case 11
                PbKiri.Image = My.Resources.singa2
            Case 12
                PbKiri.Image = My.Resources.trenggiling2
            Case 13
                PbKiri.Image = My.Resources.ular2
            Case 14
                PbKiri.Image = My.Resources.unta2
            Case 15
                PbKiri.Image = My.Resources.anjing2
        End Select
    End Sub

    Private Sub btnChar2Next_Click(sender As Object, e As EventArgs) Handles btnChar2Next.Click
        hitungChar2 = hitungChar2 + 1
        Select Case hitungChar2
            Case 1
                PbKanan.Image = My.Resources.kucing1
            Case 2
                PbKanan.Image = My.Resources.banteng1
            Case 3
                PbKanan.Image = My.Resources.burungunta1
            Case 4
                PbKanan.Image = My.Resources.hyena1
            Case 5
                PbKanan.Image = My.Resources.kadal1
            Case 6
                PbKanan.Image = My.Resources.keledai1
            Case 7
                PbKanan.Image = My.Resources.kurakura1
            Case 8
                PbKanan.Image = My.Resources.monyet1
            Case 9
                PbKanan.Image = My.Resources.orangutan1
            Case 10
                PbKanan.Image = My.Resources.panda1
            Case 11
                PbKanan.Image = My.Resources.singa1
            Case 12
                PbKanan.Image = My.Resources.trenggiling1
            Case 13
                PbKanan.Image = My.Resources.ular1
            Case 14
                PbKanan.Image = My.Resources.unta1
            Case 15
                PbKanan.Image = My.Resources.anjing1
        End Select
    End Sub

    Private Sub btnChar2Prev_Click(sender As Object, e As EventArgs) Handles btnChar2Prev.Click
        hitungChar2 = hitungChar2 - 1
        Select Case hitungChar2
            Case 1
                PbKanan.Image = My.Resources.kucing1
            Case 2
                PbKanan.Image = My.Resources.banteng1
            Case 3
                PbKanan.Image = My.Resources.burungunta1
            Case 4
                PbKanan.Image = My.Resources.hyena1
            Case 5
                PbKanan.Image = My.Resources.kadal1
            Case 6
                PbKanan.Image = My.Resources.keledai1
            Case 7
                PbKanan.Image = My.Resources.kurakura1
            Case 8
                PbKanan.Image = My.Resources.monyet1
            Case 9
                PbKanan.Image = My.Resources.orangutan1
            Case 10
                PbKanan.Image = My.Resources.panda1
            Case 11
                PbKanan.Image = My.Resources.singa1
            Case 12
                PbKanan.Image = My.Resources.trenggiling1
            Case 13
                PbKanan.Image = My.Resources.ular1
            Case 14
                PbKanan.Image = My.Resources.unta1
            Case 15
                PbKanan.Image = My.Resources.anjing1
        End Select
    End Sub

    Private Sub PbKanan_Click(sender As Object, e As EventArgs) Handles PbKanan.Click
        Select Case hitungChar2
            Case 1
                PbKanan.Image = My.Resources.kucing1
            Case 2
                PbKanan.Image = My.Resources.banteng1
            Case 3
                PbKanan.Image = My.Resources.burungunta1
            Case 4
                PbKanan.Image = My.Resources.hyena1
            Case 5
                PbKanan.Image = My.Resources.kadal1
            Case 6
                PbKanan.Image = My.Resources.keledai1
            Case 7
                PbKanan.Image = My.Resources.kurakura1
            Case 8
                PbKanan.Image = My.Resources.monyet1
            Case 9
                PbKanan.Image = My.Resources.orangutan1
            Case 10
                PbKanan.Image = My.Resources.panda1
            Case 11
                PbKanan.Image = My.Resources.singa1
            Case 12
                PbKanan.Image = My.Resources.trenggiling1
            Case 13
                PbKanan.Image = My.Resources.ular1
            Case 14
                PbKanan.Image = My.Resources.unta1
            Case 15
                PbKanan.Image = My.Resources.anjing1
        End Select
    End Sub
End Class