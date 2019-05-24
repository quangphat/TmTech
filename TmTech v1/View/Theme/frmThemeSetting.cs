using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ModernUI.Forms;

namespace TmTech_v1.View
{
    public partial class frmThemeSetting : MetroForm
    {
        frmPrimary frmPrimary;
        public frmThemeSetting()
        {
            InitializeComponent();
            frmPrimary = Application.OpenForms["frmPrimary"] as frmPrimary;
        }
        private void generateColorTheme()
        {
            List<UserTheme> lstTheme = UserTheme.generateTheme();
            foreach (UserTheme theme in lstTheme)
            {
                Panel _tile = new Panel();
                _tile.Size = new Size(30, 30);
                _tile.Margin = new Padding(5, 3, 0, 0);
                _tile.Tag = theme.Name;
                _tile.BackColor = ColorTranslator.FromHtml(theme.PrimaryColor);
                _tile.Cursor = Cursors.Hand;
                _tile.Click += _tile_Click;
                pnlTheme.Controls.Add(_tile);
            }
        }

        private delegate void delgChangeTheme(string themename);
        private void _tile_Click(object sender, EventArgs e)
        {
            delgChangeTheme delchangetheme = new delgChangeTheme(frmPrimary.ChangeTheme);
            string name = ((Panel)sender).Tag.ToString();
            delchangetheme(name);
        }

        private void frmThemeSetting_Load(object sender, EventArgs e)
        {
            generateColorTheme();
        }

        public delegate void delgSaveTheme();
        private void btSaveTheme_Click(object sender, EventArgs e)
        {
            delgSaveTheme delgSaveTheme = new delgSaveTheme(frmPrimary.SaveTheme);
            delgSaveTheme();
        }
    }
}
