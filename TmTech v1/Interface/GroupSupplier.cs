using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public partial interface IGroupSupplierRepository : IGenericRepository<GroupSupplier>
    {
        List<GroupSupplier> ChildOfGroup(int id);
        List<GroupSupplier> ParrentOfGroup();
        List<string> ParrentOfGroupLoad();
        List<GroupSupplier> ParrentOfGroupRoot();
    }

    public class TreeTagGroupSupplier
    {
        public int GroupId { get; set; }
        public int ParrentId { get; set; }
        public string Status { get; set; }
    }

    public class DiloalugeTreviewParameter
    {
        public string ParrentId { get; set; }
        public string ChildId { get; set; }
        public bool IsUpdate { get; set; }
        public bool IsInsert { get; set; }
        public bool TyepParrent { get; set; }
        public string TextNodeParrent { get; set; }
        public TreeNode Treenode { get; set; }
    }
    public class TreeSupplierModel : BaseRequestForm
    {
        public TreeNode Treenode { get; set; }
        public TreeTagGroupSupplier Treetag { get; set; }
       

    }

    public class BaseRequestForm 
    {
        public bool IsEdit { get; set; }
        public string Id { get; set; }
    }
}