namespace TmTech_v1.View
{
    partial class frmSuggest
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
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.btnPrint = new ModernUI.Controls.BootstrapButton();
            this.btnCancel = new ModernUI.Controls.BootstrapButton();
            this.cbbStaff = new TmTech_v1.ToolBoxCS.AutoSearchCombobox();
            this.cbbDepartment = new TmTech_v1.ToolBoxCS.AutoSearchCombobox();
            this.cbbPurpose = new TmTech_v1.ToolBoxCS.AutoSearchCombobox();
            this.txtReturnMoneyNumWrite = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.txtMoneyNumWrite = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.txtMoneyBack = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.txtMoneyOut = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.txtContent = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtBillNo = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtNo = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.labelNotify2 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.labelNotify3 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.labelNotify6 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.labelNotify8 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.labelNotify7 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.labelNotify10 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.labelNotify5 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.labelNotify9 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.labelNotify4 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(542, 10);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = true;
            this.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrint.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Info;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Depth = 0;
            this.btnPrint.Icon = null;
            this.btnPrint.Location = new System.Drawing.Point(476, 10);
            this.btnPrint.MouseState = ModernUI.MouseState.HOVER;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(60, 36);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(603, 10);
            this.btnCancel.MouseState = ModernUI.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbbStaff
            // 
            this.cbbStaff.BindingFor = "IncomeExpense";
            this.cbbStaff.BindingName = "StaffId";
            this.cbbStaff.FormattingEnabled = true;
            this.cbbStaff.Location = new System.Drawing.Point(306, 128);
            this.cbbStaff.Name = "cbbStaff";
            this.cbbStaff.Size = new System.Drawing.Size(148, 21);
            this.cbbStaff.TabIndex = 5;
            // 
            // cbbDepartment
            // 
            this.cbbDepartment.BindingFor = "IncomeExpense";
            this.cbbDepartment.BindingName = "DepartmentId";
            this.cbbDepartment.FormattingEnabled = true;
            this.cbbDepartment.Location = new System.Drawing.Point(74, 128);
            this.cbbDepartment.Name = "cbbDepartment";
            this.cbbDepartment.Size = new System.Drawing.Size(148, 21);
            this.cbbDepartment.TabIndex = 4;
            this.cbbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbbDepartment_SelectedIndexChanged);
            // 
            // cbbPurpose
            // 
            this.cbbPurpose.BindingFor = "IncomeExpense";
            this.cbbPurpose.BindingName = "PurposeSuggestionId";
            this.cbbPurpose.FormattingEnabled = true;
            this.cbbPurpose.Location = new System.Drawing.Point(533, 128);
            this.cbbPurpose.Name = "cbbPurpose";
            this.cbbPurpose.Size = new System.Drawing.Size(121, 21);
            this.cbbPurpose.TabIndex = 6;
            this.cbbPurpose.SelectedIndexChanged += new System.EventHandler(this.cbbPurpose_SelectedIndexChanged);
            // 
            // txtReturnMoneyNumWrite
            // 
            this.txtReturnMoneyNumWrite.BindingFor = "Suggestion";
            this.txtReturnMoneyNumWrite.BindingName = "ReturnMoneyNumWrite";
            this.txtReturnMoneyNumWrite.Location = new System.Drawing.Point(340, 351);
            this.txtReturnMoneyNumWrite.Multiline = true;
            this.txtReturnMoneyNumWrite.Name = "txtReturnMoneyNumWrite";
            this.txtReturnMoneyNumWrite.ReadOnly = true;
            this.txtReturnMoneyNumWrite.Size = new System.Drawing.Size(314, 50);
            this.txtReturnMoneyNumWrite.TabIndex = 10;
            // 
            // txtMoneyNumWrite
            // 
            this.txtMoneyNumWrite.BindingFor = "Suggestion";
            this.txtMoneyNumWrite.BindingName = "MoneyNumWrite";
            this.txtMoneyNumWrite.Location = new System.Drawing.Point(340, 267);
            this.txtMoneyNumWrite.Multiline = true;
            this.txtMoneyNumWrite.Name = "txtMoneyNumWrite";
            this.txtMoneyNumWrite.ReadOnly = true;
            this.txtMoneyNumWrite.Size = new System.Drawing.Size(314, 50);
            this.txtMoneyNumWrite.TabIndex = 9;
            // 
            // txtMoneyBack
            // 
            this.txtMoneyBack.BindingFor = "IncomeExpense";
            this.txtMoneyBack.BindingName = "MoneyBack";
            this.txtMoneyBack.Location = new System.Drawing.Point(74, 351);
            this.txtMoneyBack.Name = "txtMoneyBack";
            this.txtMoneyBack.Size = new System.Drawing.Size(144, 20);
            this.txtMoneyBack.TabIndex = 9;
            this.txtMoneyBack.Tag = "money";
            this.txtMoneyBack.Text = "0";
            this.txtMoneyBack.TextChanged += new System.EventHandler(this.txtMoneyBack_TextChanged);
            this.txtMoneyBack.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoneyOut_KeyPress);
            // 
            // txtMoneyOut
            // 
            this.txtMoneyOut.BindingFor = "IncomeExpense";
            this.txtMoneyOut.BindingName = "MoneyOut";
            this.txtMoneyOut.Location = new System.Drawing.Point(74, 267);
            this.txtMoneyOut.Name = "txtMoneyOut";
            this.txtMoneyOut.Size = new System.Drawing.Size(144, 20);
            this.txtMoneyOut.TabIndex = 8;
            this.txtMoneyOut.Tag = "money";
            this.txtMoneyOut.Text = "0";
            this.txtMoneyOut.TextChanged += new System.EventHandler(this.txtMoneyOut_TextChanged);
            this.txtMoneyOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoneyOut_KeyPress);
            // 
            // txtContent
            // 
            this.txtContent.BindingFor = "IncomeExpense";
            this.txtContent.BindingName = "Content";
            this.txtContent.ForeColor = System.Drawing.Color.Black;
            this.txtContent.Location = new System.Drawing.Point(74, 183);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(580, 68);
            this.txtContent.TabIndex = 7;
            // 
            // txtBillNo
            // 
            this.txtBillNo.BindingFor = "IncomeExpense";
            this.txtBillNo.BindingName = "BillNo";
            this.txtBillNo.ForeColor = System.Drawing.Color.Black;
            this.txtBillNo.Location = new System.Drawing.Point(306, 92);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(148, 20);
            this.txtBillNo.TabIndex = 3;
            // 
            // txtNo
            // 
            this.txtNo.BindingFor = "IncomeExpense";
            this.txtNo.BindingName = "No";
            this.txtNo.ForeColor = System.Drawing.Color.Black;
            this.txtNo.Location = new System.Drawing.Point(74, 92);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(148, 20);
            this.txtNo.TabIndex = 2;
            // 
            // labelNotify2
            // 
            this.labelNotify2.AutoSize = true;
            this.labelNotify2.Location = new System.Drawing.Point(473, 131);
            this.labelNotify2.Name = "labelNotify2";
            this.labelNotify2.Size = new System.Drawing.Size(54, 13);
            this.labelNotify2.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify2.TabIndex = 0;
            this.labelNotify2.Text = "Mục đích";
            // 
            // labelNotify3
            // 
            this.labelNotify3.AutoSize = true;
            this.labelNotify3.Location = new System.Drawing.Point(21, 131);
            this.labelNotify3.Name = "labelNotify3";
            this.labelNotify3.Size = new System.Drawing.Size(47, 13);
            this.labelNotify3.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify3.TabIndex = 0;
            this.labelNotify3.Text = "Bộ phận";
            // 
            // labelNotify6
            // 
            this.labelNotify6.AutoSize = true;
            this.labelNotify6.Location = new System.Drawing.Point(246, 270);
            this.labelNotify6.Name = "labelNotify6";
            this.labelNotify6.Size = new System.Drawing.Size(88, 13);
            this.labelNotify6.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify6.TabIndex = 0;
            this.labelNotify6.Text = "Số tiền bằng chữ";
            // 
            // labelNotify8
            // 
            this.labelNotify8.AutoSize = true;
            this.labelNotify8.Location = new System.Drawing.Point(206, 329);
            this.labelNotify8.Name = "labelNotify8";
            this.labelNotify8.Size = new System.Drawing.Size(128, 13);
            this.labelNotify8.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify8.TabIndex = 0;
            this.labelNotify8.Text = "Số tiền hoàn lại bằng chữ";
            // 
            // labelNotify7
            // 
            this.labelNotify7.AutoSize = true;
            this.labelNotify7.Location = new System.Drawing.Point(24, 329);
            this.labelNotify7.Name = "labelNotify7";
            this.labelNotify7.Size = new System.Drawing.Size(80, 13);
            this.labelNotify7.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify7.TabIndex = 0;
            this.labelNotify7.Text = "Số tiền hoàn lại";
            // 
            // labelNotify10
            // 
            this.labelNotify10.AutoSize = true;
            this.labelNotify10.Location = new System.Drawing.Point(242, 95);
            this.labelNotify10.Name = "labelNotify10";
            this.labelNotify10.Size = new System.Drawing.Size(63, 13);
            this.labelNotify10.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify10.TabIndex = 0;
            this.labelNotify10.Text = "Số hóa đơn";
            // 
            // labelNotify5
            // 
            this.labelNotify5.AutoSize = true;
            this.labelNotify5.Location = new System.Drawing.Point(28, 270);
            this.labelNotify5.Name = "labelNotify5";
            this.labelNotify5.Size = new System.Drawing.Size(40, 13);
            this.labelNotify5.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify5.TabIndex = 0;
            this.labelNotify5.Text = "Số tiền";
            // 
            // labelNotify9
            // 
            this.labelNotify9.AutoSize = true;
            this.labelNotify9.Location = new System.Drawing.Point(19, 95);
            this.labelNotify9.Name = "labelNotify9";
            this.labelNotify9.Size = new System.Drawing.Size(49, 13);
            this.labelNotify9.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify9.TabIndex = 0;
            this.labelNotify9.Text = "Số phiếu";
            // 
            // labelNotify4
            // 
            this.labelNotify4.AutoSize = true;
            this.labelNotify4.Location = new System.Drawing.Point(19, 161);
            this.labelNotify4.Name = "labelNotify4";
            this.labelNotify4.Size = new System.Drawing.Size(89, 13);
            this.labelNotify4.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify4.TabIndex = 0;
            this.labelNotify4.Text = "Nội dung đề nghị";
            // 
            // labelNotify1
            // 
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(251, 131);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(39, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 0;
            this.labelNotify1.Text = "Họ tên";
            // 
            // frmSuggest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 429);
            this.Controls.Add(this.cbbStaff);
            this.Controls.Add(this.cbbDepartment);
            this.Controls.Add(this.cbbPurpose);
            this.Controls.Add(this.txtReturnMoneyNumWrite);
            this.Controls.Add(this.txtMoneyNumWrite);
            this.Controls.Add(this.txtMoneyBack);
            this.Controls.Add(this.txtMoneyOut);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelNotify2);
            this.Controls.Add(this.labelNotify3);
            this.Controls.Add(this.labelNotify6);
            this.Controls.Add(this.labelNotify8);
            this.Controls.Add(this.labelNotify7);
            this.Controls.Add(this.labelNotify10);
            this.Controls.Add(this.labelNotify5);
            this.Controls.Add(this.labelNotify9);
            this.Controls.Add(this.labelNotify4);
            this.Controls.Add(this.labelNotify1);
            this.Name = "frmSuggest";
            this.Resizable = false;
            this.Text = "Giấy đề xuất";
            this.Load += new System.EventHandler(this.frmSuggest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolBoxCS.LabelNotify labelNotify1;
        private ToolBoxCS.LabelNotify labelNotify3;
        private ToolBoxCS.LabelNotify labelNotify4;
        private ToolBoxCS.LabelNotify labelNotify5;
        private ToolBoxCS.LabelNotify labelNotify6;
        private ToolBoxCS.LabelNotify labelNotify7;
        private ToolBoxCS.LabelNotify labelNotify8;
        private ModernUI.Controls.BootstrapButton btnSave;
        private ModernUI.Controls.BootstrapButton btnPrint;
        private ModernUI.Controls.BootstrapButton btnCancel;
        private ToolBoxCS.TextBoxValidation txtContent;
        private ToolBoxCS.AutoTextBox txtMoneyOut;
        private ToolBoxCS.AutoTextBox txtMoneyBack;
        private ToolBoxCS.AutoTextBox txtMoneyNumWrite;
        private ToolBoxCS.AutoTextBox txtReturnMoneyNumWrite;
        private ToolBoxCS.AutoSearchCombobox cbbPurpose;
        private ToolBoxCS.AutoSearchCombobox cbbDepartment;
        private ToolBoxCS.LabelNotify labelNotify9;
        private ToolBoxCS.TextBoxValidation txtNo;
        private ToolBoxCS.LabelNotify labelNotify10;
        private ToolBoxCS.TextBoxValidation txtBillNo;
        private ToolBoxCS.AutoSearchCombobox cbbStaff;
        private ToolBoxCS.LabelNotify labelNotify2;
    }
}