namespace TmTech_v1.View
{
    partial class frmUserLeftView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.itemUser = new ModernUI.Controls.MetroLink();
            this.itemUserGroup = new ModernUI.Controls.MetroLink();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.itemUser);
            this.panel1.Controls.Add(this.itemUserGroup);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 467);
            this.panel1.TabIndex = 0;
            // 
            // itemUser
            // 
            this.itemUser.BackColor = System.Drawing.Color.Transparent;
            this.itemUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemUser.HighLight = ModernUI.Controls.MetroLink.highlight.Alway;
            this.itemUser.Location = new System.Drawing.Point(3, 69);
            this.itemUser.Name = "itemUser";
            this.itemUser.Size = new System.Drawing.Size(138, 23);
            this.itemUser.TabIndex = 1;
            this.itemUser.Text = "Danh sách người dùng";
            this.itemUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemUser.UseCustomBackColor = true;
            this.itemUser.UseSelectable = true;
            this.itemUser.Click += new System.EventHandler(this.itemUser_Click);
            // 
            // itemUserGroup
            // 
            this.itemUserGroup.BackColor = System.Drawing.Color.Transparent;
            this.itemUserGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemUserGroup.HighLight = ModernUI.Controls.MetroLink.highlight.Alway;
            this.itemUserGroup.Location = new System.Drawing.Point(3, 26);
            this.itemUserGroup.Name = "itemUserGroup";
            this.itemUserGroup.Size = new System.Drawing.Size(138, 23);
            this.itemUserGroup.TabIndex = 0;
            this.itemUserGroup.Text = "Nhóm người dùng";
            this.itemUserGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemUserGroup.UseCustomBackColor = true;
            this.itemUserGroup.UseSelectable = true;
            this.itemUserGroup.Click += new System.EventHandler(this.itemUserGroup_Click);
            // 
            // frmUserLeftView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "frmUserLeftView";
            this.Size = new System.Drawing.Size(910, 467);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ModernUI.Controls.MetroLink itemUser;
        private ModernUI.Controls.MetroLink itemUserGroup;
    }
}
