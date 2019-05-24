namespace TmTech_v1.View
{
    partial class frmThemeSetting
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
            this.pnlTheme = new System.Windows.Forms.FlowLayoutPanel();
            this.btSaveTheme = new ModernUI.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // pnlTheme
            // 
            this.pnlTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTheme.Location = new System.Drawing.Point(-4, 82);
            this.pnlTheme.Name = "pnlTheme";
            this.pnlTheme.Size = new System.Drawing.Size(509, 243);
            this.pnlTheme.TabIndex = 0;
            // 
            // btSaveTheme
            // 
            this.btSaveTheme.AutoSize = true;
            this.btSaveTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSaveTheme.Depth = 0;
            this.btSaveTheme.Icon = null;
            this.btSaveTheme.Location = new System.Drawing.Point(422, 40);
            this.btSaveTheme.MouseState = ModernUI.MouseState.HOVER;
            this.btSaveTheme.Name = "btSaveTheme";
            this.btSaveTheme.Primary = true;
            this.btSaveTheme.Size = new System.Drawing.Size(55, 36);
            this.btSaveTheme.TabIndex = 1;
            this.btSaveTheme.Text = "Save";
            this.btSaveTheme.UseVisualStyleBackColor = true;
            this.btSaveTheme.Click += new System.EventHandler(this.btSaveTheme_Click);
            // 
            // frmThemeSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 331);
            this.Controls.Add(this.btSaveTheme);
            this.Controls.Add(this.pnlTheme);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemeSetting";
            this.Resizable = false;
            this.Text = "Thiết lập chủ đề";
            this.Load += new System.EventHandler(this.frmThemeSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlTheme;
        private ModernUI.Controls.MaterialRaisedButton btSaveTheme;
    }
}