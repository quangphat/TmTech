namespace TmTech.Control
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.treeviewControl1 = new TmTech.Control.TreeviewControl();
            this.treeviewControl2 = new TmTech.Control.TreeviewControl();
            this.SuspendLayout();
            // 
            // treeviewControl1
            // 
            this.treeviewControl1.Location = new System.Drawing.Point(12, 24);
            this.treeviewControl1.Name = "treeviewControl1";
            this.treeviewControl1.Size = new System.Drawing.Size(206, 209);
            this.treeviewControl1.TabIndex = 0;
            // 
            // treeviewControl2
            // 
            this.treeviewControl2.ImageIndex = 0;
            this.treeviewControl2.Location = new System.Drawing.Point(260, 51);
            this.treeviewControl2.Name = "treeviewControl2";
            this.treeviewControl2.SelectedImageIndex = 0;
            this.treeviewControl2.Size = new System.Drawing.Size(175, 377);
            this.treeviewControl2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 471);
            this.Controls.Add(this.treeviewControl2);
            this.Controls.Add(this.treeviewControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TreeviewControl treeviewControl1;
        private TreeviewControl treeviewControl2;
    }
}

