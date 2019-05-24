namespace TmTech_v1.View.UCcontrol
{
    partial class StaftProfile
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
            this.pnStaffInformation = new System.Windows.Forms.Panel();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtID = new TmTech_v1.ToolBoxCS.TextBoxInt();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtStaftName = new System.Windows.Forms.TextBox();
            this.pnStaffInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnStaffInformation
            // 
            this.pnStaffInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnStaffInformation.Controls.Add(this.cboSex);
            this.pnStaffInformation.Controls.Add(this.label23);
            this.pnStaffInformation.Controls.Add(this.label22);
            this.pnStaffInformation.Controls.Add(this.txtID);
            this.pnStaffInformation.Controls.Add(this.label21);
            this.pnStaffInformation.Controls.Add(this.label20);
            this.pnStaffInformation.Controls.Add(this.pictureBox1);
            this.pnStaffInformation.Controls.Add(this.label19);
            this.pnStaffInformation.Controls.Add(this.txtPhone);
            this.pnStaffInformation.Controls.Add(this.txtEmail);
            this.pnStaffInformation.Controls.Add(this.txtStaftName);
            this.pnStaffInformation.Location = new System.Drawing.Point(3, 3);
            this.pnStaffInformation.Name = "pnStaffInformation";
            this.pnStaffInformation.Size = new System.Drawing.Size(386, 128);
            this.pnStaffInformation.TabIndex = 48;
            this.pnStaffInformation.Paint += new System.Windows.Forms.PaintEventHandler(this.pnStaffInformation_Paint);
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboSex.Location = new System.Drawing.Point(102, 97);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(146, 21);
            this.cboSex.TabIndex = 4;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 97);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Sex:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 75);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Phone Number:";
            // 
            // txtID
            // 
            this.txtID.IsReadOnly = false;
            this.txtID.Location = new System.Drawing.Point(102, 30);
            this.txtID.MaxlenghtTB = 32767;
            this.txtID.MinLenghtTB = 0;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(146, 20);
            this.txtID.TabIndex = 53;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 52);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Email admin:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "ID Staff:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TmTech_v1.Properties.Resources.unknow;
            this.pictureBox1.Location = new System.Drawing.Point(266, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Staff Name:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(102, 75);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(146, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(102, 52);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtStaftName
            // 
            this.txtStaftName.Location = new System.Drawing.Point(102, 4);
            this.txtStaftName.Name = "txtStaftName";
            this.txtStaftName.Size = new System.Drawing.Size(146, 20);
            this.txtStaftName.TabIndex = 3;
            // 
            // StaftProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnStaffInformation);
            this.Name = "StaftProfile";
            this.Size = new System.Drawing.Size(397, 140);
            this.Load += new System.EventHandler(this.StaftProfile_Load);
            this.pnStaffInformation.ResumeLayout(false);
            this.pnStaffInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnStaffInformation;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private ToolBoxCS.TextBoxInt txtID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtStaftName;
    }
}
