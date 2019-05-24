using ModernUI.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmEditProductProperties : Form
    {
        private Model.QuotationDetail m_QuotationDetail;
        private Model.Product m_Product;
        private Model.Company m_Company;
        public frmEditProductProperties(Model.QuotationDetail quotationDetail, Model.Product product, Model.Company company)
        {
            InitializeComponent();
            m_QuotationDetail = quotationDetail;
            m_Product = product;
            m_Company = company;
            FormUtility.FormatForm(this);
            lblNotify1.Text = "";
            
        }
        private void RegistCbbEvent()
        {
            //IList<CustomModel.ProductProperty> lstProperty = uow.ProductRepository.getProperty(cbb.Tag.ToString(), m_Product);
            //ComboboxUtility.BindData<CustomModel.ProductProperty>(cbb, lstProperty, "Value", "Id");
            //cbb.SelectedValue = 0;
            metroSearchComboBox2.SelectedValueChanged += metroSearchComboBox2_SelectedValueChanged;
            metroSearchComboBox3.SelectedValueChanged += metroSearchComboBox3_SelectedValueChanged;
            metroSearchComboBox4.SelectedValueChanged += metroSearchComboBox4_SelectedValueChanged;
            metroSearchComboBox5.SelectedValueChanged += metroSearchComboBox5_SelectedValueChanged;
            metroSearchComboBox6.SelectedValueChanged += metroSearchComboBox6_SelectedValueChanged;
            metroSearchComboBox7.SelectedValueChanged += metroSearchComboBox7_SelectedValueChanged;
            metroSearchComboBox8.SelectedValueChanged += metroSearchComboBox8_SelectedValueChanged;
            metroSearchComboBox9.SelectedValueChanged += metroSearchComboBox9_SelectedValueChanged;
            metroSearchComboBox10.SelectedValueChanged += metroSearchComboBox10_SelectedValueChanged;
            metroSearchComboBox11.SelectedValueChanged += metroSearchComboBox11_SelectedValueChanged;
            metroSearchComboBox12.SelectedValueChanged += metroSearchComboBox12_SelectedValueChanged;
            metroSearchComboBox13.SelectedValueChanged += metroSearchComboBox13_SelectedValueChanged;
            metroSearchComboBox14.SelectedValueChanged += metroSearchComboBox14_SelectedValueChanged;
            metroSearchComboBox15.SelectedValueChanged += metroSearchComboBox15_SelectedValueChanged;
            metroSearchComboBox17.SelectedValueChanged += metroSearchComboBox17_SelectedValueChanged;
            metroSearchComboBox18.SelectedValueChanged += metroSearchComboBox18_SelectedValueChanged;
            metroSearchComboBox20.SelectedValueChanged += metroSearchComboBox20_SelectedValueChanged;
            metroSearchComboBox21.SelectedValueChanged += metroSearchComboBox21_SelectedValueChanged;
        }
        private void metroSearchComboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox2, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }

        private void metroSearchComboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox3, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }

        private void metroSearchComboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox4, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }

        private void metroSearchComboBox5_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox5, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }

        private void metroSearchComboBox6_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox6, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }

        private void metroSearchComboBox7_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox7, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }

        private void metroSearchComboBox8_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox8, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }

        private void metroSearchComboBox9_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox9, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }

        private void metroSearchComboBox10_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox10, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }

        private void metroSearchComboBox11_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox11, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }

        private void metroSearchComboBox12_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox12, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }

        private void metroSearchComboBox13_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox13, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }

        private void metroSearchComboBox14_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox14, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }

        private void metroSearchComboBox15_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox15, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }

        private void metroSearchComboBox17_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox17, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }

        private void metroSearchComboBox18_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox18, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }

        private void metroSearchComboBox20_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox20, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }

        private void metroSearchComboBox21_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox21, m_QuotationDetail);
            InititalizeForm(m_QuotationDetail);
        }
        private void InititalizeForm(Company company)
        {
            txtRate.Text = company.Class.CompanyClassRate.ToString();
        }
        private void InititalizeForm(Product product)
        {
            txtPrice.Text = CurrencyUtility.DecimalToString(product.Price);
            txtQuantity.Text = product.Quantity.ToString();
            decimal customerPrice = product.Price * (decimal)m_Company.Class.CompanyClassRate;
            txtQuotationPrice.Text = CurrencyUtility.DecimalToString(customerPrice);
            txtThanhtien.Text = (product.Quantity * customerPrice).ToString();
        }
        private void InititalizeForm(QuotationDetail quotationDetail)
        {
            richTextBox1.Text = ProductUtility.ConvertToDescription<Model.QuotationDetail>(m_QuotationDetail, ProductUtility.QuotationDetailToDescription, 2);
        }
        public delegate void delgUpdateRow(QuotationDetail quotationDetail);
        public delgUpdateRow UpdateRow;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (m_QuotationDetail.Quotation.ApproveStatusId == (int)ApproveStatus.Approved)
            {
                lblNotify1.SetText(UI.itemwasapproved, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            if (m_Product == null)
                return;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                m_Product = uow.ProductRepository.Find(m_Product.ProductId);
                uow.Commit();
            }
            if (m_Product == null)
            {
                lblNotify1.SetText(UI.productnotfound, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            m_QuotationDetail.ProductId = m_Product.ProductId;
            m_QuotationDetail.Product = m_Product;
            m_QuotationDetail.Quantity = string.IsNullOrWhiteSpace(txtQuantity.Text) == true ? 0 : Convert.ToInt32(txtQuantity.Text);
            if (m_QuotationDetail.Quantity == 0)
            {
                lblNotify1.SetText(UI.hasnotquantity, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            m_QuotationDetail.QuotationPrice = CurrencyUtility.ToDecimal(txtQuotationPrice.Text);
            m_QuotationDetail.BasePrice = CurrencyUtility.ToDecimal(txtPrice.Text);
            if (m_QuotationDetail.QuotationPrice == 0)
            {
                lblNotify1.SetText(UI.hasnotprice, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            CoverObjectUtility.GetAutoBindingData(this, m_QuotationDetail);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.QuotationDetailRepository.Update(m_QuotationDetail);
                    uow.Commit();
                }
                if (UpdateRow != null)
                    UpdateRow(m_QuotationDetail);
                this.Close();
            }
            catch
            {
                lblNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void bootstrapButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BindCbbData(IUnitOfWork uow,Control ctrols)
        {
            foreach (Control c in ctrols.Controls)
            {
                if (c is MetroSearchComboBox)
                {
                    MetroSearchComboBox cbb = c as MetroSearchComboBox;
                    if (cbb.Tag != null)
                    {
                        IList<CustomModel.ProductProperty> lstProperty = uow.ProductRepository.getProperty(cbb.Tag.ToString(), m_Product);
                        ComboboxUtility.BindData<CustomModel.ProductProperty>(cbb, lstProperty, "Value", "Id");
                        cbb.SelectedValue = 0;
                    }
                    
                }
                if (c.HasChildren)
                    BindCbbData(uow,c);
            }
        }
        private void frmEditProductProperties_Load(object sender, EventArgs e)
        {
            InititalizeForm(m_QuotationDetail);
            using (IUnitOfWork uow = new UnitOfWork())
            {
                List<ProductPicture> lstPicture = uow.ProductPictureRepository.FindByProduct(m_Product);
                m_Company = uow.CompanyRepository.Find(m_Company.CompanyId);
                InititalizeForm(m_Company);
                InititalizeForm(m_Product);

                displayMultiplePicture1.ImgList = new string[5];
                displayMultiplePicture1.Show(lstPicture);
                BindCbbData(uow, tableLayoutPanel1);
                uow.Commit();
            }
            RegistCbbEvent();
            CoverObjectUtility.SetAutoBindingData(this, m_QuotationDetail);
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            decimal dongia = CurrencyUtility.ToDecimal(txtPrice.Text);
            txtPrice.Text = CurrencyUtility.DecimalToString(dongia);
            txtPrice.SelectionStart = txtPrice.Text.Length;
            int soluong = string.IsNullOrWhiteSpace(txtQuantity.Text) == true ? 0 : Convert.ToInt32(txtQuantity.Text);
            decimal thanhtien = soluong * CurrencyUtility.ToDecimal(txtPrice.Text);
            txtThanhtien.Text = CurrencyUtility.DecimalToString(thanhtien);
        }
    }
}
