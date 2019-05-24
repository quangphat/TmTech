using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using TmTech.Control.Model;

namespace TmTech.Control
{
   public class TreeviewControl : TreeView
    {
        ImageList imageList;
       
        public TreeviewControl()
        {
            imageList = new ImageList();
            var pathfolderImage = @"C:\Users\DELL\Documents\Visual Studio 2017\Projects\Connection\TmTech.Control\Image\";
            ResourceSet resourceSet = ImageControl.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            foreach (DictionaryEntry entry in resourceSet)
            {
                string fileName = entry.Value.ToString();
                
                var pathfile = pathfolderImage + fileName;
                try
                {
                    Image imageadd = Image.FromFile(pathfile);
                    imageList.Images.Add(entry.Key.ToString(), imageadd);
                }
                catch (Exception)
                {

                    continue;
                }
            }
           ImageList = imageList;
        }

        
        public virtual void AddNode<T>(T nodeInsert, bool parentNode = true) where T : TreeNodeModel
        {
            if(nodeInsert ==null)
            {
                return;
            }

            TreeNode treeNode = new TreeNode()
            {
                Text = nodeInsert.TextNode,
                Name = nodeInsert.NameNode,
                Tag = nodeInsert.TreeNodeModels,
                ImageKey = nodeInsert.ImageKey,
            };
            if (nodeInsert.TreeNodeParrent == null)
            {
                Nodes.Add(treeNode);
            }
            else

            {
                nodeInsert.TreeNodeParrent.Nodes.Add(treeNode);
            }

            this.SelectedNode = treeNode;
                
        }

        public virtual void BindDataSource<T>(IList<T> lstSource)
        {
            
        }

        public virtual void DeleteNode(TreeNode treeNodeDelete)
        {  
            DialogResult dialogResult = MessageBox.Show("Xác nhận xóa?", "cảnh cáo thao tác",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if(dialogResult ==DialogResult.OK)
            {
                this.Nodes.Remove(treeNodeDelete);
            }
        }

        public virtual void UpdateNode(string TextNode,string NameNode) 
        {

            TreeNode treeNode = this.SelectedNode;
            if (treeNode == null)
                return;
            TreeNodeModel treeNodeModel = ConvertTreeNodeModel(treeNode);
            if (treeNodeModel == null)
                return;
            treeNodeModel.NameNode = NameNode;
            treeNodeModel.TextNode = TextNode;
            treeNode.Text = TextNode;
            treeNode.Name = NameNode;
        }

        public virtual void UpdateOrInsertNode<T>(T node, bool parrentNode = true) where T : TreeNodeModel
        {
            throw new NotImplementedException();
        }
        private TreeNodeModel ConvertTreeNodeModel ( TreeNode treeNode)
        {
            try
            {
              return  treeNode.Tag as TreeNodeModel;
            }
            catch (Exception)
            {

                return null;
            }

        }

    }
}
