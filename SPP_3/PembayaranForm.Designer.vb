<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PembayaranForm
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PembayaranForm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.DataManage = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NewDataButton = New DevExpress.XtraNavBar.NavBarItem()
        Me.EditButton = New DevExpress.XtraNavBar.NavBarItem()
        Me.DeleteButton = New DevExpress.XtraNavBar.NavBarItem()
        Me.Print = New DevExpress.XtraNavBar.NavBarItem()
        Me.DataPanel = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FjumlahBayar = New System.Windows.Forms.TextBox()
        Me.FbulanBayar = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FtahunBayar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Fdate = New System.Windows.Forms.DateTimePicker()
        Me.Fnominal = New System.Windows.Forms.TextBox()
        Me.Fnisn = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fnama = New System.Windows.Forms.ComboBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FnamaPetugas = New System.Windows.Forms.TextBox()
        Me.FidPembayaran = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.EditDataButton = New DevExpress.XtraEditors.SimpleButton()
        Me.AddDataButton = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataPanel.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.NavBarControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(881, 546)
        Me.SplitContainer1.SplitterDistance = 174
        Me.SplitContainer1.TabIndex = 0
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.DataManage
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.DataManage})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NewDataButton, Me.EditButton, Me.DeleteButton, Me.Print})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 174
        Me.NavBarControl1.Size = New System.Drawing.Size(174, 546)
        Me.NavBarControl1.TabIndex = 2
        Me.NavBarControl1.Text = "NavBarControl1"
        Me.NavBarControl1.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("DevExpress Style")
        '
        'DataManage
        '
        Me.DataManage.Caption = "Data Manage"
        Me.DataManage.Expanded = True
        Me.DataManage.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NewDataButton), New DevExpress.XtraNavBar.NavBarItemLink(Me.EditButton), New DevExpress.XtraNavBar.NavBarItemLink(Me.DeleteButton), New DevExpress.XtraNavBar.NavBarItemLink(Me.Print)})
        Me.DataManage.Name = "DataManage"
        '
        'NewDataButton
        '
        Me.NewDataButton.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold)
        Me.NewDataButton.Appearance.Options.UseFont = True
        Me.NewDataButton.Caption = "New Data"
        Me.NewDataButton.ImageOptions.SvgImage = CType(resources.GetObject("NewDataButton.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.NewDataButton.Name = "NewDataButton"
        '
        'EditButton
        '
        Me.EditButton.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold)
        Me.EditButton.Appearance.Options.UseFont = True
        Me.EditButton.Caption = "Edit Data"
        Me.EditButton.ImageOptions.SvgImage = CType(resources.GetObject("EditButton.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.EditButton.Name = "EditButton"
        '
        'DeleteButton
        '
        Me.DeleteButton.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold)
        Me.DeleteButton.Appearance.Options.UseFont = True
        Me.DeleteButton.Caption = "Delete Data"
        Me.DeleteButton.ImageOptions.SvgImage = CType(resources.GetObject("DeleteButton.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.DeleteButton.Name = "DeleteButton"
        '
        'Print
        '
        Me.Print.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Print.Appearance.Options.UseFont = True
        Me.Print.Caption = "Print"
        Me.Print.ImageOptions.SvgImage = CType(resources.GetObject("Print.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Print.Name = "Print"
        '
        'DataPanel
        '
        Me.DataPanel.Controls.Add(Me.EditDataButton)
        Me.DataPanel.Controls.Add(Me.AddDataButton)
        Me.DataPanel.Controls.Add(Me.Label10)
        Me.DataPanel.Controls.Add(Me.FjumlahBayar)
        Me.DataPanel.Controls.Add(Me.FbulanBayar)
        Me.DataPanel.Controls.Add(Me.Label9)
        Me.DataPanel.Controls.Add(Me.FtahunBayar)
        Me.DataPanel.Controls.Add(Me.Label8)
        Me.DataPanel.Controls.Add(Me.Fdate)
        Me.DataPanel.Controls.Add(Me.Fnominal)
        Me.DataPanel.Controls.Add(Me.Fnisn)
        Me.DataPanel.Controls.Add(Me.Label4)
        Me.DataPanel.Controls.Add(Me.Fnama)
        Me.DataPanel.Controls.Add(Me.SimpleButton1)
        Me.DataPanel.Controls.Add(Me.Label7)
        Me.DataPanel.Controls.Add(Me.Label6)
        Me.DataPanel.Controls.Add(Me.Label5)
        Me.DataPanel.Controls.Add(Me.Label3)
        Me.DataPanel.Controls.Add(Me.Label2)
        Me.DataPanel.Controls.Add(Me.FnamaPetugas)
        Me.DataPanel.Controls.Add(Me.FidPembayaran)
        Me.DataPanel.Controls.Add(Me.Label1)
        Me.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataPanel.Location = New System.Drawing.Point(0, 0)
        Me.DataPanel.Name = "DataPanel"
        Me.DataPanel.Size = New System.Drawing.Size(703, 546)
        Me.DataPanel.TabIndex = 3
        Me.DataPanel.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(360, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Jumlah Bayar"
        '
        'FjumlahBayar
        '
        Me.FjumlahBayar.Enabled = False
        Me.FjumlahBayar.Location = New System.Drawing.Point(440, 264)
        Me.FjumlahBayar.Name = "FjumlahBayar"
        Me.FjumlahBayar.Size = New System.Drawing.Size(150, 20)
        Me.FjumlahBayar.TabIndex = 33
        '
        'FbulanBayar
        '
        Me.FbulanBayar.FormattingEnabled = True
        Me.FbulanBayar.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.FbulanBayar.Location = New System.Drawing.Point(440, 216)
        Me.FbulanBayar.Name = "FbulanBayar"
        Me.FbulanBayar.Size = New System.Drawing.Size(150, 21)
        Me.FbulanBayar.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(76, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Tahun Bayar"
        '
        'FtahunBayar
        '
        Me.FtahunBayar.Location = New System.Drawing.Point(161, 258)
        Me.FtahunBayar.Name = "FtahunBayar"
        Me.FtahunBayar.Size = New System.Drawing.Size(150, 20)
        Me.FtahunBayar.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(362, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Bulan Bayar"
        '
        'Fdate
        '
        Me.Fdate.CustomFormat = ""
        Me.Fdate.Enabled = False
        Me.Fdate.Location = New System.Drawing.Point(161, 210)
        Me.Fdate.Name = "Fdate"
        Me.Fdate.Size = New System.Drawing.Size(150, 20)
        Me.Fdate.TabIndex = 27
        Me.Fdate.Value = New Date(2021, 3, 14, 0, 0, 0, 0)
        '
        'Fnominal
        '
        Me.Fnominal.Enabled = False
        Me.Fnominal.Location = New System.Drawing.Point(311, 323)
        Me.Fnominal.Name = "Fnominal"
        Me.Fnominal.Size = New System.Drawing.Size(150, 20)
        Me.Fnominal.TabIndex = 26
        '
        'Fnisn
        '
        Me.Fnisn.FormattingEnabled = True
        Me.Fnisn.Location = New System.Drawing.Point(161, 148)
        Me.Fnisn.Name = "Fnisn"
        Me.Fnisn.Size = New System.Drawing.Size(150, 21)
        Me.Fnisn.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(162, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Nominal Yang Harus Dibayar"
        '
        'Fnama
        '
        Me.Fnama.Enabled = False
        Me.Fnama.FormattingEnabled = True
        Me.Fnama.Location = New System.Drawing.Point(440, 156)
        Me.Fnama.Name = "Fnama"
        Me.Fnama.Size = New System.Drawing.Size(150, 21)
        Me.Fnama.TabIndex = 22
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(628, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(35, 23)
        Me.SimpleButton1.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(113, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "NISN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(360, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "nama petugas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "tgl bayar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(393, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "id pembayaran"
        '
        'FnamaPetugas
        '
        Me.FnamaPetugas.Enabled = False
        Me.FnamaPetugas.Location = New System.Drawing.Point(440, 95)
        Me.FnamaPetugas.Name = "FnamaPetugas"
        Me.FnamaPetugas.Size = New System.Drawing.Size(150, 20)
        Me.FnamaPetugas.TabIndex = 2
        '
        'FidPembayaran
        '
        Me.FidPembayaran.Enabled = False
        Me.FidPembayaran.Location = New System.Drawing.Point(161, 94)
        Me.FidPembayaran.Name = "FidPembayaran"
        Me.FidPembayaran.Size = New System.Drawing.Size(150, 20)
        Me.FidPembayaran.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(273, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Pembayaran"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(703, 546)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tempus Sans ITC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GridView1.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GridView1.Appearance.Preview.Options.UseBackColor = True
        Me.GridView1.Appearance.Preview.Options.UseFont = True
        Me.GridView1.Appearance.Preview.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsPrint.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsPrint.EnableAppearanceOddRow = True
        Me.GridView1.OptionsPrint.PrintVertLines = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PaintStyleName = "Web"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'EditDataButton
        '
        Me.EditDataButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EditDataButton.Enabled = False
        Me.EditDataButton.ImageOptions.Image = CType(resources.GetObject("EditDataButton.ImageOptions.Image"), System.Drawing.Image)
        Me.EditDataButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.EditDataButton.Location = New System.Drawing.Point(401, 387)
        Me.EditDataButton.Name = "EditDataButton"
        Me.EditDataButton.Size = New System.Drawing.Size(153, 32)
        Me.EditDataButton.TabIndex = 36
        Me.EditDataButton.Text = "Edit Data"
        '
        'AddDataButton
        '
        Me.AddDataButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddDataButton.Enabled = False
        Me.AddDataButton.ImageOptions.Image = CType(resources.GetObject("AddDataButton.ImageOptions.Image"), System.Drawing.Image)
        Me.AddDataButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.AddDataButton.Location = New System.Drawing.Point(173, 387)
        Me.AddDataButton.Name = "AddDataButton"
        Me.AddDataButton.Size = New System.Drawing.Size(153, 32)
        Me.AddDataButton.TabIndex = 35
        Me.AddDataButton.Text = "Add Data"
        '
        'PembayaranForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 546)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PembayaranForm"
        Me.Text = "PembayaranForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataPanel.ResumeLayout(False)
        Me.DataPanel.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents DataManage As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NewDataButton As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents EditButton As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents DeleteButton As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents Print As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents DataPanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Fnama As ComboBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FnamaPetugas As TextBox
    Friend WithEvents FidPembayaran As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Fnisn As ComboBox
    Friend WithEvents Fdate As DateTimePicker
    Friend WithEvents Fnominal As TextBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents FtahunBayar As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents FjumlahBayar As TextBox
    Friend WithEvents FbulanBayar As ComboBox
    Friend WithEvents EditDataButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AddDataButton As DevExpress.XtraEditors.SimpleButton
End Class
