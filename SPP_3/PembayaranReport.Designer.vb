<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PembayaranReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PembayaranReport))
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.detailTable = New DevExpress.XtraReports.UI.XRTable()
        Me.detailTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.productName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.quantity = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lineTotal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.thankYouLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vendorLogo2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.headerTable = New DevExpress.XtraReports.UI.XRTable()
        Me.headerTableRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.productDesctiptionCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.quantityCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.unitPriceCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerTable = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.billToLabel = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerNameRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.customerName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerAddressRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.customerAddress = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceInfoTable = New DevExpress.XtraReports.UI.XRTable()
        Me.invoiceInfoTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceInfoTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.totalCaption2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceDateCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceNumberCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceInfoTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.total2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceNumber = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.baseControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.evenDetailStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.oddDetailStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        CType(Me.detailTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headerTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.invoiceInfoTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.detailTable})
        Me.Detail.HeightF = 34.20846!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "baseControlStyle"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'detailTable
        '
        Me.detailTable.EvenStyleName = "evenDetailStyle"
        Me.detailTable.LocationFloat = New DevExpress.Utils.PointFloat(9.99997!, 0!)
        Me.detailTable.Name = "detailTable"
        Me.detailTable.OddStyleName = "oddDetailStyle"
        Me.detailTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.detailTableRow1})
        Me.detailTable.SizeF = New System.Drawing.SizeF(739.9999!, 25.41666!)
        Me.detailTable.StyleName = "evenDetailStyle"
        Me.detailTable.StylePriority.UseBorderColor = False
        Me.detailTable.StylePriority.UseBorders = False
        Me.detailTable.StylePriority.UseFont = False
        '
        'detailTableRow1
        '
        Me.detailTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.productName, Me.XrTableCell3, Me.quantity, Me.lineTotal})
        Me.detailTableRow1.Name = "detailTableRow1"
        Me.detailTableRow1.Weight = 7.5920176355552655R
        '
        'productName
        '
        Me.productName.BorderColor = System.Drawing.Color.White
        Me.productName.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.productName.BorderWidth = 5.0!
        Me.productName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[tgl_bayar]")})
        Me.productName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.productName.Name = "productName"
        Me.productName.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 0, 100.0!)
        Me.productName.StylePriority.UseBackColor = False
        Me.productName.StylePriority.UseBorderColor = False
        Me.productName.StylePriority.UseBorders = False
        Me.productName.StylePriority.UseBorderWidth = False
        Me.productName.StylePriority.UseFont = False
        Me.productName.StylePriority.UsePadding = False
        Me.productName.StylePriority.UseTextAlignment = False
        Me.productName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.productName.TextFormatString = "{0:dd/MM/yyyy}"
        Me.productName.Weight = 0.51686152121416407R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BorderColor = System.Drawing.Color.White
        Me.XrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell3.BorderWidth = 5.0!
        Me.XrTableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[bulan_dibayar]")})
        Me.XrTableCell3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 0, 100.0!)
        Me.XrTableCell3.StylePriority.UseBackColor = False
        Me.XrTableCell3.StylePriority.UseBorderColor = False
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.StylePriority.UseBorderWidth = False
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UsePadding = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "XrTableCell3"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.XrTableCell3.Weight = 0.51686152121416407R
        '
        'quantity
        '
        Me.quantity.BorderColor = System.Drawing.Color.White
        Me.quantity.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.quantity.BorderWidth = 5.0!
        Me.quantity.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[nama_petugas]")})
        Me.quantity.Name = "quantity"
        Me.quantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100.0!)
        Me.quantity.RowSpan = 2
        Me.quantity.StylePriority.UseBackColor = False
        Me.quantity.StylePriority.UseBorderColor = False
        Me.quantity.StylePriority.UseBorders = False
        Me.quantity.StylePriority.UseBorderWidth = False
        Me.quantity.StylePriority.UseFont = False
        Me.quantity.StylePriority.UsePadding = False
        Me.quantity.StylePriority.UseTextAlignment = False
        Me.quantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.quantity.Weight = 0.57545520037438014R
        '
        'lineTotal
        '
        Me.lineTotal.BorderColor = System.Drawing.Color.White
        Me.lineTotal.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lineTotal.BorderWidth = 5.0!
        Me.lineTotal.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[jumlah_bayar]")})
        Me.lineTotal.Name = "lineTotal"
        Me.lineTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 5, 0, 0, 100.0!)
        Me.lineTotal.RowSpan = 2
        Me.lineTotal.StylePriority.UseBackColor = False
        Me.lineTotal.StylePriority.UseBorderColor = False
        Me.lineTotal.StylePriority.UseBorders = False
        Me.lineTotal.StylePriority.UseBorderWidth = False
        Me.lineTotal.StylePriority.UseFont = False
        Me.lineTotal.StylePriority.UseForeColor = False
        Me.lineTotal.StylePriority.UsePadding = False
        Me.lineTotal.StylePriority.UseTextAlignment = False
        Me.lineTotal.Text = "Rp0.00"
        Me.lineTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lineTotal.TextFormatString = "{0:Rp0.00}"
        Me.lineTotal.Weight = 0.45826891765625988R
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 18.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseBackColor = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.thankYouLabel, Me.vendorLogo2})
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.StyleName = "baseControlStyle"
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'thankYouLabel
        '
        Me.thankYouLabel.CanGrow = False
        Me.thankYouLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thankYouLabel.LocationFloat = New DevExpress.Utils.PointFloat(9.999977!, 9.999964!)
        Me.thankYouLabel.Name = "thankYouLabel"
        Me.thankYouLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.thankYouLabel.SizeF = New System.Drawing.SizeF(305.0!, 20.66021!)
        Me.thankYouLabel.StylePriority.UseFont = False
        Me.thankYouLabel.StylePriority.UseForeColor = False
        Me.thankYouLabel.StylePriority.UseTextAlignment = False
        Me.thankYouLabel.Text = "THANK YOU FOR YOUR BUSINESS"
        Me.thankYouLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'vendorLogo2
        '
        Me.vendorLogo2.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopLeft
        Me.vendorLogo2.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource(CType(resources.GetObject("vendorLogo2.ImageSource"), System.Drawing.Image), True)
        Me.vendorLogo2.LocationFloat = New DevExpress.Utils.PointFloat(21.45832!, 39.99999!)
        Me.vendorLogo2.Name = "vendorLogo2"
        Me.vendorLogo2.SizeF = New System.Drawing.SizeF(105.0!, 50.0!)
        Me.vendorLogo2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.vendorLogo2.StylePriority.UseBorderColor = False
        Me.vendorLogo2.StylePriority.UseBorders = False
        Me.vendorLogo2.StylePriority.UsePadding = False
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.headerTable, Me.customerTable, Me.invoiceInfoTable, Me.vendorLogo})
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader2.HeightF = 204.4583!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.StyleName = "baseControlStyle"
        Me.GroupHeader2.StylePriority.UseBackColor = False
        '
        'headerTable
        '
        Me.headerTable.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerTable.LocationFloat = New DevExpress.Utils.PointFloat(9.999974!, 174.4583!)
        Me.headerTable.Name = "headerTable"
        Me.headerTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.headerTableRow})
        Me.headerTable.SizeF = New System.Drawing.SizeF(740.0!, 30.0!)
        Me.headerTable.StylePriority.UseFont = False
        Me.headerTable.StylePriority.UsePadding = False
        '
        'headerTableRow
        '
        Me.headerTableRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.productDesctiptionCaption, Me.XrTableCell1, Me.quantityCaption, Me.unitPriceCaption})
        Me.headerTableRow.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.headerTableRow.Name = "headerTableRow"
        Me.headerTableRow.StylePriority.UseFont = False
        Me.headerTableRow.Weight = 6.8299491460003461R
        '
        'productDesctiptionCaption
        '
        Me.productDesctiptionCaption.Name = "productDesctiptionCaption"
        Me.productDesctiptionCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.productDesctiptionCaption.StylePriority.UseBackColor = False
        Me.productDesctiptionCaption.StylePriority.UseFont = False
        Me.productDesctiptionCaption.StylePriority.UseForeColor = False
        Me.productDesctiptionCaption.StylePriority.UsePadding = False
        Me.productDesctiptionCaption.StylePriority.UseTextAlignment = False
        Me.productDesctiptionCaption.Text = "TANGGAL PEMBAYARAN"
        Me.productDesctiptionCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.productDesctiptionCaption.Weight = 0.45638066371287256R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell1.StylePriority.UseBackColor = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseForeColor = False
        Me.XrTableCell1.StylePriority.UsePadding = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "BULAN BAYAR"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell1.Weight = 0.45638066371287256R
        '
        'quantityCaption
        '
        Me.quantityCaption.Name = "quantityCaption"
        Me.quantityCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100.0!)
        Me.quantityCaption.StylePriority.UseBackColor = False
        Me.quantityCaption.StylePriority.UseFont = False
        Me.quantityCaption.StylePriority.UseForeColor = False
        Me.quantityCaption.StylePriority.UsePadding = False
        Me.quantityCaption.StylePriority.UseTextAlignment = False
        Me.quantityCaption.Text = "NAMA PETUGAS"
        Me.quantityCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.quantityCaption.Weight = 0.50811808425493665R
        '
        'unitPriceCaption
        '
        Me.unitPriceCaption.Name = "unitPriceCaption"
        Me.unitPriceCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.unitPriceCaption.StylePriority.UseBackColor = False
        Me.unitPriceCaption.StylePriority.UseFont = False
        Me.unitPriceCaption.StylePriority.UseForeColor = False
        Me.unitPriceCaption.StylePriority.UsePadding = False
        Me.unitPriceCaption.StylePriority.UseTextAlignment = False
        Me.unitPriceCaption.Text = "JUMLAH BAYAR"
        Me.unitPriceCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.unitPriceCaption.Weight = 0.40464442731024464R
        '
        'customerTable
        '
        Me.customerTable.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.customerTable.LocationFloat = New DevExpress.Utils.PointFloat(9.999982!, 85.50002!)
        Me.customerTable.Name = "customerTable"
        Me.customerTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.customerTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow9, Me.customerNameRow, Me.customerAddressRow})
        Me.customerTable.SizeF = New System.Drawing.SizeF(250.0!, 75.2906!)
        Me.customerTable.StylePriority.UseBorderColor = False
        Me.customerTable.StylePriority.UseBorders = False
        Me.customerTable.StylePriority.UseFont = False
        Me.customerTable.StylePriority.UsePadding = False
        '
        'xrTableRow9
        '
        Me.xrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.billToLabel})
        Me.xrTableRow9.Name = "xrTableRow9"
        Me.xrTableRow9.StylePriority.UseTextAlignment = False
        Me.xrTableRow9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.xrTableRow9.Weight = 1.57098007849591R
        '
        'billToLabel
        '
        Me.billToLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.billToLabel.ForeColor = System.Drawing.Color.Gray
        Me.billToLabel.Name = "billToLabel"
        Me.billToLabel.StylePriority.UseFont = False
        Me.billToLabel.StylePriority.UseForeColor = False
        Me.billToLabel.Text = "NAMA SISWA"
        Me.billToLabel.Weight = 3.0R
        '
        'customerNameRow
        '
        Me.customerNameRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.customerName})
        Me.customerNameRow.Name = "customerNameRow"
        Me.customerNameRow.Weight = 1.1434108833544583R
        '
        'customerName
        '
        Me.customerName.CanShrink = True
        Me.customerName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[nama]")})
        Me.customerName.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.customerName.Name = "customerName"
        Me.customerName.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 5, 0, 100.0!)
        Me.customerName.StylePriority.UseFont = False
        Me.customerName.StylePriority.UsePadding = False
        Me.customerName.StylePriority.UseTextAlignment = False
        Me.customerName.Weight = 3.0R
        '
        'customerAddressRow
        '
        Me.customerAddressRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.customerAddress})
        Me.customerAddressRow.Name = "customerAddressRow"
        Me.customerAddressRow.Weight = 0.98186388967424R
        '
        'customerAddress
        '
        Me.customerAddress.CanShrink = True
        Me.customerAddress.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[alamat]")})
        Me.customerAddress.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerAddress.Name = "customerAddress"
        Me.customerAddress.StylePriority.UseFont = False
        Me.customerAddress.Weight = 3.0R
        '
        'invoiceInfoTable
        '
        Me.invoiceInfoTable.LocationFloat = New DevExpress.Utils.PointFloat(317.4998!, 10.00001!)
        Me.invoiceInfoTable.Name = "invoiceInfoTable"
        Me.invoiceInfoTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.invoiceInfoTableRow1, Me.invoiceInfoTableRow2, Me.invoiceInfoTableRow3})
        Me.invoiceInfoTable.SizeF = New System.Drawing.SizeF(402.7083!, 139.5!)
        '
        'invoiceInfoTableRow1
        '
        Me.invoiceInfoTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell2})
        Me.invoiceInfoTableRow1.Name = "invoiceInfoTableRow1"
        Me.invoiceInfoTableRow1.Weight = 1.0066972757107671R
        '
        'xrTableCell2
        '
        Me.xrTableCell2.BorderColor = System.Drawing.Color.LightGray
        Me.xrTableCell2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrTableCell2.BorderWidth = 5.0!
        Me.xrTableCell2.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.xrTableCell2.Name = "xrTableCell2"
        Me.xrTableCell2.StylePriority.UseBackColor = False
        Me.xrTableCell2.StylePriority.UseBorderColor = False
        Me.xrTableCell2.StylePriority.UseBorders = False
        Me.xrTableCell2.StylePriority.UseBorderWidth = False
        Me.xrTableCell2.StylePriority.UseFont = False
        Me.xrTableCell2.StylePriority.UseForeColor = False
        Me.xrTableCell2.StylePriority.UseTextAlignment = False
        Me.xrTableCell2.Text = "STRUK PEMBAYARAN"
        Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        Me.xrTableCell2.Weight = 2.9597637771210623R
        '
        'invoiceInfoTableRow2
        '
        Me.invoiceInfoTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.totalCaption2, Me.invoiceDateCaption, Me.invoiceNumberCaption})
        Me.invoiceInfoTableRow2.Name = "invoiceInfoTableRow2"
        Me.invoiceInfoTableRow2.Weight = 0.4266795703683301R
        '
        'totalCaption2
        '
        Me.totalCaption2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.totalCaption2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalCaption2.ForeColor = System.Drawing.Color.Gray
        Me.totalCaption2.Name = "totalCaption2"
        Me.totalCaption2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 2, 100.0!)
        Me.totalCaption2.StylePriority.UseBackColor = False
        Me.totalCaption2.StylePriority.UseBorderColor = False
        Me.totalCaption2.StylePriority.UseBorders = False
        Me.totalCaption2.StylePriority.UseFont = False
        Me.totalCaption2.StylePriority.UseForeColor = False
        Me.totalCaption2.StylePriority.UsePadding = False
        Me.totalCaption2.StylePriority.UseTextAlignment = False
        Me.totalCaption2.Text = "TOTAL DUE"
        Me.totalCaption2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.totalCaption2.Weight = 0.98658795657725218R
        '
        'invoiceDateCaption
        '
        Me.invoiceDateCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.invoiceDateCaption.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoiceDateCaption.ForeColor = System.Drawing.Color.Gray
        Me.invoiceDateCaption.Name = "invoiceDateCaption"
        Me.invoiceDateCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 2, 100.0!)
        Me.invoiceDateCaption.StylePriority.UseBackColor = False
        Me.invoiceDateCaption.StylePriority.UseBorders = False
        Me.invoiceDateCaption.StylePriority.UseFont = False
        Me.invoiceDateCaption.StylePriority.UseForeColor = False
        Me.invoiceDateCaption.StylePriority.UsePadding = False
        Me.invoiceDateCaption.StylePriority.UseTextAlignment = False
        Me.invoiceDateCaption.Text = "STRUK DIBUAT"
        Me.invoiceDateCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.invoiceDateCaption.Weight = 0.98658791027190518R
        '
        'invoiceNumberCaption
        '
        Me.invoiceNumberCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.invoiceNumberCaption.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoiceNumberCaption.ForeColor = System.Drawing.Color.Gray
        Me.invoiceNumberCaption.Name = "invoiceNumberCaption"
        Me.invoiceNumberCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 2, 100.0!)
        Me.invoiceNumberCaption.StylePriority.UseBackColor = False
        Me.invoiceNumberCaption.StylePriority.UseBorderColor = False
        Me.invoiceNumberCaption.StylePriority.UseBorders = False
        Me.invoiceNumberCaption.StylePriority.UseFont = False
        Me.invoiceNumberCaption.StylePriority.UseForeColor = False
        Me.invoiceNumberCaption.StylePriority.UsePadding = False
        Me.invoiceNumberCaption.StylePriority.UseTextAlignment = False
        Me.invoiceNumberCaption.Text = "NISN"
        Me.invoiceNumberCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        Me.invoiceNumberCaption.Weight = 0.98658791027190507R
        '
        'invoiceInfoTableRow3
        '
        Me.invoiceInfoTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.total2, Me.invoiceDate, Me.invoiceNumber})
        Me.invoiceInfoTableRow3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.invoiceInfoTableRow3.Name = "invoiceInfoTableRow3"
        Me.invoiceInfoTableRow3.StylePriority.UseFont = False
        Me.invoiceInfoTableRow3.Weight = 0.4266795832360003R
        '
        'total2
        '
        Me.total2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.total2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([jumlah_bayar])")})
        Me.total2.Name = "total2"
        Me.total2.StylePriority.UseBackColor = False
        Me.total2.StylePriority.UseBorderColor = False
        Me.total2.StylePriority.UseBorders = False
        Me.total2.StylePriority.UseFont = False
        Me.total2.StylePriority.UseTextAlignment = False
        Me.total2.Text = "Rp0.00"
        Me.total2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.total2.TextFormatString = "{0:Rp0.00}"
        Me.total2.Weight = 0.98658795657725218R
        '
        'invoiceDate
        '
        Me.invoiceDate.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.invoiceDate.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Today()")})
        Me.invoiceDate.Name = "invoiceDate"
        Me.invoiceDate.StylePriority.UseBackColor = False
        Me.invoiceDate.StylePriority.UseBorders = False
        Me.invoiceDate.StylePriority.UseFont = False
        Me.invoiceDate.StylePriority.UseTextAlignment = False
        Me.invoiceDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.invoiceDate.TextFormatString = "{0:dd MMM yyyy}"
        Me.invoiceDate.Weight = 0.98658791027190518R
        '
        'invoiceNumber
        '
        Me.invoiceNumber.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.invoiceNumber.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.invoiceNumber.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[nisn]")})
        Me.invoiceNumber.Name = "invoiceNumber"
        Me.invoiceNumber.StylePriority.UseBackColor = False
        Me.invoiceNumber.StylePriority.UseBorderColor = False
        Me.invoiceNumber.StylePriority.UseBorders = False
        Me.invoiceNumber.StylePriority.UseFont = False
        Me.invoiceNumber.StylePriority.UseTextAlignment = False
        Me.invoiceNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.invoiceNumber.Weight = 0.98658791027190507R
        '
        'vendorLogo
        '
        Me.vendorLogo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopLeft
        Me.vendorLogo.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource(CType(resources.GetObject("vendorLogo.ImageSource"), System.Drawing.Image), True)
        Me.vendorLogo.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
        Me.vendorLogo.Name = "vendorLogo"
        Me.vendorLogo.SizeF = New System.Drawing.SizeF(250.0!, 75.5!)
        Me.vendorLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.vendorLogo.StylePriority.UseBorderColor = False
        Me.vendorLogo.StylePriority.UseBorders = False
        Me.vendorLogo.StylePriority.UsePadding = False
        '
        'GroupHeader1
        '
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("nisn", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 30.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        Me.GroupHeader1.StyleName = "baseControlStyle"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "localhost_spp_3_Connection 2"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression1.ColumnName = "id_pembayaran"
        Table1.Name = "pembayaraninner"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "nama_petugas"
        ColumnExpression2.Table = Table1
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "level"
        ColumnExpression3.Table = Table1
        Column3.Expression = ColumnExpression3
        ColumnExpression4.ColumnName = "nisn"
        ColumnExpression4.Table = Table1
        Column4.Expression = ColumnExpression4
        ColumnExpression5.ColumnName = "tgl_bayar"
        ColumnExpression5.Table = Table1
        Column5.Expression = ColumnExpression5
        ColumnExpression6.ColumnName = "bulan_dibayar"
        ColumnExpression6.Table = Table1
        Column6.Expression = ColumnExpression6
        ColumnExpression7.ColumnName = "tahun_dibayar"
        ColumnExpression7.Table = Table1
        Column7.Expression = ColumnExpression7
        ColumnExpression8.ColumnName = "tahun"
        ColumnExpression8.Table = Table1
        Column8.Expression = ColumnExpression8
        ColumnExpression9.ColumnName = "nominal"
        ColumnExpression9.Table = Table1
        Column9.Expression = ColumnExpression9
        ColumnExpression10.ColumnName = "jumlah_bayar"
        ColumnExpression10.Table = Table1
        Column10.Expression = ColumnExpression10
        ColumnExpression11.ColumnName = "nama"
        ColumnExpression11.Table = Table1
        Column11.Expression = ColumnExpression11
        ColumnExpression12.ColumnName = "alamat"
        ColumnExpression12.Table = Table1
        Column12.Expression = ColumnExpression12
        ColumnExpression13.ColumnName = "no_telp"
        ColumnExpression13.Table = Table1
        Column13.Expression = ColumnExpression13
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Columns.Add(Column3)
        SelectQuery1.Columns.Add(Column4)
        SelectQuery1.Columns.Add(Column5)
        SelectQuery1.Columns.Add(Column6)
        SelectQuery1.Columns.Add(Column7)
        SelectQuery1.Columns.Add(Column8)
        SelectQuery1.Columns.Add(Column9)
        SelectQuery1.Columns.Add(Column10)
        SelectQuery1.Columns.Add(Column11)
        SelectQuery1.Columns.Add(Column12)
        SelectQuery1.Columns.Add(Column13)
        SelectQuery1.Name = "pembayaraninner"
        SelectQuery1.Tables.Add(Table1)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'baseControlStyle
        '
        Me.baseControlStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.baseControlStyle.Name = "baseControlStyle"
        Me.baseControlStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'evenDetailStyle
        '
        Me.evenDetailStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.evenDetailStyle.Name = "evenDetailStyle"
        Me.evenDetailStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'oddDetailStyle
        '
        Me.oddDetailStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.oddDetailStyle.Name = "oddDetailStyle"
        Me.oddDetailStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'PembayaranReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader2, Me.GroupHeader1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "pembayaraninner"
        Me.DataSource = Me.SqlDataSource1
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 18, 100)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.baseControlStyle, Me.evenDetailStyle, Me.oddDetailStyle})
        Me.Version = "20.1"
        CType(Me.detailTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.headerTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.invoiceInfoTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents detailTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents detailTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents productName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents quantity As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lineTotal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents thankYouLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vendorLogo2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents customerTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents xrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents billToLabel As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerNameRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents customerName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerAddressRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents customerAddress As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents headerTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents headerTableRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents productDesctiptionCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents quantityCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents unitPriceCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents baseControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents evenDetailStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents oddDetailStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents invoiceInfoTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents invoiceInfoTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceInfoTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents totalCaption2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceDateCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceNumberCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceInfoTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents total2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceNumber As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
End Class
