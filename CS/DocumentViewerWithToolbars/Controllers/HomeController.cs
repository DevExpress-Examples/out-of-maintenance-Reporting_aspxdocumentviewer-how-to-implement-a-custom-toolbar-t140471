using DevExpress.Web.Mvc;
using DevExpress.XtraReports.UI;
using DocumentViewerWithToolbars.Reports;
using System.Web.Mvc;

namespace DocumentViewerWithToolbars.Controllers
{
    public class HomeController : Controller
    {
        readonly XtraReport report = new MyXtraReport();

        public ActionResult Index()
        {
            return View(report);
        }

        public ActionResult DocumentViewerPartial()
        {
            return PartialView("_DocumentViewerPartial", report);
        }

        public ActionResult DocumentViewerPartialExport()
        {
            return DocumentViewerExtension.ExportTo(report, Request);
        }
    }
}
