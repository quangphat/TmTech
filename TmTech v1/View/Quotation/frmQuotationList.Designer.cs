namespace TmTech_v1.View
{
    partial class frmQuotationList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuotationList));
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndtime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateby = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuotationId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpFromDate = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTodate = new DevExpress.XtraEditors.DateEdit();
            this.btnLoadData = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new ModernUI.Controls.MetroLink();
            this.btnEdit = new ModernUI.Controls.MetroLink();
            this.btnCreate = new ModernUI.Controls.MetroLink();
            this.lblNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.txtSearch = new ModernUI.Controls.MetroTextBox();
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
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách báo giá";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(0, 94);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1043, 423);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colCode,
            this.colCompanyName,
            this.colCompanyPhone,
            this.colProject,
            this.colValue,
            this.colEndtime,
            this.colCreateby,
            this.colCreateDate,
            this.colModifyBy,
            this.colModifyDate,
            this.colQuotationId,
            this.gridColumn2,
            this.colStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
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
            this.gridColumn1.Width = 64;
            // 
            // colCode
            // 
            this.colCode.Caption = "Mã báo giá";
            this.colCode.FieldName = "QuotationCode";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 96;
            // 
            // colCompanyName
            // 
            this.colCompanyName.Caption = "Công ty";
            this.colCompanyName.FieldName = "Company.CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.OptionsColumn.AllowEdit = false;
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 2;
            this.colCompanyName.Width = 150;
            // 
            // colCompanyPhone
            // 
            this.colCompanyPhone.Caption = "Số ĐT";
            this.colCompanyPhone.FieldName = "Company.Phone";
            this.colCompanyPhone.Name = "colCompanyPhone";
            this.colCompanyPhone.OptionsColumn.AllowEdit = false;
            this.colCompanyPhone.Visible = true;
            this.colCompanyPhone.VisibleIndex = 3;
            this.colCompanyPhone.Width = 89;
            // 
            // colProject
            // 
            this.colProject.Caption = "Project";
            this.colProject.FieldName = "ProjectName";
            this.colProject.Name = "colProject";
            this.colProject.OptionsColumn.AllowEdit = false;
            this.colProject.Visible = true;
            this.colProject.VisibleIndex = 4;
            this.colProject.Width = 89;
            // 
            // colValue
            // 
            this.colValue.Caption = "Giá trị";
            this.colValue.FieldName = "TotalValue";
            this.colValue.Name = "colValue";
            this.colValue.OptionsColumn.AllowEdit = false;
            this.colValue.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalValue", "{0:#,###}")});
            this.colValue.Tag = "money";
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 5;
            this.colValue.Width = 89;
            // 
            // colEndtime
            // 
            this.colEndtime.Caption = "End time project";
            this.colEndtime.FieldName = "Endtime";
            this.colEndtime.Name = "colEndtime";
            this.colEndtime.OptionsColumn.AllowEdit = false;
            this.colEndtime.Visible = true;
            this.colEndtime.VisibleIndex = 6;
            this.colEndtime.Width = 89;
            // 
            // colCreateby
            // 
            this.colCreateby.Caption = "Người tạo";
            this.colCreateby.FieldName = "CreateBy";
            this.colCreateby.Name = "colCreateby";
            this.colCreateby.OptionsColumn.AllowEdit = false;
            this.colCreateby.Visible = true;
            this.colCreateby.VisibleIndex = 7;
            this.colCreateby.Width = 89;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "Ngày tạo";
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.OptionsColumn.AllowEdit = false;
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 8;
            this.colCreateDate.Width = 89;
            // 
            // colModifyBy
            // 
            this.colModifyBy.Caption = "Người cập nhật";
            this.colModifyBy.FieldName = "ModifyBy";
            this.colModifyBy.Name = "colModifyBy";
            this.colModifyBy.OptionsColumn.AllowEdit = false;
            this.colModifyBy.Visible = true;
            this.colModifyBy.VisibleIndex = 9;
            this.colModifyBy.Width = 89;
            // 
            // colModifyDate
            // 
            this.colModifyDate.Caption = "Ngày cập nhật";
            this.colModifyDate.FieldName = "ModifyDate";
            this.colModifyDate.Name = "colModifyDate";
            this.colModifyDate.OptionsColumn.AllowEdit = false;
            this.colModifyDate.Visible = true;
            this.colModifyDate.VisibleIndex = 10;
            this.colModifyDate.Width = 92;
            // 
            // colQuotationId
            // 
            this.colQuotationId.Caption = "QuotationId";
            this.colQuotationId.FieldName = "QuotationId";
            this.colQuotationId.Name = "colQuotationId";
            this.colQuotationId.OptionsColumn.AllowEdit = false;
            this.colQuotationId.Tag = "primarykey";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "CusId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "ApproveStatus";
            this.colStatus.FieldName = "ApproveStatusId";
            this.colStatus.Name = "colStatus";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.EditValue = null;
            this.dtpFromDate.Location = new System.Drawing.Point(30, 67);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFromDate.Size = new System.Drawing.Size(124, 20);
            this.dtpFromDate.TabIndex = 2;
            this.dtpFromDate.Tag = "from";
            this.dtpFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFromDate_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đến:";
            // 
            // dtpTodate
            // 
            this.dtpTodate.EditValue = null;
            this.dtpTodate.Location = new System.Drawing.Point(224, 67);
            this.dtpTodate.Name = "dtpTodate";
            this.dtpTodate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTodate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTodate.Size = new System.Drawing.Size(124, 20);
            this.dtpTodate.TabIndex = 4;
            this.dtpTodate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpTodate_KeyDown);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(354, 65);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 6;
            this.btnLoadData.Text = "Lấy dữ liệu";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.HighLight = ModernUI.Controls.MetroLink.highlight.Alway;
            this.btnDelete.Image = global::TmTech_v1.Properties.Resources.Delete_48px;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageSize = 22;
            this.btnDelete.Location = new System.Drawing.Point(978, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 23);
            this.btnDelete.TabIndex = 16;
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
            this.btnEdit.Location = new System.Drawing.Point(912, 31);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 23);
            this.btnEdit.TabIndex = 15;
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
            this.btnCreate.Location = new System.Drawing.Point(818, 31);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(88, 23);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblNotify1
            // 
            this.lblNotify1.AutoSize = true;
            this.lblNotify1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify1.Location = new System.Drawing.Point(496, 38);
            this.lblNotify1.Name = "lblNotify1";
            this.lblNotify1.Size = new System.Drawing.Size(79, 16);
            this.lblNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.lblNotify1.TabIndex = 17;
            this.lblNotify1.Text = "labelNotify1";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(310, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(33, 21);
            this.txtSearch.CustomButton.Style = ModernUI.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = ModernUI.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(6, 31);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Tìm theo mã, tên công ty, project";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.ShowButton = true;
            this.txtSearch.Size = new System.Drawing.Size(344, 23);
            this.txtSearch.TabIndex = 172;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Tìm theo mã, tên công ty, project";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.ButtonClick += new ModernUI.Controls.MetroTextBox.ButClick(this.txtSearch_ButtonClick);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // frmQuotationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblNotify1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTodate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label1);
            this.Name = "frmQuotationList";
            this.Size = new System.Drawing.Size(1046, 520);
            this.Load += new System.EventHandler(this.frmQuotationList_Load);
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
        private DevExpress.XtraEditors.DateEdit dtpFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dtpTodate;
        private DevExpress.XtraEditors.SimpleButton btnLoadData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colProject;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private DevExpress.XtraGrid.Columns.GridColumn colEndtime;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateby;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDate;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotationId;
        private ModernUI.Controls.MetroLink btnDelete;
        private ModernUI.Controls.MetroLink btnEdit;
        private ModernUI.Controls.MetroLink btnCreate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private ToolBoxCS.LabelNotify lblNotify1;
        private ModernUI.Controls.MetroTextBox txtSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
    }
}
