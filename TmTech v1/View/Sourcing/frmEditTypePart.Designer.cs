namespace TmTech_v1.View
{
    partial class frmEditTypePart
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.txtName = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtCode = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.label2 = new System.Windows.Forms.Label();
            this.bootstrapButton2 = new ModernUI.Controls.BootstrapButton();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtParrentName = new TmTech_v1.ToolBoxCS.DisplayText();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nhóm cha:";
            // 
            // lblNotify1
            // 
            this.lblNotify1.AutoSize = true;
            this.lblNotify1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify1.Location = new System.Drawing.Point(20, 109);
            this.lblNotify1.Name = "lblNotify1";
            this.lblNotify1.Size = new System.Drawing.Size(79, 16);
            this.lblNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.lblNotify1.TabIndex = 57;
            this.lblNotify1.Text = "labelNotify1";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(25, 266);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 26);
            this.txtName.TabIndex = 56;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.Location = new System.Drawing.Point(25, 209);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(243, 26);
            this.txtCode.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 54;
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
            this.bootstrapButton2.Location = new System.Drawing.Point(206, 63);
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
            this.btnSave.Location = new System.Drawing.Point(145, 63);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNote
            // 
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Location = new System.Drawing.Point(25, 322);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(244, 99);
            this.txtNote.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Mô tả:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 192);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 13);
            this.lblName.TabIndex = 49;
            this.lblName.Text = "Mã nhóm:";
            // 
            // txtParrentName
            // 
            this.txtParrentName.Location = new System.Drawing.Point(23, 151);
            this.txtParrentName.Name = "txtParrentName";
            this.txtParrentName.ReadOnly = true;
            this.txtParrentName.Size = new System.Drawing.Size(243, 20);
            this.txtParrentName.TabIndex = 60;
            // 
            // frmEditTypePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 447);
            this.Controls.Add(this.txtParrentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNotify1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bootstrapButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Name = "frmEditTypePart";
            this.Text = "Cập nhật nhóm con";
            this.Load += new System.EventHandler(this.frmEditSub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ToolBoxCS.LabelNotify lblNotify1;
        private ToolBoxCS.TextBoxValidation txtName;
        private ToolBoxCS.TextBoxValidation txtCode;
        private System.Windows.Forms.Label label2;
        private ModernUI.Controls.BootstrapButton bootstrapButton2;
        private ModernUI.Controls.BootstrapButton btnSave;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private ToolBoxCS.DisplayText txtParrentName;
    }
}