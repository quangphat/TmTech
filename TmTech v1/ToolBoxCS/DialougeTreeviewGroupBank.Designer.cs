namespace TmTech_v1.ToolBoxCS
{
    partial class DialougeTreeviewGroupBank
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
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.btnClose = new ModernUI.Controls.BootstrapButton();
            this.pnelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnelOld = new System.Windows.Forms.Panel();
            this.txtOld = new TmTech_v1.ToolBoxCS.DisplayText();
            this.label2 = new System.Windows.Forms.Label();
            this.pnelNew = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.lbleMessage = new TmTech_v1.ToolBoxCS.LabelNotify();
            this.pnelMain.SuspendLayout();
            this.pnelOld.SuspendLayout();
            this.pnelNew.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(167, 11);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 215;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Danger;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Depth = 0;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(231, 11);
            this.btnClose.MouseState = ModernUI.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 36);
            this.btnClose.TabIndex = 217;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnelMain
            // 
            this.pnelMain.Controls.Add(this.pnelOld);
            this.pnelMain.Controls.Add(this.pnelNew);
            this.pnelMain.Location = new System.Drawing.Point(23, 76);
            this.pnelMain.Name = "pnelMain";
            this.pnelMain.Size = new System.Drawing.Size(281, 127);
            this.pnelMain.TabIndex = 218;
            // 
            // pnelOld
            // 
            this.pnelOld.Controls.Add(this.txtOld);
            this.pnelOld.Controls.Add(this.label2);
            this.pnelOld.Location = new System.Drawing.Point(3, 3);
            this.pnelOld.Name = "pnelOld";
            this.pnelOld.Size = new System.Drawing.Size(275, 59);
            this.pnelOld.TabIndex = 0;
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(94, 21);
            this.txtOld.Name = "txtOld";
            this.txtOld.ReadOnly = true;
            this.txtOld.Size = new System.Drawing.Size(163, 20);
            this.txtOld.TabIndex = 226;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 224;
            this.label2.Text = "Tên nhóm cũ:";
            // 
            // pnelNew
            // 
            this.pnelNew.Controls.Add(this.label1);
            this.pnelNew.Controls.Add(this.txtNew);
            this.pnelNew.Location = new System.Drawing.Point(3, 68);
            this.pnelNew.Name = "pnelNew";
            this.pnelNew.Size = new System.Drawing.Size(275, 59);
            this.pnelNew.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 225;
            this.label1.Text = "Tên nhóm mới";
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(94, 12);
            this.txtNew.Multiline = true;
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(163, 24);
            this.txtNew.TabIndex = 227;
            // 
            // lbleMessage
            // 
            this.lbleMessage.AutoSize = true;
            this.lbleMessage.Location = new System.Drawing.Point(67, 23);
            this.lbleMessage.Name = "lbleMessage";
            this.lbleMessage.Size = new System.Drawing.Size(49, 13);
            this.lbleMessage.Status = TmTech_v1.ToolBoxCS.LabelNotify.EnumStatus.Other;
            this.lbleMessage.TabIndex = 219;
            this.lbleMessage.Text = "message";
            // 
            // DialougeTreeviewGroupBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 235);
            this.Controls.Add(this.lbleMessage);
            this.Controls.Add(this.pnelMain);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "DialougeTreeviewGroupBank";
            this.pnelMain.ResumeLayout(false);
            this.pnelOld.ResumeLayout(false);
            this.pnelOld.PerformLayout();
            this.pnelNew.ResumeLayout(false);
            this.pnelNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ModernUI.Controls.BootstrapButton btnSave;
        private ModernUI.Controls.BootstrapButton btnClose;
        private System.Windows.Forms.FlowLayoutPanel pnelMain;
        private System.Windows.Forms.Panel pnelOld;
        private DisplayText txtOld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnelNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNew;
        private LabelNotify lbleMessage;
    }
}
