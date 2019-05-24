namespace TmTech_v1.View
{
    partial class frmCreateImportMaterial
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
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChoose = new ModernUI.Controls.BootstrapButton();
            this.pnelnputData = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbStock = new TmTech_v1.ToolBoxCS.AutoSearchCombobox();
            this.txtImportCode = new TmTech_v1.ToolBoxCS.StatusTexboxValdation();
            this.dtpDateCreate = new TmTech_v1.ToolBoxCS.AutoDatetime();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bootstrapButton1 = new ModernUI.Controls.BootstrapButton();
            this.bootstrapButton2 = new ModernUI.Controls.BootstrapButton();
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnelnputData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1028, 291);
            this.gridControl2.TabIndex = 4;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn6,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "Stt";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 59;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "ImportDetailId";
            this.gridColumn8.FieldName = "ImportDetailId";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "MaterialId";
            this.gridColumn9.FieldName = "Material.MaterialCode";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.Caption = "Mã vật liệu";
            this.gridColumn6.FieldName = "Material.MaterialCode";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Width = 163;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.Caption = "Tên vật liệu";
            this.gridColumn2.FieldName = "Material.MaterialName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 171;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.Caption = "Nhà cung cấp";
            this.gridColumn3.FieldName = "Material.Supplier.SupplierName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 161;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.Caption = "Số lượng";
            this.gridColumn4.FieldName = "Quantity";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 176;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.Caption = "Đơn giá";
            this.gridColumn5.FieldName = "Price";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 173;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.Caption = "Thành tiền";
            this.gridColumn7.FieldName = "Thanhtien";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 150;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnChoose);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 166);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1028, 38);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // btnChoose
            // 
            this.btnChoose.AutoSize = true;
            this.btnChoose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChoose.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoose.Depth = 0;
            this.btnChoose.Icon = null;
            this.btnChoose.Location = new System.Drawing.Point(3, 3);
            this.btnChoose.MouseState = ModernUI.MouseState.HOVER;
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(120, 36);
            this.btnChoose.TabIndex = 5;
            this.btnChoose.Text = "Chọn vật liệu";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // pnelnputData
            // 
            this.pnelnputData.Controls.Add(this.panel1);
            this.pnelnputData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnelnputData.Location = new System.Drawing.Point(20, 109);
            this.pnelnputData.Name = "pnelnputData";
            this.pnelnputData.Size = new System.Drawing.Size(1028, 57);
            this.pnelnputData.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.cbbStock);
            this.panel1.Controls.Add(this.dtpDateCreate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(45, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 41);
            this.panel1.TabIndex = 0;
            // 
            // cbbStock
            // 
            this.cbbStock.BindingFor = "ImportMaterial";
            this.cbbStock.BindingName = "StockId";
            this.cbbStock.FormattingEnabled = true;
            this.cbbStock.GetSelectedText = false;
            this.cbbStock.Location = new System.Drawing.Point(417, 10);
            this.cbbStock.Name = "cbbStock";
            this.cbbStock.RequireInput = false;
            this.cbbStock.Size = new System.Drawing.Size(151, 21);
            this.cbbStock.TabIndex = 8;
            // 
            // txtImportCode
            // 
            this.txtImportCode.BindingFor = "ImportMaterial";
            this.txtImportCode.BindingName = "ImportCode";
            this.txtImportCode.Location = new System.Drawing.Point(262, 12);
            this.txtImportCode.Name = "txtImportCode";
            this.txtImportCode.Size = new System.Drawing.Size(128, 20);
            this.txtImportCode.TabIndex = 6;
            this.txtImportCode.Visible = false;
            // 
            // dtpDateCreate
            // 
            this.dtpDateCreate.BindingFor = "ImportMaterial";
            this.dtpDateCreate.BindingName = "CreateDate";
            this.dtpDateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateCreate.Location = new System.Drawing.Point(115, 10);
            this.dtpDateCreate.MaxDate = new System.DateTime(2017, 9, 17, 0, 0, 0, 0);
            this.dtpDateCreate.MinDate = new System.DateTime(2009, 12, 25, 0, 0, 0, 0);
            this.dtpDateCreate.Name = "dtpDateCreate";
            this.dtpDateCreate.Size = new System.Drawing.Size(128, 20);
            this.dtpDateCreate.TabIndex = 7;
            this.dtpDateCreate.Value = new System.DateTime(2017, 8, 27, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã phiếu nhập kho";
            this.label1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kho được nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày nhập kho";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.txtImportCode);
            this.panel2.Controls.Add(this.labelNotify1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 49);
            this.panel2.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.bootstrapButton1);
            this.flowLayoutPanel2.Controls.Add(this.bootstrapButton2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(856, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(172, 49);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // bootstrapButton1
            // 
            this.bootstrapButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bootstrapButton1.AutoSize = true;
            this.bootstrapButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bootstrapButton1.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.bootstrapButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapButton1.Depth = 0;
            this.bootstrapButton1.Icon = null;
            this.bootstrapButton1.Location = new System.Drawing.Point(3, 3);
            this.bootstrapButton1.MouseState = ModernUI.MouseState.HOVER;
            this.bootstrapButton1.Name = "bootstrapButton1";
            this.bootstrapButton1.Size = new System.Drawing.Size(71, 36);
            this.bootstrapButton1.TabIndex = 8;
            this.bootstrapButton1.Text = "Create";
            this.bootstrapButton1.UseVisualStyleBackColor = true;
            this.bootstrapButton1.Click += new System.EventHandler(this.AddImportMaterial);
            // 
            // bootstrapButton2
            // 
            this.bootstrapButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bootstrapButton2.AutoSize = true;
            this.bootstrapButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bootstrapButton2.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.bootstrapButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapButton2.Depth = 0;
            this.bootstrapButton2.Icon = null;
            this.bootstrapButton2.Location = new System.Drawing.Point(80, 3);
            this.bootstrapButton2.MouseState = ModernUI.MouseState.HOVER;
            this.bootstrapButton2.Name = "bootstrapButton2";
            this.bootstrapButton2.Size = new System.Drawing.Size(73, 36);
            this.bootstrapButton2.TabIndex = 9;
            this.bootstrapButton2.Text = "Cancel";
            this.bootstrapButton2.UseVisualStyleBackColor = true;
            this.bootstrapButton2.Click += new System.EventHandler(this.bootstrapButton2_Click);
            // 
            // labelNotify1
            // 
            this.labelNotify1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(445, 30);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(0, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControl2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(20, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1028, 291);
            this.panel3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 24);
            this.label3.TabIndex = 194;
            this.label3.Text = "Tạo mới phiếu nhập";
            // 
            // frmCreateImportMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnelnputData);
            this.Controls.Add(this.panel2);
            this.Name = "frmCreateImportMaterial";
            this.Load += new System.EventHandler(this.frmCreateImportMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pnelnputData.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ModernUI.Controls.BootstrapButton btnChoose;
        private System.Windows.Forms.Panel pnelnputData;
        private System.Windows.Forms.Panel panel1;
        private ToolBoxCS.AutoSearchCombobox cbbStock;
        private ToolBoxCS.StatusTexboxValdation txtImportCode;
        private ToolBoxCS.AutoDatetime dtpDateCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private ToolBoxCS.LabelNotify labelNotify1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private ModernUI.Controls.BootstrapButton bootstrapButton1;
        private ModernUI.Controls.BootstrapButton bootstrapButton2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}