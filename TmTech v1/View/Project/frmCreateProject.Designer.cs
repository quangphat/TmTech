namespace TmTech_v1.View
{
    partial class frmCreateProject
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
            this.btnCreate = new ModernUI.Controls.BootstrapButton();
            this.btnCancel = new ModernUI.Controls.BootstrapButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dtpDateEnd = new TmTech_v1.ToolBoxCS.AutoXDatetime();
            this.dtpDateBegin = new TmTech_v1.ToolBoxCS.AutoXDatetime();
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.cbbStatus = new TmTech_v1.ToolBoxCS.AutoSearchCombobox();
            this.cbbCompany = new TmTech_v1.ToolBoxCS.AutoSearchCombobox();
            this.cbbSale = new TmTech_v1.ToolBoxCS.AutoSearchCombobox();
            this.txtDrawingName = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtProjectName = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtProjectCode = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateBegin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = true;
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Depth = 0;
            this.btnCreate.Icon = null;
            this.btnCreate.Location = new System.Drawing.Point(779, 24);
            this.btnCreate.MouseState = ModernUI.MouseState.HOVER;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(55, 36);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Save";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(840, 24);
            this.btnCancel.MouseState = ModernUI.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã dự án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên dự án";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên bản vẽ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày kết thúc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(662, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sale";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(647, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Công ty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(662, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tình trạng";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(337, 145);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Chọn...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PNG(*.png)|*.png|JPEG (*.jpeg)|*.jpeg|All (*.*)|*.*";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.BindingFor = "Project";
            this.dtpDateEnd.BindingName = "DateEnd";
            this.dtpDateEnd.EditValue = null;
            this.dtpDateEnd.Location = new System.Drawing.Point(434, 187);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDateEnd.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.dtpDateEnd.Size = new System.Drawing.Size(184, 20);
            this.dtpDateEnd.TabIndex = 6;
            // 
            // dtpDateBegin
            // 
            this.dtpDateBegin.BindingFor = "Project";
            this.dtpDateBegin.BindingName = "DateBegin";
            this.dtpDateBegin.EditValue = null;
            this.dtpDateBegin.Location = new System.Drawing.Point(119, 187);
            this.dtpDateBegin.Name = "dtpDateBegin";
            this.dtpDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDateBegin.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.dtpDateBegin.Size = new System.Drawing.Size(184, 20);
            this.dtpDateBegin.TabIndex = 5;
            // 
            // labelNotify1
            // 
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(396, 60);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(62, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 11;
            this.labelNotify1.Text = "labelNotify1";
            // 
            // cbbStatus
            // 
            this.cbbStatus.BindingFor = "Project";
            this.cbbStatus.BindingName = "StatusId";
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(723, 187);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(184, 21);
            this.cbbStatus.TabIndex = 3;
            // 
            // cbbCompany
            // 
            this.cbbCompany.BindingFor = "Project";
            this.cbbCompany.BindingName = "CompanyId";
            this.cbbCompany.FormattingEnabled = true;
            this.cbbCompany.Location = new System.Drawing.Point(696, 97);
            this.cbbCompany.Name = "cbbCompany";
            this.cbbCompany.Size = new System.Drawing.Size(211, 21);
            this.cbbCompany.TabIndex = 3;
            this.cbbCompany.SelectedValueChanged += new System.EventHandler(this.cbbCompany_SelectedValueChanged);
            // 
            // cbbSale
            // 
            this.cbbSale.BindingFor = "Project";
            this.cbbSale.BindingName = "Sale";
            this.cbbSale.FormattingEnabled = true;
            this.cbbSale.Location = new System.Drawing.Point(696, 142);
            this.cbbSale.Name = "cbbSale";
            this.cbbSale.Size = new System.Drawing.Size(211, 21);
            this.cbbSale.TabIndex = 7;
            // 
            // txtDrawingName
            // 
            this.txtDrawingName.BindingFor = "Project";
            this.txtDrawingName.BindingName = "DrawingName";
            this.txtDrawingName.ForeColor = System.Drawing.Color.Black;
            this.txtDrawingName.Location = new System.Drawing.Point(119, 142);
            this.txtDrawingName.Name = "txtDrawingName";
            this.txtDrawingName.ReadOnly = true;
            this.txtDrawingName.Size = new System.Drawing.Size(184, 20);
            this.txtDrawingName.TabIndex = 4;
            // 
            // txtProjectName
            // 
            this.txtProjectName.BindingFor = "Project";
            this.txtProjectName.BindingName = "ProjectName";
            this.txtProjectName.ForeColor = System.Drawing.Color.Black;
            this.txtProjectName.Location = new System.Drawing.Point(399, 97);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(228, 20);
            this.txtProjectName.TabIndex = 2;
            // 
            // txtProjectCode
            // 
            this.txtProjectCode.BindingFor = "Project";
            this.txtProjectCode.BindingName = "ProjectCode";
            this.txtProjectCode.ForeColor = System.Drawing.Color.Black;
            this.txtProjectCode.Location = new System.Drawing.Point(119, 97);
            this.txtProjectCode.Name = "txtProjectCode";
            this.txtProjectCode.ReadOnly = true;
            this.txtProjectCode.Size = new System.Drawing.Size(184, 20);
            this.txtProjectCode.TabIndex = 10;
            // 
            // frmCreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 235);
            this.Controls.Add(this.dtpDateEnd);
            this.Controls.Add(this.dtpDateBegin);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelNotify1);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.cbbCompany);
            this.Controls.Add(this.cbbSale);
            this.Controls.Add(this.txtDrawingName);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtProjectCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Name = "frmCreateProject";
            this.Resizable = false;
            this.Text = "Thêm dự án";
            this.Load += new System.EventHandler(this.frmCreateProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateBegin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModernUI.Controls.BootstrapButton btnCreate;
        private ModernUI.Controls.BootstrapButton btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ToolBoxCS.TextBoxValidation txtProjectCode;
        private ToolBoxCS.TextBoxValidation txtProjectName;
        private ToolBoxCS.TextBoxValidation txtDrawingName;
        private ToolBoxCS.AutoSearchCombobox cbbSale;
        private System.Windows.Forms.Label label7;
        private ToolBoxCS.AutoSearchCombobox cbbCompany;
        private System.Windows.Forms.Label label8;
        private ToolBoxCS.AutoSearchCombobox cbbStatus;
        private ToolBoxCS.LabelNotify labelNotify1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ToolBoxCS.AutoXDatetime dtpDateBegin;
        private ToolBoxCS.AutoXDatetime dtpDateEnd;
    }
}