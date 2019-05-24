namespace TmTech_v1.View
{
    partial class frmEditCurrencyUnit
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
            this.btnCancel = new ModernUI.Controls.BootstrapButton();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.labelNotify1 = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.txtCurrencyName = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtCurrencyCode = new TmTech_v1.ToolBoxCS.TextBoxValidation();
            this.txtNote = new TmTech_v1.ToolBoxCS.AutoTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(462, 26);
            this.btnCancel.MouseState = ModernUI.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 15;
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
            this.btnSave.Location = new System.Drawing.Point(401, 26);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelNotify1
            // 
            this.labelNotify1.AutoSize = true;
            this.labelNotify1.Location = new System.Drawing.Point(208, 66);
            this.labelNotify1.Name = "labelNotify1";
            this.labelNotify1.Size = new System.Drawing.Size(62, 13);
            this.labelNotify1.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.labelNotify1.TabIndex = 22;
            this.labelNotify1.Text = "labelNotify1";
            // 
            // txtCurrencyName
            // 
            this.txtCurrencyName.BindingFor = "CurrencyUnit";
            this.txtCurrencyName.BindingName = "CurrencyName";
            this.txtCurrencyName.ForeColor = System.Drawing.Color.Black;
            this.txtCurrencyName.Location = new System.Drawing.Point(327, 119);
            this.txtCurrencyName.Name = "txtCurrencyName";
            this.txtCurrencyName.Size = new System.Drawing.Size(152, 20);
            this.txtCurrencyName.TabIndex = 20;
            // 
            // txtCurrencyCode
            // 
            this.txtCurrencyCode.BindingFor = "CurrencyUnit";
            this.txtCurrencyCode.BindingName = "CurrencyCode";
            this.txtCurrencyCode.ForeColor = System.Drawing.Color.Black;
            this.txtCurrencyCode.Location = new System.Drawing.Point(106, 119);
            this.txtCurrencyCode.Name = "txtCurrencyCode";
            this.txtCurrencyCode.Size = new System.Drawing.Size(152, 20);
            this.txtCurrencyCode.TabIndex = 19;
            // 
            // txtNote
            // 
            this.txtNote.BindingFor = "CurrencyUnit";
            this.txtNote.BindingName = "Note";
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(100, 165);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(379, 44);
            this.txtNote.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên đơn vị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã đơn vị";
            // 
            // frmEditCurrencyUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 227);
            this.Controls.Add(this.labelNotify1);
            this.Controls.Add(this.txtCurrencyName);
            this.Controls.Add(this.txtCurrencyCode);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.Name = "frmEditCurrencyUnit";
            this.Resizable = false;
            this.Text = "Cập nhật thông tin đơn vị tiền tệ";
            this.Load += new System.EventHandler(this.frmEditCurrencyUnit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModernUI.Controls.BootstrapButton btnCancel;
        private ModernUI.Controls.BootstrapButton btnSave;
        private ToolBoxCS.LabelNotify labelNotify1;
        private ToolBoxCS.TextBoxValidation txtCurrencyName;
        private ToolBoxCS.TextBoxValidation txtCurrencyCode;
        private ToolBoxCS.AutoTextBox txtNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}