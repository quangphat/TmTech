namespace TmTech_v1.View
{
    partial class frmTreeBankUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeBankUpdate));
            this.label1 = new System.Windows.Forms.Label();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn9 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn10 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn11 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn12 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.txtSearch = new ModernUI.Controls.MetroTextBox();
            this.btnCreate = new ModernUI.Controls.MetroLink();
            this.btnReload = new ModernUI.Controls.MetroLink();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCreateBy = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblModifyDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblModifyBy = new System.Windows.Forms.Label();
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách các ngân hàng";
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
            this.treeListColumn5,
            this.treeListColumn6,
            this.treeListColumn7,
            this.treeListColumn8,
            this.treeListColumn9,
            this.treeListColumn10,
            this.treeListColumn11,
            this.treeListColumn12});
            this.treeList1.CustomizationFormBounds = new System.Drawing.Rectangle(781, 362, 216, 209);
            this.treeList1.Location = new System.Drawing.Point(0, 63);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.PopulateServiceColumns = true;
            this.treeList1.Size = new System.Drawing.Size(760, 322);
            this.treeList1.TabIndex = 2;
            this.treeList1.BeforeExpand += new DevExpress.XtraTreeList.BeforeExpandEventHandler(this.treeList1_BeforeExpand);
            this.treeList1.Click += new System.EventHandler(this.treeList1_Click);
            this.treeList1.DoubleClick += new System.EventHandler(this.treeList1_DoubleClick);
            this.treeList1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeList1_KeyDown);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "BankId";
            this.treeListColumn1.FieldName = "BankId";
            this.treeListColumn1.Name = "treeListColumn1";
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "BankCode";
            this.treeListColumn2.FieldName = "BankCode";
            this.treeListColumn2.Name = "treeListColumn2";
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn3.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn3.Caption = "Tên ngân hàng/Chi nhánh";
            this.treeListColumn3.FieldName = "BankName";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.OptionsColumn.AllowEdit = false;
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 0;
            this.treeListColumn3.Width = 201;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn4.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn4.Caption = "Địa chỉ";
            this.treeListColumn4.FieldName = "Address";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.OptionsColumn.AllowEdit = false;
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 1;
            this.treeListColumn4.Width = 109;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn5.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn5.Caption = "Điện thoại";
            this.treeListColumn5.FieldName = "Phone";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.OptionsColumn.AllowEdit = false;
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 2;
            this.treeListColumn5.Width = 126;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn6.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn6.Caption = "Fax";
            this.treeListColumn6.FieldName = "Fax";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.OptionsColumn.AllowEdit = false;
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 3;
            this.treeListColumn6.Width = 95;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn7.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn7.Caption = "Email";
            this.treeListColumn7.FieldName = "Email";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.OptionsColumn.AllowEdit = false;
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 4;
            this.treeListColumn7.Width = 100;
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListColumn8.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn8.Caption = "Ghi chú";
            this.treeListColumn8.FieldName = "Note";
            this.treeListColumn8.Name = "treeListColumn8";
            this.treeListColumn8.OptionsColumn.AllowEdit = false;
            this.treeListColumn8.Visible = true;
            this.treeListColumn8.VisibleIndex = 5;
            this.treeListColumn8.Width = 111;
            // 
            // treeListColumn9
            // 
            this.treeListColumn9.Caption = "CreateDate";
            this.treeListColumn9.FieldName = "CreateDate";
            this.treeListColumn9.Name = "treeListColumn9";
            // 
            // treeListColumn10
            // 
            this.treeListColumn10.Caption = "CreateBy";
            this.treeListColumn10.FieldName = "CreateBy";
            this.treeListColumn10.Name = "treeListColumn10";
            // 
            // treeListColumn11
            // 
            this.treeListColumn11.Caption = "ModifyDate";
            this.treeListColumn11.FieldName = "ModifyDate";
            this.treeListColumn11.Name = "treeListColumn11";
            // 
            // treeListColumn12
            // 
            this.treeListColumn12.Caption = "ModifyBy";
            this.treeListColumn12.FieldName = "ModifyBy";
            this.treeListColumn12.Name = "treeListColumn12";
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
            this.txtSearch.Location = new System.Drawing.Point(8, 34);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.WaterMark = "Tìm theo tên ngân hàng, tên chi nhánh";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.ShowButton = true;
            this.txtSearch.Size = new System.Drawing.Size(257, 23);
            this.txtSearch.TabIndex = 174;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Tìm theo tên ngân hàng, tên chi nhánh";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.ButtonClick += new ModernUI.Controls.MetroTextBox.ButClick(this.txtSearch_ButtonClick);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.HighLight = ModernUI.Controls.MetroLink.highlight.Alway;
            this.btnCreate.Image = global::TmTech_v1.Properties.Resources.Add_List_48px;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.ImageSize = 22;
            this.btnCreate.Location = new System.Drawing.Point(674, 34);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(84, 23);
            this.btnCreate.TabIndex = 176;
            this.btnCreate.Text = "Thêm";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.HighLight = ModernUI.Controls.MetroLink.highlight.Alway;
            this.btnReload.Image = global::TmTech_v1.Properties.Resources.search_50px;
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.ImageSize = 22;
            this.btnReload.Location = new System.Drawing.Point(574, 34);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(94, 23);
            this.btnReload.TabIndex = 177;
            this.btnReload.Text = "Xem dữ liệu";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.UseSelectable = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(151, 430);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 19);
            this.lblUsername.TabIndex = 179;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 178;
            this.label2.Text = "Người dùng:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 178;
            this.label3.Text = "Tạo bởi:";
            // 
            // lblCreateBy
            // 
            this.lblCreateBy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCreateBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateBy.Location = new System.Drawing.Point(612, 400);
            this.lblCreateBy.Name = "lblCreateBy";
            this.lblCreateBy.Size = new System.Drawing.Size(113, 19);
            this.lblCreateBy.TabIndex = 179;
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDate.Location = new System.Drawing.Point(386, 400);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(113, 19);
            this.lblCreateDate.TabIndex = 181;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 180;
            this.label5.Text = "Ngày tạo:";
            // 
            // lblModifyDate
            // 
            this.lblModifyDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblModifyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyDate.Location = new System.Drawing.Point(386, 456);
            this.lblModifyDate.Name = "lblModifyDate";
            this.lblModifyDate.Size = new System.Drawing.Size(113, 19);
            this.lblModifyDate.TabIndex = 183;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 182;
            this.label7.Text = "Ngày thay đổi:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(530, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 182;
            this.label8.Text = "Thay đổi bởi:";
            // 
            // lblModifyBy
            // 
            this.lblModifyBy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblModifyBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyBy.Location = new System.Drawing.Point(612, 456);
            this.lblModifyBy.Name = "lblModifyBy";
            this.lblModifyBy.Size = new System.Drawing.Size(113, 19);
            this.lblModifyBy.TabIndex = 183;
            // 
            // labelNotify1
            // 
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(363, 44);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(62, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 184;
            this.labelNotify1.Text = "labelNotify1";
            // 
            // frmTreeBankUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelNotify1);
            this.Controls.Add(this.lblModifyBy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblModifyDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCreateDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCreateBy);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.label1);
            this.Name = "frmTreeBankUpdate";
            this.Size = new System.Drawing.Size(760, 483);
            this.Load += new System.EventHandler(this.frmTreeBankUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private ModernUI.Controls.MetroTextBox txtSearch;
        private ModernUI.Controls.MetroLink btnCreate;
        private ModernUI.Controls.MetroLink btnReload;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn9;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn10;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn11;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn12;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCreateBy;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblModifyDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblModifyBy;
        private ToolBoxCS.LabelNotify labelNotify1;
    }
}
