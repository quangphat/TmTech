namespace TmTech_v1.View
{
    partial class frmCreateDebt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.autoTextBox1 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDetailId = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.txtNote = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.dtpPaymentDay = new TmTech_v1.ToolBoxCS.AutoXDatetime();
            this.txtThanhtien = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.txtReqCode = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClose = new ModernUI.Controls.BootstrapButton();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.btnPaymentRequest = new DevExpress.XtraEditors.SimpleButton();
            this.txtCompany = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.txtPOCode = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.txtBill = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPaymentDay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPaymentDay.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Công ty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Số hợp đồng/PO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số hóa đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.autoTextBox1);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(0, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 50);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin về bảo hành";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(193, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 13);
            this.label19.TabIndex = 96;
            this.label19.Text = "(%)";
            // 
            // autoTextBox1
            // 
            this.autoTextBox1.BindingFor = "Debt";
            this.autoTextBox1.BindingName = "Po.WarrantyPercent";
            this.autoTextBox1.Location = new System.Drawing.Point(119, 20);
            this.autoTextBox1.Name = "autoTextBox1";
            this.autoTextBox1.ReadOnly = true;
            this.autoTextBox1.Size = new System.Drawing.Size(71, 20);
            this.autoTextBox1.TabIndex = 2;
            this.autoTextBox1.TextChanged += new System.EventHandler(this.autoTextBox1_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(318, 17);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(151, 20);
            this.textBox9.TabIndex = 1;
            this.textBox9.Tag = "money";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(278, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Giá trị";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tỷ lệ bảo hành (%)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDetailId);
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Controls.Add(this.dtpPaymentDay);
            this.groupBox2.Controls.Add(this.txtThanhtien);
            this.groupBox2.Controls.Add(this.txtReqCode);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(0, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 149);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh toán";
            // 
            // txtDetailId
            // 
            this.txtDetailId.BindingFor = "DebtDetail";
            this.txtDetailId.BindingName = "DebtDetailId";
            this.txtDetailId.Location = new System.Drawing.Point(441, 29);
            this.txtDetailId.Name = "txtDetailId";
            this.txtDetailId.Size = new System.Drawing.Size(100, 20);
            this.txtDetailId.TabIndex = 34;
            this.txtDetailId.Visible = false;
            // 
            // txtNote
            // 
            this.txtNote.BindingFor = "DebtDetail";
            this.txtNote.BindingName = "Note";
            this.txtNote.Location = new System.Drawing.Point(132, 93);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(429, 20);
            this.txtNote.TabIndex = 33;
            // 
            // dtpPaymentDay
            // 
            this.dtpPaymentDay.BindingFor = "DebtDetail";
            this.dtpPaymentDay.BindingName = "PaymentDate";
            this.dtpPaymentDay.EditValue = null;
            this.dtpPaymentDay.Location = new System.Drawing.Point(441, 61);
            this.dtpPaymentDay.Name = "dtpPaymentDay";
            this.dtpPaymentDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpPaymentDay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpPaymentDay.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.dtpPaymentDay.Size = new System.Drawing.Size(120, 20);
            this.dtpPaymentDay.TabIndex = 32;
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.BindingFor = "DebtDetail";
            this.txtThanhtien.BindingName = "Payment";
            this.txtThanhtien.Location = new System.Drawing.Point(132, 62);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(200, 20);
            this.txtThanhtien.TabIndex = 31;
            this.txtThanhtien.Tag = "money";
            // 
            // txtReqCode
            // 
            this.txtReqCode.BindingFor = "DebtDetail";
            this.txtReqCode.BindingName = "RequestPaymentCode";
            this.txtReqCode.Location = new System.Drawing.Point(133, 29);
            this.txtReqCode.Name = "txtReqCode";
            this.txtReqCode.Size = new System.Drawing.Size(199, 20);
            this.txtReqCode.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Yêu cầu thanh toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày thanh toán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thành tiền";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.gridControl1);
            this.groupBox3.Location = new System.Drawing.Point(0, 407);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(625, 271);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết thanh toán";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(0, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(625, 251);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn6,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
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
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Payment Request";
            this.gridColumn6.FieldName = "RequestPaymentCode";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 150;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Thành tiền";
            this.gridColumn2.FieldName = "Payment";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Tag = "money";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 184;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày";
            this.gridColumn3.FieldName = "PaymentDate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Tag = "datetime";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 184;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Note";
            this.gridColumn4.FieldName = "Note";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 189;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "DetailId";
            this.gridColumn5.FieldName = "DebtDetailId";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Tag = "primarykey";
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
            this.btnClose.Location = new System.Drawing.Point(542, 25);
            this.btnClose.MouseState = ModernUI.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 36);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnSave.Location = new System.Drawing.Point(479, 25);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPaymentRequest
            // 
            this.btnPaymentRequest.Location = new System.Drawing.Point(479, 141);
            this.btnPaymentRequest.Name = "btnPaymentRequest";
            this.btnPaymentRequest.Size = new System.Drawing.Size(128, 23);
            this.btnPaymentRequest.TabIndex = 41;
            this.btnPaymentRequest.Text = "Gửi yêu cầu thanh toán";
            this.btnPaymentRequest.Click += new System.EventHandler(this.btnPaymentRequest_Click);
            // 
            // txtCompany
            // 
            this.txtCompany.BindingFor = "Debt";
            this.txtCompany.BindingName = "Company.CompanyName";
            this.txtCompany.Location = new System.Drawing.Point(119, 75);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.ReadOnly = true;
            this.txtCompany.Size = new System.Drawing.Size(415, 20);
            this.txtCompany.TabIndex = 44;
            // 
            // txtPOCode
            // 
            this.txtPOCode.BindingFor = "Debt";
            this.txtPOCode.BindingName = "POCode";
            this.txtPOCode.Location = new System.Drawing.Point(119, 108);
            this.txtPOCode.Name = "txtPOCode";
            this.txtPOCode.ReadOnly = true;
            this.txtPOCode.Size = new System.Drawing.Size(200, 20);
            this.txtPOCode.TabIndex = 45;
            // 
            // txtBill
            // 
            this.txtBill.BindingFor = "Debt";
            this.txtBill.BindingName = "Bill";
            this.txtBill.Location = new System.Drawing.Point(119, 144);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(200, 20);
            this.txtBill.TabIndex = 46;
            // 
            // frmCreateDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 684);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.txtPOCode);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.btnPaymentRequest);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateDebt";
            this.Text = "Thêm công nợ";
            this.Load += new System.EventHandler(this.frmCreateDebt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPaymentDay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPaymentDay.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private ModernUI.Controls.BootstrapButton btnClose;
        private ModernUI.Controls.BootstrapButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnPaymentRequest;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private ToolBoxCS.AutoTextBox txtCompany;
        private ToolBoxCS.AutoTextBox txtPOCode;
        private ToolBoxCS.AutoTextBox txtReqCode;
        private ToolBoxCS.AutoTextBox txtThanhtien;
        private ToolBoxCS.AutoTextBox txtBill;
        private ToolBoxCS.AutoXDatetime dtpPaymentDay;
        private ToolBoxCS.AutoTextBox txtNote;
        private ToolBoxCS.AutoTextBox txtDetailId;
        private ToolBoxCS.AutoTextBox autoTextBox1;
        private System.Windows.Forms.Label label19;
    }
}