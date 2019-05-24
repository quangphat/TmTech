namespace TmTech_v1.View
{
    partial class frmEditPlanning
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtPOCode = new System.Windows.Forms.TextBox();
            this.btnClear = new ModernUI.Controls.BootstrapButton();
            this.lblNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.btnClose = new ModernUI.Controls.BootstrapButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlanningCode = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinish = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Location = new System.Drawing.Point(0, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(200, 721);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // txtPOCode
            // 
            this.txtPOCode.Location = new System.Drawing.Point(209, 76);
            this.txtPOCode.Name = "txtPOCode";
            this.txtPOCode.ReadOnly = true;
            this.txtPOCode.Size = new System.Drawing.Size(163, 20);
            this.txtPOCode.TabIndex = 36;
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
            this.btnClear.Location = new System.Drawing.Point(990, 47);
            this.btnClear.MouseState = ModernUI.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 36);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblNotify1
            // 
            this.lblNotify1.AutoSize = true;
            this.lblNotify1.Location = new System.Drawing.Point(560, 220);
            this.lblNotify1.Name = "lblNotify1";
            this.lblNotify1.Size = new System.Drawing.Size(62, 13);
            this.lblNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.lblNotify1.TabIndex = 31;
            this.lblNotify1.Text = "labelNotify1";
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
            this.btnClose.Location = new System.Drawing.Point(1057, 47);
            this.btnClose.MouseState = ModernUI.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 36);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Số lượng sản phẩm";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(206, 220);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.ReadOnly = true;
            this.txtProductQuantity.Size = new System.Drawing.Size(163, 20);
            this.txtProductQuantity.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã planning";
            // 
            // txtPlanningCode
            // 
            this.txtPlanningCode.BindingFor = "";
            this.txtPlanningCode.BindingName = null;
            this.txtPlanningCode.ForeColor = System.Drawing.Color.Black;
            this.txtPlanningCode.Location = new System.Drawing.Point(399, 76);
            this.txtPlanningCode.Name = "txtPlanningCode";
            this.txtPlanningCode.ReadOnly = true;
            this.txtPlanningCode.Size = new System.Drawing.Size(163, 20);
            this.txtPlanningCode.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã PO";
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.Location = new System.Drawing.Point(209, 15);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(189, 23);
            this.btnFinish.TabIndex = 39;
            this.btnFinish.Text = "Finish this planning";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(206, 242);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(914, 484);
            this.gridControl1.TabIndex = 40;
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
            // frmEditPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 726);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.txtPOCode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblNotify1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlanningCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "frmEditPlanning";
            this.Load += new System.EventHandler(this.frmEditPlanning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtPOCode;
        private ModernUI.Controls.BootstrapButton btnClear;
        private ToolBoxCS.LabelNotify lblNotify1;
        private ModernUI.Controls.BootstrapButton btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Label label2;
        private ToolBoxCS.TextBoxValidation txtPlanningCode;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnFinish;
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
    }
}