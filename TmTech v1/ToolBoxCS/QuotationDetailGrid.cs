using DevExpress.XtraGrid;
using System;
using System.Windows.Forms;
using TmTech_v1.CustomModel;

namespace TmTech_v1.ToolBoxCS
{
    public partial class QuotationDetailGrid : GridControl
    {
        private DevExpress.XtraGrid.Columns.GridColumn colStt;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDonvi;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDongia;
        private DevExpress.XtraGrid.Columns.GridColumn colSoluong;
        private DevExpress.XtraGrid.Columns.GridColumn colStandard;
        private DevExpress.XtraGrid.Columns.GridColumn colLampType;
        private DevExpress.XtraGrid.Columns.GridColumn colClassSafety;
        private DevExpress.XtraGrid.Columns.GridColumn colPhotoPath;
        private DevExpress.XtraGrid.Columns.GridColumn colAngle;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhtien;
        private DevExpress.XtraGrid.Columns.GridColumn colClassProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colTemperature;
        private DevExpress.XtraGrid.Columns.GridColumn colIPRate;
        private DevExpress.XtraGrid.Columns.GridColumn colIKRate;
        private DevExpress.XtraGrid.Columns.GridColumn colControl;
        private DevExpress.XtraGrid.Columns.GridColumn colProfileHousing;
        private DevExpress.XtraGrid.Columns.GridColumn colHousing;
        private DevExpress.XtraGrid.Columns.GridColumn colHead;
        private DevExpress.XtraGrid.Columns.GridColumn colWatt;

        private DevExpress.XtraGrid.Columns.GridColumn colCri;
        private DevExpress.XtraGrid.Columns.GridColumn colInputVoltage;
        private DevExpress.XtraGrid.Columns.GridColumn colDimension;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchOfLed;
        private DevExpress.XtraGrid.Columns.GridColumn colColorHousing;
        private DevExpress.XtraGrid.Columns.GridColumn colEnec;
        private DevExpress.XtraGrid.Columns.GridColumn colPixel;
        public QuotationDetailGrid()
        {
            InitializeComponent();
        }
        private void InitColumn()
        {
            colStt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStt.Caption = "Stt";
            this.colStt.FieldName = "Stt";
            this.colStt.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colStt.Name = "gridColumn13";
            this.colStt.OptionsColumn.AllowEdit = false;
            this.colStt.Visible = true;
            this.colStt.VisibleIndex = 0;
            this.colStt.Width = 50;

            colPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoto.Caption = "Hình ảnh";
            this.colPhoto.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.OptionsColumn.AllowEdit = false;
            this.colPhoto.Visible = true;
            this.colPhoto.VisibleIndex = 1;
            this.colPhoto.Width = 151;

            colPhotoPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhotoPath.Caption = "photoPath";
            this.colPhotoPath.FieldName = "Product.PhotoPath";
            this.colPhotoPath.Name = "colImgPath";

            colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "TotalDescription";
            this.colDescription.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 190;

            colDonvi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonvi.Caption = "Đơn vị";
            this.colDonvi.FieldName = "ProductUnit";
            this.colDonvi.Name = "colDonvi";
            this.colDonvi.OptionsColumn.AllowEdit = false;
            this.colDonvi.Tag = new GridColumnTag("",4,50);
            this.colDonvi.Width = 50;

            colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCode.Caption = "Mã sản phẩm";
            this.colProductCode.FieldName = "Product.ProductCode";
            this.colProductCode.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colProductCode.Name = "gridColumn4";
            this.colProductCode.OptionsColumn.AllowEdit = false;
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 2;
            this.colProductCode.Width = 92;

            colDongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDongia.Caption = "Đơn giá";
            this.colDongia.FieldName = "QuotationPrice";
            this.colDongia.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colDongia.Name = "gridColumn7";
            this.colDongia.Tag = "money";
            this.colDongia.Visible = true;
            this.colDongia.VisibleIndex = 4;
            this.colDongia.Width = 100;

            colSoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoluong.Caption = "Số lượng";
            this.colSoluong.FieldName = "Quantity";
            this.colSoluong.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colSoluong.Name = "gridColumn5";
            this.colSoluong.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colSoluong.Tag = "number";
            this.colSoluong.Visible = true;
            this.colSoluong.VisibleIndex = 5;
            this.colSoluong.Width = 50;

            colThanhtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhtien.Caption = "Thành tiền";
            this.colThanhtien.FieldName = "TotalMoney";
            this.colThanhtien.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colThanhtien.Name = "colThanhtien";
            this.colThanhtien.OptionsColumn.AllowEdit = false;
            this.colThanhtien.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalMoney", "{0:#,###}")});
            this.colThanhtien.Tag = "money";
            this.colThanhtien.Visible = true;
            this.colThanhtien.VisibleIndex = 6;
            this.colThanhtien.Width = 200;

            colStandard = new DevExpress.XtraGrid.Columns.GridColumn();
            colLampType = new DevExpress.XtraGrid.Columns.GridColumn();
            colClassSafety = new DevExpress.XtraGrid.Columns.GridColumn();
            
            colAngle = new DevExpress.XtraGrid.Columns.GridColumn();

            colClassProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            colTemperature = new DevExpress.XtraGrid.Columns.GridColumn();
            colIPRate = new DevExpress.XtraGrid.Columns.GridColumn();
            colIKRate = new DevExpress.XtraGrid.Columns.GridColumn();
            colControl = new DevExpress.XtraGrid.Columns.GridColumn();
            colProfileHousing = new DevExpress.XtraGrid.Columns.GridColumn();
            colHousing = new DevExpress.XtraGrid.Columns.GridColumn();
            colHead = new DevExpress.XtraGrid.Columns.GridColumn();
            colWatt = new DevExpress.XtraGrid.Columns.GridColumn();

            colCri = new DevExpress.XtraGrid.Columns.GridColumn();
            colInputVoltage = new DevExpress.XtraGrid.Columns.GridColumn();
            colDimension = new DevExpress.XtraGrid.Columns.GridColumn();
            colBranchOfLed = new DevExpress.XtraGrid.Columns.GridColumn();
            colColorHousing = new DevExpress.XtraGrid.Columns.GridColumn();
            colEnec = new DevExpress.XtraGrid.Columns.GridColumn();
            colPixel = new DevExpress.XtraGrid.Columns.GridColumn();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
