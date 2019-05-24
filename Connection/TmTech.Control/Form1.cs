using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TmTech.Control.Model;
using TmTech.SDK.Connection1;

namespace TmTech.Control
{
    public partial class Form1 : Form
    {


        public Form1()
        {

            IConnection iConnection = new Connection();
            if(iConnection.Authorization())
            {
                MessageBox.Show("succes");
            }
            InitializeComponent();

            for(int i =0; i<10; i++)
            {
                TreeNodeModel treeNodeModel = new TreeNodeModel
                {
                    IconImgae = 1,
                    NameNode = "nghia" + i.ToString(),
                    TextNode = "nghia" + i.ToString(),
                    TreeNodeParrent = null,
                    ImageKey = "imageFolder2"
                };
                
                this.treeviewControl1.AddNode(treeNodeModel);
            }

            for (int i = 0; i < 5; i++)
            {
                TreeNodeModel treeNodeModechild = new TreeNodeModel
                {
                    NameNode = "Child" + i.ToString(),
                    TextNode = "Child" + i.ToString(),
                    TreeNodeParrent = treeviewControl1.Nodes[1],
                    ImageKey = "imageFolder"
                };

                this.treeviewControl1.AddNode(treeNodeModechild);
            }





        }
    }
}
