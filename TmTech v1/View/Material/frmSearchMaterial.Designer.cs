namespace TmTech_v1.View
{
    partial class frmSearchMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchMaterial));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImgPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDesCripTion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCreate = new ModernUI.Controls.BootstrapButton();
            this.btnEdit = new ModernUI.Controls.BootstrapButton();
            this.lblNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.btnRemove = new ModernUI.Controls.BootstrapButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new ModernUI.Controls.BootstrapButton();
            this.dtpTimeTo = new TmTech_v1.ToolBoxCS.AutoXDatetime();
            this.dtpTimeFrom = new TmTech_v1.ToolBoxCS.AutoXDatetime();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSupplier = new TmTech_v1.ToolBoxCS.AutoSearchCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new ModernUI.Controls.MetroTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTimeTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTimeTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTimeFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTimeFrom.Properties)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(835, 275);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn7,
            this.colPhoto,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn8,
            this.gridColumn5,
            this.colImgPath,
            this.gridColumn6,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridDesCripTion});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Stt";
            this.gridColumn1.FieldName = "Stt";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 30;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã";
            this.gridColumn2.FieldName = "MaterialCode";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 122;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tên";
            this.gridColumn7.FieldName = "MaterialName";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 122;
            // 
            // colPhoto
            // 
            this.colPhoto.Caption = "Hình ảnh";
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.OptionsColumn.AllowEdit = false;
            this.colPhoto.Visible = true;
            this.colPhoto.VisibleIndex = 3;
            this.colPhoto.Width = 158;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nhà cung cấp";
            this.gridColumn3.FieldName = "Supplier.SupplierName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 113;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Giá";
            this.gridColumn4.FieldName = "_Price";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Tag = "money";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 113;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "Tồn kho";
            this.gridColumn8.FieldName = "InStock";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 113;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "MaterialId";
            this.gridColumn5.FieldName = "MaterialId";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // colImgPath
            // 
            this.colImgPath.Caption = "Hình ảnh";
            this.colImgPath.FieldName = "PhotoPath";
            this.colImgPath.Name = "colImgPath";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "gridColumn6";
            this.gridColumn6.FieldName = "GroupPartId";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "gridColumn9";
            this.gridColumn9.FieldName = "TypePartId";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "gridColumn10";
            this.gridColumn10.FieldName = "SeriesPartId";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Reflector";
            this.gridColumn11.FieldName = "Reflector";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "gridColumn12";
            this.gridColumn12.FieldName = "UnitId";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "gridColumn13";
            this.gridColumn13.FieldName = "Price";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Group part name";
            this.gridColumn14.FieldName = "GropsupplierMaterial.GroupPartName";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 7;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Type part name";
            this.gridColumn15.FieldName = "TypePartMaterial.TypePartName";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 8;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Series part name";
            this.gridColumn16.FieldName = "SeriesPartName";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 9;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Đơn vị tính";
            this.gridColumn17.FieldName = "UnitMaterial.UnitName";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 10;
            // 
            // gridDesCripTion
            // 
            this.gridDesCripTion.Caption = "Mô tả chi tiết";
            this.gridDesCripTion.FieldName = "DescriptionDetail";
            this.gridDesCripTion.Name = "gridDesCripTion";
            this.gridDesCripTion.Visible = true;
            this.gridDesCripTion.VisibleIndex = 11;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.AutoSize = true;
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Depth = 0;
            this.btnCreate.Icon = null;
            this.btnCreate.Location = new System.Drawing.Point(624, 3);
            this.btnCreate.MouseState = ModernUI.MouseState.HOVER;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(71, 36);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Depth = 0;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(701, 3);
            this.btnEdit.MouseState = ModernUI.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 36);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblNotify1
            // 
            this.lblNotify1.AutoSize = true;
            this.lblNotify1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify1.Location = new System.Drawing.Point(3, 83);
            this.lblNotify1.Name = "lblNotify1";
            this.lblNotify1.Size = new System.Drawing.Size(65, 16);
            this.lblNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.lblNotify1.TabIndex = 4;
            this.lblNotify1.Text = "message";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.AutoSize = true;
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Danger;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Depth = 0;
            this.btnRemove.Icon = null;
            this.btnRemove.Location = new System.Drawing.Point(757, 3);
            this.btnRemove.MouseState = ModernUI.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 36);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(835, 168);
            this.panel5.TabIndex = 195;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nguyên vật liệu";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.labelNotify1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.dtpTimeTo);
            this.panel2.Controls.Add(this.dtpTimeFrom);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbbSupplier);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(32, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 114);
            this.panel2.TabIndex = 0;
            // 
            // labelNotify1
            // 
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(356, 92);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(62, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 222;
            this.labelNotify1.Text = "labelNotify1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 215;
            this.label5.Text = "Ngày kết thúc";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Depth = 0;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(663, 69);
            this.btnSearch.MouseState = ModernUI.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 36);
            this.btnSearch.TabIndex = 204;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchMaterial);
            // 
            // dtpTimeTo
            // 
            this.dtpTimeTo.BindingFor = "";
            this.dtpTimeTo.BindingName = null;
            this.dtpTimeTo.EditValue = null;
            this.dtpTimeTo.Location = new System.Drawing.Point(508, 47);
            this.dtpTimeTo.Name = "dtpTimeTo";
            this.dtpTimeTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTimeTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTimeTo.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.dtpTimeTo.Size = new System.Drawing.Size(236, 20);
            this.dtpTimeTo.TabIndex = 220;
            this.dtpTimeTo.Tag = "datetime";
            // 
            // dtpTimeFrom
            // 
            this.dtpTimeFrom.BindingFor = "";
            this.dtpTimeFrom.BindingName = null;
            this.dtpTimeFrom.EditValue = null;
            this.dtpTimeFrom.Location = new System.Drawing.Point(95, 49);
            this.dtpTimeFrom.Name = "dtpTimeFrom";
            this.dtpTimeFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTimeFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTimeFrom.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.dtpTimeFrom.Size = new System.Drawing.Size(255, 20);
            this.dtpTimeFrom.TabIndex = 221;
            this.dtpTimeFrom.Tag = "datetime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 218;
            this.label4.Text = "Từ khóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 219;
            this.label3.Text = "Nhà cung cấp";
            // 
            // cbbSupplier
            // 
            this.cbbSupplier.BindingFor = "";
            this.cbbSupplier.BindingName = null;
            this.cbbSupplier.FormattingEnabled = true;
            this.cbbSupplier.GetSelectedText = false;
            this.cbbSupplier.Location = new System.Drawing.Point(508, 17);
            this.cbbSupplier.Name = "cbbSupplier";
            this.cbbSupplier.RequireInput = false;
            this.cbbSupplier.Size = new System.Drawing.Size(236, 21);
            this.cbbSupplier.TabIndex = 217;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 216;
            this.label2.Text = "Ngày bắt đầu:";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(33, 21);
            this.txtSearch.CustomButton.Style = ModernUI.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = ModernUI.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(95, 17);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Tìm kiếm theo mã , số vật liệu";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.ShowButton = true;
            this.txtSearch.Size = new System.Drawing.Size(257, 23);
            this.txtSearch.TabIndex = 214;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Tìm kiếm theo mã , số vật liệu";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnRemove);
            this.flowLayoutPanel2.Controls.Add(this.btnEdit);
            this.flowLayoutPanel2.Controls.Add(this.btnCreate);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 168);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(835, 46);
            this.flowLayoutPanel2.TabIndex = 196;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 275);
            this.panel1.TabIndex = 197;
            // 
            // frmSearchMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblNotify1);
            this.Name = "frmSearchMaterial";
            this.Size = new System.Drawing.Size(835, 489);
            this.Load += new System.EventHandler(this.frmMaterialList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTimeTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTimeTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTimeFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTimeFrom.Properties)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colImgPath;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private ModernUI.Controls.BootstrapButton btnCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoto;
        private ModernUI.Controls.BootstrapButton btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private ToolBoxCS.LabelNotify lblNotify1;
        private ModernUI.Controls.BootstrapButton btnRemove;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridDesCripTion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private ModernUI.Controls.BootstrapButton btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private ToolBoxCS.AutoXDatetime dtpTimeTo;
        private ToolBoxCS.AutoXDatetime dtpTimeFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ToolBoxCS.AutoSearchCombobox cbbSupplier;
        private System.Windows.Forms.Label label2;
        private ModernUI.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private ToolBoxCS.LabelNotify labelNotify1;
    }
}