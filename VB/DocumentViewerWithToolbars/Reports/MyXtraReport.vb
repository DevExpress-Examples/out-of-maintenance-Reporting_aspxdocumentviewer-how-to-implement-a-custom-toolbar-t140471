Imports System
Imports DevExpress.XtraPrinting

Namespace DocumentViewerWithToolbars.Reports
    Partial Public Class MyXtraReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private progress As Integer

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub MyXtraReport_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
            ReportPrintOptions.DetailCountOnEmptyDataSource = Math.Max(Math.Min(CInt((pageCount.Value)), 100), 1)
            AddHandler PrintingSystem.ProgressReflector.PositionChanged, AddressOf ProgressReflector_PositionChanged
        End Sub

        Private Sub MyXtraReport_AfterPrint(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.AfterPrint
            RemoveHandler PrintingSystem.ProgressReflector.PositionChanged, AddressOf ProgressReflector_PositionChanged
        End Sub

        Private Sub ProgressReflector_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim progressReflector = DirectCast(sender, ProgressReflector)
            progress = progressReflector.Position
        End Sub

        Private Sub xrShape1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrShape1.BeforePrint
            xrShape1.Angle = progress * (180 \ 100)
        End Sub
    End Class
End Namespace
