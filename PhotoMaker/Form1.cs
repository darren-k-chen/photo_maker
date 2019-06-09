using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * |==================================================|
 * |======This code created by K.J. Chen(陳冠儒)======|
 * |=Copyright © 2019 K.J. Chen | All Rights Reserved=|
 * |==================================================|
*/

namespace PhotoMaker
{
    public partial class PhotoMakerForm : Form
    {
        public System.Drawing.Bitmap NegativeConvert(System.Drawing.Image img)
        {
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(img);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    var pixel = bitmap.GetPixel(x, y);

                    System.Drawing.Color newColor = System.Drawing.Color.FromArgb(pixel.A, 255 - pixel.R, 255 - pixel.G, 255 - pixel.B);

                    bitmap.SetPixel(x, y, newColor);
                }
            }
            return bitmap;
        }
        public PhotoMakerForm()
        {
            InitializeComponent();
            processPanelControl2.BackColor = Color.Transparent;
            painterPanelControl2.BackColor = Color.Transparent;
            filePanelControl1.BackColor = Color.Transparent;
            //Install_OTF();
            //GithubButton.Image = imageList1.Images[0];
            //GithubButton.Image = imageList1.Images[1];
            filePanelControl1.Visible = true;
        }

        private void PhotoMakerForm_Load(object sender, EventArgs e)
        {

        }

        //private void Install_OTF()
        //{
        //    string otf_name = "BrushScriptStd_0.otf";
        //    string src_path = @"D:\kjchen\Documents\學習資料\學習課程目錄\C語言\PhotoMaker\PhotoMaker\bin\Debug\Resources";
        //    string trg_path = @"C:\Windows\Fonts";

        //    string src_file = System.IO.Path.Combine(src_path, otf_name);
        //    string dst_file = System.IO.Path.Combine(trg_path, otf_name);

        //    System.IO.File.Copy(src_file, dst_file, true);
        //}

        public void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.Transparent;
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            CloseAllPanelControl();
            filePanelControl1.Visible = true;
        }

        private void FileButton_MouseEnter(object sender, EventArgs e)
        {
            FileButton.BackColor = Color.FromArgb(2, 170, 245);
        }

        private void FileButton_MouseLeave(object sender, EventArgs e)
        {
            FileButton.BackColor = Color.Transparent;
        }

        private void ProcessButton_MouseEnter(object sender, EventArgs e)
        {
            ProcessButton.BackColor = Color.FromArgb(2, 170, 245);
        }

        private void ProcessButton_MouseLeave(object sender, EventArgs e)
        {
            ProcessButton.BackColor = Color.Transparent;
        }

        private void PainterButton_MouseEnter(object sender, EventArgs e)
        {
            PainterButton.BackColor = Color.FromArgb(2, 170, 245);
        }

        private void PainterButton_MouseLeave(object sender, EventArgs e)
        {
            PainterButton.BackColor = Color.Transparent;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GithubButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/kj-chen/photo_maker");
        }

        private void ReadmeLabel_Click(object sender, EventArgs e)
        {

        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void GithubButton_MouseEnter(object sender, EventArgs e)
        {
            GithubButton.BackColor = Color.Black/*FromArgb(128, 255, 128)*/;
            GithubButton.ForeColor = Color.White;
            //GithubButton.Image = null;
            GithubButton.Image = NegativeConvert(GithubButton.Image);
            //GithubButton.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void GithubButton_MouseLeave(object sender, EventArgs e)
        {
            GithubButton.BackColor = Color.Transparent;
            GithubButton.ForeColor = Color.Black;
            //GithubButton.Image = null;
            GithubButton.Image = NegativeConvert(GithubButton.Image);
            //GithubButton.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void ProcessPanelControl1_Load(object sender, EventArgs e)
        {

        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            CloseAllPanelControl();
            processPanelControl2.Visible = true;
        }

        private void CloseAllPanelControl()
        {
            filePanelControl1.Visible = false;
            processPanelControl2.Visible = false;
            painterPanelControl2.Visible = false;
        }

        private void PainterButton_Click(object sender, EventArgs e)
        {
            CloseAllPanelControl();
            painterPanelControl2.Visible = true;
        }
    }
}
