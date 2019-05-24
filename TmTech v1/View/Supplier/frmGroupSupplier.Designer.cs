namespace TmTech_v1.View
{
    partial class frmGroupSupplier
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.bootstrapButton2 = new ModernUI.Controls.BootstrapButton();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.lblNotify = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tạoNhómMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoMớiSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhóm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(105, 79);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(192, 20);
            this.txtGroupName.TabIndex = 1;
            this.txtGroupName.TextChanged += new System.EventHandler(this.txtGroupName_TextChanged);
            // 
            // bootstrapButton2
            // 
            this.bootstrapButton2.AutoSize = true;
            this.bootstrapButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bootstrapButton2.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.bootstrapButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapButton2.Depth = 0;
            this.bootstrapButton2.Icon = null;
            this.bootstrapButton2.Location = new System.Drawing.Point(323, 8);
            this.bootstrapButton2.MouseState = ModernUI.MouseState.HOVER;
            this.bootstrapButton2.Name = "bootstrapButton2";
            this.bootstrapButton2.Size = new System.Drawing.Size(73, 36);
            this.bootstrapButton2.TabIndex = 34;
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
            this.btnSave.Location = new System.Drawing.Point(262, 8);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNotify
            // 
            this.lblNotify.AutoSize = true;
            this.lblNotify.Location = new System.Drawing.Point(187, 60);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(49, 13);
            this.lblNotify.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.lblNotify.TabIndex = 35;
            this.lblNotify.Text = "message";
            this.lblNotify.Click += new System.EventHandler(this.lblNotify_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoNhómMớiToolStripMenuItem,
            this.tạoMớiSupplierToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tạoNhómMớiToolStripMenuItem
            // 
            this.tạoNhómMớiToolStripMenuItem.Name = "tạoNhómMớiToolStripMenuItem";
            this.tạoNhómMớiToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.tạoNhómMớiToolStripMenuItem.Text = "Tạo nhóm mới";
            this.tạoNhómMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoNhómMớiToolStripMenuItem_Click);
            // 
            // tạoMớiSupplierToolStripMenuItem
            // 
            this.tạoMớiSupplierToolStripMenuItem.Name = "tạoMớiSupplierToolStripMenuItem";
            this.tạoMớiSupplierToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.tạoMớiSupplierToolStripMenuItem.Text = "Tạo  mới supplier";
            this.tạoMớiSupplierToolStripMenuItem.Click += new System.EventHandler(this.tạoMớiSupplierToolStripMenuItem_Click);
            // 
            // frmGroupSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 146);
            this.Controls.Add(this.lblNotify);
            this.Controls.Add(this.bootstrapButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.label1);
            this.Name = "frmGroupSupplier";
            this.Text = "Thêm nhóm mới";
            this.Load += new System.EventHandler(this.GroupSupplier_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroupName;
        private ModernUI.Controls.BootstrapButton bootstrapButton2;
        private ModernUI.Controls.BootstrapButton btnSave;
        private ToolBoxCS.LabelNotify lblNotify;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tạoNhómMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoMớiSupplierToolStripMenuItem;
    }
}