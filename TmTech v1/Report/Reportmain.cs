using DevExpress.XtraReports.UI;

namespace TmTech_v1.Report
{
    public partial class Reportmain : DevExpress.XtraReports.UI.XtraReport
    {
        public Reportmain()
        {
            InitializeComponent();
            
        }

        private void AddTableCell ()
        {
            XRTableCell obj = new XRTableCell();
        }

        private void xrLabel22_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {


        }

    }
}
