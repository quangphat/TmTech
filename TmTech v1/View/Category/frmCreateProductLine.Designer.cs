namespace TmTech_v1.View
{
    partial class frmCreateSub
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
            this.lblNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.txtName = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtCode = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.label2 = new System.Windows.Forms.Label();
            this.bootstrapButton2 = new ModernUI.Controls.BootstrapButton();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.productPath1 = new TmTech_v1.ToolBoxCS.ProductPath();
            this.SuspendLayout();
            // 
            // lblNotify1
            // 
            this.lblNotify1.AutoSize = true;
            this.lblNotify1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify1.Location = new System.Drawing.Point(25, 104);
            this.lblNotify1.Name = "lblNotify1";
            this.lblNotify1.Size = new System.Drawing.Size(79, 16);
            this.lblNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.lblNotify1.TabIndex = 46;
            this.lblNotify1.Text = "labelNotify1";
            // 
            // txtName
            // 
            this.txtName.BindingFor = "ProductLine";
            this.txtName.BindingName = "ProductLineName";
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(30, 261);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 26);
            this.txtName.TabIndex = 45;
            // 
            // txtCode
            // 
            this.txtCode.BindingFor = "ProductLine";
            this.txtCode.BindingName = "ProductLineCode";
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.Location = new System.Drawing.Point(30, 204);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(243, 26);
            this.txtCode.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tên nhóm:";
            // 
            // bootstrapButton2
            // 
            this.bootstrapButton2.AutoSize = true;
            this.bootstrapButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bootstrapButton2.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.bootstrapButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapButton2.Depth = 0;
            this.bootstrapButton2.Icon = null;
            this.bootstrapButton2.Location = new System.Drawing.Point(231, 54);
            this.bootstrapButton2.MouseState = ModernUI.MouseState.HOVER;
            this.bootstrapButton2.Name = "bootstrapButton2";
            this.bootstrapButton2.Size = new System.Drawing.Size(63, 36);
            this.bootstrapButton2.TabIndex = 42;
            this.bootstrapButton2.Text = "Close";
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
            this.btnSave.Location = new System.Drawing.Point(170, 54);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNote
            // 
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Location = new System.Drawing.Point(30, 317);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(244, 99);
            this.txtNote.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mô tả:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 187);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 13);
            this.lblName.TabIndex = 38;
            this.lblName.Text = "Mã nhóm:";
            // 
            // productPath1
            // 
            this.productPath1.Location = new System.Drawing.Point(28, 139);
            this.productPath1.Name = "productPath1";
            this.productPath1.Size = new System.Drawing.Size(270, 28);
            this.productPath1.TabIndex = 236;
            // 
            // frmCreateSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 448);
            this.Controls.Add(this.productPath1);
            this.Controls.Add(this.lblNotify1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bootstrapButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Name = "frmCreateSub";
            this.Text = "Create Sub Product";
            this.Load += new System.EventHandler(this.frmCreateSub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolBoxCS.LabelNotify lblNotify1;
        private ToolBoxCS.TextBoxValidation txtName;
        private ToolBoxCS.TextBoxValidation txtCode;
        private System.Windows.Forms.Label label2;
        private ModernUI.Controls.BootstrapButton bootstrapButton2;
        private ModernUI.Controls.BootstrapButton btnSave;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private ToolBoxCS.ProductPath productPath1;
    }
}