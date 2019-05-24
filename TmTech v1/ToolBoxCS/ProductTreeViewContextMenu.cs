using System;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;
using TmTech_v1.View;

namespace TmTech_v1.ToolBoxCS
{
    public interface IProductCategoryCtxMenu
    {
        void Show(TreeNode node);
        //void Edit();
    }
    public abstract class ProductTreeViewContextMenu:ContextMenuStrip
    {
        TreeView m_Treeview;
        TreeNode m_Node;
        
        public ToolStripMenuItem itemCreateCategory, itemCreateSerie, itemDelete, itemEdit,itemCreateLine;
        public ProductTreeViewContextMenu(TreeView tree)
        {
            //InitializeComponent();
            m_Treeview = tree;
            itemCreateCategory = new ToolStripMenuItem();
            itemCreateCategory.Text = "Create Category";
            itemCreateCategory.Name = "CreateCategory";
            itemCreateCategory.Image = TmTech_v1.Properties.Resources.Plus_Math_32px;
            itemCreateCategory.Click += itemCreateCategory_Click;
            this.Items.Add(itemCreateCategory);

            itemCreateSerie = new ToolStripMenuItem();
            itemCreateSerie.Text = "Create Class Product";
            itemCreateSerie.Name = "Createclassproduct";
            itemCreateSerie.Image = TmTech_v1.Properties.Resources.Plus_Math_32px;
            itemCreateSerie.Click += itemCreateSerie_Click;
            this.Items.Add(itemCreateSerie);

            itemCreateLine = new ToolStripMenuItem();
            itemCreateLine.Text = "Create Sub Product";
            itemCreateLine.Name = "CreateSubproduct";
            itemCreateLine.Image = TmTech_v1.Properties.Resources.Plus_Math_32px;
            itemCreateLine.Click += itemCreateLine_Click;
            this.Items.Add(itemCreateLine);

            itemEdit = new ToolStripMenuItem();
            itemEdit.Text = "Edit";
            itemEdit.Name = "Edit";
            itemEdit.Click += itemEdit_Click;
            itemEdit.Image = TmTech_v1.Properties.Resources.Edit_32px;
            this.Items.Add(itemEdit);

            itemDelete = new ToolStripMenuItem();
            itemDelete.Text = "Delete";
            itemDelete.Name = "Delete";
            itemDelete.Image = TmTech_v1.Properties.Resources.Delete_32px;
            itemDelete.Click += itemDelete_Click;
            this.Items.Add(itemDelete);
        }

        void itemCreateLine_Click(object sender, EventArgs e)
        {
            CreateLine();
        }
        public void CreateLine()
        {
            TreeTag treetag = m_Node.Tag as TreeTag;
            frmCreateSub frmCreate = new frmCreateSub(treetag);
            frmCreate.AddNode = AddNodeToTree;
            frmCreate.ShowDialog();
        }
        void itemCreateSerie_Click(object sender, EventArgs e)
        {
            CreateSerie();
        }
        public void CreateSerie()
        {
            TreeTag treetag = m_Node.Tag as TreeTag;
            if (treetag == null) return;
            frmCreateSerie frmCreate = new frmCreateSerie(treetag);
            frmCreate.AddNode = AddNodeToTree;
            frmCreate.ShowDialog();
        }
        private void AddNodeToTree(TreeNode newNode)
        {
            TreeTag selectedTag = m_Node.Tag as TreeTag;
            TreeTag newnodeTag = newNode.Tag as TreeTag;
            TreeNode parentNode = null;
            m_Treeview.BeginUpdate();
            if (selectedTag.NodeTye == TreeTag.Types.Category)
            {
                if (newnodeTag.NodeTye == TreeTag.Types.Category)
                    m_Treeview.Nodes.Add(newNode);
                else
                    m_Node.Nodes.Add(newNode);
            }
            else
                if (selectedTag.NodeTye == TreeTag.Types.Serie)
                {
                    if (newnodeTag.NodeTye == TreeTag.Types.Serie)
                    {
                        parentNode = m_Node.Parent;
                        m_Node.Nodes.Add(newNode);
                    }
                    else
                        m_Node.Nodes.Add(newNode);
                }
                else
                {
                    if (newnodeTag.NodeTye == TreeTag.Types.Line)
                    {
                        parentNode = m_Node.Parent;
                        m_Node.Nodes.Add(newNode);
                    }
                    else
                        m_Node.Nodes.Add(newNode);
                }
            m_Treeview.EndUpdate();
            m_Treeview.Refresh();
        }
        void itemCreateCategory_Click(object sender, EventArgs e)
        {
            CreateCategory();
        }
        public void CreateCategory()
        {
            frmCreateCategory frmCreate = new frmCreateCategory();
            frmCreate.AddNode = AddNodeToTree;
            frmCreate.ShowDialog();
        }
        
