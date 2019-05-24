
//using static TmTech_v1.Model.BaseRequest<T>;

namespace TmTech_v1.Model
{
    public class CompanyRequestForm : BaseRequest<Company>
    {

     }

    public abstract class BaseRequest <T> where T:class
    {
        public T objectRequest;
        public delegate void HandleRepose(T companyReposeView);
        public bool isEdit { get; set; }
       

    }

    public  class CompanyRequestxx:BaseRequest<Company>
    {
        HandleRepose handlerepose;
    }
    public class BaseReponseView <T> where T:class

        {
       
        public T respose;
        }
    
    public class CompanyReponseView  :  BaseReponseView<Company>
    {

    }
}
