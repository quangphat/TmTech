using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.ToolBoxCS
{
    [ToolboxItem(true)]
        public partial class CustomizeGriviewControl : GridControl
    {
        public CustomizeGriviewControl()
        {
            IsFormat = true;
        }
        public bool IsFormat { get; set; }
        private GridView Gridview
        {
            get { return MainView as GridView; }

        }
        public bool DrawSTT { get; set; }
        private T GetSelectedItem<T>() where T : class
        {
            int i = Gridview.GetSelectedRows().FirstOrDefault();
            T obj = Gridview.GetRow(i) as T;
            return obj;
        }
        public void DeleteRow<T>(T entry)
        {
            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.GridviewRepository.Remove<T>(entry);
                uow.Commit();
            }
        }
        public void UpdateRow<T>(T entry)
        {
            var row = Gridview.GetSelectedRows().FirstOrDefault();
            foreach (GridColumn col in Gridview.Columns)
            {
                var props = col.FieldName.Split('.');
                {
                    var propInfo = entry.GetType().GetProperty(props[0]);
                    if (propInfo != null)
                    {
                        var val = propInfo.GetValue(entry, null);
                        if (val != null)
                        {
                            for (var i = 1; i < props.Length; i++)
                            {
                                propInfo = val.GetType().GetProperty(props[i]);
                                val = propInfo.GetValue(val, null);
                            }
                            Gridview.SetRowCellValue(row, col, val);
                        }
                    }
                }
            }
        }

        public void UpdateRow<T>(int row, T obj) where T : class
        {
            foreach (GridColumn col in Gridview.Columns)
            {
                var props = col.FieldName.Split('.');
                var propInfo = obj.GetType().GetProperty(props[0]);
                if (propInfo == null) continue;
                var val = propInfo.GetValue(obj, null);
                if (val == null) continue;
                for (var i = 1; i < props.Length; i++)
                {
                    propInfo = val.GetType().GetProperty(props[i]);
                    val = propInfo.GetValue(val, null);
                }
                Gridview.SetRowCellValue(row, col, val);
            }
            Gridview.RefreshRow(row);
        }
        public void AddNewRow<T>(T obj) where T : class
        {
            Gridview.AddNewRow();
            var rowHandle = Gridview.GetRowHandle(Gridview.DataRowCount);
            if (Gridview.IsNewItemRow(rowHandle))
                UpdateRow(rowHandle, obj);
        }
        public void BindingData<T>(IList<T> lstSource) where T : class
        {
            if (lstSource == null)
                return;
            BindingList<T> bi = new BindingList<T>(lstSource);
            DataSource = null;
            DataSource = bi;
        }
        public void SetRowColor(string htmlColor = "#90CAF9")
        {
            Gridview.Appearance.SelectedRow.BackColor = ColorTranslator.FromHtml(htmlColor);
            Gridview.Appearance.FocusedCell.BackColor = ColorTranslator.FromHtml(htmlColor);
            Gridview.Appearance.FocusedRow.BackColor = ColorTranslator.FromHtml(htmlColor);
            Gridview.Appearance.SelectedRow.Options.UseBackColor = true;
            Gridview.Appearance.SelectedRow.ForeColor = Color.White;
            Gridview.Appearance.FocusedRow.ForeColor = Color.White;
            Gridview.Appearance.SelectedRow.Options.UseForeColor = true;
        }

        public void FormatDisplay(bool showGroupPanel = false, bool showAutoFilterRow = true)
        {
            Gridview.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Bold);
            Gridview.Appearance.HeaderPanel.Options.UseFont = true;
            Gridview.ColumnPanelRowHeight = 30;
            Gridview.OptionsView.ShowAutoFilterRow = showAutoFilterRow;
            Gridview.OptionsView.ShowGroupPanel = showGroupPanel;
            foreach (GridColumn column in Gridview.Columns)
            {
                if (column.Tag == null) continue;
                if (column.Tag.ToString() == "datetime")
                {
                    column.DisplayFormat.FormatType = FormatType.Custom;
                    column.DisplayFormat.FormatString = "dd/MM/yyyy";
                }
                if (column.Tag.ToString() != "money") continue;
                column.DisplayFormat.FormatType = FormatType.Custom;
                column.DisplayFormat.FormatString = "#,###";
                column.DisplayFormat.Format = UtilityFunction.VnCul;
            }
        }
        void Init()
        {
            this.Gridview.CustomDrawCell += Gridview_CustomDrawCell;
            this.ProcessGridKey += DatagridviewMain_ProcessGridKey;
            this.Gridview.RowClick += Gridview_RowClick;
        }

        void Gridview_RowClick(object sender, RowClickEventArgs e)
        {
            SetRowColor();
        }
        public void DrawStt(RowCellCustomDrawEventArgs e, string fieldname = "Stt")
        {
            if (!DrawSTT)
                return;
            if (e.Column.FieldName == fieldname)
            {
                if (e.RowHandle >= 0)
                    e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
        void Gridview_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (DrawSTT)
                DrawStt(e);
        }

        private void DatagridviewMain_ProcessGridKey(object sender, KeyEventArgs e)
        {

            //if (e.KeyData == Keys.Delete)
            //{
            //    DialogResult result = FormUtility.MsgDelete();
            //    if (result == DialogResult.Yes)
            //    {
            //        int i = Gridview.GetSelectedRows().FirstOrDefault();
            //        object obj = Gridview.GetRow(i) as object;
            //        if (obj == null) return;
            //        DeleteRow<object>(obj);
            //        Gridview.DeleteRow(i);
            //    }
            //}
            //e.Handled = true;
        }
        bool isloaded = true;
        protected override void OnCreateControl()
        {
            if (isloaded)
            {
                Init();
                Gridview.OptionsBehavior.AutoPopulateColumns = false;
                isloaded = false;
                DrawSTT = true;

                if (DrawSTT)
                {
                    GridColumn gridColumn = new GridColumn();
                    gridColumn.Caption = "STT";
                    gridColumn.FieldName = "Stt";
                    gridColumn.Name = "colStt";
                    gridColumn.Width = 50;
                    gridColumn.VisibleIndex = 0;
                    if (!Gridview.Columns.Contains(gridColumn))
                        Gridview.Columns.Insert(0, gridColumn);
                }
                FormatDisplay();
                SetRowColor();
            }
            //base.OnLoaded();
            base.OnCreateControl();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public void DeleteRow(int rowIndex)
        {
            throw new NotImplementedException();
        }

        public void InsertColumn (List<ColumnInforModel> lstColumnInsert)
        {
            GridColumn gridColumn = new GridColumn();
            foreach (var column in lstColumnInsert)
            {
                gridColumn.Caption = column.Caption;
                gridColumn.FieldName = column.FieldName;
                gridColumn.Name = column.Name;
                gridColumn.Width = column.Width;
                gridColumn.Tag = column.Tag;
                gridColumn.Width = column.Width;
                Gridview.Columns.Add(gridColumn);
            }
        }
       
        public void RequesetHideColumn( string fieldName , bool visible  =false)
        {
            foreach (GridColumn item in  Gridview.Columns)
            {
                if( item.FieldName == fieldName)
                {
                    item.Visible = visible;
                    return;
                }
            }
        }
    }

   
}
