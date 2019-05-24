using System;
using System.Collections.Generic;
using System.Linq;
using TmTech_v1.Interface;

namespace TmTech_v1.Model
{
    public class ImportMaritalQuerry : BasicQuerry
    {
        public string Stock { get; set; }

    }

    public class BasicQuerry
    {
        public DateTime? dtpFrom { get; set; }
        public DateTime? dtpTo { get; set; }
        public string _Token { get; set; }
    }

    public abstract class BaseSearch<T> where T : CoreEntry
    {

        public BaseSearch()
        {

        }
        public virtual string BuildQuerrySearch()
        {
            return string.Empty;
        }
    }

    public class ImportMaterialBaseSearch : BaseSearch<ImportMaterial>
    {
        private ImportMaritalQuerry _ImportMaritalQuerry;
        public ImportMaterialBaseSearch(ImportMaritalQuerry importMaritalQuerry) : base()
        {
            _ImportMaritalQuerry = importMaritalQuerry;
        }

        public List<ImportMaterial> GetAllSearch()
        {

            List<ImportMaterial> all;

            using (IUnitOfWork uow = new UnitOfWork())
            {
                all = uow.ImportMaterialRepository.GetAll();
            }

            if (all.Count < 1)
                return new List<ImportMaterial>();

            if (!string.IsNullOrEmpty(_ImportMaritalQuerry._Token))
            {
                all = all.Where(x => ((x.ImportCode != null) && x.ImportCode.Contains(_ImportMaritalQuerry._Token)) || ((x.ImportName != null) &&
                    x.ImportName.Contains(_ImportMaritalQuerry._Token))).ToList();
            }

            if (_ImportMaritalQuerry.dtpFrom.HasValue)
            {
                all = all.Where(x => x.CreateDate >= _ImportMaritalQuerry.dtpFrom).ToList();
            }

            if (_ImportMaritalQuerry.dtpTo.HasValue)
            {
                all = all.Where(x => x.CreateDate <= _ImportMaritalQuerry.dtpTo).ToList();
            }

            if (!string.IsNullOrEmpty(_ImportMaritalQuerry.Stock))
            {
                all = all.Where(x => x.StockId == int.Parse(_ImportMaritalQuerry.Stock)).ToList();
            }

            List<ImportMaterial> lstImport = new List<ImportMaterial>();

            using (IUnitOfWork uow = new UnitOfWork())
            {
                foreach (var item in all)
                {
                    var importMaterial = uow.ImportMaterialRepository.GetByID(item.ImportId);
                    if (importMaterial != null)
                    {
                   
                        lstImport.Add(importMaterial);
                    }
                }
            }

            return lstImport;
        }
    }
}
