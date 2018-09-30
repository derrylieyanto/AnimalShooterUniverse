Public Class MainForm


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim dog As New Dog
        Label1.Text = dog.Life()
    End Sub
End Class