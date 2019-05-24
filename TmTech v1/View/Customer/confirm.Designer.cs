namespace TmTech_v1.View.Customer
{
    partial class frmConform
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
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new ModernUI.Controls.BootstrapButton();
            this.bootstrapButton2 = new ModernUI.Controls.BootstrapButton();
            this.bootstrapButton1 = new ModernUI.Controls.BootstrapButton();
            this.btnUpdateCompany = new ModernUI.Controls.BootstrapButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatusCurrent = new TmTech_v1.ToolBoxCS.DisplayText();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(119, 117);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(185, 96);
            this.txtNote.TabIndex = 1;
            this.txtNote.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 181;
            this.label2.Text = "Ghi chú";
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
            this.btnClose.Location = new System.Drawing.Point(254, 10);
            this.btnClose.MouseState = ModernUI.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 36);
            this.btnClose.TabIndex = 219;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bootstrapButton2
            // 
            this.bootstrapButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bootstrapButton2.AutoSize = true;
            this.bootstrapButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bootstrapButton2.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.bootstrapButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapButton2.Depth = 0;
            this.bootstrapButton2.Icon = null;
            this.bootstrapButton2.Location = new System.Drawing.Point(8, 10);
            this.bootstrapButton2.MouseState = ModernUI.MouseState.HOVER;
            this.bootstrapButton2.Name = "bootstrapButton2";
            this.bootstrapButton2.Size = new System.Drawing.Size(95, 36);
            this.bootstrapButton2.TabIndex = 216;
            this.bootstrapButton2.Text = "Chờ duyệt";
            this.bootstrapButton2.UseVisualStyleBackColor = true;
            this.bootstrapButton2.Click += new System.EventHandler(this.bootstrapButton2_Click);
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
            this.bootstrapButton1.Location = new System.Drawing.Point(189, 10);
            this.bootstrapButton1.MouseState = ModernUI.MouseState.HOVER;
            this.bootstrapButton1.Name = "bootstrapButton1";
            this.bootstrapButton1.Size = new System.Drawing.Size(59, 36);
            this.bootstrapButton1.TabIndex = 217;
            this.bootstrapButton1.Text = "Đóng";
            this.bootstrapButton1.UseVisualStyleBackColor = true;
            this.bootstrapButton1.Click += new System.EventHandler(this.bootstrapButton1_Click);
            // 
            // btnUpdateCompany
            // 
            this.btnUpdateCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateCompany.AutoSize = true;
            this.btnUpdateCompany.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateCompany.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnUpdateCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCompany.Depth = 0;
            this.btnUpdateCompany.Icon = null;
            this.btnUpdateCompany.Location = new System.Drawing.Point(109, 10);
            this.btnUpdateCompany.MouseState = ModernUI.MouseState.HOVER;
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(74, 36);
            this.btnUpdateCompany.TabIndex = 218;
            this.btnUpdateCompany.Text = "Từ chối";
            this.btnUpdateCompany.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 181;
            this.label1.Text = "Trạng thái hiện tại";
            // 
            // txtStatusCurrent
            // 
            this.txtStatusCurrent.Location = new System.Drawing.Point(119, 76);
            this.txtStatusCurrent.Name = "txtStatusCurrent";
            this.txtStatusCurrent.ReadOnly = true;
            this.txtStatusCurrent.Size = new System.Drawing.Size(185, 20);
            this.txtStatusCurrent.TabIndex = 220;
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(-15, -15);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(100, 20);
            this.radTextBox1.TabIndex = 221;
            // 
            // radTextBox2
            // 
            this.radTextBox2.Location = new System.Drawing.Point(189, 268);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.Size = new System.Drawing.Size(100, 20);
            this.radTextBox2.TabIndex = 222;
            // 
            // frmConform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 428);
            this.Controls.Add(this.radTextBox2);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.txtStatusCurrent);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bootstrapButton2);
            this.Controls.Add(this.bootstrapButton1);
            this.Controls.Add(this.btnUpdateCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNote);
            this.Name = "frmConform";
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Label label2;
        private ModernUI.Controls.BootstrapButton btnClose;
        private ModernUI.Controls.BootstrapButton bootstrapButton2;
        private ModernUI.Controls.BootstrapButton bootstrapButton1;
        private ModernUI.Controls.BootstrapButton btnUpdateCompany;
        private System.Windows.Forms.Label label1;
        private ToolBoxCS.DisplayText txtStatusCurrent;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
    }
}