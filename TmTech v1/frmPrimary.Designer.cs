using System.Drawing;

namespace TmTech_v1
{
    partial class frmPrimary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimary));
            this.mainTabCtrl = new ModernUI.Controls.MaterialTabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPOList = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProductPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.itemUserGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSetPermission = new System.Windows.Forms.ToolStripMenuItem();
            this.thiếtLậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemThemeSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngTyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.itemStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetting = new ModernUI.Controls.MetroLink();
            this.btnMenu = new ModernUI.Controls.MetroLink();
            this.btnBack = new ModernUI.Controls.MetroLink();
            this.btnNext = new ModernUI.Controls.MetroLink();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabCtrl
            // 
            this.mainTabCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabCtrl.Depth = 0;
            this.mainTabCtrl.Location = new System.Drawing.Point(-3, 57);
            this.mainTabCtrl.MouseState = ModernUI.MouseState.HOVER;
            this.mainTabCtrl.Name = "mainTabCtrl";
            this.mainTabCtrl.SelectedIndex = 0;
            this.mainTabCtrl.Size = new System.Drawing.Size(882, 325);
            this.mainTabCtrl.TabIndex = 1;
            this.mainTabCtrl.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.mainTabCtrl_Deselecting);
            this.mainTabCtrl.Deselected += new System.Windows.Forms.TabControlEventHandler(this.mainTabCtrl_Deselected);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.ngườiDùngToolStripMenuItem,
            this.thiếtLậpToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.phòngBanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(178, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemPOList});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.menuToolStripMenuItem.Text = "Đơn hàng";
            // 
            // itemPOList
            // 
            this.itemPOList.Name = "itemPOList";
            this.itemPOList.Size = new System.Drawing.Size(183, 22);
            this.itemPOList.Text = "Danh sách đơn hàng";
            this.itemPOList.Click += new System.EventHandler(this.itemPOList_Click);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCategory,
            this.itemProduct,
            this.itemProductPrice});
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            // 
            // itemCategory
            // 
            this.itemCategory.Name = "itemCategory";
            this.itemCategory.Size = new System.Drawing.Size(163, 22);
            this.itemCategory.Text = "Nhóm sản phẩm";
            this.itemCategory.Click += new System.EventHandler(this.itemCategory_Click);
            // 
            // itemProduct
            // 
            this.itemProduct.Name = "itemProduct";
            this.itemProduct.Size = new System.Drawing.Size(163, 22);
            this.itemProduct.Text = "Sản phẩm";
            this.itemProduct.Click += new System.EventHandler(this.itemProduct_Click);
            // 
            // itemProductPrice
            // 
            this.itemProductPrice.Name = "itemProductPrice";
            this.itemProductPrice.Size = new System.Drawing.Size(163, 22);
            this.itemProductPrice.Text = "Cập nhật giá";
            this.itemProductPrice.Click += new System.EventHandler(this.itemProductPrice_Click);
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemUsers,
            this.itemUserGroup,
            this.itemSetPermission});
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
            // 
            // itemUsers
            // 
            this.itemUsers.Name = "itemUsers";
            this.itemUsers.Size = new System.Drawing.Size(194, 22);
            this.itemUsers.Text = "Danh sách người dùng";
            this.itemUsers.Click += new System.EventHandler(this.itemUsers_Click);
            // 
            // itemUserGroup
            // 
            this.itemUserGroup.Name = "itemUserGroup";
            this.itemUserGroup.Size = new System.Drawing.Size(194, 22);
            this.itemUserGroup.Text = "Nhóm người dùng";
            // 
            // itemSetPermission
            // 
            this.itemSetPermission.Name = "itemSetPermission";
            this.itemSetPermission.Size = new System.Drawing.Size(194, 22);
            this.itemSetPermission.Text = "Phân quyền";
            this.itemSetPermission.Click += new System.EventHandler(this.itemSetPermission_Click);
            // 
            // thiếtLậpToolStripMenuItem
            // 
            this.thiếtLậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemThemeSetting,
            this.tileToolStripMenuItem});
            this.thiếtLậpToolStripMenuItem.Name = "thiếtLậpToolStripMenuItem";
            this.thiếtLậpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.thiếtLậpToolStripMenuItem.Text = "Thiết lập";
            // 
            // itemThemeSetting
            // 
            this.itemThemeSetting.Name = "itemThemeSetting";
            this.itemThemeSetting.Size = new System.Drawing.Size(112, 22);
            this.itemThemeSetting.Text = "Chủ đề";
            this.itemThemeSetting.Click += new System.EventHandler(this.itemThemeSetting_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.tileToolStripMenuItem.Text = "Tile";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.côngTyToolStripMenuItem});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // côngTyToolStripMenuItem
            // 
            this.côngTyToolStripMenuItem.Name = "côngTyToolStripMenuItem";
            this.côngTyToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.côngTyToolStripMenuItem.Text = "Công ty";
            this.côngTyToolStripMenuItem.Click += new System.EventHandler(this.côngTyToolStripMenuItem_Click);
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDepartment,
            this.itemStaff});
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.phòngBanToolStripMenuItem.Text = "Phòng ban";
            // 
            // itemDepartment
            // 
            this.itemDepartment.Name = "itemDepartment";
            this.itemDepartment.Size = new System.Drawing.Size(132, 22);
            this.itemDepartment.Text = "Phòng ban";
            this.itemDepartment.Click += new System.EventHandler(this.itemDepartment_Click);
            // 
            // itemStaff
            // 
            this.itemStaff.Name = "itemStaff";
            this.itemStaff.Size = new System.Drawing.Size(132, 22);
            this.itemStaff.Text = "Nhân viên";
            this.itemStaff.Click += new System.EventHandler(this.itemStaff_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.HighLight = ModernUI.Controls.MetroLink.highlight.Alway;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageSize = 20;
            this.btnSetting.Location = new System.Drawing.Point(-3, 25);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(41, 23);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.UseCustomBackColor = true;
            this.btnSetting.UseSelectable = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.HighLight = ModernUI.Controls.MetroLink.highlight.Alway;
            this.btnMenu.Image = global::TmTech_v1.Properties.Resources.menu250;
            this.btnMenu.ImageSize = 20;
            this.btnMenu.Location = new System.Drawing.Point(841, 24);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(38, 23);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseCustomBackColor = true;
            this.btnMenu.UseSelectable = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.HighLight = ModernUI.Controls.MetroLink.highlight.Alway;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = 20;
            this.btnBack.Location = new System.Drawing.Point(35, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(41, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.HighLight = ModernUI.Controls.MetroLink.highlight.Alway;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageSize = 20;
            this.btnNext.Location = new System.Drawing.Point(76, 25);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(41, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.UseCustomBackColor = true;
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmPrimary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 394);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.mainTabCtrl);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrimary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrimary_FormClosing);
            this.Load += new System.EventHandler(this.frmPrimary_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModernUI.Controls.MetroLink btnMenu;
        private ModernUI.Controls.MetroLink btnSetting;
        public ModernUI.Controls.MaterialTabControl mainTabCtrl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemPOList;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemCategory;
        private System.Windows.Forms.ToolStripMenuItem itemProduct;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemUsers;
        private System.Windows.Forms.ToolStripMenuItem itemUserGroup;
        private System.Windows.Forms.ToolStripMenuItem thiếtLậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemThemeSetting;
        private System.Windows.Forms.ToolStripMenuItem itemProductPrice;
        private System.Windows.Forms.ToolStripMenuItem itemSetPermission;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngTyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemDepartment;
        private System.Windows.Forms.ToolStripMenuItem itemStaff;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private ModernUI.Controls.MetroLink btnBack;
        private ModernUI.Controls.MetroLink btnNext;
    }
}