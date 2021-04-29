Imports MySql.Data.MySqlClient
Public Class HistorySiswaForm
    Dim conn As MySqlConnection = Form1.connection

    Sub SettingTopLevel(bool As Boolean)
        Me.SetTopLevel(bool)
    End Sub

    Private Sub HistorySiswaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim dataAdapter As MySqlDataAdapter
        Dim siswaDataSet As DataSet = New DataSet()
        dataAdapter = New MySqlDataAdapter("SELECT
spp_3.pembayaran.id_pembayaran,
spp_3.siswa.NISN,
spp_3.siswa.nis,
spp_3.siswa.nama,
spp_3.petugas.nama_petugas,
spp_3.pembayaran.tgl_bayar,
spp_3.pembayaran.bulan_dibayar,
spp_3.pembayaran.tahun_dibayar,
spp_3.spp.nominal,
spp_3.pembayaran.jumlah_bayar
FROM
spp_3.pembayaran
Inner Join spp_3.petugas ON spp_3.pembayaran.id_petugas = spp_3.petugas.id_petugas
Inner Join spp_3.siswa ON spp_3.pembayaran.nisn = spp_3.siswa.NISN
Inner Join spp_3.spp ON spp_3.pembayaran.id_spp = spp_3.spp.id_spp
WHERE
pembayaran.nisn =  '" + Form1.siswaNISN + "'
", conn)
        dataAdapter.Fill(siswaDataSet)
        GridControl1.DataSource = siswaDataSet
        GridControl1.DataMember = "Table"
    End Sub
End Class