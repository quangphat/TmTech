namespace TmTech_v1.ToolBoxCS
{
    partial class DisplayMultiplePicture
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayMultiplePicture));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.itemView = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.ptb4 = new TmTech_v1.ToolBoxCS.AutoPictureBox();
            this.ptb3 = new TmTech_v1.ToolBoxCS.AutoPictureBox();
            this.ptb2 = new TmTech_v1.ToolBoxCS.AutoPictureBox();
            this.ptb1 = new TmTech_v1.ToolBoxCS.AutoPictureBox();
            this.ptb0 = new TmTech_v1.ToolBoxCS.AutoPictureBox();
            this.ptbMain = new TmTech_v1.ToolBoxCS.AutoPictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMain)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAdd,
            this.itemRemove,
            this.itemView});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 70);
            // 
            // itemAdd
            // 
            this.itemAdd.Image = global::TmTech_v1.Properties.Resources.Plus_Math_32px;
            this.itemAdd.Name = "itemAdd";
            this.itemAdd.Size = new System.Drawing.Size(157, 22);
            this.itemAdd.Text = "Add Picture";
            this.itemAdd.Click += new System.EventHandler(this.itemAdd_Click);
            // 
            // itemRemove
            // 
            this.itemRemove.Image = global::TmTech_v1.Properties.Resources.Delete_32px;
            this.itemRemove.Name = "itemRemove";
            this.itemRemove.Size = new System.Drawing.Size(157, 22);
            this.itemRemove.Text = "Remove Picture";
            this.itemRemove.Click += new System.EventHandler(this.itemRemove_Click);
            // 
            // itemView
            // 
            this.itemView.Image = global::TmTech_v1.Properties.Resources.Eye_32px;
            this.itemView.Name = "itemView";
            this.itemView.Size = new System.Drawing.Size(157, 22);
            this.itemView.Text = "View";
            this.itemView.Click += new System.EventHandler(this.itemView_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(423, 239);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(68, 73);
            this.btnNext.TabIndex = 23;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(3, 239);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 73);
            this.btnBack.TabIndex = 22;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ptb4
            // 
            this.ptb4.BindingFor = "";
            this.ptb4.BindingName = null;
            this.ptb4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb4.Index = 4;
            this.ptb4.Location = new System.Drawing.Point(353, 239);
            this.ptb4.Name = "ptb4";
            this.ptb4.PictureName = "";
            this.ptb4.PictureOriginPath = "";
            this.ptb4.Size = new System.Drawing.Size(64, 73);
            this.ptb4.TabIndex = 21;
            this.ptb4.TabStop = false;
            this.ptb4.Tag = "4";
            this.ptb4.Click += new System.EventHandler(this.ptb4_Click);
            // 
            // ptb3
            // 
            this.ptb3.BindingFor = "";
            this.ptb3.BindingName = null;
            this.ptb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb3.Index = 3;
            this.ptb3.Location = new System.Drawing.Point(283, 239);
            this.ptb3.Name = "ptb3";
            this.ptb3.PictureName = "";
            this.ptb3.PictureOriginPath = "";
            this.ptb3.Size = new System.Drawing.Size(64, 73);
            this.ptb3.TabIndex = 20;
            this.ptb3.TabStop = false;
            this.ptb3.Tag = "3";
            this.ptb3.Click += new System.EventHandler(this.ptb3_Click);
            // 
            // ptb2
            // 
            this.ptb2.BindingFor = "";
            this.ptb2.BindingName = null;
            this.ptb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb2.Index = 2;
            this.ptb2.Location = new System.Drawing.Point(213, 239);
            this.ptb2.Name = "ptb2";
            this.ptb2.PictureName = "";
            this.ptb2.PictureOriginPath = "";
            this.ptb2.Size = new System.Drawing.Size(64, 73);
            this.ptb2.TabIndex = 19;
            this.ptb2.TabStop = false;
            this.ptb2.Tag = "2";
            this.ptb2.Click += new System.EventHandler(this.ptb2_Click);
            // 
            // ptb1
            // 
            this.ptb1.BindingFor = "";
            this.ptb1.BindingName = null;
            this.ptb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb1.Index = 1;
            this.ptb1.Location = new System.Drawing.Point(143, 239);
            this.ptb1.Name = "ptb1";
            this.ptb1.PictureName = "";
            this.ptb1.PictureOriginPath = "";
            this.ptb1.Size = new System.Drawing.Size(64, 73);
            this.ptb1.TabIndex = 18;
            this.ptb1.TabStop = false;
            this.ptb1.Tag = "1";
            this.ptb1.Click += new System.EventHandler(this.ptb1_Click);
            // 
            // ptb0
            // 
            this.ptb0.BindingFor = "Product";
            this.ptb0.BindingName = "Photo";
            this.ptb0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb0.Index = 0;
            this.ptb0.Location = new System.Drawing.Point(73, 239);
            this.ptb0.Name = "ptb0";
            this.ptb0.PictureName = "";
            this.ptb0.PictureOriginPath = "";
            this.ptb0.Size = new System.Drawing.Size(64, 73);
            this.ptb0.TabIndex = 17;
            this.ptb0.TabStop = false;
            this.ptb0.Tag = "0";
            this.ptb0.Click += new System.EventHandler(this.ptb0_Click);
            // 
            // ptbMain
            // 
            this.ptbMain.BindingFor = "";
            this.ptbMain.BindingName = null;
            this.ptbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.ptbMain, 7);
            this.ptbMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbMain.Index = 5;
            this.ptbMain.Location = new System.Drawing.Point(3, 3);
            this.ptbMain.Name = "ptbMain";
            this.ptbMain.PictureName = "";
            this.ptbMain.PictureOriginPath = "";
            this.ptbMain.Size = new System.Drawing.Size(488, 230);
            this.ptbMain.TabIndex = 16;
            this.ptbMain.TabStop = false;
            this.ptbMain.Tag = "5";
            this.ptbMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptbMain_MouseClick);
            this.ptbMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ptbMain_MouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.ptbMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNext, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.ptb0, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ptb4, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.ptb1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ptb3, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.ptb2, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 315);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // DisplayMultiplePicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DisplayMultiplePicture";
            this.Size = new System.Drawing.Size(494, 315);
            this.Load += new System.EventHandler(this.DisplayMultiplePicture_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMain)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemAdd;
        private System.Windows.Forms.ToolStripMenuItem itemRemove;
        private System.Windows.Forms.ToolStripMenuItem itemView;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        public AutoPictureBox ptb4;
        public AutoPictureBox ptb3;
        public AutoPictureBox ptb2;
        public AutoPictureBox ptb1;
        public AutoPictureBox ptb0;
        public AutoPictureBox ptbMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}
