namespace TmTech_v1.View
{
    partial class frmEditProject
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
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.btnCancel = new ModernUI.Controls.BootstrapButton();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cbbStatus = new TmTech_v1.ToolBoxCS.AutoSearchCombobox();
            this.cbbCompany = new TmTech_v1.ToolBoxCS.AutoSearchCombobox();
            this.cbbSale = new TmTech_v1.ToolBoxCS.AutoSearchCombobox();
            this.txtDrawingName = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtProjectName = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtProjectCode = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateEnd = new TmTech_v1.ToolBoxCS.AutoXDatetime();
            this.dtpDateBegin = new TmTech_v1.ToolBoxCS.AutoXDatetime();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateBegin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNotify1
            // 
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(368, 61);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(62, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 30;
            this.labelNotify1.Text = "labelNotify1";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(816, 25);
            this.btnCancel.MouseState = ModernUI.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 28;
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
            this.btnSave.Location = new System.Drawing.Point(755, 25);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(319, 156);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 13);
            this.linkLabel1.TabIndex = 47;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Chọn...";
            // 
            // cbbStatus
            // 
            this.cbbStatus.BindingFor = "Project";
            this.cbbStatus.BindingName = "StatusId";
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(705, 198);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(184, 21);
            this.cbbStatus.TabIndex = 40;
            // 
            // cbbCompany
            // 
            this.cbbCompany.BindingFor = "Project";
            this.cbbCompany.BindingName = "CompanyId";
            this.cbbCompany.FormattingEnabled = true;
            this.cbbCompany.Location = new System.Drawing.Point(678, 108);
            this.cbbCompany.Name = "cbbCompany";
            this.cbbCompany.Size = new System.Drawing.Size(211, 21);
            this.cbbCompany.TabIndex = 41;
            // 
            // cbbSale
            // 
            this.cbbSale.BindingFor = "Project";
            this.cbbSale.BindingName = "Sale";
            this.cbbSale.FormattingEnabled = true;
            this.cbbSale.Location = new System.Drawing.Point(678, 153);
            this.cbbSale.Name = "cbbSale";
            this.cbbSale.Size = new System.Drawing.Size(211, 21);
            this.cbbSale.TabIndex = 45;
            // 
            // txtDrawingName
            // 
            this.txtDrawingName.BindingFor = "Project";
            this.txtDrawingName.BindingName = "DrawingName";
            this.txtDrawingName.ForeColor = System.Drawing.Color.Black;
            this.txtDrawingName.Location = new System.Drawing.Point(101, 153);
            this.txtDrawingName.Name = "txtDrawingName";
            this.txtDrawingName.ReadOnly = true;
            this.txtDrawingName.Size = new System.Drawing.Size(184, 20);
            this.txtDrawingName.TabIndex = 42;
            // 
            // txtProjectName
            // 
            this.txtProjectName.BindingFor = "Project";
            this.txtProjectName.BindingName = "ProjectName";
            this.txtProjectName.ForeColor = System.Drawing.Color.Black;
            this.txtProjectName.Location = new System.Drawing.Point(381, 108);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(228, 20);
            this.txtProjectName.TabIndex = 39;
            // 
            // txtProjectCode
            // 
            this.txtProjectCode.BindingFor = "Project";
            this.txtProjectCode.BindingName = "ProjectCode";
            this.txtProjectCode.ForeColor = System.Drawing.Color.Black;
            this.txtProjectCode.Location = new System.Drawing.Point(101, 108);
            this.txtProjectCode.Name = "txtProjectCode";
            this.txtProjectCode.ReadOnly = true;
            this.txtProjectCode.Size = new System.Drawing.Size(184, 20);
            this.txtProjectCode.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tên bản vẽ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(644, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Tình trạng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(629, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Công ty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên dự án";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(644, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Sale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã dự án";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.BindingFor = "Project";
            this.dtpDateEnd.BindingName = "DateEnd";
            this.dtpDateEnd.EditValue = null;
            this.dtpDateEnd.Location = new System.Drawing.Point(416, 198);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDateEnd.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.dtpDateEnd.Size = new System.Drawing.Size(184, 20);
            this.dtpDateEnd.TabIndex = 51;
            // 
            // dtpDateBegin
            // 
            this.dtpDateBegin.BindingFor = "Project";
            this.dtpDateBegin.BindingName = "DateBegin";
            this.dtpDateBegin.EditValue = null;
            this.dtpDateBegin.Location = new System.Drawing.Point(101, 198);
            this.dtpDateBegin.Name = "dtpDateBegin";
            this.dtpDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDateBegin.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.dtpDateBegin.Size = new System.Drawing.Size(184, 20);
            this.dtpDateBegin.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // frmEditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 243);
            this.Controls.Add(this.dtpDateEnd);
            this.Controls.Add(this.dtpDateBegin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNotify1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "frmEditProject";
            this.Resizable = false;
            this.Text = "Cập nhật dự án";
            this.Load += new System.EventHandler(this.frmEditProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateBegin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolBoxCS.LabelNotify labelNotify1;
        private ModernUI.Controls.BootstrapButton btnCancel;
        private ModernUI.Controls.BootstrapButton btnSave;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private ToolBoxCS.AutoSearchCombobox cbbStatus;
        private ToolBoxCS.AutoSearchCombobox cbbCompany;
        private ToolBoxCS.AutoSearchCombobox cbbSale;
        private ToolBoxCS.TextBoxValidation txtDrawingName;
        private ToolBoxCS.TextBoxValidation txtProjectName;
        private ToolBoxCS.TextBoxValidation txtProjectCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private ToolBoxCS.AutoXDatetime dtpDateEnd;
        private ToolBoxCS.AutoXDatetime dtpDateBegin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}