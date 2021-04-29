Imports MySql.Data.MySqlClient
Public Class SiswaForm
    Dim conn As MySqlConnection = Form1.Koneksi()
    Dim dataAdapter As MySqlDataAdapter
    Dim siswaDataSet As DataSet
    Dim command As MySqlCommand
    Dim kelasDataAdapter As MySqlDataAdapter
    Dim kelasDataSet As DataSet = New DataSet()
    Dim sppDataAdapter As MySqlDataAdapter
    Dim sppDataSet As DataSet = New DataSet()
    Dim selectedRow As Integer = 0
    Sub SettingTopLevel(bool As Boolean)
        Me.SetTopLevel(bool)
    End Sub

    Sub SetEnabledField(bool As Boolean)
        Fnisn.Enabled = bool
        Fnama.Enabled = bool
        FidKelas.Enabled = bool
        Fnis.Enabled = bool
        FidSpp.Enabled = bool
        FnoTelpon.Enabled = bool

        Falamat.Enabled = bool
    End Sub
    Sub ClearAllField()
        Fnisn.Text = ""
        Fnama.Text = ""
        FidKelas.Text = ""
        Fnis.Text = ""
        FidSpp.Text = ""
        FnoTelpon.Text = ""
    End Sub
    Sub RefreshData()
        Me.SiswaTableAdapter.Fill(Me.Spp_3SiswaDataSet.siswa)
    End Sub
    Private Sub SiswaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Spp_3SiswaDataSet.siswa' table. You can move, or remove it, as needed.
        Me.SiswaTableAdapter.Fill(Me.Spp_3SiswaDataSet.siswa)
        'TODO: This line of code loads data into the 'Spp_3SiswaDataSet.siswa' table. You can move, or remove it, as needed.

        'conn = New MySqlConnection("server=localhost;user id=root;database=spp_3")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        kelasDataAdapter = New MySqlDataAdapter("SELECT * FROM kelas", conn)
        kelasDataAdapter.Fill(kelasDataSet)
        For i As Integer = 0 To kelasDataSet.Tables.Item(0).Rows.Count - 1
            FidKelas.Items.Add(kelasDataSet.Tables.Item(0).Rows.Item(i).Item(1).ToString() + " / " + kelasDataSet.Tables.Item(0).Rows.Item(i).Item(0).ToString())
        Next

        sppDataAdapter = New MySqlDataAdapter("SELECT * FROM spp", conn)
        sppDataAdapter.Fill(sppDataSet)
        For i As Integer = 0 To sppDataSet.Tables.Item(0).Rows.Count - 1
            FidSpp.Items.Add(sppDataSet.Tables.Item(0).Rows.Item(i).Item(2).ToString() + " - " + sppDataSet.Tables.Item(0).Rows.Item(i).Item(1).ToString() + "/" + sppDataSet.Tables.Item(0).Rows.Item(i).Item(0).ToString())


        Next



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles DataPanel.Paint


    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        DataPanel.Visible = False
    End Sub

    Private Sub NewDataButton_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NewDataButton.LinkPressed
        SetEnabledField(True)
        AddDataButton.Enabled = True
        EditDataButton.Enabled = False
        DataPanel.Visible = True
        ClearAllField()

    End Sub

    Private Sub AddDataButton_Click(sender As Object, e As EventArgs) Handles AddDataButton.Click
        If Fnis.Text = "" Or Fnama.Text = "" Or FidKelas.Text = "" Or FnoTelpon.Text = "" Or Falamat.Text = "" Or FidSpp.Text = "" Then
            MessageBox.Show("Mohon Lengkapi Semua Form Yang Ada")
        Else
            command = New MySqlCommand("INSERT INTO siswa VALUES('" + Fnisn.Text + "','" + Fnis.Text + "','" + Fnama.Text + "','" + FidKelas.Text.Split(" ").Last() + "','" + Falamat.Text + "','" + FnoTelpon.Text + "','" + FidSpp.Text.Split("/").Last() + "')", conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Ditambahkan")
            SetEnabledField(False)
            AddDataButton.Enabled = False
            RefreshData()
        End If
    End Sub



    Private Sub NavBarControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        selectedRow = e.RowHandle

    End Sub

    Private Sub EditButton_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles EditButton.LinkPressed
        SetEnabledField(True)
        AddDataButton.Enabled = False
        DataPanel.Visible = True
        EditDataButton.Enabled = True
        Fnisn.Text = GridView1.GetDataRow(selectedRow).Item(0).ToString()
        Fnis.Text = GridView1.GetDataRow(selectedRow).Item(1).ToString()
        Fnama.Text = GridView1.GetDataRow(selectedRow).Item(2).ToString()
        FidKelas.Text = GridView1.GetDataRow(selectedRow).Item(3).ToString()
        Falamat.Text = GridView1.GetDataRow(selectedRow).Item(4).ToString()
        FnoTelpon.Text = GridView1.GetDataRow(selectedRow).Item(5).ToString()
        FidSpp.Text = GridView1.GetDataRow(selectedRow).Item(6).ToString()


    End Sub

    Private Sub EditDataButton_Click(sender As Object, e As EventArgs) Handles EditDataButton.Click
        If Fnis.Text = "" Or Fnama.Text = "" Or FidKelas.Text = "" Or FnoTelpon.Text = "" Or Falamat.Text = "" Or FidSpp.Text = "" Then
            MessageBox.Show("Mohon Isi Semua Form Yang Ada")
        Else
            command = New MySqlCommand("UPDATE siswa SET NISN = '" + Fnisn.Text + "',nis = '" + Fnis.Text + "',nama = '" + Fnama.Text + "',id_kelas = '" + FidKelas.Text.Split(" ").Last() + "',alamat = '" + Falamat.Text + "',no_telp = '" + FnoTelpon.Text + "',id_spp = '" + FidSpp.Text.Split("/").Last() + "' WHERE NISN = '" + Fnisn.Text + "' ", conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Update Data Berhasil")
            SetEnabledField(False)
            EditDataButton.Enabled = False
            RefreshData()
        End If
    End Sub

    Private Sub DeleteButton_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles DeleteButton.LinkPressed
        Dim dResult As DialogResult = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Dengan Nama " + GridView1.GetDataRow(selectedRow).Item(2).ToString(), "Konfirmasi Penghapusan Data", MessageBoxButtons.YesNo)
        If dResult = DialogResult.Yes Then
            command = New MySqlCommand("DELETE FROM siswa WHERE NISN = '" + GridView1.GetDataRow(selectedRow).Item(0).ToString() + "'", conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus")
            RefreshData()
        End If
    End Sub

    Private Sub Fnisn_KeyUp(sender As Object, e As KeyEventArgs) Handles Fnisn.KeyUp
        If Integer.TryParse(Fnisn.Text, True) Then

        Else
            MessageBox.Show("NISN Harus Berupa Angka")
            Fnis.Text = ""
        End If
    End Sub

    Private Sub Fnama_KeyUp(sender As Object, e As KeyEventArgs) Handles Fnama.KeyUp

    End Sub

    Private Sub Fnis_TextChanged(sender As Object, e As EventArgs) Handles Fnis.TextChanged
        If Integer.TryParse(Fnis.Text, True) Then

        Else
            MessageBox.Show("nis Harus Berupa Angka")
        End If
    End Sub

    Private Sub Fnama_TextChanged(sender As Object, e As EventArgs) Handles Fnama.TextChanged

    End Sub

    Private Sub FnoTelpon_TextChanged(sender As Object, e As EventArgs) Handles FnoTelpon.TextChanged
        If Integer.TryParse(FnoTelpon.Text, True) Then
        Else

            MessageBox.Show("Nomer Telpon Tidak Boleh Mengandung Huruf")
        End If
    End Sub

    Private Sub Fnama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Fnama.KeyPress
        Dim AllowChar As String = "abcdefghijklmnopqrstuvwxyz"
        If Fnama.Text = "" Then
        Else
            If AllowChar.Contains(e.KeyChar.ToString().ToLower()) Then
            Else
                MessageBox.Show("Nama Harus Alfabet")
                e.Handled = False
                Fnama.Text = ""
            End If
        End If
    End Sub
End Class