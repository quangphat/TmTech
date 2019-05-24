namespace TmTech_v1.View
{
    partial class frmEditGroupSupplier
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
            this.lblNotify = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.bootstrapButton2 = new ModernUI.Controls.BootstrapButton();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bootstrapButton1 = new ModernUI.Controls.BootstrapButton();
            this.SuspendLayout();
            // 
            // lblNotify
            // 
            this.lblNotify.AutoSize = true;
            this.lblNotify.Location = new System.Drawing.Point(171, 82);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(49, 13);
            this.lblNotify.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.lblNotify.TabIndex = 40;
            this.lblNotify.Text = "message";
            // 
            // bootstrapButton2
            // 
            this.bootstrapButton2.AutoSize = true;
            this.bootstrapButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bootstrapButton2.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.bootstrapButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapButton2.Depth = 0;
            this.bootstrapButton2.Icon = null;
            this.bootstrapButton2.Location = new System.Drawing.Point(307, 30);
            this.bootstrapButton2.MouseState = ModernUI.MouseState.HOVER;
            this.bootstrapButton2.Name = "bootstrapButton2";
            this.bootstrapButton2.Size = new System.Drawing.Size(73, 36);
            this.bootstrapButton2.TabIndex = 39;
            this.bootstrapButton2.Text = "Cancel";
            this.bootstrapButton2.UseVisualStyleBackColor = true;
            this.bootstrapButton2.Click += new System.EventHandler(this.bootstrapButton2_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(246, 30);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.saveupdate);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(89, 114);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(192, 20);
            this.txtGroupName.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tên nhóm";
            // 
            // bootstrapButton1
            // 
            this.bootstrapButton1.AutoSize = true;
            this.bootstrapButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bootstrapButton1.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.bootstrapButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapButton1.Depth = 0;
            this.bootstrapButton1.Icon = null;
            this.bootstrapButton1.Location = new System.Drawing.Point(185, 30);
            this.bootstrapButton1.MouseState = ModernUI.MouseState.HOVER;
            this.bootstrapButton1.Name = "bootstrapButton1";
            this.bootstrapButton1.Size = new System.Drawing.Size(48, 36);
            this.bootstrapButton1.TabIndex = 38;
            this.bootstrapButton1.Text = "Xóa";
            this.bootstrapButton1.UseVisualStyleBackColor = true;
            this.bootstrapButton1.Click += new System.EventHandler(this.bootstrapButton1_Click);
            // 
            // frmEditGroupSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 180);
            this.Controls.Add(this.lblNotify);
            this.Controls.Add(this.bootstrapButton2);
            this.Controls.Add(this.bootstrapButton1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.label1);
            this.Name = "frmEditGroupSupplier";
            this.Load += new System.EventHandler(this.frmEditGroupSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolBoxCS.LabelNotify lblNotify;
        private ModernUI.Controls.BootstrapButton bootstrapButton2;
        private ModernUI.Controls.BootstrapButton btnSave;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label1;
        private ModernUI.Controls.BootstrapButton bootstrapButton1;
    }
}
