using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.ToolBoxCS;

namespace TmTech_v1.Utility
{
    public class GridUtility
    {
        private readonly GridControl m_GridControl;
        private readonly GridView m_Gridview;
        public IGridviewContextMenu m_IGridviewCtxMenu;
        private GridColumn colProductPicture;
        public object obj {get;set;}
        public GridColumn ColProductPicture
        {
            get
            {
                return colProductPicture;
            }
            set
            {
                colProductPicture = value;
            }
        }
        private GridColumn colProductPicturePath;
        public GridColumn ColProductPicturePath
        {
            get
            {
                return colProductPicturePath;
            }
            set
            {
                colProductPicturePath = value;
            }
        }
        private GridColumn colDimensionPicture;
        public GridColumn ColDimensionPicture
        {
            get
            {
                return colDimensionPicture;
            }
            set
            {
                colDimensionPicture = value;
            }
        }
        public GridColumn colDimensionPicturePath;
        public GridColumn ColDimensionPicturePath
        {
            get
            {
                return colDimensionPicturePath;
            }
            set
            {
                colDimensionPicturePath = value;
            }
        }
        private GridColumn colTotalDescription;
        public GridColumn ColTotalDescription
        {
            get
            {
                return colTotalDescription;
            }
            set
            {
                colTotalDescription = value;
            }
        }
        private readonly string colPrimaryKeyName;
        private bool allowDelete = false;
        public bool AllowDelete
        {
            set
            {
                allowDelete = value;
            }
        }
        public GridUtility()
        {
            colProductPicturePath = colProductPicture = colTotalDescription = null;
            colPrimaryKeyName = "";
        }
        public GridUtility(GridControl gridcontrol, bool showGroupPanel = false, bool showAutoFilterRow = true,int SttWidth = 35,GridColumn Descrition = null)
        {
            m_IGridviewCtxMenu = null;
            m_GridControl = gridcontrol;
            m_Gridview = (GridView)gridcontrol.MainView;
            colTotalDescription = Descrition;
            m_GridControl.ProcessGridKey += grid_ProcessGridKey;
            m_Gridview.MouseUp += m_Gridview_MouseUp;
            m_Gridview.CustomDrawCell += M_Gridview_CustomDrawCell;
            FormatDisplay(showGroupPanel,showAutoFilterRow,SttWidth);
            m_Gridview.ClearSelection();
            colPrimaryKeyName = "";
        }
        public GridUtility(GridControl gridcontrol,IGridviewContextMenu gridviewCtx, bool showGroupPanel = false, bool showAutoFilterRow = true, int SttWidth = 35, GridColumn Descrition = null)
        {
            m_IGridviewCtxMenu = gridviewCtx;
            //m_IGridviewCtxMenu.
            m_GridControl = gridcontrol;
            m_Gridview = (GridView)gridcontrol.MainView;
            colTotalDescription = Descrition;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in m_Gridview.Columns)
            {
                if (col.Tag != null)
                {
                    if (col.Tag.ToString() == "primarykey")
                        colPrimaryKeyName = col.FieldName;
                }
            }
            m_IGridviewCtxMenu.SetGridview(m_Gridview,colPrimaryKeyName);
            m_GridControl.ProcessGridKey += grid_ProcessGridKey;
            m_Gridview.MouseUp += m_Gridview_MouseUp;
            m_Gridview.CustomDrawCell += M_Gridview_CustomDrawCell;
            FormatDisplay(gridviewCtx, showGroupPanel, showAutoFilterRow,SttWidth);
            m_Gridview.ClearSelection();
        }
        private void M_Gridview_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            DrawAll(e);
        }

        public void AddNewRow<T>(T obj) where T : class
        {
            if (obj == null) return;
            m_Gridview.AddNewRow();
            int rowHandle = m_Gridview.GetRowHandle(m_Gridview.DataRowCount);
            if (rowHandle == 0) rowHandle = 1;
            UpdateRow<T>(rowHandle, obj);
            m_Gridview.RefreshData();
        }
        public void UpdateRow<T>(int row,T obj) where T:class
        {
            if (obj == null) return;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in m_Gridview.Columns)
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
                                val = propInfo.GetValue(val, null);
                            }
                            m_Gridview.SetRowCellValue(row, col, val);
                        }
                    }
                }
            }
            m_Gridview.RefreshData();
        }
        public void UpdateRow<T>(T obj) where T : class
        {
            if (obj == null) return;
            int row = m_Gridview.GetSelectedRows().FirstOrDefault();
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in m_Gridview.Columns)
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
                                val = propInfo.GetValue(val, null);
                            }
                            m_Gridview.SetRowCellValue(row, col, val);
                        }
                    }
                }
            }
            m_Gridview.RefreshData();
        }
        //devexpress
        public void BindingData<T>(IList<T> lstSource) where T : class
        {
            if (lstSource == null)
                return;
            BindingList<T> bi = new BindingList<T>(lstSource);
            m_GridControl.DataSource = null;
            m_GridControl.DataSource = bi;
        }
        public void SetRowColor(Color? color=null)
        {
            color = color == null ? ((int)TmTechColor.GridviewRow).ToColor() : ColorTranslator.FromHtml("#45CAEA");
            m_Gridview.Appearance.SelectedRow.BackColor = color.Value;
            m_Gridview.Appearance.FocusedCell.BackColor = color.Value;
            m_Gridview.Appearance.FocusedRow.BackColor = color.Value;
            m_Gridview.Appearance.SelectedRow.Options.UseBackColor = true;
            m_Gridview.Appearance.SelectedRow.ForeColor = Color.White;
            m_Gridview.Appearance.FocusedRow.ForeColor = Color.White;
            m_Gridview.Appearance.SelectedRow.Options.UseForeColor = true;
        }
        public void FormatDisplay(bool showGroupPanel = false,bool showAutoFilterRow = true, int SttWidth = 35)
        {
            m_Gridview.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Bold);
            m_Gridview.Appearance.HeaderPanel.Options.UseFont = true;
            m_Gridview.ColumnPanelRowHeight = 30;
            m_Gridview.OptionsView.ShowAutoFilterRow = showAutoFilterRow;
            m_Gridview.OptionsView.ShowGroupPanel = showGroupPanel;
            foreach (GridColumn column in m_Gridview.Columns)
            {
                if (column.Tag != null)
                {
                    if (column.Tag.ToString() == "datetime")
                    {
                        column.DisplayFormat.FormatType = FormatType.Custom;
                        column.DisplayFormat.FormatString = "dd/MM/yyyy";
                    }
             if (column.Tag.ToString() == "money")
                    {
                        column.DisplayFormat.FormatType = FormatType.Custom;
                        column.DisplayFormat.FormatString = "#,###";
                        column.DisplayFormat.Format = UtilityFunction.VnCul;
                        column.SummaryItem.DisplayFormat = "{0:#,###}";
                        column.SummaryItem.Format = UtilityFunction.VnCul;
                    }
                }
                if(column.FieldName=="Stt")
                {
                    column.Width = SttWidth;
                }
            }
        }
        
        public void FormatDisplay(IGridviewContextMenu IgridviewctxMenu, bool showGroupPanel = false, bool showAutoFilterRow = true, int SttWidth = 35)
        {
            FormatDisplay(showGroupPanel, showAutoFilterRow,SttWidth);
            //.MouseUp += _MouseUp;
            m_IGridviewCtxMenu = IgridviewctxMenu;
        }

        void grid_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete) return;
            if (allowDelete == false) return;

            if (!string.IsNullOrWhiteSpace(colPrimaryKeyName))
            {
                int i = m_Gridview.GetSelectedRows()[0];
                object row = m_Gridview.GetRow(i);
                if (row != null)
                {
                    try
                    {
                        using (IUnitOfWork uow = new UnitOfWork())
                        {
                            uow.ObjectCoverRepositroy.DeleteById(row, colPrimaryKeyName);
                            uow.Commit();
                        }
                        m_Gridview.DeleteRow(i);
                        m_Gridview.ClearSelection();

                    }
                    catch
                    {
                    }
                }
            }
        }
        void m_Gridview_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (m_IGridviewCtxMenu == null) return;
                int i = m_Gridview.GetSelectedRows().FirstOrDefault();
                object row = m_Gridview.GetRow(i);
                if (row == null) return;
                //if (ctxMenu == null || ctxMenu.IsDisposed)
                //    ctxMenu = new GridviewContextMenu(gridview);
                m_IGridviewCtxMenu.Add(row,i);
                m_IGridviewCtxMenu.Show(Cursor.Position);
            }
        }
        public void DrawAll(DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e, string fieldname = "Stt")
        {
            if (e.Column.FieldName == fieldname)
            {
                if (e.RowHandle >= 0)
                    e.DisplayText = (e.RowHandle + 1).ToString();
            }
            if(colTotalDescription!=null)
            {
                string text = string.Empty;
                if (e.Column == colTotalDescription)
                {
                    obj = m_Gridview.GetRow(e.RowHandle);
                    text = e.CellValue != null ? e.CellValue.ToString() : "";
                    text = ProductUtility.ConvertToDescription(obj,ProductUtility.QuotationDetailToDescription);
                    GridCellInfo cell = e.Cell as GridCellInfo;
                    e.Appearance.FillRectangle(e.Cache, e.Bounds);
                    StringFormat f = cell.ViewInfo.PaintAppearance.GetStringFormat(TextOptions.DefaultOptionsMultiLine);
                    e.Graphics.DrawString(text, cell.ViewInfo.PaintAppearance.Font,
                      cell.ViewInfo.PaintAppearance.GetForeBrush(e.Cache),
                      e.Bounds, f);
                    e.Handled = true;
                }
            }
            if(colProductPicture !=null && colProductPicturePath !=null)
            {
                if (e.Column == colProductPicture)
                {
                    string path = string.Empty;
                    path = m_Gridview.GetRowCellValue(e.RowHandle, colProductPicturePath) != null ? m_Gridview.GetRowCellValue(e.RowHandle, colProductPicturePath).ToString() : "";
                    Image img = PictureUtility.GetImg(path);
                    e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y, e.Bounds.Height, e.Bounds.Height);
                }
            }
            if (colDimensionPicturePath != null && colDimensionPicture != null)
            {
                if (e.Column == colDimensionPicture)
                {
                    string path = string.Empty;
                    path = m_Gridview.GetRowCellValue(e.RowHandle, colDimensionPicturePath) != null ? m_Gridview.GetRowCellValue(e.RowHandle, colDimensionPicturePath).ToString() : "";
                    if (FileUtility.PathIsImage(path))
                    {
                        e.DisplayText = "";
                        Image img = PictureUtility.GetImg(path);
                        e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y, e.Bounds.Height, e.Bounds.Height);
                    }
                    //else
                    //    e.DisplayText = path;
                }
            }
        }
        public void DrawStatusColor(object sender, RowCellStyleEventArgs e, GridColumn colStatus, string colName = "colCompanyName")
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.Name == colName)
                {
                    bool Status = bool.Parse(View.GetRowCellValue(e.RowHandle, colStatus).ToString());
                    Model.Company row = View.GetRow(e.RowHandle) as Model.Company;
                    if (row != null)
                    {
                        if (row.isActive == false)
                        {
                            e.Appearance.BackColor = ((int)TmTechColor.Cancel).ToColor();
                            e.Appearance.ForeColor = Color.White;
                        }
                    }
                }
            }
        }
        private enum StatusFlag { Waiting = 1, OK = 2, Cancel = 3 }
        public void DrawStatusColor(object sender, RowCellStyleEventArgs e, GridColumn colStatus, GridColumn colDisplayColor)
        {
            if (e.RowHandle >= 0)
            {
                if (e.Column == colDisplayColor)
                {
                    var temp = m_Gridview.GetRowCellValue(e.RowHandle, colStatus);
                    int Status = temp!=null? Convert.ToInt32(Convert.ChangeType(temp,typeof(int))):0;
                    if(Status==(int)StatusFlag.OK)
                    {
                        e.Appearance.BackColor = ((int)TmTechColor.Approved).ToColor();
                        e.Appearance.ForeColor = Color.White;
                    }
                    if (Status == (int)StatusFlag.Cancel)
                    {
                        e.Appearance.BackColor = ((int)TmTechColor.Cancel).ToColor();
                        e.Appearance.ForeColor = Color.White;
                    }
                }

            }
        }

        public void DrawColorForIncomeExpense(object sender, RowCellStyleEventArgs e, GridColumn colStatus, GridColumn colDisplayColor)
        {
            if (e.RowHandle >= 0)
            {
                if (e.Column == colDisplayColor)
                {
                    var temp = m_Gridview.GetRowCellValue(e.RowHandle, colStatus);
                    int Status = temp != null ? Convert.ToInt32(Convert.ChangeType(temp, typeof(int))) : 0;
                    if (Status == (int)StatusFlag.OK|| Status == (int)StatusFlag.Waiting)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.ForeColor = Color.White;
                    }
                }

            }
        }

        public void DrawColorForStock(object sender, RowCellStyleEventArgs e, GridColumn colStockQuantity)
        {
            if (e.RowHandle >= 0)
            {
                if (e.Column == colStockQuantity)
                {
                    int quantity = int.Parse(m_Gridview.GetRowCellValue(e.RowHandle, colStockQuantity).ToString());
                    if (quantity <=0)
                    {
                        e.Appearance.BackColor = ((int)TmTechColor.Warning).ToColor();
                        e.Appearance.ForeColor = Color.White;
                    }
                }

            }
        }
        public void DrawColorForPlanning(object sender, RowCellStyleEventArgs e, GridColumn colStatus, GridColumn colDisplayColor, GridColumn colDayleft)
        {
            if (e.RowHandle >= 0)
            {
                int Status = int.Parse(m_Gridview.GetRowCellValue(e.RowHandle, colStatus).ToString());
                if (e.Column == colDisplayColor)
                {
                    
                    if (Status == 2)
                    {
                        e.Appearance.BackColor = ((int)TmTechColor.InProgress).ToColor();
                        e.Appearance.ForeColor = Color.White;
                    }
                    else
                    if (Status == 3)
                    {
                        e.Appearance.BackColor = ((int)TmTechColor.Finish).ToColor();
                        e.Appearance.ForeColor = Color.White;
                    }
                    else
                    if (Status == 4)
                    {
                        e.Appearance.BackColor = ((int)TmTechColor.Cancel).ToColor();
                        e.Appearance.ForeColor = Color.White;
                    }
                }
                if(e.Column == colDayleft)
                {
                    string deobiettengi = m_Gridview.GetRowCellValue(e.RowHandle, colDayleft) == null ? "0" : m_Gridview.GetRowCellValue(e.RowHandle, colDayleft).ToString();
                    int dayleft =0;
                    if (deobiettengi == "Finish")
                        dayleft = 0;
                     else   dayleft = Convert.ToInt32(deobiettengi);
                    if(dayleft<=7 && Status !=3)
                    {
                        e.Appearance.BackColor = ((int)TmTechColor.Warning).ToColor();
                        e.Appearance.ForeColor = Color.White;
                    }
                }
            }
        }
        public T GetSelectedItem<T>() where T:class
        {
            int i = m_Gridview.GetSelectedRows().FirstOrDefault();
            T obj = m_Gridview.GetRow(i) as T;
            return obj;
        }


        public void BindDataToTree<T>(DevExpress.XtraTreeList.TreeList treeList1,IList<T> lstSource) where T:class
        {
            BindingList<T> bi = new BindingList<T>(lstSource);
            treeList1.DataSource = null;
            treeList1.DataSource = bi;
        }
     
        public void TreeSetRowColor(DevExpress.XtraTreeList.TreeList treeList1, Color? color =null)
        {
            color = color == null ? ((int)TmTechColor.GridviewRow).ToColor() : ColorTranslator.FromHtml("#45CAEA");
            treeList1.Appearance.SelectedRow.BackColor = (Color)color;
            treeList1.Appearance.FocusedCell.BackColor = (Color)color;
            treeList1.Appearance.FocusedRow.BackColor = (Color)color;
            treeList1.Appearance.SelectedRow.Options.UseBackColor = true;
            treeList1.Appearance.SelectedRow.ForeColor = Color.White;
            treeList1.Appearance.FocusedRow.ForeColor = Color.White;
            treeList1.Appearance.SelectedRow.Options.UseForeColor = true;
        }
        public void SetGridEditable(GridView gridview,bool editable)
        {
            gridview.OptionsBehavior.Editable = editable;
            foreach(GridColumn column in gridview.Columns)
            {
                column.OptionsColumn.AllowEdit = editable;
            }
        }
       
    }
}
