using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

            processPanelControl1.BackColor = Color.Transparent;
            painterPanelControl1.BackColor = Color.Transparent;
            filePanelControl2.BackColor = Color.Transparent;

            filePanelControl2.Visible = true;
        }

        bool isMouseDown = false;

        private void PhotoMakerForm_Load(object sender, EventArgs e)
        {

        }

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
            filePanelControl2.Visible = true;

            drawMode = false;
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
            GithubButton.Image = NegativeConvert(GithubButton.Image);
        }

        private void GithubButton_MouseLeave(object sender, EventArgs e)
        {
            GithubButton.BackColor = Color.Transparent;
            GithubButton.ForeColor = Color.Black;
            GithubButton.Image = NegativeConvert(GithubButton.Image);
        }

        private void ProcessPanelControl1_Load(object sender, EventArgs e)
        {

        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            CloseAllPanelControl();
            processPanelControl1.Visible = true;

            drawMode = false;
        }

        private void CloseAllPanelControl()
        {
            filePanelControl2.Visible = false;
            processPanelControl1.Visible = false;
            painterPanelControl1.Visible = false;
        }

        public bool drawMode = false;

        private void PainterButton_Click(object sender, EventArgs e)
        {
            CloseAllPanelControl();
            painterPanelControl1.Visible = true;

            drawMode = true;
        }



        public bool OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Filter = "PNG File(*.PNG)|*.PNG|BMP File(*.BMP)|*.BMP|JPEG File(*.JPG)|*.JPG"
            };
            openFileDialog1.Title = "Open Image File";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

                img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                g = Graphics.FromImage(img);
                openFileDialog1.Dispose();
                return true;
            } else
            {
                openFileDialog1.Dispose();
                return false;
            }
            



        }
        
        public void PictureFit()
        {
            double ratio1, ratio2;
            if (pictureBox1.Image != null)
                ratio1 = (double)pictureBox1.Image.Width /
                    (double)pictureBox1.Image.Height;
            else
            {
                ratio1 = (double)pictureBox1.Width / (double)pictureBox1.Height;
                PictureBoxPanel.AutoScroll = false;
            }

            ratio2 = (double)(PictureBoxPanel.Width - 10) / (double)(pictureBox1.Height - 10);
            if (ratio1 > ratio2)
            {
                pictureBox1.Width = PictureBoxPanel.Width - 10;
                pictureBox1.Height = (int)(pictureBox1.Width / ratio1);
            }
            else
            {
                pictureBox1.Height = (int)(PictureBoxPanel.Height - 10);
                pictureBox1.Width = (int)(pictureBox1.Height * ratio1);
            }
        }

        public void ZoomOUT()
        {
            pictureBox1.Width = (int)((double)pictureBox1.Width * 2);
            pictureBox1.Height = (int)((double)pictureBox1.Height * 2);
            PictureBoxPanel.AutoScroll = true;
            //if (pictureBox1.Width <= 8192 && pictureBox1.Height <= 8192)
            //{
                
            //}
        }

        Graphics g;
        public Pen pen = new Pen(Color.Black, 3);

        Bitmap img;
        Bitmap buf;

        public void ZoomIN()
        {
            pictureBox1.Width = (int)((double)pictureBox1.Width / 2);
            pictureBox1.Height = (int)((double)pictureBox1.Height / 2);
            //if (pictureBox1.Width >= 32 && pictureBox1.Height >= 32)
            //{
            //    pictureBox1.Width = (int)((double)pictureBox1.Width / 2);
            //    pictureBox1.Height = (int)((double)pictureBox1.Height / 2);
            //}
        }

        //public void CopyPictureBoxImage()
        //{
        //    Clipboard.SetImage(pictureBox1.Image);
        //}

        private Bitmap bmpOut;
        private BitmapData dataIn;
        private BitmapData dataOut;
        public void IntegrationProcessing(String flag = "COMPLE", char flag2 = '#')
        {
            Bitmap tmpImage = new Bitmap(pictureBox1.Image);
            int h = tmpImage.Height;
            int w = tmpImage.Width;

            bmpOut = new Bitmap(w, h, PixelFormat.Format24bppRgb);

            dataIn = tmpImage.LockBits(new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            dataOut = bmpOut.LockBits(new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            unsafe
            {
                double gray;
                byte* pIn = (byte*)(dataIn.Scan0.ToPointer());
                byte* pOut = (byte*)(dataOut.Scan0.ToPointer());
                for (int y = 0; y < dataIn.Height; y++)
                {
                    switch (flag)
                    {
                        case "GRAY":
                            for (int x = 0; x < dataIn.Width; x++)
                            {
                                if (flag2 == 'M')
                                    gray = (pIn[0] + pIn[2] + pIn[1]) / 3;
                                else
                                    gray = 0.299 * pIn[2] + 0.587 * pIn[1] + 0.114 * pIn[0];
                                pOut[0] = (byte)gray;
                                pOut[1] = (byte)gray;
                                pOut[2] = (byte)gray;

                                pIn += 3;
                                pOut += 3;
                            }
                            break;
                        case "RGB":
                            for (int x = 0; x < dataIn.Width; x++)
                            {
                                for (int i = 0; i < 3; i++)
                                    pOut[i] = (byte)0;

                                switch (flag2)
                                {
                                    case 'R':
                                        pOut[2] = (byte)pIn[2];
                                        break;
                                    case 'G':
                                        pOut[1] = (byte)pIn[1];
                                        break;
                                    case 'B':
                                        pOut[0] = (byte)pIn[0];
                                        break;
                                }

                                pIn += 3;
                                pOut += 3;
                            }
                            pIn += dataIn.Stride - dataIn.Width * 3;
                            pOut += dataOut.Stride - dataOut.Width * 3;
                            break;
                        case "COMPLE":
                            for (int x = 0; x < dataIn.Width; x++)
                            {
                                for (int i = 0; i < 3; i++)
                                    pOut[i] = (byte)(255 - pIn[i]);
                                pIn += 3;
                                pOut += 3;
                            }
                            break;
                        case "BINARY":
                            for (int x = 0; x < dataIn.Width; x++)
                            {
                                for (int i = 0; i < 3; i++)
                                    pOut[i] = (byte)(255 * ((pIn[0] + pIn[1] + pIn[3]) / 3 < 128 ? 1 : 0));

                                pIn += 3;
                                pOut += 3;
                            }
                            break;
                    }
                    pIn += dataIn.Stride - dataIn.Width * 3;
                    pOut += dataOut.Stride - dataOut.Width * 3;
                }
            }
            bmpOut.UnlockBits(dataOut);
            tmpImage.UnlockBits(dataIn);
            pictureBox1.Image = bmpOut;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        public void SaveFile()
        {
            saveFileDialog1.Filter = "PNG影像(*.PNG)|*.PNG|BMP影像(*.BMP)|*.BMP|JPEG影像(*.JPG)|*.JPG";
            saveFileDialog1.Title = "儲存影像檔";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image.Save(saveFileDialog1.FileName);
        }
        public void DeleteFile() { pictureBox1.Image = null; }

        //private Point Start;
        //private Point End;
        //private Point cutPosit;
        //private Bitmap tmpbmp;
        List<Point> points = new List<Point>();
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //Point p = new Point(e.X, e.Y);
            //isMouseDown = true;
            //points.Clear();
            //points.Add(p);
            //pictureBox1.Image = UniteImage(pictureBox1.Image, img);

            //if (pictureBox1.Image != null && drawMode != 0 &&
            //    e.Button == MouseButtons.Left)
            //{
            //    Start.X = (int)(e.X * (pictureBox1.Image.Width - 1) /
            //        (pictureBox1.Height - 1));
            //    Start.Y = (int)(e.Y * (pictureBox1.Image.Width - 1) /
            //        (pictureBox1.Height - 1));
            //    //if (PasteButton.Checked == true)
            //    //{
            //    //    int cutW = Clipboard.GetImage().Width;
            //    //    int cutH = Clipboard.GetImage().Height;

            //    //    if (Start.X < cutPosit.X || Start.X > cutPosit.X + cutW ||
            //    //        Start.Y < cutPosit.Y || Start.Y > cutPosit.Y + cutH)
            //    //    {
            //    //        PasteButton.Checked = false;
            //    //        drawMode = 0;
            //    //        cutPosit.X = 0;
            //    //        cutPosit.Y = 0;
            //    //    }
            //    //    tmpbmp = bmp;
            //    //}
            //}
        }
        
        public void SolidFont()
        {
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        public void ColorChoice()
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pen.Color = colorDialog1.Color;
        }

        public String ComboBoxMode = "Pen";

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //if(drawMode && pictureBox1.Image != null)
            //{
            //    Point p = new Point(e.X, e.Y);

            //    buf = new Bitmap(img);
            //    Graphics g = Graphics.FromImage(buf);
            //    if (points.Count > 0 && isMouseDown)
            //    {
            //        Point pStart = points[0];
            //        Point pLast = points[points.Count - 1];
            //        if (ComboBoxMode == "Pen")
            //        {
            //            Point p0 = pStart;
            //            foreach (Point p1 in points)
            //            {
            //                g.DrawLine(pen, p0, p1);
            //                p0 = p1;
            //            }
            //        }
            //        else if (ComboBoxMode == "Line")
            //        {
            //            g.DrawLine(pen, pStart, p);
            //        }
            //        else if (ComboBoxMode == "Rectangle")
            //        {
            //            g.DrawRectangle(pen, pStart.X, pStart.Y, p.X - pStart.X, p.Y - pStart.Y);
            //        }
            //        else if (ComboBoxMode == "Ellipse")
            //        {
            //            g.DrawEllipse(pen, pStart.X, pStart.Y, p.X - pStart.X, p.Y - pStart.Y);
            //        }
            //    }
            //    points.Add(p);
            //    pictureBox1.Image = UniteImage(buf, pictureBox1.Image);
            //}
            
        }

        //public void PenClick()
        //{
        //    if (drawMode != 1)
        //        drawMode = 1;
        //    else
        //        drawMode = 0;
        //}

        //public void LineClick()
        //{
        //    if (drawMode != 2)
        //        drawMode = 2;
        //    else
        //        drawMode = 0;
        //}

        private void painterPanelControl1_Load(object sender, EventArgs e)
        {

        }

        public Image UniteImage(Image img1, Image img2, int width = 0, int height = 0)
        {
            if (pictureBox1.Image != null)
            {
                width = pictureBox1.Image.Width;
                height = pictureBox1.Image.Width;
            }
            System.Drawing.Image img = new System.Drawing.Bitmap(width, height);

            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(img);

            g.Clear(System.Drawing.Color.Transparent);

            g.DrawImage(img1, 0, 0, img1.Width, img1.Height);
            g.DrawImage(img2, 0, 0, img2.Width, img2.Height);

            return img;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //isMouseDown = false;
            //img = buf;
            //pictureBox1.Image = UniteImage(pictureBox1.Image, img);
        }
    }
}