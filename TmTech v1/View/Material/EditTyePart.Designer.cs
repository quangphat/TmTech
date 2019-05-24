namespace TmTech_v1.View.Material
{
    partial class EditTyePart
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnClose = new ModernUI.Controls.BootstrapButton();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupSeriesPart = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxValidation13 = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxValidation9 = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.textBoxValidation8 = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxValidation7 = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.textBoxValidation5 = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.textBoxValidation6 = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.groupTypePart = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxValidation3 = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.textBoxValidation10 = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.textBoxValidation11 = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.textBoxValidation4 = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.label4 = new System.Windows.Forms.Label();
            this.groupGroupPart = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxValidation12 = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.textBoxValidation2 = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.textBoxValidation1 = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.lblNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupSeriesPart.SuspendLayout();
            this.groupTypePart.SuspendLayout();
            this.groupGroupPart.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(23, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn loại Thêm mới";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(314, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Series part";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.seriespartshow);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(192, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Type part";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.typepartshow);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(58, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Group part";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.grouppartshow);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Depth = 0;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(576, 12);
            this.btnClose.MouseState = ModernUI.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 36);
            this.btnClose.TabIndex = 294;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(507, 12);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 293;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupSeriesPart);
            this.flowLayoutPanel1.Controls.Add(this.groupTypePart);
            this.flowLayoutPanel1.Controls.Add(this.groupGroupPart);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 146);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(477, 423);
            this.flowLayoutPanel1.TabIndex = 295;
            // 
            // groupSeriesPart
            // 
            this.groupSeriesPart.Controls.Add(this.label12);
            this.groupSeriesPart.Controls.Add(this.label9);
            this.groupSeriesPart.Controls.Add(this.label8);
            this.groupSeriesPart.Controls.Add(this.label7);
            this.groupSeriesPart.Controls.Add(this.textBoxValidation13);
            this.groupSeriesPart.Controls.Add(this.label5);
            this.groupSeriesPart.Controls.Add(this.textBoxValidation9);
            this.groupSeriesPart.Controls.Add(this.textBoxValidation8);
            this.groupSeriesPart.Controls.Add(this.label6);
            this.groupSeriesPart.Controls.Add(this.textBoxValidation7);
            this.groupSeriesPart.Controls.Add(this.textBoxValidation5);
            this.groupSeriesPart.Controls.Add(this.textBoxValidation6);
            this.groupSeriesPart.Location = new System.Drawing.Point(3, 3);
            this.groupSeriesPart.Name = "groupSeriesPart";
            this.groupSeriesPart.Size = new System.Drawing.Size(458, 183);
            this.groupSeriesPart.TabIndex = 2;
            this.groupSeriesPart.TabStop = false;
            this.groupSeriesPart.Text = "Thông tin series part";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ghi  chú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ghi  chú";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Series code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên series part";
            // 
            // textBoxValidation13
            // 
            this.textBoxValidation13.BindingFor = "SeriesPart";
            this.textBoxValidation13.BindingName = "SeriesPartId";
            this.textBoxValidation13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxValidation13.Location = new System.Drawing.Point(136, 162);
            this.textBoxValidation13.Name = "textBoxValidation13";
            this.textBoxValidation13.Size = new System.Drawing.Size(263, 20);
            this.textBoxValidation13.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "TypePartId";
            // 
            // textBoxValidation9
            // 
            this.textBoxValidation9.BindingFor = "SeriesPart";
            this.textBoxValidation9.BindingName = "Note";
            this.textBoxValidation9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxValidation9.Location = new System.Drawing.Point(136, 138);
            this.textBoxValidation9.Name = "textBoxValidation9";
            this.textBoxValidation9.Size = new System.Drawing.Size(263, 20);
            this.textBoxValidation9.TabIndex = 0;
            // 
            // textBoxValidation8
            // 
            this.textBoxValidation8.BindingFor = "SeriesPart";
            this.textBoxValidation8.BindingName = "SeriesPartCode";
            this.textBoxValidation8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxValidation8.Location = new System.Drawing.Point(136, 108);
            this.textBoxValidation8.Name = "textBoxValidation8";
            this.textBoxValidation8.Size = new System.Drawing.Size(263, 20);
            this.textBoxValidation8.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "GroupPartID";
            // 
            // textBoxValidation7
            // 
            this.textBoxValidation7.BindingFor = "SeriesPart";
            this.textBoxValidation7.BindingName = "SeriesPartName";
            this.textBoxValidation7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxValidation7.Location = new System.Drawing.Point(136, 82);
            this.textBoxValidation7.Name = "textBoxValidation7";
            this.textBoxValidation7.Size = new System.Drawing.Size(263, 20);
            this.textBoxValidation7.TabIndex = 0;
            // 
            // textBoxValidation5
            // 
            this.textBoxValidation5.BindingFor = "SeriesPart";
            this.textBoxValidation5.BindingName = "TypePartId";
            this.textBoxValidation5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxValidation5.Location = new System.Drawing.Point(136, 56);
            this.textBoxValidation5.Name = "textBoxValidation5";
            this.textBoxValidation5.Size = new System.Drawing.Size(263, 20);
            this.textBoxValidation5.TabIndex = 0;
            // 
            // textBoxValidation6
            // 
            this.textBoxValidation6.BindingFor = "SeriesPart";
            this.textBoxValidation6.BindingName = "GroupPartId";
            this.textBoxValidation6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxValidation6.Location = new System.Drawing.Point(136, 19);
            this.textBoxValidation6.Name = "textBoxValidation6";
            this.textBoxValidation6.Size = new System.Drawing.Size(263, 20);
            this.textBoxValidation6.TabIndex = 0;
            // 
            // groupTypePart
            // 
            this.groupTypePart.Controls.Add(this.label3);
            this.groupTypePart.Controls.Add(this.label10);
            this.groupTypePart.Controls.Add(this.label11);
            this.groupTypePart.Controls.Add(this.textBoxValidation3);
            this.groupTypePart.Controls.Add(this.textBoxValidation10);
            this.groupTypePart.Controls.Add(this.textBoxValidation11);
            this.groupTypePart.Controls.Add(this.textBoxValidation4);
            this.groupTypePart.Controls.Add(this.label4);
            this.groupTypePart.Location = new System.Drawing.Point(3, 192);
            this.groupTypePart.Name = "groupTypePart";
            this.groupTypePart.Size = new System.Drawing.Size(458, 130);
            this.groupTypePart.TabIndex = 3;
            this.groupTypePart.TabStop = false;
            this.groupTypePart.Text = "Thông tin Type part";
            this.groupTypePart.Enter += new System.EventHandler(this.groupTypePart_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ghi  chú";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Type part code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Tên type part";
            // 
            // textBoxValidation3
            // 
            this.textBoxValidation3.BindingFor = "TypePart";
            this.textBoxValidation3.BindingName = "Note";
            this.textBoxValidation3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxValidation3.Location = new System.Drawing.Point(136, 108);
            this.textBoxValidation3.Name = "textBoxValidation3";
            this.textBoxValidation3.Size = new System.Drawing.Size(263, 20);
            this.textBoxValidation3.TabIndex = 2;
            // 
            // textBoxValidation10
            // 
            this.textBoxValidation10.BindingFor = "TypePart";
            this.textBoxValidation10.BindingName = "TypePartCode";
            this.textBoxValidation10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxValidation10.Location = new System.Drawing.Point(136, 78);
            this.textBoxValidation10.Name = "textBoxValidation10";
            this.textBoxValidation10.Size = new System.Drawing.Size(263, 20);
            this.textBoxValidation10.TabIndex = 3;
            // 
            // textBoxValidation11
            // 
            this.textBoxValidation11.BindingFor = "TypePart";
            this.textBoxValidation11.BindingName = "TypePartName";
            this.textBoxValidation11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxValidation11.Location = new System.Drawing.Point(136, 52);
            this.textBoxValidation11.Name = "textBoxValidation11";
            this.textBoxValidation11.Size = new System.Drawing.Size(263, 20);
            this.textBoxValidation11.TabIndex = 4;
            // 
            // textBoxValidation4
            // 
            this.textBoxValidation4.BindingFor = "TypePart";
            this.textBoxValidation4.BindingName = "TypePartID";
            this.textBoxValidation4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxValidation4.Location = new System.Drawing.Point(136, 19);
            this.textBoxValidation4.Name = "textBoxValidation4";
            this.textBoxValidation4.Size = new System.Drawing.Size(263, 20);
            this.textBoxValidation4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "GroupPartID";
            // 
            // groupGroupPart
            // 
            this.groupGroupPart.Controls.Add(this.label2);
            this.groupGroupPart.Controls.Add(this.label1);
            this.groupGroupPart.Controls.Add(this.textBoxValidation12);
            this.groupGroupPart.Controls.Add(this.textBoxValidation2);
            this.groupGroupPart.Controls.Add(this.textBoxValidation1);
            this.groupGroupPart.Location = new System.Drawing.Point(3, 328);
            this.groupGroupPart.Name = "groupGroupPart";
            this.groupGroupPart.Size = new System.Drawing.Size(458, 101);
            this.groupGroupPart.TabIndex = 4;
            this.groupGroupPart.TabStop = false;
            this.groupGroupPart.Text = "Thông tin group part";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group partcode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên nhóm";
            // 
            // textBoxValidation12
            // 
            this.textBoxValidation12.BindingFor = "GroupPart";
            this.textBoxValidation12.BindingName = "GroupPartId";
            this.textBoxValidation12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxValidation12.Location = new System.Drawing.Point(145, 81);
            this.textBoxValidation12.Name = "textBoxValidation12";
            this.textBoxValidation12.Size = new System.Drawing.Size(263, 20);
            this.textBoxValidation12.TabIndex = 0;
            // 
            // textBoxValidation2
            // 
            this.textBoxValidation2.BindingFor = "GroupPart";
            this.textBoxValidation2.BindingName = "GroupPartCode";
            this.textBoxValidation2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxValidation2.Location = new System.Drawing.Point(145, 56);
            this.textBoxValidation2.Name = "textBoxValidation2";
            this.textBoxValidation2.Size = new System.Drawing.Size(263, 20);
            this.textBoxValidation2.TabIndex = 0;
            // 
            // textBoxValidation1
            // 
            this.textBoxValidation1.BindingFor = "GroupPart";
            this.textBoxValidation1.BindingName = "GroupPartName";
            this.textBoxValidation1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxValidation1.Location = new System.Drawing.Point(136, 19);
            this.textBoxValidation1.Name = "textBoxValidation1";
            this.textBoxValidation1.Size = new System.Drawing.Size(263, 20);
            this.textBoxValidation1.TabIndex = 0;
            // 
            // lblNotify1
            // 
            this.lblNotify1.AutoSize = true;
            this.lblNotify1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify1.Location = new System.Drawing.Point(191, 37);
            this.lblNotify1.Name = "lblNotify1";
            this.lblNotify1.Size = new System.Drawing.Size(79, 16);
            this.lblNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.lblNotify1.TabIndex = 376;
            this.lblNotify1.Text = "labelNotify1";
            // 
            // EditTyePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 431);
            this.Controls.Add(this.lblNotify1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditTyePart";
            this.Text = "AddTypePart";
            this.Load += new System.EventHandler(this.EditTyePart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupSeriesPart.ResumeLayout(false);
            this.groupSeriesPart.PerformLayout();
            this.groupTypePart.ResumeLayout(false);
            this.groupTypePart.PerformLayout();
            this.groupGroupPart.ResumeLayout(false);
            this.groupGroupPart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private ModernUI.Controls.BootstrapButton btnClose;
        private ModernUI.Controls.BootstrapButton btnSave;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupSeriesPart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ToolBoxCS.TextBoxValidation textBoxValidation5;
        private ToolBoxCS.TextBoxValidation textBoxValidation6;
        private System.Windows.Forms.GroupBox groupTypePart;
        private System.Windows.Forms.GroupBox groupGroupPart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ToolBoxCS.TextBoxValidation textBoxValidation2;
        private ToolBoxCS.TextBoxValidation textBoxValidation1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private ToolBoxCS.TextBoxValidation textBoxValidation8;
        private ToolBoxCS.TextBoxValidation textBoxValidation7;
        private System.Windows.Forms.Label label9;
        private ToolBoxCS.TextBoxValidation textBoxValidation9;
        private ToolBoxCS.TextBoxValidation textBoxValidation4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private ToolBoxCS.TextBoxValidation textBoxValidation3;
        private ToolBoxCS.TextBoxValidation textBoxValidation10;
        private ToolBoxCS.TextBoxValidation textBoxValidation11;
        private ToolBoxCS.TextBoxValidation textBoxValidation12;
        private System.Windows.Forms.Label label12;
        private ToolBoxCS.TextBoxValidation textBoxValidation13;
        private ToolBoxCS.LabelNotify lblNotify1;
    }
}