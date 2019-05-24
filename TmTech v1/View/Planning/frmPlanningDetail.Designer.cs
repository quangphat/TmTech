namespace TmTech_v1.View
{
    partial class frmPlanningDetail
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnFinish = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new ModernUI.Controls.BootstrapButton();
            this.btnClose = new ModernUI.Controls.BootstrapButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonkho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImgPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDisplayColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDayleft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancelPlanning = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Location = new System.Drawing.Point(0, 135);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(200, 398);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(209, 135);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(189, 23);
            this.btnFinish.TabIndex = 46;
            this.btnFinish.Text = "Finish this planning";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Depth = 0;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(1037, 3);
            this.btnClear.MouseState = ModernUI.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 36);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Depth = 0;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(1104, 3);
            this.btnClose.MouseState = ModernUI.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 36);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(206, 234);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(961, 299);
            this.gridControl1.TabIndex = 50;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colPhoto,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.colTonkho,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.colImgPath});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Stt";
            this.gridColumn1.FieldName = "Stt";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 36;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Name";
            this.gridColumn2.FieldName = "MaterialName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 92;
            // 
            // colPhoto
            // 
            this.colPhoto.Caption = "Hình ảnh";
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.OptionsColumn.AllowEdit = false;
            this.colPhoto.Visible = true;
            this.colPhoto.VisibleIndex = 2;
            this.colPhoto.Width = 122;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Part number";
            this.gridColumn4.FieldName = "PartNumber";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 92;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Quality";
            this.gridColumn5.FieldName = "Quality";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 92;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tolerant(%)";
            this.gridColumn6.FieldName = "Tolerant";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 92;
            // 
            // colTonkho
            // 
            this.colTonkho.Caption = "Tồn kho";
            this.colTonkho.FieldName = "InStock";
            this.colTonkho.Name = "colTonkho";
            this.colTonkho.OptionsColumn.AllowEdit = false;
            this.colTonkho.Visible = true;
            this.colTonkho.VisibleIndex = 6;
            this.colTonkho.Width = 92;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Quantity";
            this.gridColumn7.FieldName = "MaterialQuantity";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            this.gridColumn7.Width = 88;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Total Quantity";
            this.gridColumn8.FieldName = "TotalQuantity";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            this.gridColumn8.Width = 90;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "MaterialId";
            this.gridColumn9.FieldName = "MaterialId";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            // 
            // colImgPath
            // 
            this.colImgPath.Caption = "gridColumn3";
            this.colImgPath.FieldName = "PhotoPath";
            this.colImgPath.Name = "colImgPath";
            this.colImgPath.OptionsColumn.AllowEdit = false;
            // 
            // lblNotify1
            // 
            this.lblNotify1.AutoSize = true;
            this.lblNotify1.Location = new System.Drawing.Point(621, 218);
            this.lblNotify1.Name = "lblNotify1";
            this.lblNotify1.Size = new System.Drawing.Size(62, 13);
            this.lblNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.lblNotify1.TabIndex = 49;
            this.lblNotify1.Text = "labelNotify1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Số lượng sản phẩm:";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(313, 208);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.ReadOnly = true;
            this.txtProductQuantity.Size = new System.Drawing.Size(163, 20);
            this.txtProductQuantity.TabIndex = 47;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.Location = new System.Drawing.Point(-14, 45);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1181, 55);
            this.gridControl2.TabIndex = 51;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDisplayColor,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.colDayleft,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.colStatus});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            this.gridView2.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView2_RowCellStyle);
            // 
            // colDisplayColor
            // 
            this.colDisplayColor.Caption = "Planning code";
            this.colDisplayColor.FieldName = "PlanningCode";
            this.colDisplayColor.Name = "colDisplayColor";
            this.colDisplayColor.Visible = true;
            this.colDisplayColor.VisibleIndex = 0;
            this.colDisplayColor.Width = 120;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "PO code";
            this.gridColumn10.FieldName = "Po.PoCode";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 120;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "PO begin";
            this.gridColumn11.FieldName = "Po.ApproveDate";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Tag = "datetime";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            this.gridColumn11.Width = 80;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Saler name";
            this.gridColumn12.FieldName = "Staff.StaffName";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 3;
            this.gridColumn12.Width = 107;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Saler code";
            this.gridColumn13.FieldName = "Staff.StaffCode";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 4;
            this.gridColumn13.Width = 107;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Phone number";
            this.gridColumn14.FieldName = "Staff.Phone";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 5;
            this.gridColumn14.Width = 80;
            // 
            // colDayleft
            // 
            this.colDayleft.Caption = "Day left";
            this.colDayleft.FieldName = "Dayleft";
            this.colDayleft.Name = "colDayleft";
            this.colDayleft.Visible = true;
            this.colDayleft.VisibleIndex = 6;
            this.colDayleft.Width = 80;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Delivery day";
            this.gridColumn15.FieldName = "DeliveryDate";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Tag = "datetime";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 7;
            this.gridColumn15.Width = 123;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Day make";
            this.gridColumn16.FieldName = "DayMake";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 8;
            this.gridColumn16.Width = 96;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "ProductId";
            this.gridColumn17.FieldName = "PlanningId";
            this.gridColumn17.Name = "gridColumn17";
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "POId";
            this.gridColumn18.FieldName = "PoId";
            this.gridColumn18.Name = "gridColumn18";
            // 
            // colStatus
            // 
            this.colStatus.Caption = "gridColumn14";
            this.colStatus.FieldName = "StatusId";
            this.colStatus.Name = "colStatus";
            // 
            // btnCancelPlanning
            // 
            this.btnCancelPlanning.Location = new System.Drawing.Point(404, 135);
            this.btnCancelPlanning.Name = "btnCancelPlanning";
            this.btnCancelPlanning.Size = new System.Drawing.Size(189, 23);
            this.btnCancelPlanning.TabIndex = 52;
            this.btnCancelPlanning.Text = "Cancel this planning";
            this.btnCancelPlanning.Click += new System.EventHandler(this.btnCancelPlanning_Click);
            // 
            // frmPlanningDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCancelPlanning);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lblNotify1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.listView1);
            this.Name = "frmPlanningDetail";
            this.Size = new System.Drawing.Size(1170, 536);
            this.Load += new System.EventHandler(this.frmPlanningDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private DevExpress.XtraEditors.SimpleButton btnFinish;
        private ModernUI.Controls.BootstrapButton btnClear;
        private ModernUI.Controls.BootstrapButton btnClose;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colTonkho;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn colImgPath;
        private ToolBoxCS.LabelNotify lblNotify1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayColor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn colDayleft;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.SimpleButton btnCancelPlanning;
    }
}
