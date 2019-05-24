namespace TmTech_v1.View
{
    partial class frmPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPO));
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPoCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new ModernUI.Controls.MetroLink();
            this.btnEdit = new ModernUI.Controls.MetroLink();
            this.btnCreate = new ModernUI.Controls.MetroLink();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDate = new DevExpress.XtraEditors.DateEdit();
            this.dtpTodate = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new ModernUI.Controls.MetroTextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTodate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTodate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách đơn đặt hàng";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(-8, 91);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(977, 401);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colPoCode,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn11,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn12,
            this.gridColumn13,
            this.colStatus,
            this.gridColumn2,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
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
            this.gridColumn1.Width = 72;
            // 
            // colPoCode
            // 
            this.colPoCode.Caption = "Mã";
            this.colPoCode.FieldName = "PoCode";
            this.colPoCode.Name = "colPoCode";
            this.colPoCode.Visible = true;
            this.colPoCode.VisibleIndex = 1;
            this.colPoCode.Width = 109;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Công ty";
            this.gridColumn3.FieldName = "Company.CompanyName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 150;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số lượng";
            this.gridColumn4.FieldName = "Quantity";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumn4.Tag = "number";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 103;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Thành tiền";
            this.gridColumn5.FieldName = "TotalValue";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalValue", "{0:#,###}")});
            this.gridColumn5.Tag = "money";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 103;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Delivery date";
            this.gridColumn11.FieldName = "DeliveryTime";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 5;
            this.gridColumn11.Width = 103;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Ngày xác nhận";
            this.gridColumn14.FieldName = "ApproveDate";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 6;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Người xác nhận";
            this.gridColumn15.FieldName = "ApproveBy";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 7;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày tạo";
            this.gridColumn6.FieldName = "CreateDate";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 8;
            this.gridColumn6.Width = 103;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Người tạo";
            this.gridColumn7.FieldName = "CreateBy";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 9;
            this.gridColumn7.Width = 103;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Ngày sửa";
            this.gridColumn8.FieldName = "ModifyDate";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 10;
            this.gridColumn8.Width = 103;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Người sửa";
            this.gridColumn9.FieldName = "ModifyBy";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 11;
            this.gridColumn9.Width = 105;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Id";
            this.gridColumn10.FieldName = "PoId";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Tag = "primarykey";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "QuotationCode";
            this.gridColumn12.FieldName = "QuotationCode";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "CompanyId";
            this.gridColumn13.FieldName = "CompanyId";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Approve";
            this.colStatus.FieldName = "ApproveStatusId";
            this.colStatus.Name = "colStatus";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "WarrantyPercent";
            this.gridColumn2.FieldName = "WarrantyPercent";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "poBegin";
            this.gridColumn16.FieldName = "PoBegin";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 12;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "projectName";
            this.gridColumn17.FieldName = "Quotation.ProjectName";
            this.gridColumn17.Name = "gridColumn17";
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "ProjectAddress";
            this.gridColumn18.FieldName = "Quotation.ProjectAddress";
            this.gridColumn18.Name = "gridColumn18";
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "ProjectValue";
            this.gridColumn19.FieldName = "Quotation.ProjectValue";
            this.gridColumn19.Name = "gridColumn19";
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "CreateDebt";
            this.gridColumn20.FieldName = "CreateDebt";
            this.gridColumn20.Name = "gridColumn20";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.HighLight = ModernUI.Controls.MetroLink.highlight.Alway;
            this.btnDelete.Image = global::TmTech_v1.Properties.Resources.Delete_48px;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageSize = 22;
            this.btnDelete.Location = new System.Drawing.Point(899, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.HighLight = ModernUI.Controls.MetroLink.highlight.Alway;
            this.btnEdit.Image = global::TmTech_v1.Properties.Resources.Edit_48px;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.ImageSize = 22;
            this.btnEdit.Location = new System.Drawing.Point(833, 30);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.HighLight = ModernUI.Controls.MetroLink.highlight.Alway;
            this.btnCreate.Image = global::TmTech_v1.Properties.Resources.Add_List_48px;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.ImageSize = 22;
            this.btnCreate.Location = new System.Drawing.Point(739, 30);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(88, 23);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Từ:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.EditValue = null;
            this.dtpFromDate.Location = new System.Drawing.Point(36, 64);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dtpFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFromDate.Size = new System.Drawing.Size(134, 20);
            this.dtpFromDate.TabIndex = 15;
            this.dtpFromDate.Tag = "from";
            this.dtpFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFromDate_KeyDown);
            // 
            // dtpTodate
            // 
            this.dtpTodate.EditValue = null;
            this.dtpTodate.Location = new System.Drawing.Point(239, 65);
            this.dtpTodate.Name = "dtpTodate";
            this.dtpTodate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dtpTodate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTodate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTodate.Size = new System.Drawing.Size(134, 20);
            this.dtpTodate.TabIndex = 17;
            this.dtpTodate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpTodate_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Đến:";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(332, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(33, 21);
            this.txtSearch.CustomButton.Style = ModernUI.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = ModernUI.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(6, 36);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search by code, name,company";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.ShowButton = true;
            this.txtSearch.Size = new System.Drawing.Size(366, 23);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search by code, name,company";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.ButtonClick += new ModernUI.Controls.MetroTextBox.ButClick(this.txtSearch_ButtonClick);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton1.Location = new System.Drawing.Point(390, 62);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "Lọc";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelNotify1
            // 
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotify1.Location = new System.Drawing.Point(471, 68);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(74, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 22;
            this.labelNotify1.Text = "labelNotify1";
            // 
            // frmPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelNotify1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtpTodate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label1);
            this.Name = "frmPO";
            this.Size = new System.Drawing.Size(972, 495);
            this.Load += new System.EventHandler(this.frmPO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTodate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTodate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ModernUI.Controls.MetroLink btnDelete;
        private ModernUI.Controls.MetroLink btnEdit;
        private ModernUI.Controls.MetroLink btnCreate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colPoCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dtpFromDate;
        private DevExpress.XtraEditors.DateEdit dtpTodate;
        private System.Windows.Forms.Label label3;
        private ModernUI.Controls.MetroTextBox txtSearch;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private ToolBoxCS.LabelNotify labelNotify1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
    }
}
