
using DevExpress.XtraGrid.Views.Grid;
using TmTech_v1.Utility;

namespace TmTech_v1.Model
{
 public class RequestPaymentParameter
    {
      public bool  IsEdit { get; set; }
      public int CompanyId { get; set; }
      public PaymentRequest RequestPayment { get; set; }

      public delegate void SaveRequestPayment(RequestPaymentParameter requestPaymentParameter);
      public SaveRequestPayment SaveRequest { get; set; }

    }


  public class BaseRequestCreateData <T>
    {
        public bool IsEdit { get; set; }
        public T Model { get; set; }
        public delegate void delgAddNewOrUpdate(T material, CRUD flag);
        public delgAddNewOrUpdate AddOrUpdateRow;
        public GridView gridview;

    }

    public class  MaterialRequestDataBase:BaseRequestCreateData<Model.Material>
    {

    }

    public class ImportMaterialRequestDataBase : BaseRequestCreateData<Model.ImportMaterial>
    {

    }
}
