namespace TmTech_v1.View
{
    partial class frmEditBankUpdate
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBankAddress = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBankPhone = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBankName = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new ModernUI.Controls.BootstrapButton();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.txtCreatedBy = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCreatedDate = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtBankFax = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.txtBankCode = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.txtBankEmail = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.txtBankNote = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ghi chú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Fax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Địa chỉ";
            // 
            // txtBankAddress
            // 
            this.txtBankAddress.BindingFor = "Bank";
            this.txtBankAddress.BindingName = "Address";
            this.txtBankAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankAddress.ForeColor = System.Drawing.Color.Black;
            this.txtBankAddress.Location = new System.Drawing.Point(60, 236);
            this.txtBankAddress.Name = "txtBankAddress";
            this.txtBankAddress.Size = new System.Drawing.Size(162, 22);
            this.txtBankAddress.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Số điện thoại";
            // 
            // txtBankPhone
            // 
            this.txtBankPhone.BindingFor = "Bank";
            this.txtBankPhone.BindingName = "Phone";
            this.txtBankPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankPhone.ForeColor = System.Drawing.Color.Black;
            this.txtBankPhone.Location = new System.Drawing.Point(60, 185);
            this.txtBankPhone.Name = "txtBankPhone";
            this.txtBankPhone.Size = new System.Drawing.Size(162, 22);
            this.txtBankPhone.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên ngân hàng";
            // 
            // txtBankName
            // 
            this.txtBankName.BindingFor = "Bank";
            this.txtBankName.BindingName = "BankName";
            this.txtBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankName.ForeColor = System.Drawing.Color.Black;
            this.txtBankName.Location = new System.Drawing.Point(286, 131);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(162, 22);
            this.txtBankName.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã ngân hàng";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(421, 32);
            this.btnCancel.MouseState = ModernUI.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 22;
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
            this.btnSave.Location = new System.Drawing.Point(360, 32);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BindingFor = "Bank";
            this.txtCreatedBy.BindingName = "CreateBy";
            this.txtCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.txtCreatedBy.Location = new System.Drawing.Point(286, 393);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(162, 22);
            this.txtCreatedBy.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Tạo bởi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Ngày tạo";
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.BindingFor = "Bank";
            this.txtCreatedDate.BindingName = "CreateDate";
            this.txtCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedDate.ForeColor = System.Drawing.Color.Black;
            this.txtCreatedDate.Location = new System.Drawing.Point(60, 393);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.ReadOnly = true;
            this.txtCreatedDate.Size = new System.Drawing.Size(162, 22);
            this.txtCreatedDate.TabIndex = 64;
            // 
            // txtBankFax
            // 
            this.txtBankFax.BindingFor = "Bank";
            this.txtBankFax.BindingName = "Fax";
            this.txtBankFax.Location = new System.Drawing.Point(287, 187);
            this.txtBankFax.Name = "txtBankFax";
            this.txtBankFax.Size = new System.Drawing.Size(162, 20);
            this.txtBankFax.TabIndex = 60;
            // 
            // txtBankCode
            // 
            this.txtBankCode.BindingFor = "Bank";
            this.txtBankCode.BindingName = "BankCode";
            this.txtBankCode.Location = new System.Drawing.Point(60, 133);
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.Size = new System.Drawing.Size(162, 20);
            this.txtBankCode.TabIndex = 57;
            // 
            // txtBankEmail
            // 
            this.txtBankEmail.BindingFor = "Bank";
            this.txtBankEmail.BindingName = "Email";
            this.txtBankEmail.Location = new System.Drawing.Point(287, 238);
            this.txtBankEmail.Name = "txtBankEmail";
            this.txtBankEmail.Size = new System.Drawing.Size(162, 20);
            this.txtBankEmail.TabIndex = 60;
            // 
            // txtBankNote
            // 
            this.txtBankNote.BindingFor = "Bank";
            this.txtBankNote.BindingName = "Note";
            this.txtBankNote.Location = new System.Drawing.Point(60, 287);
            this.txtBankNote.Multiline = true;
            this.txtBankNote.Name = "txtBankNote";
            this.txtBankNote.Size = new System.Drawing.Size(388, 76);
            this.txtBankNote.TabIndex = 63;
            // 
            // labelNotify1
            // 
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(196, 83);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(62, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 66;
            this.labelNotify1.Text = "labelNotify1";
            // 
            // frmEditBankUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 438);
            this.Controls.Add(this.labelNotify1);
            this.Controls.Add(this.txtBankCode);
            this.Controls.Add(this.txtBankEmail);
            this.Controls.Add(this.txtBankFax);
            this.Controls.Add(this.txtBankNote);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCreatedDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBankAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBankPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBankName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "frmEditBankUpdate";
            this.Resizable = false;
            this.Text = "Cập nhật thông tin ngân hàng";
            this.Load += new System.EventHandler(this.frmEditBankUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ToolBoxCS.TextBoxValidation txtBankAddress;
        private System.Windows.Forms.Label label3;
        private ToolBoxCS.TextBoxValidation txtBankPhone;
        private System.Windows.Forms.Label label2;
        private ToolBoxCS.TextBoxValidation txtBankName;
        private System.Windows.Forms.Label label1;
        private ModernUI.Controls.BootstrapButton btnCancel;
        private ModernUI.Controls.BootstrapButton btnSave;
        private ToolBoxCS.TextBoxValidation txtCreatedBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private ToolBoxCS.TextBoxValidation txtCreatedDate;
        private ToolBoxCS.AutoTextBox txtBankFax;
        private ToolBoxCS.AutoTextBox txtBankCode;
        private ToolBoxCS.AutoTextBox txtBankEmail;
        private ToolBoxCS.AutoTextBox txtBankNote;
        private ToolBoxCS.LabelNotify labelNotify1;
    }
}