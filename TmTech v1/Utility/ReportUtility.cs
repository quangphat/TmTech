using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TmTech_v1.Utility
{
    public interface IReportUtility
    {
        void Format();
        void ShowPreview();
        void Binding<T>(BindingSource bindingSource, IList<T> lstObj);
    }
    public class ReportUtility:IReportUtility
    {
        private CultureInfo UsCul = CultureInfo.GetCultureInfo("en-US");
        private CultureInfo VnCul = CultureInfo.GetCultureInfo("vi-VN");
        public XtraReport rpt;
        private DevExpress.XtraReports.UI.XRSummary summmaryStt;
        private DevExpress.XtraReports.UI.XRSummary summmaryMoney;
        private DevExpress.XtraReports.UI.XRSummary summmaryNumber;
        public ReportUtility(XtraReport xrpt)
        {
            this.rpt = xrpt;
            DefineSummary();
            Format();
        }
        private void DefineSummary()
        {
            //cho cột số thứ tự
            summmaryStt = new XRSummary();
            summmaryStt.FormatString = "{0:#}";
            summmaryStt.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
            summmaryStt.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;

            //cho các ô là tiền tệ
            summmaryMoney = new XRSummary();
            summmaryMoney.FormatString = "{0:#,#}";
            summmaryMoney.Func = SummaryFunc.Sum;
            summmaryMoney.Running = SummaryRunning.Group;

            //cho các ô là số
            summmaryNumber = new XRSummary();
            summmaryNumber.FormatString = "{0:#}";
            summmaryNumber.Func = SummaryFunc.Sum;
            summmaryNumber.Running = SummaryRunning.Group;
        }
        public void Format()
        {
            rpt.ShowPreviewMarginLines = false;
            foreach (Band band in rpt.Bands)
            {
                if (band is GroupHeaderBand)
                {
                    foreach(XRControl table in band.Controls)
                    {
                        if (table is XRTable)
                        {
                            table.Borders = DevExpress.XtraPrinting.BorderSide.All;
                            foreach (XRControl row in table.Controls)
                            {
                                if (row is XRTableRow)
                                {
                                    foreach (XRControl ctrl in row.Controls)
                                    {
                                        if (ctrl is XRTableCell)
                                        {
                                            //FontFamily fontFamily = new FontFamily();
                                            Font font = new Font(ctrl.Font, FontStyle.Bold);
                                            ctrl.Font = font;
                                            ctrl.Padding = new DevExpress.XtraPrinting.PaddingInfo(3,0,3,0);
                                        }
                                    }
                                }
                                
                            }
                        }
                        
                    }
                }
                if (band is DetailBand)
                {
                    foreach (XRControl c in band.Controls)
                    {
                        if (c is XRTable)
                        {
                            c.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
                            foreach (XRControl row in c.Controls)
                            {
                                if (row is XRTableRow)
                                {
                                    foreach (XRControl ctrl in row.Controls)
                                    {
                                        if (ctrl.Tag != null)
                                        {
                                            if (ctrl is XRTableCell)
                                            {
                                                XRTableCell cell = ctrl as XRTableCell;
                                                cell.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 3, 0);
                                                if (ctrl.Tag.ToString() == "Stt")
                                                {
                                                    cell.Summary = summmaryStt;
                                                }
                                                if (ctrl.Tag.ToString() == "money")
                                                {
                                                    if (cell.DataBindings["Text"] != null)
                                                    cell.DataBindings["Text"].FormatString = summmaryMoney.FormatString;
                                                }
                                                if (ctrl.Tag.ToString() == "number")
                                                {
                                                    if (cell.DataBindings["Text"] != null)
                                                    cell.DataBindings["Text"].FormatString = summmaryNumber.FormatString;
                                                }                                         
                                            }
                                        }
                                    }
                                }
                                
                            }
                        }
                        
                    }
                }
                if (band is GroupFooterBand)
                {
                    foreach (XRControl c in band.Controls)
                    {
                        if (c is XRTable)
                        {
                            foreach (XRControl row in c.Controls)
                            {
                                if (row is XRTableRow)
                                {
                                    foreach (XRControl ctrl in row.Controls)
                                    {
                                        if (ctrl.Tag != null)
                                        {
                                            if (ctrl is XRTableCell)
                                            {
                                                XRTableCell cell = ctrl as XRTableCell;
                                                if (ctrl.Tag.ToString() == "number")
                                                {
                                                    cell.Summary = summmaryNumber;
                                                }
                                                if (ctrl.Tag.ToString() == "datetime")
                                                {
                                                    cell.Summary = summmaryMoney;
                                                }
                                            }
                                        }
                                    }
                                }
                                
                            }
                        }
                        
                    }
                }
            }
        }

        public void ShowPreview()
        {
            ReportPrintTool tool = new ReportPrintTool(rpt);
            tool.ShowPreviewDialog();
        }

        public void Binding<T>( BindingSource bindingSource, IList<T> lstObj)
        {
            bindingSource = new BindingSource(lstObj, null);
            rpt.DataSource = bindingSource;
            //Format();
        }
    }
}
