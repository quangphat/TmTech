using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TmTech_v1.Model;
using TmTech_v1.Utility;
using TmTech_v1.CustomModel;
using TmTech_v1.Interface;

namespace TmTech_v1.View
{
    public partial class frmPlanningDetail : UserControl
    {
        Planning m_Planning;
        Po m_Po;
        Product m_Product;
        GridUtility gridUtility;
        GridUtility gridUtility2;
        public frmPlanningDetail(Planning planning)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            m_Planning = planning;
            m_Po = planning.Po;
            m_Product = new Product();
            gridUtility = new GridUtility(gridControl1, false, false, 35);
            gridUtility2 = new GridUtility(gridControl2, false, false);
            gridUtility.ColProductPicture = colPhoto;
            gridUtility.ColProductPicturePath = colImgPath;
            gridView1.RowHeight = 100;
            lblNotify1.Text = "";
        }
        public delegate void delgCloseThisForm();
        public delgCloseThisForm CloseThisForm;
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
                //if (listView1.Items.ContainsKey(tag.ProductCode))
                //{
                //    listView1.Items.RemoveByKey(tag.ProductCode);
                //}
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
            AddProductToListView(lstQuotationDetail);
        }

        private void frmPlanningDetail_Load(object sender, EventArgs e)
        {
            IList<QuotationDetail> lstProduct;
            IList<Planning> lstPlanning = new List<Planning>() { m_Planning };
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstProduct = uow.PlanningRepository.GetAllProduct(m_Planning.PlanningCode);
                uow.Commit();
            }
            if (lstProduct != null)
            {
                AddProductToListView(lstProduct);
            }
            gridUtility2.BindingData<Planning>(lstPlanning);
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
            gridUtility.BindingData<Model.Material>(lstMaterial);
        }
        private void AddMaterialToProduct(IList<Model.Material> lstProductMaterial, Product product)
        {
            ProductUtility.AddMaterialToProduct(lstProductMaterial, product);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (m_Planning == null) return;
            if (m_Planning.StatusId == (int)ProgressStatus.Finish) return;
            m_Planning.StatusId = (int)ProgressStatus.Finish;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.PlanningRepository.Update(m_Planning);
                uow.Commit();
            }
            gridUtility2.UpdateRow<Planning>(m_Planning);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            gridUtility.DrawColorForStock(sender, e, colTonkho);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (CloseThisForm != null)
                CloseThisForm();
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility2.SetRowColor();
        }

        private void gridView2_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            gridUtility2.DrawColorForPlanning(sender, e, colStatus, colDisplayColor,colDayleft);
        }

        private void btnCancelPlanning_Click(object sender, EventArgs e)
        {
            if (m_Planning == null) return;
            if (m_Planning.StatusId == (int)ProgressStatus.Finish || m_Planning.StatusId==(int)ProgressStatus.Cancel) return;
            m_Planning.StatusId = (int)ProgressStatus.Cancel;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.PlanningRepository.Update(m_Planning);
                uow.Commit();
            }
            gridUtility2.UpdateRow<Planning>(m_Planning);
        }
    }
}
