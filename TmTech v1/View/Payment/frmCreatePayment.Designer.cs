namespace TmTech_v1.View
{
    partial class frmCreatePayment
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
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cbbStaff = new System.Windows.Forms.ComboBox();
            this.cbbBank = new System.Windows.Forms.ComboBox();
            this.cbbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.dtpPaidDate = new DevExpress.XtraEditors.DateEdit();
            this.txtPaymentName = new System.Windows.Forms.TextBox();
            this.cbbPO = new System.Windows.Forms.ComboBox();
            this.cbbCompany = new System.Windows.Forms.ComboBox();
            this.txtPaymentCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new ModernUI.Controls.BootstrapButton();
            this.btnCreate = new ModernUI.Controls.BootstrapButton();
            this.txtPaid = new TmTech_v1.ToolBoxCS.NumberIntValidation();
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPaidDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPaidDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(157, 209);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(796, 70);
            this.txtNote.TabIndex = 35;
            // 
            // cbbStaff
            // 
            this.cbbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStaff.FormattingEnabled = true;
            this.cbbStaff.Location = new System.Drawing.Point(789, 173);
            this.cbbStaff.Name = "cbbStaff";
            this.cbbStaff.Size = new System.Drawing.Size(164, 21);
            this.cbbStaff.TabIndex = 34;
            // 
            // cbbBank
            // 
            this.cbbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBank.FormattingEnabled = true;
            this.cbbBank.Location = new System.Drawing.Point(478, 170);
            this.cbbBank.Name = "cbbBank";
            this.cbbBank.Size = new System.Drawing.Size(164, 21);
            this.cbbBank.TabIndex = 33;
            // 
            // cbbPaymentMethod
            // 
            this.cbbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPaymentMethod.FormattingEnabled = true;
            this.cbbPaymentMethod.Location = new System.Drawing.Point(157, 173);
            this.cbbPaymentMethod.Name = "cbbPaymentMethod";
            this.cbbPaymentMethod.Size = new System.Drawing.Size(181, 21);
            this.cbbPaymentMethod.TabIndex = 32;
            // 
            // dtpPaidDate
            // 
            this.dtpPaidDate.EditValue = new System.DateTime(2017, 7, 22, 20, 8, 47, 489);
            this.dtpPaidDate.Location = new System.Drawing.Point(789, 135);
            this.dtpPaidDate.Name = "dtpPaidDate";
            this.dtpPaidDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpPaidDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpPaidDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtpPaidDate.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.dtpPaidDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtpPaidDate.Size = new System.Drawing.Size(164, 20);
            this.dtpPaidDate.TabIndex = 31;
            // 
            // txtPaymentName
            // 
            this.txtPaymentName.Location = new System.Drawing.Point(157, 135);
            this.txtPaymentName.Name = "txtPaymentName";
            this.txtPaymentName.Size = new System.Drawing.Size(185, 20);
            this.txtPaymentName.TabIndex = 29;
            // 
            // cbbPO
            // 
            this.cbbPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPO.FormattingEnabled = true;
            this.cbbPO.Location = new System.Drawing.Point(789, 94);
            this.cbbPO.Name = "cbbPO";
            this.cbbPO.Size = new System.Drawing.Size(164, 21);
            this.cbbPO.TabIndex = 28;
            // 
            // cbbCompany
            // 
            this.cbbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCompany.FormattingEnabled = true;
            this.cbbCompany.Location = new System.Drawing.Point(478, 91);
            this.cbbCompany.Name = "cbbCompany";
            this.cbbCompany.Size = new System.Drawing.Size(164, 21);
            this.cbbCompany.TabIndex = 27;
            this.cbbCompany.SelectedIndexChanged += new System.EventHandler(this.cbbCompany_SelectedIndexChanged);
            this.cbbCompany.SelectedValueChanged += new System.EventHandler(this.cbbCompany_SelectedValueChanged);
            // 
            // txtPaymentCode
            // 
            this.txtPaymentCode.Location = new System.Drawing.Point(157, 97);
            this.txtPaymentCode.Name = "txtPaymentCode";
            this.txtPaymentCode.Size = new System.Drawing.Size(185, 20);
            this.txtPaymentCode.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(761, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "PO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Công ti";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Ghi chú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ngân hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Phương thức thanh toán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(673, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nhân viên thanh toán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(697, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ngày thanh toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Số tiền thanh toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên thanh toán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã thanh toán";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(914, 8);
            this.btnCancel.MouseState = ModernUI.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = true;
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Depth = 0;
            this.btnCreate.Icon = null;
            this.btnCreate.Location = new System.Drawing.Point(837, 8);
            this.btnCreate.MouseState = ModernUI.MouseState.HOVER;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(71, 36);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtPaid
            // 
            this.txtPaid.BindingFor = "";
            this.txtPaid.BindingName = null;
            this.txtPaid.ForeColor = System.Drawing.Color.Black;
            this.txtPaid.Location = new System.Drawing.Point(478, 132);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(164, 20);
            this.txtPaid.TabIndex = 30;
            // 
            // labelNotify1
            // 
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(432, 46);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(62, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 15;
            this.labelNotify1.Text = "labelNotify1";
            // 
            // frmCreatePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 394);
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
            this.Controls.Add(this.btnCreate);
            this.Name = "frmCreatePayment";
            this.Text = "Thêm mới thanh toán";
            this.Load += new System.EventHandler(this.frmCreatePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtpPaidDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPaidDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cbbStaff;
        private System.Windows.Forms.ComboBox cbbBank;
        private System.Windows.Forms.ComboBox cbbPaymentMethod;
        private DevExpress.XtraEditors.DateEdit dtpPaidDate;
        private ToolBoxCS.NumberIntValidation txtPaid;
        private System.Windows.Forms.TextBox txtPaymentName;
        private System.Windows.Forms.ComboBox cbbPO;
        private System.Windows.Forms.ComboBox cbbCompany;
        private System.Windows.Forms.TextBox txtPaymentCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ToolBoxCS.LabelNotify labelNotify1;
        private ModernUI.Controls.BootstrapButton btnCancel;
        private ModernUI.Controls.BootstrapButton btnCreate;
    }
}