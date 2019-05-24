namespace TmTech_v1.Model
{
    public class RequestConfirmForm
    {
        public delegate void HanlerConform(RequestConfirmForm requestConfirm);
        public HanlerConform HanlerConForm { get; set; }
        public RequestConfirmForm()
        {

        }
        public string CurrentStatus { get; set; }
        public string ContentNote { get; set; }
       
    }
}
