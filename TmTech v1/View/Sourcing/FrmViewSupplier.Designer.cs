namespace TmTech_v1.View.Sourcing
{
    partial class FrmViewSupplier
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLookForProduct = new ModernUI.Controls.BootstrapButton();
            this.cbPart = new ModernUI.Controls.MetroSearchComboBox();
            this.cbSeriesPart = new ModernUI.Controls.MetroSearchComboBox();
            this.cbGroupPart = new ModernUI.Controls.MetroSearchComboBox();
            this.cbTypePart = new ModernUI.Controls.MetroSearchComboBox();
            this.cbSupplier = new ModernUI.Controls.MetroSearchComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLookForProduct);
            this.panel1.Controls.Add(this.cbPart);
            this.panel1.Controls.Add(this.cbSeriesPart);
            this.panel1.Controls.Add(this.cbGroupPart);
            this.panel1.Controls.Add(this.cbTypePart);
            this.panel1.Controls.Add(this.cbSupplier);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtToken);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 170);
            this.panel1.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Thông tin nhà cung cấp part";
            // 
            // btnLookForProduct
            // 
            this.btnLookForProduct.AutoSize = true;
            this.btnLookForProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLookForProduct.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Success;
            this.btnLookForProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLookForProduct.Depth = 0;
            this.btnLookForProduct.Icon = null;
            this.btnLookForProduct.Location = new System.Drawing.Point(921, 118);
            this.btnLookForProduct.MouseState = ModernUI.MouseState.HOVER;
            this.btnLookForProduct.Name = "btnLookForProduct";
            this.btnLookForProduct.Size = new System.Drawing.Size(156, 36);
            this.btnLookForProduct.TabIndex = 31;
            this.btnLookForProduct.Text = "Tìm kiếm thông tin";
            this.btnLookForProduct.UseVisualStyleBackColor = true;
            this.btnLookForProduct.Click += new System.EventHandler(this.btnLookForProduct_Click);
            // 
            // cbPart
            // 
            this.cbPart.FormattingEnabled = true;
            this.cbPart.Location = new System.Drawing.Point(618, 97);
            this.cbPart.Name = "cbPart";
            this.cbPart.Size = new System.Drawing.Size(269, 21);
            this.cbPart.TabIndex = 3;
            // 
            // cbSeriesPart
            // 
            this.cbSeriesPart.FormattingEnabled = true;
            this.cbSeriesPart.Location = new System.Drawing.Point(115, 97);
            this.cbSeriesPart.Name = "cbSeriesPart";
            this.cbSeriesPart.Size = new System.Drawing.Size(269, 21);
            this.cbSeriesPart.TabIndex = 3;
            // 
            // cbGroupPart
            // 
            this.cbGroupPart.FormattingEnabled = true;
            this.cbGroupPart.Location = new System.Drawing.Point(116, 66);
            this.cbGroupPart.Name = "cbGroupPart";
            this.cbGroupPart.Size = new System.Drawing.Size(269, 21);
            this.cbGroupPart.TabIndex = 3;
            // 
            // cbTypePart
            // 
            this.cbTypePart.FormattingEnabled = true;
            this.cbTypePart.Location = new System.Drawing.Point(618, 62);
            this.cbTypePart.Name = "cbTypePart";
            this.cbTypePart.Size = new System.Drawing.Size(269, 21);
            this.cbTypePart.TabIndex = 3;
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(618, 35);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(269, 21);
            this.cbSupplier.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(548, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Part:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhóm nguyên liệu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Series part:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại nguyên liệu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ khóa";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(115, 40);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(269, 20);
            this.txtToken.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 170);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1080, 345);
            this.gridControl1.TabIndex = 109;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn11,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn12,
            this.gridColumn10,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn4, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Stt";
            this.gridColumn1.FieldName = "Stt";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 45;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Nhà cung cấp";
            this.gridColumn11.FieldName = "SupplierName";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 89;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Người đại diện";
            this.gridColumn2.FieldName = "SubSupplierName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 78;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Địa chỉ";
            this.gridColumn3.FieldName = "AddressSupplier";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số điện thoại";
            this.gridColumn4.FieldName = "Phone";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 85;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Fax";
            this.gridColumn5.FieldName = "Fax";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 52;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Skype";
            this.gridColumn6.FieldName = "Skype";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 52;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Email";
            this.gridColumn7.FieldName = "Email";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            this.gridColumn7.Width = 52;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Id";
            this.gridColumn8.FieldName = "SupplierId";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Hoạt động";
            this.gridColumn9.FieldName = "StatusSupplier";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            this.gridColumn9.Width = 77;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Ghi chú";
            this.gridColumn12.FieldName = "NOte";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 9;
            this.gridColumn12.Width = 84;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Part Number";
            this.gridColumn10.FieldName = "PartNumber";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 10;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "PartID";
            this.gridColumn13.FieldName = "PartID";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Part Name";
            this.gridColumn14.FieldName = "partName";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 11;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Pricespart";
            this.gridColumn15.FieldName = "Pricespart";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 12;
            // 
            // FrmViewSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmViewSupplier";
            this.Size = new System.Drawing.Size(1080, 515);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToken;
        private ModernUI.Controls.MetroSearchComboBox cbGroupPart;
        private ModernUI.Controls.MetroSearchComboBox cbTypePart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ModernUI.Controls.MetroSearchComboBox cbSeriesPart;
        private ModernUI.Controls.MetroSearchComboBox cbSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private ModernUI.Controls.MetroSearchComboBox cbPart;
        private System.Windows.Forms.Label label8;
        private ModernUI.Controls.BootstrapButton btnLookForProduct;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
     
        private System.Windows.Forms.Label label1;
    }
}