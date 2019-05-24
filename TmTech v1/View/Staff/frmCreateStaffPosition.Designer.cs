namespace TmTech_v1.View
{
    partial class frmCreateStaffPosition
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
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxValidation1 = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.textBoxValidation2 = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.btnCancel = new ModernUI.Controls.BootstrapButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chức vụ";
            // 
            // labelNotify1
            // 
            this.labelNotify1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(247, 60);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(62, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 1;
            this.labelNotify1.Text = "labelNotify1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên chức vụ";
            // 
            // textBoxValidation1
            // 
            this.textBoxValidation1.BindingFor = "StaffPosition";
            this.textBoxValidation1.BindingName = "StaffPositionCode";
            this.textBoxValidation1.ForeColor = System.Drawing.Color.Black;
            this.textBoxValidation1.Location = new System.Drawing.Point(85, 115);
            this.textBoxValidation1.Name = "textBoxValidation1";
            this.textBoxValidation1.Size = new System.Drawing.Size(192, 20);
            this.textBoxValidation1.TabIndex = 2;
            // 
            // textBoxValidation2
            // 
            this.textBoxValidation2.BindingFor = "StaffPosition";
            this.textBoxValidation2.BindingName = "StaffPositionName";
            this.textBoxValidation2.ForeColor = System.Drawing.Color.Black;
            this.textBoxValidation2.Location = new System.Drawing.Point(339, 115);
            this.textBoxValidation2.Name = "textBoxValidation2";
            this.textBoxValidation2.Size = new System.Drawing.Size(192, 20);
            this.textBoxValidation2.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(401, 21);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(462, 21);
            this.btnCancel.MouseState = ModernUI.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCreateStaffPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 160);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxValidation2);
            this.Controls.Add(this.textBoxValidation1);
            this.Controls.Add(this.labelNotify1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateStaffPosition";
            this.Resizable = false;
            this.Text = "Thêm chức vụ mới";
            this.Load += new System.EventHandler(this.frmCreateStaffPosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ToolBoxCS.LabelNotify labelNotify1;
        private System.Windows.Forms.Label label2;
        private ToolBoxCS.TextBoxValidation textBoxValidation1;
        private ToolBoxCS.TextBoxValidation textBoxValidation2;
        private ModernUI.Controls.BootstrapButton btnSave;
        private ModernUI.Controls.BootstrapButton btnCancel;
    }
}