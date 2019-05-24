namespace TmTech_v1.View
{
    partial class frmImportMaterialDetail
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
            this.btnApprove = new ModernUI.Controls.BootstrapButton();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboStatus = new TmTech_v1.ToolBoxCS.AutoCombobox();
            this.cboStock = new TmTech_v1.ToolBoxCS.AutoCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.ptPhoto = new TmTech_v1.ToolBoxCS.AutoPictureBox();
            this.txtImportCode = new TmTech_v1.ToolBoxCS.StatusTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnClose = new ModernUI.Controls.BootstrapButton();
            this.txtImportId = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbbMaterialCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptPhoto)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaterialCode)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.AutoSize = true;
            this.btnApprove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApprove.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Danger;
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.Depth = 0;
            this.btnApprove.Icon = null;
            this.btnApprove.Location = new System.Drawing.Point(895, 3);
            this.btnApprove.MouseState = ModernUI.MouseState.HOVER;
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(82, 36);
            this.btnApprove.TabIndex = 4;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(834, 3);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1004, 179);
            this.panel3.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNotify1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 124);
            this.panel1.TabIndex = 9;
            // 
            // labelNotify1
            // 
            this.labelNotify1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(391, 108);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(49, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 26;
            this.labelNotify1.Text = "message";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.cboStatus);
            this.panel5.Controls.Add(this.cboStock);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.ptPhoto);
            this.panel5.Controls.Add(this.txtImportCode);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(7, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(968, 99);
            this.panel5.TabIndex = 0;
            // 
            // cboStatus
            // 
            this.cboStatus.BindingFor = "ImportMaterial";
            this.cboStatus.BindingName = "ApproveStatusId";
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.GetSelectedText = false;
            this.cboStatus.Location = new System.Drawing.Point(220, 36);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.RequireInput = false;
            this.cboStatus.Size = new System.Drawing.Size(138, 21);
            this.cboStatus.TabIndex = 25;
            // 
            // cboStock
            // 
            this.cboStock.BindingFor = "ImportMaterial";
            this.cboStock.BindingName = "StockId";
            this.cboStock.FormattingEnabled = true;
            this.cboStock.GetSelectedText = false;
            this.cboStock.Location = new System.Drawing.Point(220, 66);
            this.cboStock.Name = "cboStock";
            this.cboStock.RequireInput = false;
            this.cboStock.Size = new System.Drawing.Size(138, 21);
            this.cboStock.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã phiếu nhập";
            // 
            // ptPhoto
            // 
            this.ptPhoto.BindingFor = "";
            this.ptPhoto.BindingName = null;
            this.ptPhoto.Index = 0;
            this.ptPhoto.Location = new System.Drawing.Point(520, 10);
            this.ptPhoto.Name = "ptPhoto";
            this.ptPhoto.PictureName = "";
            this.ptPhoto.PictureOriginPath = "";
            this.ptPhoto.Size = new System.Drawing.Size(177, 80);
            this.ptPhoto.TabIndex = 18;
            this.ptPhoto.TabStop = false;
            // 
            // txtImportCode
            // 
            this.txtImportCode.BindingFor = "ImportMaterial";
            this.txtImportCode.BindingName = "ImportCode";
            this.txtImportCode.Location = new System.Drawing.Point(220, 10);
            this.txtImportCode.Name = "txtImportCode";
            this.txtImportCode.Size = new System.Drawing.Size(138, 20);
            this.txtImportCode.StatusFieldName = "ApproveStatusId";
            this.txtImportCode.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Hình ảnh vật liệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kho nhập";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.txtImportId);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1004, 55);
            this.panel4.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(280, 55);
            this.panel7.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chi tiết phiếu nhập vật liệu";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnClose);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(919, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(85, 55);
            this.panel6.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Depth = 0;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(19, 8);
            this.btnClose.MouseState = ModernUI.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 36);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtImportId
            // 
            this.txtImportId.BindingFor = "ImportMaterial";
            this.txtImportId.BindingName = "ImportId";
            this.txtImportId.Location = new System.Drawing.Point(420, 8);
            this.txtImportId.Name = "txtImportId";
            this.txtImportId.ReadOnly = true;
            this.txtImportId.Size = new System.Drawing.Size(100, 20);
            this.txtImportId.TabIndex = 9;
            this.txtImportId.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID phiếu nhập";
            this.label5.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl2);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 278);
            this.panel2.TabIndex = 8;
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 38);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbbMaterialCode});
            this.gridControl2.Size = new System.Drawing.Size(1004, 240);
            this.gridControl2.TabIndex = 7;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn15,
            this.gridColumn14,
            this.gridColumn1,
            this.gridColumn6,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumnMoney,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn8,
            this.gridColumn16});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "ImportDetailId";
            this.gridColumn15.FieldName = "ImportDetailId";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Tag = "primarykey";
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "MaterailId";
            this.gridColumn14.FieldName = "MaterialId";
            this.gridColumn14.Name = "gridColumn14";
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
            this.gridColumn1.Width = 70;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn6.Caption = "Mã vật liệu";
            this.gridColumn6.ColumnEdit = this.cbbMaterialCode;
            this.gridColumn6.FieldName = "Material.MaterialCode";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 167;
            // 
            // cbbMaterialCode
            // 
            this.cbbMaterialCode.AutoHeight = false;
            this.cbbMaterialCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMaterialCode.Name = "cbbMaterialCode";
            this.cbbMaterialCode.NullText = "Chọn mã vật liệu";
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
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 177;
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
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 198;
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
            this.gridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumn4.Tag = "number";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            this.gridColumn4.Width = 48;
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
            this.gridColumn5.Tag = "money";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 111;
            // 
            // gridColumnMoney
            // 
            this.gridColumnMoney.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumnMoney.AppearanceHeader.Options.UseFont = true;
            this.gridColumnMoney.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnMoney.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnMoney.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumnMoney.Caption = "Thành tiền";
            this.gridColumnMoney.FieldName = "Thanhtien";
            this.gridColumnMoney.Name = "gridColumnMoney";
            this.gridColumnMoney.OptionsColumn.AllowEdit = false;
            this.gridColumnMoney.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Thanhtien", "DisplayFormat = \'{0:#,###}\', SummaryType = Sum")});
            this.gridColumnMoney.Tag = "money";
            this.gridColumnMoney.Visible = true;
            this.gridColumnMoney.VisibleIndex = 7;
            this.gridColumnMoney.Width = 139;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn9.AppearanceHeader.Options.UseFont = true;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn9.Caption = "Đơn vị tính";
            this.gridColumn9.FieldName = "Material.UnitMaterial.UnitName";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            this.gridColumn9.Width = 71;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "CreateDate";
            this.gridColumn10.FieldName = "CreateDate";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Tag = "datetime";
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "CreateBy";
            this.gridColumn11.FieldName = "CreateBy";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "ModifyDate";
            this.gridColumn12.FieldName = "ModifyDate";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Tag = "datetime";
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "ModifyBy";
            this.gridColumn13.FieldName = "ModifyBy";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Photo";
            this.gridColumn8.FieldName = "Material.Photo";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "PhotoPath";
            this.gridColumn16.FieldName = "Material.PhotoPath";
            this.gridColumn16.Name = "gridColumn16";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.btnApprove);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1004, 38);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(983, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(18, 29);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // frmImportMaterialDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "frmImportMaterialDetail";
            this.Size = new System.Drawing.Size(1004, 457);
            this.Load += new System.EventHandler(this.frmImportMaterialDetail_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptPhoto)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaterialCode)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ModernUI.Controls.BootstrapButton btnApprove;
        private ModernUI.Controls.BootstrapButton btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private ToolBoxCS.AutoTextBox txtImportId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbbMaterialCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMoney;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private ModernUI.Controls.BootstrapButton btnClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private ToolBoxCS.LabelNotify labelNotify1;
        private System.Windows.Forms.Panel panel5;
        private ToolBoxCS.AutoCombobox cboStatus;
        private ToolBoxCS.AutoCombobox cboStock;
        private System.Windows.Forms.Label label2;
        private ToolBoxCS.AutoPictureBox ptPhoto;
        private ToolBoxCS.StatusTextbox txtImportCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
