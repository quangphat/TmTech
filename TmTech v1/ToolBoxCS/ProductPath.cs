using System;
using System.Drawing;
using System.Windows.Forms;

namespace TmTech_v1.ToolBoxCS
{
    public partial class ProductPath : UserControl
    {
        public ProductPath()
        {
            InitializeComponent();
        }
        public void Show(string CategoryName, string SerieName, string LineName)
        {
            if (string.IsNullOrWhiteSpace(CategoryName))
            {
                linkCategory.Visible = linkSerie.Visible = linkLine.Visible = lblDivide1.Visible = lblDivide2.Visible = false;
                //return;
            }
            else
            {
                linkCategory.Visible = true;
                linkCategory.Text = CategoryName;
            }
            if (string.IsNullOrWhiteSpace(SerieName))
            {
                linkSerie.Visible = linkLine.Visible = lblDivide1.Visible = lblDivide2.Visible = false;
                //return;
            }
            else
            {
                lblDivide1.Visible = true;
                linkSerie.Visible = true;
                linkSerie.Text = SerieName;
            }
            if (string.IsNullOrWhiteSpace(LineName))
            {
                linkLine.Visible = lblDivide2.Visible = false;
                //return;
            }
            else
            {
                lblDivide2.Visible = true;
                linkLine.Visible = true;
                linkLine.Text = LineName;
            }
            setPosition();
        }
        public void Show(Model.Product product)
        {
            if (product.Category == null)
                product.Category = new Model.Category();
            if (product.Series == null) product.Series = new Model.Series();
            if (product.Productline == null) product.Productline = new Model.ProductLine();
            Show(product.Category.CategoryName, product.Series.SerieName, product.Productline.ProductLineName);
        }
        private void setPosition()
        {
            lblDivide1.Location = new Point(linkCategory.Location.X + linkCategory.Width + 2,lblDivide1.Location.Y);
            linkSerie.Location = new Point(lblDivide1.Location.X + lblDivide1.Width + 2, linkSerie.Location.Y);
            lblDivide2.Location = new Point(linkSerie.Location.X + linkSerie.Width + 2, lblDivide2.Location.Y);
            linkLine.Location = new Point(lblDivide2.Location.X + lblDivide2.Width + 2, linkLine.Location.Y);
        }
        public delegate void delgSearchByName(string name);
        public delgSearchByName SearchByName;
        private void linkSerie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (SearchByName != null) SearchByName(linkSerie.Text);
        }

        private void linkLine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (SearchByName != null) SearchByName(linkLine.Text);
        }

        private void linkCategory_LinkClicked(object sender, EventArgs e)
        {
            if (SearchByName != null) SearchByName(linkCategory.Text);
        }
    }
}
