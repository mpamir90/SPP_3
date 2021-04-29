<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KelasForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KelasForm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataPanel = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.EditDataButton = New DevExpress.XtraEditors.SimpleButton()
        Me.AddDataButton = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FkompetensiKeahlian = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FnamaKelas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FidKelas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.KelasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Spp_3KelasDataSet = New SPP_3.spp_3KelasDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid_kelas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnama_kelas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkompetensi_keahlian = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.KelasTableAdapter = New SPP_3.spp_3KelasDataSetTableAdapters.kelasTableAdapter()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.DataManage = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NewDataButton = New DevExpress.XtraNavBar.NavBarItem()
        Me.EditButton = New DevExpress.XtraNavBar.NavBarItem()
        Me.DeleteButton = New DevExpress.XtraNavBar.NavBarItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.DataPanel.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spp_3KelasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(904, 564)
        Me.SplitContainer1.SplitterDistance = 301
        Me.SplitContainer1.TabIndex = 0
        '
        'DataPanel
        '
        Me.DataPanel.Controls.Add(Me.SimpleButton1)
        Me.DataPanel.Controls.Add(Me.EditDataButton)
        Me.DataPanel.Controls.Add(Me.AddDataButton)
        Me.DataPanel.Controls.Add(Me.Label5)
        Me.DataPanel.Controls.Add(Me.FkompetensiKeahlian)
        Me.DataPanel.Controls.Add(Me.Label4)
        Me.DataPanel.Controls.Add(Me.FnamaKelas)
        Me.DataPanel.Controls.Add(Me.Label3)
        Me.DataPanel.Controls.Add(Me.FidKelas)
        Me.DataPanel.Controls.Add(Me.Label2)
        Me.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataPanel.Location = New System.Drawing.Point(0, 0)
        Me.DataPanel.Name = "DataPanel"
        Me.DataPanel.Size = New System.Drawing.Size(599, 564)
        Me.DataPanel.TabIndex = 2
        Me.DataPanel.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(538, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(35, 23)
        Me.SimpleButton1.TabIndex = 16
        '
        'EditDataButton
        '
        Me.EditDataButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EditDataButton.Enabled = False
        Me.EditDataButton.ImageOptions.Image = CType(resources.GetObject("EditDataButton.ImageOptions.Image"), System.Drawing.Image)
        Me.EditDataButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.EditDataButton.Location = New System.Drawing.Point(337, 266)
        Me.EditDataButton.Name = "EditDataButton"
        Me.EditDataButton.Size = New System.Drawing.Size(153, 32)
        Me.EditDataButton.TabIndex = 15
        Me.EditDataButton.Text = "Edit Data"
        '
        'AddDataButton
        '
        Me.AddDataButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddDataButton.Enabled = False
        Me.AddDataButton.ImageOptions.Image = CType(resources.GetObject("AddDataButton.ImageOptions.Image"), System.Drawing.Image)
        Me.AddDataButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.AddDataButton.Location = New System.Drawing.Point(109, 266)
        Me.AddDataButton.Name = "AddDataButton"
        Me.AddDataButton.Size = New System.Drawing.Size(153, 32)
        Me.AddDataButton.TabIndex = 14
        Me.AddDataButton.Text = "Add Data"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 19)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Kompetensi Keahlian"
        '
        'FkompetensiKeahlian
        '
        Me.FkompetensiKeahlian.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FkompetensiKeahlian.Enabled = False
        Me.FkompetensiKeahlian.Location = New System.Drawing.Point(180, 211)
        Me.FkompetensiKeahlian.Name = "FkompetensiKeahlian"
        Me.FkompetensiKeahlian.Size = New System.Drawing.Size(407, 20)
        Me.FkompetensiKeahlian.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "nama_kelas"
        '
        'FnamaKelas
        '
        Me.FnamaKelas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FnamaKelas.Enabled = False
        Me.FnamaKelas.Location = New System.Drawing.Point(180, 164)
        Me.FnamaKelas.Name = "FnamaKelas"
        Me.FnamaKelas.Size = New System.Drawing.Size(407, 20)
        Me.FnamaKelas.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "id_kelas"
        '
        'FidKelas
        '
        Me.FidKelas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FidKelas.Enabled = False
        Me.FidKelas.Location = New System.Drawing.Point(180, 123)
        Me.FidKelas.Name = "FidKelas"
        Me.FidKelas.Size = New System.Drawing.Size(43, 20)
        Me.FidKelas.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI Semilight", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.KelasBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(599, 564)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'KelasBindingSource
        '
        Me.KelasBindingSource.DataMember = "kelas"
        Me.KelasBindingSource.DataSource = Me.Spp_3KelasDataSet
        '
        'Spp_3KelasDataSet
        '
        Me.Spp_3KelasDataSet.DataSetName = "spp_3KelasDataSet"
        Me.Spp_3KelasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid_kelas, Me.colnama_kelas, Me.colkompetensi_keahlian})
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
        'colid_kelas
        '
        Me.colid_kelas.FieldName = "id_kelas"
        Me.colid_kelas.Name = "colid_kelas"
        Me.colid_kelas.Visible = True
        Me.colid_kelas.VisibleIndex = 0
        '
        'colnama_kelas
        '
        Me.colnama_kelas.FieldName = "nama_kelas"
        Me.colnama_kelas.Name = "colnama_kelas"
        Me.colnama_kelas.Visible = True
        Me.colnama_kelas.VisibleIndex = 1
        '
        'colkompetensi_keahlian
        '
        Me.colkompetensi_keahlian.FieldName = "kompetensi_keahlian"
        Me.colkompetensi_keahlian.Name = "colkompetensi_keahlian"
        Me.colkompetensi_keahlian.Visible = True
        Me.colkompetensi_keahlian.VisibleIndex = 2
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'KelasTableAdapter
        '
        Me.KelasTableAdapter.ClearBeforeFill = True
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.DataManage
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.DataManage})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NewDataButton, Me.EditButton, Me.DeleteButton})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 301
        Me.NavBarControl1.Size = New System.Drawing.Size(301, 564)
        Me.NavBarControl1.TabIndex = 3
        Me.NavBarControl1.Text = "NavBarControl1"
        Me.NavBarControl1.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("DevExpress Style")
        '
        'DataManage
        '
        Me.DataManage.Caption = "Data Manage"
        Me.DataManage.Expanded = True
        Me.DataManage.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NewDataButton), New DevExpress.XtraNavBar.NavBarItemLink(Me.EditButton), New DevExpress.XtraNavBar.NavBarItemLink(Me.DeleteButton)})
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
        'KelasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 564)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "KelasForm"
        Me.Text = "KelasForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.DataPanel.ResumeLayout(False)
        Me.DataPanel.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spp_3KelasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Spp_3KelasDataSet As spp_3KelasDataSet
    Friend WithEvents KelasBindingSource As BindingSource
    Friend WithEvents KelasTableAdapter As spp_3KelasDataSetTableAdapters.kelasTableAdapter
    Friend WithEvents DataPanel As Panel
    Friend WithEvents colid_kelas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnama_kelas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkompetensi_keahlian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FkompetensiKeahlian As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FnamaKelas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FidKelas As TextBox
    Friend WithEvents EditDataButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AddDataButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents DataManage As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NewDataButton As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents EditButton As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents DeleteButton As DevExpress.XtraNavBar.NavBarItem
End Class
