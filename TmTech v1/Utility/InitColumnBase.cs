using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using TmTech_v1.Model;
using TmTech_v1.ToolBoxCS;

namespace TmTech_v1.Utility
{
    public interface IInitColumn
    {
        void InitColumn();
        void InitColumn(List<GridColumn> lstDefinedColumn);
    }
    public abstract class InitColumnBase
    {
        public GridView m_GridView;
        public CheckBoxCombobox m_CheckboxCombobox;
        public List<ColumnInforModel> lstColumn;
        public string[] columnToShow = null;
        public InitColumnBase(GridView gridview, CheckBoxCombobox checkboxCombobox)
        {
            m_GridView = gridview;
            m_CheckboxCombobox = checkboxCombobox;
            m_CheckboxCombobox.CheckStateChanged += M_CheckboxCombobox_CheckStateChanged;
            lstColumn = new List<ColumnInforModel>();
        }

        private void M_CheckboxCombobox_CheckStateChanged(object sender, EventArgs e)
        {
            CheckComboBoxItem checkboxitem = sender as CheckComboBoxItem;
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in m_GridView.Columns)
            {
                if (column.FieldName == checkboxitem.Value)
                {
                    column.Visible = checkboxitem.CheckState;
                    return;
                }
            }
        }

        public void InsertColumn(List<ColumnInforModel> lstColumnInsert)
        {
            columnToShow = UtilityFunction.ReadColumnToShow();
            foreach (var column in lstColumnInsert)
            {
                GridColumn gridColumn = new GridColumn();
                gridColumn.Caption = column.Caption;
                gridColumn.FieldName = column.FieldName;
                gridColumn.Name = column.Name;
                gridColumn.Tag = column.Tag;
                gridColumn.Width = 100;
                gridColumn.Visible = column.Vissible;
                gridColumn.OptionsColumn.AllowEdit = column.AllowEdit;
                var checkedState = false;
                if (columnToShow == null)
                {
                }
                else
                    if (columnToShow.Contains(column.FieldName))
                        checkedState = true;
                    else
                    {
                    }
                m_CheckboxCombobox.Items.Add(new CheckComboBoxItem(column.Caption, checkedState, column.FieldName));
                gridColumn.Visible = checkedState;
                m_GridView.Columns.Add(gridColumn);

            }
            m_GridView.FocusedRowHandle = GridControl.InvalidRowHandle;
            m_GridView.ClearSelection();
        }

    }
}
