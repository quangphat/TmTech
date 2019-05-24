namespace TmTech_v1.View
{
    partial class frmProductPriceDetail
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpActiveDate = new ModernUI.Controls.MetroDateTime();
            this.label5 = new System.Windows.Forms.Label();
            this.cbActive = new ModernUI.Controls.MaterialCheckBox();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.btnCancel = new ModernUI.Controls.BootstrapButton();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreateBy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNote = new ModernUI.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbProdCode = new ModernUI.Controls.MetroSearchComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên giá";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(24, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 26);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sản phẩm";
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(404, 175);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(253, 26);
            this.txtProductName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên sản phẩm";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(24, 175);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(253, 26);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Tag = "money";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá";
            // 
            // dtpActiveDate
            // 
            this.dtpActiveDate.DisplayWeekNumbers = false;
            this.dtpActiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpActiveDate.Location = new System.Drawing.Point(24, 247);
            this.dtpActiveDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpActiveDate.Name = "dtpActiveDate";
            this.dtpActiveDate.Size = new System.Drawing.Size(253, 29);
            this.dtpActiveDate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày áp dụng";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Depth = 0;
            this.cbActive.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbActive.Location = new System.Drawing.Point(24, 305);
            this.cbActive.Margin = new System.Windows.Forms.Padding(0);
            this.cbActive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbActive.MouseState = ModernUI.MouseState.HOVER;
            this.cbActive.Name = "cbActive";
            this.cbActive.Ripple = true;
            this.cbActive.Size = new System.Drawing.Size(81, 30);
            this.cbActive.TabIndex = 10;
            this.cbActive.Text = "Áp dụng";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(722, 456);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(797, 456);
            this.btnCancel.MouseState = ModernUI.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Enabled = false;
            this.txtCreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateDate.Location = new System.Drawing.Point(404, 327);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(253, 26);
            this.txtCreateDate.TabIndex = 16;
            this.txtCreateDate.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ngày tạo";
            // 
            // txtCreateBy
            // 
            this.txtCreateBy.Enabled = false;
            this.txtCreateBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateBy.Location = new System.Drawing.Point(404, 248);
            this.txtCreateBy.Name = "txtCreateBy";
            this.txtCreateBy.Size = new System.Drawing.Size(253, 26);
            this.txtCreateBy.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Người tạo";
            // 
            // txtNote
            // 
            // 
            // 
            // 
            this.txtNote.CustomButton.Image = null;
            this.txtNote.CustomButton.Location = new System.Drawing.Point(575, 2);
            this.txtNote.CustomButton.Name = "";
            this.txtNote.CustomButton.Size = new System.Drawing.Size(52, 37);
            this.txtNote.CustomButton.Style = ModernUI.MetroColorStyle.Blue;
            this.txtNote.CustomButton.TabIndex = 1;
            this.txtNote.CustomButton.Theme = ModernUI.MetroThemeStyle.Light;
            this.txtNote.CustomButton.UseSelectable = true;
            this.txtNote.CustomButton.Visible = false;
            this.txtNote.Lines = new string[0];
            this.txtNote.Location = new System.Drawing.Point(27, 383);
            this.txtNote.MaxLength = 32767;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.PasswordChar = '\0';
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNote.SelectedText = "";
            this.txtNote.SelectionLength = 0;
            this.txtNote.SelectionStart = 0;
            this.txtNote.ShortcutsEnabled = true;
            this.txtNote.Size = new System.Drawing.Size(630, 42);
            this.txtNote.TabIndex = 17;
            this.txtNote.UseSelectable = true;
            this.txtNote.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNote.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mô tả";
            // 
            // cbbProdCode
            // 
            this.cbbProdCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbProdCode.FormattingEnabled = true;
            this.cbbProdCode.Location = new System.Drawing.Point(404, 96);
            this.cbbProdCode.Name = "cbbProdCode";
            this.cbbProdCode.Size = new System.Drawing.Size(253, 28);
            this.cbbProdCode.TabIndex = 19;
            this.cbbProdCode.SelectedValueChanged += new System.EventHandler(this.cbbProdCode_SelectedValueChanged);
            // 
            // frmProductPriceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 505);
            this.Controls.Add(this.cbbProdCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtCreateDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCreateBy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpActiveDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "frmProductPriceDetail";
            this.Text = "Chi tiết giá";
            this.Load += new System.EventHandler(this.frmProductPriceDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private ModernUI.Controls.MetroDateTime dtpActiveDate;
        private System.Windows.Forms.Label label5;
        private ModernUI.Controls.MaterialCheckBox cbActive;
        private ModernUI.Controls.BootstrapButton btnSave;
        private ModernUI.Controls.BootstrapButton btnCancel;
        private System.Windows.Forms.TextBox txtCreateDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCreateBy;
        private System.Windows.Forms.Label label7;
        private ModernUI.Controls.MetroTextBox txtNote;
        private System.Windows.Forms.Label label8;
        private ModernUI.Controls.MetroSearchComboBox cbbProdCode;
    }
}