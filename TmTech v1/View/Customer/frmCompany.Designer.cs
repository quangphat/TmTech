using TmTech_v1.ToolBoxCS;

namespace TmTech_v1.View
{
    sealed partial class FrmCompany
    {
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private ToolBoxCS.LabelNotify lblNotify1;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlDeactiveCompany;
        private ModernUI.Controls.MetroTextBox txtSearch;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label31 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearch = new ModernUI.Controls.MetroTextBox();
            this.pnlDeactiveCompany = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.AutoTextBox5 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.AutoTextBox6 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.AutoTextBox7 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.cbbType = new TmTech_v1.ToolBoxCS.AutoCombobox();
            this.cbbClass = new TmTech_v1.ToolBoxCS.AutoCombobox();
            this.AutoTextBox8 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AutoTextBox9 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AutoTextBox11 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.AutoTextBox12 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.AutoTextBox13 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCompanyName = new TmTech_v1.ToolBoxCS.StatusTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxValidation2 = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxValidation3 = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.lnkSetPass = new System.Windows.Forms.LinkLabel();
            this.AutoTextBox18 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.AutoTextBox15 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.AutoTextBox16 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdNam = new ModernUI.Controls.MaterialRadioButton();
            this.rdNu = new ModernUI.Controls.MaterialRadioButton();
            this.autoTextBox4 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.autoTextBox10 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbbIsMainDeputy = new ModernUI.Controls.MaterialCheckBox();
            this.cbActive = new ModernUI.Controls.MaterialCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbSignature = new TmTech_v1.ToolBoxCS.AutoPictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lnkSignature = new System.Windows.Forms.LinkLabel();
            this.label18 = new System.Windows.Forms.Label();
            this.ptbAvatar = new TmTech_v1.ToolBoxCS.AutoPictureBox();
            this.lnkPhoto = new System.Windows.Forms.LinkLabel();
            this.btnCreateAccount = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteAccount = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveDeputy = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveCompany = new DevExpress.XtraEditors.SimpleButton();
            this.btnApprove = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeactive = new DevExpress.XtraEditors.SimpleButton();
            this.txtCompanyId = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.txtCompanyCode = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.autoTextBox1 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.autoTextBox2 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.autoTextBox3 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.autoTextBox14 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSignature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNotify1
            // 
            this.lblNotify1.AutoSize = true;
            this.lblNotify1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotify1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify1.Location = new System.Drawing.Point(103, 0);
            this.lblNotify1.Name = "lblNotify1";
            this.lblNotify1.Size = new System.Drawing.Size(391, 26);
            this.lblNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.lblNotify1.TabIndex = 107;
            this.lblNotify1.Text = "labelNotify1";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.Location = new System.Drawing.Point(3, 76);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(220, 612);
            this.gridControl2.TabIndex = 125;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompanyName,
            this.gridColumn11,
            this.colStatus});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            this.gridView2.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView2_RowCellStyle);
            // 
            // colCompanyName
            // 
            this.colCompanyName.Caption = "Tên công ty";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 0;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Id";
            this.gridColumn11.FieldName = "CompanyId";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Tag = "primarykey";
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "ApproveStatusId";
            this.colStatus.Name = "colStatus";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 369);
            this.label31.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(44, 13);
            this.label31.TabIndex = 242;
            this.label31.Text = "Kế toán";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 57);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 166;
            this.label15.Text = "Company Code";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 265);
            this.label27.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 13);
            this.label27.TabIndex = 149;
            this.label27.Text = "Class:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 291);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 146;
            this.label10.Text = "No brach:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 239);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 144;
            this.label8.Text = "Type of company:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 143;
            this.label7.Text = "Swift code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 145;
            this.label6.Text = "Bank name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 141;
            this.label5.Text = "Bank account:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 140;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 139;
            this.label3.Text = "Tax code:";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(3, 174);
            this.lbSex.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(28, 13);
            this.lbSex.TabIndex = 135;
            this.lbSex.Text = "Sex:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 123);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 134;
            this.label16.Text = "Phone:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 147);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 133;
            this.label14.Text = "Email:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 43);
            this.label26.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 13);
            this.label26.TabIndex = 132;
            this.label26.Text = "User Account:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 132;
            this.label13.Text = "Name contact:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 142;
            this.label2.Text = "Company Name:";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(229, 497);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1086, 191);
            this.gridControl1.TabIndex = 106;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn12,
            this.gridColumn8,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn4, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Stt";
            this.gridColumn1.FieldName = "Stt";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 50;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên";
            this.gridColumn2.FieldName = "DeputyName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Địa chỉ";
            this.gridColumn3.FieldName = "Address";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số điện thoại";
            this.gridColumn4.FieldName = "Phone";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Skype";
            this.gridColumn6.FieldName = "Skype";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Email";
            this.gridColumn7.FieldName = "Email";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Hoạt động";
            this.gridColumn9.FieldName = "IsActive";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Chính";
            this.gridColumn10.FieldName = "IsMain";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 7;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Ghi chú";
            this.gridColumn12.FieldName = "Note";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 8;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Id";
            this.gridColumn8.FieldName = "DeputyId";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumn5";
            this.gridColumn5.FieldName = "UserId";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.gridControl2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 688);
            this.panel3.TabIndex = 134;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.pnlDeactiveCompany);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 74);
            this.panel4.TabIndex = 132;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = global::TmTech_v1.Properties.Resources.search_50px;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(33, 21);
            this.txtSearch.CustomButton.Style = ModernUI.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = ModernUI.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(3, 17);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search company";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.ShowButton = true;
            this.txtSearch.Size = new System.Drawing.Size(220, 23);
            this.txtSearch.TabIndex = 135;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search company";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.ButtonClick += new ModernUI.Controls.MetroTextBox.ButClick(this.txtSearch_ButtonClick);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // pnlDeactiveCompany
            // 
            this.pnlDeactiveCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(95)))), ((int)(((byte)(115)))));
            this.pnlDeactiveCompany.Location = new System.Drawing.Point(7, 46);
            this.pnlDeactiveCompany.Name = "pnlDeactiveCompany";
            this.pnlDeactiveCompany.Size = new System.Drawing.Size(19, 20);
            this.pnlDeactiveCompany.TabIndex = 130;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 131;
            this.label9.Text = "Deactive Company";
            // 
            // AutoTextBox5
            // 
            this.AutoTextBox5.BindingFor = "Company";
            this.AutoTextBox5.BindingName = "SwiftCode";
            this.AutoTextBox5.ForeColor = System.Drawing.Color.Black;
            this.AutoTextBox5.Location = new System.Drawing.Point(107, 133);
            this.AutoTextBox5.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.AutoTextBox5.Name = "AutoTextBox5";
            this.AutoTextBox5.Size = new System.Drawing.Size(162, 20);
            this.AutoTextBox5.TabIndex = 287;
            // 
            // AutoTextBox6
            // 
            this.AutoTextBox6.BindingFor = "Company";
            this.AutoTextBox6.BindingName = "BankName";
            this.AutoTextBox6.ForeColor = System.Drawing.Color.Black;
            this.AutoTextBox6.Location = new System.Drawing.Point(107, 185);
            this.AutoTextBox6.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.AutoTextBox6.Name = "AutoTextBox6";
            this.AutoTextBox6.Size = new System.Drawing.Size(315, 20);
            this.AutoTextBox6.TabIndex = 288;
            // 
            // AutoTextBox7
            // 
            this.AutoTextBox7.BindingFor = "Company";
            this.AutoTextBox7.BindingName = "BankAccount";
            this.AutoTextBox7.ForeColor = System.Drawing.Color.Black;
            this.AutoTextBox7.Location = new System.Drawing.Point(107, 211);
            this.AutoTextBox7.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.AutoTextBox7.Name = "AutoTextBox7";
            this.AutoTextBox7.Size = new System.Drawing.Size(162, 20);
            this.AutoTextBox7.TabIndex = 289;
            this.AutoTextBox7.TextChanged += new System.EventHandler(this.AutoTextBox7_TextChanged);
            // 
            // cbbType
            // 
            this.cbbType.BindingFor = "Company";
            this.cbbType.BindingName = "TypeId";
            this.cbbType.FormattingEnabled = true;
            this.cbbType.GetSelectedText = false;
            this.cbbType.Location = new System.Drawing.Point(107, 237);
            this.cbbType.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.cbbType.Name = "cbbType";
            this.cbbType.RequireInput = false;
            this.cbbType.Size = new System.Drawing.Size(162, 21);
            this.cbbType.TabIndex = 290;
            // 
            // cbbClass
            // 
            this.cbbClass.BindingFor = "Company";
            this.cbbClass.BindingName = "ClassId";
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.GetSelectedText = false;
            this.cbbClass.Location = new System.Drawing.Point(107, 263);
            this.cbbClass.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.RequireInput = false;
            this.cbbClass.Size = new System.Drawing.Size(162, 21);
            this.cbbClass.TabIndex = 291;
            // 
            // AutoTextBox8
            // 
            this.AutoTextBox8.BindingFor = "Company";
            this.AutoTextBox8.BindingName = "Branch";
            this.AutoTextBox8.ForeColor = System.Drawing.Color.Black;
            this.AutoTextBox8.Location = new System.Drawing.Point(107, 289);
            this.AutoTextBox8.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.AutoTextBox8.Name = "AutoTextBox8";
            this.AutoTextBox8.Size = new System.Drawing.Size(162, 20);
            this.AutoTextBox8.TabIndex = 292;
            this.AutoTextBox8.Tag = "number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 317);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 293;
            this.label11.Text = "No Staff:";
            // 
            // AutoTextBox9
            // 
            this.AutoTextBox9.BindingFor = "Company";
            this.AutoTextBox9.BindingName = "NumberOfEmployee";
            this.AutoTextBox9.ForeColor = System.Drawing.Color.Black;
            this.AutoTextBox9.Location = new System.Drawing.Point(107, 315);
            this.AutoTextBox9.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.AutoTextBox9.Name = "AutoTextBox9";
            this.AutoTextBox9.Size = new System.Drawing.Size(162, 20);
            this.AutoTextBox9.TabIndex = 294;
            this.AutoTextBox9.Tag = "number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 343);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 295;
            this.label12.Text = "Target value:";
            // 
            // AutoTextBox11
            // 
            this.AutoTextBox11.BindingFor = "Company";
            this.AutoTextBox11.BindingName = "Accountant";
            this.AutoTextBox11.ForeColor = System.Drawing.Color.Black;
            this.AutoTextBox11.Location = new System.Drawing.Point(107, 367);
            this.AutoTextBox11.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.AutoTextBox11.Name = "AutoTextBox11";
            this.AutoTextBox11.Size = new System.Drawing.Size(162, 20);
            this.AutoTextBox11.TabIndex = 297;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 395);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 298;
            this.label19.Text = "Số Đt kế toán";
            // 
            // AutoTextBox12
            // 
            this.AutoTextBox12.BindingFor = "Company";
            this.AutoTextBox12.BindingName = "AccountantPhone";
            this.AutoTextBox12.ForeColor = System.Drawing.Color.Black;
            this.AutoTextBox12.Location = new System.Drawing.Point(5, 3);
            this.AutoTextBox12.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.AutoTextBox12.Name = "AutoTextBox12";
            this.AutoTextBox12.Size = new System.Drawing.Size(162, 20);
            this.AutoTextBox12.TabIndex = 299;
            this.AutoTextBox12.Tag = "number";
            // 
            // AutoTextBox13
            // 
            this.AutoTextBox13.BindingFor = "Company";
            this.AutoTextBox13.BindingName = "Website";
            this.AutoTextBox13.ForeColor = System.Drawing.Color.Black;
            this.AutoTextBox13.Location = new System.Drawing.Point(107, 159);
            this.AutoTextBox13.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.AutoTextBox13.Name = "AutoTextBox13";
            this.AutoTextBox13.Size = new System.Drawing.Size(162, 20);
            this.AutoTextBox13.TabIndex = 301;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 161);
            this.label20.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 300;
            this.label20.Text = "Website:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BindingFor = "Company";
            this.txtCompanyName.BindingName = "CompanyName";
            this.txtCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCompanyName.Location = new System.Drawing.Point(107, 29);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(387, 20);
            this.txtCompanyName.StatusFieldName = null;
            this.txtCompanyName.TabIndex = 302;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(500, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 16);
            this.groupBox1.Size = new System.Drawing.Size(591, 417);
            this.groupBox1.TabIndex = 303;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Người liên hệ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label26, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbSex, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBoxValidation2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.AutoTextBox18, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.AutoTextBox15, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.AutoTextBox16, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel5, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 7);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.163324F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.997085F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.87172F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.275362F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.565217F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.64183F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(591, 399);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 293;
            this.label1.Text = "Address:";
            // 
            // textBoxValidation2
            // 
            this.textBoxValidation2.BindingFor = "Users";
            this.textBoxValidation2.BindingName = "FullName";
            this.textBoxValidation2.ForeColor = System.Drawing.Color.Black;
            this.textBoxValidation2.Location = new System.Drawing.Point(105, 12);
            this.textBoxValidation2.Margin = new System.Windows.Forms.Padding(5, 12, 3, 3);
            this.textBoxValidation2.Name = "textBoxValidation2";
            this.textBoxValidation2.Size = new System.Drawing.Size(220, 20);
            this.textBoxValidation2.TabIndex = 296;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.textBoxValidation3);
            this.flowLayoutPanel3.Controls.Add(this.lnkSetPass);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(102, 41);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(486, 50);
            this.flowLayoutPanel3.TabIndex = 297;
            // 
            // textBoxValidation3
            // 
            this.textBoxValidation3.BindingFor = "Users";
            this.textBoxValidation3.BindingName = "UserName";
            this.textBoxValidation3.ForeColor = System.Drawing.Color.Black;
            this.textBoxValidation3.Location = new System.Drawing.Point(3, 3);
            this.textBoxValidation3.Name = "textBoxValidation3";
            this.textBoxValidation3.Size = new System.Drawing.Size(220, 20);
            this.textBoxValidation3.TabIndex = 297;
            // 
            // lnkSetPass
            // 
            this.lnkSetPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkSetPass.AutoSize = true;
            this.lnkSetPass.Location = new System.Drawing.Point(229, 8);
            this.lnkSetPass.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lnkSetPass.Name = "lnkSetPass";
            this.lnkSetPass.Size = new System.Drawing.Size(71, 13);
            this.lnkSetPass.TabIndex = 315;
            this.lnkSetPass.TabStop = true;
            this.lnkSetPass.Text = "Set password";
            this.lnkSetPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSetPass_LinkClicked);
            // 
            // AutoTextBox18
            // 
            this.AutoTextBox18.BindingFor = "Users";
            this.AutoTextBox18.BindingName = "Address";
            this.AutoTextBox18.ForeColor = System.Drawing.Color.Black;
            this.AutoTextBox18.Location = new System.Drawing.Point(105, 97);
            this.AutoTextBox18.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.AutoTextBox18.Name = "AutoTextBox18";
            this.AutoTextBox18.Size = new System.Drawing.Size(220, 20);
            this.AutoTextBox18.TabIndex = 294;
            // 
            // AutoTextBox15
            // 
            this.AutoTextBox15.BindingFor = "Users";
            this.AutoTextBox15.BindingName = "Phone";
            this.AutoTextBox15.ForeColor = System.Drawing.Color.Black;
            this.AutoTextBox15.Location = new System.Drawing.Point(105, 121);
            this.AutoTextBox15.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.AutoTextBox15.Name = "AutoTextBox15";
            this.AutoTextBox15.Size = new System.Drawing.Size(220, 20);
            this.AutoTextBox15.TabIndex = 287;
            // 
            // AutoTextBox16
            // 
            this.AutoTextBox16.BindingFor = "Users";
            this.AutoTextBox16.BindingName = "Email";
            this.AutoTextBox16.ForeColor = System.Drawing.Color.Black;
            this.AutoTextBox16.Location = new System.Drawing.Point(105, 145);
            this.AutoTextBox16.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.AutoTextBox16.Name = "AutoTextBox16";
            this.AutoTextBox16.Size = new System.Drawing.Size(220, 20);
            this.AutoTextBox16.TabIndex = 288;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.rdNam);
            this.flowLayoutPanel4.Controls.Add(this.rdNu);
            this.flowLayoutPanel4.Controls.Add(this.autoTextBox4);
            this.flowLayoutPanel4.Controls.Add(this.autoTextBox10);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(103, 172);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(485, 26);
            this.flowLayoutPanel4.TabIndex = 298;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Depth = 0;
            this.rdNam.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdNam.Location = new System.Drawing.Point(0, 0);
            this.rdNam.Margin = new System.Windows.Forms.Padding(0);
            this.rdNam.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdNam.MouseState = ModernUI.MouseState.HOVER;
            this.rdNam.Name = "rdNam";
            this.rdNam.Ripple = true;
            this.rdNam.Size = new System.Drawing.Size(58, 30);
            this.rdNam.TabIndex = 311;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Depth = 0;
            this.rdNu.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdNu.Location = new System.Drawing.Point(58, 0);
            this.rdNu.Margin = new System.Windows.Forms.Padding(0);
            this.rdNu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdNu.MouseState = ModernUI.MouseState.HOVER;
            this.rdNu.Name = "rdNu";
            this.rdNu.Ripple = true;
            this.rdNu.Size = new System.Drawing.Size(47, 30);
            this.rdNu.TabIndex = 312;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // autoTextBox4
            // 
            this.autoTextBox4.BindingFor = "Deputy";
            this.autoTextBox4.BindingName = "DeputyId";
            this.autoTextBox4.Location = new System.Drawing.Point(108, 3);
            this.autoTextBox4.Name = "autoTextBox4";
            this.autoTextBox4.Size = new System.Drawing.Size(74, 20);
            this.autoTextBox4.TabIndex = 317;
            this.autoTextBox4.Text = "deputyId";
            this.autoTextBox4.Visible = false;
            // 
            // autoTextBox10
            // 
            this.autoTextBox10.BindingFor = "Users";
            this.autoTextBox10.BindingName = "UserId";
            this.autoTextBox10.Location = new System.Drawing.Point(188, 3);
            this.autoTextBox10.Name = "autoTextBox10";
            this.autoTextBox10.Size = new System.Drawing.Size(62, 20);
            this.autoTextBox10.TabIndex = 319;
            this.autoTextBox10.Text = "userId";
            this.autoTextBox10.Visible = false;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.cbbIsMainDeputy);
            this.flowLayoutPanel5.Controls.Add(this.cbActive);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(103, 204);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(485, 27);
            this.flowLayoutPanel5.TabIndex = 299;
            // 
            // cbbIsMainDeputy
            // 
            this.cbbIsMainDeputy.AutoSize = true;
            this.cbbIsMainDeputy.Depth = 0;
            this.cbbIsMainDeputy.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbbIsMainDeputy.Location = new System.Drawing.Point(0, 0);
            this.cbbIsMainDeputy.Margin = new System.Windows.Forms.Padding(0);
            this.cbbIsMainDeputy.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbbIsMainDeputy.MouseState = ModernUI.MouseState.HOVER;
            this.cbbIsMainDeputy.Name = "cbbIsMainDeputy";
            this.cbbIsMainDeputy.Ripple = true;
            this.cbbIsMainDeputy.Size = new System.Drawing.Size(75, 30);
            this.cbbIsMainDeputy.TabIndex = 295;
            this.cbbIsMainDeputy.Text = "Is Main";
            this.cbbIsMainDeputy.UseVisualStyleBackColor = true;
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Depth = 0;
            this.cbActive.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbActive.Location = new System.Drawing.Point(75, 0);
            this.cbActive.Margin = new System.Windows.Forms.Padding(0);
            this.cbActive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbActive.MouseState = ModernUI.MouseState.HOVER;
            this.cbActive.Name = "cbActive";
            this.cbActive.Ripple = true;
            this.cbActive.Size = new System.Drawing.Size(69, 30);
            this.cbActive.TabIndex = 320;
            this.cbActive.Text = "Active";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.ptbSignature);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.lnkSignature);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.ptbAvatar);
            this.panel1.Controls.Add(this.lnkPhoto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 237);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel2.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(585, 159);
            this.panel1.TabIndex = 300;
            // 
            // ptbSignature
            // 
            this.ptbSignature.BindingFor = "Deputy";
            this.ptbSignature.BindingName = "SignaturePhoto";
            this.ptbSignature.Index = 0;
            this.ptbSignature.Location = new System.Drawing.Point(6, 23);
            this.ptbSignature.Name = "ptbSignature";
            this.ptbSignature.PictureName = "";
            this.ptbSignature.PictureOriginPath = "";
            this.ptbSignature.Size = new System.Drawing.Size(147, 107);
            this.ptbSignature.TabIndex = 307;
            this.ptbSignature.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 308;
            this.label17.Text = "Chữ ký";
            // 
            // lnkSignature
            // 
            this.lnkSignature.AutoSize = true;
            this.lnkSignature.Location = new System.Drawing.Point(109, 136);
            this.lnkSignature.Name = "lnkSignature";
            this.lnkSignature.Size = new System.Drawing.Size(44, 13);
            this.lnkSignature.TabIndex = 313;
            this.lnkSignature.TabStop = true;
            this.lnkSignature.Text = "Change";
            this.lnkSignature.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignature_LinkClicked);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(201, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 310;
            this.label18.Text = "Ảnh đại diện";
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.BindingFor = "Deputy";
            this.ptbAvatar.BindingName = "Avatar";
            this.ptbAvatar.Index = 0;
            this.ptbAvatar.Location = new System.Drawing.Point(202, 23);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.PictureName = "";
            this.ptbAvatar.PictureOriginPath = "";
            this.ptbAvatar.Size = new System.Drawing.Size(147, 107);
            this.ptbAvatar.TabIndex = 309;
            this.ptbAvatar.TabStop = false;
            // 
            // lnkPhoto
            // 
            this.lnkPhoto.AutoSize = true;
            this.lnkPhoto.Location = new System.Drawing.Point(305, 138);
            this.lnkPhoto.Name = "lnkPhoto";
            this.lnkPhoto.Size = new System.Drawing.Size(44, 13);
            this.lnkPhoto.TabIndex = 314;
            this.lnkPhoto.TabStop = true;
            this.lnkPhoto.Text = "Change";
            this.lnkPhoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPhoto_LinkClicked);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(101, 3);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(92, 23);
            this.btnCreateAccount.TabIndex = 318;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(199, 3);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(108, 23);
            this.btnDeleteAccount.TabIndex = 292;
            this.btnDeleteAccount.Text = "Delete account";
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnSaveDeputy
            // 
            this.btnSaveDeputy.Location = new System.Drawing.Point(3, 3);
            this.btnSaveDeputy.Name = "btnSaveDeputy";
            this.btnSaveDeputy.Size = new System.Drawing.Size(92, 23);
            this.btnSaveDeputy.TabIndex = 290;
            this.btnSaveDeputy.Text = "Save Account";
            this.btnSaveDeputy.Click += new System.EventHandler(this.btnSaveDeputy_Click);
            // 
            // btnSaveCompany
            // 
            this.btnSaveCompany.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSaveCompany.Location = new System.Drawing.Point(3, 3);
            this.btnSaveCompany.Name = "btnSaveCompany";
            this.btnSaveCompany.Size = new System.Drawing.Size(92, 23);
            this.btnSaveCompany.TabIndex = 304;
            this.btnSaveCompany.Text = "Save Company";
            this.btnSaveCompany.Click += new System.EventHandler(this.btnSaveCompany_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnApprove.Location = new System.Drawing.Point(199, 3);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(116, 23);
            this.btnApprove.TabIndex = 305;
            this.btnApprove.Text = "Approve Company";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnDeactive
            // 
            this.btnDeactive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDeactive.Location = new System.Drawing.Point(321, 3);
            this.btnDeactive.Name = "btnDeactive";
            this.btnDeactive.Size = new System.Drawing.Size(100, 23);
            this.btnDeactive.TabIndex = 306;
            this.btnDeactive.Text = "Deactive company";
            this.btnDeactive.Click += new System.EventHandler(this.btnDeactive_Click);
            // 
            // txtCompanyId
            // 
            this.txtCompanyId.BindingFor = "Company";
            this.txtCompanyId.BindingName = "CompanyId";
            this.txtCompanyId.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyId.Location = new System.Drawing.Point(173, 3);
            this.txtCompanyId.Name = "txtCompanyId";
            this.txtCompanyId.Size = new System.Drawing.Size(51, 20);
            this.txtCompanyId.TabIndex = 311;
            this.txtCompanyId.Text = "companyid";
            this.txtCompanyId.Visible = false;
            // 
            // txtCompanyCode
            // 
            this.txtCompanyCode.BindingFor = "Company";
            this.txtCompanyCode.BindingName = "CompanyCode";
            this.txtCompanyCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCompanyCode.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyCode.Location = new System.Drawing.Point(107, 55);
            this.txtCompanyCode.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.txtCompanyCode.Name = "txtCompanyCode";
            this.txtCompanyCode.Size = new System.Drawing.Size(387, 20);
            this.txtCompanyCode.TabIndex = 312;
            // 
            // autoTextBox1
            // 
            this.autoTextBox1.BindingFor = "Company";
            this.autoTextBox1.BindingName = "Address";
            this.autoTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoTextBox1.Location = new System.Drawing.Point(107, 81);
            this.autoTextBox1.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.autoTextBox1.Name = "autoTextBox1";
            this.autoTextBox1.Size = new System.Drawing.Size(387, 20);
            this.autoTextBox1.TabIndex = 313;
            // 
            // autoTextBox2
            // 
            this.autoTextBox2.BindingFor = "Company";
            this.autoTextBox2.BindingName = "Taxcode";
            this.autoTextBox2.ForeColor = System.Drawing.Color.Black;
            this.autoTextBox2.Location = new System.Drawing.Point(107, 108);
            this.autoTextBox2.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.autoTextBox2.Name = "autoTextBox2";
            this.autoTextBox2.Size = new System.Drawing.Size(162, 20);
            this.autoTextBox2.TabIndex = 314;
            // 
            // autoTextBox3
            // 
            this.autoTextBox3.BindingFor = "Company";
            this.autoTextBox3.BindingName = "TagetValue";
            this.autoTextBox3.ForeColor = System.Drawing.Color.Black;
            this.autoTextBox3.Location = new System.Drawing.Point(107, 341);
            this.autoTextBox3.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.autoTextBox3.Name = "autoTextBox3";
            this.autoTextBox3.Size = new System.Drawing.Size(162, 20);
            this.autoTextBox3.TabIndex = 315;
            this.autoTextBox3.Tag = "money";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCreate.Location = new System.Drawing.Point(101, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(92, 23);
            this.btnCreate.TabIndex = 316;
            this.btnCreate.Text = "Create Company";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // autoTextBox14
            // 
            this.autoTextBox14.BindingFor = "Company";
            this.autoTextBox14.BindingName = "ApproveStatusId";
            this.autoTextBox14.ForeColor = System.Drawing.Color.Black;
            this.autoTextBox14.Location = new System.Drawing.Point(230, 3);
            this.autoTextBox14.Name = "autoTextBox14";
            this.autoTextBox14.Size = new System.Drawing.Size(63, 20);
            this.autoTextBox14.TabIndex = 317;
            this.autoTextBox14.Text = "approveStatus";
            this.autoTextBox14.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.autoTextBox3, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.AutoTextBox11, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNotify1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.autoTextBox2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.autoTextBox1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtCompanyCode, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.AutoTextBox13, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.AutoTextBox9, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.AutoTextBox8, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.cbbClass, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label27, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.cbbType, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.AutoTextBox7, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.AutoTextBox6, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtCompanyName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.label31, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.AutoTextBox5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 15);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(226, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.382979F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.910165F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1094, 423);
            this.tableLayoutPanel1.TabIndex = 318;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.AutoTextBox12);
            this.flowLayoutPanel1.Controls.Add(this.txtCompanyId);
            this.flowLayoutPanel1.Controls.Add(this.autoTextBox14);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(103, 393);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(391, 27);
            this.flowLayoutPanel1.TabIndex = 318;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.90476F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.09524F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel7, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(226, 423);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1094, 68);
            this.tableLayoutPanel3.TabIndex = 319;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.btnSaveCompany);
            this.flowLayoutPanel6.Controls.Add(this.btnCreate);
            this.flowLayoutPanel6.Controls.Add(this.btnApprove);
            this.flowLayoutPanel6.Controls.Add(this.btnDeactive);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.tableLayoutPanel3.SetRowSpan(this.flowLayoutPanel6, 2);
            this.flowLayoutPanel6.Size = new System.Drawing.Size(496, 62);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.btnSaveDeputy);
            this.flowLayoutPanel7.Controls.Add(this.btnCreateAccount);
            this.flowLayoutPanel7.Controls.Add(this.btnDeleteAccount);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(505, 3);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.tableLayoutPanel3.SetRowSpan(this.flowLayoutPanel7, 2);
            this.flowLayoutPanel7.Size = new System.Drawing.Size(586, 62);
            this.flowLayoutPanel7.TabIndex = 1;
            // 
            // FrmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel3);
            this.Name = "FrmCompany";
            this.Size = new System.Drawing.Size(1320, 688);
            this.Load += new System.EventHandler(this.FrmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSignature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


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
        private System.Windows.Forms.Label label31;
        private AutoTextBox AutoTextBox5;
        private AutoTextBox AutoTextBox6;
        private AutoTextBox AutoTextBox7;
        private AutoCombobox cbbType;
        private AutoCombobox cbbClass;
        private AutoTextBox AutoTextBox8;
        private System.Windows.Forms.Label label11;
        private AutoTextBox AutoTextBox9;
        private System.Windows.Forms.Label label12;
        private AutoTextBox AutoTextBox11;
        private System.Windows.Forms.Label label19;
        private AutoTextBox AutoTextBox12;
        private AutoTextBox AutoTextBox13;
        private System.Windows.Forms.Label label20;
        private StatusTextbox txtCompanyName;
        private System.Windows.Forms.GroupBox groupBox1;
        private AutoTextBox AutoTextBox16;
        private AutoTextBox AutoTextBox15;
        private DevExpress.XtraEditors.SimpleButton btnSaveDeputy;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAccount;
        private AutoTextBox AutoTextBox18;
        private System.Windows.Forms.Label label1;
        private ModernUI.Controls.MaterialCheckBox cbbIsMainDeputy;
        private DevExpress.XtraEditors.SimpleButton btnSaveCompany;
        private DevExpress.XtraEditors.SimpleButton btnApprove;
        private DevExpress.XtraEditors.SimpleButton btnDeactive;
        private AutoPictureBox ptbSignature;
        private System.Windows.Forms.Label label17;
        private AutoPictureBox ptbAvatar;
        private System.Windows.Forms.Label label18;
        private AutoTextBox txtCompanyId;
        private TextBoxValidation txtCompanyCode;
        private AutoTextBox autoTextBox1;
        private AutoTextBox autoTextBox2;
        private AutoTextBox autoTextBox3;
        private TextBoxValidation textBoxValidation3;
        private TextBoxValidation textBoxValidation2;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private ModernUI.Controls.MaterialRadioButton rdNu;
        private ModernUI.Controls.MaterialRadioButton rdNam;
        private System.Windows.Forms.LinkLabel lnkPhoto;
        private System.Windows.Forms.LinkLabel lnkSignature;
        private System.Windows.Forms.LinkLabel lnkSetPass;
        private AutoTextBox autoTextBox4;
        private DevExpress.XtraEditors.SimpleButton btnCreateAccount;
        private AutoTextBox autoTextBox10;
        private AutoTextBox autoTextBox14;
        private ModernUI.Controls.MaterialCheckBox cbActive;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
    }
}