namespace TmTech_v1.View
{
    partial class frmChooseToCreate
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
            this.rbtnBank = new System.Windows.Forms.RadioButton();
            this.rbtnBranch = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new ModernUI.Controls.BootstrapButton();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbBank = new TmTech_v1.ToolBoxCS.AutoSearchCombobox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnBank
            // 
            this.rbtnBank.AutoSize = true;
            this.rbtnBank.Checked = true;
            this.rbtnBank.Location = new System.Drawing.Point(7, 19);
            this.rbtnBank.Name = "rbtnBank";
            this.rbtnBank.Size = new System.Drawing.Size(78, 17);
            this.rbtnBank.TabIndex = 2;
            this.rbtnBank.TabStop = true;
            this.rbtnBank.Text = "Ngân hàng";
            this.rbtnBank.UseVisualStyleBackColor = true;
            this.rbtnBank.CheckedChanged += new System.EventHandler(this.rbtnBank_CheckedChanged);
            // 
            // rbtnBranch
            // 
            this.rbtnBranch.AutoSize = true;
            this.rbtnBranch.Location = new System.Drawing.Point(91, 19);
            this.rbtnBranch.Name = "rbtnBranch";
            this.rbtnBranch.Size = new System.Drawing.Size(73, 17);
            this.rbtnBranch.TabIndex = 2;
            this.rbtnBranch.Text = "Chi nhánh";
            this.rbtnBranch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnBank);
            this.groupBox1.Controls.Add(this.rbtnBranch);
            this.groupBox1.Location = new System.Drawing.Point(51, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 45);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm mới:";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(295, 43);
            this.btnCancel.MouseState = ModernUI.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(234, 43);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Thuộc ngân hàng:";
            this.label1.Visible = false;
            // 
            // cbbBank
            // 
            this.cbbBank.BindingFor = "Bank";
            this.cbbBank.BindingName = "BankId";
            this.cbbBank.FormattingEnabled = true;
            this.cbbBank.Location = new System.Drawing.Point(67, 162);
            this.cbbBank.Name = "cbbBank";
            this.cbbBank.Size = new System.Drawing.Size(222, 21);
            this.cbbBank.TabIndex = 14;
            this.cbbBank.Visible = false;
            // 
            // frmChooseToCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 206);
            this.Controls.Add(this.cbbBank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChooseToCreate";
            this.Resizable = false;
            this.Text = "Chọn chức năng";
            this.Load += new System.EventHandler(this.frmChooseToCreate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnBank;
        private System.Windows.Forms.RadioButton rbtnBranch;
        private System.Windows.Forms.GroupBox groupBox1;
        private ModernUI.Controls.BootstrapButton btnCancel;
        private ModernUI.Controls.BootstrapButton btnSave;
        private System.Windows.Forms.Label label1;
        private ToolBoxCS.AutoSearchCombobox cbbBank;
    }
}