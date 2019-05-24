using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TmTech_v1.Utility;

namespace TmTech_v1.ToolBoxCS
{
    public partial class DisplayMultiplePicture : UserControl
    {
        public string[] ImgList { get; set; }
        private int selectIndex = 0;
        public DisplayMultiplePicture()
        {
            InitializeComponent();
            ImgList = new string[5];
        }
        public DisplayMultiplePicture(string[] imglst)
        {
            InitializeComponent();
            ImgList = imglst;
            
        }
        public void Show(string[] imglst)
        {
            ImgList = imglst;
            if (ImgList == null) return;
            PictureUtility.BindImage(ptbMain, ImgList[0]);
            PictureUtility.BindImage(ptb0, ImgList[0]);
            PictureUtility.BindImage(ptb1, ImgList[1]);
            PictureUtility.BindImage(ptb2, ImgList[2]);
            PictureUtility.BindImage(ptb3, ImgList[3]);
            PictureUtility.BindImage(ptb4, ImgList[4]);
        }
        public void Show(List<Model.ProductPicture> lstPicture)
        {
            ImgList = new string[5];
            if (lstPicture != null)
            {
                for (int i = 0; i < lstPicture.Count; i++)
                {
                    ImgList[i] = lstPicture[i] != null ? lstPicture[i].Picture : "";
                    if (i == 4) break;
                }
            }
            Show(ImgList);
        }
        public void Add(string imgName)
        {
            int i = 0;
            if (ImgList == null) ImgList = new string[5];
            for (i = 0; i < ImgList.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(ImgList[i]))
                {
                    ImgList[i] = imgName;
                    break;
                }
            }
            Show(ImgList);
            selectIndex = i;
            ShowSelect(i);
        }
        public void Remove(int index)
        {
            if (index < 0 || index > 4) return;
            ImgList[index] = "";
            Show(ImgList);
        }
        private void DisplayMultiplePicture_Load(object sender, EventArgs e)
        {

        }
        private void ShowSelect(int index, PictureBox smallPictureBox)
        {
            if (ImgList == null) return;
            if (index < 0 || index > 4) return;
            PictureUtility.BindImage(ptbMain, ImgList[index]);
            //ptb0.BorderStyle = ptb1.BorderStyle = ptb2.BorderStyle = ptb3.BorderStyle = ptb4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //smallPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        private void ShowSelect(int index)
        {
            AutoPictureBox ptb = ptb0;
            foreach (Control c in this.Controls)
            {
                if (c is AutoPictureBox)
                {
                    ptb = c as AutoPictureBox;
                    if (ptb.Index == index)
                    {
                        ShowSelect(index, ptb);
                        DrawBorder(ptb, ptb.CreateGraphics());
                    }
                }
            }
        }
        private void ptb0_Click(object sender, EventArgs e)
        {
            selectIndex = 0;
            ShowSelect(0, ptb0);
            DrawBorder(ptb0, ptb0.CreateGraphics());
        }

        private void DrawBorder(AutoPictureBox ptb,Graphics g)
        {
            foreach (Control c in this.Controls)
            {
                if (c is AutoPictureBox)
                {
                    AutoPictureBox others = c as AutoPictureBox;
                    //others.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    ControlPaint.DrawBorder(others.CreateGraphics(), others.ClientRectangle, Color.Black,1, ButtonBorderStyle.Solid,Color.Black,1,ButtonBorderStyle.Solid,Color.Black,1,ButtonBorderStyle.Solid,Color.Black,1,ButtonBorderStyle.Solid);
                }
            }
            ControlPaint.DrawBorder(g, ptb.ClientRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }
        private void ptb1_Click(object sender, EventArgs e)
        {
            selectIndex = 1;
            ShowSelect(1, ptb1);
            DrawBorder(ptb1, ptb1.CreateGraphics());
        }

        private void ptb2_Click(object sender, EventArgs e)
        {
            selectIndex = 2;
            ShowSelect(2, ptb2);
            DrawBorder(ptb2, ptb2.CreateGraphics());
        }

        private void ptb3_Click(object sender, EventArgs e)
        {
            selectIndex = 3;
            ShowSelect(3, ptb3);
            DrawBorder(ptb3, ptb3.CreateGraphics());
        }

        private void ptb4_Click(object sender, EventArgs e)
        {
            selectIndex = 4;
            ShowSelect(4, ptb4);
            DrawBorder(ptb4, ptb4.CreateGraphics());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            selectIndex -= 1;
            if (selectIndex < 0) selectIndex = 4;
            ShowSelect(selectIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            selectIndex += 1;
            if (selectIndex > 4) selectIndex = 0;
            ShowSelect(selectIndex);
        }

        private void itemAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = PictureUtility.filter;
            op.ShowDialog();
            if (ValidationUtility.StringIsNull(op.FileName)) return;
            string name = PictureUtility.SaveImg(op.FileName);
            Add(name);
        }

        private void ptbMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void itemRemove_Click(object sender, EventArgs e)
        {
            Remove(selectIndex);
        }

        private void itemView_Click(object sender, EventArgs e)
        {
            string fullpath = PictureUtility.getImgLocation(ImgList[selectIndex]);
            if (string.IsNullOrWhiteSpace(fullpath)) return;
            System.Diagnostics.Process.Start(fullpath);
        }

        private void ptbMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            itemView.PerformClick();
        }
    }
}
