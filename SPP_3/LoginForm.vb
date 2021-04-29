Imports MySql.Data.MySqlClient
Public Class LoginForm
    Dim dataReader As MySqlDataReader
    Dim connection As MySqlConnection = Form1.connection
    Dim dataAdapter As MySqlDataAdapter
    Dim dataSet As DataSet
    Dim siswaDataAdapter As MySqlDataAdapter
    Dim siswaDataSet As DataSet

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        dataSet = New DataSet()

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        dataAdapter = New MySqlDataAdapter("SELECT * FROM petugas WHERE username = '" + Username.Text + "' AND password = '" + Password.Text + "'", connection)
        dataAdapter.Fill(dataSet)

        If dataSet.Tables.Item(0).Rows.Count = 1 Then
            Form1.ScreenPanel.Controls.Clear()
            Form1.LoginBarItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Form1.LogoutBarItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Form1.DatabasePage.Visible = True
            Form1.Nama.Caption = "Nama: " + dataSet.Tables.Item(0).Rows.Item(0).Item(3).ToString()
            Form1.idPetugas = dataSet.Tables.Item(0).Rows.Item(0).Item(0).ToString()
            Form1.Status.Caption = "Status: " + dataSet.Tables.Item(0).Rows.Item(0).Item(4).ToString()
            Form1.HistoryBarItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Form1.DatabasePage.Visible = True
            If dataSet.Tables.Item(0).Rows.Item(0).Item(4).ToString() = "petugas" Then
                Form1.TablesGroup.Visible = False
                Form1.PembayaranItemBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                Form1.HistoryBarItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else
                Form1.TablesGroup.Visible = True
                Form1.PembayaranItemBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If

        Else
            MessageBox.Show("Data Tidak Ditemukan")
        End If

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

    End Sub

    Private Sub LoginSiswa_Click(sender As Object, e As EventArgs) Handles LoginSiswa.Click
        siswaDataSet = New DataSet()
        If Fnisn.Text = "" Then
            MessageBox.Show("Form NISN Tidak Boleh Kosong")
        Else
            siswaDataAdapter = New MySqlDataAdapter("SELECT * FROM siswa WHERE NISN = '" + Fnisn.Text + "' AND password = '" + FpasswordSiswa.Text + "'", connection)
            siswaDataAdapter.Fill(siswaDataSet)
            If siswaDataSet.Tables.Item(0).Rows.Count > 0 Then
                Form1.TablesGroup.Visible = False
                Form1.PembayaranItemBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Form1.Nama.Caption = "Nama: " + siswaDataSet.Tables.Item(0).Rows.Item(0).Item(2).ToString()
                Form1.Status.Caption = "Status: siswa"
                Form1.siswaNISN = siswaDataSet.Tables.Item(0).Rows.Item(0).Item(0).ToString()
                Form1.TransaksiPageGroup.Visible = True
                Form1.HistoryBarItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                Form1.LoginBarItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Form1.LogoutBarItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                Form1.DatabasePage.Visible = True
                Form1.ScreenPanel.Controls.Clear()
            End If
        End If
    End Sub

    Private Sub LoginLabel_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub LoginLabel_Click_1(sender As Object, e As EventArgs) Handles LoginLabel.Click

    End Sub
End Class