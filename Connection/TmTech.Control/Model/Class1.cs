using System.Windows.Forms;

namespace TmTech.Control.Model
{
   public class TreeNodeModel
    {
        public string NameNode { get; set; }
        public string TextNode { get; set; }
        public int IconImgae { get; set; }
        public string ImageKey { get; set; }
        public TreeNode TreeNodeParrent { get; set; }

        public TreeNodeModel TreeNodeModels { get { return this; } }
        public TreeNodeModel()
        {
            IconImgae = 1;
        }
    }
    


  
}
