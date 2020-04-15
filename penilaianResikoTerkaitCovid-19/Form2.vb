Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Form1.RadioButton1.Checked = True Then
            jk = Form1.RadioButton1.Text
        ElseIf Form1.RadioButton2.Checked = True Then
            jk = Form1.RadioButton2.Text
        End If

        If CheckBox1.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox2.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox3.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox4.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox5.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox6.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox7.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox8.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox9.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox10.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox11.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox12.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox13.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox14.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox15.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox16.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox17.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox18.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox19.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox20.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If
        If CheckBox21.Checked = True Then
            y = y + 1
        Else
            t = t + 1
        End If

        If y >= 0 And y <= 7 Then
            hasil = "rendah"
            Form4.Label1.Text = "Anda Beresiko Rendah Terkena Virus COVID-19"
        ElseIf y >= 8 And y <= 14 Then
            hasil = "Sedang"
            Form4.Label1.Text = "Anda Beresiko Sedang Terkena Virus COVID-19"
        Else
            hasil = "tinggi"
            Form4.Label1.Text = "Anda Beresiko tinggi Terkena Virus COVID-19"
        End If

        sqlnya = "insert into tb_orang(nama,jenis_kelamin,umur,alamat,ya,tidak,resiko)values('" & Form1.TextBox1.Text & "','" & jk & "','" & Form1.TextBox2.Text & "','" & Form1.TextBox3.Text & "','" & y & "','" & t & "','" & hasil & "')"
        Call jalan()
        Call panggildata()
        Form4.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox22.Checked = True
        CheckBox23.Checked = False
        Form1.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class