Imports MySql.Data.MySqlClient
Public Class KelasForm
    Dim conn As MySqlConnection = Form1.connection
    Dim command As MySqlCommand
    Dim selectedRow As Integer = 0
    Private Sub KelasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Spp_3KelasDataSet.kelas' table. You can move, or remove it, as needed.
        Me.KelasTableAdapter.Fill(Me.Spp_3KelasDataSet.kelas)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If


    End Sub

    Sub SettingTopLevel(bool As Boolean)
        Me.SetTopLevel(bool)
    End Sub

    Sub RefreshData()
        Me.KelasTableAdapter.Fill(Me.Spp_3KelasDataSet.kelas)
    End Sub

    Sub EnabledAllField(bool As Boolean)
        FnamaKelas.Enabled = bool
        FkompetensiKeahlian.Enabled = bool

    End Sub

    Sub ClearAllField()
        FnamaKelas.Text = ""
        FkompetensiKeahlian.Text = ""
    End Sub

    Private Sub NewDataButton_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NewDataButton.LinkPressed
        DataPanel.Visible = True
        AddDataButton.Enabled = True
        EnabledAllField(True)
    End Sub

    Private Sub AddDataButton_Click(sender As Object, e As EventArgs) Handles AddDataButton.Click
        If FnamaKelas.Text = "" Or FkompetensiKeahlian.Text = "" Then
            MessageBox.Show("Mohon Isi Form Yang Tersedia")
        Else
            command = New MySqlCommand("INSERT INTO kelas(nama_kelas,kompetensi_keahlian) VALUES('" + FnamaKelas.Text + "','" + FkompetensiKeahlian.Text + "') ", conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Ditambahkan")
            RefreshData()
            EnabledAllField(False)
            AddDataButton.Enabled = False

        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        DataPanel.Visible = False
    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        selectedRow = e.RowHandle
    End Sub

    Private Sub EditButton_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles EditButton.LinkPressed
        EnabledAllField(True)
        EditDataButton.Enabled = True
        FidKelas.Text = GridView1.GetDataRow(selectedRow).Item(0).ToString()
        FnamaKelas.Text = GridView1.GetDataRow(selectedRow).Item(1).ToString()
        FkompetensiKeahlian.Text = GridView1.GetDataRow(selectedRow).Item(2).ToString()
        DataPanel.Visible = True
    End Sub

    Private Sub EditDataButton_Click(sender As Object, e As EventArgs) Handles EditDataButton.Click
        If FnamaKelas.Text = "" Or FkompetensiKeahlian.Text = "" Then
            MessageBox.Show("Field Tidak Boleh Ada Yang Kosong")
        Else
            command = New MySqlCommand("UPDATE kelas SET nama_kelas = '" + FnamaKelas.Text + "',kompetensi_keahlian = '" + FkompetensiKeahlian.Text + "' WHERE id_kelas = '" + FidKelas.Text + "'", conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Edit Data Berhasil")
            RefreshData()
            EnabledAllField(False)
            EditDataButton.Enabled = False
        End If
    End Sub

    Private Sub DeleteButton_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles DeleteButton.LinkPressed
        Dim dResult As DialogResult = MessageBox.Show("Hapus Data Dengan id_Kelas: " + GridView1.GetDataRow(selectedRow).Item(0).ToString(), "Konfirmasi Penghapusan", MessageBoxButtons.YesNo)
        If dResult = DialogResult.Yes Then
            command = New MySqlCommand("DELETE FROM kelas WHERE id_kelas = '" + FidKelas.Text + "' ", conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus")
            RefreshData()
        End If
    End Sub
End Class