namespace TmTech_v1.ToolBoxCS
{
    partial class ProductPath
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkCategory = new System.Windows.Forms.LinkLabel();
            this.lblDivide2 = new System.Windows.Forms.Label();
            this.linkSerie = new System.Windows.Forms.LinkLabel();
            this.lblDivide1 = new System.Windows.Forms.Label();
            this.linkLine = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.linkCategory);
            this.flowLayoutPanel1.Controls.Add(this.lblDivide1);
            this.flowLayoutPanel1.Controls.Add(this.linkSerie);
            this.flowLayoutPanel1.Controls.Add(this.lblDivide2);
            this.flowLayoutPanel1.Controls.Add(this.linkLine);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(330, 21);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // linkCategory
            // 
            this.linkCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.linkCategory.AutoSize = true;
            this.linkCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCategory.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkCategory.Location = new System.Drawing.Point(3, 0);
            this.linkCategory.Name = "linkCategory";
            this.linkCategory.Size = new System.Drawing.Size(77, 13);
            this.linkCategory.TabIndex = 240;
            this.linkCategory.TabStop = true;
            this.linkCategory.Text = "CategoryName";
            this.linkCategory.Click += new System.EventHandler(this.linkCategory_LinkClicked);
            // 
            // lblDivide2
            // 
            this.lblDivide2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDivide2.AutoSize = true;
            this.lblDivide2.Location = new System.Drawing.Point(170, 0);
            this.lblDivide2.Name = "lblDivide2";
            this.lblDivide2.Size = new System.Drawing.Size(13, 13);
            this.lblDivide2.TabIndex = 243;
            this.lblDivide2.Text = ">";
            // 
            // linkSerie
            // 
            this.linkSerie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.linkSerie.AutoSize = true;
            this.linkSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSerie.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkSerie.Location = new System.Drawing.Point(105, 0);
            this.linkSerie.Name = "linkSerie";
            this.linkSerie.Size = new System.Drawing.Size(59, 13);
            this.linkSerie.TabIndex = 242;
            this.linkSerie.TabStop = true;
            this.linkSerie.Text = "SerieName";
            this.linkSerie.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSerie_LinkClicked);
            // 
            // lblDivide1
            // 
            this.lblDivide1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDivide1.AutoSize = true;
            this.lblDivide1.Location = new System.Drawing.Point(86, 0);
            this.lblDivide1.Name = "lblDivide1";
            this.lblDivide1.Size = new System.Drawing.Size(13, 13);
            this.lblDivide1.TabIndex = 241;
            this.lblDivide1.Text = ">";
            // 
            // linkLine
            // 
            this.linkLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLine.AutoSize = true;
            this.linkLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLine.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLine.Location = new System.Drawing.Point(189, 0);
            this.linkLine.Name = "linkLine";
            this.linkLine.Size = new System.Drawing.Size(55, 13);
            this.linkLine.TabIndex = 244;
            this.linkLine.TabStop = true;
            this.linkLine.Text = "LineName";
            this.linkLine.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLine_LinkClicked);
            // 
            // ProductPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ProductPath";
            this.Size = new System.Drawing.Size(330, 21);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkCategory;
        private System.Windows.Forms.Label lblDivide2;
        private System.Windows.Forms.LinkLabel linkSerie;
        private System.Windows.Forms.Label lblDivide1;
        private System.Windows.Forms.LinkLabel linkLine;

    }
}
