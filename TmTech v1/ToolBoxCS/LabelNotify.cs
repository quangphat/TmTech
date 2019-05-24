using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TmTech_v1.ToolBoxCS
{
    public partial class LabelNotify : Label
    {
        public enum EnumStatus
        {
            Success = 1,
            Failed = 2,
            Other = 0
        }
        private int timeToDisplay = 3000;
        public LabelNotify()
        {
            InitializeComponent();
            if (Status == EnumStatus.Other)
                Text = "message";
        }

        public EnumStatus Status { get; set; }
       

        public int TimeToDisplay
        {
            set { timeToDisplay = value; }
        }

        public void  SetText(string notifyStr, EnumStatus pStatus, int? timeDisplay = 3000)
        {
            Status = pStatus;
            if (Status == EnumStatus.Success)
                ForeColor = ColorTranslator.FromHtml("#3498DB");
            else if (Status == EnumStatus.Failed)
                ForeColor = Color.OrangeRed ;
            timeToDisplay = timeDisplay.Value;
            Text = notifyStr;
            Update();
            var thread1 = new Thread(DoSleep);
            thread1.Start();
            //thread1.Abort();
        }

        private void DoSleep()
        {
            Thread.Sleep(timeToDisplay);
            if (IsHandleCreated)
                Invoke((Action) delegate { Text = ""; });
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}