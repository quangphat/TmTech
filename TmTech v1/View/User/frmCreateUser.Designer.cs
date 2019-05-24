namespace TmTech_v1.View
{
    partial class frmCreateUser
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecoverEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRetypePass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbUsertype = new ModernUI.Controls.MetroComboBox();
            this.cbbUserGroup = new ModernUI.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.btnCancel = new ModernUI.Controls.BootstrapButton();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(63, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên đăng nhập:";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(66, 87);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(299, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(66, 141);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(299, 26);
            this.txtPass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật khẩu:";
            // 
            // txtRecoverEmail
            // 
            this.txtRecoverEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecoverEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecoverEmail.Location = new System.Drawing.Point(65, 254);
            this.txtRecoverEmail.Name = "txtRecoverEmail";
            this.txtRecoverEmail.Size = new System.Drawing.Size(300, 26);
            this.txtRecoverEmail.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email khôi phục:";
            // 
            // txtRetypePass
            // 
            this.txtRetypePass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRetypePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypePass.Location = new System.Drawing.Point(66, 196);
            this.txtRetypePass.Name = "txtRetypePass";
            this.txtRetypePass.PasswordChar = '*';
            this.txtRetypePass.Size = new System.Drawing.Size(299, 26);
            this.txtRetypePass.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên người dùng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Loại người dùng:";
            // 
            // cbbUsertype
            // 
            this.cbbUsertype.FormattingEnabled = true;
            this.cbbUsertype.Highlight = ModernUI.Controls.MetroComboBox.enumHighLight.Alway;
            this.cbbUsertype.ItemHeight = 23;
            this.cbbUsertype.Location = new System.Drawing.Point(66, 311);
            this.cbbUsertype.Name = "cbbUsertype";
            this.cbbUsertype.Size = new System.Drawing.Size(299, 29);
            this.cbbUsertype.TabIndex = 12;
            this.cbbUsertype.UseSelectable = true;
            this.cbbUsertype.SelectionChangeCommitted += new System.EventHandler(this.cbbUsertype_SelectionChangeCommitted);
            // 
            // cbbUserGroup
            // 
            this.cbbUserGroup.FormattingEnabled = true;
            this.cbbUserGroup.Highlight = ModernUI.Controls.MetroComboBox.enumHighLight.Alway;
            this.cbbUserGroup.ItemHeight = 23;
            this.cbbUserGroup.Location = new System.Drawing.Point(65, 382);
            this.cbbUserGroup.Name = "cbbUserGroup";
            this.cbbUserGroup.Size = new System.Drawing.Size(299, 29);
            this.cbbUserGroup.TabIndex = 15;
            this.cbbUserGroup.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nhóm người dùng:";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(127, 498);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(215, 498);
            this.btnCancel.MouseState = ModernUI.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(66, 450);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(299, 26);
            this.txtFullName.TabIndex = 22;
            // 
            // frmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackLocation = ModernUI.Forms.BackLocation.TopLeft;
            this.BorderStyle = ModernUI.Forms.MetroFormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(454, 557);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbUserGroup);
            this.Controls.Add(this.cbbUsertype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRecoverEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRetypePass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateUser";
            this.Resizable = false;
            this.ShadowType = ModernUI.Forms.MetroFormShadowType.Flat;
            this.Text = "Tạo tài khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Create_FormClosing);
            this.Load += new System.EventHandler(this.Create_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecoverEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRetypePass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ModernUI.Controls.MetroComboBox cbbUsertype;
        private ModernUI.Controls.MetroComboBox cbbUserGroup;
        private System.Windows.Forms.Label label6;
        private ModernUI.Controls.BootstrapButton btnSave;
        private ModernUI.Controls.BootstrapButton btnCancel;
        private System.Windows.Forms.TextBox txtFullName;
    }
}