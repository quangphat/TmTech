namespace TmTech_v1.View
{
    partial class frmViewBankUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewBankUpdate));
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridViewBank = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridViewBranchBank = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCreateBranchBank = new ModernUI.Controls.MetroLink();
            this.btnCreateBank = new ModernUI.Controls.MetroLink();
            this.txtSearch = new ModernUI.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBranchBank)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách các ngân hàng";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(0, 122);
            this.gridControl1.MainView = this.gridViewBank;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(228, 495);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBank});
            // 
            // gridViewBank
            // 
            this.gridViewBank.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn16});
            this.gridViewBank.GridControl = this.gridControl1;
            this.gridViewBank.Name = "gridViewBank";
            this.gridViewBank.OptionsView.ShowFooter = true;
            this.gridViewBank.OptionsView.ShowGroupPanel = false;
            this.gridViewBank.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewBank_RowCellClick);
            this.gridViewBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewBank_KeyDown);
            this.gridViewBank.DoubleClick += new System.EventHandler(this.gridViewBank_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên ngân hàng";
            this.gridColumn1.FieldName = "BankName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Bank Id";
            this.gridColumn2.FieldName = "BankId";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Bank code";
            this.gridColumn3.FieldName = "BankCode";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Địa chỉ";
            this.gridColumn4.FieldName = "Address";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Điện thoại";
            this.gridColumn5.FieldName = "Phone";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Fax";
            this.gridColumn6.FieldName = "Fax";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Email";
            this.gridColumn7.FieldName = "Email";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Ghi chú";
            this.gridColumn8.FieldName = "Note";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Số lượng chi nhánh";
            this.gridColumn16.FieldName = "BrankBankNumber";
            this.gridColumn16.Name = "gridColumn16";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.Location = new System.Drawing.Point(216, 122);
            this.gridControl2.MainView = this.gridViewBranchBank;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(600, 495);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBranchBank});
            // 
            // gridViewBranchBank
            // 
            this.gridViewBranchBank.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn17});
            this.gridViewBranchBank.GridControl = this.gridControl2;
            this.gridViewBranchBank.Name = "gridViewBranchBank";
            this.gridViewBranchBank.OptionsView.ShowFooter = true;
            this.gridViewBranchBank.OptionsView.ShowGroupPanel = false;
            this.gridViewBranchBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewBranchBank_KeyDown);
            this.gridViewBranchBank.DoubleClick += new System.EventHandler(this.gridViewBranchBank_DoubleClick);
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "STT";
            this.gridColumn9.FieldName = "Stt";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            this.gridColumn9.Width = 77;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "ID Chi nhánh";
            this.gridColumn10.FieldName = "BrankId";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Tên chi nhánh";
            this.gridColumn11.FieldName = "BrankName";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 142;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Địa chỉ";
            this.gridColumn12.FieldName = "BrankAddress";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 2;
            this.gridColumn12.Width = 162;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Điện thoại";
            this.gridColumn13.FieldName = "Phone";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 3;
            this.gridColumn13.Width = 91;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "ID Ngân hàng";
            this.gridColumn14.FieldName = "BankID";
            this.gridColumn14.Name = "gridColumn14";
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Ghi chú";
            this.gridColumn15.FieldName = "Note";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 4;
            this.gridColumn15.Width = 133;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Thuộc ngân hàng";
            this.gridColumn17.FieldName = "Bank.BankName";
            this.gridColumn17.Name = "gridColumn17";
            // 
            // btnCreateBranchBank
            // 
            this.btnCreateBranchBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateBranchBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateBranchBank.HighLight = ModernUI.Controls.MetroLink.highlight.Alway;
            this.btnCreateBranchBank.Image = global::TmTech_v1.Properties.Resources.Add_List_48px;
            this.btnCreateBranchBank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateBranchBank.ImageSize = 22;
            this.btnCreateBranchBank.Location = new System.Drawing.Point(679, 93);
            this.btnCreateBranchBank.Name = "btnCreateBranchBank";
            this.btnCreateBranchBank.Size = new System.Drawing.Size(134, 23);
            this.btnCreateBranchBank.TabIndex = 17;
            this.btnCreateBranchBank.Text = "Thêm chi nhánh";
            this.btnCreateBranchBank.UseSelectable = true;
            this.btnCreateBranchBank.Click += new System.EventHandler(this.btnCreateBranchBank_Click);
            // 
            // btnCreateBank
            // 
            this.btnCreateBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateBank.HighLight = ModernUI.Controls.MetroLink.highlight.Alway;
            this.btnCreateBank.Image = global::TmTech_v1.Properties.Resources.Add_List_48px;
            this.btnCreateBank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateBank.ImageSize = 22;
            this.btnCreateBank.Location = new System.Drawing.Point(7, 93);
            this.btnCreateBank.Name = "btnCreateBank";
            this.btnCreateBank.Size = new System.Drawing.Size(139, 23);
            this.btnCreateBank.TabIndex = 18;
            this.btnCreateBank.Text = "Thêm ngân hàng";
            this.btnCreateBank.UseSelectable = true;
            this.btnCreateBank.Click += new System.EventHandler(this.btnCreateBank_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(7, 64);
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
            this.txtSearch.TabIndex = 173;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Tìm theo tên ngân hàng, tên chi nhánh";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.ButtonClick += new ModernUI.Controls.MetroTextBox.ButClick(this.txtSearch_ButtonClick);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // frmViewBankUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCreateBank);
            this.Controls.Add(this.btnCreateBranchBank);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.label1);
            this.Name = "frmViewBankUpdate";
            this.Size = new System.Drawing.Size(816, 620);
            this.Load += new System.EventHandler(this.frmViewBankUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBranchBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBank;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBranchBank;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private ModernUI.Controls.MetroLink btnCreateBranchBank;
        private ModernUI.Controls.MetroLink btnCreateBank;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private ModernUI.Controls.MetroTextBox txtSearch;
    }
}
