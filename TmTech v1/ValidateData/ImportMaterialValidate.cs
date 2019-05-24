using System;
using System.Collections.Generic;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.ValidateData
{
    public class ImportMaterialValidate : BaseValidate<ImportMaterial>
    {

        public ImportMaterialValidate() : base()
        {

        }
        public override List<ErrorData> CheckValidate(ImportMaterial model,IUnitOfWork uow)
        {

            List<ErrorData> lstError = new List<ErrorData>();
            ImportMaterial _importMaterial;
            //check  user interface

            if(model.ImportCode == string.Empty)
            {
                ErrorData error = new ErrorData
                {
                    ErrorTitle = "",
                    MessageError = ""
                };
                lstError.Add(error);
                return lstError;
            }

                _importMaterial = uow.ImportMaterialRepository.GetExistCode(model.ImportCode);
                if(_importMaterial!=null)
                {
                    ErrorData error = new ErrorData
                    {
                        ErrorTitle =  "",
                         MessageError  = "" 
                    };
                    lstError.Add(error);
                }
            
            return lstError;
        }
    }


    public class ImportMaterialDetailValidate : BaseValidate<ImportMaterialDetail>
    {

        public ImportMaterialDetailValidate() : base()
        {

        }
        public override List<ErrorData> CheckValidate(ImportMaterialDetail model, IUnitOfWork uow)
        {
            List<ErrorData> lstError = new List<ErrorData>();
            if (model.ImportId == Guid.Empty)
            {
                ErrorData error = new ErrorData
                {
                    ErrorTitle = "Thiếu thông tin",
                    MessageError = " phiếu nhập nguyên vật liệu "
                };
                lstError.Add(error);
            }

            return lstError;

        }
        public override List<ErrorData> CheckValidate(ImportMaterialDetail model)
        {
            return base.CheckValidate(model);
        }
        public override List<ErrorData> CheckValidateUpdate(ImportMaterialDetail model, IUnitOfWork uow)
        {
            List<ErrorData> lstError = new List<ErrorData>();
            if (model.ImportId == Guid.Empty)
            {
                ErrorData error = new ErrorData
                {
                    ErrorTitle = "Thiếu thông tin ",
                    MessageError = "phiếu nhập liệu"
                };
                lstError.Add(error);
                return lstError;
            }
            return lstError;
        }
    }
    public abstract class BaseValidate<T> where T : Model.CoreEntry
    {
        public BaseValidate()
        {

        }

        public virtual List<ErrorData> CheckValidate(T model,IUnitOfWork uow)
        {
            return null;
        }
        public virtual List<ErrorData> CheckValidate(T model)
        {
            return null;
        }


        public virtual List<ErrorData> CheckValidateUpdate(T model, IUnitOfWork uow)
        {
            return null;
        }
    }

}