        public void Init(TreeNode node)
        {
            m_Node = node;
            TreeTag treetag = m_Node.Tag as TreeTag;
            if (treetag == null) return;
            itemCreateCategory.Visible = false;
            itemCreateSerie.Visible = false;
            itemCreateLine.Visible = false;
            if (treetag.NodeTye == TreeTag.Types.Category)
            {
                itemCreateCategory.Visible = true;
                itemCreateSerie.Visible = true;

            }
            if (treetag.NodeTye == TreeTag.Types.Serie)
            {
                itemCreateSerie.Visible = true;
                itemCreateLine.Visible = true;
            }
            if (treetag.NodeTye == TreeTag.Types.Line)
            {
                itemCreateLine.Visible = true;
            }
            
            this.Show(Cursor.Position);
        }
        private void updateNode(TreeNode node)
        {
            m_Treeview.BeginUpdate();
            m_Treeview.SelectedNode.Name = node.Name;
            m_Treeview.SelectedNode.Text = node.Name;
            m_Treeview.SelectedNode.Tag = node.Tag;
            m_Treeview.EndUpdate();
            m_Treeview.Refresh();
        }
        public void itemEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }
        public bool Edit()
        {
            TreeTag treetag = m_Node.Tag as TreeTag;
            if (treetag == null) return false;
            try
            {
                if (treetag.NodeTye == TreeTag.Types.Category)
                {
                    Category cate;
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        cate = uow.CategoryRepository.Find(treetag.CateId);
                        uow.Commit();
                    }
                    if (cate == null) return false;
                    frmEditCategory frmEdit = new frmEditCategory(cate);
                    frmEdit.UpdateNode = updateNode;
                    frmEdit.ShowDialog();
                }
                if (treetag.NodeTye == TreeTag.Types.Serie)
                {
                    Series serie;
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        serie = uow.SeriesRepository.Find(treetag.SerieId);
                        uow.Commit();
                    }
                    if (serie == null) return false;
                    frmEditSerie frmEdit = new frmEditSerie(serie, treetag);
                    frmEdit.UpdateNode = updateNode;
                    frmEdit.ShowDialog();
                }
                if (treetag.NodeTye == TreeTag.Types.Line)
                {
                    ProductLine line;
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        line = uow.ProductLineRepository.Find(treetag.LineId);
                        uow.Commit();
                    }
                    if (line == null) return false;
                    frmEditProductLine frmEdit = new frmEditProductLine(line,treetag);
                    frmEdit.UpdateNode = updateNode;
                    frmEdit.ShowDialog();
                }
                return true;
            }
            catch { return false; }
        }
        public void itemDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.Yes)
            {
               bool success = Delete();
                if(success==true)
                    m_Treeview.Nodes.Remove(m_Treeview.SelectedNode);
            }
        }
        public bool Delete()
        {
            TreeTag treetag = m_Node.Tag as TreeTag;
            if (treetag == null) return false;
                try
                {
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        if (treetag.NodeTye == TreeTag.Types.Category)
                        {
                            uow.CategoryRepository.Remove(treetag.CateId);
                        }
                        else
                            if (treetag.NodeTye == TreeTag.Types.Serie)
                            {
                                uow.SeriesRepository.Remove(treetag.SerieId);
                            }
                        else
                                if (treetag.NodeTye == TreeTag.Types.Line)
                                {
                                    uow.ProductLineRepository.Remove(treetag.LineId);
                                }
                        uow.Commit();
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
