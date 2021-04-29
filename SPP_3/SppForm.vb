Imports MySql.Data.MySqlClient
Public Class SppForm
    Dim conn As MySqlConnection = New MySqlConnection("server=localhost;user id=root;database=spp_3")
    Dim command As MySqlCommand
    Dim selectedRow As Integer = 0
    Private Sub SppForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Spp_3SppDataSet.spp' table. You can move, or remove it, as needed.
        Me.SppTableAdapter.Fill(Me.Spp_3SppDataSet.spp)
        conn.Open()

    End Sub

    Sub ClearAllField()
        FidSpp.Text = ""
        Ftahun.Text = ""
        Fnominal.Text = ""
    End Sub

    Sub EnabledAllField(bool As Boolean)

        Ftahun.Enabled = bool
        Fnominal.Enabled = bool
    End Sub

    Sub RefreshData()
        Me.SppTableAdapter.Fill(Me.Spp_3SppDataSet.spp)
    End Sub
    Sub SettingTopLevel(bool As Boolean)
        Me.SetTopLevel(bool)
    End Sub


    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        selectedRow = e.RowHandle
    End Sub

    Private Sub NewDataButton_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NewDataButton.LinkPressed
        DataPanel.Visible = True
        AddDataButton.Enabled = True
        EditDataButton.Enabled = False
        ClearAllField()
        EnabledAllField(True)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        DataPanel.Visible = False
    End Sub

    Private Sub EditButton_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles EditButton.LinkPressed
        DataPanel.Visible = True
        FidSpp.Text = GridView1.GetDataRow(selectedRow).Item(0).ToString()
        Ftahun.Text = GridView1.GetDataRow(selectedRow).Item(1).ToString()
        Fnominal.Text = GridView1.GetDataRow(selectedRow).Item(2).ToString()
        EditDataButton.Enabled = True
        EnabledAllField(True)

    End Sub

    Private Sub AddDataButton_Click(sender As Object, e As EventArgs) Handles AddDataButton.Click
        If Ftahun.Text = "" Or Fnominal.Text = "" Then
            MessageBox.Show("Mohon Isi Semua Form Yang Ada")
        Else
            command = New MySqlCommand("INSERT INTO spp(tahun,nominal) VALUES ('" + Ftahun.Text + "','" + Fnominal.Text + "')", conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Ditambahkan")
            AddDataButton.Enabled = False
            EnabledAllField(False)
            RefreshData()
        End If
    End Sub

    Private Sub EditDataButton_Click(sender As Object, e As EventArgs) Handles EditDataButton.Click
        If Ftahun.Text = "" Or Fnominal.Text = "" Then
            MessageBox.Show("Mohon Isi Semua Form Yang Ada")

        Else
            command = New MySqlCommand("UPDATE spp SET tahun = '" + Ftahun.Text + "',nominal = '" + Fnominal.Text + "' WHERE id_spp = '" + FidSpp.Text + "'", conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Update Data Berhasil")
            RefreshData()
            EnabledAllField(False)
            EditDataButton.Enabled = False
        End If
    End Sub

    Private Sub DeleteButton_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles DeleteButton.LinkPressed
        Dim dResult As DialogResult = MessageBox.Show("Hapus Data Dengan id_spp: " + GridView1.GetDataRow(selectedRow).Item(0).ToString(), "Konfirmasi Penghapusan Data", MessageBoxButtons.YesNo)
        If dResult = DialogResult.Yes Then
            command = New MySqlCommand("DELETE FROM spp WHERE id_spp = '" + GridView1.GetDataRow(selectedRow).Item(0).ToString() + "'", conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Delete Data Berhasil")
            RefreshData()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        DataPanel.Visible = False

    End Sub
End Class