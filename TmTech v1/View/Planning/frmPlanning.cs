using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
using TmTech_v1.Model;
using System.Linq;
using TmTech.Resource;
using System.Drawing;

namespace TmTech_v1.View
{
    public partial class frmPlanning : UserControl
    {
        GridUtility gridUtility;
        Planning m_Planning;
        int m_Speed = 20;
        
        public frmPlanning()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            FormUtility.FormatForm(this);
            gridUtility = new GridUtility(gridControl1);
            dtpFromdate.DateTime = DateTime.Today.AddDays(-15);
            dtpTodate.DateTime = DateTime.Today.AddDays(15);
            lblNotify1.Text = "";
            panelDetail.Height = 0;
            panelGrid.Height = this.Height;
        }

        private void frmPlanning_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            IList<Planning> lstPlanning;
            using(IUnitOfWork uow = new UnitOfWork())
            {
                lstPlanning = uow.PlanningRepository.All(dtpFromdate.DateTime, dtpTodate.DateTime);
                uow.Commit();
            }
            gridUtility.BindingData<Planning>( lstPlanning);
        }
        private void Search(string searchStr)
        {
            IList<Planning> lstPlanning;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstPlanning = uow.PlanningRepository.Search(searchStr);
                uow.Commit();
            }
            gridUtility.BindingData<Planning>(lstPlanning);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (panelGrid.Height <= 0)
            {
                timer1.Start();
            }
            else
            FormUtility.CloseCurrentTab();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            gridUtility.DrawColorForPlanning(sender, e, colStatus, colDisplayColor,colDayleft);
        }

        private void dtpFromdate_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Return)
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
        frmPlanningDetail frmDetail;
        private void CloseDetail()
        {
            timer1.Start();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int i = gridView1.GetSelectedRows().FirstOrDefault();
            m_Planning = gridView1.GetRow(i) as Planning;
            if (m_Planning == null) return;
            frmDetail = new frmPlanningDetail(m_Planning);
            frmDetail.CloseThisForm = CloseDetail;
            timer1.Start();
        }
        private void UpdateRow(Planning planning)
        {
            IList<Planning> lstPlanning = gridControl1.DataSource as IList<Planning>;
            Planning row = lstPlanning.Where(p => p.PlanningId == planning.PlanningId).FirstOrDefault();
            if (row == null) return;
            row = planning;
            gridControl1.RefreshDataSource();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = FormUtility.MsgDelete();
            if(result== DialogResult.Yes)
            {
                int i = gridView1.GetSelectedRows().FirstOrDefault();
                Planning row = gridView1.GetRow(i) as Planning;
                if (row == null) return;
                try
                {
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        uow.PlanningRepository.Remove(row.PlanningId);
                        uow.PlanningDetailRepository.RemovebyPlanning(row);
                        uow.Commit();
                    }
                    gridView1.DeleteRow(i);
                }
                catch
                {
                    lblNotify1.SetText(UI.removefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelDetail.Height <= 0)
            {
                while (panelGrid.Height > 0)
                {
                    panelGrid.Height -= m_Speed;
                    panelDetail.Height += m_Speed;
                    this.Refresh();

                }
                panelDetail.Width = panelGrid.Width;
                panelDetail.Location = new Point(panelGrid.Location.X, panelGrid.Location.Y);
                panelDetail.Controls.Add(frmDetail);
                frmDetail.Width = panelDetail.Width;
            }
            else
            if (panelGrid.Height <= 0)
            {
                while (panelDetail.Height > 0)
                {
                    panelDetail.Height -= m_Speed;
                    panelGrid.Height += m_Speed;
                    this.Refresh();
                }
                panelDetail.Controls.Clear();
            }
            timer1.Stop();
        }

        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            Search(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                Search(txtSearch.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

    }
}
