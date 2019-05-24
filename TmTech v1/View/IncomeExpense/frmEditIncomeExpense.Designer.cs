namespace TmTech_v1.View
{
    partial class frmEditIncomExpense
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
            this.btnSend = new ModernUI.Controls.BootstrapButton();
            this.autoTextBox1 = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.btnClose = new ModernUI.Controls.BootstrapButton();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Success;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Depth = 0;
            this.btnSend.Icon = null;
            this.btnSend.Location = new System.Drawing.Point(303, 7);
            this.btnSend.MouseState = ModernUI.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(44, 36);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // autoTextBox1
            // 
            this.autoTextBox1.BindingFor = "";
            this.autoTextBox1.BindingName = null;
            this.autoTextBox1.Location = new System.Drawing.Point(3, 63);
            this.autoTextBox1.Multiline = true;
            this.autoTextBox1.Name = "autoTextBox1";
            this.autoTextBox1.Size = new System.Drawing.Size(407, 122);
            this.autoTextBox1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Depth = 0;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(351, 7);
            this.btnClose.MouseState = ModernUI.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmEditIncomExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 187);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.autoTextBox1);
            this.Name = "frmEditIncomExpense";
            this.Resizable = false;
            this.Text = "Nội dung sửa đổi";
            this.Load += new System.EventHandler(this.frmEditIncomeExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolBoxCS.AutoTextBox autoTextBox1;
        private ModernUI.Controls.BootstrapButton btnSend;
        private ModernUI.Controls.BootstrapButton btnClose;
    }
}