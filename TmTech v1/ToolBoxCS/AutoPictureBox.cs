
using System.Windows.Forms;

namespace TmTech_v1.ToolBoxCS
{
    public partial class AutoPictureBox : PictureBox
    {
        private string bindingName;
        public string BindingName
        {
            get
            {
                return bindingName;
            }
            set
            {
                bindingName = value;
            }
        }
        private string bindingFor = "";
        public string BindingFor
        {
            get
            {
                return bindingFor;
            }
            set
            {
                bindingFor = value;
            }
        }
        private string pictureName = "";
        public string PictureName
        {
            get
            {
                return pictureName;
            }
            set
            {
                pictureName = value;
            }
        }
        private string pictureOriginPath = "";
        public string PictureOriginPath
        {
            get
            {
                return pictureOriginPath;
            }
            set
            {
                pictureOriginPath = value;
            }
        }
        private int index = 0;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        public AutoPictureBox()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            
        }
    }
}
