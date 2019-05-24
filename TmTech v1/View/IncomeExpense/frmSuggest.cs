using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmSuggest : ModernUI.Forms.MetroForm
    {
        public delegate void delgAdd(IncomeExpense sug);
        public delgAdd add;
        private decimal lastMoneyIn = 0;
        public frmSuggest()
        {
            InitializeComponent();
            FormUtility.FormatForm(this);
            
        }

        private void frmSuggest_Load(object sender, EventArgs e)
        {
            IList<PurposeSuggestion> ps = new List<PurposeSuggestion>();
            IList<Department> dep = new List<Department>();
            IList<Staff> staff = new List<Staff>();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    ps = uow.IncomeExpenseRepository.GetAllPurpose();
                    dep = uow.DepartmentRepository.All();
                    staff = uow.StaffRepository.All();
                    uow.Commit();
                }
            }
            catch { }
            ComboboxUtility.BindData(cbbPurpose, ps, "PurposeName", "PurposeSuggestionId");
            ComboboxUtility.BindData(cbbDepartment, dep, "DepartmentName", "DepartmentId");
            ComboboxUtility.BindData(cbbStaff, staff, "StaffName", "StaffId");
            cbbPurpose.SelectedValue = cbbDepartment.SelectedValue = cbbStaff.SelectedValue = -1;
            lastMoneyIn = GetLastMoneyIn();
            txtBillNo.Focus();
        }

        private decimal GetLastMoneyIn()
        {
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {

                    return uow.IncomeExpenseRepository.GetLastMoneyIn();
                }
            }
            catch { return 0; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IncomeExpense ie = new IncomeExpense();
            CoverObjectUtility.GetAutoBindingData(this, ie);
            ie.PurposeSuggestion.PurposeName = (cbbPurpose.SelectedItem as PurposeSuggestion).PurposeName;
            ie.Department.DepartmentName = (cbbDepartment.SelectedItem as Department).DepartmentName;
            ie.Staff.StaffName = (cbbStaff.SelectedItem as Staff).StaffName;
            ie.SetCreate();
            if (cbbPurpose.SelectedValue.ToString() == "1") //Ky quy
            {
                ie.RegisterValue = Convert.ToDecimal(txtMoneyOut.Text.Trim().Replace(",", ""));
                lastMoneyIn += (decimal)ie.MoneyBack + (decimal)ie.RegisterValue; //MoneyIn tang
                ie.MoneyOut = null;
            }
            else
            {
                lastMoneyIn = lastMoneyIn - (decimal)ie.MoneyOut + (decimal)ie.MoneyBack;
                ie.MoneyUse = (decimal)ie.MoneyOut - (decimal)ie.MoneyBack;
            }

            ie.MoneyIn = lastMoneyIn;
            ie.ApproveStatusId = 2;
            ie.ApproveBy = UserManagement.UserSession.UserName;
            ie.ApproveDate = DateTime.Now;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.IncomeExpenseRepository.Add(ie);
                    uow.Commit();
                }
            }
            catch { return; }
            if (add != null)
                add(ie);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Translate number
        private string TranslateNumber(char num, bool isCamel, bool isFifth = false, bool isFirst = false)
        {
            switch (num)
            {
                case '0':
                    return (isCamel ? "Không" : "không");
                case '1':
                    if (!isFirst)
                        return (isCamel ? "Một" : "một");
                    else
                        return (isCamel ? "Mốt" : "mốt");
                case '2':
                    return (isCamel ? "Hai" : "hai");
                case '3':
                    return (isCamel ? "Ba" : "ba");
                case '4':
                    return (isCamel ? "Bốn" : "bốn");
                case '5':
                    if (!isFifth)
                        return (isCamel ? "Năm" : "năm");
                    else
                        return (isCamel ? "Lăm" : "lăm");
                case '6':
                    return (isCamel ? "Sáu" : "sáu");
                case '7':
                    return (isCamel ? "Bảy" : "bảy");
                case '8':
                    return (isCamel ? "Tám" : "tám");
                case '9':
                    return (isCamel ? "Chín" : "chín");
                default:
                    return string.Empty;
            }
        }

        private string GetLarge(int length)
        {
            float temp = (float)length / 3;
            if (temp > 0 && temp <= 1)
                return string.Empty;
            else
            {
                if (temp > 1 && temp <= 2)
                    return " nghìn ";
                else
                {
                    if (temp > 2 && temp <= 3)
                        return " triệu ";
                    else
                    {
                        if (temp > 3 && temp <= 4)
                            return " tỉ ";
                        else
                            return string.Empty;
                    }
                }
            }
        }

        private string ReadOnce(string num)
        {
            string temp;
            if (num.Length == 1)
            {
                return TranslateNumber(num.ElementAt(0), true);
            }
            else
            {
                if (num.Length == 2)
                {
                    if (num == "00")
                        return string.Empty;
                    temp = "";
                    temp = (TranslateNumber(num.ElementAt(0), true) == "Một" ? "Mười " : TranslateNumber(num.ElementAt(0), true) + " mươi ");
                    return temp + (TranslateNumber(num.ElementAt(1), false) == "không" ? "" : TranslateNumber(num.ElementAt(1), false, true));
                }
                else
                {
                    if (num.Length == 3)
                    {
                        if (num == "000")
                            return string.Empty;
                        temp = "";
                        string temp2 = (TranslateNumber(num.ElementAt(2), false) == "không" ? "" : TranslateNumber(num.ElementAt(1), false) == "không" ? TranslateNumber(num.ElementAt(2), false) : TranslateNumber(num.ElementAt(2), false, true));
                        if (temp2 != "")
                            temp = (TranslateNumber(num.ElementAt(1), false) == "không" ? "lẻ" : TranslateNumber(num.ElementAt(1), false) + " mươi ");
                        else
                            temp = (TranslateNumber(num.ElementAt(1), false) == "không" ? "" : TranslateNumber(num.ElementAt(1), false) + " mươi ");
                        return TranslateNumber(num.ElementAt(0), true) + " trăm " + temp + temp2;
                    }
                    else
                        return string.Empty;
                }
            }
        }

        private string Translate(string num)
        {
            if (num == "")
                return string.Empty;

            double num2 = 0;
            try
            {
                num = num.Trim().Replace(".", "").Replace(" ", "");
                num2 = Convert.ToDouble(num);
            }
            catch { return string.Empty; }
            int len = num.Length;
            string temp = num2.ToString("#,#");
            string[] str = temp.Split(',');
            string result = "";
            foreach (string s in str)
            {
                result += ReadOnce(s) == string.Empty ? string.Empty : ReadOnce(s) + GetLarge(len);
                len = len - s.Length;
            }
            return result + " ";
        }
        #endregion

        #region Textbox ReadNumber
        private void txtMoneyOut_TextChanged(object sender, EventArgs e)
        {
            //AutoTextBox text = sender as AutoTextBox;
            //txtMoneyNumWrite.Text = Translate(text.Text).Normalize();
            txtMoneyNumWrite.Text = MoneyToString.ReadMoney.MoneyToText(CurrencyUtility.ToDecimal(txtMoneyOut.Text));

        }

        private void txtMoneyOut_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtMoneyBack_TextChanged(object sender, EventArgs e)
        {
            txtReturnMoneyNumWrite.Text = MoneyToString.ReadMoney.MoneyToText(CurrencyUtility.ToDecimal(txtMoneyBack.Text));
        }

        #endregion

        private void cbbPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPurpose.SelectedValue != null)
            {
                if (cbbPurpose.SelectedValue.ToString() == "1") //Ky quy
                {
                    txtContent.Text = "Ký quỹ";
                    txtContent.ReadOnly = true;
                }
                else
                {
                    if (cbbPurpose.SelectedValue.ToString() == "2") //Rut quy
                    {
                        txtContent.Text = "Rút quỹ";
                        txtContent.ReadOnly = true;
                    }
                    else
                    {
                        if (cbbPurpose.SelectedValue.ToString() == "3")
                        {
                            txtContent.Text = "";
                            txtContent.ReadOnly = false;
                        }
                    }
                }
            }
        }

        private void cbbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDepartment.SelectedValue != null)
            {
                IList<Staff> staff = new List<Staff>();
                try
                {
                    using (IUnitOfWork uow = new UnitOfWork())
                    {

                        staff = uow.StaffRepository.FindByDepartment(Convert.ToInt32(cbbDepartment.SelectedValue));
                        uow.Commit();
                    }
                }
                catch { }
                ComboboxUtility.BindData(cbbStaff, staff, "StaffName", "StaffId");
            }
        }

        #region Printing
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += PrintDocument_PrintPage;
            if(printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }

        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Time New Roman", 12);
            graphic.DrawString("Xin chào", font, Brushes.Blue, new Point(10, 10));
        }

        #endregion
    }
}
