namespace TmTech_v1.View
{
    partial class FrmEditCompany
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
            this.label19 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.PictureSgnature = new System.Windows.Forms.PictureBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSwich = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbSex = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.btnClearAll = new ModernUI.Controls.BootstrapButton();
            this.btnClose = new ModernUI.Controls.BootstrapButton();
            this.txtCompanyCode = new System.Windows.Forms.TextBox();
            this.bootstrapButton1 = new ModernUI.Controls.BootstrapButton();
            this.cbSex = new ModernUI.Controls.MetroSearchComboBox();
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNoBrach = new TmTech_v1.ToolBoxCS.TextBoxInt();
            this.txtNameContact = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtAddree = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtCompanyName = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtTargertValue = new TmTech_v1.ToolBoxCS.TextBoxInt();
            this.txtStaft = new TmTech_v1.ToolBoxCS.TextBoxInt();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTaxCode = new TmTech_v1.ToolBoxCS.NumberIntValidation();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTypeOfCompany = new ModernUI.Controls.MetroSearchComboBox();
            this.txtEmail = new TmTech_v1.ToolBoxCS.TextboxEmail();
            this.label21 = new System.Windows.Forms.Label();
            this.txtAccount = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAdrressOfBank = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSelectBank = new ModernUI.Controls.MetroSearchComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cbClassCustormer = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtAccountant = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtApprover = new System.Windows.Forms.TextBox();
            this.txtPhoneAccountant = new TmTech_v1.ToolBoxCS.TextboxPhone();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSgnature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 119);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 209;
            this.label19.Text = "CompanyCode";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(354, 296);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(95, 13);
            this.linkLabel2.TabIndex = 207;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Signature of client:";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(482, 296);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(31, 13);
            this.linkLabel1.TabIndex = 208;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logo";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // PictureSgnature
            // 
            this.PictureSgnature.Image = global::TmTech_v1.Properties.Resources.unknow;
            this.PictureSgnature.Location = new System.Drawing.Point(357, 312);
            this.PictureSgnature.Name = "PictureSgnature";
            this.PictureSgnature.Size = new System.Drawing.Size(109, 107);
            this.PictureSgnature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureSgnature.TabIndex = 178;
            this.PictureSgnature.TabStop = false;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(15, 531);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(569, 77);
            this.txtNote.TabIndex = 197;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 490);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 192;
            this.label12.Text = "Targer value:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 190;
            this.label10.Text = "No employee:";
            // 
            // txtSwich
            // 
            this.txtSwich.Location = new System.Drawing.Point(121, 313);
            this.txtSwich.Name = "txtSwich";
            this.txtSwich.Size = new System.Drawing.Size(216, 20);
            this.txtSwich.TabIndex = 196;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 188;
            this.label7.Text = "Switch code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 186;
            this.label4.Text = "Address:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 509);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 184;
            this.label18.Text = "Description:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(459, 190);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(146, 20);
            this.txtPhone.TabIndex = 195;
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(357, 214);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(28, 13);
            this.lbSex.TabIndex = 183;
            this.lbSex.Text = "Sex:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(357, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 182;
            this.label16.Text = "Phone:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(357, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 181;
            this.label14.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(357, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 180;
            this.label13.Text = "Name contact:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 187;
            this.label2.Text = "Company Name:";
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
            this.btnSave.Location = new System.Drawing.Point(379, 44);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 212;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClearAll.Location = new System.Drawing.Point(440, 44);
            this.btnClearAll.MouseState = ModernUI.MouseState.HOVER;
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(90, 36);
            this.btnClearAll.TabIndex = 213;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Danger;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Depth = 0;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(536, 44);
            this.btnClose.MouseState = ModernUI.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 36);
            this.btnClose.TabIndex = 214;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCompanyCode
            // 
            this.txtCompanyCode.Location = new System.Drawing.Point(120, 119);
            this.txtCompanyCode.Name = "txtCompanyCode";
            this.txtCompanyCode.ReadOnly = true;
            this.txtCompanyCode.Size = new System.Drawing.Size(215, 20);
            this.txtCompanyCode.TabIndex = 204;
            // 
            // bootstrapButton1
            // 
            this.bootstrapButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bootstrapButton1.AutoSize = true;
            this.bootstrapButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bootstrapButton1.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.bootstrapButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapButton1.Depth = 0;
            this.bootstrapButton1.Icon = null;
            this.bootstrapButton1.Location = new System.Drawing.Point(383, -184);
            this.bootstrapButton1.MouseState = ModernUI.MouseState.HOVER;
            this.bootstrapButton1.Name = "bootstrapButton1";
            this.bootstrapButton1.Size = new System.Drawing.Size(55, 36);
            this.bootstrapButton1.TabIndex = 212;
            this.bootstrapButton1.Text = "Save";
            this.bootstrapButton1.UseVisualStyleBackColor = true;
            this.bootstrapButton1.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbSex.Location = new System.Drawing.Point(459, 214);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(146, 21);
            this.cbSex.TabIndex = 216;
            // 
            // PictureLogo
            // 
            this.PictureLogo.Image = global::TmTech_v1.Properties.Resources.unknow;
            this.PictureLogo.Location = new System.Drawing.Point(485, 312);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(99, 107);
            this.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLogo.TabIndex = 179;
            this.PictureLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 217;
            this.label1.Text = "Sửa đổi thông tin công ty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 218;
            this.label5.Text = "No brach:";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(123, 416);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(168, 20);
            this.txtWebsite.TabIndex = 221;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 419);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 220;
            this.label17.Text = "Website:";
            // 
            // txtNoBrach
            // 
            this.txtNoBrach.IsReadOnly = false;
            this.txtNoBrach.Location = new System.Drawing.Point(123, 464);
            this.txtNoBrach.MaxlenghtTB = 32767;
            this.txtNoBrach.MinLenghtTB = 0;
            this.txtNoBrach.Name = "txtNoBrach";
            this.txtNoBrach.Size = new System.Drawing.Size(93, 20);
            this.txtNoBrach.TabIndex = 219;
            // 
            // txtNameContact
            // 
            this.txtNameContact.ForeColor = System.Drawing.Color.Black;
            this.txtNameContact.Location = new System.Drawing.Point(459, 142);
            this.txtNameContact.Name = "txtNameContact";
            this.txtNameContact.Size = new System.Drawing.Size(146, 20);
            this.txtNameContact.TabIndex = 211;
            // 
            // txtAddree
            // 
            this.txtAddree.ForeColor = System.Drawing.Color.Black;
            this.txtAddree.Location = new System.Drawing.Point(120, 188);
            this.txtAddree.Name = "txtAddree";
            this.txtAddree.Size = new System.Drawing.Size(216, 20);
            this.txtAddree.TabIndex = 206;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyName.Location = new System.Drawing.Point(120, 142);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(216, 20);
            this.txtCompanyName.TabIndex = 205;
            // 
            // txtTargertValue
            // 
            this.txtTargertValue.IsReadOnly = false;
            this.txtTargertValue.Location = new System.Drawing.Point(123, 488);
            this.txtTargertValue.MaxlenghtTB = 32767;
            this.txtTargertValue.MinLenghtTB = 0;
            this.txtTargertValue.Name = "txtTargertValue";
            this.txtTargertValue.Size = new System.Drawing.Size(93, 20);
            this.txtTargertValue.TabIndex = 201;
            // 
            // txtStaft
            // 
            this.txtStaft.IsReadOnly = false;
            this.txtStaft.Location = new System.Drawing.Point(123, 439);
            this.txtStaft.MaxlenghtTB = 32767;
            this.txtStaft.MinLenghtTB = 0;
            this.txtStaft.Name = "txtStaft";
            this.txtStaft.Size = new System.Drawing.Size(93, 20);
            this.txtStaft.TabIndex = 200;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 222;
            this.label8.Text = "Type of company:";
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.ForeColor = System.Drawing.Color.Black;
            this.txtTaxCode.Location = new System.Drawing.Point(121, 336);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Size = new System.Drawing.Size(214, 20);
            this.txtTaxCode.TabIndex = 225;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 224;
            this.label3.Text = "Tax code:";
            // 
            // cboTypeOfCompany
            // 
            this.cboTypeOfCompany.FormattingEnabled = true;
            this.cboTypeOfCompany.Items.AddRange(new object[] {
            "Công ty",
            "Cá nhân"});
            this.cboTypeOfCompany.Location = new System.Drawing.Point(120, 165);
            this.cboTypeOfCompany.Name = "cboTypeOfCompany";
            this.cboTypeOfCompany.Size = new System.Drawing.Size(216, 21);
            this.cboTypeOfCompany.TabIndex = 216;
            this.cboTypeOfCompany.SelectedIndexChanged += new System.EventHandler(this.cboTypeOfCompany_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(459, 166);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 20);
            this.txtEmail.TabIndex = 263;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(357, 109);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 266;
            this.label21.Text = "UserAccount:";
            // 
            // txtAccount
            // 
            this.txtAccount.ForeColor = System.Drawing.Color.Black;
            this.txtAccount.Location = new System.Drawing.Point(459, 109);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(146, 20);
            this.txtAccount.TabIndex = 269;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(512, 93);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(93, 13);
            this.linkLabel3.TabIndex = 270;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Change Password";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 289);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 20);
            this.textBox2.TabIndex = 273;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 274;
            // 
            // txtAdrressOfBank
            // 
            this.txtAdrressOfBank.Location = new System.Drawing.Point(122, 241);
            this.txtAdrressOfBank.Name = "txtAdrressOfBank";
            this.txtAdrressOfBank.Size = new System.Drawing.Size(216, 20);
            this.txtAdrressOfBank.TabIndex = 275;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 277;
            this.label9.Text = "Address of bank";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 278;
            this.label6.Text = "Select bank";
            // 
            // cbSelectBank
            // 
            this.cbSelectBank.DropDownWidth = 200;
            this.cbSelectBank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSelectBank.FormattingEnabled = true;
            this.cbSelectBank.Items.AddRange(new object[] {
            "Công ty",
            "Cá nhân"});
            this.cbSelectBank.Location = new System.Drawing.Point(122, 210);
            this.cbSelectBank.Name = "cbSelectBank";
            this.cbSelectBank.Size = new System.Drawing.Size(215, 21);
            this.cbSelectBank.TabIndex = 276;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(17, 289);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 13);
            this.label23.TabIndex = 271;
            this.label23.Text = "Số tài khoản:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 263);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 13);
            this.label22.TabIndex = 272;
            this.label22.Text = "Tên tài khoản:";
            // 
            // cbClassCustormer
            // 
            this.cbClassCustormer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassCustormer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClassCustormer.FormattingEnabled = true;
            this.cbClassCustormer.Location = new System.Drawing.Point(459, 241);
            this.cbClassCustormer.Name = "cbClassCustormer";
            this.cbClassCustormer.Size = new System.Drawing.Size(146, 21);
            this.cbClassCustormer.TabIndex = 280;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(357, 244);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 13);
            this.label27.TabIndex = 279;
            this.label27.Text = "Class:";
            // 
            // txtAccountant
            // 
            this.txtAccountant.Location = new System.Drawing.Point(122, 363);
            this.txtAccountant.Name = "txtAccountant";
            this.txtAccountant.Size = new System.Drawing.Size(216, 20);
            this.txtAccountant.TabIndex = 284;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 389);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 13);
            this.label25.TabIndex = 281;
            this.label25.Text = "Số điện thoại ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(17, 363);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 13);
            this.label24.TabIndex = 282;
            this.label24.Text = "kế toán chính";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(357, 270);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(61, 13);
            this.label28.TabIndex = 287;
            this.label28.Text = "Approve by";
            // 
            // txtApprover
            // 
            this.txtApprover.Location = new System.Drawing.Point(460, 268);
            this.txtApprover.Name = "txtApprover";
            this.txtApprover.ReadOnly = true;
            this.txtApprover.Size = new System.Drawing.Size(145, 20);
            this.txtApprover.TabIndex = 288;
            this.txtApprover.Text = "Nguyễn Trung Tuyến";
            // 
            // txtPhoneAccountant
            // 
            this.txtPhoneAccountant.Location = new System.Drawing.Point(123, 390);
            this.txtPhoneAccountant.Name = "txtPhoneAccountant";
            this.txtPhoneAccountant.Size = new System.Drawing.Size(213, 20);
            this.txtPhoneAccountant.TabIndex = 289;
            // 
            // FrmEditCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 641);
            this.Controls.Add(this.txtPhoneAccountant);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtApprover);
            this.Controls.Add(this.txtAccountant);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cbClassCustormer);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtAdrressOfBank);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSelectBank);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTaxCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtNoBrach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTypeOfCompany);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.bootstrapButton1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtNameContact);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtAddree);
            this.Controls.Add(this.txtCompanyCode);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtTargertValue);
            this.Controls.Add(this.txtStaft);
            this.Controls.Add(this.PictureSgnature);
            this.Controls.Add(this.PictureLogo);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSwich);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Name = "FrmEditCompany";
            this.Load += new System.EventHandler(this.frmEditCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureSgnature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolBoxCS.TextBoxValidation txtNameContact;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private ToolBoxCS.TextBoxValidation txtAddree;
        private ToolBoxCS.TextBoxValidation txtCompanyName;
        private ToolBoxCS.TextBoxInt txtTargertValue;
        private ToolBoxCS.TextBoxInt txtStaft;
        private System.Windows.Forms.PictureBox PictureSgnature;


        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSwich;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private ModernUI.Controls.BootstrapButton btnSave;
        private ModernUI.Controls.BootstrapButton btnClearAll;
        private ModernUI.Controls.BootstrapButton btnClose;
        private System.Windows.Forms.TextBox txtCompanyCode;
        private ModernUI.Controls.BootstrapButton bootstrapButton1;
        private ModernUI.Controls.MetroSearchComboBox cbSex;
        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.Label label1;
        private ToolBoxCS.TextBoxInt txtNoBrach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private ToolBoxCS.NumberIntValidation txtTaxCode;
        private System.Windows.Forms.Label label3;
        private ModernUI.Controls.MetroSearchComboBox cboTypeOfCompany;
        private ToolBoxCS.TextboxEmail txtEmail;
        private System.Windows.Forms.Label label21;
        private ToolBoxCS.TextBoxValidation txtAccount;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtAdrressOfBank;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private ModernUI.Controls.MetroSearchComboBox cbSelectBank;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbClassCustormer;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtAccountant;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtApprover;
        private ToolBoxCS.TextboxPhone txtPhoneAccountant;
    }
}