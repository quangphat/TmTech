using DevExpress.XtraEditors;
using FlatMessageBox;
using ModernUI.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.ToolBoxCS;

namespace TmTech_v1.Utility
{
    public class TheScreen
    {
        public TheScreen(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public float Width { get; set; }
        public float Height { get; set; }
    }
    public static class FormUtility
    {
        static INotify Notify = new FlatNotify();
        static CultureInfo UsCul = CultureInfo.GetCultureInfo("en-US");
        static CultureInfo VnCul = CultureInfo.GetCultureInfo("vi-VN");
        public static TheScreen Standard = new TheScreen(1368, 768);
        public static TheScreen ThisScreen = new TheScreen(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        public static float RateX =  ThisScreen.Width/Standard.Width;
        public static float RateY =   ThisScreen.Height/Standard.Height;
        //static string CurrencyFormat = "#,###";
        public static void FormatForm(Control ctrl)
        {   
            foreach (Control c in ctrl.Controls)
            {
                if (c is DateEdit)
                {
                    DateEdit dtp = c as DateEdit;
                    dtp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
                    dtp.DateTime = DateTime.Today;
                    if (dtp.Tag != null)
                        dtp.DateTime = DateTime.Today.AddDays(-5);
                    dtp.Properties.DisplayFormat.Format = VnCul;
                }
                else
                if (c is AutoXDatetime)
                {
                    AutoXDatetime dtp = c as AutoXDatetime;
                    dtp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
                    dtp.DateTime = DateTime.Today;
                    dtp.Properties.DisplayFormat.Format = VnCul;
                }
                else
                if (c is ApproveButton)
                {
                    ApproveButton btn = c as ApproveButton;
                    btn.Visible = UserManagement.AllowApprove(btn.Bindingfor);
                }
                else
                if (c is TextBox || c is AutoTextBox)
                {
                    if (c.Tag == null) continue;
                    string tag = c.Tag.ToString().ToLower();
                    switch (tag)
                    {
                        case "money":
                            c.KeyPress += UtilityFunction_KeyPress;
                            c.TextChanged += ctrl_TextChanged;
                            break;
                        case "totalmoney":
                            c.KeyPress += UtilityFunction_KeyPress;
                            break;
                        case "number":
                            c.KeyPress += UtilityFunction_KeyPress;
                            break;
                    }
                }
                if (c.HasChildren)
                {
                    if (!(c is DevExpress.XtraGrid.GridControl))
                    FormatForm(c);
                }
            }
        }
        static void ctrl_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            decimal money = CurrencyUtility.ToDecimal(t.Text);
            t.Text = CurrencyUtility.DecimalToString(money);
            t.SelectionStart = t.TextLength;
        }

        private static void UtilityFunction_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public static DialogResult ItemWasApproved()
        {
            return Notify.ItemWasApproved();
        }
        public static DialogResult MsgApprove()
        {
            return Notify.Approve();
        }
        public static DialogResult MsgDelete()
        {
            return Notify.DeleteItem();
        }
        public static DialogResult MsgNoInformtion()
        {
            return Notify.NoInformation();
        }
        public static DialogResult CloseWithoutSave()
        {
            return Notify.CloseWithoutSave();
        }
        public static DialogResult MscWarming()
        {
            return Notify.Warming();
        }
        public static DialogResult CancelApprove()
        {
            return Notify.CancelApprove();
        }
        public static DialogResult CloseForm()
        {
            return Notify.CloseForm();
        }
        public static void ResetForm(Control control)
        {
            if (control is MetroSearchComboBox)
            {
                var cmb = (MetroSearchComboBox)control;
                if (cmb.Items.Count > 0)
                    cmb.SelectedIndex = -1;
            }

            else if (control is TextBox)
            {

                var txtbox = (TextBox)control;
                if (txtbox.Name == "txtTaxCode")
                {
                    txtbox.ReadOnly = false;

                }
                txtbox.Text = string.Empty;

            }
            else if( control is AutoPictureBox)
            {
                var autobox = (AutoPictureBox)control;
                autobox.Tag = null;
                autobox.Image = null;
            }
            else if (control is CheckBox)
            {
                var chkbox = (CheckBox)control;
                chkbox.Checked = false;
            }
            else if (control is RadioButton)
            {
                var rdbtn = (RadioButton)control;
                rdbtn.Checked = false;
            }
            else if (control is DateTimePicker)
            {
                var dtp = (DateTimePicker)control;
                dtp.Value = DateTime.Now;
            }
            else if (control is RichTextBox)
            {
                var richTextBox = (RichTextBox)control;
                richTextBox.Text = string.Empty;
            }

            // repeat for combobox, listbox, checkbox and any other controls you want to clear
            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                    ResetForm(child);
                }
            }

        }



