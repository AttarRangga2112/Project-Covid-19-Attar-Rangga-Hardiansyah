Public Class table
    Private Sub table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call panggildata()
        Form1.Hide()
    End Sub
    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        sqlnya = "delete from tb_orang where nama= '" & cari.Text & "'"
        Call jalan()
        MsgBox("Data Berhasil Terhapus")
        cari.Text = " "
        Call panggildata()
    End Sub

    Private Sub cari_TextChanged(sender As Object, e As EventArgs) Handles cari.TextChanged
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_orang where nama like'%" & cari.Text & "%'", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_orang")
        DataGridView1.DataSource = DS.Tables("tb_orang")
    End Sub
    Private Sub DataGridView1_RowHeaderMouseClick_1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cari.Text = DataGridView1.Item(0, i).Value
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class