using System;
using System.Windows.Forms;

namespace TmTech_v1.ToolBoxCS
{
    public partial class CategoryContextMenu : ProductTreeViewContextMenu, IProductCategoryCtxMenu
    {
        public CategoryContextMenu(TreeView tree):base(tree)
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public new void Edit()
        {
            throw new NotImplementedException();
        }

        public void Show(TreeNode node)
        {
            base.Init(node);
        }
    }
}
