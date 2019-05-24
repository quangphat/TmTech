using ModernUI.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmProductProperty : MetroForm
    {
        GridUtility gridUtility;
        Model.Product m_Product;
        public frmProductProperty(Model.Product product)
        {
            InitializeComponent();
            gridUtility = new GridUtility(gridControl1);
            lblNotify1.Text = "";
            this.m_Product = product;
            txtProductId.Text = product.ProductId.ToString();
        }

        private void frmProductProperty_Load(object sender, EventArgs e)
        {
        }
        private void LoadGrid(string propertyName)
        {
            IList<CustomModel.ProductProperty> lstProperty;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstProperty = uow.ProductRepository.getProperty(propertyName,m_Product);
                uow.Commit();
            }
            gridUtility.BindingData<CustomModel.ProductProperty>( lstProperty);
        }
        private void txtControl_Enter(object sender, EventArgs e)
        {
            if (txtControl.Tag == null) return;
            LoadGrid(txtControl.Tag.ToString());
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }

        private void txtClassSafety_Enter(object sender, EventArgs e)
        {
            if(txtClassSafety.Tag!=null)
            LoadGrid(txtClassSafety.Tag.ToString());
        }

        private void txtAngle_Enter(object sender, EventArgs e)
        {
            if(txtAngle.Tag!=null)
            LoadGrid(txtAngle.Tag.ToString());
        }

        private void txtClassProduct_Enter(object sender, EventArgs e)
        {
            if (txtClassProduct.Tag != null)
            LoadGrid(txtClassProduct.Tag.ToString());
        }

        private void txtStandard_Enter(object sender, EventArgs e)
        {
            if (txtStandard.Tag != null)
            LoadGrid(txtStandard.Tag.ToString());
        }

        private void txtTemperature_Enter(object sender, EventArgs e)
        {
            if (txtTemperature.Tag != null)
            LoadGrid(txtTemperature.Tag.ToString());
        }

        private void txtIPRate_Enter(object sender, EventArgs e)
        {
            if (txtIPRate.Tag != null)
            LoadGrid(txtIPRate.Tag.ToString());
        }

        private void txtProfileHousing_Enter(object sender, EventArgs e)
        {
            if (txtProfileHousing.Tag != null)
            LoadGrid(txtProfileHousing.Tag.ToString());
        }

        private void txtHousing_Enter(object sender, EventArgs e)
        {
            if (txtHousing.Tag != null)
            LoadGrid(txtHousing.Tag.ToString());
        }

        private void txtHead_Enter(object sender, EventArgs e)
        {
            if (txtHead.Tag != null)
            LoadGrid(txtHead.Tag.ToString());
        }

        private void txtWatt_Enter(object sender, EventArgs e)
        {
            if (txtWatt.Tag != null)
            LoadGrid(txtWatt.Tag.ToString());
        }

        private void txtCri_Enter(object sender, EventArgs e)
        {
            if (txtCri.Tag != null)
            LoadGrid(txtCri.Tag.ToString());
        }

        private void txtIKRate_Enter(object sender, EventArgs e)
        {
            if (txtIKRate.Tag != null)
            LoadGrid(txtIKRate.Tag.ToString());
        }

        private void txtInputVol_Enter(object sender, EventArgs e)
        {
            if (txtInputVol.Tag != null)
            LoadGrid(txtInputVol.Tag.ToString());
        }



        private void txtBranchLed_Enter(object sender, EventArgs e)
        {
            if (txtBranchLed.Tag != null)
            LoadGrid(txtBranchLed.Tag.ToString());
        }

        private void txtColorHousing_Enter(object sender, EventArgs e)
        {
            if (txtColorHousing.Tag != null)
            LoadGrid(txtColorHousing.Tag.ToString());
        }


        private void txtEnec_Enter(object sender, EventArgs e)
        {
            if (txtEnec.Tag != null)
            LoadGrid(txtEnec.Tag.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Guid productId = Guid.Parse(txtProductId.Text);
            if (productId == Guid.Empty) return;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox textbox = c as TextBox;
                        if (textbox.Tag != null && !string.IsNullOrWhiteSpace(textbox.Text))
                        {
                            string[] strValue = textbox.Text.Split(';');
                            try
                            {
                                foreach (string val in strValue)
                                {
                                    if (!string.IsNullOrWhiteSpace(val))
                                    {
                                        CustomModel.ProductProperty prop = new CustomModel.ProductProperty();
                                        prop.TableName = textbox.Tag.ToString();
                                        prop.Value = val;
                                        prop.ProductId = productId;
                                        uow.ProductRepository.InsertProductProperty(prop);
                                    }
                                }
                            }
                            catch
                            {
                                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                            }
                        }
                    }
                }
                uow.Commit();
                lblNotify1.SetText(UI.success, ToolBoxCS.LabelNotify.EnumStatus.Success);
                //FormUtility.ResetForm(this);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormUtility.ResetForm(this);
            txtProductId.Text = m_Product.ProductId.ToString();
        }

        private void txtPixel_Enter(object sender, EventArgs e)
        {
            if (txtPixel.Tag != null)
                LoadGrid(txtPixel.Tag.ToString());
        }
    }
}
