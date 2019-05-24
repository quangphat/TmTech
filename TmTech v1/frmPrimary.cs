
using ModernUI.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

using System.Windows.Forms;
using TmTech_v1.Utility;
using FlatMessageBox;
using TmTech_v1.View;
using ModernUI;
using TmTech.Resource;

namespace TmTech_v1
{
    public partial class frmPrimary : MaterialForm
    {
        IDbConnection db = DbTmTech.DbCon;
        private readonly ModernUIManager materialSkinManager;
        public List<UserTheme> lstheme = UserTheme.generateTheme();
        private readonly ILocale iLocale;
        //private TabControl mainTab;
        public frmPrimary()
        {
            InitializeComponent();
            materialSkinManager = ModernUIManager.Instance;
            materialSkinManager.AddFormToManage(this);
            iLocale = new ManagementResource();
            SetLanuage();
        }
        private void  SetLanuage ()
        {
            CultureLanguage cultureLanguage = CultureLanguage.vn_VN;
            iLocale.SwichLanguage(cultureLanguage);
        }
        public void AddTab(UserControl userCtrl)
        {
            TabPage tab = new TabPage();
            tab.Tag = userCtrl.Name;
            tab.Name = userCtrl.GetType().Name;
            if (tab.Tag.ToString() == "frmTileView")
            {
                if(mainTabCtrl.TabCount>0)
                {
                    mainTabCtrl.SelectedTab = mainTabCtrl.TabPages[0];
                    return;
                }
            }
            TabPage existTab = FindTab(tab);
            if(existTab!=null)
            {
                mainTabCtrl.SelectedTab = existTab;
            }
            else
            {
                userCtrl.Dock = DockStyle.Fill;
                tab.Controls.Add(userCtrl);
                mainTabCtrl.TabPages.Add(tab);
                mainTabCtrl.SelectedTab = tab;
            }
        }

        public void AddTab(Form frmCtrl)
        {
            TabPage tab = new TabPage();
            tab.Tag = frmCtrl.Name;
            if (tab.Tag.ToString() == "frmTileView")
            {
                if (mainTabCtrl.TabCount > 0)
                {
                    mainTabCtrl.SelectedTab = mainTabCtrl.TabPages[0];
                    return;
                }
            }
            TabPage existTab = FindTab(tab);
            if (existTab != null)
            {
                mainTabCtrl.SelectedTab = existTab;
            }
            else
            {
                frmCtrl.Dock = DockStyle.Fill;
                tab.Controls.Add(frmCtrl);
                mainTabCtrl.TabPages.Add(tab);
                mainTabCtrl.SelectedTab = tab;
            }
        }
        private TabPage FindTab(TabPage tab)
        {
            foreach(TabPage t in mainTabCtrl.TabPages)
            {
                if (t.Tag == null) return null;
                if (t.Tag.ToString() == tab.Tag.ToString())
                {
                    return t;
                }
            }
            return null;
        }
        private void BackPage()
        {
            if (mainTabCtrl.SelectedIndex>0)
                mainTabCtrl.SelectedTab = mainTabCtrl.TabPages[mainTabCtrl.SelectedIndex-1];
            //mainTabCtrl.SelectedTab.Show();
        }
        private void NextPage()
        {
            if(mainTabCtrl.SelectedIndex<mainTabCtrl.TabCount-1)
            {
                    mainTabCtrl.SelectedTab = mainTabCtrl.TabPages[mainTabCtrl.SelectedIndex + 1];
                //mainTabCtrl.SelectedTab.Show();
            }
        }
        private void frmPrimary_Load(object sender, EventArgs e)
        {
            if (MaximizeOption == MaximizeOptions.NotCoverTaskBar)
            {
                this.Bounds = Screen.PrimaryScreen.WorkingArea;
                this.TopMost = false;
            }
            ChangeTheme(UserManagement.UserSession.ThemeName);
            if (materialSkinManager.ColorScheme.PrimaryColor == System.Drawing.Color.FromArgb(242, 244, 248))
            {
                menuStrip1.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                menuStrip1.ForeColor = System.Drawing.Color.White;
            }
            frmTileView frmView = new frmTileView();
            frmView.AddTab = AddTab;
            AddTab(frmView);
        }
        public void SetEnable(bool isEnable)
        {
            this.Enabled = isEnable;
        }
        private void frmPrimary_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private string themeName = "Default";
        public void ChangeTheme(string themename)
        {
            UserTheme theme = lstheme.Find(p => p.Name == themename);
            if (theme != null)
            {
                try
                {

                    System.Drawing.Color primary = ColorTranslator.FromHtml(theme.PrimaryColor);
                    System.Drawing.Color titlebar = ColorTranslator.FromHtml(theme.TitleBarColor);
                    System.Drawing.Color lightPrimary = ColorTranslator.FromHtml(theme.LightPrimary);
                    System.Drawing.Color textShade = ColorTranslator.FromHtml(theme.TextColor);
                    System.Drawing.Color accent = ColorTranslator.FromHtml(theme.Accent);
                    materialSkinManager.ColorScheme = new ColorScheme(primary, titlebar, lightPrimary, accent, textShade);
                    themeName = themename;
                }
                catch
                {
                    return;
                }
            }
        }
        public void SaveTheme()
        {
            UserSetting setting = new UserSetting();
            setting.UserName = UserManagement.UserSession.UserName;
            setting.ThemeName = themeName;
            UtilityFunction.WriteTheme(setting);
        }

        
        public void closeCurrentTab()
        {
            TabPage tab = mainTabCtrl.SelectedTab;
            mainTabCtrl.TabPages.Remove(tab);
        }

