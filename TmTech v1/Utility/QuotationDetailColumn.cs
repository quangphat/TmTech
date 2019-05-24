using System.Collections.Generic;
using System.Linq;
using TmTech_v1.Model;
using TmTech_v1.ToolBoxCS;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace TmTech_v1.Utility
{
    public class QuotationDetailColumn : InitColumnBase, IInitColumn
    {
        public QuotationDetailColumn(GridView gridview, CheckBoxCombobox checkboxCombobox):base(gridview,checkboxCombobox)
        { 
        }
        public void InitColumn()
        {
            
            ColumnInforModel obj = new ColumnInforModel
            {
                Caption = "Input Voltage",
                FieldName = "InputVoltage",
                AllowEdit = false,
                Vissible = false
            };
            lstColumn.Add(obj);
            obj = new ColumnInforModel
            {
                Caption = "Angle",
                FieldName = "Angle",
                AllowEdit = false,
                Vissible = false
            };
            lstColumn.Add(obj);
            obj = new ColumnInforModel
            {
                Caption = "Branch Of Led",
                FieldName = "BranchOfLed",
                AllowEdit = false,
                Vissible = false
            };
            lstColumn.Add(obj);
            obj = new ColumnInforModel
            {
                Caption = "Color Housing",
                FieldName = "ColorHousing",
                AllowEdit = false,
                Vissible = false
            };
            lstColumn.Add(obj);
            obj = new ColumnInforModel
            {
                Caption = "Temperature",
                FieldName = "Temperature",
                AllowEdit = false,
                Vissible = false

            };
            lstColumn.Add(obj);
            obj = new ColumnInforModel
            {
                Caption = "Class product",
                FieldName = "ClassProduct",
                AllowEdit = false,
                Vissible = false
            };
            lstColumn.Add(obj);
            obj = new ColumnInforModel
            {
                Caption = "IP Rate",
                FieldName = "IPRate",
                AllowEdit = false,
                Vissible = false
            };
            lstColumn.Add(obj);
            obj = new ColumnInforModel
            {
                Caption = "Standard",
                FieldName = "Standard",
                AllowEdit = false,
                Vissible = false
            };
            lstColumn.Add(obj);
            obj = new ColumnInforModel
            {
                Caption = "Profile housing",
                FieldName = "ProfileHousing",
                AllowEdit = false,
                Vissible = false
            };
            lstColumn.Add(obj);
            obj = new ColumnInforModel
            {
                Caption = "Housing",
                FieldName = "Housing",
                AllowEdit = false,
                Vissible = false
            };
            lstColumn.Add(obj);

            obj = new ColumnInforModel
            {
                Caption = "Head",
                FieldName = "Head",
                AllowEdit = false,
                Vissible = false
            };
            lstColumn.Add(obj);

            obj = new ColumnInforModel
            {
                Caption = "Watt",
                FieldName = "Watt",
                AllowEdit = false,
                Vissible = false
            };
            lstColumn.Add(obj);
            obj = new ColumnInforModel
            {
                Caption = "Cri",
                FieldName = "Cri",
                AllowEdit = false,
                Vissible = false
            };
            lstColumn.Add(obj);
            obj = new ColumnInforModel
            {
                Caption = "IK Rate",
                FieldName = "IKRate",
                AllowEdit = false,
                Vissible = false
            };
            lstColumn.Add(obj);
            obj = new ColumnInforModel
            {
                Caption = "Control",
                FieldName = "Control",
                AllowEdit = false,
                Vissible = false
            };
            lstColumn.Add(obj);

            obj = new ColumnInforModel
            {
                Caption = "Enec",
                FieldName = "Enec",
                AllowEdit = false,
                Vissible = false
            };
            lstColumn.Add(obj);
            obj = new ColumnInforModel
            {
                Caption = "Pixel",
                FieldName = "Pixel",
                AllowEdit = false,
                Vissible = false
            };
            lstColumn.Add(obj);
            obj = new ColumnInforModel
            {
                Caption = "Mã yêu cầu",
                FieldName = "CustomerProductCode",
                AllowEdit = false,
                Vissible = false
            };
            lstColumn.Add(obj);
            obj = new ColumnInforModel
            {
                Caption = "Thời gian bảo hành",
                FieldName = "WarrantyTime",
                AllowEdit = false,
                Vissible = false,
                Tag = "datetime"
            };
            lstColumn.Add(obj);
            obj = new ColumnInforModel
            {
                Caption = "Thời gian giao hàng",
                FieldName = "DeliveryTime",
                AllowEdit = true,
                Vissible = false,
                Tag = "datetime"
            };
            lstColumn.Add(obj);
            InsertColumn(lstColumn);
        }
        public void InitColumn(List<GridColumn> lstDefinedColumn)
        {
            InitColumn();
            bool checkedState = false;
            foreach (GridColumn col in lstDefinedColumn)
            {
                if (columnToShow == null)
                    checkedState = false;
                else
                    if (columnToShow.Contains(col.FieldName))
                        checkedState = true;
                m_CheckboxCombobox.Items.Add(new CheckComboBoxItem(col.Caption, checkedState, col.FieldName));
                col.Visible = checkedState;
            }
        }
    }
}
