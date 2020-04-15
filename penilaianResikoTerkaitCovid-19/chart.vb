Public Class chart

    Private Sub chart_Load(sender As Object, e As EventArgs)
        Call resikor()
        Call resikos()
        Call resikot()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Chart1.Series("Resiko").Points.AddXY("Rendah", jr)
        Chart1.Series("Resiko").Points.AddXY("Sedang", js)
        Chart1.Series("Resiko").Points.AddXY("Tinggi", jt)

        If jt >= js And jt >= jr Then
            Label2.Text = "Tinggi"
        ElseIf js >= jr And js >= jt Then
            Label2.Text = "Sedang"
        ElseIf jr >= jt And jr >= js Then
            Label2.Text = "Rendah"
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class