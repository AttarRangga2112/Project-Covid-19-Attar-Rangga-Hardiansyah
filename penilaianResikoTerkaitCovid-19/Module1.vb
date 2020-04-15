Imports System.Data
Imports System.Data.OleDb
Module Module1
    Public sqlnya As String
    Public y As Integer
    Public t As Integer
    Public jt As Integer
    Public js As Integer
    Public jr As Integer
    Public hasil As String
    Public jk As String
    Public conn As OleDbConnection
    Public CMD As OleDbCommand
    Public DS As New DataSet
    Public DA As OleDbDataAdapter
    Public RD As OleDbDataReader
    Public lokasidata As String


    Public Sub konek()
        lokasidata = "provider=microsoft.jet.oledb.4.0;data source=datab.mdb"
        conn = New OleDbConnection(lokasidata)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Public Sub panggildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_orang", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_orang")
        table.DataGridView1.DataSource = DS.Tables("tb_orang")
        table.DataGridView1.Enabled = True
    End Sub
    Public Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sqlnya
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
    End Sub
    Public Sub resikot()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_orang where resiko like'%" & tabelresiko.Label1.Text & "%'", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_orang")
        tabelresiko.DataGridView1.DataSource = DS.Tables("tb_orang")
        jt = tabelresiko.DataGridView1.RowCount - 1
    End Sub
    Public Sub resikos()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_orang where resiko like'%" & tabelresiko.Label2.Text & "%'", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_orang")
        tabelresiko.DataGridView2.DataSource = DS.Tables("tb_orang")
        js = tabelresiko.DataGridView2.RowCount - 1
    End Sub
    Public Sub resikor()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_orang where resiko like'%" & tabelresiko.Label3.Text & "%'", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_orang")
        tabelresiko.DataGridView3.DataSource = DS.Tables("tb_orang")
        jr = tabelresiko.DataGridView3.RowCount - 1
    End Sub
End Module
