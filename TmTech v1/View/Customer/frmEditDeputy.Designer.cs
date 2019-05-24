namespace TmTech_v1.View
{
    partial class frmEditDeputy
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
            this.btnCancel = new ModernUI.Controls.BootstrapButton();
            this.btnClearAll = new ModernUI.Controls.BootstrapButton();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSex = new ModernUI.Controls.MetroSearchComboBox();
            this.txtDiaChi = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtNameContact = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSkype = new System.Windows.Forms.TextBox();
            this.lbnote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkIsActive = new System.Windows.Forms.CheckBox();
            this.txtEmail = new TmTech_v1.ToolBoxCS.TextboxEmail();
            this.label21 = new System.Windows.Forms.Label();
            this.txtAccount = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.cbMain = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Danger;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(360, 22);
            this.btnCancel.MouseState = ModernUI.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 122;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.AutoSize = true;
            this.btnClearAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearAll.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAll.Depth = 0;
            this.btnClearAll.Icon = null;
            this.btnClearAll.Location = new System.Drawing.Point(263, 22);
            this.btnClearAll.MouseState = ModernUI.MouseState.HOVER;
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(90, 36);
            this.btnClearAll.TabIndex = 121;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
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
            this.btnSave.Location = new System.Drawing.Point(202, 22);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 120;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 33);
            this.label4.TabIndex = 173;
            this.label4.Text = "Sửa khách hàng đại diện";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbSex.Location = new System.Drawing.Point(170, 232);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(213, 21);
            this.cbSex.TabIndex = 188;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(170, 185);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(214, 20);
            this.txtDiaChi.TabIndex = 186;
            // 
            // txtNameContact
            // 
            this.txtNameContact.ForeColor = System.Drawing.Color.Black;
            this.txtNameContact.Location = new System.Drawing.Point(170, 163);
            this.txtNameContact.Name = "txtNameContact";
            this.txtNameContact.Size = new System.Drawing.Size(214, 20);
            this.txtNameContact.TabIndex = 187;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(170, 338);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(263, 43);
            this.txtNote.TabIndex = 185;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(170, 208);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(214, 20);
            this.txtPhone.TabIndex = 184;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 180;
            this.label2.Text = "Tài khoản Skype:";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(52, 232);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(50, 13);
            this.lbSex.TabIndex = 181;
            this.lbSex.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 178;
            this.label3.Text = "Địa chỉ :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(52, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 179;
            this.label16.Text = "Số điện thoại:";
            // 
            // txtSkype
            // 
            this.txtSkype.Location = new System.Drawing.Point(170, 258);
            this.txtSkype.Name = "txtSkype";
            this.txtSkype.Size = new System.Drawing.Size(214, 20);
            this.txtSkype.TabIndex = 182;
            // 
            // lbnote
            // 
            this.lbnote.AutoSize = true;
            this.lbnote.Location = new System.Drawing.Point(52, 283);
            this.lbnote.Name = "lbnote";
            this.lbnote.Size = new System.Drawing.Size(35, 13);
            this.lbnote.TabIndex = 177;
            this.lbnote.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 175;
            this.label1.Text = "Ghi chú:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 176;
            this.label13.Text = "Họ tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 177;
            this.label5.Text = "Hoạt Động:";
            // 
            // checkIsActive
            // 
            this.checkIsActive.AutoSize = true;
            this.checkIsActive.Location = new System.Drawing.Point(170, 310);
            this.checkIsActive.Name = "checkIsActive";
            this.checkIsActive.Size = new System.Drawing.Size(15, 14);
            this.checkIsActive.TabIndex = 189;
            this.checkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(170, 284);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 20);
            this.txtEmail.TabIndex = 190;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(51, 137);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 13);
            this.label21.TabIndex = 276;
            this.label21.Text = "Tên tài khoản:";
            // 
            // txtAccount
            // 
            this.txtAccount.ForeColor = System.Drawing.Color.Black;
            this.txtAccount.Location = new System.Drawing.Point(171, 137);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.ReadOnly = true;
            this.txtAccount.Size = new System.Drawing.Size(146, 20);
            this.txtAccount.TabIndex = 277;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(323, 140);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(93, 13);
            this.linkLabel3.TabIndex = 278;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Change Password";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // cbMain
            // 
            this.cbMain.AutoSize = true;
            this.cbMain.Location = new System.Drawing.Point(368, 309);
            this.cbMain.Name = "cbMain";
            this.cbMain.Size = new System.Drawing.Size(15, 14);
            this.cbMain.TabIndex = 189;
            this.cbMain.UseVisualStyleBackColor = true;
            this.cbMain.CheckedChanged += new System.EventHandler(this.cbMain_CheckedChanged);
            this.cbMain.Click += new System.EventHandler(this.cbMain_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 177;
            this.label6.Text = "Tài khoản chính:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // frmEditDeputy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(448, 412);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cbMain);
            this.Controls.Add(this.checkIsActive);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtNameContact);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtSkype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbnote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditDeputy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCreateProduct_FormClosing);
            this.Load += new System.EventHandler(this.frmCreateProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModernUI.Controls.BootstrapButton btnCancel;
        private ModernUI.Controls.BootstrapButton btnClearAll;
        private ModernUI.Controls.BootstrapButton btnSave;
        private System.Windows.Forms.Label label4;
        private ModernUI.Controls.MetroSearchComboBox cbSex;
        private ToolBoxCS.TextBoxValidation txtDiaChi;
        private ToolBoxCS.TextBoxValidation txtNameContact;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSkype;
        private System.Windows.Forms.Label lbnote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkIsActive;
        private ToolBoxCS.TextboxEmail txtEmail;
        private System.Windows.Forms.Label label21;
        private ToolBoxCS.TextBoxValidation txtAccount;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.CheckBox cbMain;
        private System.Windows.Forms.Label label6;
    }
}