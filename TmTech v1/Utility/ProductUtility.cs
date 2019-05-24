
using DevExpress.XtraGrid;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using TmTech_v1.Interface;

namespace TmTech_v1.Utility
{
    public class ProductUtility
    {
        readonly TreeView _mTree;

        public static string[] QuotationDetailToDescription = {"quotationdetailid","vat", "warrantytime", "deliverytime", "quotationdetailcode"
                                                                  , "quotationcode", "productid", "supplierid", "quantity", "baseprice", "quotationprice"
                                                                  , "discount", "note", "quotation", "product", "totaldescription", "totalmoney"
                                                                  , "createdate", "createby", "modifyby", "modifydate" };
        static GridUtility _gridUtility;
        public static List<CustomModel.CustomProduct> SearchAll(string searchStr)
        {
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    return uow.ProductRepository.FindToCustom(searchStr);
                }
            }
            catch
            {
                return null;
            }
        }
        public static void AddProductToGrid(IList<CustomModel.CustomProduct> lstProduct, GridControl grid)
        {
            _gridUtility = new GridUtility(grid);
            if (lstProduct == null)
                return;
            IList<CustomModel.CustomProduct> lstSource = grid.DataSource as IList<CustomModel.CustomProduct>;
            if (lstSource == null)
                lstSource = new List<CustomModel.CustomProduct>();
            foreach(CustomModel.CustomProduct poProduct in lstProduct)
            {
                if (poProduct.QuotationPrice <= 0)
                    poProduct.QuotationPrice = poProduct.BasePrice;
                CustomModel.CustomProduct exists = lstSource.Where(p => p.ProductId == poProduct.ProductId).FirstOrDefault();
                if (exists != null)
                    exists.Quantity += poProduct.Quantity;
                else
                {
                    if (poProduct.Quantity == 0)
                        poProduct.Quantity = 1;
                    lstSource.Add(poProduct);
                }
                    
            }
            _gridUtility.BindingData<CustomModel.CustomProduct>(lstSource);
        }
        public static string ConvertToDescription<T>(T obj)where T:class
        {
            string description = "";
            PropertyInfo[] propInfos = obj.GetType().GetProperties();
            if (propInfos != null)
            {
                foreach (PropertyInfo prop in propInfos)
                {
                    description += prop.Name + ": " + prop.GetValue(obj) + "\n";
                }
            }
            return description;
        }
        public static string ConvertToDescription<T>(T obj,string[] ignore,int newline=1) where T : class
        {
            string description = "";
            if (obj == null) return string.Empty;
            string value = "";
            PropertyInfo[] propInfos = obj.GetType().GetProperties();
            if (propInfos != null)
            {
                foreach (PropertyInfo prop in propInfos)
                {
                    if (!ignore.Contains(prop.Name.ToLower()))
                    {
                        value = prop.GetValue(obj)!=null?prop.GetValue(obj).ToString():"";
                        if (!string.IsNullOrWhiteSpace(value))
                        {
                            if (newline == 1)
                                description += prop.Name + ": " + value + "\n";
                            else
                                description += prop.Name + ": " + value + "\n\n";
                        }
                    }
                }
            }
            return description;
        }
        public static void AddMaterialToProduct(IList<Model.Material> lstProductMaterial, Model.Product product)
        {
            if (lstProductMaterial == null)
                return;
            IList<Model.Material> lstExist;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstExist = uow.MaterialRepository.GetMaterialByProductId(product.ProductId);
                if (lstExist == null) lstExist = new List<Model.Material>();
                foreach (Model.Material material in lstProductMaterial)
                {
                    Model.Material exist = lstExist.Where(p => p.MaterialId == material.MaterialId && p.ProductId == product.ProductId).FirstOrDefault();
                    if (material.MaterialQuantity > 0)
                    {
                        if (exist != null)
                        {
                            //false to update.
                            uow.MaterialRepository.AddToProduct(material.MaterialId, product.ProductId, material.MaterialQuantity, false);
                        }
                        else
                        {
                            uow.MaterialRepository.AddToProduct(material.MaterialId, product.ProductId, material.MaterialQuantity, true);
                        }
                    }
                    else
                        if (exist != null && exist.MaterialQuantity > 0 && material.MaterialQuantity == 0)
                        {
                            uow.MaterialRepository.RemoveFromProduct(material.MaterialId, product.ProductId);
                        }
                }
                uow.Commit();
            }
        }
       
        public ProductUtility(TreeView tree)
        {
            _mTree = tree;
        }


        public static List<Model.Category> GetRoot(IUnitOfWork uow)
        {
            List<Model.Category> lstCategory;
            lstCategory = uow.CategoryRepository.All();
            return lstCategory;
        }
        public static List<Model.ProductLine> GetLine(IUnitOfWork uow,int SerieId)
        {
            List<Model.ProductLine> lstLine;
            lstLine = uow.ProductLineRepository.FindBySerie(SerieId);
            return lstLine;
        }
        public static List<Model.Series> GetSerie(IUnitOfWork uow, int cateId)
        {
            List<Model.Series> lstSerie;
            lstSerie = uow.SeriesRepository.FindByCategory(cateId);
            return lstSerie;
        }
        public static List<Model.Product> FindProductByParent(TreeTag tag)
        {
            List<Model.Product> lstProduct = null;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                if (tag.NodeTye == TreeTag.Types.Category)
                {
                    lstProduct = uow.ProductRepository.FindByCategory(tag.CateId);
                    uow.Commit();
                }
                else
                    if (tag.NodeTye == TreeTag.Types.Serie)
                    {
                        lstProduct = uow.ProductRepository.FindBySerie(tag.SerieId);
                    }
                else
                        if (tag.NodeTye == TreeTag.Types.Line)
                        {
                            lstProduct = uow.ProductRepository.FindByLine(tag.LineId);
                        }
                uow.Commit();
            }
            return lstProduct;
        }
        public void BuildRoot()
        {
            using(IUnitOfWork uow = new UnitOfWork())
            {
                IList<Model.Category> lstCategory = uow.CategoryRepository.All();
                if (lstCategory == null) return;
                TreeTag treeTag;
                foreach (Model.Category cate in lstCategory)
                {
                    TreeNode node = new TreeNode(cate.CategoryName);
                    treeTag = new TreeTag();
                    treeTag.NodeTye = TreeTag.Types.Category;
                    treeTag.CateId = cate.CategoryId;
                    treeTag.CateName = cate.CategoryName;
                    node.Tag = treeTag;
                    List<Model.Series> lstSerie = uow.SeriesRepository.FindByCategory(cate.CategoryId);
                    
                    BuildSerie(lstSerie, node, treeTag, uow);
                    _mTree.Nodes.Add(node);
                }
                uow.Commit();
            }
            
        }
        private void BuildSerie(List<Model.Series> lstSerie, TreeNode subNode, TreeTag subTag, IUnitOfWork uow)
        {
            if (lstSerie == null) return;
            foreach (Model.Series serie in lstSerie)
            {
                TreeNode node = new TreeNode(serie.SerieName);
                TreeTag treeTag = new TreeTag();
                treeTag.NodeTye = TreeTag.Types.Serie;
                treeTag.CateId = subTag.CateId;
                treeTag.CateName = subTag.CateName;
                treeTag.SerieId = serie.SerieId;
                treeTag.SerieName = serie.SerieName;
                node.Tag = treeTag;
                subNode.Nodes.Add(node);
                List<Model.ProductLine> lstLine = uow.ProductLineRepository.FindBySerie(serie.SerieId);
                BuildLine(lstLine, node, treeTag);
            }
        }
        private void BuildLine(List<Model.ProductLine> lstLine,TreeNode cateNode,TreeTag Tag)
        {
            if (lstLine == null) return;
            foreach(Model.ProductLine line in lstLine)
            {
                TreeNode node = new TreeNode(line.ProductLineName);
                TreeTag treeTag = new TreeTag();
                treeTag.NodeTye = TreeTag.Types.Line;
                treeTag.CateId = Tag.CateId;
                treeTag.CateName = Tag.CateName;
                treeTag.LineId = line.ProductLineId;
                treeTag.LineName = line.ProductLineName;
                treeTag.SerieName = Tag.SerieName;
                treeTag.SerieId = Tag.SerieId;
                node.Tag = treeTag;
                cateNode.Nodes.Add(node);
            }
        }
        
        public void BuildRootPart()
        {
            
            using (IUnitOfWork uow = new UnitOfWork())
            {
                IList<Model.GroupPart> lstGroupPart = uow.GroupPartBaseRepository.All();
                if (lstGroupPart == null) return;
                TreeTagPart treeTag;
                foreach (Model.GroupPart cate in lstGroupPart)
                {
                    TreeNode node = new TreeNode(cate.GroupPartName);
                    treeTag = new TreeTagPart();
                    treeTag.NodeTye = TreeTagPart.Types.GroupPart;
                    treeTag.GroupPartIDTag = cate.GroupPartId;
                    node.Tag = treeTag;
                    List<Model.TypePart> lstTypePart = uow.TypePartBaseRepository.FindByGroupID(cate.GroupPartId);
                    if (lstTypePart == null) return;
                    BuildSubPart(lstTypePart, node, treeTag, uow);
                    _mTree.Nodes.Add(node);
                }
                uow.Commit();
            }

        }
        private void BuildSubPart(List<Model.TypePart> lstTypepart, TreeNode nodeGrouppart, TreeTagPart cateTag, IUnitOfWork uow)
        {
            foreach (Model.TypePart sub in lstTypepart)
            {
                TreeNode node = new TreeNode(sub.TypePartName);
                TreeTagPart treeTag = new TreeTagPart();
                treeTag.NodeTye = TreeTagPart.Types.TypePart;
                treeTag.GroupPartIDTag = cateTag.GroupPartIDTag;
                treeTag.TypePartIDTag = sub.TypePartID;
                node.Tag = treeTag;
                nodeGrouppart.Nodes.Add(node);
                List<Model.SeriesPart> lstSerie = uow.SeriesPartBaseRepository.FindByTypeID(sub.TypePartID);
                if (lstSerie == null) return;
                BuildSeriePart(lstSerie, treeTag, node, uow);
            }
        }

       
        private void BuildSeriePart(List<Model.SeriesPart> lstSeriesPart, TreeTagPart subTag, TreeNode subNode, IUnitOfWork uow)
        {
            foreach (Model.SeriesPart serie in lstSeriesPart)
            {
                TreeNode node = new TreeNode(serie.SeriesPartName);
                TreeTagPart treeTag = new TreeTagPart();
                treeTag.NodeTye = TreeTagPart.Types.SeriesPart;
                treeTag.GroupPartIDTag = subTag.GroupPartIDTag;
                treeTag.TypePartIDTag = subTag.TypePartIDTag;
                treeTag.SeriesPartIDTag = serie.SeriesPartId;
                node.Tag = treeTag;
                subNode.Nodes.Add(node);
                List<Model.Part> lstPart = uow.PartBaseRepository.FindBySeriesPartID(serie.SeriesPartId);
                BuildPart(lstPart, treeTag, node);
            }
        }
    
         private void BuildPart(List<Model.Part> lstSerie, TreeTagPart subTag, TreeNode subNode)
        {
            foreach (Model.Part serie in lstSerie)
            {
                TreeNode node = new TreeNode(serie.PartName);
                TreeTagPart treeTag = new TreeTagPart();
                treeTag.NodeTye = TreeTagPart.Types.Part;
                treeTag.GroupPartIDTag = subTag.GroupPartIDTag;
                treeTag.TypePartIDTag = subTag.TypePartIDTag;
                treeTag.SeriesPartIDTag = serie.SeriesPartID;
                treeTag.PartIDTag = serie.PartID;
                treeTag.PartNumber = serie.PartNumber;
                node.Tag = treeTag;
                subNode.Nodes.Add(node);
            }
        }

        public static TreeNode FindNodePart(TreeNodeCollection NodesCollection, TreeTagPart treeTag)
        {
            TreeNode returnNode = null; // Default value to return
            foreach (TreeNode checkNode in NodesCollection)
            {
                if (checkNode.Tag == treeTag)  //checks if this node name is correct
                    returnNode = checkNode;
                else if (checkNode.Nodes.Count > 0) //node has child
                {
                    returnNode = FindNodePart(checkNode.Nodes, treeTag);
                }

                if (returnNode != null) //check if founded do not continue and break
                {
                    return returnNode;
                }

            }
            return null;
        }
        public static TreeNode FindNode(TreeNodeCollection NodesCollection, TreeTag treeTag)
        {
            TreeNode returnNode = null; // Default value to return
            foreach (TreeNode checkNode in NodesCollection)
            {
                if (checkNode.Tag == treeTag)  //checks if this node name is correct
                    returnNode = checkNode;
                else if (checkNode.Nodes.Count > 0) //node has child
                {
                    returnNode = FindNode(checkNode.Nodes, treeTag);
                }

                if (returnNode != null) //check if founded do not continue and break
                {
                    return returnNode;
                }

            }
            return null;
        }
    }
    public class TreeTag
    {
        public enum Types { Category, Line, Serie };
        public int CateId {get;set;}
        public string CateName { get; set; }
        public int LineId {get;set;}
        public string LineName { get; set; }
        public int SerieId {get;set;}
        public string SerieName { get; set; }
        private Types nodeType = Types.Category;
        public Types NodeTye
        {
            get
            {
                return nodeType;
            }
            set
            {
                nodeType = value;
            }
        }
    }

    public class TreeTagPart
    {
        public enum Types { GroupPart, TypePart, SeriesPart,Part };
        public int GroupPartIDTag { get; set; }
        public int TypePartIDTag { get; set; }
        public int SeriesPartIDTag { get; set; }
        public int PartIDTag { get; set; }  
        public string PartNumber { get; set; }
        private Types nodeType = Types.GroupPart;
        public Types NodeTye
        {
            get
            {
                return nodeType;
            }
            set
            {
                nodeType = value;
            }
        }
    }

    public class TreePart
    {
        public enum Types { GroupPart, TypePart, SeriesPart};
        public System.Guid GroupPartID { get; set; }
        public System.Guid TypePartID { get; set; }
        public System.Guid SeriesPartID { get; set; }
        private Types nodeType = Types.GroupPart;
        public Types NodeTye
        {
            get
            {
                return nodeType;
            }
            set
            {
                nodeType = value;
            }
        }
    }
}
