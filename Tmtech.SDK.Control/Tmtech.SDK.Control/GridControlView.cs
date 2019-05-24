using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Tmtech.SDK.Control.Model;
using DevExpress.XtraGrid.Views.Base;

namespace Tmtech.SDK.Control
{
    [ToolboxItem(true)]
    public class GridControlView : GridControl
    {

        private readonly List<string> _exceptionFieldName = new List<string>();
        public string PrimaryKey { get; set; }
        public Action<object> DoubleClickRow;
        private GridView gridView1;
        public Action<object> RowClick;

        public GridView GridViewData
        {
            get { return (GridView)MainView; }

        }

        public GridControlView()
        {
             _exceptionFieldName.Add("stt");
            
        }

         void GridViewData_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            DrawStt(e);
        }

        private void DrawStt(RowCellCustomDrawEventArgs e, string fieldname = "Stt")
        {
            
            if (e.Column.FieldName == fieldname)
            {
                if (e.RowHandle >= 0)
                    e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
        public void Delete<T>(T entry = default(T))
        {
            if (entry == null)
                return;

            var itemKey = entry.GetType().GetProperty(PrimaryKey);
            if (itemKey == null)
                return;
            var valueKey = itemKey.GetValue(entry, null);
            var rowHandler = GridViewData.LocateByValue(PrimaryKey, valueKey);
            if (rowHandler != InvalidRowHandle)
            {
                RemoveRow(rowHandler);
            }

        }
        public void GetEntry<T>(T entry)
        {

        }
        public void Insert<T>(T entry) where T : class
        {
            var list = GetList<T>();
            list.Add(entry);
        }
        public void Insert<T>(List<T> entry) where T : class
        {
            var list = GetList<T>();
            foreach (var item in entry)
            {
                list.Add(item);
            }

        }
        public void InsertOrUpdate<T>(T entry) where T : class
        {
            var itemKey = entry.GetType().GetProperty(PrimaryKey);
            if (itemKey == null)
                return;
            var valueKey = itemKey.GetValue(entry, null);
            var rowHandler = GridViewData.LocateByValue(PrimaryKey, valueKey);
            if (rowHandler != InvalidRowHandle)
            {
                UpdateRow(entry, rowHandler);
            }
            else
            {
                Insert(entry);
            }
        }
        private void UpdateRow<T>(T entryUpdate, int rowIndex) where T : class
        {

            foreach (GridColumn item in GridViewData.Columns)
            {
                var fieldName = item.FieldName;
                if (string.IsNullOrEmpty(fieldName))
                    continue;
                if (_exceptionFieldName.Contains(fieldName))
                    continue;
                var propInfo = entryUpdate.GetType().GetProperty(fieldName);
                if (propInfo == null)
                    continue;
                var value = propInfo.GetValue(entryUpdate, null);
                GridViewData.SetRowCellValue(rowIndex, item, value);
            }
        }
        public void Update<T>(T entry) where T : class
        {
            var itemKey = entry.GetType().GetProperty(PrimaryKey);
            if (itemKey == null)
                return;
            var valueKey = itemKey.GetValue(entry, null);
            var rowHandler = GridViewData.LocateByValue(PrimaryKey, valueKey);
            if (rowHandler != InvalidRowHandle)
            {
                UpdateRow(entry, rowHandler);
            }
        }
        public void RemoveRow(int rowIndex)
        {
            if (rowIndex < GridViewData.RowCount)
                GridViewData.DeleteRow(rowIndex);
        }
        public T SelectRow<T>() where T : class
        {
            var i = GridViewData.GetSelectedRows().FirstOrDefault();
            return GridViewData.GetRow(i) as T;
        }
        public T SelectRow<T>(int rowSelect) where T : class
        {
            if (rowSelect > GridViewData.DataRowCount)
                return null;
            return GridViewData.GetRow(rowSelect) as T;
        }
        public void AddColumn(ColumnGrid columnGrid)
        {
            GridColumn column = new GridColumn();
            if (!string.IsNullOrEmpty(columnGrid.Name))
            {
                column.Name = columnGrid.Name;
            }
            if (!string.IsNullOrEmpty(columnGrid.FieldName))
            {
                column.FieldName = columnGrid.FieldName;
            }
            if (!string.IsNullOrEmpty(columnGrid.Caption))
            {
                column.Caption = columnGrid.Caption;
            }
            column.Width = columnGrid.Width > 0 ? columnGrid.Width : 100;
            column.Visible = true;
            GridColumn gridColumn = GridViewData.Columns.FirstOrDefault(x => x.FieldName == columnGrid.FieldName);
            if (gridColumn == null)
            {
                GridViewData.Columns.Add(column);
            }
            else
            {
                gridColumn.Caption = columnGrid.Caption;
                gridColumn.Name = columnGrid.Name;

            }
            switch (columnGrid.Type)
            {
                case TypeColumn.Money:

                    break;
                case TypeColumn.Number:
                    break;
            }
        }
        public void AddColumn(List<ColumnGrid> columnGrid)
        {
            foreach (var item in columnGrid)
            {
                AddColumn(item);
            }

            UseEmbeddedNavigator = true;
            GridViewData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;

        }
        public void ColumnFormat()
        {
            foreach (GridColumn item in GridViewData.Columns)
            {
                if (item.ColumnType == typeof(DateTime))
                {
                    item.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    item.DisplayFormat.FormatString = Constraint.FormatDateTime;
                }
            }
        }
        public List<TModel> GetList<TModel>()
        {
            if (DataSource == null)
                return new List<TModel>();
            else
            {
                try
                {
                    return (List<TModel>)DataSource;
                }
                catch (Exception)
                {

                    return new List<TModel>();
                }
            }

        }

        protected override void OnCreateControl()
        {
            GridColumn columStt = new GridColumn()
            {
                Caption = "STT",
                FieldName = "Stt",
                Visible = true,
                Name = "STT",
                VisibleIndex = 0,
            };
            columStt.OptionsColumn.AllowEdit = false;
            if (!GridViewData.Columns.Any(x=>x.FieldName == columStt.FieldName))
            {
                GridViewData.Columns.Add(columStt);
            }
            GridViewData.CustomDrawCell -= GridViewData_CustomDrawCell;
            GridViewData.CustomDrawCell += GridViewData_CustomDrawCell;

            GridViewData.DoubleClick += GridViewData_DoubleClick;
            GridViewData.Click += GridViewData_Click;
            base.OnCreateControl();
        }
       private int _rowSelect = -1;
       private int _rowDoubleSelect = -1;
        void GridViewData_Click(object sender, EventArgs e)
        {
            var selectRowindex = GridViewData.GetSelectedRows().FirstOrDefault();
            if (_rowSelect == selectRowindex)
                return;
            if (RowClick != null)
            {
                RowClick(SelectRow<object>());
                _rowSelect = selectRowindex;
            }
            
        }
        void GridViewData_DoubleClick(object sender, EventArgs e)
        {
            var selectRowindex = GridViewData.GetSelectedRows().FirstOrDefault();
            if (_rowDoubleSelect == selectRowindex)
                return;

            if (DoubleClickRow != null)
            {
                var rowDoubleClick = SelectRow<object>();
                DoubleClickRow(rowDoubleClick);
                _rowDoubleSelect = selectRowindex;
            }
          
        }
        public void DrawStatusColor(object sender, RowCellStyleEventArgs e, GridColumn colStatus, GridColumn colDisplayColor)
        {
            if (e.RowHandle < 0) 
                return;
            if (e.Column == colDisplayColor)
            {
            }
        }

        private void InitializeComponent()
        {
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this;
            this.gridView1.Name = "gridView1";
            // 
            // GridControlView
            // 
            this.MainView = this.gridView1;
            this.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
