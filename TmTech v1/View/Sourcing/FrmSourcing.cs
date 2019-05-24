using System;
using System.Drawing;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.ToolBoxCS;
using TmTech_v1.Utility;

namespace TmTech_v1.View.Sourcing
{
    public partial class FrmSourcing : UserControl
    {

        public static bool isLoad = false;

        string currentImagePath = string.Empty;
        int currentSelecSupplier = -1;

        Part isCreateNew = new Part();
        Boolean isInsert = false;
        Model.Sourcing isSourcing = new Model.Sourcing();
        Boolean isUpdate = false;
        Part isUpdatePart = new Part();

        TreeTagPart mainCreate = new TreeTagPart();
        TreeTagPart mainUpdate = new TreeTagPart();
        PartBackUp objBackUp = null;
        public delgAddTab AddTab;
        
        public FrmSourcing()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            txtNamePart.ReadOnly = true;
            txtPricePart.ReadOnly = true;
            cboSupplier.Enabled = false;
            lblNotify1.Text = string.Empty;
        }

        public delegate void delgAddTab(UserControl uCtrl);

        private void AddNodeToTree(TreeNode newNode)
        {

            TreeNode parentNode = treeView1.SelectedNode;
            TreeTagPart parentTag = parentNode.Tag as TreeTagPart;
            TreeTagPart newnodeTag = newNode.Tag as TreeTagPart;
            if (parentNode == null)
            {
                parentNode = treeView1.TopNode;
            }
            treeView1.BeginUpdate();
            if (parentTag.NodeTye == newnodeTag.NodeTye)
            {
                parentNode = parentNode.Parent;
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

        private void bootstrapButton1_Click(object sender, EventArgs e)
        {
            if (isInsert == false && isUpdate == false)
            {
                lblNotify1.SetText("không có thao tác", LabelNotify.EnumStatus.Failed);
                return;
            }

            if (isInsert)
            {
                if (ValidationUtility.FieldNotAllowNull(this) == false) return;
                if (isCreateNew.SeriesPartID < 0)
                {
                    lblNotify1.SetText("thiếu thông tin về series ID", LabelNotify.EnumStatus.Failed);
                    return;
                }


                if (txtPricePart.Text == string.Empty)
                {

                }

                try
                {
                    decimal.Parse(txtPricePart.Text);
                }
                catch (Exception)
                {

                    lblNotify1.SetText("Chưa nhập giá hoặc giá không chính x", LabelNotify.EnumStatus.Failed);
                    txtPricePart.Focus();
                    return;
                }


                if (cboSupplier.SelectedValue == null)
                {
                    lblNotify1.SetText("Chưa nhập thông tin nhà cung cấp", LabelNotify.EnumStatus.Failed);

                }

                if (PictureImage.Tag != null)
                {
                    isCreateNew.ImagePath = PictureUtility.SaveImg(PictureImage.Tag.ToString());
                }



                SaveSourcing(isCreateNew);


            }
            else if (isUpdate)
            {
                Update();

            }



        }

        private void bootstrapButton2_Click(object sender, EventArgs e)
        {

            if (isInsert == false && isUpdate == false)
            {
                if (objBackUp != null)
                {
                    txtNamePart.Text = objBackUp.PartName;
                    txtDescription.Text = objBackUp.Description;
                    txtNumberPart.Text = objBackUp.PartName;
                    txtPricePart.Text = objBackUp.Pricespart > 0 ? objBackUp.Pricespart.ToString() : string.Empty;
                    PictureImage.Image = objBackUp.ImageBackUp;
                    PictureUtility.BindImage(PictureImage, objBackUp.ImagePath);
                    cboSupplier.SelectedValue = currentSelecSupplier;
                    currentSelecSupplier = -1;
                    objBackUp = null;
                }

                txtNamePart.ReadOnly = txtDescription.ReadOnly = txtNumberPart.ReadOnly = txtPricePart.ReadOnly = true;
                treeView1.Select();

                return;
            }

            DialogResult result = FormUtility.MscWarming();
            if (result == DialogResult.Yes)
            {
                if (objBackUp != null)
                {
                    txtNamePart.Text = objBackUp.PartName;
                    txtDescription.Text = objBackUp.Description;
                    txtNumberPart.Text = objBackUp.PartName;
                    txtPricePart.Text = objBackUp.Pricespart > 0 ? objBackUp.Pricespart.ToString() : string.Empty;
                    PictureUtility.BindImage(PictureImage, objBackUp.ImagePath);
                    cboSupplier.SelectedValue = currentSelecSupplier;
                    currentSelecSupplier = -1;
                    objBackUp = null;
                }

                txtNamePart.ReadOnly = txtDescription.ReadOnly = txtNumberPart.ReadOnly = txtPricePart.ReadOnly = true;

                if (isInsert == true || isUpdate == true)
                {
                    TreeNode nodeSelect = treeView1.SelectedNode;

                    DisplayInformation(nodeSelect);
                    isInsert = false;
                    isUpdate = false;

                }
                else
                {
                    TreeNode nodeSelect = treeView1.SelectedNode;

                    DisplayInformation(nodeSelect);
                }

            }
            else
                return;


        }

        private void cboSupplier_DropDown(object sender, EventArgs e)
        {
            if (isLoad)
            {
                isLoad = false;
                ComboboxUtility.BindSupplier(cboSupplier);
            }
        }

        private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSupplier_SelectedValueChanged(object sender, EventArgs e)
        {

            TmTech_v1.Model.Supplier selectSuppler;
            if (cboSupplier.SelectedItem == null)

            {
                return;

            }


            selectSuppler = cboSupplier.SelectedItem as TmTech_v1.Model.Supplier;
            if (selectSuppler == null)
                return;
            int idSupplier = selectSuppler.SupplierId;
            SubSupplier selectSubSupplier;

            using (UnitOfWork uow = new UnitOfWork())
            {
                selectSuppler = uow.SupplierRepository.Find(idSupplier);
                selectSubSupplier = uow.SubSupplierRepository.FindMainSubsupplier(idSupplier);
                uow.Commit();
            }
            if (selectSuppler != null)
            {
                txtSupplierID.Text = selectSuppler.SupplierCode;
                txtSupplierName.Text = selectSuppler.SupplierName;
                txtWebsite.Text = selectSuppler.Website;
                txtSupplierDesScrition.Text = selectSuppler.Note;
            }

            if (selectSubSupplier != null)
            {
                txtNameContact.Text = selectSubSupplier.SubSupplierName;
                txtPhoneContact.Text = selectSubSupplier.Phone;
            }

        }

        private void createSourcingToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TreeTagPart treetag = treeView1.SelectedNode.Tag as TreeTagPart;

            mainCreate = treetag;
            if (treetag != null)
                isCreateNew.SeriesPartID = treetag.SeriesPartIDTag;
            txtNamePart.Tag = txtNamePart.Text;
            objBackUp = new PartBackUp();

            objBackUp.PartName = txtNamePart.Text;
            objBackUp.Description = txtDescription.Text;
            objBackUp.PartName = txtNumberPart.Text;
            objBackUp.Pricespart = txtPricePart.Text != string.Empty ? decimal.Parse(txtPricePart.Text) : 0;
            objBackUp.ImagePath = PictureImage.Tag != null ? PictureImage.Tag.ToString() : null;

            objBackUp.ImagePath = currentImagePath;


            PictureUtility.BindImage(PictureImage, "@32121");

            txtNamePart.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtNumberPart.Text = string.Empty;
            txtPricePart.Text = string.Empty;
            PictureImage.InitialImage = null;
            ComboboxUtility.BindSupplier(cboSupplier);
            lbTitle.Text = "Create new sourcing";
            isInsert = true;
            isUpdate = false;
            txtPricePart.ReadOnly = false;
            txtNamePart.ReadOnly = false;
            txtDescription.ReadOnly = false;
            cboSupplier.Enabled = true;
            txtNumberPart.ReadOnly = false;






        }

        void DisplayInformation(TreeNode nodeInformation)
        {
            TreeTagPart treetag = nodeInformation.Tag as TreeTagPart;
            if (treetag == null)
                return;
            if (treetag.NodeTye != TreeTagPart.Types.Part)
                return;
            Part selectPart;
            Model.Sourcing selectSouring;
            txtPricePart.ReadOnly = true;
            txtNamePart.ReadOnly = true;
            txtDescription.ReadOnly = true;
            cboSupplier.Enabled = false;



            using (IUnitOfWork uow = new UnitOfWork())
            {
                selectPart = uow.PartBaseRepository.Find(treetag.PartIDTag);
                selectSouring = uow.SourcingBaseRepository.FindPartByIDPart(treetag.PartIDTag);
                uow.Commit();
            }
            if (selectPart == null) return;
            if (selectSouring == null) return;



            txtNamePart.Text = selectPart.PartName;
            txtPricePart.Text = (selectPart.Pricespart) > 0 ? selectPart.Pricespart.ToString() : "0";
            txtDescription.Text = selectPart.Description;
            cboSupplier.SelectedValue = selectSouring.SupplierID;
            currentSelecSupplier = selectSouring.SupplierID;

            txtNamePart.Focus();
            txtNumberPart.Text = selectPart.PartNumber;
            txtDescription.ReadOnly = true;
            lbTitle.Text = "Information detail sourcing";
            PictureUtility.BindImage(PictureImage, selectPart.ImagePath);

            if (selectPart.ImagePath != null)
            {
                currentImagePath = selectPart.ImagePath;
            }
            txtNumberPart.ReadOnly = true;
            treeView1.Select();


        }

        private void editSourcingToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
        void fieldFilterTxtBx_TextChanged(object sender, EventArgs e)
        {

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
            //not found
            return returnNode;
        }

        private void FrmSourcingMain2_Load(object sender, EventArgs e)
        {
            LoadTreeview();

        }




        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtNamePart.ReadOnly)
                return;
            FrmSupplier frmSupplier = new FrmSupplier();
            AddTab(frmSupplier);
            isLoad = true;



        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtNamePart.ReadOnly)
                return;
            PictureUtility.OpenImage(PictureImage);
        }

        void LoadTreeview()
        {

            ProductUtility obj = new ProductUtility(treeView1);
            obj.BuildRootPart();
            ComboboxUtility.BindSupplier(cboSupplier);
            FormUtility.ResetForm(this);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        void SaveSourcing(Part partInsert)
        {
            try
            {
                Model.Sourcing sourcing = new Model.Sourcing();
                sourcing.SupplierID = (cboSupplier.SelectedItem as TmTech_v1.Model.Supplier).SupplierId;
                sourcing.Note = txtDescription.Text;
                sourcing.CreateDate = DateTime.Now;
                sourcing.CreateBy = UserManagement.UserSession.FullName;
                partInsert.CreateBy = UserManagement.UserSession.FullName;
                partInsert.CreateDate = DateTime.Now;
                partInsert.PartName = txtNamePart.Text;
                partInsert.Pricespart = decimal.Parse(txtPricePart.Text);
                partInsert.PartNumber = txtNumberPart.Text;
                partInsert.Description = txtDescription.Text;
                using (UnitOfWork uow = new UnitOfWork())
                {

                    int idPart = uow.PartBaseRepository.AddandGetRequestPaymentId(partInsert);

                    sourcing.PartID = idPart;
                    int idSouriing = uow.SourcingBaseRepository.AddandGetRequestPaymentId(sourcing);
                    uow.Commit();

                    TreeTagPart treeTag = new TreeTagPart();
                    treeTag.NodeTye = TreeTagPart.Types.Part;

                    treeTag.SeriesPartIDTag = isCreateNew.SeriesPartID;
                    treeTag.PartIDTag = idPart;
                    treeTag.PartNumber = txtNumberPart.Text;
                    treeTag.GroupPartIDTag = mainCreate.GroupPartIDTag;
                    treeTag.TypePartIDTag = mainCreate.TypePartIDTag;

                    TreeNode node = new TreeNode(txtNamePart.Text);

                    node.Tag = treeTag;
                    AddNodeToTree(node);
                    txtNumberPart.ReadOnly = true;
                }

                lblNotify1.SetText(UI.createsuccess, LabelNotify.EnumStatus.Success);
                DisplayInformation(treeView1.SelectedNode);
                isInsert = false;
                txtDescription.ReadOnly = true;

                FormUtility.ReadOnlySpecial(pnlContent);
                cboSupplier.Enabled = false;
            }
            catch (Exception )
            {
                lblNotify1.SetText(UI.createfailed, LabelNotify.EnumStatus.Failed);
            }

        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TreeTagPart treetag = treeView1.SelectedNode.Tag as TreeTagPart;
            Part selectPart;
            Model.Sourcing selectSouring;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                selectPart = uow.PartBaseRepository.Find(treetag.PartIDTag);
                selectSouring = uow.SourcingBaseRepository.FindPartByIDPart(treetag.PartIDTag);
                uow.Commit();
            }
            if (selectPart == null) return;
            if (selectSouring == null) return;

            txtNumberPart.Text = selectPart.PartNumber;
            txtNamePart.Text = selectPart.PartName;
            txtPricePart.Text = (selectPart.Pricespart) > 0 ? selectPart.Pricespart.ToString() : "0";
            txtDescription.Text = selectPart.Description;
            cboSupplier.SelectedItem = selectPart.SeriesPartID;
            lbTitle.Text = "update sourcing";
            isUpdatePart = selectPart;
            isSourcing = selectSouring;
            isInsert = false;
            isUpdate = true;

            objBackUp = new PartBackUp();

            objBackUp.PartName = txtNamePart.Text;
            objBackUp.Description = txtDescription.Text;
            objBackUp.PartName = txtNumberPart.Text;
            objBackUp.Pricespart = txtPricePart.Text != string.Empty ? decimal.Parse(txtPricePart.Text) : 0;
            objBackUp.ImagePath = currentImagePath;
            PictureUtility.BindImage(PictureImage, selectPart.ImagePath);
            txtNumberPart.ReadOnly = true;
            txtPricePart.ReadOnly = false;
            txtNamePart.ReadOnly = false;
            txtDescription.ReadOnly = false;
            cboSupplier.Enabled = true;
            mainUpdate = treetag;
            txtDescription.ReadOnly = false;
        }


        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.Yes)
            {
                TreeTagPart treeTag = treeView1.SelectedNode.Tag as TreeTagPart;
                if (treeTag != null)
                {
                    try
                    {
                        using (IUnitOfWork uow = new UnitOfWork())
                        {
                            uow.PartBaseRepository.Remove(treeTag.PartIDTag);
                            uow.Commit();
                        }
                        treeView1.Nodes.Remove(treeView1.SelectedNode);
                        lblNotify1.SetText(UI.removesuccess, LabelNotify.EnumStatus.Failed);
                    }
                    catch
                    {
                        lblNotify1.SetText(UI.removefailed, LabelNotify.EnumStatus.Failed);
                    }
                }
            }

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            TreeTagPart treetag = treeView1.SelectedNode.Tag as TreeTagPart;
            if (treetag != null)
                isCreateNew.SeriesPartID = treetag.SeriesPartIDTag;
            txtNamePart.Text = string.Empty;
            txtDescription.Text = string.Empty;

            txtPricePart.Text = string.Empty;
            PictureImage.InitialImage = null;
            FormUtility.ResetForm(pnlContent);
            ComboboxUtility.BindSupplier(cboSupplier);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            TreeNode nodeSelect = treeView1.SelectedNode;

            DisplayInformation(nodeSelect);
        }
        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            TreeViewHitTestInfo info = treeView1.HitTest(treeView1.PointToClient(Cursor.Position));
            TreeNode node = info.Node;
            TreeTagPart treeTag = node.Tag as TreeTagPart;
            treeView1.SelectedNode = node;
            if (node != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (treeTag == null) return;

                }
                if (e.Button == MouseButtons.Right)
                {
                    if (treeTag.GroupPartIDTag > 0 && treeTag.TypePartIDTag == 0 && treeTag.SeriesPartIDTag == 0)
                        ctxGroupPart.Show(Cursor.Position);
                    if (treeTag.GroupPartIDTag > 0 && treeTag.TypePartIDTag > 0 && treeTag.SeriesPartIDTag == 0)
                        ctxTypePart.Show(Cursor.Position);
                    if (treeTag.GroupPartIDTag > 0 && treeTag.TypePartIDTag > 0 && treeTag.SeriesPartIDTag > 0)
                        ctxSeriePart.Show(Cursor.Position);
                    if (treeTag.GroupPartIDTag > 0 && treeTag.TypePartIDTag > 0 && treeTag.SeriesPartIDTag > 0
                        && treeTag.PartIDTag > 0)
                    {
                        ctxPart.Show(Cursor.Position);
                    }
                }
            }
        }

        private void tsCreateCategory_Click(object sender, EventArgs e)
        {
            frmCreateGroupPart frmCreate = new frmCreateGroupPart();
            frmCreate.AddNode = AddNodeToTree;
            frmCreate.Show();
        }
        private void tsCreateProduct_Click(object sender, EventArgs e)
        {




        }

        private void tsCreateSerie1_Click(object sender, EventArgs e)
        {
            TreeTagPart treetag = treeView1.SelectedNode.Tag as TreeTagPart;
            frmCreateSeriesPart frmCreate = new frmCreateSeriesPart(treetag.GroupPartIDTag, treetag.TypePartIDTag, treeView1.SelectedNode.Text);
            Enabled = false;
            frmCreate.AddNode = AddNodeToTree;
            frmCreate.ShowDialog();
            Enabled = true;
        }

        private void tsCreateSerie2_Click(object sender, EventArgs e)
        {
            TreeTagPart treetag = treeView1.SelectedNode.Tag as TreeTagPart;
            frmCreateSeriesPart frmCreate = new frmCreateSeriesPart(treetag.GroupPartIDTag, treetag.TypePartIDTag, treeView1.SelectedNode.Parent.Text);
            Enabled = false;
            frmCreate.AddNode = AddNodeToTree;
            frmCreate.ShowDialog();
            Enabled = true;
        }


        private void tsCreateSubCate1_Click(object sender, EventArgs e)
        {
            TreeTagPart treetag = treeView1.SelectedNode.Tag as TreeTagPart;
            frmcreateTypePart frmCreate = new frmcreateTypePart(treetag.GroupPartIDTag, treeView1.SelectedNode.Text);
            Enabled = false;
            frmCreate.AddNode = AddNodeToTree;
            frmCreate.Show();
            Enabled = true;
        }

        private void tsCreateSubCate2_Click(object sender, EventArgs e)
        {
            TreeTagPart treetag = treeView1.SelectedNode.Tag as TreeTagPart;
            frmcreateTypePart frmCreate = new frmcreateTypePart(treetag.GroupPartIDTag, treeView1.SelectedNode.Parent.Text);
            frmCreate.AddNode = AddNodeToTree;
            frmCreate.Show();

        }

        private void tsDeleteCategory_Click_1(object sender, EventArgs e)
        {

            DialogResult result = FormUtility.MsgDelete();

            if (result == DialogResult.Yes)
            {
                TreeTagPart treeTag = treeView1.SelectedNode.Tag as TreeTagPart;
                if (treeTag != null)
                {
                    try
                    {
                        using (IUnitOfWork uow = new UnitOfWork())
                        {
                            uow.GroupPartBaseRepository.Remove(treeTag.GroupPartIDTag);
                            uow.Commit();
                        }
                        treeView1.Nodes.Remove(treeView1.SelectedNode);
                        lblNotify1.SetText(UI.success, LabelNotify.EnumStatus.Success);
                    }
                    catch
                    {
                        lblNotify1.SetText(UI.removefailed, LabelNotify.EnumStatus.Failed);
                    }
                }
            }
        }

        private void tsDeleteSerie_Click(object sender, EventArgs e)
        {
            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.Yes)
            {
                TreeTagPart treeTag = treeView1.SelectedNode.Tag as TreeTagPart;
                if (treeTag != null)
                {
                    try
                    {
                        using (IUnitOfWork uow = new UnitOfWork())
                        {
                            uow.SeriesPartBaseRepository.Remove(treeTag.SeriesPartIDTag);
                            uow.Commit();
                        }
                        treeView1.Nodes.Remove(treeView1.SelectedNode);
                    }
                    catch
                    {
                        lblNotify1.SetText(UI.removefailed, LabelNotify.EnumStatus.Failed);
                    }
                }
            }
        }

        private void tsDeleteSubCate_Click(object sender, EventArgs e)
        {
            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.Yes)
            {
                TreeTagPart treeTag = treeView1.SelectedNode.Tag as TreeTagPart;
                if (treeTag != null)
                {
                    try
                    {
                        using (IUnitOfWork uow = new UnitOfWork())
                        {
                            uow.TypePartBaseRepository.Remove(treeTag.TypePartIDTag);
                            uow.Commit();
                        }
                        treeView1.Nodes.Remove(treeView1.SelectedNode);
                    }
                    catch
                    {
                        lblNotify1.SetText(UI.removefailed, LabelNotify.EnumStatus.Failed);
                    }
                }
            }
        }

        private void tsEditCate_Click(object sender, EventArgs e)
        {
            TreeTagPart treetag = treeView1.SelectedNode.Tag as TreeTagPart;
            GroupPart cate;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                cate = uow.GroupPartBaseRepository.Find(treetag.GroupPartIDTag);
                uow.Commit();
            }
            if (cate == null) return;
            frmEditGroupPart frmEdit = new frmEditGroupPart(cate);
            Enabled = false;
            frmEdit.UpdateNode = updateNode;
            frmEdit.Show();
            Enabled = true;
        }

        private void tsEditSerie_Click(object sender, EventArgs e)
        {
            TreeTagPart treetag = treeView1.SelectedNode.Tag as TreeTagPart;
            SeriesPart serie;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                serie = uow.SeriesPartBaseRepository.Find(treetag.SeriesPartIDTag);
                uow.Commit();
            }
            if (serie == null) return;

            frmEditSeriesPart frmEdit = new frmEditSeriesPart(serie, treetag.GroupPartIDTag, treeView1.SelectedNode.Parent.Text);
            Enabled = false;
            frmEdit.UpdateNode = updateNode;
            frmEdit.ShowDialog();
            Enabled = true;
        }

        private void tsEditSub_Click(object sender, EventArgs e)
        {
            TreeTagPart treetag = treeView1.SelectedNode.Tag as TreeTagPart;
            TypePart sub;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                sub = uow.TypePartBaseRepository.Find(treetag.TypePartIDTag);
                uow.Commit();
            }
            if (sub == null) return;
            frmEditTypePart frmEdit = new frmEditTypePart(sub, treeView1.SelectedNode.Parent.Text);
            Enabled = false;
            frmEdit.UpdateNode = updateNode;
            frmEdit.ShowDialog();
            Enabled = true;
        }

        private new void Update()
        {

            if (ValidationUtility.FieldNotAllowNull(this) == false) return;

            if (isUpdatePart.SeriesPartID < 0)
            {
                lblNotify1.SetText("thiếu thông tin về series ID", LabelNotify.EnumStatus.Failed);
                return;
            }


            if (txtPricePart.Text == string.Empty)
            {
                lblNotify1.SetText("Chưa nhập giá", LabelNotify.EnumStatus.Failed);
                txtPricePart.Focus();
                return;
            }

            try
            {
                decimal.Parse(txtPricePart.Text);
            }
            catch (Exception)
            {

                lblNotify1.SetText("Chưa nhập giá hoặc giá không chính x", LabelNotify.EnumStatus.Failed);
                txtPricePart.Focus();
                return;
            }
            if (cboSupplier.SelectedValue == null)
            {
                lblNotify1.SetText("Chưa nhập thông tin nhà cung cấp", LabelNotify.EnumStatus.Failed);

            }

            if (PictureImage.Tag != null)
            {
                isUpdatePart.ImagePath = PictureUtility.SaveImg(PictureImage.Tag.ToString());
            }


            isSourcing.SupplierID = (cboSupplier.SelectedItem as TmTech_v1.Model.Supplier).SupplierId;
            isSourcing.ModifyBy = UserManagement.UserSession.UserName;
            isSourcing.ModifyDate = DateTime.Now;
            isUpdatePart.ModifyBy = UserManagement.UserSession.UserName;
            isUpdatePart.ModifyDate = DateTime.Now;
            isUpdatePart.Pricespart = decimal.Parse(txtPricePart.Text);
            isUpdatePart.PartName = txtNamePart.Text;
            isUpdatePart.Description = txtDescription.Text;
            isSourcing.Note = txtDescription.Text;

            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {

                    uow.PartBaseRepository.Update(isUpdatePart);

                    uow.SourcingBaseRepository.Update(isSourcing);
                    uow.Commit();


                    TreeTagPart treeTag = new TreeTagPart();
                    treeTag.NodeTye = TreeTagPart.Types.Part;
                    treeTag.SeriesPartIDTag = isUpdatePart.SeriesPartID;
                    treeTag.PartIDTag = isUpdatePart.PartID;
                    treeTag.GroupPartIDTag = mainUpdate.GroupPartIDTag;
                    treeTag.TypePartIDTag = mainUpdate.TypePartIDTag;

                    TreeNode node = new TreeNode(txtNamePart.Text);
                    node.Name = txtNamePart.Text;
                    node.Tag = treeTag;
                    updateNode(node);


                }

                lblNotify1.SetText(UI.updatesuccess, LabelNotify.EnumStatus.Success);
                DisplayInformation(treeView1.SelectedNode);
                txtDescription.ReadOnly = true;
                isUpdate = false;
                FormUtility.ReadOnlySpecial(pnlContent);
                cboSupplier.Enabled = false;
            }
            catch (Exception)
            {

                lblNotify1.SetText(UI.updatefailed, LabelNotify.EnumStatus.Failed);
            }


        }
        private void updateNode(TreeNode node)
        {
            treeView1.BeginUpdate();
            treeView1.SelectedNode.Name = node.Name;
            treeView1.SelectedNode.Text = node.Name;
            treeView1.EndUpdate();
            treeView1.Refresh();
        }

        private void viewListSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeTagPart treeTag = treeView1.SelectedNode.Tag as TreeTagPart;
            if (treeTag == null)
                return;

            InformationSearch parameterSerach = new InformationSearch
            {
                GroupPartID = treeTag.GroupPartIDTag,
                TypePartID = treeTag.TypePartIDTag

            };


            FrmViewSupplier frmViewSupplier = FrmViewSupplier.Instance();
            frmViewSupplier.LoadInformationSearch(parameterSerach);
            if (AddTab != null)
                AddTab(frmViewSupplier);
        }

        private void viewListSupplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TreeTagPart treeTag = treeView1.SelectedNode.Tag as TreeTagPart;
            if (treeTag == null)
                return;

            InformationSearch parameterSerach = new InformationSearch
            {
                GroupPartID = treeTag.GroupPartIDTag,
                TypePartID = treeTag.TypePartIDTag,
                SeriesPartID = treeTag.SeriesPartIDTag

            };

            FrmViewSupplier frmViewSupplier = FrmViewSupplier.Instance();
            frmViewSupplier.LoadInformationSearch(parameterSerach);
            if (AddTab != null)
                AddTab(frmViewSupplier);
        }

        private void viewSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeTagPart treeTag = treeView1.SelectedNode.Tag as TreeTagPart;
            if (treeTag == null)
                return;

            InformationSearch parameterSerach = new InformationSearch
            {
                GroupPartID = treeTag.GroupPartIDTag
            };


            FrmViewSupplier frmViewSupplier = FrmViewSupplier.Instance();
            frmViewSupplier.LoadInformationSearch(parameterSerach);
            if (AddTab != null)
                AddTab(frmViewSupplier);


        }

        private void viewSupplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TreeTagPart treeTag = treeView1.SelectedNode.Tag as TreeTagPart;
            if (treeTag == null)
                return;

            InformationSearch parameterSerach = new InformationSearch
            {
                GroupPartID = treeTag.GroupPartIDTag,
                TypePartID = treeTag.TypePartIDTag,
                SeriesPartID = treeTag.SeriesPartIDTag,
                PartID = treeTag.PartIDTag
            };

            FrmViewSupplier frmViewSupplier = FrmViewSupplier.Instance();
            frmViewSupplier.LoadInformationSearch(parameterSerach);
            if (AddTab != null)
                AddTab(frmViewSupplier);
        }



        protected override Point ScrollToControl(Control activeControl)
        {
            return AutoScrollPosition;
        }
    }
}

