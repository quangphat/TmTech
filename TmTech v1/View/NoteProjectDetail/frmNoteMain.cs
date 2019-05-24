using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmNoteMain : UserControl
    {
        GridUtility gridUtility;
        
        public frmNoteMain()
        {
            InitializeComponent();
            gridUtility = new GridUtility(gridControl1);
        }

        private void frmNoteMain_Load(object sender, EventArgs e)
        {
            labelNotify1.SetText("", ToolBoxCS.LabelNotify.EnumStatus.Other);
            //Load DB
            IList<NoteProjectDetail> lstnote = new List<NoteProjectDetail>();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    lstnote = uow.NoteProjectDetailBaseRepository.All();
                    uow.Commit();
                }
                gridUtility.BindingData(lstnote);
            }
            catch
            {

            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateNote obj = new frmCreateNote();
            obj.insertnote = InsertOrUpdate;
            obj.ShowDialog();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                DialogResult rs = FormUtility.MsgDelete();
                if (rs== DialogResult.Yes)
                {
                    try
                    {
                        NoteProjectDetail note = gridUtility.GetSelectedItem<NoteProjectDetail>();
                        using (IUnitOfWork uow = new UnitOfWork())
                        {
                            uow.NoteProjectDetailBaseRepository.Remove(note);
                            uow.Commit();
                        }
                        //remove
                        gridView1.DeleteSelectedRows();
                        labelNotify1.SetText(UI.removesuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
                    }
                    catch
                    {
                        labelNotify1.SetText(UI.removefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                    }

                }
                e.Handled = true;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView grid = sender as GridView;
            GridHitInfo hi = gridView1.CalcHitInfo(grid.GridControl.PointToClient(MousePosition));
            if(hi.InRowCell|| hi.InRow)
            {
                frmEditNote obj = new frmEditNote(gridUtility.GetSelectedItem<NoteProjectDetail>());
                obj.updatenote = InsertOrUpdate;
                obj.ShowDialog();
            }
        }

        private void InsertOrUpdate(NoteProjectDetail note, CRUD cru)
        {
            if (cru == CRUD.Insert)
                gridUtility.AddNewRow( note);
            else
                gridUtility.UpdateRow( note);
            gridView1.RefreshData();
        }
    }
}
