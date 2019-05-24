namespace TmTech_v1.View
{
    partial class FrmInputBank
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtAccountName = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtBankName = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.lableMessage = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên ngân hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số tài khoản:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddItemBank);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(81, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập thông tin ngân hàng";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BindingFor = "";
            this.txtAccountNumber.BindingName = null;
            this.txtAccountNumber.Location = new System.Drawing.Point(92, 107);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(145, 20);
            this.txtAccountNumber.TabIndex = 0;
            // 
            // txtAccountName
            // 
            this.txtAccountName.BindingFor = "";
            this.txtAccountName.BindingName = null;
            this.txtAccountName.Location = new System.Drawing.Point(92, 81);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(145, 20);
            this.txtAccountName.TabIndex = 0;
            // 
            // txtBankName
            // 
            this.txtBankName.BindingFor = "";
            this.txtBankName.BindingName = null;
            this.txtBankName.Location = new System.Drawing.Point(92, 55);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(145, 20);
            this.txtBankName.TabIndex = 0;
            // 
            // labelNotify1
            // 
            this.lableMessage.AutoSize = true;
            this.lableMessage.Location = new System.Drawing.Point(112, 40);
            this.lableMessage.Name = "labelNotify1";
            this.lableMessage.Size = new System.Drawing.Size(62, 13);
            this.lableMessage.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.lableMessage.TabIndex = 4;
            this.lableMessage.Text = "labelNotify1";
            // 
            // FrmInputBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 177);
            this.Controls.Add(this.lableMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.txtBankName);
            this.Name = "FrmInputBank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolBoxCS.TextBoxValidation txtBankName;
        private ToolBoxCS.TextBoxValidation txtAccountName;
        private ToolBoxCS.TextBoxValidation txtAccountNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private ToolBoxCS.LabelNotify lableMessage;
    }
}
