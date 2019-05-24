using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmEditProductType : ModernUI.Forms.MetroForm
    {
        ProductType m_ProductType;

        public frmEditProductType(ProductType ProductType)
        {
            InitializeComponent();
            m_ProductType = ProductType;
            AcceptButton = btnSave;
        }

        private void frmEditProductType_Load(object sender, EventArgs e)
        {
            if (m_ProductType != null)
            {
                CoverObjectUtility.SetAutoBindingData(this, m_ProductType);
                labelNotify1.Text = "";
            }
        }

        public delegate void delgUpdateNewProductType(ProductType ProductType, CRUD crud);
        public delgUpdateNewProductType UpdateNewProductType;

        private void btnSave_Click(object sender, EventArgs e)
        {
            CoverObjectUtility.GetAutoBindingData(this, m_ProductType);
            m_ProductType.SetModify();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.ProductTypeRepository.Edit(m_ProductType);
                    uow.Commit();
                }
            }
            catch
            {
                labelNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
            if (UpdateNewProductType != null)
                UpdateNewProductType(m_ProductType, CRUD.Update);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
