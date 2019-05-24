using ModernUI.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Model;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
using TmTech_v1.CustomModel;
namespace TmTech_v1.View
{
    public partial class frmEditPlanning : MetroForm
    {
        Planning m_Planning;
        Po m_Po;
        Product m_Product;
        GridUtility gridUtility;
        public frmEditPlanning(Planning planning)
        {
            InitializeComponent();
            m_Planning = planning;
            m_Po = planning.Po;
            m_Product = new Product();
            gridUtility = new GridUtility(gridControl1, false, false, 35);
            gridUtility.ColProductPicture = colPhoto;
            gridUtility.ColProductPicturePath = colImgPath;
            gridView1.RowHeight = 100;
            lblNotify1.Text = "";
        }
        private void InitializeForm(Planning planning)
        {
            if(m_Po!=null)
            {
                if (string.IsNullOrWhiteSpace(m_Planning.PlanningCode))
                    m_Planning.PlanningCode = m_Po.PoCode.Replace("PO", "PL");
                txtPOCode.Text = m_Po.PoCode;
            }
            txtPlanningCode.Text = m_Planning.PlanningCode;
        }
        private void AddProductToListView(IList<QuotationDetail> lstQuotationDetail)
        {
            ImageList imgList = new ImageList();
            foreach (QuotationDetail detail in lstQuotationDetail)
            {
                Image img = PictureUtility.GetImg(detail.Product.Photo);
                imgList.Images.Add(img);
                //img.Dispose();
            }
            listView1.View = System.Windows.Forms.View.LargeIcon;
            imgList.ImageSize = new Size(100, 100);
            listView1.LargeImageList = imgList;
            for (int i = 0; i < lstQuotationDetail.Count; i++)
            {
                ProductTag tag = new ProductTag();
                tag.ProductId = lstQuotationDetail[i].ProductId;
                tag.ProductCode = lstQuotationDetail[i].Product.ProductCode;
                tag.Photo = lstQuotationDetail[i].Product.PhotoPath;
                tag.Quantity = lstQuotationDetail[i].Quantity;
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

        private void BindToListView(Po po, IList<QuotationDetail> lstQuotationDetail)
        {
            m_Po = po;
            m_Planning.PlanningCode = m_Po.PoCode.Replace("PO", "PL");
            txtPOCode.Text = m_Po.PoCode;
            txtPlanningCode.Text = m_Planning.PlanningCode;
            AddProductToListView(lstQuotationDetail);
        }

        private void frmEditPlanning_Load(object sender, EventArgs e)
        {
            InitializeForm(m_Planning);
            IList<QuotationDetail> lstProduct;
            using(IUnitOfWork uow = new UnitOfWork())
            {
                lstProduct = uow.PlanningRepository.GetAllProduct(m_Planning.PlanningCode);
                uow.Commit();

            }
            if(lstProduct!=null)
            {
                AddProductToListView(lstProduct);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems == null) return;
            ListViewItem item = listView1.SelectedItems[0];
            if (item == null) return;
            ProductTag tag = item.Tag as ProductTag;
            if (tag == null) return;
            txtProductQuantity.Text = tag.Quantity.ToString();
            m_Product.ProductId = tag.ProductId;
            m_Product.Quantity = tag.Quantity;
            ShowProductMaterial(m_Product);
        }
        private void ShowProductMaterial(Product product)
        {
            IList<Model.Material> lstMaterial;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstMaterial = uow.MaterialRepository.GetMaterialByProductId(product.ProductId, product.Quantity).Where(p => p.MaterialQuantity > 0).ToList();
                uow.Commit();
            }
            gridUtility.BindingData<Model.Material>( lstMaterial);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            m_Po = null;
            m_Planning = new Planning();
            m_Product = new Product();
            txtPlanningCode.ReadOnly = true;
            FormUtility.ResetForm(this);
            listView1.Items.Clear();
            gridControl1.DataSource = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddMaterialToProduct(IList<Model.Material> lstProductMaterial, Product product)
        {
            ProductUtility.AddMaterialToProduct(lstProductMaterial, product);
        }
        private bool AllowEditPlanning()
        {
            if (m_Planning.StatusId != 1)
            {
                FlatMessageBox.FlatMsgBox.Show(UI.planningcouldnotbeedit);
                return false;
            }
            return true;
        }

       
        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (m_Planning == null) return;
            m_Planning.StatusId = 3;
            m_Planning.ModifyBy = UserManagement.UserSession.UserName;
            m_Planning.ModifyDate = DateTime.Now;
            using(IUnitOfWork uow = new UnitOfWork())
            {
                uow.PlanningRepository.Update(m_Planning);
                uow.Commit();
            }
            Close();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            gridUtility.DrawColorForStock(sender, e, colTonkho);
        }
    }
}
