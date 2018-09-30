Public Class CharSelectForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mainForm As New MainForm

        Me.Hide()
        mainForm.Show()


    End Sub
End Class