        public static void ReadOnlySpecial(Control control)
        {
            if (control is MetroTextBox)
            {
                var metrobox = (MetroTextBox)control;
                metrobox.Enabled = false;
            }
            else
            if (control is TextBox)
            {
                var txtbox = (TextBox)control;
                txtbox.ReadOnly = true;
            }
            // repeat for combobox, listbox, checkbox and any other controls you want to clear
            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                    ReadOnly(child);
                }
            }
        }
        public static void ReadOnly(Control control)
        {
            if (control is MetroTextBox)
            {

                return;
            }
            else
            if (control is TextBox)
            {

                var txtbox = (TextBox)control;
                txtbox.ReadOnly = true;

            }



            // repeat for combobox, listbox, checkbox and any other controls you want to clear
            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                    ReadOnly(child);
                }
            }

        }
        private static void lostfocus(object sender, EventArgs e)
        {

            var objfouse = (TextBox)sender;
            var strTag = objfouse.Tag.ToString().ToLower();
            switch (strTag)
            {
                case "phone":
                    if (objfouse.Text.Length < 9)
                    {
                        objfouse.Focus();
                        FlatMsgBox.Show("Số điện thoại không hợp lệ");
                    }
                    break;

            }
        }
        private static void InPutFloat(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private static void InputNumber(object sender, KeyPressEventArgs e)  // only input number
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
        public static void SetFormSize(Form f)
        {
            f.Width = Screen.PrimaryScreen.WorkingArea.Width;
            f.Height = Screen.PrimaryScreen.WorkingArea.Height;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Location = new Point(0, 0);
        }
        public static Form FindForm(string Name)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == Name)
                    return form;
            }
            return null;
        }
        public static UserControl FindUserCtrl(string Name)
        {
            var frmPrimary = FindForm("frmPrimary") as frmPrimary;
            if (frmPrimary == null) return null;
            var uCtrl = frmPrimary.Controls.Find(Name, true).FirstOrDefault() as UserControl;
            if (uCtrl != null)
                return uCtrl;
            else
                return null;
        }
        public static MaterialTabControl FindTabCtrl(string Name)
        {
            var frmPrimary = FindForm("frmPrimary") as frmPrimary;
            if (frmPrimary == null) return null;
            var tabCtrl = frmPrimary.Controls.Find(Name, true).FirstOrDefault() as MaterialTabControl;
            if (tabCtrl != null)
                return tabCtrl;
            else
                return null;
        }
        public static List<T> GetControlByName<T>(Control controlToSearch, string nameOfControlsToFind, bool searchDescendants) where T : class
        {
            List<T> result;
            result = new List<T>();
            foreach (Control c in controlToSearch.Controls)
            {

                if (c.Name == "frmView")
                {
                    if (c.GetType().Name == nameOfControlsToFind && c.GetType() == typeof(T))
                    {
                        result.Add(c as T);
                    }
                    if (searchDescendants)
                    {
                        result.AddRange(GetControlByName<T>(c, nameOfControlsToFind, true));
                    }
                }

            }
            return result;
        }
        public static List<T> FindAllTextbox<T>(Control controlToSearch, bool searchDescendants) where T : class
        {
            var result = new List<T>();
            foreach (Control c in controlToSearch.Controls)
            {
                if (c.GetType() == typeof(T))
                {
                    result.Add(c as T);
                }
                if (searchDescendants)
                {
                    result.AddRange(FindAllTextbox<T>(c, true));
                }
            }
            return result;
        }
        public static bool isTabExist(MaterialTabControl tab, string tabname)
        {
            foreach (TabPage tabpage in tab.TabPages)
            {
                if (tabpage.Text == tabname)
                    return true;
            }
            return false;
        }
        private delegate void delgCloseTab();
        public static void CloseCurrentTab()
        {
            var form = Application.OpenForms["frmPrimary"] as frmPrimary;
            if (form != null)
            {
                var delgCloseTab = new delgCloseTab(form.closeCurrentTab);
                delgCloseTab();
            }
        }

        public static void CloseTabByWinFrm( UserControl frm)
        {
            var form = Application.OpenForms["frmPrimary"] as frmPrimary;
            if (form != null)
            {
                form.CloseTabByName(frm);
            }
        }
        public static void OpenTabByWinFrm(string name)
        {
            var form = Application.OpenForms["frmPrimary"] as frmPrimary;
            if (form != null)
            {
                form.OpentabByName(name);
            }
        }
        public static void HideTabByFrm(UserControl frm)
        {
            var form = Application.OpenForms["frmPrimary"] as frmPrimary;
            if (form != null)
            {
                form.HideTabByName(frm);
            }
        }
        public static void HideAndShow(Form form)
        {
            if (form != null)
            {
                form.Enabled = false;
                //form.Hide();
            }
        }
        public static void ShowPopup()
        {
            var primary = Application.OpenForms["frmPrimary"] as frmPrimary;
            if (primary != null)
                primary.Enabled = false;
        }
        public static void CloseAndShow(string name)
        {
            var form = Application.OpenForms[name];
            if (form == null) return;
            if (form != null)
            {
                form.Enabled = true;
                //form.Visible = true;
            }
        }
        public static void ShowParentForm()
        {
            var primary = Application.OpenForms["frmPrimary"] as frmPrimary;
            if (primary != null)
            {
                primary.Enabled = true;
            }
        }
        public static void CloseAndShow(Form form)
        {
            if (form != null)
            {
                form.Enabled = true;
                // form.Visible = true;
            }
        }
        public static void SetTexboxReadOnly(List<TextBox> lstTextbox, bool isreadOnly = true)
        {
            foreach (var textbx in lstTextbox)
            {
                textbx.ReadOnly = isreadOnly;
            }
        }
        public static void SetTexboxReadOnly(Control ctrl, bool isreadOnly = true)
        {
            var lstTextbox = FindAllTextbox<TextBox>(ctrl, true);
            var lstTextbox2 = FindAllTextbox<TextBoxValidation>(ctrl, true);
            if (lstTextbox != null)
            {
                foreach (var textbx in lstTextbox)
                {
                    textbx.ReadOnly = isreadOnly;
                }
            }
            if (lstTextbox2 != null)
            {
                foreach (var textbx in lstTextbox2)
                {
                    textbx.ReadOnly = isreadOnly;
                }
            }
        }
        public static void SetComboboxDisable(Control controls, bool enable)
        {
            enable = !enable;
            foreach (Control ctrl in controls.Controls)
            {
                if (ctrl is System.Windows.Forms.ComboBox || ctrl is DevExpress.XtraEditors.ComboBoxEdit || ctrl is MetroSearchComboBox)
                    ctrl.Enabled = enable;
                if (ctrl.Controls.Count > 0)
                {
                    SetComboboxDisable(ctrl, enable);
                }
            }
        }
        public static void SetLinkDisable(Control controls, bool enable)
        {
            enable = !enable;
            foreach (Control ctrl in controls.Controls)
            {
                if (ctrl is LinkLabel)
                    ctrl.Enabled = enable;
                if (ctrl.Controls.Count > 0)
                {
                    SetComboboxDisable(ctrl, enable);
                }
            }
        }
        public static void DisableAllCtrl(Control controls, bool enable)
        {
            foreach (Control ctrl in controls.Controls)
            {
                ctrl.Enabled = !enable;
                if (ctrl.Controls.Count > 0)
                {
                    DisableAllCtrl(ctrl, enable);
                }
            }
        }
        public static string getAllByUser(string tablename)
        {
            var username = UserManagement.UserSession.UserName;
            username = UserManagement.AllowViewAll(tablename) == true ? username : null;
            return username;
        }

        public static void BindTextBoxToObj<T>(Control ctrls, T obj) where T : class
        {
            if (obj == null) return;
            foreach (Control ctrl in ctrls.Controls)
            {
                if ((ctrl is TextBox) || (ctrl is TextBoxValidation))
                {
                    var txt = ctrl as TextBox;
                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        if (ctrl.Tag != null)
                        {
                            if (ctrl.Tag.ToString() == prop.Name)
                                prop.SetValue(obj, txt.Text);
                        }

                    }
                }
            }
            if (obj != null)
            {
                foreach (var prop in obj.GetType().GetProperties())
                {

                }
            }
        }
        

       
        public static string IntToString(this int? numberConvert)
        {
            if (numberConvert == null)
                return string.Empty;
            else
            {
                return numberConvert.ToString();
            }
        }
        public static int ConvertToInt(this string stringConvert)
        {
            if (string.IsNullOrEmpty(stringConvert) || string.IsNullOrWhiteSpace(stringConvert))
                return 0;
            else
            {
                return int.Parse(stringConvert.ToString());
            }
        }

        public static DialogResult MsgAddNewRow()
        {
            var result = FlatMsgBox.Show(UI.AddNewRow, UI.warning, FlatMsgBox.Buttons.YesNo);
            return result;
        }
    }
}
