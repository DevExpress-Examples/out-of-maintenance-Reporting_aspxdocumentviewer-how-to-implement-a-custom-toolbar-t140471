Namespace DocumentViewerWithToolbars.Reports
    Partial Public Class MyXtraReport
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim shapeStar1 As New DevExpress.XtraPrinting.Shape.ShapeStar()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrShape1 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.pageCount = New DevExpress.XtraReports.Parameters.Parameter()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPanel1, Me.xrPageBreak1})
            Me.Detail.HeightF = 209.1667F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPanel1
            ' 
            Me.xrPanel1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1, Me.xrShape1})
            Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 33.00001F)
            Me.xrPanel1.Name = "xrPanel1"
            Me.xrPanel1.SizeF = New System.Drawing.SizeF(473.0001F, 166.1667F)
            Me.xrPanel1.StylePriority.UseBorders = False
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrPageInfo1.Font = New System.Drawing.Font("Times New Roman", 12F)
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(396.3334F, 105.7083F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(66.66664F, 23F)
            Me.xrPageInfo1.StylePriority.UseBorders = False
            Me.xrPageInfo1.StylePriority.UseFont = False
            ' 
            ' xrShape1
            ' 
            Me.xrShape1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrShape1.FillColor = System.Drawing.Color.Yellow
            Me.xrShape1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 37.45835F)
            Me.xrShape1.Name = "xrShape1"
            shapeStar1.StarPointCount = 5
            Me.xrShape1.Shape = shapeStar1
            Me.xrShape1.SizeF = New System.Drawing.SizeF(372.9583F, 91.24998F)
            Me.xrShape1.StylePriority.UseBorders = False
            ' 
            ' xrPageBreak1
            ' 
            Me.xrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 207.1667F)
            Me.xrPageBreak1.Name = "xrPageBreak1"
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' pageCount
            ' 
            Me.pageCount.Description = "Count of Pages"
            Me.pageCount.Name = "pageCount"
            Me.pageCount.Type = GetType(Integer)
            Me.pageCount.ValueInfo = "5"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 12F)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(473F, 23F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.Text = "Custom Toolbars"
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
            Me.PageHeader.HeightF = 33F
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' MyXtraReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
            Me.PageHeight = 492
            Me.PageWidth = 693
            Me.PaperKind = System.Drawing.Printing.PaperKind.B6Envelope
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.pageCount})
            Me.RequestParameters = False
            Me.Version = "14.1"
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private xrPanel1 As DevExpress.XtraReports.UI.XRPanel
        Private WithEvents xrShape1 As DevExpress.XtraReports.UI.XRShape
        Private xrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
        Private pageCount As DevExpress.XtraReports.Parameters.Parameter
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    End Class
End Namespace
