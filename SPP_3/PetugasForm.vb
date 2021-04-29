Imports MySql.Data.MySqlClient
Public Class PetugasForm
    Dim selectedRows As Integer = 0

    Public conn As MySqlConnection = Form1.connection
    Dim command As MySqlCommand
    Private Sub PetugasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Spp_3PetugasDataSet.petugas' table. You can move, or remove it, as needed.
        Me.PetugasTableAdapter.Fill(Me.Spp_3PetugasDataSet.petugas)
        Me.WindowState = FormWindowState.Maximized
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

    End Sub

    Sub UpdateGrid()
        GridControl1.Update()
        Me.PetugasTableAdapter.Fill(Me.Spp_3PetugasDataSet.petugas)
    End Sub


    Sub SettingTopLevel()
        Me.SetTopLevel(False)
    End Sub

    Sub EnabledField(bool As Boolean)
        Fusername.Enabled = bool
        Fpassword.Enabled = bool
        FnamaPetugas.Enabled = bool
        Flevel.Enabled = bool
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        selectedRows = e.RowHandle

    End Sub

    Private Sub PanelEditing_Paint(sender As Object, e As PaintEventArgs) Handles PanelEditing.Paint

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles FnamaPetugas.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub AddDataButton_Click(sender As Object, e As EventArgs) Handles AddDataButton.Click
        If Fusername.Text = "" Or Fpassword.Text = "" Or FnamaPetugas.Text = "" Or Flevel.Text = "" Then
            MessageBox.Show("Form Tidak Boleh Ada Yang Kosong")
        Else
            command = New MySqlCommand("INSERT INTO petugas(username,password,nama_petugas,level) VALUES ('" + Fusername.Text + "','" + Fpassword.Text + "','" + FnamaPetugas.Text + "','" + Flevel.Text + "')", conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Berhasil Ditambahkan")
            EnabledField(False)
            AddDataButton.Enabled = False
            UpdateGrid()

        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Fpassword.TextChanged

    End Sub

    Private Sub NewDataButton_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NewDataButton.LinkPressed
        EditDataButton.Enabled = False
        PanelEditing.BringToFront()
        EnabledField(True)
        ClearAllField()
        PanelEditing.Visible = True
    End Sub

    Private Sub ClearAllField()
        Fusername.Clear()
        Fpassword.Clear()
        FnamaPetugas.Clear()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        PanelEditing.Visible = False
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles Flevel.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub DeleteButton_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles DeleteButton.LinkPressed
        Dim dialogResult As DialogResult = MessageBox.Show("Hapus Data Dengan Username: " + GridView1.GetDataRow(selectedRows).Item(0).ToString(), "Konfirmasi Penghapusan Data", MessageBoxButtons.YesNo)
        If dialogResult = DialogResult.Yes Then
            command = New MySqlCommand("DELETE FROM petugas WHERE username = '" + GridView1.GetDataRow(selectedRows).Item(0).ToString() + "'", conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus")
            Me.PetugasTableAdapter.Fill(Me.Spp_3PetugasDataSet.petugas)
            UpdateGrid()
        End If


    End Sub

    Private Sub EditButton_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles EditButton.LinkPressed
        PanelEditing.BringToFront()
        EditDataButton.Enabled = True
        AddDataButton.Enabled = False
        PanelEditing.Visible = True
        Fusername.Text = GridView1.GetDataRow(selectedRows).Item(0).ToString()
        Fpassword.Text = GridView1.GetDataRow(selectedRows).Item(1).ToString()
        FnamaPetugas.Text = GridView1.GetDataRow(selectedRows).Item(2).ToString()
        Flevel.Text = GridView1.GetDataRow(selectedRows).Item(3).ToString()
        EnabledField(True)
    End Sub

    Private Sub EditDataButton_Click(sender As Object, e As EventArgs) Handles EditDataButton.Click
        If Fusername.Text = "" Or Fpassword.Text = "" Or FnamaPetugas.Text = "" Or Flevel.Text = "" Then
            MessageBox.Show("Form Tidak Boleh Ada Yang Kosong")
        Else
            command = New MySqlCommand("UPDATE petugas SET username = '" + Fusername.Text + "',password = '" + Fpassword.Text + "',nama_petugas = '" + FnamaPetugas.Text + "',level = '" + Flevel.Text + "' WHERE username = '" + Fusername.Text + "'", conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Di Update")
            EnabledField(False)
            EditDataButton.Enabled = False
            UpdateGrid()
        End If
    End Sub
End Class