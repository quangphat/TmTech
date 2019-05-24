namespace TmTech_v1.View
{
    partial class frmCreateBranchBankUpdate
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new ModernUI.Controls.BootstrapButton();
            this.btnCreate = new ModernUI.Controls.BootstrapButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBranchPhone = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.txtBranchNote = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtBank = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtBranchAddress = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtBranchName = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Địa chỉ chi nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Thuộc ngân hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên chi nhánh";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(342, 27);
            this.btnCancel.MouseState = ModernUI.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 22;
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
            this.btnCreate.Location = new System.Drawing.Point(281, 27);
            this.btnCreate.MouseState = ModernUI.MouseState.HOVER;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(55, 36);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "Save";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ghi chú";
            // 
            // txtBranchPhone
            // 
            this.txtBranchPhone.BindingFor = "BrankBank";
            this.txtBranchPhone.BindingName = "Phone";
            this.txtBranchPhone.Location = new System.Drawing.Point(40, 161);
            this.txtBranchPhone.Name = "txtBranchPhone";
            this.txtBranchPhone.Size = new System.Drawing.Size(162, 20);
            this.txtBranchPhone.TabIndex = 38;
            // 
            // labelNotify1
            // 
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(167, 65);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(62, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 39;
            this.labelNotify1.Text = "labelNotify1";
            // 
            // txtBranchNote
            // 
            this.txtBranchNote.BindingFor = "BrankBank";
            this.txtBranchNote.BindingName = "Note";
            this.txtBranchNote.Location = new System.Drawing.Point(40, 280);
            this.txtBranchNote.Multiline = true;
            this.txtBranchNote.Name = "txtBranchNote";
            this.txtBranchNote.Size = new System.Drawing.Size(375, 91);
            this.txtBranchNote.TabIndex = 40;
            // 
            // txtBank
            // 
            this.txtBank.BindingFor = "Bank";
            this.txtBank.BindingName = "BankName";
            this.txtBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBank.ForeColor = System.Drawing.Color.Black;
            this.txtBank.Location = new System.Drawing.Point(253, 159);
            this.txtBank.Name = "txtBank";
            this.txtBank.ReadOnly = true;
            this.txtBank.Size = new System.Drawing.Size(162, 22);
            this.txtBank.TabIndex = 37;
            // 
            // txtBranchAddress
            // 
            this.txtBranchAddress.BindingFor = "BrankBank";
            this.txtBranchAddress.BindingName = "BrankAddress";
            this.txtBranchAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchAddress.ForeColor = System.Drawing.Color.Black;
            this.txtBranchAddress.Location = new System.Drawing.Point(40, 220);
            this.txtBranchAddress.Name = "txtBranchAddress";
            this.txtBranchAddress.Size = new System.Drawing.Size(375, 22);
            this.txtBranchAddress.TabIndex = 39;
            // 
            // txtBranchName
            // 
            this.txtBranchName.BindingFor = "BrankBank";
            this.txtBranchName.BindingName = "BrankName";
            this.txtBranchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchName.ForeColor = System.Drawing.Color.Black;
            this.txtBranchName.Location = new System.Drawing.Point(40, 102);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(375, 22);
            this.txtBranchName.TabIndex = 37;
            // 
            // frmCreateBranchBankUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 394);
            this.Controls.Add(this.txtBranchPhone);
            this.Controls.Add(this.labelNotify1);
            this.Controls.Add(this.txtBranchNote);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBranchAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBranchName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Name = "frmCreateBranchBankUpdate";
            this.Resizable = false;
            this.Text = "Thêm chi nhánh";
            this.Load += new System.EventHandler(this.frmCreateBranchBankUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private ToolBoxCS.TextBoxValidation txtBranchAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ToolBoxCS.TextBoxValidation txtBranchName;
        private ModernUI.Controls.BootstrapButton btnCancel;
        private ModernUI.Controls.BootstrapButton btnCreate;
        private System.Windows.Forms.Label label7;
        private ToolBoxCS.TextBoxValidation txtBank;
        private ToolBoxCS.TextBoxValidation txtBranchNote;
        private ToolBoxCS.LabelNotify labelNotify1;
        private ToolBoxCS.TextBoxValidation txtBranchPhone;
    }
}