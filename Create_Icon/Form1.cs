using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Create_Icon
{
    public partial class Form1 : Form
    {
        double Prs = 0;
        string[] items = new string[100];
        string df_path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "Resize Icon");

        public Form1() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnImport.Focus();
            if (!new System.IO.DirectoryInfo(df_path).Exists)
                System.IO.Directory.CreateDirectory(df_path);

            for (int i = 0; i < 5000; i++)
            {
                DU_Height.Items.Add(i);
                DU_Width.Items.Add(i);
            }
        }

        public double TimeProcess()
        {
            var Me_App_PRS = Process.GetCurrentProcess();
            var Time = Me_App_PRS.UserProcessorTime.TotalSeconds;
            if (Prs > 0)
            {
                Prs -= Time;
                if (Prs < 0)
                    Prs *= -1;
            }
            else
            {
                Prs = Time;
            }
            return Prs;
        }

        public void ResizeImg(string path, string name, Image img, int width, int height)
        {
            Bitmap bitmap = new Bitmap(img, new Size(width, height));
            bitmap.Save(path + @"\" + name + "." + CB_TypeFile.Text);
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose files image";
            openFileDialog.Multiselect = true;
            DialogResult dialog = openFileDialog.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                items = openFileDialog.FileNames;
                Panel.Text = "Count images : " + items.Count() + System.Environment.NewLine;
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if ((CB_TypeFile.Text == "PNG" || CB_TypeFile.Text == "JPG" || CB_TypeFile.Text == "BMP") && items.Count() > 0)
            {
                for (int i = 0; i < items.Count(); i++)
                {
                    string name = (System.IO.Path.GetFileName(items[i])); // name files
                    string fm_name = name.Substring(0, name.Length - 4); // get name out pas
                    PictureBox picture = new PictureBox();
                    picture.Load(items[i]);
                    Image image = picture.Image;// image
                    ResizeImg(df_path, fm_name, image, int.Parse(DU_Width.Text), int.Parse(DU_Height.Text));
                    Panel.Text += fm_name + " : " + System.IO.File.OpenRead(df_path + @"\" + fm_name + "." + CB_TypeFile.Text).Length / 1024 + " KB" + System.Environment.NewLine;
                }
                Panel.Text += "Resize : " + items.Count();
            }
            else
            {
                Panel.Text = "Choose image & type file";
            }
        }

        private void PictureBox_Android_Click(object sender, EventArgs e)
        {
            if ((CB_TypeFile.Text == "PNG" || CB_TypeFile.Text == "JPG" || CB_TypeFile.Text == "BMP") && items.Count() > 0)
            {
                if (!Directory.Exists(df_path + @"\Android"))
                    Directory.CreateDirectory(df_path + @"\Android");
                string Adderss = df_path + @"\Android";
                int[] size = new int[] { 192, 144, 96, 72, 48 };
                ///  xxxhdpi   xxhdpi   xhdpi   hdpi    mdpi
                string[] TP_Item = { "xxxhdpi", "xxhdpi", "xhdpi", "hdpi", "mdpi" };
                foreach (var item in TP_Item)
                {
                    if (!Directory.Exists(Adderss + @"\" + item))
                        Directory.CreateDirectory(Adderss + @"\" + item);
                }
                //
                for (int i = 0; i < items.Length; i++)
                {
                    int count = 0;
                    foreach (var item in size)
                    {
                        string name = (System.IO.Path.GetFileName(items[i])); // name files
                        string fm_name = name.Substring(0, name.Length - 4); // get name out pas
                        PictureBox picture = new PictureBox();
                        picture.Load(items[i]);
                        Image image = picture.Image;// image
                        ResizeImg(Adderss + @"\" + TP_Item[count], fm_name, image, item, item);
                        count++;
                    }
                }
                Panel.Text = "Craete Icon Android : " + items.Count();
                Panel.Text += "\nTime is : " + TimeProcess() + " S";
            }
            else
            {
                Panel.Text = "Choose image & type file";
            }
        }

        private void PictureBox_IOS_Click(object sender, EventArgs e)
        {
            if ((CB_TypeFile.Text == "PNG" || CB_TypeFile.Text == "JPG" || CB_TypeFile.Text == "BMP") && items.Count() > 0)
            {
                if (!Directory.Exists(df_path + @"\IOS"))
                    Directory.CreateDirectory(df_path + @"\IOS");
                string Adderss = df_path + @"\IOS";

                int[] size_iPhone = new int[] { 180, 120, 80, 60 };
                int[] size_iPad_Pro = new int[] { 167, 80, 58, 40 };
                int[] size_iPad_Mini = new int[] { 152, 80, 58, 40 };

                string[] TP_Item = { "iPhone", "iPad Pro", "iPad Mini" };
                string[] Zero_Item = { "Main", "Spotlight", "Settings", "Notification" };

                foreach (var item in TP_Item)
                {
                    if (!Directory.Exists(Adderss + @"\" + item))
                        Directory.CreateDirectory(Adderss + @"\" + item);
                }

                foreach (var item in TP_Item)
                {
                    foreach (var itemZ in Zero_Item)
                    {
                        if (!Directory.Exists(Adderss + @"\" + item + @"\" + itemZ))
                            Directory.CreateDirectory(Adderss + @"\" + item + @"\" + itemZ);
                    }
                }

                // iPhone 
                for (int i = 0; i < items.Length; i++)
                {
                    int counter = 0;
                    foreach (var item in size_iPhone)
                    {
                        string name = (System.IO.Path.GetFileName(items[i])); // name files
                        string fm_name = name.Substring(0, name.Length - 4); // get name out pas
                        PictureBox picture = new PictureBox();
                        picture.Load(items[i]);
                        Image image = picture.Image;// image
                        ResizeImg(Adderss + @"\iPhone\" + Zero_Item[counter], fm_name, image, item, item);
                        counter++;
                    }
                }

                // iPad Pro
                for (int i = 0; i < items.Length; i++)
                {
                    int counter = 0;
                    foreach (var item in size_iPad_Pro)
                    {
                        string name = (System.IO.Path.GetFileName(items[i])); // name files
                        string fm_name = name.Substring(0, name.Length - 4); // get name out pas
                        PictureBox picture = new PictureBox();
                        picture.Load(items[i]);
                        Image image = picture.Image;// image
                        ResizeImg(Adderss + @"\iPad Pro\" + Zero_Item[counter], fm_name, image, item, item);
                        counter++;
                    }
                }
                // iPad Mini
                for (int i = 0; i < items.Length; i++)
                {
                    int counter = 0;
                    foreach (var item in size_iPad_Mini)
                    {
                        string name = (System.IO.Path.GetFileName(items[i])); // name files
                        string fm_name = name.Substring(0, name.Length - 4); // get name out pas
                        PictureBox picture = new PictureBox();
                        picture.Load(items[i]);
                        Image image = picture.Image;// image
                        ResizeImg(Adderss + @"\iPad Mini\" + Zero_Item[counter], fm_name, image, item, item);
                        counter++;
                    }
                }

                Panel.Text = "Craete Icon IOS : " + items.Count();
                Panel.Text += "\nTime is : " + TimeProcess() + " S";
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e) { Application.Exit(); }

        private void PictureBoxDEL_Click(object sender, EventArgs e)
        {
            if (items.Count() > 0)
            {
                int lenght = items.Count();
                Array.Clear(items, 0, lenght);
                Panel.Text = "Choose image & type file";
            }
        }

        private void PictureBoxClear_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Clear To All Data ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                Directory.Delete(df_path, true);
                Application.Restart();
            }
        }
    }
}
