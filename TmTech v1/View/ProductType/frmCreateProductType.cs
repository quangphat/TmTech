
using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmCreateProductType : ModernUI.Forms.MetroForm
    {
        public frmCreateProductType()
        {
            InitializeComponent();
        }

        private void frmCreateUnit_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnSave;
            labelNotify1.Text = "";
        }

        public delegate void delgAddNewUnit(ProductType ProductType, CRUD crud);
        public delgAddNewUnit addNewProductType;

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Create new Unit
            ProductType ProductType = new ProductType();
            CoverObjectUtility.GetAutoBindingData(this, ProductType);
            ProductType.SetCreate();
            
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.ProductTypeRepository.Insert(ProductType);
                    uow.Commit();
                }
            } catch ( Exception ex)
            {
                labelNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }

            if (addNewProductType != null)
                addNewProductType(ProductType, CRUD.Insert);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
