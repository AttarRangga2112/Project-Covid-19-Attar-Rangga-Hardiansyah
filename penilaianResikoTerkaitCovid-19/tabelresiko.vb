Public Class tabelresiko
    Private Sub tabelresiko_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call panggildata()
        Call resikot()
        Call resikos()
        Call resikor()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(20)
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Form3.Show()
        End If
    End Sub
End Class