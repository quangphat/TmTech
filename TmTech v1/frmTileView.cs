using System.Windows.Forms;
using TmTech_v1.Utility;
using TmTech_v1.View;
using TmTech_v1.View.Sourcing;

namespace TmTech_v1
{
    public partial class frmTileView : UserControl
    {
        frmPrimary m_frmPrimary;
        public frmTileView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            m_frmPrimary = Application.OpenForms["frmPrimary"] as frmPrimary;
        }
        public delegate void delgAddTab(UserControl uCtrl);
        public delgAddTab AddTab;
        private void frmTileView_Load(object sender, System.EventArgs e)
        {
            foreach (DevExpress.XtraEditors.TileGroup tileGroup in tileControl1.Groups)
            {
                foreach (DevExpress.XtraEditors.TileItem tilel in tileGroup.Items)
                {
                    if (tilel.Tag == null)
                        tilel.Visible = false;
                    else
                        if (UserManagement.AllowViewAll(tilel.Tag.ToString()) == false)
                        tilel.Visible = false;
                    else
                        tilel.Visible = true;
                }
            }

        }

        private void tileIProduct_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            //TmTech_v1.View.frmProductLeftView frmLeft = new View.frmProductLeftView();
            //frmProduct frmProduct = new View.frmProduct();
            frmProductTest frmProduct = new frmProductTest();
            frmProduct.LoadTree();
            AddTab(frmProduct);
        }

        private void tileIUser_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmDepartmentMain frmView = new frmDepartmentMain();
            AddTab(frmView);
        }


        private void tilelCompany_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (UserManagement.UserSession.GroupId == Model.UserConstant.CUSTOMER_Group)
            {
                InformationCustomer frmView = new InformationCustomer(UserManagement.UserSession.UserName);
                AddTab(frmView);

            }
            else
            {
                FrmCompany frmView = new View.FrmCompany();
                AddTab(frmView);

            }

        }

        private void titelPO_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            View.frmPO frmView = new View.frmPO();
            AddTab(frmView);
        }

        private void tileItem1_ItemPress(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            //FrmQuotationNew frmView = new FrmQuotationNew();
            //AddTab(frmView);
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmPlanning frmView = new frmPlanning();
            AddTab(frmView);
        }



        private void tileMaterial_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmSearchMaterial frmMaterial = new frmSearchMaterial();
            AddTab(frmMaterial);
        }

        private void Supplier_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmSupplier frmSupplier = new FrmSupplier();
            AddTab(frmSupplier);
            //FrmDemo objDemo =new FrmDemo();
            //AddTab(objDemo);
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            //TmTech_v1.View.Test.frmQuotationList frmList = new View.Test.frmQuotationList();
            frmQuotationList frmList = new frmQuotationList();
            AddTab(frmList);
        }
        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmSourcing obj = new FrmSourcing();
            obj.AddTab = m_frmPrimary.AddTab;
            AddTab(obj);

        }

        private void tileControl1_Click(object sender, System.EventArgs e)
        {
            //FrmDemo frm = new FrmDemo();
            //AddTab(frm);
        }

        private void tileIDepartmentStaff_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmDepartmentMain obj = new frmDepartmentMain();
            AddTab(obj);
        }

        private void tileIUnit_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmUnitMain obj = new frmUnitMain();
            AddTab(obj);
        }

        private void tileIBank_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmTreeBankUpdate obj = new frmTreeBankUpdate();
            AddTab(obj);
        }

        private void tileICurrencyUnit_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmCurrencyUnit obj = new frmCurrencyUnit();
            AddTab(obj);
        }

        private void tileIPaymentMethod_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmPaymentMethodMain obj = new frmPaymentMethodMain();
            AddTab(obj);
        }

        private void tileIDebt_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmDebtMain obj = new frmDebtMain();
            AddTab(obj);
        }

        private void tileIPayment_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmPaymentMain obj = new frmPaymentMain();
            AddTab(obj);
        }

        private void tileINoteProjectDetail_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmNoteMain obj = new frmNoteMain();
            AddTab(obj);
        }

        private void tileIIncomeExpense_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

            frmIncomeExpenseMain obj = new frmIncomeExpenseMain();
            AddTab(obj);
        }

        private void tileIProject_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmProjectMain obj = new frmProjectMain();
            AddTab(obj);
        }

        private void tileItem4_ItemClick_1(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmRequestPayment obj = new frmRequestPayment();
            AddTab(obj);
        }

        private void tileIStafffPosition_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmStaffPositionMain obj = new frmStaffPositionMain();
            AddTab(obj);
        }

        private void tileIImportMaterial_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmImportMaterial obj = new frmImportMaterial();
            obj.AddTab = m_frmPrimary.AddTab;
            AddTab(obj);
        }


        private void frmstockmain(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            //frmStockMain frmStockMain = new frmStockMain();
            //AddTab(frmStockMain);
            //frmImportMaterialDetail obj = new frmImportMaterialDetail();
            //AddTab(obj);
        }
    }
}
