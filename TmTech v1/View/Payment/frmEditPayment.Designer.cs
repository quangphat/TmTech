namespace TmTech_v1.View
{
    partial class frmEditPayment
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
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.btnCancel = new ModernUI.Controls.BootstrapButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPaymentCode = new System.Windows.Forms.TextBox();
            this.cbbCompany = new System.Windows.Forms.ComboBox();
            this.cbbPO = new System.Windows.Forms.ComboBox();
            this.txtPaymentName = new System.Windows.Forms.TextBox();
            this.dtpPaidDate = new DevExpress.XtraEditors.DateEdit();
            this.cbbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.cbbBank = new System.Windows.Forms.ComboBox();
            this.cbbStaff = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtPaid = new TmTech_v1.ToolBoxCS.NumberIntValidation();
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPaidDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPaidDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(855, 7);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(916, 7);
            this.btnCancel.MouseState = ModernUI.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã thanh toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Công ti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(761, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "PO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số tiền thanh toán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(697, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày thanh toán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(673, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nhân viên thanh toán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Phương thức thanh toán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ngân hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ghi chú";
            // 
            // txtPaymentCode
            // 
            this.txtPaymentCode.Location = new System.Drawing.Point(157, 106);
            this.txtPaymentCode.Name = "txtPaymentCode";
            this.txtPaymentCode.ReadOnly = true;
            this.txtPaymentCode.Size = new System.Drawing.Size(185, 20);
            this.txtPaymentCode.TabIndex = 3;
            // 
            // cbbCompany
            // 
            this.cbbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCompany.FormattingEnabled = true;
            this.cbbCompany.Location = new System.Drawing.Point(478, 100);
            this.cbbCompany.Name = "cbbCompany";
            this.cbbCompany.Size = new System.Drawing.Size(164, 21);
            this.cbbCompany.TabIndex = 4;
            this.cbbCompany.SelectedIndexChanged += new System.EventHandler(this.cbbCompany_SelectedIndexChanged);
            // 
            // cbbPO
            // 
            this.cbbPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPO.FormattingEnabled = true;
            this.cbbPO.Location = new System.Drawing.Point(789, 103);
            this.cbbPO.Name = "cbbPO";
            this.cbbPO.Size = new System.Drawing.Size(153, 21);
            this.cbbPO.TabIndex = 5;
            // 
            // txtPaymentName
            // 
            this.txtPaymentName.Location = new System.Drawing.Point(157, 144);
            this.txtPaymentName.Name = "txtPaymentName";
            this.txtPaymentName.Size = new System.Drawing.Size(185, 20);
            this.txtPaymentName.TabIndex = 6;
            // 
            // dtpPaidDate
            // 
            this.dtpPaidDate.EditValue = new System.DateTime(2017, 7, 22, 20, 8, 47, 489);
            this.dtpPaidDate.Location = new System.Drawing.Point(789, 144);
            this.dtpPaidDate.Name = "dtpPaidDate";
            this.dtpPaidDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpPaidDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpPaidDate.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.dtpPaidDate.Size = new System.Drawing.Size(120, 20);
            this.dtpPaidDate.TabIndex = 8;
            // 
            // cbbPaymentMethod
            // 
            this.cbbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPaymentMethod.FormattingEnabled = true;
            this.cbbPaymentMethod.Location = new System.Drawing.Point(157, 182);
            this.cbbPaymentMethod.Name = "cbbPaymentMethod";
            this.cbbPaymentMethod.Size = new System.Drawing.Size(181, 21);
            this.cbbPaymentMethod.TabIndex = 9;
            // 
            // cbbBank
            // 
            this.cbbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBank.FormattingEnabled = true;
            this.cbbBank.Location = new System.Drawing.Point(478, 179);
            this.cbbBank.Name = "cbbBank";
            this.cbbBank.Size = new System.Drawing.Size(164, 21);
            this.cbbBank.TabIndex = 10;
            // 
            // cbbStaff
            // 
            this.cbbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStaff.FormattingEnabled = true;
            this.cbbStaff.Location = new System.Drawing.Point(789, 182);
            this.cbbStaff.Name = "cbbStaff";
            this.cbbStaff.Size = new System.Drawing.Size(153, 21);
            this.cbbStaff.TabIndex = 11;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(157, 218);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(785, 56);
            this.txtNote.TabIndex = 12;
            // 
            // txtPaid
            // 
            this.txtPaid.ForeColor = System.Drawing.Color.Black;
            this.txtPaid.Location = new System.Drawing.Point(478, 141);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(164, 20);
            this.txtPaid.TabIndex = 7;
            // 
            // labelNotify1
            // 
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(410, 45);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(62, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 1;
            this.labelNotify1.Text = "labelNotify1";
            // 
            // frmEditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 289);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cbbStaff);
            this.Controls.Add(this.cbbBank);
            this.Controls.Add(this.cbbPaymentMethod);
            this.Controls.Add(this.dtpPaidDate);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.txtPaymentName);
            this.Controls.Add(this.cbbPO);
            this.Controls.Add(this.cbbCompany);
            this.Controls.Add(this.txtPaymentCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNotify1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "frmEditPayment";
            this.Text = "Cập nhật thanh toán";
            this.Load += new System.EventHandler(this.frmEditPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtpPaidDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPaidDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModernUI.Controls.BootstrapButton btnSave;
        private ModernUI.Controls.BootstrapButton btnCancel;
        private ToolBoxCS.LabelNotify labelNotify1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPaymentCode;
        private System.Windows.Forms.ComboBox cbbCompany;
        private System.Windows.Forms.ComboBox cbbPO;
        private System.Windows.Forms.TextBox txtPaymentName;
        private ToolBoxCS.NumberIntValidation txtPaid;
        private DevExpress.XtraEditors.DateEdit dtpPaidDate;
        private System.Windows.Forms.ComboBox cbbPaymentMethod;
        private System.Windows.Forms.ComboBox cbbBank;
        private System.Windows.Forms.ComboBox cbbStaff;
        private System.Windows.Forms.TextBox txtNote;
    }
}