namespace TmTech_v1.View.Customer
{
    partial class frmEditCompanyUpdate
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
            this.txtPhoneAccountant = new TmTech_v1.ToolBoxCS.TextboxPhone();
            this.label28 = new System.Windows.Forms.Label();
            this.txtApprover = new System.Windows.Forms.TextBox();
            this.cbSelectBank = new TmTech_v1.ToolBoxCS.CboBindBank();
            this.txtAddressBank = new System.Windows.Forms.TextBox();
            this.cbClassCustormer = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtPassword = new TmTech_v1.ToolBoxCS.TextBoxPassword();
            this.txtRePassword = new TmTech_v1.ToolBoxCS.TextBoxPassword();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNumberBank = new System.Windows.Forms.TextBox();
            this.txtAccountant = new System.Windows.Forms.TextBox();
            this.txtAcountBank = new System.Windows.Forms.TextBox();
            this.txtEmail = new TmTech_v1.ToolBoxCS.TextboxEmail();
            this.txtTaxCode = new TmTech_v1.ToolBoxCS.NumberIntValidation();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNoBrach = new TmTech_v1.ToolBoxCS.TextBoxInt();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboTypeOfCompany = new ModernUI.Controls.MetroSearchComboBox();
            this.cbSex = new ModernUI.Controls.MetroSearchComboBox();
            this.txtAccount = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtNameContact = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.label19 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtAddress = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtCompanyCode = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtTargertValue = new TmTech_v1.ToolBoxCS.TextBoxInt();
            this.txtStaft = new TmTech_v1.ToolBoxCS.TextBoxInt();
            this.PictureSgnature = new System.Windows.Forms.PictureBox();
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtSwich = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbSex = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.btnClearAll = new ModernUI.Controls.BootstrapButton();
            this.btnClose = new ModernUI.Controls.BootstrapButton();
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSgnature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPhoneAccountant
            // 
            this.txtPhoneAccountant.Location = new System.Drawing.Point(152, 338);
            this.txtPhoneAccountant.Name = "txtPhoneAccountant";
            this.txtPhoneAccountant.Size = new System.Drawing.Size(213, 20);
            this.txtPhoneAccountant.TabIndex = 348;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(404, 314);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(61, 13);
            this.label28.TabIndex = 346;
            this.label28.Text = "Approve by";
            // 
            // txtApprover
            // 
            this.txtApprover.Location = new System.Drawing.Point(502, 314);
            this.txtApprover.Name = "txtApprover";
            this.txtApprover.ReadOnly = true;
            this.txtApprover.Size = new System.Drawing.Size(145, 20);
            this.txtApprover.TabIndex = 347;
            this.txtApprover.Text = "Nguyễn Trung Tuyến";
            // 
            // cbSelectBank
            // 
            this.cbSelectBank.FormattingEnabled = true;
            this.cbSelectBank.ItemHeight = 13;
            this.cbSelectBank.Location = new System.Drawing.Point(152, 208);
            this.cbSelectBank.Name = "cbSelectBank";
            this.cbSelectBank.Size = new System.Drawing.Size(215, 21);
            this.cbSelectBank.TabIndex = 345;
            // 
            // txtAddressBank
            // 
            this.txtAddressBank.Location = new System.Drawing.Point(152, 235);
            this.txtAddressBank.Name = "txtAddressBank";
            this.txtAddressBank.ReadOnly = true;
            this.txtAddressBank.Size = new System.Drawing.Size(216, 20);
            this.txtAddressBank.TabIndex = 344;
            // 
            // cbClassCustormer
            // 
            this.cbClassCustormer.FormattingEnabled = true;
            this.cbClassCustormer.Location = new System.Drawing.Point(502, 283);
            this.cbClassCustormer.Name = "cbClassCustormer";
            this.cbClassCustormer.Size = new System.Drawing.Size(143, 21);
            this.cbClassCustormer.TabIndex = 343;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(400, 286);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 13);
            this.label27.TabIndex = 342;
            this.label27.Text = "Class:";
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(502, 128);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(143, 20);
            this.txtPassword.TabIndex = 341;
            // 
            // txtRePassword
            // 
            this.txtRePassword.ForeColor = System.Drawing.Color.Black;
            this.txtRePassword.Location = new System.Drawing.Point(502, 154);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(143, 20);
            this.txtRePassword.TabIndex = 340;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(400, 154);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 13);
            this.label20.TabIndex = 295;
            this.label20.Text = "Re_Password:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(400, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 294;
            this.label15.Text = "Password:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(400, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 296;
            this.label21.Text = "UserAccount:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(400, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 293;
            this.label13.Text = "Name contact:";
            // 
            // txtNumberBank
            // 
            this.txtNumberBank.Location = new System.Drawing.Point(151, 283);
            this.txtNumberBank.Name = "txtNumberBank";
            this.txtNumberBank.Size = new System.Drawing.Size(216, 20);
            this.txtNumberBank.TabIndex = 315;
            // 
            // txtAccountant
            // 
            this.txtAccountant.Location = new System.Drawing.Point(150, 311);
            this.txtAccountant.Name = "txtAccountant";
            this.txtAccountant.Size = new System.Drawing.Size(216, 20);
            this.txtAccountant.TabIndex = 314;
            // 
            // txtAcountBank
            // 
            this.txtAcountBank.Location = new System.Drawing.Point(151, 257);
            this.txtAcountBank.Name = "txtAcountBank";
            this.txtAcountBank.Size = new System.Drawing.Size(216, 20);
            this.txtAcountBank.TabIndex = 313;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(502, 204);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 20);
            this.txtEmail.TabIndex = 339;
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.ForeColor = System.Drawing.Color.Black;
            this.txtTaxCode.Location = new System.Drawing.Point(151, 388);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Size = new System.Drawing.Size(214, 20);
            this.txtTaxCode.TabIndex = 338;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 337;
            this.label3.Text = "Tax code:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 336;
            this.label9.Text = "Address of bank";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 335;
            this.label6.Text = "Select bank";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 334;
            this.label8.Text = "Type of company:";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(151, 412);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(168, 20);
            this.txtWebsite.TabIndex = 333;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(46, 412);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 332;
            this.label17.Text = "Website:";
            // 
            // txtNoBrach
            // 
            this.txtNoBrach.IsReadOnly = false;
            this.txtNoBrach.Location = new System.Drawing.Point(151, 460);
            this.txtNoBrach.MaxlenghtTB = 32767;
            this.txtNoBrach.MinLenghtTB = 0;
            this.txtNoBrach.Name = "txtNoBrach";
            this.txtNoBrach.Size = new System.Drawing.Size(93, 20);
            this.txtNoBrach.TabIndex = 331;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 330;
            this.label5.Text = "No brach:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(8, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 24);
            this.lblTitle.TabIndex = 329;
            this.lblTitle.Text = "Thêm mới công ty";
            // 
            // cboTypeOfCompany
            // 
            this.cboTypeOfCompany.FormattingEnabled = true;
            this.cboTypeOfCompany.Items.AddRange(new object[] {
            "Công ty",
            "Cá nhân"});
            this.cboTypeOfCompany.Location = new System.Drawing.Point(151, 154);
            this.cboTypeOfCompany.Name = "cboTypeOfCompany";
            this.cboTypeOfCompany.Size = new System.Drawing.Size(146, 21);
            this.cboTypeOfCompany.TabIndex = 328;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cbSex.Location = new System.Drawing.Point(502, 257);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(146, 21);
            this.cbSex.TabIndex = 327;
            // 
            // txtAccount
            // 
            this.txtAccount.ForeColor = System.Drawing.Color.Black;
            this.txtAccount.Location = new System.Drawing.Point(502, 105);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(146, 20);
            this.txtAccount.TabIndex = 326;
            // 
            // txtNameContact
            // 
            this.txtNameContact.ForeColor = System.Drawing.Color.Black;
            this.txtNameContact.Location = new System.Drawing.Point(502, 182);
            this.txtNameContact.Name = "txtNameContact";
            this.txtNameContact.Size = new System.Drawing.Size(146, 20);
            this.txtNameContact.TabIndex = 325;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(46, 105);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 13);
            this.label19.TabIndex = 324;
            this.label19.Text = "Company code";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(400, 386);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(95, 13);
            this.linkLabel2.TabIndex = 322;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Signature of client:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(528, 386);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(31, 13);
            this.linkLabel1.TabIndex = 323;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logo";
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(151, 182);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(215, 20);
            this.txtAddress.TabIndex = 321;
            // 
            // txtCompanyCode
            // 
            this.txtCompanyCode.Location = new System.Drawing.Point(151, 105);
            this.txtCompanyCode.Name = "txtCompanyCode";
            this.txtCompanyCode.Size = new System.Drawing.Size(215, 20);
            this.txtCompanyCode.TabIndex = 319;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyName.Location = new System.Drawing.Point(151, 128);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(216, 20);
            this.txtCompanyName.TabIndex = 320;
            // 
            // txtTargertValue
            // 
            this.txtTargertValue.IsReadOnly = false;
            this.txtTargertValue.Location = new System.Drawing.Point(151, 486);
            this.txtTargertValue.MaxlenghtTB = 32767;
            this.txtTargertValue.MinLenghtTB = 0;
            this.txtTargertValue.Name = "txtTargertValue";
            this.txtTargertValue.Size = new System.Drawing.Size(93, 20);
            this.txtTargertValue.TabIndex = 318;
            // 
            // txtStaft
            // 
            this.txtStaft.IsReadOnly = false;
            this.txtStaft.Location = new System.Drawing.Point(151, 434);
            this.txtStaft.MaxlenghtTB = 32767;
            this.txtStaft.MinLenghtTB = 0;
            this.txtStaft.Name = "txtStaft";
            this.txtStaft.Size = new System.Drawing.Size(93, 20);
            this.txtStaft.TabIndex = 317;
            // 
            // PictureSgnature
            // 
            this.PictureSgnature.Image = global::TmTech_v1.Properties.Resources.unknow;
            this.PictureSgnature.Location = new System.Drawing.Point(403, 412);
            this.PictureSgnature.Name = "PictureSgnature";
            this.PictureSgnature.Size = new System.Drawing.Size(109, 107);
            this.PictureSgnature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureSgnature.TabIndex = 291;
            this.PictureSgnature.TabStop = false;
            // 
            // PictureLogo
            // 
            this.PictureLogo.Image = global::TmTech_v1.Properties.Resources.unknow;
            this.PictureLogo.Location = new System.Drawing.Point(534, 412);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(99, 107);
            this.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLogo.TabIndex = 292;
            this.PictureLogo.TabStop = false;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(74, 543);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(571, 61);
            this.txtNote.TabIndex = 316;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 486);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 310;
            this.label12.Text = "Targer value:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(152, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 309;
            this.label11.Text = "No staff:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 308;
            this.label10.Text = "No employee:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(45, 337);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 13);
            this.label25.TabIndex = 304;
            this.label25.Text = "Số điện thoại ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(46, 283);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 13);
            this.label23.TabIndex = 303;
            this.label23.Text = "Số tài khoản:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(45, 311);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 13);
            this.label24.TabIndex = 302;
            this.label24.Text = "kế toán chính";
            // 
            // txtSwich
            // 
            this.txtSwich.Location = new System.Drawing.Point(151, 363);
            this.txtSwich.Name = "txtSwich";
            this.txtSwich.Size = new System.Drawing.Size(216, 20);
            this.txtSwich.TabIndex = 312;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(46, 257);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 13);
            this.label22.TabIndex = 301;
            this.label22.Text = "Tên tài khoản:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 307;
            this.label7.Text = "Switch code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 305;
            this.label4.Text = "Address:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(46, 504);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 300;
            this.label18.Text = "Description:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(502, 235);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(146, 20);
            this.txtPhone.TabIndex = 311;
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(400, 257);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(28, 13);
            this.lbSex.TabIndex = 299;
            this.lbSex.Text = "Sex:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(400, 235);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 298;
            this.label16.Text = "Phone:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(400, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 297;
            this.label14.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 306;
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
            this.btnSave.Location = new System.Drawing.Point(440, 10);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 288;
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
            this.btnClearAll.Location = new System.Drawing.Point(501, 10);
            this.btnClearAll.MouseState = ModernUI.MouseState.HOVER;
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(90, 36);
            this.btnClearAll.TabIndex = 289;
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
            this.btnClose.Location = new System.Drawing.Point(597, 10);
            this.btnClose.MouseState = ModernUI.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 36);
            this.btnClose.TabIndex = 290;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelNotify1
            // 
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(316, 69);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(0, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 349;
            // 
            // frmEditCompanyUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 642);
            this.Controls.Add(this.labelNotify1);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtPhoneAccountant);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtApprover);
            this.Controls.Add(this.cbSelectBank);
            this.Controls.Add(this.txtAddressBank);
            this.Controls.Add(this.cbClassCustormer);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNumberBank);
            this.Controls.Add(this.txtAccountant);
            this.Controls.Add(this.txtAcountBank);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTaxCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtNoBrach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cboTypeOfCompany);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.txtNameContact);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCompanyCode);
            this.Controls.Add(this.txtTargertValue);
            this.Controls.Add(this.txtStaft);
            this.Controls.Add(this.PictureSgnature);
            this.Controls.Add(this.PictureLogo);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtSwich);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClose);
            this.Name = "frmEditCompanyUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.PictureSgnature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolBoxCS.TextboxPhone txtPhoneAccountant;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtApprover;
        private ToolBoxCS.CboBindBank cbSelectBank;
        private System.Windows.Forms.TextBox txtAddressBank;
        private System.Windows.Forms.ComboBox cbClassCustormer;
        private System.Windows.Forms.Label label27;
        private ToolBoxCS.TextBoxPassword txtPassword;
        private ToolBoxCS.TextBoxPassword txtRePassword;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNumberBank;
        private System.Windows.Forms.TextBox txtAccountant;
        private System.Windows.Forms.TextBox txtAcountBank;
        private ToolBoxCS.TextboxEmail txtEmail;
        private ToolBoxCS.NumberIntValidation txtTaxCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label label17;
        private ToolBoxCS.TextBoxInt txtNoBrach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTitle;
        private ModernUI.Controls.MetroSearchComboBox cboTypeOfCompany;
        private ModernUI.Controls.MetroSearchComboBox cbSex;
        private ToolBoxCS.TextBoxValidation txtAccount;
        private ToolBoxCS.TextBoxValidation txtNameContact;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private ToolBoxCS.TextBoxValidation txtAddress;
        private System.Windows.Forms.TextBox txtCompanyCode;
        private ToolBoxCS.TextBoxValidation txtCompanyName;
        private ToolBoxCS.TextBoxInt txtTargertValue;
        private ToolBoxCS.TextBoxInt txtStaft;
        private System.Windows.Forms.PictureBox PictureSgnature;
        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtSwich;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private ModernUI.Controls.BootstrapButton btnSave;
        private ModernUI.Controls.BootstrapButton btnClearAll;
        private ModernUI.Controls.BootstrapButton btnClose;
        private ToolBoxCS.LabelNotify labelNotify1;
    }
}