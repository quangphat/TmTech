namespace TmTech_v1.View
{
    partial class frmPaymentMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentMain));
            this.label1 = new System.Windows.Forms.Label();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn15 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn17 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn16 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn18 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn19 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn9 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn20 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn10 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn11 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn12 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn13 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn14 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn21 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnCreate = new ModernUI.Controls.MetroLink();
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.txtSearch = new ModernUI.Controls.MetroTextBox();
            this.btnReload = new ModernUI.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh toán";
            // 
            // treeList1
            // 
            this.treeList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn15,
            this.treeListColumn17,
            this.treeListColumn16,
            this.treeListColumn5,
            this.treeListColumn6,
            this.treeListColumn18,
            this.treeListColumn7,
            this.treeListColumn8,
            this.treeListColumn19,
            this.treeListColumn9,
            this.treeListColumn20,
            this.treeListColumn10,
            this.treeListColumn11,
            this.treeListColumn12,
            this.treeListColumn13,
            this.treeListColumn14,
            this.treeListColumn21});
            this.treeList1.Location = new System.Drawing.Point(-3, 68);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(1017, 366);
            this.treeList1.TabIndex = 1;
            this.treeList1.DoubleClick += new System.EventHandler(this.treeList1_DoubleClick);
            this.treeList1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeList1_KeyDown);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn1.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn1.Caption = "PaymentId";
            this.treeListColumn1.FieldName = "PaymentId";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn2.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn2.Caption = "PaymentCode";
            this.treeListColumn2.FieldName = "PaymentCode";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.AllowEdit = false;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn3.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn3.Caption = "PaymentName";
            this.treeListColumn3.FieldName = "PaymentName";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.OptionsColumn.AllowEdit = false;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn4.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn4.Caption = "POId";
            this.treeListColumn4.FieldName = "POId";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.OptionsColumn.AllowEdit = false;
            // 
            // treeListColumn15
            // 
            this.treeListColumn15.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn15.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn15.Caption = "Mã PO";
            this.treeListColumn15.FieldName = "Po.PoCode";
            this.treeListColumn15.Name = "treeListColumn15";
            this.treeListColumn15.OptionsColumn.AllowEdit = false;
            this.treeListColumn15.Visible = true;
            this.treeListColumn15.VisibleIndex = 1;
            this.treeListColumn15.Width = 104;
            // 
            // treeListColumn17
            // 
            this.treeListColumn17.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn17.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn17.Caption = "CusId";
            this.treeListColumn17.FieldName = "CusId";
            this.treeListColumn17.Name = "treeListColumn17";
            this.treeListColumn17.OptionsColumn.AllowEdit = false;
            // 
            // treeListColumn16
            // 
            this.treeListColumn16.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn16.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn16.Caption = "Tên công ty";
            this.treeListColumn16.FieldName = "Company.CompanyName";
            this.treeListColumn16.Name = "treeListColumn16";
            this.treeListColumn16.OptionsColumn.AllowEdit = false;
            this.treeListColumn16.Visible = true;
            this.treeListColumn16.VisibleIndex = 0;
            this.treeListColumn16.Width = 130;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn5.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn5.Caption = "Đã trả";
            this.treeListColumn5.FieldName = "Paid";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.OptionsColumn.AllowEdit = false;
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 3;
            this.treeListColumn5.Width = 89;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn6.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn6.Caption = "StaffId";
            this.treeListColumn6.FieldName = "StaffId";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.OptionsColumn.AllowEdit = false;
            // 
            // treeListColumn18
            // 
            this.treeListColumn18.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn18.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn18.Caption = "Nhân viên";
            this.treeListColumn18.FieldName = "Staff.StaffName";
            this.treeListColumn18.Name = "treeListColumn18";
            this.treeListColumn18.OptionsColumn.AllowEdit = false;
            this.treeListColumn18.Visible = true;
            this.treeListColumn18.VisibleIndex = 5;
            this.treeListColumn18.Width = 120;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn7.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn7.Caption = "Ngày trả";
            this.treeListColumn7.FieldName = "PaidDate";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.OptionsColumn.AllowEdit = false;
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 4;
            this.treeListColumn7.Width = 114;
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn8.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn8.Caption = "PaymentMethodId";
            this.treeListColumn8.FieldName = "PaymentMethodId";
            this.treeListColumn8.Name = "treeListColumn8";
            this.treeListColumn8.OptionsColumn.AllowEdit = false;
            // 
            // treeListColumn19
            // 
            this.treeListColumn19.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn19.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn19.Caption = "Phương thức thanh toán";
            this.treeListColumn19.FieldName = "PaymentMethod.Name";
            this.treeListColumn19.Name = "treeListColumn19";
            this.treeListColumn19.OptionsColumn.AllowEdit = false;
            this.treeListColumn19.Visible = true;
            this.treeListColumn19.VisibleIndex = 6;
            this.treeListColumn19.Width = 190;
            // 
            // treeListColumn9
            // 
            this.treeListColumn9.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn9.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn9.Caption = "BankId";
            this.treeListColumn9.FieldName = "BankId";
            this.treeListColumn9.Name = "treeListColumn9";
            this.treeListColumn9.OptionsColumn.AllowEdit = false;
            // 
            // treeListColumn20
            // 
            this.treeListColumn20.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn20.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn20.Caption = "Ngân hàng";
            this.treeListColumn20.FieldName = "Bank.BankName";
            this.treeListColumn20.Name = "treeListColumn20";
            this.treeListColumn20.OptionsColumn.AllowEdit = false;
            this.treeListColumn20.Visible = true;
            this.treeListColumn20.VisibleIndex = 7;
            this.treeListColumn20.Width = 124;
            // 
            // treeListColumn10
            // 
            this.treeListColumn10.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn10.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn10.Caption = "Ghi chú";
            this.treeListColumn10.FieldName = "Note";
            this.treeListColumn10.Name = "treeListColumn10";
            this.treeListColumn10.OptionsColumn.AllowEdit = false;
            this.treeListColumn10.Visible = true;
            this.treeListColumn10.VisibleIndex = 8;
            this.treeListColumn10.Width = 107;
            // 
            // treeListColumn11
            // 
            this.treeListColumn11.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn11.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn11.Caption = "CreateDate";
            this.treeListColumn11.FieldName = "CreateDate";
            this.treeListColumn11.Name = "treeListColumn11";
            this.treeListColumn11.OptionsColumn.AllowEdit = false;
            // 
            // treeListColumn12
            // 
            this.treeListColumn12.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn12.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn12.Caption = "CreateBy";
            this.treeListColumn12.FieldName = "CreateBy";
            this.treeListColumn12.Name = "treeListColumn12";
            this.treeListColumn12.OptionsColumn.AllowEdit = false;
            // 
            // treeListColumn13
            // 
            this.treeListColumn13.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn13.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn13.Caption = "ModifyDate";
            this.treeListColumn13.FieldName = "ModifyDate";
            this.treeListColumn13.Name = "treeListColumn13";
            this.treeListColumn13.OptionsColumn.AllowEdit = false;
            // 
            // treeListColumn14
            // 
            this.treeListColumn14.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn14.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn14.Caption = "ModifyBy";
            this.treeListColumn14.FieldName = "ModifyBy";
            this.treeListColumn14.Name = "treeListColumn14";
            this.treeListColumn14.OptionsColumn.AllowEdit = false;
            // 
            // treeListColumn21
            // 
            this.treeListColumn21.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn21.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn21.Caption = "Tổng giá trị";
            this.treeListColumn21.FieldName = "Po.TotalValue";
            this.treeListColumn21.Name = "treeListColumn21";
            this.treeListColumn21.OptionsColumn.AllowEdit = false;
            this.treeListColumn21.Visible = true;
            this.treeListColumn21.VisibleIndex = 2;
            this.treeListColumn21.Width = 113;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.HighLight = ModernUI.Controls.MetroLink.highlight.Alway;
            this.btnCreate.Image = global::TmTech_v1.Properties.Resources.Add_List_48px;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.ImageSize = 22;
            this.btnCreate.Location = new System.Drawing.Point(948, 39);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(60, 23);
            this.btnCreate.TabIndex = 178;
            this.btnCreate.Text = "Thêm";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // labelNotify1
            // 
            this.labelNotify1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(510, 49);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(62, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 179;
            this.labelNotify1.Text = "labelNotify1";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(33, 21);
            this.txtSearch.CustomButton.Style = ModernUI.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = ModernUI.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(3, 39);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.WaterMark = "Tìm theo mã PO, Công ty";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.ShowButton = true;
            this.txtSearch.Size = new System.Drawing.Size(326, 23);
            this.txtSearch.TabIndex = 180;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Tìm theo mã PO, Công ty";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.ButtonClick += new ModernUI.Controls.MetroTextBox.ButClick(this.txtSearch_ButtonClick);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.HighLight = ModernUI.Controls.MetroLink.highlight.Alway;
            this.btnReload.Image = global::TmTech_v1.Properties.Resources.search_50px;
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.ImageSize = 22;
            this.btnReload.Location = new System.Drawing.Point(848, 39);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(94, 23);
            this.btnReload.TabIndex = 181;
            this.btnReload.Text = "Xem dữ liệu";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.UseSelectable = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // frmPaymentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.labelNotify1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.label1);
            this.Name = "frmPaymentMain";
            this.Size = new System.Drawing.Size(1011, 437);
            this.Load += new System.EventHandler(this.frmPaymentMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn15;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn16;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn9;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn10;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn11;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn12;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn13;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn14;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn17;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn18;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn19;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn20;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn21;
        private ModernUI.Controls.MetroLink btnCreate;
        private ToolBoxCS.LabelNotify labelNotify1;
        private ModernUI.Controls.MetroTextBox txtSearch;
        private ModernUI.Controls.MetroLink btnReload;
    }
}
