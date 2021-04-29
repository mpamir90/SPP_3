<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PetugasForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PetugasForm))
        Me.ScreenPanel = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PanelEditing = New System.Windows.Forms.Panel()
        Me.Flevel = New System.Windows.Forms.ComboBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.EditDataButton = New DevExpress.XtraEditors.SimpleButton()
        Me.AddDataButton = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FnamaPetugas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fpassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fusername = New System.Windows.Forms.TextBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.PetugasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Spp_3PetugasDataSet = New SPP_3.spp_3PetugasDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colusername = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpassword = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnama_petugas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collevel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PetugasTableAdapter = New SPP_3.spp_3PetugasDataSetTableAdapters.petugasTableAdapter()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.DataManage = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NewDataButton = New DevExpress.XtraNavBar.NavBarItem()
        Me.EditButton = New DevExpress.XtraNavBar.NavBarItem()
        Me.DeleteButton = New DevExpress.XtraNavBar.NavBarItem()
        Me.ScreenPanel.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.PanelEditing.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spp_3PetugasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScreenPanel
        '
        Me.ScreenPanel.Controls.Add(Me.SplitContainer1)
        Me.ScreenPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScreenPanel.Location = New System.Drawing.Point(0, 0)
        Me.ScreenPanel.Name = "ScreenPanel"
        Me.ScreenPanel.Size = New System.Drawing.Size(900, 481)
        Me.ScreenPanel.TabIndex = 0
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.PanelEditing)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(900, 481)
        Me.SplitContainer1.SplitterDistance = 201
        Me.SplitContainer1.TabIndex = 0
        '
        'PanelEditing
        '
        Me.PanelEditing.Controls.Add(Me.Flevel)
        Me.PanelEditing.Controls.Add(Me.SimpleButton1)
        Me.PanelEditing.Controls.Add(Me.EditDataButton)
        Me.PanelEditing.Controls.Add(Me.AddDataButton)
        Me.PanelEditing.Controls.Add(Me.Label6)
        Me.PanelEditing.Controls.Add(Me.Label5)
        Me.PanelEditing.Controls.Add(Me.FnamaPetugas)
        Me.PanelEditing.Controls.Add(Me.Label4)
        Me.PanelEditing.Controls.Add(Me.Fpassword)
        Me.PanelEditing.Controls.Add(Me.Label3)
        Me.PanelEditing.Controls.Add(Me.Label2)
        Me.PanelEditing.Controls.Add(Me.Label1)
        Me.PanelEditing.Controls.Add(Me.Fusername)
        Me.PanelEditing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEditing.Location = New System.Drawing.Point(0, 0)
        Me.PanelEditing.Name = "PanelEditing"
        Me.PanelEditing.Size = New System.Drawing.Size(695, 481)
        Me.PanelEditing.TabIndex = 1
        Me.PanelEditing.Visible = False
        '
        'Flevel
        '
        Me.Flevel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Flevel.FormattingEnabled = True
        Me.Flevel.Items.AddRange(New Object() {"petugas", "admin"})
        Me.Flevel.Location = New System.Drawing.Point(144, 226)
        Me.Flevel.Name = "Flevel"
        Me.Flevel.Size = New System.Drawing.Size(81, 21)
        Me.Flevel.TabIndex = 13
        Me.Flevel.Text = "petugas"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(648, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(35, 23)
        Me.SimpleButton1.TabIndex = 12
        '
        'EditDataButton
        '
        Me.EditDataButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EditDataButton.ImageOptions.Image = CType(resources.GetObject("EditDataButton.ImageOptions.Image"), System.Drawing.Image)
        Me.EditDataButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.EditDataButton.Location = New System.Drawing.Point(399, 278)
        Me.EditDataButton.Name = "EditDataButton"
        Me.EditDataButton.Size = New System.Drawing.Size(153, 32)
        Me.EditDataButton.TabIndex = 11
        Me.EditDataButton.Text = "Edit Data"
        '
        'AddDataButton
        '
        Me.AddDataButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddDataButton.ImageOptions.Image = CType(resources.GetObject("AddDataButton.ImageOptions.Image"), System.Drawing.Image)
        Me.AddDataButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.AddDataButton.Location = New System.Drawing.Point(171, 278)
        Me.AddDataButton.Name = "AddDataButton"
        Me.AddDataButton.Size = New System.Drawing.Size(153, 32)
        Me.AddDataButton.TabIndex = 10
        Me.AddDataButton.Text = "Add Data"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(78, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Level"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nama Petugas"
        '
        'FnamaPetugas
        '
        Me.FnamaPetugas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FnamaPetugas.Location = New System.Drawing.Point(144, 185)
        Me.FnamaPetugas.Name = "FnamaPetugas"
        Me.FnamaPetugas.Size = New System.Drawing.Size(471, 20)
        Me.FnamaPetugas.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password"
        '
        'Fpassword
        '
        Me.Fpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Fpassword.Location = New System.Drawing.Point(144, 138)
        Me.Fpassword.Name = "Fpassword"
        Me.Fpassword.Size = New System.Drawing.Size(471, 20)
        Me.Fpassword.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI Semilight", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(240, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'Fusername
        '
        Me.Fusername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Fusername.Location = New System.Drawing.Point(144, 97)
        Me.Fusername.Name = "Fusername"
        Me.Fusername.Size = New System.Drawing.Size(471, 20)
        Me.Fusername.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.PetugasBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(695, 481)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PetugasBindingSource
        '
        Me.PetugasBindingSource.DataMember = "petugas"
        Me.PetugasBindingSource.DataSource = Me.Spp_3PetugasDataSet
        '
        'Spp_3PetugasDataSet
        '
        Me.Spp_3PetugasDataSet.DataSetName = "spp_3PetugasDataSet"
        Me.Spp_3PetugasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GridView1.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GridView1.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GridView1.Appearance.Preview.Options.UseBackColor = True
        Me.GridView1.Appearance.Preview.Options.UseFont = True
        Me.GridView1.Appearance.Preview.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GridView1.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.Options.UseBorderColor = True
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colusername, Me.colpassword, Me.colnama_petugas, Me.collevel})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsPrint.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.PaintStyleName = "Web"
        '
        'colusername
        '
        Me.colusername.FieldName = "username"
        Me.colusername.Name = "colusername"
        Me.colusername.Visible = True
        Me.colusername.VisibleIndex = 0
        '
        'colpassword
        '
        Me.colpassword.FieldName = "password"
        Me.colpassword.Name = "colpassword"
        Me.colpassword.Visible = True
        Me.colpassword.VisibleIndex = 1
        '
        'colnama_petugas
        '
        Me.colnama_petugas.FieldName = "nama_petugas"
        Me.colnama_petugas.Name = "colnama_petugas"
        Me.colnama_petugas.OptionsEditForm.Caption = "nama petugas:"
        Me.colnama_petugas.Visible = True
        Me.colnama_petugas.VisibleIndex = 2
        '
        'collevel
        '
        Me.collevel.FieldName = "level"
        Me.collevel.Name = "collevel"
        Me.collevel.Visible = True
        Me.collevel.VisibleIndex = 3
        '
        'PetugasTableAdapter
        '
        Me.PetugasTableAdapter.ClearBeforeFill = True
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.DataManage
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.DataManage})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NewDataButton, Me.EditButton, Me.DeleteButton})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 201
        Me.NavBarControl1.Size = New System.Drawing.Size(201, 481)
        Me.NavBarControl1.TabIndex = 4
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
        'PetugasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 481)
        Me.Controls.Add(Me.ScreenPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PetugasForm"
        Me.Text = "PetugasForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ScreenPanel.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.PanelEditing.ResumeLayout(False)
        Me.PanelEditing.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spp_3PetugasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ScreenPanel As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Spp_3PetugasDataSet As spp_3PetugasDataSet
    Friend WithEvents PetugasBindingSource As BindingSource
    Friend WithEvents PetugasTableAdapter As spp_3PetugasDataSetTableAdapters.petugasTableAdapter
    Friend WithEvents colusername As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpassword As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnama_petugas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collevel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelEditing As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Fusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FnamaPetugas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Fpassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EditDataButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AddDataButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Flevel As ComboBox
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents DataManage As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NewDataButton As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents EditButton As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents DeleteButton As DevExpress.XtraNavBar.NavBarItem
End Class
