namespace TmTech_v1.View
{
    partial class frmCreateSerie
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
            this.label2 = new System.Windows.Forms.Label();
            this.bootstrapButton2 = new ModernUI.Controls.BootstrapButton();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.productPath1 = new TmTech_v1.ToolBoxCS.ProductPath();
            this.lblNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.txtName = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtCode = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtNote = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Tên serie:";
            // 
            // bootstrapButton2
            // 
            this.bootstrapButton2.AutoSize = true;
            this.bootstrapButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bootstrapButton2.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.bootstrapButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapButton2.Depth = 0;
            this.bootstrapButton2.Icon = null;
            this.bootstrapButton2.Location = new System.Drawing.Point(230, 63);
            this.bootstrapButton2.MouseState = ModernUI.MouseState.HOVER;
            this.bootstrapButton2.Name = "bootstrapButton2";
            this.bootstrapButton2.Size = new System.Drawing.Size(63, 36);
            this.bootstrapButton2.TabIndex = 53;
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
            this.btnSave.Location = new System.Drawing.Point(169, 63);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Mô tả:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 196);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 13);
            this.lblName.TabIndex = 49;
            this.lblName.Text = "Mã serie:";
            // 
            // productPath1
            // 
            this.productPath1.Location = new System.Drawing.Point(23, 152);
            this.productPath1.Name = "productPath1";
            this.productPath1.Size = new System.Drawing.Size(270, 28);
            this.productPath1.TabIndex = 235;
            // 
            // lblNotify1
            // 
            this.lblNotify1.AutoSize = true;
            this.lblNotify1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify1.Location = new System.Drawing.Point(24, 113);
            this.lblNotify1.Name = "lblNotify1";
            this.lblNotify1.Size = new System.Drawing.Size(79, 16);
            this.lblNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.lblNotify1.TabIndex = 57;
            this.lblNotify1.Text = "labelNotify1";
            // 
            // txtName
            // 
            this.txtName.BindingFor = "Series";
            this.txtName.BindingName = "SerieName";
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(29, 270);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 26);
            this.txtName.TabIndex = 56;
            // 
            // txtCode
            // 
            this.txtCode.BindingFor = "Series";
            this.txtCode.BindingName = "SerieCode";
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.Location = new System.Drawing.Point(29, 213);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(243, 26);
            this.txtCode.TabIndex = 55;
            // 
            // txtNote
            // 
            this.txtNote.BindingFor = "Series";
            this.txtNote.BindingName = "Note";
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Location = new System.Drawing.Point(29, 326);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(244, 99);
            this.txtNote.TabIndex = 51;
            // 
            // frmCreateSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 493);
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
            this.Name = "frmCreateSerie";
            this.Text = "Create Class Product";
            this.Load += new System.EventHandler(this.frmCreateSerie_Load);
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
        private ToolBoxCS.AutoTextBox txtNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private ToolBoxCS.ProductPath productPath1;
    }
}