Imports DevExpress.Web.Mvc
Imports DevExpress.XtraReports.UI
Imports DocumentViewerWithToolbars.Reports
Imports System.Web.Mvc

Namespace DocumentViewerWithToolbars.Controllers
    Public Class HomeController
        Inherits Controller

        Private ReadOnly report As XtraReport = New MyXtraReport()

        Public Function Index() As ActionResult
            Return View(report)
        End Function

        Public Function DocumentViewerPartial() As ActionResult
            Return PartialView("_DocumentViewerPartial", report)
        End Function

        Public Function DocumentViewerPartialExport() As ActionResult
            Return DocumentViewerExtension.ExportTo(report, Request)
        End Function
    End Class
End Namespace
