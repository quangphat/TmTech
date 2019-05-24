namespace TmTech_v1.View
{
    partial class frmPlanning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanning));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDayleft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCreate = new ModernUI.Controls.BootstrapButton();
            this.btnRemove = new ModernUI.Controls.BootstrapButton();
            this.btnEdit = new ModernUI.Controls.BootstrapButton();
            this.btnClose = new ModernUI.Controls.BootstrapButton();
            this.dtpFromdate = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTodate = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.txtSearch = new ModernUI.Controls.MetroTextBox();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTodate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTodate.Properties)).BeginInit();
            this.panelGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(0, 74);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1061, 404);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colDisplayColor,
            this.gridColumn3,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.colDayleft,
            this.gridColumn13,
            this.gridColumn2,
            this.gridColumn5,
            this.gridColumn6,
            this.colStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Stt";
            this.gridColumn1.FieldName = "Stt";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 53;
            // 
            // colDisplayColor
            // 
            this.colDisplayColor.Caption = "Planning code";
            this.colDisplayColor.FieldName = "PlanningCode";
            this.colDisplayColor.Name = "colDisplayColor";
            this.colDisplayColor.Visible = true;
            this.colDisplayColor.VisibleIndex = 1;
            this.colDisplayColor.Width = 120;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "PO code";
            this.gridColumn3.FieldName = "Po.PoCode";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 120;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "PO begin";
            this.gridColumn7.FieldName = "Po.ApproveDate";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Tag = "datetime";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 80;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Saler name";
            this.gridColumn8.FieldName = "Staff.StaffName";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            this.gridColumn8.Width = 107;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Saler code";
            this.gridColumn9.FieldName = "Staff.StaffCode";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            this.gridColumn9.Width = 107;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Phone number";
            this.gridColumn10.FieldName = "Staff.Phone";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 6;
            this.gridColumn10.Width = 80;
            // 
            // colDayleft
            // 
            this.colDayleft.Caption = "Day left";
            this.colDayleft.FieldName = "Dayleft";
            this.colDayleft.Name = "colDayleft";
            this.colDayleft.Visible = true;
            this.colDayleft.VisibleIndex = 7;
            this.colDayleft.Width = 80;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Delivery day";
            this.gridColumn13.FieldName = "DeliveryDate";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Tag = "datetime";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 8;
            this.gridColumn13.Width = 123;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Day make";
            this.gridColumn2.FieldName = "DayMake";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 9;
            this.gridColumn2.Width = 96;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "ProductId";
            this.gridColumn5.FieldName = "PlanningId";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "POId";
            this.gridColumn6.FieldName = "PoId";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // colStatus
            // 
            this.colStatus.Caption = "gridColumn14";
            this.colStatus.FieldName = "StatusId";
            this.colStatus.Name = "colStatus";
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
            this.btnCreate.Location = new System.Drawing.Point(781, 3);
            this.btnCreate.MouseState = ModernUI.MouseState.HOVER;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(71, 36);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            this.btnRemove.Location = new System.Drawing.Point(914, 3);
            this.btnRemove.MouseState = ModernUI.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 36);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(858, 3);
            this.btnEdit.MouseState = ModernUI.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 36);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnClose.Location = new System.Drawing.Point(995, 3);
            this.btnClose.MouseState = ModernUI.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtpFromdate
            // 
            this.dtpFromdate.EditValue = null;
            this.dtpFromdate.Location = new System.Drawing.Point(64, 51);
            this.dtpFromdate.Name = "dtpFromdate";
            this.dtpFromdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFromdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFromdate.Size = new System.Drawing.Size(135, 20);
            this.dtpFromdate.TabIndex = 5;
            this.dtpFromdate.Tag = "from";
            this.dtpFromdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFromdate_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "To:";
            // 
            // dtpTodate
            // 
            this.dtpTodate.EditValue = null;
            this.dtpTodate.Location = new System.Drawing.Point(242, 51);
            this.dtpTodate.Name = "dtpTodate";
            this.dtpTodate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTodate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTodate.Size = new System.Drawing.Size(135, 20);
            this.dtpTodate.TabIndex = 9;
            this.dtpTodate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpTodate_KeyDown);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(383, 49);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(128, 23);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Get data";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lblNotify1
            // 
            this.lblNotify1.AutoSize = true;
            this.lblNotify1.Location = new System.Drawing.Point(517, 54);
            this.lblNotify1.Name = "lblNotify1";
            this.lblNotify1.Size = new System.Drawing.Size(62, 13);
            this.lblNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.lblNotify1.TabIndex = 11;
            this.lblNotify1.Text = "labelNotify1";
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.Controls.Add(this.txtSearch);
            this.panelGrid.Controls.Add(this.gridControl1);
            this.panelGrid.Controls.Add(this.btnClose);
            this.panelGrid.Controls.Add(this.lblNotify1);
            this.panelGrid.Controls.Add(this.btnCreate);
            this.panelGrid.Controls.Add(this.simpleButton1);
            this.panelGrid.Controls.Add(this.btnRemove);
            this.panelGrid.Controls.Add(this.dtpTodate);
            this.panelGrid.Controls.Add(this.btnEdit);
            this.panelGrid.Controls.Add(this.label2);
            this.panelGrid.Controls.Add(this.dtpFromdate);
            this.panelGrid.Controls.Add(this.label1);
            this.panelGrid.Location = new System.Drawing.Point(0, 3);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1061, 489);
            this.panelGrid.TabIndex = 12;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(337, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(33, 21);
            this.txtSearch.CustomButton.Style = ModernUI.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = ModernUI.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(6, 22);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search by code, name";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.ShowButton = true;
            this.txtSearch.Size = new System.Drawing.Size(371, 23);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search by code, name";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.ButtonClick += new ModernUI.Controls.MetroTextBox.ButClick(this.txtSearch_ButtonClick);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // panelDetail
            // 
            this.panelDetail.Location = new System.Drawing.Point(0, 498);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(1064, 13);
            this.panelDetail.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelGrid);
            this.Name = "frmPlanning";
            this.Size = new System.Drawing.Size(1064, 511);
            this.Load += new System.EventHandler(this.frmPlanning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTodate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTodate.Properties)).EndInit();
            this.panelGrid.ResumeLayout(false);
            this.panelGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayColor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn colDayleft;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private ModernUI.Controls.BootstrapButton btnCreate;
        private ModernUI.Controls.BootstrapButton btnRemove;
        private ModernUI.Controls.BootstrapButton btnEdit;
        private ModernUI.Controls.BootstrapButton btnClose;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.DateEdit dtpFromdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dtpTodate;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private ToolBoxCS.LabelNotify lblNotify1;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Timer timer1;
        private ModernUI.Controls.MetroTextBox txtSearch;

    }
}
