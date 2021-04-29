Imports MySql.Data.MySqlClient
Imports DevExpress.XtraReports.UI
Imports DevExpress.LookAndFeel
Public Class PembayaranForm
    Dim conn As MySqlConnection = Form1.connection
    Dim command As MySqlCommand
    Dim pembayaranInnerAdapter As MySqlDataAdapter
    Dim PembayaranInnerDataSet As DataSet
    Dim siswaAdapter As MySqlDataAdapter
    Dim siswaDataSet As DataSet = New DataSet()
    Dim idSppSiswa As String
    Dim SelectedRow As Integer = 0
    Private Sub PembayaranForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Spp_3PembayaranViewDataSet.pembayaraninner' table. You can move, or remove it, as needed.

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        RefreshTable()

        'ADD Field Petugas



        'ADD ITEM NISN

        siswaAdapter = New MySqlDataAdapter("SELECT * FROM siswa", conn)
        siswaAdapter.Fill(siswaDataSet)
        For i As Integer = 0 To siswaDataSet.Tables(0).Rows.Count - 1
            Fnisn.Items.Add(siswaDataSet.Tables(0).Rows.Item(i).Item(0).ToString())
        Next




    End Sub

    Sub RefreshTable()
        PembayaranInnerDataSet = New DataSet()
        pembayaranInnerAdapter = New MySqlDataAdapter("SELECT
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
", conn)
        pembayaranInnerAdapter.Fill(PembayaranInnerDataSet)
        GridControl1.DataSource = PembayaranInnerDataSet
        GridControl1.DataMember = "Table"
    End Sub
    Sub SettingTopLevel(bool As Boolean)
        Me.SetTopLevel(bool)
    End Sub

    Private Sub Fnisn_SelectedValueChanged(sender As Object, e As EventArgs) Handles Fnisn.SelectedValueChanged
        siswaDataSet.Tables.Clear()
        siswaAdapter = New MySqlDataAdapter("SELECT * FROM siswa WHERE NISN = '" + Fnisn.Text + "' ", conn)
        siswaAdapter.Fill(siswaDataSet)
        Fnama.Text = siswaDataSet.Tables(0).Rows.Item(0).Item(2).ToString()

        'Add Field Nominal
        Dim nominalDataAdapter As MySqlDataAdapter
        Dim nominalDataSet As DataSet = New DataSet()
        nominalDataAdapter = New MySqlDataAdapter("SELECT a.nominal,b.id_spp FROM spp AS a INNER JOIN siswa AS b ON b.id_spp = a.id_spp WHERE b.NISN = '" + Fnisn.Text + "' ", conn)
        nominalDataAdapter.Fill(nominalDataSet)
        Fnominal.Text = nominalDataSet.Tables.Item(0).Rows.Item(0).Item(0).ToString()
        FjumlahBayar.Text = nominalDataSet.Tables.Item(0).Rows.Item(0).Item(0).ToString()
        idSppSiswa = nominalDataSet.Tables.Item(0).Rows.Item(0).Item(1).ToString()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        DataPanel.Visible = False
    End Sub

    Private Sub NewDataButton_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NewDataButton.LinkPressed
        DataPanel.Visible = True
        FnamaPetugas.Text = Form1.Nama.Caption.Split(": ").Last()
        Fnisn.Enabled = True
        Fnisn.Text = ""
        Fnama.Text = ""
        Fnominal.Text = ""
        FjumlahBayar.Text = ""
        FbulanBayar.Text = ""
        Fdate.Enabled = False
        EditDataButton.Enabled = False
        AddDataButton.Enabled = True
        Fdate.Enabled = True
        Fdate.Value = Today



    End Sub

    Private Sub Print_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles Print.LinkPressed
        Dim myReport As XtraReport = New PembayaranReport()
        Dim dataSetSiswa As DataSet = New DataSet()
        Dim siswaNISN As String = GridView1.GetDataRow(SelectedRow).Item(1).ToString()
        Dim dateComplete As String
        Dim tahun As String = GridView1.GetDataRow(SelectedRow).Item(5).ToString().Split("/").Last().Split(" ").First()
        Dim bulan As String = GridView1.GetDataRow(SelectedRow).Item(5).ToString().Split("/")(1)
        Dim tanggal As String = GridView1.GetDataRow(SelectedRow).Item(5).ToString().Split("/").First()
        dateComplete = tahun + "-" + bulan + "-" + tanggal
        'MessageBox.Show("NISN = " + siswaNISN + " date = " + dateComplete)
        Dim dataAdapter As MySqlDataAdapter = New MySqlDataAdapter("SELECT
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
pembayaran.nisn =  '" + siswaNISN + "' AND
pembayaran.tgl_bayar =  '" + dateComplete + "'
", conn)
        dataAdapter.Fill(dataSetSiswa)
        myReport.DataSource = dataSetSiswa
        myReport.DataMember = "Table"
        Dim printTool As New ReportPrintTool(myReport)
        printTool.ShowPreview()
    End Sub

    Private Sub AddDataButton_Click(sender As Object, e As EventArgs) Handles AddDataButton.Click
        If Fnisn.Text = "" Or FtahunBayar.Text = "" Or FbulanBayar.Text = "" Then
            MessageBox.Show("Mohon isi Semua Form Yang Ada")
        Else
            Dim dateComplete As String
            dateComplete = Fdate.Value.Year.ToString() + "-" + Fdate.Value.Month.ToString() + "-" + Fdate.Value.Day.ToString()
            command = New MySqlCommand("INSERT INTO pembayaran(id_petugas,nisn,tgl_bayar,bulan_dibayar,tahun_dibayar,id_spp,jumlah_bayar) VALUES('" + Form1.idPetugas + "','" + Fnisn.Text + "','" + dateComplete + "','" + FbulanBayar.Text + "','" + FtahunBayar.Text + "','" + idSppSiswa + "','" + FjumlahBayar.Text + "')", conn)
            command.ExecuteNonQuery()
            DataPanel.Visible = False
            MessageBox.Show("Data Berhasil Ditambahkan")
            GridControl1.DataSource = New DataSet()
            RefreshTable()
        End If




    End Sub

    Private Sub EditButton_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles EditButton.LinkPressed
        DataPanel.Visible = True
        FnamaPetugas.Text = Form1.Nama.Caption.Split(": ").Last()
        Fnisn.Text = GridView1.GetDataRow(SelectedRow).Item(1).ToString()
        Fdate.Enabled = True
        FbulanBayar.Text = GridView1.GetDataRow(SelectedRow).Item(6).ToString()
        FtahunBayar.Enabled = True
        FtahunBayar.Text = GridView1.GetDataRow(SelectedRow).Item(7).ToString()
        Fdate.Value = GridView1.GetDataRow(SelectedRow).Item(5)
        FidPembayaran.Text = GridView1.GetDataRow(SelectedRow).Item(0)
        MessageBox.Show(Today.ToString())
        EditDataButton.Enabled = True
        AddDataButton.Enabled = False
        Fnisn.Enabled = False

    End Sub

    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        SelectedRow = e.RowHandle
    End Sub

    Private Sub EditDataButton_Click(sender As Object, e As EventArgs) Handles EditDataButton.Click
        If Fnisn.Text = "" Or FtahunBayar.Text = "" Or FbulanBayar.Text = "" Then
            MessageBox.Show("Mohon Isi Semua Form Yang Ada")
        Else
            Dim dateComplete As String
            dateComplete = Fdate.Value.Year.ToString() + "-" + Fdate.Value.Month.ToString() + "-" + Fdate.Value.Day.ToString()
            command = New MySqlCommand("UPDATE pembayaran SET id_petugas = '" + Form1.idPetugas + "',tgl_bayar = '" + dateComplete + "', bulan_dibayar = '" + FbulanBayar.Text + "',tahun_dibayar = '" + FtahunBayar.Text + "' WHERE id_pembayaran = '" + FidPembayaran.Text + "' ", conn)
            command.ExecuteNonQuery()
            DataPanel.Visible = False
            MessageBox.Show("Data Berhasil Diubah")
            RefreshTable()
        End If

    End Sub

    Private Sub DeleteButton_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles DeleteButton.LinkPressed
        Dim dResult As DialogResult = MessageBox.Show("Hapus Data Dengan id_pembayaran: " + GridView1.GetDataRow(SelectedRow).Item(0).ToString(), "Konfirmasi Penghapusan", MessageBoxButtons.YesNo)
        If dResult = DialogResult.Yes Then
            command = New MySqlCommand("DELETE FROM pembayaran WHERE id_pembayaran = '" + GridView1.GetDataRow(SelectedRow).Item(0).ToString() + "' ", conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus")
            RefreshTable()
        End If
    End Sub
End Class