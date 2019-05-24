namespace TmTech_v1.View
{
    partial class frmProductDemo
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
            this.cbbCategory = new TmTech_v1.ToolBoxCS.AutoSearchCombobox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbSubCategory = new TmTech_v1.ToolBoxCS.AutoSearchCombobox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSerie = new TmTech_v1.ToolBoxCS.AutoSearchCombobox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInputVol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWatt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPixel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbCategory
            // 
            this.cbbCategory.BindingFor = "Product";
            this.cbbCategory.BindingName = "CategoryId";
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(32, 32);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(213, 21);
            this.cbbCategory.TabIndex = 0;
            this.cbbCategory.SelectionChangeCommitted += new System.EventHandler(this.cbbCategory_SelectionChangeCommitted);
            this.cbbCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbCategory_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhóm con";
            // 
            // cbbSubCategory
            // 
            this.cbbSubCategory.BindingFor = "Product";
            this.cbbSubCategory.BindingName = "SubCategoryId";
            this.cbbSubCategory.FormattingEnabled = true;
            this.cbbSubCategory.Location = new System.Drawing.Point(315, 32);
            this.cbbSubCategory.Name = "cbbSubCategory";
            this.cbbSubCategory.Size = new System.Drawing.Size(213, 21);
            this.cbbSubCategory.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Serie";
            // 
            // cbbSerie
            // 
            this.cbbSerie.BindingFor = "Product";
            this.cbbSerie.BindingName = "SerieId";
            this.cbbSerie.FormattingEnabled = true;
            this.cbbSerie.Location = new System.Drawing.Point(582, 32);
            this.cbbSerie.Name = "cbbSerie";
            this.cbbSerie.Size = new System.Drawing.Size(213, 21);
            this.cbbSerie.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(3, 102);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1133, 192);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colCode,
            this.colName,
            this.colBarcode,
            this.colInputVol,
            this.colWatt,
            this.colPixel,
            this.colPrice,
            this.colModifyDate,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Stt";
            this.gridColumn1.FieldName = "Stt";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 46;
            // 
            // colCode
            // 
            this.colCode.Caption = "Mã";
            this.colCode.FieldName = "ProductCode";
            this.colCode.Name = "colCode";
            this.colCode.OptionsColumn.AllowEdit = false;
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 124;
            // 
            // colName
            // 
            this.colName.Caption = "Tên";
            this.colName.FieldName = "ProductName";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 145;
            // 
            // colBarcode
            // 
            this.colBarcode.Caption = "Mã vạch";
            this.colBarcode.FieldName = "Barcode";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.OptionsColumn.AllowEdit = false;
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 3;
            this.colBarcode.Width = 111;
            // 
            // colInputVol
            // 
            this.colInputVol.Caption = "Input Vol";
            this.colInputVol.FieldName = "InputVoltage";
            this.colInputVol.Name = "colInputVol";
            this.colInputVol.Visible = true;
            this.colInputVol.VisibleIndex = 4;
            this.colInputVol.Width = 55;
            // 
            // colWatt
            // 
            this.colWatt.Caption = "Wat";
            this.colWatt.FieldName = "Watt";
            this.colWatt.Name = "colWatt";
            this.colWatt.Visible = true;
            this.colWatt.VisibleIndex = 5;
            this.colWatt.Width = 53;
            // 
            // colPixel
            // 
            this.colPixel.Caption = "Pixel";
            this.colPixel.FieldName = "Pixel";
            this.colPixel.Name = "colPixel";
            this.colPixel.Visible = true;
            this.colPixel.VisibleIndex = 6;
            this.colPixel.Width = 70;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Giá";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.Tag = "money";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 7;
            this.colPrice.Width = 127;
            // 
            // colModifyDate
            // 
            this.colModifyDate.Caption = "Ngày sửa";
            this.colModifyDate.FieldName = "ModifyDate";
            this.colModifyDate.Name = "colModifyDate";
            this.colModifyDate.OptionsColumn.AllowEdit = false;
            this.colModifyDate.Tag = "datetime";
            this.colModifyDate.Visible = true;
            this.colModifyDate.VisibleIndex = 8;
            this.colModifyDate.Width = 102;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Người sửa";
            this.gridColumn5.FieldName = "ModifyBy";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 9;
            this.gridColumn5.Width = 104;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày tạo";
            this.gridColumn6.FieldName = "CreateDate";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Tag = "datetime";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 10;
            this.gridColumn6.Width = 76;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Người tạo";
            this.gridColumn7.FieldName = "CreateBy";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 11;
            this.gridColumn7.Width = 96;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Id";
            this.gridColumn8.FieldName = "ProductId";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "PriceId";
            this.gridColumn2.FieldName = "PriceId";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // lblNotify1
            // 
            this.lblNotify1.AutoSize = true;
            this.lblNotify1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify1.Location = new System.Drawing.Point(31, 69);
            this.lblNotify1.Name = "lblNotify1";
            this.lblNotify1.Size = new System.Drawing.Size(73, 20);
            this.lblNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.lblNotify1.TabIndex = 166;
            this.lblNotify1.Text = "lblNotify1";
            // 
            // frmProductDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNotify1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbSerie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbSubCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbCategory);
            this.Name = "frmProductDemo";
            this.Size = new System.Drawing.Size(1136, 561);
            this.Load += new System.EventHandler(this.frmProductDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolBoxCS.AutoSearchCombobox cbbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ToolBoxCS.AutoSearchCombobox cbbSubCategory;
        private System.Windows.Forms.Label label3;
        private ToolBoxCS.AutoSearchCombobox cbbSerie;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colInputVol;
        private DevExpress.XtraGrid.Columns.GridColumn colWatt;
        private DevExpress.XtraGrid.Columns.GridColumn colPixel;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private ToolBoxCS.LabelNotify lblNotify1;
    }
}
