using ModernUI.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.ToolBoxCS;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmCreateProduct : MetroForm
    {
        TreeTag m_treeTag;
        public frmCreateProduct()
        {
            InitializeComponent();
            lblNotify1.Text = string.Empty;
            m_treeTag = new TreeTag();
        }
        public frmCreateProduct(TreeTag treeTag)
        {
            InitializeComponent();
            lblNotify1.Text = string.Empty;
            m_treeTag = treeTag;
        }
        private void frmCreateProd_Load(object sender, EventArgs e)
        {
            ComboboxUtility.BindCategory(cbbCategory);
            ComboboxUtility.BindSerie(cbbSerie, 0);
            //ComboboxUtility.BindClassProduct(cbbClassProduct);
            //ComboboxUtility.BindStandard(cbbStandard);
            //ComboboxUtility.BindSafety(cbbClassSafety);
            //ComboboxUtility.BindLampType(cbbLamptype);
            cbbCategory.SelectedValue = m_treeTag.CateId;
            cbbSubCate.SelectedValue = m_treeTag.LineId;
            cbbSerie.SelectedValue = m_treeTag.SerieId;
            cbbClassProduct.SelectedValue = -1;
            cbbClassSafety.SelectedValue = -1;
            cbbStandard.SelectedValue = -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidationUtility.FieldNotAllowNull(this)==false) return;
            if (cbbCategory.SelectedValue == null || cbbSubCate.SelectedValue == null || cbbSerie.SelectedValue == null)
            {
                lblNotify1.SetText(UI.hasnoinfomation, LabelNotify.EnumStatus.Failed);
                return;
            }
            Product product = new Product();
            FormUtility.BindTextBoxToObj<Product>(this, product);
            product.SeriesId = int.Parse(cbbSerie.SelectedValue.ToString());
            product.ProductCode = txtCode.Text;
            product.ProductName = txtName.Text;
            //product.BranchOfLed = txtLed.Text;
            //product.IPRate = txtIPRate.Text;
            product.DataSheet = ValidationUtility.StringIsNull(txtDatasheet.Text) == false ? txtDatasheet.Text : "";
            product.Note = txtNote.Text;
            product.CreateBy = UserManagement.UserSession.UserName;
            product.CreateDate = DateTime.Now;
            ProductPrice productPrice = new ProductPrice();
            productPrice.Price = CurrencyUtility.ToDecimal(txtPrice.Text);
            productPrice.ActiveDate = DateTime.Today;
            productPrice.CreateBy = UserManagement.UserSession.UserName;
            productPrice.CreateDate = DateTime.Now;
            if (ptPicture.Tag != null)
            {
                product.PhotoPath = PictureUtility.SaveImg(ptPicture.Tag.ToString());
            }
            if (ptPhotometer.Tag != null)
            {
                product.PhotoMeter = PictureUtility.SaveImg(ptPhotometer.Tag.ToString());
            }
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    Product exists = uow.ProductRepository.FindByCode(product.ProductCode);
                    if(exists!=null)
                    {
                        lblNotify1.SetText(UI.codehasexist, LabelNotify.EnumStatus.Failed);
                        uow.Commit();
                        return;
                    }
                    if(product.Barcode!=null)
                    {
                        exists = uow.ProductRepository.FindByBarcode(product.Barcode);
                        if (exists != null)
                        {
                            lblNotify1.SetText(UI.barcodehasexists, LabelNotify.EnumStatus.Failed);
                            uow.Commit();
                            return;
                        }
                    }
                    
                    //Guid id = uow.ProductRepository.Add(product);
                    //product.ProductId = id;
                    ////product.Barcode = BarcodeUtility.generateBarcode(id);
                    //productPrice.ProductId = id;
                    //uow.ProductPriceRepository.Update(productPrice);
                    //uow.ProductRepository.Update(product);
                    //uow.Commit();
                }
                lblNotify1.SetText(UI.createsuccess, LabelNotify.EnumStatus.Success);
            }
            catch
            {
                lblNotify1.SetText(UI.createfailed, LabelNotify.EnumStatus.Failed);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            FormUtility.ResetForm(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnkChangeHinhanh_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUtility.OpenImage(ptPicture);

        }

        private void lnkDiagram_Click(object sender, EventArgs e)
        {
            PictureUtility.OpenImage(ptPhotometer);

        }

        

        private void frmCreateProd_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUtility.ShowParentForm();
        }

        private void cbbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedValue != null)
            {
                int cateId = int.Parse(cbbCategory.SelectedValue.ToString());
            }
        }

        private void cbbSubCate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbSubCate.SelectedValue != null)
            {
                int subId = int.Parse(cbbSubCate.SelectedValue.ToString());
                List<Series> lstSerie = cbbSerie.DataSource as List<Series>;
                if (lstSerie != null)
                {
                    ComboboxUtility.BindSerie(cbbSerie, subId);
                    cbbSerie.SelectedValue = -1;
                }
            }
        }
    }
}
