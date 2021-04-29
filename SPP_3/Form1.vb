
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraReports.UI
Public Class Form1
    Public connection As MySqlConnection
    Public idPetugas As String
    Public siswaNISN As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection("server=localhost;user id=root;database=spp_3")
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

    End Sub

    Function Koneksi() As MySqlConnection
        connection = New MySqlConnection("server=localhost;user id=root;database=spp_3")
        If connection.State = ConnectionState.Closed Then
            connection.Open()
            Return connection
        End If
        Return connection
    End Function


    Private Sub ScreenPanel_Click(sender As Object, e As EventArgs) Handles ScreenPanel.Click


    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles LoginBarItem.ItemClick
        Panel2.SendToBack()
        ScreenPanel.Controls.Clear()
        ScreenPanel.Controls.Add(LoginForm.ScreenPanel)
    End Sub

    Private Sub PetugasBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PetugasBar.ItemClick
        PetugasForm.Dispose()
        ScreenPanel.Controls.Clear()
        PetugasForm.TopMost = True
        PetugasForm.SettingTopLevel()
        ScreenPanel.Controls.Add(PetugasForm)
        PetugasForm.Show()

    End Sub

    Private Sub LogoutBarItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles LogoutBarItem.ItemClick
        'DefaultPanel.SendToBack()
        ScreenPanel.SendToBack()
        Status.Caption = "Status: "
        Nama.Caption = "Nama: "
        DatabasePage.Visible = False
        ScreenPanel.Controls.Clear()
        LogoutBarItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        LoginBarItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

    End Sub

    Private Sub SiswaBarButton_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SiswaBarButton.ItemClick
        SiswaForm.Dispose()
        ScreenPanel.Controls.Clear()
        SiswaForm.SettingTopLevel(False)
        ScreenPanel.Controls.Add(SiswaForm)
        SiswaForm.Show()

    End Sub

    Private Sub KelasItemBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles KelasItemBar.ItemClick
        KelasForm.Dispose()
        ScreenPanel.Controls.Clear()
        KelasForm.SettingTopLevel(False)
        ScreenPanel.Controls.Add(KelasForm)
        KelasForm.Show()
    End Sub

    Private Sub SppBarButton_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SppBarButton.ItemClick
        SppForm.Dispose()
        ScreenPanel.Controls.Clear()
        SppForm.SettingTopLevel(False)
        ScreenPanel.Controls.Add(SppForm)
        SppForm.Show()
    End Sub

    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PembayaranItemBar.ItemClick
        PembayaranForm.Dispose()
        ScreenPanel.Controls.Clear()
        ScreenPanel.Dock = DockStyle.Fill
        PembayaranForm.SettingTopLevel(False)
        ScreenPanel.Controls.Add(PembayaranForm)
        PembayaranForm.Show()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles HistoryBarItem.ItemClick
        HistorySiswaForm.Dispose()
        ScreenPanel.Controls.Clear()
        HistorySiswaForm.SettingTopLevel(False)
        ScreenPanel.Controls.Add(HistorySiswaForm)
        HistorySiswaForm.Show()
    End Sub

    Private Sub DefaultPanel_Click(sender As Object, e As EventArgs) Handles DefaultPanel.Click

    End Sub
End Class
