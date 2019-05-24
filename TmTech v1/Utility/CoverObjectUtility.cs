using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraScheduler.Commands;
using TmTech_v1.ToolBoxCS;

namespace TmTech_v1.Utility
{
    public static class CoverObjectUtility
    {
        public static object GetPropertyValue(string fieldname, object obj)
        {
            string[] props = fieldname.Split('.');
            object val = null;
            if (props != null)
            {
                PropertyInfo propInfo = obj.GetType().GetProperty(props[0]);
                if (propInfo != null)
                {
                    val = propInfo.GetValue(obj, null);
                    if (val != null)
                    {
                        for (int i = 1; i < props.Length; i++)
                        {
                            propInfo = val.GetType().GetProperty(props[i]);
                            val = propInfo != null ? propInfo.GetValue(val, null) : null;
                        }
                        return val;
                    }
                }
            }
            return val;
        }
        private static void SetProperty(string compoundProperty, object target, object value)
        {
            if (value == null) return;
            string[] bits = compoundProperty.Split('.');
            for (int i = 0; i < bits.Length - 1; i++)
            {
                PropertyInfo propertyToGet = target.GetType().GetProperty(bits[i]);
                if (propertyToGet != null)
                    target = propertyToGet.GetValue(target, null);
                else
                    target = null;
            }
            if (target != null)
            {
                PropertyInfo propertyToSet = target.GetType().GetProperty(bits.Last());
                if (propertyToSet != null)
                {
                    Type u = Nullable.GetUnderlyingType(propertyToSet.PropertyType);
                    if (u != null)
                    {
                        var val = ChangeType(value, u);
                        if (val != null)
                            propertyToSet.SetValue(target, val, null);
                    }
                    else
                    {
                        var val = ChangeType(value, propertyToSet.PropertyType);
                        if (val != null)
                            propertyToSet.SetValue(target, val, null);
                    }
                }
            }
        }
        private static object ChangeType(object obj, Type t)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(obj.ToString()))
                {
                    if (t == typeof(int))
                    {
                        return (int)(0);
                    }
                    if (t == typeof(double))
                    {
                        return (double)(0);
                    }
                    if (t == typeof(decimal))
                    {
                        return (decimal)(0);
                    }
                    if (t == typeof(float))
                    {
                        return (float)(0);
                    }
                }
                if ((t == typeof(decimal) || t == typeof(Decimal)))
                {
                    return CurrencyUtility.ToDecimal(obj.ToString());
                }
                if (t == typeof(Guid) && !string.IsNullOrWhiteSpace(obj.ToString()))
                {
                    return Guid.Parse(obj.ToString());
                }
                return Convert.ChangeType(obj, t);
            }
            catch
            {
                obj = "";
                return ChangeType(obj, t);
            }
        }
        public static void SetAutoBindingData(Control controls, object obj)
        {
            if (obj == null) return;
            string ObjectName = obj.GetType().Name;
            string bindingname = "";
            object val = null;
            foreach (Control ctrl in controls.Controls)
            {

                if (ctrl is TextBoxValidation)
                {
                    TextBoxValidation textbox = ctrl as TextBoxValidation;
                    if (textbox.BindingFor != ObjectName) continue;
                    if (string.IsNullOrWhiteSpace(textbox.BindingName)) continue;
                    bindingname = textbox.BindingName;
                    val = GetPropertyValue(bindingname, obj);
                    textbox.Text = val != null ? val.ToString() : "";
                }
                else if (ctrl is StatusTextbox)
                {
                    StatusTextbox textbox = ctrl as StatusTextbox;
                    if (textbox.BindingFor != ObjectName) continue;
                    if (string.IsNullOrWhiteSpace(textbox.BindingName)) continue;
                    bindingname = textbox.BindingName;
                    val = GetPropertyValue(bindingname, obj);
                    textbox.Text = val != null ? val.ToString() : "";
                    if (!string.IsNullOrWhiteSpace(textbox.StatusFieldName))
                    {
                        var statusValue = GetPropertyValue(textbox.StatusFieldName, obj);
                        int status = statusValue != null ? Convert.ToInt32(statusValue) : 0;
                        textbox.Display(status);
                    }
                }
                else if (ctrl is AutoTextBox)
                {
                    AutoTextBox textbox = ctrl as AutoTextBox;
                    if (textbox.BindingFor != ObjectName) continue;
                    if (string.IsNullOrWhiteSpace(textbox.BindingName)) continue;
                    bindingname = textbox.BindingName;
                    val = GetPropertyValue(bindingname, obj);
                    textbox.Text = val != null ? val.ToString() : "";
                }

                else if (ctrl is AutoMetroTextBox)
                {
                    AutoMetroTextBox textbox = ctrl as AutoMetroTextBox;
                    if (textbox.BindingFor != ObjectName) continue;
                    if (string.IsNullOrWhiteSpace(textbox.BindingName)) continue;
                    bindingname = textbox.BindingName;
                    val = GetPropertyValue(bindingname, obj);
                    textbox.Text = val != null ? val.ToString() : "";
                }
                else if (ctrl is AutoFileTextBox)
                {
                    AutoFileTextBox textbox = ctrl as AutoFileTextBox;
                    if (textbox.BindingFor != ObjectName) continue;
                    if (string.IsNullOrWhiteSpace(textbox.BindingName)) continue;
                    bindingname = textbox.BindingName;
                    val = GetPropertyValue(bindingname, obj);
                    textbox.Text = val != null ? val.ToString() : "";
                    if (FileUtility.PathIsImage(textbox.Text))
                    {
                        textbox.FilePath = PictureUtility.getImgLocation(textbox.Text);
                    }
                    textbox.FileName = textbox.Text;
                }
                else if (ctrl is AutoDatetime)
                {
                    AutoDatetime dtp = ctrl as AutoDatetime;
                    if (dtp.BindingFor != ObjectName) continue;
                    if (string.IsNullOrWhiteSpace(dtp.BindingName)) continue;
                    bindingname = dtp.BindingName;
                    val = GetPropertyValue(bindingname, obj);
                    dtp.Value = val != null ? Convert.ToDateTime(val) : UtilityFunction.minDate;
                }
                else if (ctrl is AutoXDatetime)
                {
                    AutoXDatetime dtp = ctrl as AutoXDatetime;
                    if (dtp.BindingFor != ObjectName) continue;
                    if (string.IsNullOrWhiteSpace(dtp.BindingName)) continue;
                    bindingname = dtp.BindingName;
                    val = GetPropertyValue(bindingname, obj);
                    dtp.DateTime = val != null ? Convert.ToDateTime(val) : UtilityFunction.minDate;
                }
                else if (ctrl is AutoPictureBox)
                {
                    AutoPictureBox ptb = ctrl as AutoPictureBox;
                    if (ptb.BindingFor != ObjectName) continue;
                    if (string.IsNullOrWhiteSpace(ptb.BindingName)) continue;
                    bindingname = ptb.BindingName;
                    val = GetPropertyValue(bindingname, obj);
                    ptb.PictureName = val != null ? val.ToString() : "";
                    ptb.Image = PictureUtility.GetImg(ptb.PictureName);
                    if (ptb.Image == null)
                        ptb.Image = TmTech_v1.Properties.Resources.unknow;
                    ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (ctrl is AutoCombobox)
                {
                    AutoCombobox cbb = ctrl as AutoCombobox;
                    if (cbb.BindingFor != ObjectName) continue;
                    if (string.IsNullOrWhiteSpace(cbb.BindingName)) continue;
                    bindingname = cbb.BindingName;
                    val = GetPropertyValue(bindingname, obj);
                    cbb.SelectedValue = val != null ? Convert.ToInt32(val) : 0;
                }
                else if (ctrl is AutoSearchCombobox)
                {
                    AutoSearchCombobox cbb = ctrl as AutoSearchCombobox;
                    if (cbb.BindingFor != ObjectName) continue;
                    if (string.IsNullOrWhiteSpace(cbb.BindingName)) continue;
                    bindingname = cbb.BindingName;
                    val = GetPropertyValue(bindingname, obj);
                    if (cbb.GetSelectedText == true)
                        cbb.Text = val != null ? val.ToString() : "";
                    else
                        cbb.SelectedValue = val != null ? Convert.ToInt32(val) : 0;
                }
                else if (ctrl is AutoMaterialCheckBox)
                {
                    AutoMaterialCheckBox cb = ctrl as AutoMaterialCheckBox;
                    if (cb.BindingFor != ObjectName) continue;
                    if (string.IsNullOrWhiteSpace(cb.BindingName)) continue;
                    bindingname = cb.BindingName;
                    val = GetPropertyValue(bindingname, obj);
                    cb.Checked = val == null ? false : Convert.ToBoolean(val);
                }
                if (ctrl.Controls.Count > 0)
                {
                    SetAutoBindingData(ctrl, obj);
                }
            }
        }

        public static void SetSingleCtrlAutoBindingData(Control ctrl, object obj)
        {
            if (obj == null) return;
            string ObjectName = obj.GetType().Name;
            string bindingname = "";
            object val = null;

            if (ctrl is AutoTextBox)
            {
                AutoTextBox textbox = ctrl as AutoTextBox;
                if (textbox.BindingFor == ObjectName)
                {
                    if (!string.IsNullOrWhiteSpace(textbox.BindingName))
                    {
                        bindingname = textbox.BindingName;
                        val = GetPropertyValue(bindingname, obj);
                        textbox.Text = val != null ? val.ToString() : "";
                    }
                }
            }
            else
                if (ctrl is TextBoxValidation)
                {
                    TextBoxValidation textbox = ctrl as TextBoxValidation;
                    if (textbox.BindingFor == ObjectName)
                    {
                        if (!string.IsNullOrWhiteSpace(textbox.BindingName))
                        {
                            bindingname = textbox.BindingName;
                            val = GetPropertyValue(bindingname, obj);
                            textbox.Text = val != null ? val.ToString() : "";
                        }
                    }
                }
                else
                    if (ctrl is StatusTextbox)
                    {
                        StatusTextbox textbox = ctrl as StatusTextbox;
                        if (textbox.BindingFor == ObjectName)
                        {
                            if (!string.IsNullOrWhiteSpace(textbox.BindingName))
                            {
                                bindingname = textbox.BindingName;
                                val = GetPropertyValue(bindingname, obj);
                                textbox.Text = val != null ? val.ToString() : "";
                            }
                        }
                    }
                    else
                        if (ctrl is AutoMetroTextBox)
                        {
                            AutoMetroTextBox textbox = ctrl as AutoMetroTextBox;
                            if (textbox.BindingFor == ObjectName)
                            {
                                if (!string.IsNullOrWhiteSpace(textbox.BindingName))
                                {
                                    bindingname = textbox.BindingName;
                                    val = GetPropertyValue(bindingname, obj);
                                    textbox.Text = val != null ? val.ToString() : "";
                                }
                            }
                        }
                        else
                            if (ctrl is AutoFileTextBox)
                            {
                                AutoFileTextBox textbox = ctrl as AutoFileTextBox;
                                if (textbox.BindingFor == ObjectName)
                                {
                                    if (!string.IsNullOrWhiteSpace(textbox.BindingName))
                                    {
                                        bindingname = textbox.BindingName;
                                        val = GetPropertyValue(bindingname, obj);
                                        textbox.Text = val != null ? val.ToString() : "";
                                        textbox.FileName = textbox.Text;
                                    }
                                }
                            }
                            else
                                if (ctrl is AutoDatetime)
                                {
                                    AutoDatetime dtp = ctrl as AutoDatetime;
                                    if (dtp.BindingFor == ObjectName)
                                    {
                                        if (!string.IsNullOrWhiteSpace(dtp.BindingName))
                                        {
                                            bindingname = dtp.BindingName;
                                            val = GetPropertyValue(bindingname, obj);
                                            dtp.Value = val != null ? Convert.ToDateTime(val) : UtilityFunction.minDate;
                                        }
                                    }
                                }
                                else
                                    if (ctrl is AutoXDatetime)
                                    {
                                        AutoXDatetime dtp = ctrl as AutoXDatetime;
                                        if (dtp.BindingFor == ObjectName)
                                        {
                                            if (!string.IsNullOrWhiteSpace(dtp.BindingName))
                                            {
                                                bindingname = dtp.BindingName;
                                                val = GetPropertyValue(bindingname, obj);
                                                dtp.DateTime = val != null ? Convert.ToDateTime(val) : UtilityFunction.minDate;
                                            }
                                        }
                                    }
                                    else
                                        if (ctrl is AutoPictureBox)
                                        {
                                            AutoPictureBox ptb = ctrl as AutoPictureBox;
                                            if (ptb.BindingFor == ObjectName)
                                            {
                                                if (!string.IsNullOrWhiteSpace(ptb.BindingName))
                                                {
                                                    bindingname = ptb.BindingName;
                                                    val = GetPropertyValue(bindingname, obj);
                                                    ptb.PictureName = val != null ? val.ToString() : "";
                                                    ptb.Image = PictureUtility.GetImg(ptb.PictureName);
                                                    if (ptb.Image == null)
                                                        ptb.Image = TmTech_v1.Properties.Resources.unknow;
                                                    ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                                                }
                                            }
                                        }
                                        else
                                            if (ctrl is AutoCombobox)
                                            {
                                                AutoCombobox cbb = ctrl as AutoCombobox;
                                                if (cbb.BindingFor == ObjectName)
                                                {
                                                    if (!string.IsNullOrWhiteSpace(cbb.BindingName))
                                                    {
                                                        bindingname = cbb.BindingName;
                                                        val = GetPropertyValue(bindingname, obj);
                                                        cbb.SelectedValue = val != null ? Convert.ToInt32(val) : 0;
                                                    }
                                                }
                                            }
                                            else
                                                if (ctrl is AutoSearchCombobox)
                                                {
                                                    AutoSearchCombobox cbb = ctrl as AutoSearchCombobox;
                                                    if (cbb.BindingFor == ObjectName)
                                                    {
                                                        if (!string.IsNullOrWhiteSpace(cbb.BindingName))
                                                        {
                                                            bindingname = cbb.BindingName;
                                                            val = GetPropertyValue(bindingname, obj);
                                                            if (cbb.GetSelectedText == true)
                                                                cbb.Text = val != null ? val.ToString() : "";
                                                            else
                                                                cbb.SelectedValue = val != null ? Convert.ToInt32(val) : 0;
                                                        }
                                                    }
                                                }

        }
        public static void GetAutoBindingData(Control controls, object obj)
        {
            string ObjectName = obj.GetType().Name;
            string bindingname = "";
            foreach (Control ctrl in controls.Controls)
            {
                if (ctrl is AutoTextBox)
                {
                    AutoTextBox textbox = ctrl as AutoTextBox;
                    if (textbox.BindingFor != ObjectName) continue;
                    if (string.IsNullOrWhiteSpace(textbox.BindingName)) continue;
                    bindingname = textbox.BindingName;
                    SetProperty(bindingname, obj, textbox.Text);
                }
                else
                    if (ctrl is TextBoxValidation)
                    {
                        TextBoxValidation textbox = ctrl as TextBoxValidation;
                        if (textbox.BindingFor != ObjectName) continue;
                        if (string.IsNullOrWhiteSpace(textbox.BindingName)) continue;
                        bindingname = textbox.BindingName;
                        SetProperty(bindingname, obj, textbox.Text);
                    }
                    else
                        if (ctrl is StatusTextbox)
                        {
                            StatusTextbox textbox = ctrl as StatusTextbox;
                            if (textbox.BindingFor != ObjectName) continue;
                            if (string.IsNullOrWhiteSpace(textbox.BindingName)) continue;
                            bindingname = textbox.BindingName;
                            SetProperty(bindingname, obj, textbox.Text);
                        }
                        else
                            if (ctrl is AutoMetroTextBox)
                            {
                                AutoMetroTextBox textbox = ctrl as AutoMetroTextBox;
                                if (textbox.BindingFor != ObjectName) continue;
                                if (string.IsNullOrWhiteSpace(textbox.BindingName)) continue;
                                bindingname = textbox.BindingName;
                                SetProperty(bindingname, obj, textbox.Text);
                            }
                            else
                                if (ctrl is AutoFileTextBox)
                                {
                                    AutoFileTextBox textbox = ctrl as AutoFileTextBox;
                                    if (textbox.BindingFor != ObjectName) continue;
                                    if (string.IsNullOrWhiteSpace(textbox.BindingName)) continue;
                                    bindingname = textbox.BindingName;
                                    string text = string.IsNullOrWhiteSpace(textbox.FileName) == true ? textbox.Text : textbox.FileName;
                                    SetProperty(bindingname, obj, text);
                                }
                                else
                                    if (ctrl is AutoCombobox)
                                    {
                                        AutoCombobox combobox = ctrl as AutoCombobox;
                                        if (combobox.BindingFor != ObjectName) continue;
                                        if (string.IsNullOrWhiteSpace(combobox.BindingName)) continue;
                                        bindingname = combobox.BindingName;
                                        SetProperty(bindingname, obj, combobox.SelectedValue);
                                    }
                                    else
                                        if (ctrl is AutoSearchCombobox)
                                        {
                                            AutoSearchCombobox combobox = ctrl as AutoSearchCombobox;
                                            if (combobox.BindingFor != ObjectName) continue;
                                            if (string.IsNullOrWhiteSpace(combobox.BindingName)) continue;
                                            bindingname = combobox.BindingName;
                                            if (combobox.GetSelectedText == true)
                                                SetProperty(bindingname, obj, combobox.Text);
                                            else
                                                SetProperty(bindingname, obj, combobox.SelectedValue);
                                        }

                                        else
                                            if (ctrl is AutoDatetime)
                                            {
                                                AutoDatetime dtp = ctrl as AutoDatetime;
                                                if (dtp.BindingFor != ObjectName) continue;
                                                if (string.IsNullOrWhiteSpace(dtp.BindingName)) continue;
                                                bindingname = dtp.BindingName;
                                                SetProperty(bindingname, obj, dtp.Value);
                                            }
                                            else
                                                if (ctrl is AutoXDatetime)
                                                {
                                                    AutoXDatetime dtp = ctrl as AutoXDatetime;
                                                    if (dtp.BindingFor != ObjectName) continue;
                                                    if (string.IsNullOrWhiteSpace(dtp.BindingName)) continue;
                                                    bindingname = dtp.BindingName;
                                                    SetProperty(bindingname, obj, dtp.DateTime);
                                                }
                                                else
                                                    if (ctrl is AutoPictureBox)
                                                    {
                                                        AutoPictureBox ptb = ctrl as AutoPictureBox;
                                                        if (ptb.BindingFor != ObjectName) continue;
                                                        if (string.IsNullOrWhiteSpace(ptb.BindingName)) continue;
                                                        bindingname = ptb.BindingName;
                                                        SetProperty(bindingname, obj, ptb.PictureName);
                                                        if (!string.IsNullOrWhiteSpace(ptb.PictureOriginPath))
                                                        {
                                                            PictureUtility.SaveImg(ptb.PictureOriginPath);
                                                        }
                                                    }
                if (ctrl is AutoMaterialCheckBox)
                {
                    AutoMaterialCheckBox cb = ctrl as AutoMaterialCheckBox;
                    if (cb.BindingFor != ObjectName) continue;
                    if (string.IsNullOrWhiteSpace(cb.BindingName)) continue;
                    bindingname = cb.BindingName;
                    SetProperty(bindingname, obj, cb.Checked);
                }
                if (ctrl.Controls.Count > 0)
                {
                    GetAutoBindingData(ctrl, obj);
                }
            }
        }
        public static void GetSingleCtrlAutoBindingData(Control ctrl, object obj)
        {
            string ObjectName = obj.GetType().Name;
            string bindingname = "";
            if (ctrl is AutoTextBox)
            {
                AutoTextBox textbox = ctrl as AutoTextBox;
                if (textbox.BindingFor == ObjectName)
                {
                    if (!string.IsNullOrWhiteSpace(textbox.BindingName))
                    {
                        bindingname = textbox.BindingName;
                        SetProperty(bindingname, obj, textbox.Text);
                    }
                }
            }
            else
                if (ctrl is TextBoxValidation)
                {
                    TextBoxValidation textbox = ctrl as TextBoxValidation;
                    if (textbox.BindingFor == ObjectName)
                    {
                        if (!string.IsNullOrWhiteSpace(textbox.BindingName))
                        {
                            bindingname = textbox.BindingName;
                            SetProperty(bindingname, obj, textbox.Text);
                        }
                    }
                }
                else
                    if (ctrl is StatusTextbox)
                    {
                        StatusTextbox textbox = ctrl as StatusTextbox;
                        if (textbox.BindingFor == ObjectName)
                        {
                            if (!string.IsNullOrWhiteSpace(textbox.BindingName))
                            {
                                bindingname = textbox.BindingName;
                                SetProperty(bindingname, obj, textbox.Text);
                            }
                        }
                    }
                    else
                        if (ctrl is AutoMetroTextBox)
                        {
                            AutoMetroTextBox textbox = ctrl as AutoMetroTextBox;
                            if (textbox.BindingFor == ObjectName)
                            {
                                if (!string.IsNullOrWhiteSpace(textbox.BindingName))
                                {
                                    bindingname = textbox.BindingName;
                                    SetProperty(bindingname, obj, textbox.Text);
                                }
                            }
                        }
                        else
                            if (ctrl is AutoFileTextBox)
                            {
                                AutoFileTextBox textbox = ctrl as AutoFileTextBox;
                                if (textbox.BindingFor == ObjectName)
                                {
                                    if (!string.IsNullOrWhiteSpace(textbox.BindingName))
                                    {
                                        bindingname = textbox.BindingName;
                                        SetProperty(bindingname, obj, textbox.FileName);
                                    }
                                }
                            }
                            else
                                if (ctrl is AutoCombobox)
                                {
                                    AutoCombobox combobox = ctrl as AutoCombobox;
                                    if (combobox.BindingFor == ObjectName)
                                    {
                                        if (!string.IsNullOrWhiteSpace(combobox.BindingName))
                                        {
                                            bindingname = combobox.BindingName;
                                            SetProperty(bindingname, obj, combobox.SelectedValue);
                                        }
                                    }
                                }
                                else
                                    if (ctrl is AutoSearchCombobox)
                                    {
                                        AutoSearchCombobox combobox = ctrl as AutoSearchCombobox;
                                        if (combobox.BindingFor == ObjectName)
                                        {
                                            if (!string.IsNullOrWhiteSpace(combobox.BindingName))
                                            {
                                                bindingname = combobox.BindingName;
                                                if (combobox.GetSelectedText == true)
                                                    SetProperty(bindingname, obj, combobox.Text);
                                                else
                                                    SetProperty(bindingname, obj, combobox.SelectedValue);
                                            }
                                        }
                                    }

                                    else
                                        if (ctrl is AutoDatetime)
                                        {
                                            AutoDatetime dtp = ctrl as AutoDatetime;
                                            if (dtp.BindingFor == ObjectName)
                                            {
                                                if (!string.IsNullOrWhiteSpace(dtp.BindingName))
                                                {
                                                    bindingname = dtp.BindingName;
                                                    SetProperty(bindingname, obj, dtp.Value);
                                                }
                                            }
                                        }
                                        else
                                            if (ctrl is AutoXDatetime)
                                            {
                                                AutoXDatetime dtp = ctrl as AutoXDatetime;
                                                if (dtp.BindingFor == ObjectName)
                                                {
                                                    if (!string.IsNullOrWhiteSpace(dtp.BindingName))
                                                    {
                                                        bindingname = dtp.BindingName;
                                                        SetProperty(bindingname, obj, dtp.DateTime);
                                                    }
                                                }
                                            }
                                            else
                                                if (ctrl is AutoPictureBox)
                                                {
                                                    AutoPictureBox ptb = ctrl as AutoPictureBox;
                                                    if (ptb.BindingFor == ObjectName)
                                                    {
                                                        if (!string.IsNullOrWhiteSpace(ptb.BindingName))
                                                        {
                                                            bindingname = ptb.BindingName;
                                                            SetProperty(bindingname, obj, ptb.PictureName);
                                                            if (!string.IsNullOrWhiteSpace(ptb.PictureOriginPath))
                                                            {
                                                                PictureUtility.SaveImg(ptb.PictureOriginPath);
                                                            }
                                                        }
                                                    }
                                                }
        }
    }
}
