namespace TmTech_v1.View
{
    partial class frmCreateCurrencyUnit
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
            this.txtNote = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.btnCancel = new ModernUI.Controls.BootstrapButton();
            this.btnAdd = new ModernUI.Controls.BootstrapButton();
            this.txtCurrencyName = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtCurrencyCode = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn vị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đơn vị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ghi chú";
            // 
            // txtNote
            // 
            this.txtNote.BindingFor = "CurrencyUnit";
            this.txtNote.BindingName = "Note";
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(75, 159);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(379, 44);
            this.txtNote.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(381, 26);
            this.btnCancel.MouseState = ModernUI.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Depth = 0;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(320, 26);
            this.btnAdd.MouseState = ModernUI.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCurrencyName
            // 
            this.txtCurrencyName.BindingFor = "CurrencyUnit";
            this.txtCurrencyName.BindingName = "CurrencyName";
            this.txtCurrencyName.ForeColor = System.Drawing.Color.Black;
            this.txtCurrencyName.Location = new System.Drawing.Point(302, 113);
            this.txtCurrencyName.Name = "txtCurrencyName";
            this.txtCurrencyName.Size = new System.Drawing.Size(152, 20);
            this.txtCurrencyName.TabIndex = 2;
            // 
            // txtCurrencyCode
            // 
            this.txtCurrencyCode.BindingFor = "CurrencyUnit";
            this.txtCurrencyCode.BindingName = "CurrencyCode";
            this.txtCurrencyCode.ForeColor = System.Drawing.Color.Black;
            this.txtCurrencyCode.Location = new System.Drawing.Point(81, 113);
            this.txtCurrencyCode.Name = "txtCurrencyCode";
            this.txtCurrencyCode.Size = new System.Drawing.Size(152, 20);
            this.txtCurrencyCode.TabIndex = 1;
            // 
            // labelNotify1
            // 
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(183, 60);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(62, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 6;
            this.labelNotify1.Text = "labelNotify1";
            // 
            // frmCreateCurrencyUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 226);
            this.Controls.Add(this.labelNotify1);
            this.Controls.Add(this.txtCurrencyName);
            this.Controls.Add(this.txtCurrencyCode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateCurrencyUnit";
            this.Resizable = false;
            this.Text = "Thêm đơn vị tiền tệ";
            this.Load += new System.EventHandler(this.frmCreateCurrencyUnit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ToolBoxCS.AutoTextBox txtNote;
        private ModernUI.Controls.BootstrapButton btnCancel;
        private ModernUI.Controls.BootstrapButton btnAdd;
        private ToolBoxCS.TextBoxValidation txtCurrencyCode;
        private ToolBoxCS.TextBoxValidation txtCurrencyName;
        private ToolBoxCS.LabelNotify labelNotify1;
    }
}