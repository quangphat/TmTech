using System.Collections.Generic;
using System.Linq;
using TmTech_v1.Interface;

namespace TmTech_v1.Model
{
    public class MaterialQuerry : BasicQuerry
    {
        public string SupplierID { get; set; }

    }

    public class MaterialSearch : BaseSearch<Material>
    {
        private MaterialQuerry _MaterialQuerry;
        public MaterialSearch(MaterialQuerry materialQuerry) : base()
        {

            _MaterialQuerry = materialQuerry;
        }

        public List<Material> GetAllSearch()
        {
            List<Material> all;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                all = uow.MaterialRepository.All();
            }
            if (all.Count < 1)
                return new List<Material>();
            if (!string.IsNullOrEmpty(_MaterialQuerry._Token))
            {
                all = all.Where(x => ((x.MaterialCode != null) && x.MaterialCode.Contains(_MaterialQuerry._Token)) || ((x.MaterialName != null) &&
                    x.MaterialName.Contains(_MaterialQuerry._Token))).ToList();
            }
            if (_MaterialQuerry.dtpFrom.HasValue)
            {
                all = all.Where(x => x.CreateDate >= _MaterialQuerry.dtpFrom).ToList();
            }
            if (_MaterialQuerry.dtpTo.HasValue)
            {
                all = all.Where(x => x.CreateDate <= _MaterialQuerry.dtpTo).ToList();
            }
            if (!string.IsNullOrEmpty(_MaterialQuerry.SupplierID))
            {
                all = all.Where(x => x.SupplierId == int.Parse(_MaterialQuerry.SupplierID)).ToList();
            }

            using (IUnitOfWork uow = new UnitOfWork())
            {
                foreach (var item in all)
                {
                    item.Supplier = uow.SupplierRepository.Find(item.SupplierId);
                    //item.GropsupplierMaterial = uow.group.Find(item.GroupPartId);
                    //item.TypePartMaterial = uow.TypePartRepository.Find(item.TypePartId);
                    //item.SeriesPartMaterial = uow.SeriesPartRepository.Find(item.SeriesPartId);
                    item.UnitMaterial = uow.UnitRepository.Find(item.UnitId);
                }
            }
            
            return all;
        }
    }
}
