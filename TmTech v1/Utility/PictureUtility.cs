using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TmTech_v1.ToolBoxCS;

namespace TmTech_v1.Utility
{
    public static class PictureUtility
    {
        public static string filter = "Images (*.JPG,*.PNG)|*.JPG;*.PNG;";
        public static string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TmTech\\Image";
        private static string ServerIP = DbTmTech._dbInfo.Server;
        private static string serverPath = "\\\\" + ServerIP + "\\Development\\Images\\Product";
        public static bool OpenImage(PictureBox ptPicture)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = filter;
            op.ShowDialog();
            if (ValidationUtility.StringIsNull(op.FileName)) return false;
            ptPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ptPicture.Image = Image.FromFile(op.FileName);
            ptPicture.Tag = op.FileName;
            return true;
        }
        public static bool OpenImage(AutoPictureBox ptPicture)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = filter;
            op.ShowDialog();
            if (ValidationUtility.StringIsNull(op.FileName)) return false;
            FileInfo finfo = new FileInfo(op.FileName);
            ptPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ptPicture.Image = Image.FromFile(op.FileName);
            ptPicture.PictureOriginPath = op.FileName;
            ptPicture.PictureName = finfo.Name;
            return true;
        }
        public static string getImgLocation(string imgName)
        {
            if (imgName != null)
            {
                FileInfo finfo = new FileInfo(Path.Combine(serverPath, imgName));
                if (File.Exists(finfo.FullName))
                {
                    return finfo.FullName;
                }
                else
                    return string.Empty;
            }
            else
                return string.Empty;
        }

        public static string getFileName(string fullPath)
        {
            if (string.IsNullOrWhiteSpace(fullPath)) return string.Empty;
            if (!File.Exists(fullPath)) return string.Empty;
            FileInfo finfo = new FileInfo(fullPath);
            return finfo.Name;
        }
        public static string SaveImg(string imgPath)
        {
            if (!Directory.Exists(appDataDir))
            {
                //Directory.CreateDirectory(appDataDir);
                return "";
            }
            try
            {
                string pathToSave = string.Empty;
                //string savePath = string.Empty;
                FileInfo finfo = new FileInfo(imgPath);
                if (File.Exists(imgPath))
                {
                    pathToSave = Path.Combine(serverPath, finfo.Name);
                    if (!File.Exists(pathToSave))
                    {
                        byte[] buf = File.ReadAllBytes(imgPath);
                        FileStream stream = new FileStream(pathToSave, FileMode.Create, FileAccess.Write);
                        stream.Write(buf, 0, buf.Length);
                        stream.Close();
                        stream.Dispose();
                        //Image img = Image.FromFile(imgPath);
                        //Bitmap bmp = new Bitmap(img);
                        //bmp.Save(pathToSave, ImageFormat.Png);
                        return finfo.Name;
                    }
                    else
                        return finfo.Name;
                }
                else
                    return string.Empty;
            }
            catch
            {
                return string.Empty;
            }

        }
        public static Image GetImg(string imgName)
        {
            Image img = null;
            string fullPath = Path.Combine(serverPath, imgName);
            if (File.Exists(fullPath))
            {
                img = Image.FromFile(fullPath);
            }
            else
                img = TmTech_v1.Properties.Resources.unknow;
            return img;
        }
        public static void BindImage(PictureBox ptb, string name)
        {
            try
            {
                string fullPath = Path.Combine(serverPath, name);
                ptb.Tag = fullPath;
                ptb.Image = GetImg(name);
                ptb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                ptb.Image = TmTech_v1.Properties.Resources.unknow;
                ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                return;
            }

        }
        public static void BindImage(AutoPictureBox ptb, string name)
        {
            try
            {
                string fullPath = Path.Combine(serverPath, name);
                ptb.Tag = fullPath;
                ptb.PictureName = name;
                ptb.Image = GetImg(name);
                ptb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                ptb.Image = TmTech_v1.Properties.Resources.unknow;
                ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                return;
            }

        }

       

        public static void BindimageToListView(ImageList imgList, ListView listView)
        {
            int count = 0;
            listView.LargeImageList = imgList;
            foreach (Image img in imgList.Images)
            {
                ListViewItem lst = new ListViewItem();
                CustomModel.ImageTag imgTag = img.Tag as CustomModel.ImageTag;
                lst.Text = imgTag != null ? imgTag.Code : "";
                lst.ImageIndex = count++;
                listView.Items.Add(lst);
            }
        }

        public static void SaveFile(string sourcePath, string networkPath,string filename, string folderName="")
        {
            string path;

            //path = "\\\\ServerName\\ShareName\\targetnewfolder";
            //System.IO.Directory.CreateDirectory(path);
            try
            {
                if (folderName == "")
                    path = @"\\" + networkPath + @"\Development\" + filename;
                else
                    path = @"\\" + networkPath + @"\Development\" + folderName + @"\" + filename;
                FileInfo fileInfo = new FileInfo(path);
                if(!fileInfo.Exists)
                {
                    Directory.CreateDirectory(fileInfo.DirectoryName);
                }
                byte[] buf = File.ReadAllBytes(sourcePath);
                FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
                stream.Write(buf, 0, buf.Length);
                stream.Close();
                stream.Dispose();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}