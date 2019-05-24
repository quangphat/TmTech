namespace TmTech_v1.View
{
    partial class frmMaterialList
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImgPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPickMaterial = new ModernUI.Controls.BootstrapButton();
            this.btnCreate = new ModernUI.Controls.BootstrapButton();
            this.btnEdit = new ModernUI.Controls.BootstrapButton();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(-1, 102);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(914, 383);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn7,
            this.colPhoto,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn8,
            this.gridColumn6,
            this.gridColumn5,
            this.colImgPath,
            this.gridColumn9});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Stt";
            this.gridColumn1.FieldName = "Stt";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 30;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã";
            this.gridColumn2.FieldName = "MaterialCode";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 122;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tên";
            this.gridColumn7.FieldName = "MaterialName";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 122;
            // 
            // colPhoto
            // 
            this.colPhoto.Caption = "Hình ảnh";
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.OptionsColumn.AllowEdit = false;
            this.colPhoto.Visible = true;
            this.colPhoto.VisibleIndex = 3;
            this.colPhoto.Width = 158;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nhà cung cấp";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 113;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Giá";
            this.gridColumn4.FieldName = "MaterialPrice";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Tag = "money";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 113;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tồn kho";
            this.gridColumn8.FieldName = "InStock";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 113;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Số lượng";
            this.gridColumn6.FieldName = "MaterialQuantity";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Tag = "number";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            this.gridColumn6.Width = 125;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "MaterialId";
            this.gridColumn5.FieldName = "MaterialId";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // colImgPath
            // 
            this.colImgPath.Caption = "Hình ảnh";
            this.colImgPath.FieldName = "PhotoPath";
            this.colImgPath.Name = "colImgPath";
            // 
            // btnPickMaterial
            // 
            this.btnPickMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickMaterial.AutoSize = true;
            this.btnPickMaterial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPickMaterial.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnPickMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPickMaterial.Depth = 0;
            this.btnPickMaterial.Icon = null;
            this.btnPickMaterial.Location = new System.Drawing.Point(769, 63);
            this.btnPickMaterial.MouseState = ModernUI.MouseState.HOVER;
            this.btnPickMaterial.Name = "btnPickMaterial";
            this.btnPickMaterial.Size = new System.Drawing.Size(135, 36);
            this.btnPickMaterial.TabIndex = 1;
            this.btnPickMaterial.Text = "Add to product";
            this.btnPickMaterial.UseVisualStyleBackColor = true;
            this.btnPickMaterial.Click += new System.EventHandler(this.btnPickMaterial_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.AutoSize = true;
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Depth = 0;
            this.btnCreate.Icon = null;
            this.btnCreate.Location = new System.Drawing.Point(636, 63);
            this.btnCreate.MouseState = ModernUI.MouseState.HOVER;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(71, 36);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Depth = 0;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(713, 63);
            this.btnEdit.MouseState = ModernUI.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 36);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "gridColumn9";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // frmMaterialList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 489);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnPickMaterial);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmMaterialList";
            this.Text = "Material";
            this.Load += new System.EventHandler(this.frmMaterialList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ModernUI.Controls.BootstrapButton btnPickMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colImgPath;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private ModernUI.Controls.BootstrapButton btnCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoto;
        private ModernUI.Controls.BootstrapButton btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
    }
}