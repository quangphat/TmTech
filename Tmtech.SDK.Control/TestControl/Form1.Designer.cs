namespace TestControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.gridControlView1 = new Tmtech.SDK.Control.GridControlView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.autoTextBox1 = new Tmtech.SDK.Control.AutoTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridControlView1
            // 
            this.gridControlView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlView1.Location = new System.Drawing.Point(12, 24);
            this.gridControlView1.MainView = this.gridView1;
            this.gridControlView1.Name = "gridControlView1";
            this.gridControlView1.PrimaryKey = null;
            this.gridControlView1.Size = new System.Drawing.Size(400, 200);
            this.gridControlView1.TabIndex = 2;
            this.gridControlView1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStt});
            this.gridView1.GridControl = this.gridControlView1;
            this.gridView1.Name = "gridView1";
            // 
            // colStt
            // 
            this.colStt.Caption = "STT";
            this.colStt.FieldName = "Stt";
            this.colStt.Name = "colStt";
            this.colStt.Visible = true;
            this.colStt.VisibleIndex = 0;
            // 
            // autoTextBox1
            // 
            this.autoTextBox1.BindingFor = null;
            this.autoTextBox1.BindingName = null;
            this.autoTextBox1.IsPassword = false;
            this.autoTextBox1.IsRequire = false;
            this.autoTextBox1.Location = new System.Drawing.Point(459, 149);
            this.autoTextBox1.Name = "autoTextBox1";
            this.autoTextBox1.Size = new System.Drawing.Size(255, 20);
            this.autoTextBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 359);
            this.Controls.Add(this.autoTextBox1);
            this.Controls.Add(this.gridControlView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Tmtech.SDK.Control.GridControlView gridControlView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colStt;
        private Tmtech.SDK.Control.AutoTextBox autoTextBox1;


    }
}