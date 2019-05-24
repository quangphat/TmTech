using System.Drawing;
using System.Windows.Forms;
using TmTech_v1.ToolBoxCS;
using System.Linq;
using System.Text.RegularExpressions;
using TmTech.Resource;

namespace TmTech_v1.Utility
{
    public static class ValidationUtility
    {
        static bool isvalid = true;
        public static bool ContainsUnicodeCharacter(string input)
        {
            const int MaxAnsiCode = 255;
            return input.ToCharArray().Any(c => c > MaxAnsiCode);
        }
        public static bool IsTextAllowed(string text)
        {
            return Regex.IsMatch(text, @"^[^\d\s]+$");
        }
        private static bool FieldNotAllowNull2(Control control)
        {


            if (control is TextBoxPassword)
            {
                if (control.Name.ToLower().Contains("txtrepassword"))
                {

                    TextBoxPassword objPassword = control.FindForm().Controls.Find("txtPassword", true).FirstOrDefault() as TextBoxPassword;
                    TextBoxPassword objRPassword = (TextBoxPassword)control;
                    if (!objPassword.Text.Equals(objRPassword.Text))
                    {
                        objRPassword.Text = "password not match";
                        objPassword.ForeColor = Color.Red;
                        objRPassword.ForeColor = Color.Red;
                        isvalid = false;
                    }
                    else
                    {
                        objPassword.ForeColor = Color.Black;
                        objRPassword.ForeColor = Color.Black;
                    }

                }
            }
            else if (control is TextboxPhone)
            {
                
                var txtTextboxPhone = (TextboxPhone)control;
               
                if (!IsPhoneNumber(txtTextboxPhone.Text))
                {
                    txtTextboxPhone.Text = Validation.PhoneNotFormat;
                    txtTextboxPhone.ForeColor = Color.Red;
                }
                else
                {
                    txtTextboxPhone.ForeColor = Color.Black;
                }
            }
            else if (control is TextBoxValidation)
            {
                TextBoxValidation txtBoxValidation = (TextBoxValidation)control;

                if (txtBoxValidation.AllowNull == false)
                {
                    if (string.IsNullOrWhiteSpace(txtBoxValidation.Text) && txtBoxValidation.ForeColor != Color.Black)
                    {
                        txtBoxValidation.Text = "null";
                        txtBoxValidation.ForeColor = Color.Red;
                        isvalid = false;
                    }
                    else
                    {
                        txtBoxValidation.ForeColor = Color.Black;
                    }


                }




            }



            else if (control is TextboxEmail)
            {

                TextboxEmail obj = (TextboxEmail)control;
                if (obj.Text.Length > 0)
                {
                    if (UtilityFunction.IsValidEmailAddress(obj.Text))
                    {
                        obj.ForeColor = Color.Black;
                    }
                    else
                    {
                        obj.ForeColor = Color.Red;
                        isvalid = false;
                    }
                }





            }

            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                    FieldNotAllowNull2(child);
                }
            }
            return isvalid;
        }

        public static void EnableRead(Control ctrl)
        {


            foreach (Control ctr in ctrl.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = ctr as TextBox;

                    txt.ReadOnly = true;

                }


                if (ctr.Controls.Count > 0)
                {
                    foreach (Control childe in ctr.Controls)
                    {
                        EnableRead(childe);
                    }

                }
            }

        }

        public static bool FieldNotAllowNull(Control control1)
        {
            bool result = FieldNotAllowNull2(control1);
            isvalid = true;
            return result;
        }

        //public static string GetAccout(int? userID1)
        //{
        //    int userId = (userID1 != null) ? (int)userID1 : 0;
        //    if (userId == 0)
        //        return "";

        //    Users user = null;
        //    using (var uow = new UnitOfWork())
        //    {
        //        user = uow.UsersRepository.Find(userId);
        //        uow.Commit();
        //    }
        //    if (user != null)
        //    {
        //        return user.UserName;
        //    }
        //    return "";
        //}
        public static bool IsPhoneNumber(string number)
        {
            string regex = @"^\d{10,11}$";
            return StringIsNull(number) &&Regex.Match(number, regex).Success;
        }

        public static void OnlyRead(Control ctrl)
        {


            foreach (Control ctr in ctrl.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = ctr as TextBox;
                    txt.ReadOnly = true;

                }


                if (ctr.Controls.Count > 0)
                {
                    foreach (Control childe in ctr.Controls)
                    {
                        OnlyRead(childe);
                    }

                }
            }

        }




        public static bool StringIsNull(string input)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                return true;
            }
            return false;
        }
    }
}
