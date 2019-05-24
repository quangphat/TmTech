using System;
using System.Collections.Generic;
using TmTech_v1.Interface;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmChooseMaterial : ModernUI.Forms.MetroForm
    {
        public delegate void delgAdd(List<Model.Material> mat);
        public delgAdd add;
        private GridUtility gridutility;
        public frmChooseMaterial()
        {
            InitializeComponent();
            gridutility = new GridUtility(gridControl1);
        }

        private void frmChooseMaterial_Load(object sender, EventArgs e)
        {
            IList<Model.Material> lstMaterial = new List<Model.Material>();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    lstMaterial = uow.MaterialRepository.All();
                    uow.Commit();
                }
            }
            catch {
            }
            gridutility.BindingData(lstMaterial);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
            int[] indexes = gridView1.GetSelectedRows();
            if (indexes.Length < 1)
                return;
            List<Model.Material> lst = new List<Model.Material>();
            foreach (int i in indexes)
            {
                lst.Add(gridView1.GetRow(i) as Model.Material);
            }
            if (add != null)
                add(lst);
            Close();

        }
    }
}
