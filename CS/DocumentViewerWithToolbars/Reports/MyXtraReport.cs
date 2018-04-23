using System;
using DevExpress.XtraPrinting;

namespace DocumentViewerWithToolbars.Reports
{
    public partial class MyXtraReport : DevExpress.XtraReports.UI.XtraReport
    {
        int progress;

        public MyXtraReport()
        {
            InitializeComponent();
        }

        void MyXtraReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ReportPrintOptions.DetailCountOnEmptyDataSource = Math.Max(Math.Min((int)pageCount.Value, 100), 1);
            PrintingSystem.ProgressReflector.PositionChanged += ProgressReflector_PositionChanged;
        }

        void MyXtraReport_AfterPrint(object sender, EventArgs e)
        {
            PrintingSystem.ProgressReflector.PositionChanged -= ProgressReflector_PositionChanged;
        }

        void ProgressReflector_PositionChanged(object sender, EventArgs e)
        {
            var progressReflector = (ProgressReflector)sender;
            progress = progressReflector.Position;
        }

        void xrShape1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrShape1.Angle = progress * (180 / 100);
        }
    }
}
