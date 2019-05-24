namespace TmTech_v1.View
{
    partial class frmEditDepartment
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new ModernUI.Controls.BootstrapButton();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.cbbStaff = new TmTech_v1.ToolBoxCS.AutoSearchCombobox();
            this.txtNote = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtDepartmentName = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtDepartmentCode = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trưởng phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mô tả:";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Depth = 0;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(472, 24);
            this.btnClose.MouseState = ModernUI.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 36);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(411, 24);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelNotify1
            // 
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(223, 60);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(62, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 11;
            this.labelNotify1.Text = "labelNotify1";
            // 
            // cbbStaff
            // 
            this.cbbStaff.BindingFor = "Department";
            this.cbbStaff.BindingName = "HeaderId";
            this.cbbStaff.FormattingEnabled = true;
            this.cbbStaff.ItemHeight = 13;
            this.cbbStaff.Location = new System.Drawing.Point(59, 158);
            this.cbbStaff.Name = "cbbStaff";
            this.cbbStaff.Size = new System.Drawing.Size(208, 21);
            this.cbbStaff.TabIndex = 10;
            // 
            // txtNote
            // 
            this.txtNote.BindingFor = "Department";
            this.txtNote.BindingName = "Note";
            this.txtNote.ForeColor = System.Drawing.Color.Black;
            this.txtNote.Location = new System.Drawing.Point(59, 210);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(476, 91);
            this.txtNote.TabIndex = 7;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.BindingFor = "Department";
            this.txtDepartmentName.BindingName = "DepartmentName";
            this.txtDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentName.ForeColor = System.Drawing.Color.Black;
            this.txtDepartmentName.Location = new System.Drawing.Point(327, 100);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(208, 20);
            this.txtDepartmentName.TabIndex = 3;
            // 
            // txtDepartmentCode
            // 
            this.txtDepartmentCode.BindingFor = "Department";
            this.txtDepartmentCode.BindingName = "DepartmentCode";
            this.txtDepartmentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentCode.ForeColor = System.Drawing.Color.Black;
            this.txtDepartmentCode.Location = new System.Drawing.Point(59, 100);
            this.txtDepartmentCode.Name = "txtDepartmentCode";
            this.txtDepartmentCode.Size = new System.Drawing.Size(208, 20);
            this.txtDepartmentCode.TabIndex = 1;
            // 
            // frmEditDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 321);
            this.Controls.Add(this.labelNotify1);
            this.Controls.Add(this.cbbStaff);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDepartmentCode);
            this.Controls.Add(this.label1);
            this.Name = "frmEditDepartment";
            this.Resizable = false;
            this.Text = "Chỉnh sửa phòng ban";
            this.Load += new System.EventHandler(this.frmEditDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ToolBoxCS.TextBoxValidation txtDepartmentCode;
        private System.Windows.Forms.Label label2;
        private ToolBoxCS.TextBoxValidation txtDepartmentName;
        private System.Windows.Forms.Label label3;
        private ToolBoxCS.TextBoxValidation txtNote;
        private System.Windows.Forms.Label label4;
        private ModernUI.Controls.BootstrapButton btnClose;
        private ModernUI.Controls.BootstrapButton btnSave;
        private ToolBoxCS.AutoSearchCombobox cbbStaff;
        private ToolBoxCS.LabelNotify labelNotify1;
    }
}