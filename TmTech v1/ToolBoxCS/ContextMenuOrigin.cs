using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using TmTech_v1.Utility;
namespace TmTech_v1.ToolBoxCS
{
    public interface IGridviewContextMenu
    {
        void Add(object obj,int selectedrow);
        void SetGridview(GridView gridview, string primarykeyName);
        void Show(Point point);
        bool Approve();
        bool Delete();
        void Edit();
        void Copy();
        void Paste();
    }
    public class ContextItem
    {
        public bool ShowEdit { get; set; }
        public bool ShowCopy { get; set; }
        public bool ShowPaste { get; set; }
        public bool ShowDelete { get; set; }
        public bool ShowApprove { get; set; }
        public bool ShowCancel { get; set; }
        public ContextItem()
        {
            ShowEdit = ShowCopy = ShowPaste = ShowDelete = false;
            ShowApprove = ShowCancel = false;
        }
    }
    public abstract class ContextMenuOrigin : ContextMenuStrip
    {
        public ToolStripMenuItem itemCopy, itemPaste, itemDelete, itemEdit,itemApprove,itemCancel;
        public bool isCopied;
        public int m_Selectedrow = 0;
        //public GridControl m_GridControl;
        public GridView m_GridView;
        private string colPrimaryKeyName = string.Empty;
        public string ColPrimaryKeyName
        {
            get
            {
                return colPrimaryKeyName;
            }
            set
            {
                colPrimaryKeyName = value;
            }
        }
        public void Init(ContextItem ctxItem)
        {
            if (ctxItem.ShowCopy == true)
            {
                itemCopy = new ToolStripMenuItem();
                itemCopy.Text = "Copy";
                itemCopy.Name = "Copy";
                itemCopy.Image = TmTech_v1.Properties.Resources.Copy_32px;
                itemCopy.Click += itemCopy_Click;
                this.Items.Add(itemCopy);
            }
            if (ctxItem.ShowPaste == true)
            {
                itemPaste = new ToolStripMenuItem();
                itemPaste.Text = "Paste";
                itemPaste.Name = "Paste";
                itemPaste.Image = TmTech_v1.Properties.Resources.Paste_32px;
                itemPaste.Click += itemPaste_Click;
                this.Items.Add(itemPaste);
            }
            if (ctxItem.ShowDelete == true)
            {
                itemDelete = new ToolStripMenuItem();
                itemDelete.Text = "Delete";
                itemDelete.Name = "Delete";
                itemDelete.Image = TmTech_v1.Properties.Resources.Delete_32px;
                itemDelete.Click += itemDelete_Click;
                this.Items.Add(itemDelete);
            }
            if (ctxItem.ShowEdit == true)
            {
                itemEdit = new ToolStripMenuItem();
                itemEdit.Text = "Edit";
                itemEdit.Name = "Edit";
                itemEdit.Image = TmTech_v1.Properties.Resources.Edit_32px;
                itemEdit.Click += itemEdit_Click;
                this.Items.Add(itemEdit);
            }
            if (ctxItem.ShowApprove == true)
            {
                itemApprove = new ToolStripMenuItem();
                itemApprove.Text = "Approve";
                itemApprove.Name = "Approve";
                itemApprove.Image = TmTech_v1.Properties.Resources.Checkmark_32px;
                itemApprove.Click +=  itemApprove_Click;
                this.Items.Add(itemApprove);
            }
            if (ctxItem.ShowCancel == true)
            {
                itemCancel = new ToolStripMenuItem();
                itemCancel.Text = "Cancel";
                itemCancel.Name = "Cancel";
                itemCancel.Image = TmTech_v1.Properties.Resources.Trash_32px;
                //itemCancel.Click += itemEdit_Click;
                this.Items.Add(itemCancel);
            }
        }

       
        public void AddNewRow<T>(T obj) where T : class
        {
            if (obj == null) return;
            m_GridView.AddNewRow();
            int rowHandle = m_GridView.GetRowHandle(m_GridView.DataRowCount);
            UpdateRow<T>(rowHandle, obj);
            m_GridView.RefreshData();
        }
        public void UpdateRow<T>(int row, T obj) where T : class
        {
            if (obj == null) return;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in m_GridView.Columns)
            {
                string[] props = col.FieldName.Split('.');
                if (props != null)
                {
                    PropertyInfo propInfo = obj.GetType().GetProperty(props[0]);
                    if (propInfo != null)
                    {
                        object val = propInfo.GetValue(obj, null);
                        if (val != null)
                        {
                            for (int i = 1; i < props.Length; i++)
                            {
                                propInfo = val.GetType().GetProperty(props[i]);
                                val = propInfo!=null? propInfo.GetValue(val, null):null;
                            }
                            m_GridView.SetRowCellValue(row, col, val);
                        }
                    }
                }
            }
            m_GridView.RefreshData();
        }
        public void itemEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }
        public abstract void Edit();
        public void itemApprove_Click(object sender, EventArgs e)
        {
            DialogResult result = FormUtility.MsgApprove();
            if (result == DialogResult.Yes)
                Approve();
        }
        public abstract bool Approve();
        //public void DoApprove()
        //{
        //    bool success = Approve();
        //}
        public void itemDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.Yes)
                DoDelete();
        }
        public void DoDelete()
        {
            bool isdeleteSucsess = Delete();
            if (isdeleteSucsess == true)
                m_GridView.DeleteRow(m_GridView.GetSelectedRows().FirstOrDefault());
        }
        public abstract bool Delete();
        public void itemPaste_Click(object sender, EventArgs e)
        {
            DoPaste();
        }
        public void DoPaste()
        {
            Paste();
        }
        public abstract void Paste();
        public void itemCopy_Click(object sender, EventArgs e)
        {
            DoCopy();
            isCopied = true;
        }
        public void DoCopy()
        {
            Copy();
        }
        public abstract void Copy();
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (itemPaste == null) return;
            if (isCopied)
                itemPaste.Enabled = true;
            else
                itemPaste.Enabled = false;
        }
    }
}
