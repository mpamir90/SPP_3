<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.LoginBarItem = New DevExpress.XtraBars.BarButtonItem()
        Me.LogoutBarItem = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.PetugasBar = New DevExpress.XtraBars.BarButtonItem()
        Me.SiswaBarButton = New DevExpress.XtraBars.BarButtonItem()
        Me.KelasItemBar = New DevExpress.XtraBars.BarButtonItem()
        Me.SppBarButton = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.PembayaranItemBar = New DevExpress.XtraBars.BarButtonItem()
        Me.HistoryBarItem = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.DatabasePage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.TablesGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.TransaksiPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.StatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.Nama = New DevExpress.XtraBars.BarHeaderItem()
        Me.Status = New DevExpress.XtraBars.BarStaticItem()
        Me.ScreenPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DefaultPanel = New System.Windows.Forms.Panel()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ScreenPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.LoginBarItem, Me.LogoutBarItem, Me.BarStaticItem2, Me.PetugasBar, Me.SiswaBarButton, Me.KelasItemBar, Me.SppBarButton, Me.BarButtonItem1, Me.PembayaranItemBar, Me.HistoryBarItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 13
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.DatabasePage})
        Me.RibbonControl1.Size = New System.Drawing.Size(872, 158)
        Me.RibbonControl1.StatusBar = Me.StatusBar
        '
        'LoginBarItem
        '
        Me.LoginBarItem.Caption = "Login"
        Me.LoginBarItem.Id = 1
        Me.LoginBarItem.ImageOptions.SvgImage = CType(resources.GetObject("LoginBarItem.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.LoginBarItem.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.LoginBarItem.ItemAppearance.Normal.Options.UseFont = True
        Me.LoginBarItem.Name = "LoginBarItem"
        '
        'LogoutBarItem
        '
        Me.LogoutBarItem.Caption = "Logout"
        Me.LogoutBarItem.Id = 2
        Me.LogoutBarItem.ImageOptions.SvgImage = CType(resources.GetObject("LogoutBarItem.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.LogoutBarItem.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.LogoutBarItem.ItemAppearance.Normal.Options.UseFont = True
        Me.LogoutBarItem.Name = "LogoutBarItem"
        Me.LogoutBarItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "BarStaticItem2"
        Me.BarStaticItem2.Id = 5
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'PetugasBar
        '
        Me.PetugasBar.Caption = "Petugas"
        Me.PetugasBar.Id = 6
        Me.PetugasBar.ImageOptions.SvgImage = CType(resources.GetObject("PetugasBar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.PetugasBar.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PetugasBar.ItemAppearance.Normal.Options.UseFont = True
        Me.PetugasBar.Name = "PetugasBar"
        '
        'SiswaBarButton
        '
        Me.SiswaBarButton.Caption = "Siswa"
        Me.SiswaBarButton.Id = 7
        Me.SiswaBarButton.ImageOptions.SvgImage = CType(resources.GetObject("SiswaBarButton.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SiswaBarButton.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SiswaBarButton.ItemAppearance.Normal.Options.UseFont = True
        Me.SiswaBarButton.Name = "SiswaBarButton"
        '
        'KelasItemBar
        '
        Me.KelasItemBar.Caption = "Kelas"
        Me.KelasItemBar.Id = 8
        Me.KelasItemBar.ImageOptions.SvgImage = CType(resources.GetObject("KelasItemBar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.KelasItemBar.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.KelasItemBar.ItemAppearance.Normal.Options.UseFont = True
        Me.KelasItemBar.Name = "KelasItemBar"
        '
        'SppBarButton
        '
        Me.SppBarButton.Caption = "Spp"
        Me.SppBarButton.Id = 9
        Me.SppBarButton.ImageOptions.SvgImage = CType(resources.GetObject("SppBarButton.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SppBarButton.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SppBarButton.ItemAppearance.Normal.Options.UseFont = True
        Me.SppBarButton.Name = "SppBarButton"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Pembayaran"
        Me.BarButtonItem1.Id = 10
        Me.BarButtonItem1.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'PembayaranItemBar
        '
        Me.PembayaranItemBar.Caption = "Pembayaran"
        Me.PembayaranItemBar.Id = 11
        Me.PembayaranItemBar.ImageOptions.SvgImage = CType(resources.GetObject("PembayaranItemBar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.PembayaranItemBar.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PembayaranItemBar.ItemAppearance.Normal.Options.UseFont = True
        Me.PembayaranItemBar.Name = "PembayaranItemBar"
        '
        'HistoryBarItem
        '
        Me.HistoryBarItem.Caption = "Hitory Pembayaran"
        Me.HistoryBarItem.Id = 12
        Me.HistoryBarItem.ImageOptions.SvgImage = CType(resources.GetObject("HistoryBarItem.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.HistoryBarItem.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.HistoryBarItem.ItemAppearance.Normal.Options.UseFont = True
        Me.HistoryBarItem.Name = "HistoryBarItem"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Akun"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.LoginBarItem)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.LogoutBarItem)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Login"
        '
        'DatabasePage
        '
        Me.DatabasePage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.TablesGroup, Me.TransaksiPageGroup})
        Me.DatabasePage.Name = "DatabasePage"
        Me.DatabasePage.Text = "Master"
        Me.DatabasePage.Visible = False
        '
        'TablesGroup
        '
        Me.TablesGroup.ItemLinks.Add(Me.PetugasBar)
        Me.TablesGroup.ItemLinks.Add(Me.SiswaBarButton)
        Me.TablesGroup.ItemLinks.Add(Me.KelasItemBar)
        Me.TablesGroup.ItemLinks.Add(Me.SppBarButton)
        Me.TablesGroup.Name = "TablesGroup"
        Me.TablesGroup.Text = "Tables"
        '
        'TransaksiPageGroup
        '
        Me.TransaksiPageGroup.ItemLinks.Add(Me.PembayaranItemBar)
        Me.TransaksiPageGroup.ItemLinks.Add(Me.HistoryBarItem)
        Me.TransaksiPageGroup.Name = "TransaksiPageGroup"
        Me.TransaksiPageGroup.Text = "Transaksi"
        '
        'StatusBar
        '
        Me.StatusBar.ItemLinks.Add(Me.Nama)
        Me.StatusBar.ItemLinks.Add(Me.Status)
        Me.StatusBar.Location = New System.Drawing.Point(0, 479)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Ribbon = Me.RibbonControl1
        Me.StatusBar.Size = New System.Drawing.Size(872, 24)
        '
        'Nama
        '
        Me.Nama.Caption = "Nama: "
        Me.Nama.Id = 3
        Me.Nama.Name = "Nama"
        '
        'Status
        '
        Me.Status.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.Status.Caption = "Status:"
        Me.Status.Id = 4
        Me.Status.Name = "Status"
        '
        'ScreenPanel
        '
        Me.ScreenPanel.Controls.Add(Me.Panel2)
        Me.ScreenPanel.Controls.Add(Me.DefaultPanel)
        Me.ScreenPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScreenPanel.Location = New System.Drawing.Point(0, 158)
        Me.ScreenPanel.Name = "ScreenPanel"
        Me.ScreenPanel.Size = New System.Drawing.Size(872, 345)
        Me.ScreenPanel.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.BackgroundImage = Global.SPP_3.My.Resources.Resources.Financial_Manage2
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(872, 345)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Location = New System.Drawing.Point(649, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(223, 79)
        Me.Panel3.TabIndex = 2
        '
        'DefaultPanel
        '
        Me.DefaultPanel.BackColor = System.Drawing.Color.AliceBlue
        Me.DefaultPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DefaultPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DefaultPanel.Location = New System.Drawing.Point(0, 0)
        Me.DefaultPanel.Name = "DefaultPanel"
        Me.DefaultPanel.Size = New System.Drawing.Size(872, 345)
        Me.DefaultPanel.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 503)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.ScreenPanel)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "Form1"
        Me.Ribbon = Me.RibbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.StatusBar
        Me.Text = "Aplikasi Pembayaran SPP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ScreenPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LoginBarItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LogoutBarItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ScreenPanel As Panel
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents StatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents Nama As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents Status As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents PetugasBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SiswaBarButton As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DatabasePage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents TablesGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents KelasItemBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SppBarButton As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PembayaranItemBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TransaksiPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents HistoryBarItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DefaultPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
