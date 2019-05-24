namespace TmTech_v1.View
{
    partial class frmSendPaymentRequest
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
            this.txtEmail = new TmTech_v1.ToolBoxCS.TextboxEmail();
            this.txtTitle = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.lblNotify = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.txtCode = new TmTech_v1.ToolBoxCS.DisplayText();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new ModernUI.Controls.BootstrapButton();
            this.btnSend = new ModernUI.Controls.BootstrapButton();
            this.autoTextBox1 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BindingFor = "";
            this.txtEmail.BindingName = null;
            this.txtEmail.Location = new System.Drawing.Point(143, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(404, 20);
            this.txtEmail.TabIndex = 310;
            // 
            // txtTitle
            // 
            this.txtTitle.BindingFor = "PaymentRequest";
            this.txtTitle.BindingName = "Title";
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(142, 143);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(405, 20);
            this.txtTitle.TabIndex = 309;
            // 
            // lblNotify
            // 
            this.lblNotify.AutoSize = true;
            this.lblNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify.Location = new System.Drawing.Point(278, 78);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(72, 16);
            this.lblNotify.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.lblNotify.TabIndex = 308;
            this.lblNotify.Text = "message";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(142, 105);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(405, 20);
            this.txtCode.TabIndex = 306;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 302;
            this.label3.Text = "Nội dung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 303;
            this.label5.Text = "Tiêu đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 304;
            this.label2.Text = "Email người nhận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 305;
            this.label1.Text = "Mã yêu cầu";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Depth = 0;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(566, 39);
            this.btnClose.MouseState = ModernUI.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 36);
            this.btnClose.TabIndex = 312;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.AutoSize = true;
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Depth = 0;
            this.btnSend.Icon = null;
            this.btnSend.Location = new System.Drawing.Point(505, 39);
            this.btnSend.MouseState = ModernUI.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(56, 36);
            this.btnSend.TabIndex = 311;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // autoTextBox1
            // 
            this.autoTextBox1.BindingFor = "PaymentRequest";
            this.autoTextBox1.BindingName = "RequestContent";
            this.autoTextBox1.Location = new System.Drawing.Point(0, 246);
            this.autoTextBox1.Multiline = true;
            this.autoTextBox1.Name = "autoTextBox1";
            this.autoTextBox1.Size = new System.Drawing.Size(642, 266);
            this.autoTextBox1.TabIndex = 313;
            // 
            // frmSendPaymentRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 515);
            this.Controls.Add(this.autoTextBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblNotify);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSendPaymentRequest";
            this.Text = "Gửi yêu cầu thanh toán";
            this.Load += new System.EventHandler(this.frmSendPaymentRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolBoxCS.TextboxEmail txtEmail;
        private ToolBoxCS.TextBoxValidation txtTitle;
        private ToolBoxCS.LabelNotify lblNotify;
        private ToolBoxCS.DisplayText txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ModernUI.Controls.BootstrapButton btnClose;
        private ModernUI.Controls.BootstrapButton btnSend;
        private ToolBoxCS.AutoTextBox autoTextBox1;
    }
}