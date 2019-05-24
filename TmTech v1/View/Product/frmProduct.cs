using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
using TmTech_v1.ToolBoxCS;
using TmTech_v1.Model;
using System.IO;
using TmTech.Resource;
using TmTech_v1.CustomModel;
using Microsoft.Win32;

namespace TmTech_v1.View
{
    public partial class frmProduct : UserControl
    {
        Product m_Product;
        GridUtility gridUtility;
        List<ProductPicture> lstPicture;
        IProductCategoryCtxMenu ICtxCategory;
        
        TreeNode m_SelectedNode = null;
        public frmProduct()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            lblNotify1.Text = string.Empty;
            //m_lstRowEdited = new List<Product>();
            lstPicture = null;
            FormUtility.FormatForm(this);
            gridUtility = new GridUtility(gridControl1);
            ICtxCategory = new CategoryContextMenu(treeView1);
            productPath1.Visible = false;
            //btnSave.Visible = false;
            SystemEvents.DisplaySettingsChanged += new
            EventHandler(SystemEvents_DisplaySettingsChanged);  
        }

        private void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1368;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 768;
            SizeF scale = new SizeF(widthRatio, heightRatio);
            this.Scale(scale);
            foreach (Control control in this.Controls)
            {
                //float fontsize = control.Font.SizeInPoints * heightRatio * widthRatio;
                float fontsize = 0;
                if (fontsize == 0) fontsize = 5;
                control.Font = new Font("Verdana", fontsize);
            }
        }
        public void LoadTree()
        {
            ProductUtility ProductUtility = new ProductUtility(treeView1);
            ProductUtility.BuildRoot();
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            ComboboxUtility.BindUnit(cbbDonvi);
        }
        private void InititalizeForm(Product product)
        {
            if (product.ProductId == Guid.Empty)
            {
                btnCreateProperty.Visible = false;
            }
            else
            {
                btnCreateProperty.Visible = true;
            }
            CoverObjectUtility.SetAutoBindingData(this, product);
            displayMultiplePicture1.ImgList = new string[5];
            displayMultiplePicture1.Show(lstPicture);
            productPath1.Visible = true;
            productPath1.SearchByName = searchByName;
            if (product.Productline == null) product.Productline = new ProductLine();
            productPath1.Show(product);
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
            int i = gridView1.GetSelectedRows().FirstOrDefault();
            m_Product = gridView1.GetRow(i) as Product;
            if (m_Product != null)
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    lstPicture = uow.ProductPictureRepository.FindByProduct(m_Product);
                    uow.Commit();
                }
                InititalizeForm(m_Product);
            }
        }

        private void SetCtrlException()
        {
            treeView1.Enabled = true;
            gridControl1.Enabled = true;
            btnCreate.Enabled = true;
        }
        protected override Point ScrollToControl(Control activeControl)
        {
            return AutoScrollPosition;
        }
        private void bootstrapButton1_Click(object sender, EventArgs e)
        {
            FormUtility.CloseCurrentTab();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateProduct frmCreate = new frmCreateProduct();
            frmCreate.Show();
            FormUtility.ShowPopup();
        }


        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            searchByName(txtSearch.Text);
        }
        private void OpenTreeNode(int categoryId)
        {
            if (treeView1.SelectedNode == null)
                treeView1.SelectedNode = treeView1.Nodes[0];
            if (treeView1.SelectedNode.Tag.ToString() == categoryId.ToString())
                return;
            TreeNode node = FindNodeByName(treeView1.Nodes, categoryId);
            if (node != null)
            {
                expandNode(node);
                treeView1.SelectedNode = node;
                treeView1.Focus();
            }
                
        }
        private void expandNode(TreeNode node)
        {
            if (node == null)
                return;
            if (node.Level != 0) //check if it is not root
            {
                node.Expand();
                expandNode(node.Parent);
            }
            else
            {
                node.Expand(); // this is root 
            }
        }
        TreeNode FindNodeByName(TreeNodeCollection NodesCollection, int categoryId)
        {
            TreeNode returnNode = null; // Default value to return
            foreach (TreeNode checkNode in NodesCollection)
            {
                if (checkNode.Tag.ToString() == categoryId.ToString())  //checks if this node name is correct
                    returnNode = checkNode;
                else if (checkNode.Nodes.Count > 0) //node has child
                {
                    returnNode = FindNodeByName(checkNode.Nodes, categoryId);
                }

                if (returnNode != null) //check if founded do not continue and break
                {
                    return returnNode;
                }

            }
            return returnNode;
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Return)
            {
                searchByName(txtSearch.Text);
            }
        }
        private void searchByName(string text)
        {
            IList<Product> lstProduct;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstProduct = uow.ProductRepository.FindByName(text);
                uow.Commit();
            }
            gridUtility.BindingData<Product>(lstProduct);
            Product first = lstProduct.FirstOrDefault();
            if (first == null) return;
            OpenTreeNode(first.SeriesId);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUtility.OpenImage(pictureBox2);
        }

        public void SetTextboxReadOnly(bool isReadOnly)
        {
            FormUtility.SetTexboxReadOnly(this, isReadOnly);
        }
        private void AddNodeToTree(TreeNode newNode)
        {
            TreeNode parentNode = treeView1.SelectedNode;
            TreeTag parentTag = parentNode.Tag as TreeTag;
            TreeTag newnodeTag = newNode.Tag as TreeTag;
            treeView1.BeginUpdate();
            if(parentTag.NodeTye == newnodeTag.NodeTye)
            {
                parentNode = parentNode.PrevNode;
                if (parentNode == null)
                    treeView1.Nodes.Add(newNode);
                else
                    parentNode.Nodes.Add(newNode);
            }
            else
            {
                parentNode.Nodes.Add(newNode);
            }
            treeView1.EndUpdate();
            treeView1.Refresh();
        }
        private void updateNode(TreeNode node)
        {
            treeView1.BeginUpdate();
            treeView1.SelectedNode.Name = node.Name;
            treeView1.SelectedNode.Text = node.Name;
            treeView1.SelectedNode.Tag = node.Tag;
            treeView1.EndUpdate();
            treeView1.Refresh();
        }

        private void tsEditCate_Click(object sender, EventArgs e)
        {
            TreeTag treetag = treeView1.SelectedNode.Tag as TreeTag;
            Category cate;
            using(IUnitOfWork uow = new UnitOfWork())
            {
                cate = uow.CategoryRepository.Find(treetag.CateId);
                uow.Commit();
            }
            if (cate == null) return;
            frmEditCategory frmEdit = new frmEditCategory(cate);
            Enabled = false;
            frmEdit.UpdateNode = updateNode;
            frmEdit.Show();
            Enabled = true;
        }


        private void AddMaterialToProduct(IList<Model.Material> lstProductMaterial,Product product)
        {
            ProductUtility.AddMaterialToProduct(lstProductMaterial, product);
        }
        private void linkMaterial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Product product = gridUtility.GetSelectedItem<Product>() as Product;
            frmMaterialList frmView;
            if(product==null)
            {
                frmView = new frmMaterialList();
            }
            else
            {
                frmView = new frmMaterialList(product);
                frmView.AddToProduct = AddMaterialToProduct;
            }
            frmView.ShowDialog();
        }

        private void bootstrapButton1_Click_1(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false) return;
            if (m_Product == null) return;
            CoverObjectUtility.GetAutoBindingData(this, m_Product);
            SaveProduct();
        }
        private void btnCreateProperty_Click(object sender, EventArgs e)
        {
            frmProductProperty frmproperty = new frmProductProperty(m_Product);
            frmproperty.Show();
        }

        private void btnUdatePrice_Click(object sender, EventArgs e)
        {
            frmProductPrice frmProductPrice = new frmProductPrice(m_Product);
            frmProductPrice.UpdatePrice = InititalizeForm;
            frmProductPrice.ShowDialog();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            Product product = gridUtility.GetSelectedItem<Product>() as Product;
            frmMaterialList frmView;
            if (product == null)
            {
                frmView = new frmMaterialList();
            }
            else
            {
                frmView = new frmMaterialList(product);
                frmView.AddToProduct = AddMaterialToProduct;
            }
            frmView.ShowDialog();
        }

        private void btnViewMaterial_Click(object sender, EventArgs e)
        {
            Product product = gridUtility.GetSelectedItem<Product>() as Product;
            if (product == null)
            {
                FlatMessageBox.FlatMsgBox.Show(UI.producthasnomaterial);
                return;
            }
            frmProductMaterial frmView = new frmProductMaterial(product);
            frmView.ShowDialog();
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            IList<Product> lstProduct;
            TreeTag treeTag= null;
            if (e.Node == null)
            {
                lstProduct = new List<Product>();
                gridUtility.BindingData<Product>(lstProduct);
            }
            else
            {
                treeTag = e.Node.Tag as TreeTag;
                treeView1.SelectedNode = e.Node;

                if (e.Button == MouseButtons.Left)
                {
                    if (treeTag == null) return;
                    lstProduct = ProductUtility.FindProductByParent(treeTag);
                    gridUtility.BindingData<Product>(lstProduct);
                }
                if (e.Button == MouseButtons.Right)
                {
                    ICtxCategory.Show(treeView1.SelectedNode);
                }
            }
            lstPicture = null;
            m_Product = new Product();
            m_Product.Category = new Category();
            m_Product.Category.CategoryName = treeTag.CateName;
            m_Product.Series = new Series();
            m_Product.Series.SerieName = treeTag.SerieName;
            m_Product.SeriesId = treeTag.SerieId;
            m_Product.Productline = new ProductLine();
            m_Product.Productline.ProductLineName = treeTag.LineName;
            m_Product.ProductLineId = treeTag.LineId;
            InititalizeForm(m_Product);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FileInformation finfo  = FileUtility.OpenFile();
            txtInstallGuide.Text = finfo.FileName;
            txtInstallGuide.FilePath = finfo.FilePath;
            txtInstallGuide.FileName = finfo.FileName;
            txtInstallGuide.Tag = finfo.FilePath;
        }
        private void SaveProduct()
        {
            if (!string.IsNullOrWhiteSpace(pictureBox2.PictureOriginPath))
            {
                PictureUtility.SaveImg(pictureBox2.PictureOriginPath);
            }
            if (!string.IsNullOrWhiteSpace(txtInstallGuide.FilePath))
            {
                FileUtility.SaveToServer(txtInstallGuide.FileName, txtInstallGuide.FilePath);
            }
            if (!string.IsNullOrWhiteSpace(txtDatasheet.Text))
            {
                FileUtility.SaveToServer(txtDatasheet.FileName, txtDatasheet.FilePath);
            }
            if (!string.IsNullOrWhiteSpace(txtCard3D.FilePath))
            {
                FileUtility.SaveToServer(txtCard3D.FileName, txtCard3D.FilePath);
            }
            if (!string.IsNullOrWhiteSpace(txtDimension.FilePath))
            {
                PictureUtility.SaveImg(txtDimension.FilePath);
            }
            using (IUnitOfWork uow = new UnitOfWork())
            {
                if (m_Product.ProductId == Guid.Empty)
                {
                    uow.ProductRepository.Add(m_Product);
                    gridUtility.AddNewRow<Product>(m_Product);
                }
                else
                {
                    uow.ProductRepository.Update(m_Product);
                    gridUtility.UpdateRow<Product>(m_Product);
                }
                if (displayMultiplePicture1.ImgList != null)
                {
                    for (int i = 0; i < displayMultiplePicture1.ImgList.Length; i++)
                    {
                        if (!string.IsNullOrWhiteSpace(displayMultiplePicture1.ImgList[i]))
                        {
                            ProductPicture picture = new ProductPicture();
                            picture.ProductId = m_Product.ProductId;
                            picture.Picture = displayMultiplePicture1.ImgList[i];
                            uow.ProductPictureRepository.Add(picture);
                        }
                    }
                }
                uow.Commit();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false) return;
            if (m_Product == null) return;
            CoverObjectUtility.GetAutoBindingData(this, m_Product);
            
            try
            {
                SaveProduct();
                //gridUtility.UpdateRow<Product>(m_Product);
                lblNotify1.SetText(UI.success, LabelNotify.EnumStatus.Success);
            }
            catch
            {
                lblNotify1.SetText(UI.failed, LabelNotify.EnumStatus.Failed);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.Yes)
            {
                int i = gridView1.GetSelectedRows().FirstOrDefault();
                Product product = gridView1.GetRow(i) as Product;
                if (product == null) return;
                try
                {
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        uow.ProductRepository.Remove(product);
                        uow.Commit();
                    }
                    gridView1.DeleteRow(i);
                }
                catch
                {
                    lblNotify1.SetText(UI.removefailed, LabelNotify.EnumStatus.Failed);
                }
            }
            else
                return;
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            lstPicture = null;
            InititalizeForm(new Product());
        }

        private void linkAddDimension_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = PictureUtility.filter;
            op.ShowDialog();
            if (ValidationUtility.StringIsNull(op.FileName)) return;
            FileInfo finfo = new FileInfo(op.FileName);
            txtDimension.Text = finfo.Name;
            txtDimension.FileName = finfo.Name;
            txtDimension.FilePath = op.FileName;
        }

        private void btnViewDimension_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDimension.FilePath))
            {
                string fullpath = PictureUtility.getImgLocation(txtDimension.FileName);
                if (string.IsNullOrWhiteSpace(fullpath)) return;
                System.Diagnostics.Process.Start(fullpath);
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            txtDimension.FileName = "";
            txtDimension.FilePath = "";
            txtDimension.Text = "";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FileInformation finfo = FileUtility.OpenFile();
            txtDatasheet.Text = finfo.FileName;
            txtDatasheet.FilePath = finfo.FilePath;
            txtDatasheet.Tag = finfo.FilePath;
            txtDatasheet.FileName = finfo.FileName;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FileInformation finfo = FileUtility.OpenFile();
            txtCard3D.Text = finfo.FileName;
            txtCard3D.FilePath = finfo.FilePath;
            txtCard3D.Tag = finfo.FilePath;
            txtCard3D.FileName = finfo.FileName;
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

     
    }
}
