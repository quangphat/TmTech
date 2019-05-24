using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TmTech_v1.Utility;
using TmTech_v1.Model;
using TmTech_v1.Interface;
using TmTech_v1.Repository;

namespace TmTech_v1.View
{
    public partial class frmProductDemo : UserControl
    {
        public frmProductDemo()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            lblNotify1.Text = string.Empty;
        }

        private void frmProductDemo_Load(object sender, EventArgs e)
        {         
            IList<Category> lstCate;
            IList<Series> lstSerie;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstCate = uow.CategoryRepository.All();
                lstSerie = uow.SeriesRepository.All();
                uow.Commit();
            }
            ComboboxUtility.BindCategory(cbbCategory);
            ComboboxUtility.BindSerie(cbbSerie, 0);
            cbbCategory.SelectedValue = -1;
        }

        private void cbbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedValue != null)
            {
                int cateId = int.Parse(cbbCategory.SelectedValue.ToString());
            }
        }

        private void cbbCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cbbCategory_SelectionChangeCommitted(cbbCategory, new EventArgs());
            }
        }
    }
}
