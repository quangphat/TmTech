﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ModernUI.Controls;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
using TmTech.Resource;
using TmTech_v1.Model;

namespace TmTech_v1.View
{
    public partial class frmSelectProperty : UserControl
    {
        public Model.Product m_Product;
        Model.QuotationDetail m_QuotationDetail;
        Company m_Company;
        public frmSelectProperty()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            lblNotify1.Text = "";
            m_QuotationDetail = new Model.QuotationDetail();
            FormUtility.FormatForm(this);
        }
        public frmSelectProperty(Model.Product product,Company company)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.m_Product = product;
            this.m_Company = company;
            m_Product.Quantity = 1;
            lblNotify1.Text = "";
            m_QuotationDetail = new Model.QuotationDetail();
            FormUtility.FormatForm(this);
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
            richTextBox1.Text = ProductUtility.ConvertToDescription<Model.QuotationDetail>(m_QuotationDetail, ProductUtility.QuotationDetailToDescription,2);
        }
        private void frmSelectProperty_Load(object sender, EventArgs e)
        {
            InititalizeForm(m_Company);
            InititalizeForm(m_Product);
            //PictureUtility.BindImage(ptPicture, m_Product.PhotoPath);
            using (IUnitOfWork uow = new UnitOfWork())
            {
                List<ProductPicture> lstPicture = uow.ProductPictureRepository.FindByProduct(m_Product);
                displayMultiplePicture1.ImgList = new string[5];
                displayMultiplePicture1.Show(lstPicture);
                foreach (Control c in Controls)
                {
                    if (c is MetroSearchComboBox)
                    {
                        MetroSearchComboBox cbb = c as MetroSearchComboBox;
                        if (cbb.Tag != null)
                        {
                            IList<CustomModel.ProductProperty> lstProperty = uow.ProductRepository.getProperty(cbb.Tag.ToString(),m_Product);
                            ComboboxUtility.BindData<CustomModel.ProductProperty>(cbb, lstProperty, "Value", "Id");
                            cbb.SelectedValue = 0;
                        }
                        
                    }
                }
                //if (m_Product != null && m_Quotation != null)
                //{
                //    m_Product = uow.ProductRepository.Find(m_Product.ProductId);
                //    m_QuotationDetail = uow.QuotationDetailRepository.Find(m_Quotation, m_Product);
                //    IList<Model.QuotationDetail> lstQuotationDetail = new List<Model.QuotationDetail>();
                //    if (m_QuotationDetail == null)
                //    {
                //        m_QuotationDetail = new Model.QuotationDetail();
                //    }
                //    m_QuotationDetail.Product = m_Product;
                //    InitializeForm(m_QuotationDetail);
                //    lstQuotationDetail.Add(m_QuotationDetail);
                //    richTextBox1.Text = ProductUtility.ConvertToDescription<Model.QuotationDetail>(m_QuotationDetail,UtilityFunction.objectToDescriptionIgnore);
                //    //GridUtility.BindingData<Model.QuotationDetail>( lstQuotationDetail);
                //    if (m_Quotation.Company.Class == null) m_Quotation.Company.Class = new Model.CustomerClass();
                //    txtPrice.Text = CurrencyUtility.DecimalToString(m_Product.Price);
                //    txtRate.Text = m_Quotation.Company.Class!=null?m_Quotation.Company.Class.ClassRate.ToString():"0";
                //    txtQuotationPrice.Text = CurrencyUtility.DecimalToString(m_Product.Price * (decimal)m_Quotation.Company.Class.ClassRate);
                //    txtThanhtien.Text = CurrencyUtility.DecimalToString(Convert.ToInt32(txtQuantity.Text) * CurrencyUtility.ToDecimal(txtQuotationPrice.Text));
                //}
            }
        }
        
        public delegate void delgHideThis();
        public delgHideThis HideThis;

        private void bootstrapButton1_Click(object sender, EventArgs e)
        {
            if(HideThis!=null)
                HideThis();
        }
        public delegate void delgSaveSelectedProperty(Model.QuotationDetail quotationDetail);
        public delgSaveSelectedProperty SaveSelectedProperty;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (m_Product == null)
                return;
            m_QuotationDetail = new QuotationDetail();
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
            m_QuotationDetail.Quantity = string.IsNullOrWhiteSpace(txtQuantity.Text)==true?0:Convert.ToInt32(txtQuantity.Text);
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
            
            if (SaveSelectedProperty != null)
                SaveSelectedProperty(m_QuotationDetail);
            ((Form)this.TopLevelControl).Close();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //GridUtility.SetRowColor();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            int soluong = string.IsNullOrWhiteSpace(txtQuantity.Text) == true ? 0 : Convert.ToInt32(txtQuantity.Text);
            decimal thanhtien = soluong* CurrencyUtility.ToDecimal(txtQuotationPrice.Text);
            txtThanhtien.Text = CurrencyUtility.DecimalToString(thanhtien);
        }

        private void txtQuotationPrice_TextChanged(object sender, EventArgs e)
        {
            decimal dongia = CurrencyUtility.ToDecimal(txtPrice.Text);
            txtPrice.Text = CurrencyUtility.DecimalToString(dongia);
            txtPrice.SelectionStart = txtPrice.Text.Length;
            int soluong = string.IsNullOrWhiteSpace(txtQuantity.Text) == true ? 0 : Convert.ToInt32(txtQuantity.Text);
            decimal thanhtien = soluong * CurrencyUtility.ToDecimal(txtPrice.Text);
            txtThanhtien.Text = CurrencyUtility.DecimalToString(thanhtien);
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

        private void metroSearchComboBox8_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox8, m_QuotationDetail);
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

        private void metroSearchComboBox15_SelectedValueChanged(object sender, EventArgs e)
        {
            CoverObjectUtility.GetSingleCtrlAutoBindingData(metroSearchComboBox15, m_QuotationDetail);
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
    }
}
