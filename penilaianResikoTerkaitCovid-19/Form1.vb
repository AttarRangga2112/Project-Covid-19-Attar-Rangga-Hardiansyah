Public Class Form1
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Harap isi Form terlebih dahulu")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Harap isi Form terlebih dahulu")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Harap isi Form terlebih dahulu")
        ElseIf TextBox1.Text = "attarRangga" And TextBox2.Text = "admin" And TextBox3.Text = "admin" And RadioButton1.Checked = True Then
            Form3.Show()
        Else
            Form2.Show()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form4.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
