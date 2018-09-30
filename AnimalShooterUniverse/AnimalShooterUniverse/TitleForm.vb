Public Class AnimalShooterUniverse
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim CharSelectForm As New CharSelectForm

        Me.Hide()
        CharSelectForm.Show()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
