namespace TmTech_v1.View
{
    partial class frmEditRequestPayment
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
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.btnClose = new ModernUI.Controls.BootstrapButton();
            this.btnSend = new ModernUI.Controls.BootstrapButton();
            this.txtCode = new TmTech_v1.ToolBoxCS.DisplayText();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lableMessage = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.txtTitle = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtEmail = new TmTech_v1.ToolBoxCS.TextboxEmail();
            this.SuspendLayout();
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleForm.Location = new System.Drawing.Point(8, 26);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(266, 33);
            this.lblTitleForm.TabIndex = 174;
            this.lblTitleForm.Text = "Yêu cầu thanh toán";
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
            this.btnClose.Location = new System.Drawing.Point(575, 23);
            this.btnClose.MouseState = ModernUI.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 36);
            this.btnClose.TabIndex = 294;
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
            this.btnSend.Location = new System.Drawing.Point(514, 23);
            this.btnSend.MouseState = ModernUI.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(56, 36);
            this.btnSend.TabIndex = 293;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(168, 120);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(405, 20);
            this.txtCode.TabIndex = 180;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 177;
            this.label3.Text = "Nội dung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 178;
            this.label2.Text = "Email người nhận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 179;
            this.label1.Text = "Mã yêu cầu";
            // 
            // txtContent
            // 
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContent.Location = new System.Drawing.Point(52, 241);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(521, 286);
            this.txtContent.TabIndex = 295;
            this.txtContent.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 178;
            this.label5.Text = "Tiêu đề";
            // 
            // lableMessage
            // 
            this.lableMessage.AutoSize = true;
            this.lableMessage.Location = new System.Drawing.Point(315, 78);
            this.lableMessage.Name = "lableMessage";
            this.lableMessage.Size = new System.Drawing.Size(49, 13);
            this.lableMessage.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.lableMessage.TabIndex = 298;
            this.lableMessage.Text = "message";
            // 
            // txtTitle
            // 
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(168, 158);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(405, 20);
            this.txtTitle.TabIndex = 299;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(169, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(404, 20);
            this.txtEmail.TabIndex = 301;
            // 
            // frmEditRequestPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 550);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lableMessage);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblTitleForm);
            this.Controls.Add(this.label1);
            this.Name = "frmEditRequestPayment";
            this.Load += new System.EventHandler(this.RequestPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleForm;
        private ModernUI.Controls.BootstrapButton btnClose;
        private ModernUI.Controls.BootstrapButton btnSend;
        private ToolBoxCS.DisplayText txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Label label5;
        private ToolBoxCS.LabelNotify lableMessage;
        private ToolBoxCS.TextBoxValidation txtTitle;
        private ToolBoxCS.TextboxEmail txtEmail;
    }
}