namespace TmTech_v1.View
{
    partial class frmEditBranchBankUpdate
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBranchPhone = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBranchAddress = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBranchName = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.btnCancel = new ModernUI.Controls.BootstrapButton();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBranchNote = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.txtCreatedDate = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.txtCreatedBy = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.txtBank = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Ghi chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Số điện thoại";
            // 
            // txtBranchPhone
            // 
            this.txtBranchPhone.BindingFor = "BrankBank";
            this.txtBranchPhone.BindingName = "Phone";
            this.txtBranchPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchPhone.ForeColor = System.Drawing.Color.Black;
            this.txtBranchPhone.Location = new System.Drawing.Point(69, 186);
            this.txtBranchPhone.Name = "txtBranchPhone";
            this.txtBranchPhone.Size = new System.Drawing.Size(162, 22);
            this.txtBranchPhone.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Địa chỉ chi nhánh";
            // 
            // txtBranchAddress
            // 
            this.txtBranchAddress.BindingFor = "BrankBank";
            this.txtBranchAddress.BindingName = "BrankAddress";
            this.txtBranchAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchAddress.ForeColor = System.Drawing.Color.Black;
            this.txtBranchAddress.Location = new System.Drawing.Point(69, 237);
            this.txtBranchAddress.Name = "txtBranchAddress";
            this.txtBranchAddress.Size = new System.Drawing.Size(375, 22);
            this.txtBranchAddress.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Thuộc ngân hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tên chi nhánh";
            // 
            // txtBranchName
            // 
            this.txtBranchName.BindingFor = "BrankBank";
            this.txtBranchName.BindingName = "BrankName";
            this.txtBranchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchName.ForeColor = System.Drawing.Color.Black;
            this.txtBranchName.Location = new System.Drawing.Point(69, 134);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(162, 22);
            this.txtBranchName.TabIndex = 40;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(408, 35);
            this.btnCancel.MouseState = ModernUI.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(347, 35);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Tạo bởi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Ngày tạo";
            // 
            // txtBranchNote
            // 
            this.txtBranchNote.BindingFor = "BrankBank";
            this.txtBranchNote.BindingName = "Note";
            this.txtBranchNote.Location = new System.Drawing.Point(69, 290);
            this.txtBranchNote.Multiline = true;
            this.txtBranchNote.Name = "txtBranchNote";
            this.txtBranchNote.Size = new System.Drawing.Size(375, 97);
            this.txtBranchNote.TabIndex = 54;
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.BindingFor = "BrankBank";
            this.txtCreatedDate.BindingName = "CreateDate";
            this.txtCreatedDate.Location = new System.Drawing.Point(69, 420);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.ReadOnly = true;
            this.txtCreatedDate.Size = new System.Drawing.Size(162, 20);
            this.txtCreatedDate.TabIndex = 55;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BindingFor = "BrankBank";
            this.txtCreatedBy.BindingName = "CreateBy";
            this.txtCreatedBy.Location = new System.Drawing.Point(282, 420);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(162, 20);
            this.txtCreatedBy.TabIndex = 56;
            // 
            // txtBank
            // 
            this.txtBank.BindingFor = "BrankBank";
            this.txtBank.BindingName = "Bank.BankName";
            this.txtBank.Location = new System.Drawing.Point(287, 163);
            this.txtBank.Name = "txtBank";
            this.txtBank.ReadOnly = true;
            this.txtBank.Size = new System.Drawing.Size(162, 20);
            this.txtBank.TabIndex = 57;
            // 
            // labelNotify1
            // 
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(206, 90);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(62, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 58;
            this.labelNotify1.Text = "labelNotify1";
            // 
            // frmEditBranchBankUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 463);
            this.Controls.Add(this.labelNotify1);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.txtCreatedDate);
            this.Controls.Add(this.txtBranchNote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBranchPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBranchAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBranchName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "frmEditBranchBankUpdate";
            this.Resizable = false;
            this.Text = "Cập nhật thông tin chi nhánh";
            this.Load += new System.EventHandler(this.frmEditBranchBankUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private ToolBoxCS.TextBoxValidation txtBranchPhone;
        private System.Windows.Forms.Label label3;
        private ToolBoxCS.TextBoxValidation txtBranchAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ToolBoxCS.TextBoxValidation txtBranchName;
        private ModernUI.Controls.BootstrapButton btnCancel;
        private ModernUI.Controls.BootstrapButton btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private ToolBoxCS.AutoTextBox txtBranchNote;
        private ToolBoxCS.AutoTextBox txtCreatedDate;
        private ToolBoxCS.AutoTextBox txtCreatedBy;
        private ToolBoxCS.AutoTextBox txtBank;
        private ToolBoxCS.LabelNotify labelNotify1;
    }
}