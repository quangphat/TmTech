using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TmTech_v1.CustomModel;
using TmTech_v1.Model;

namespace TmTech_v1.View
{
    public partial class frmSelectProduct : UserControl
    {
        Panel m_PnlRight;
        public frmSelectProduct()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        public frmSelectProduct(Panel pnel)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            m_PnlRight = pnel;
        }
        private void frmProductListView_Load(object sender, EventArgs e)
        {
        }
        public void BindProductToListView(IList<Product> lstProduct)
        {
            listView1.Items.Clear();
            listView1.Clear();
            listView1.DataBindings.Clear();
            listView1.Update();
            listView1.Refresh();
            if (lstProduct != null)
                AddProductToListView(lstProduct);
        }
        private void AddProductToListView(IList<Product> lstProduct)
        {
            ImageList imgList = new ImageList();
            foreach (Product p in lstProduct)
            {
                if (!string.IsNullOrWhiteSpace(p.PhotoPath))
                {
                    Image img = Image.FromFile(p.PhotoPath);
                    imgList.Images.Add(img);
                }
                else
                {
                    Image img = Properties.Resources.unknow;
                    imgList.Images.Add(img);
                }
                //img.Dispose();
            }
            listView1.View = System.Windows.Forms.View.LargeIcon;
            imgList.ImageSize = new Size(100, 100);
            listView1.LargeImageList = imgList;
            for (int i = 0; i < lstProduct.Count; i++)
            {
                ProductTag tag = new ProductTag();
                tag.ProductId = lstProduct[i].ProductId;
                tag.ProductCode = lstProduct[i].ProductCode;
                tag.Photo = lstProduct[i].Photo;
                tag.Quantity = lstProduct[i].Quantity;
                tag.Price = lstProduct[i].Price;
                tag.Category = lstProduct[i].Category;
                tag.Serie = lstProduct[i].Series;
                tag.Line = lstProduct[i].Productline;
                if (listView1.Items.ContainsKey(tag.ProductCode))
                {
                    listView1.Items.RemoveByKey(tag.ProductCode);
                }
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Name = tag.ProductCode;
                item.Text = tag.ProductCode;
                item.Tag = tag;
                listView1.Items.Add(item);
            }
        }
        private void AddProductToListView(IList<CustomModel.CustomProduct> lstCustomProduct)
        {
            IList<Product> lstProduct = new List<Product>();
            foreach (CustomModel.CustomProduct custom in lstCustomProduct)
            {
                Product product = new Product();
                product.ProductId = custom.ProductId;
                product.ProductCode = custom.ProductCode;
                product.Photo = custom.Photo;
                product.Quantity = custom.Quantity;
                product.Price = custom.Price;
                lstProduct.Add(product);
            }
            AddProductToListView(lstProduct);
        }
        public delegate void delgShowProperty(Product product);
        public delgShowProperty ShowProperty;
        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems == null) return;
            ListViewItem item = listView1.SelectedItems[0];
            if (item == null) return;
            ProductTag tag = item.Tag as ProductTag;
            if (tag == null) return;
            Product product = new Product();
            product.ProductCode = tag.ProductCode;
            product.ProductId = tag.ProductId;
            product.Photo = tag.Photo;
            product.Price = tag.Price;
            product.Series = tag.Serie;
            product.Category = tag.Category;
            product.Productline = tag.Line;
            if (product == null) return;
            if (ShowProperty != null)
                ShowProperty(product);
        }

        
    }
}