        public void CloseTabByName(UserControl frmClose)
        {
            if (frmClose == null)
                return;
            TabPage tab = null;
            foreach (TabPage item in mainTabCtrl.TabPages)
            {
                if (item.Name == frmClose.GetType().Name)
                {
                    tab = item;
                    break;
                }
            }
            if( tab !=null)
            {
             
                mainTabCtrl.TabPages.Remove(tab);
                if (mainTabCtrl.SelectedIndex > 0)
                frmClose = null;
            }
        }

        public void OpentabByName(string frmOpen)
        {
            if (frmOpen == null)
                return;
            TabPage tab = null;
            foreach (TabPage item in mainTabCtrl.TabPages)
            {
                if (item.Name == frmOpen)
                {
                    tab = item;
                    break;
                }
            }
            if (tab != null)
            {

                mainTabCtrl.SelectedTab = tab;
            }
        }

        public void HideTabByName(UserControl frmHide)
        {
            if (frmHide == null)
                return;
            TabPage tab = null;
            foreach (TabPage item in mainTabCtrl.TabPages)
            {
                if (item.Name == frmHide.GetType().Name)
                {
                    tab = item;
                    break;
                }
                
            }
            if (tab != null)
            {
                mainTabCtrl.TabPages.Remove(tab);
            }
            

        }
        private delegate void delgloadData();
        private void itemPOList_Click(object sender, EventArgs e)
        {
            TabPage tabDdh = new TabPage("Đơn đặt hàng");
            tabDdh.Tag = 1;
            mainTabCtrl.TabPages.Add(tabDdh);
            mainTabCtrl.SelectedTab = tabDdh;
        }
        private void CallPage(string tableName, string tabPageName, UserControl frmView, delgloadData delgLoad)
        {
            if (UserManagement.AllowViewAll(tableName) == false && UserManagement.AllowViewOwn(tableName) == false)
            {
                FlatMsgBox.Show("Bạn không có quyền ở mục này");
                return;
            }
            if(delgLoad!=null) delgLoad();
            TabPage tab = new TabPage(tabPageName);
            tab.Name = tableName;
            tab.Controls.Add(frmView);
            mainTabCtrl.TabPages.Add(tab);
            mainTabCtrl.SelectedTab = tab;
        }
        
        public void ItemUserClick()
        {
            TmTech_v1.View.frmUsersView frmView = new frmUsersView();
            delgloadData delgLoad = new delgloadData(frmView.LoadGrid);
            CallPage("Users", "Người dùng", frmView, delgLoad);
        }
       
        public void itemUserGroupClick()
        {
            TmTech_v1.View.frmUGroupView frmView = new frmUGroupView();
            delgloadData delgLoad = new delgloadData(frmView.LoadGrid);
            CallPage("UserGroup", "Nhóm người dùng", frmView, delgLoad);
        }
       
        public void itemProductGroupClick()
        {
            TmTech_v1.View.Lstcategory frmView = new Lstcategory();
            delgloadData delgLoad = new delgloadData(frmView.LoadGrid);
            CallPage("Category", "Nhóm sản phẩm", frmView, delgLoad);
        }
        private void itemProduct_Click(object sender, EventArgs e)
        {
            TmTech_v1.View.frmProduct frmView = new View.frmProduct();
            delgloadData delgLoad = new delgloadData(frmView.LoadTree);
            CallPage("Product", "Sản phẩm", frmView, delgLoad);
        }
        public void itemProductClick()
        {
            TmTech_v1.View.frmProduct frmView = new View.frmProduct();
            //TmTech_v1.View.frmProductDemo frmView = new frmProductDemo();
            delgloadData delgLoad = new delgloadData(frmView.LoadTree);
            //delgloadData delgLoad = null;
            CallPage("Product", "Sản phẩm", frmView, delgLoad);
        }
        private void itemThemeSetting_Click(object sender, EventArgs e)
        {
            frmThemeSetting frmTheme = new frmThemeSetting();
            frmTheme.Show();
        }

        private void itemProductPrice_Click(object sender, EventArgs e)
        {
            TmTech_v1.View.frmProductPriceView frmView = new View.frmProductPriceView();
            delgloadData delgLoad = new delgloadData(frmView.LoadGrid);
            CallPage("ProductPrice", "Cập nhật giá", frmView, delgLoad);
        }

        private void itemSetPermission_Click(object sender, EventArgs e){
            TmTech_v1.View.frmSetPermission frmView = new TmTech_v1.View.frmSetPermission();
            delgloadData delgLoad = new delgloadData(frmView.LoadGrid);
            CallPage("Permissions", "Đối tượng", frmView, delgLoad);
        }

        private void côngTyToolStripMenuItem_Click(object sender, EventArgs e)
        {

           }

        private void itemDepartment_Click(object sender, EventArgs e)
        {
        }

        private void itemStaff_Click(object sender, EventArgs e)
        {

        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTileView frmView = new frmTileView();
            TabPage tab = new TabPage();
            tab.Controls.Add(frmView);
            mainTabCtrl.TabPages.Add(tab);
            mainTabCtrl.SelectedTab = tab;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmTileView frmView = new frmTileView();
            frmView.AddTab = AddTab;
            AddTab(frmView);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackPage();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void mainTabCtrl_Deselected(object sender, TabControlEventArgs e)
        {

        }

        private void mainTabCtrl_Deselecting(object sender, TabControlCancelEventArgs e)
        {
          
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void itemUsers_Click(object sender, EventArgs e)
        {

        }

        private void itemCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
