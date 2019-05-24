using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TmTech_v1.Model;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
using TmTech_v1.ToolBoxCS;
using TmTech.Resource;
namespace TmTech_v1.View
{
    public partial class frmPO : UserControl
    {
        GridUtility gridUtility;
        
        public frmPO()
        {
            InitializeComponent();
            txtSearch.Select();
            Dock = DockStyle.Fill;
            labelNotify1.Text = "";
            IGridviewContextMenu ctxMenu = new PoContextMenu();
            gridUtility = new GridUtility(gridControl1, ctxMenu);
            FormUtility.FormatForm(this);
            //paginationLine1.PageClick += paginationLine1_PageClick;
        }

        void paginationLine1_PageClick(object sender, EventArgs e)
        {
            
        }

        private void frmPO_Load(object sender, EventArgs e)
        {
            //IEnumerable<Po> lstPo;
            //using (IUnitOfWork uow = new UnitOfWork())
            //{
            //    lstPo = uow.PoRepository.All();
            //    uow.Commit();
            //}
            LoadGrid();
        }
        private void LoadGrid()
        {
            IList<Po> lstPo;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstPo = uow.PoRepository.Search(dtpFromDate.DateTime, dtpTodate.DateTime);
                uow.Commit();
            }
            if (lstPo != null)
            {
                gridUtility.BindingData<Po>( lstPo);
            }
        }
        private void Search()
        {
            IList<Po> lstPo;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstPo = uow.PoRepository.Search(txtSearch.Text);
                uow.Commit();
            }
            if (lstPo != null)
            {
                //paginationLine1.TotalPage = lstPo.Count;
                gridUtility.BindingData<Po>( lstPo);
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreatePo frmCreate = new frmCreatePo();
            frmCreate.AddRow = AddOrUpdate;
            frmCreate.ShowDialog();

        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }

        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) return;
            Search();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Return)
            {
                Search();
            }
        }

        private void AddOrUpdate(Model.Po PO,CRUD flag)
        {
            if(flag == CRUD.Insert)
            {
                gridUtility.AddNewRow<Po>(PO);
            }
            else
            {
                gridUtility.UpdateRow<Po>(PO);
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = FormUtility.MsgDelete();
            if(result == DialogResult.Yes)
            {
                int i = gridView1.GetSelectedRows().FirstOrDefault();
                Po po = gridView1.GetRow(i) as Po;
                if (po != null)
                {
                    if (po.ApproveStatusId == (int)ApproveStatus.Approved)
                    {
                        labelNotify1.SetText(UI.itemwasapproved, LabelNotify.EnumStatus.Failed, 5000);
                        return;
                    }
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        uow.PoRepository.Remove(po);
                        uow.Commit();
                    }
                    gridView1.DeleteRow(i);
                }
            } 
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Po PO = gridUtility.GetSelectedItem<Po>() as Po;
            if (PO == null)
                return;
            frmEditPO frmEdit = new frmEditPO(PO);
            frmEdit.UpdateRow = AddOrUpdate;
            frmEdit.ShowDialog();
        }

        private void dtpFromDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                LoadGrid();
            }
        }

        private void dtpTodate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                LoadGrid();
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            gridUtility.DrawStatusColor(sender, e, colStatus,colPoCode);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
