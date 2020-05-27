using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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

namespace PhotoMaker.PanelControls
{
    public partial class PainterPanelControl : UserControl
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
        public PainterPanelControl()
        {
            InitializeComponent();

            PenButton.Image = NegativeConvert(PenButton.Image);
            PasteButton.BackgroundImage = NegativeConvert(PasteButton.BackgroundImage);
            CopyButton.BackgroundImage = NegativeConvert(CopyButton.BackgroundImage);
            CutButton.BackgroundImage = NegativeConvert(CutButton.BackgroundImage);
            PaletteButton.Image = NegativeConvert(PaletteButton.Image);
            FitButton.Image = NegativeConvert(FitButton.Image);
            ZoomIN_Button.Image = NegativeConvert(ZoomIN_Button.Image);
            ZoomOUT_Button.Image = NegativeConvert(ZoomOUT_Button.Image);

            LineButton.Image = NegativeConvert(LineButton.Image);
            EllipseButton.Image = NegativeConvert(EllipseButton.Image);
            RectangleButton.Image = NegativeConvert(RectangleButton.Image);

            BigCutButton.Image = NegativeConvert(BigCutButton.Image);
            BigCopyButton.Image = NegativeConvert(BigCopyButton.Image);
            BigPasteButton.Image = NegativeConvert(BigPasteButton.Image);

            DotButton.BackColor = Color.Transparent;
            DashDotDotButton.BackColor = Color.Transparent;
            DashDotButton.BackColor = Color.Transparent;
            DashButton.BackColor = Color.Transparent;
            SolidButton.BackColor = Color.Transparent;
        }

        private void CutButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            Clipboard.SetImage(f.pictureBox1.Image);
            f.pictureBox1.Image = null;
        }

        private void CutButton_MouseEnter(object sender, EventArgs e)
        {
            CutButton.BackgroundImage = NegativeConvert(CutButton.BackgroundImage);
            CutButton.BackColor = Color.FromArgb(25, 118, 211);
            CutButton.ForeColor = Color.Black;
        }

        private void CutButton_MouseLeave(object sender, EventArgs e)
        {
            CutButton.BackgroundImage = NegativeConvert(CutButton.BackgroundImage);
            CutButton.BackColor = Color.Transparent;
            CutButton.ForeColor = Color.White;
        }

        private void CopyButton_MouseEnter(object sender, EventArgs e)
        {
            CopyButton.BackgroundImage = NegativeConvert(CopyButton.BackgroundImage);
            CopyButton.BackColor = Color.FromArgb(25, 118, 211);
            CopyButton.ForeColor = Color.Black;
        }

        private void CopyButton_MouseLeave(object sender, EventArgs e)
        {
            CopyButton.BackgroundImage = NegativeConvert(CopyButton.BackgroundImage);
            CopyButton.BackColor = Color.Transparent;
            CopyButton.ForeColor = Color.White;
        }

        private void PasteButton_MouseEnter(object sender, EventArgs e)
        {
            PasteButton.BackgroundImage = NegativeConvert(PasteButton.BackgroundImage);
            PasteButton.BackColor = Color.FromArgb(25, 118, 211);
            PasteButton.ForeColor = Color.Black;
        }

        private void PasteButton_MouseLeave(object sender, EventArgs e)
        {
            PasteButton.BackgroundImage = NegativeConvert(PasteButton.BackgroundImage);
            PasteButton.BackColor = Color.Transparent;
            PasteButton.ForeColor = Color.White;
        }

        private void PenButton_MouseEnter(object sender, EventArgs e)
        {
            PenButton.Image = NegativeConvert(PenButton.Image);
            PenButton.BackColor = Color.FromArgb(25, 118, 211);
            PenButton.ForeColor = Color.Black;
        }

        private void PaletteButton_MouseEnter(object sender, EventArgs e)
        {
            PaletteButton.Image = NegativeConvert(PaletteButton.Image);
            PaletteButton.BackColor = Color.FromArgb(25, 118, 211);
            PaletteButton.ForeColor = Color.Black;
        }

        private void PaletteButton_MouseLeave(object sender, EventArgs e)
        {
            PaletteButton.Image = NegativeConvert(PaletteButton.Image);
            PaletteButton.BackColor = Color.Transparent;
            PaletteButton.ForeColor = Color.White;
        }

        private void PenButton_MouseLeave(object sender, EventArgs e)
        {
            PenButton.Image = NegativeConvert(PenButton.Image);
            PenButton.BackColor = Color.Transparent;
            PenButton.ForeColor = Color.White;
        }

        private void PainterPanelControl_Load(object sender, EventArgs e)
        {

        }

        private void FitButton_MouseEnter(object sender, EventArgs e)
        {
            FitButton.Image = NegativeConvert(FitButton.Image);
            FitButton.BackColor = Color.FromArgb(25, 118, 211);
            FitButton.ForeColor = Color.Black;
        }

        private void FitButton_MouseLeave(object sender, EventArgs e)
        {
            FitButton.Image = NegativeConvert(FitButton.Image);
            FitButton.BackColor = Color.Transparent;
            FitButton.ForeColor = Color.White;
        }

        private void ZoomOUT_Button_MouseEnter(object sender, EventArgs e)
        {
            ZoomOUT_Button.Image = NegativeConvert(ZoomOUT_Button.Image);
            ZoomOUT_Button.BackColor = Color.FromArgb(25, 118, 211);
            ZoomOUT_Button.ForeColor = Color.Black;
        }

        private void ZoomOUT_Button_MouseLeave(object sender, EventArgs e)
        {
            ZoomOUT_Button.Image = NegativeConvert(ZoomOUT_Button.Image);
            ZoomOUT_Button.BackColor = Color.Transparent;
            ZoomOUT_Button.ForeColor = Color.White;
        }

        private void ZoomIN_Button_MouseEnter(object sender, EventArgs e)
        {
            ZoomIN_Button.Image = NegativeConvert(ZoomIN_Button.Image);
            ZoomIN_Button.BackColor = Color.FromArgb(25, 118, 211);
            ZoomIN_Button.ForeColor = Color.Black;
        }

        private void ZoomIN_Button_MouseLeave(object sender, EventArgs e)
        {
            ZoomIN_Button.Image = NegativeConvert(ZoomIN_Button.Image);
            ZoomIN_Button.BackColor = Color.Transparent;
            ZoomIN_Button.ForeColor = Color.White;
        }

        private void FitButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.PictureFit();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            Clipboard.SetImage(f.pictureBox1.Image);
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.pictureBox1.Image = Clipboard.GetImage();
        }

        private void ZoomOUT_Button_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.ZoomOUT();
        }

        private void ZoomIN_Button_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.ZoomIN();
        }

        private void LineButton_MouseEnter(object sender, EventArgs e)
        {
            LineButton.Image = NegativeConvert(LineButton.Image);
            LineButton.BackColor = Color.FromArgb(25, 118, 211);
            LineButton.ForeColor = Color.Black;
        }

        private void LineButton_MouseLeave(object sender, EventArgs e)
        {
            LineButton.Image = NegativeConvert(LineButton.Image);
            LineButton.BackColor = Color.Transparent;
            LineButton.ForeColor = Color.White;
        }

        private void EllipseButton_MouseEnter(object sender, EventArgs e)
        {
            EllipseButton.Image = NegativeConvert(EllipseButton.Image);
            EllipseButton.BackColor = Color.FromArgb(25, 118, 211);
            EllipseButton.ForeColor = Color.Black;
        }

        private void EllipseButton_MouseLeave(object sender, EventArgs e)
        {
            EllipseButton.Image = NegativeConvert(EllipseButton.Image);
            EllipseButton.BackColor = Color.Transparent;
            EllipseButton.ForeColor = Color.White;
        }

        private void RectangleButton_MouseEnter(object sender, EventArgs e)
        {
            RectangleButton.Image = NegativeConvert(RectangleButton.Image);
            RectangleButton.BackColor = Color.FromArgb(25, 118, 211);
            RectangleButton.ForeColor = Color.Black;
        }

        private void RectangleButton_MouseLeave(object sender, EventArgs e)
        {
            RectangleButton.Image = NegativeConvert(RectangleButton.Image);
            RectangleButton.BackColor = Color.Transparent;
            RectangleButton.ForeColor = Color.White;
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {

        }

        private void PaletteButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.ColorChoice();
        }

        private void SolidButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void DashButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        }

        private void DashDotButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void DashDotDotButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
        }

        private void BigCutButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            Clipboard.SetImage(f.pictureBox1.Image);
            f.pictureBox1.Image = null;
        }

        private void BigCutButton_MouseEnter(object sender, EventArgs e)
        {
            BigCutButton.Image = NegativeConvert(BigCutButton.Image);
            BigCutButton.BackColor = Color.FromArgb(2, 170, 245);
            BigCutButton.ForeColor = Color.Black;
        }

        private void BigCutButton_MouseLeave(object sender, EventArgs e)
        {
            BigCutButton.Image = NegativeConvert(BigCutButton.Image);
            BigCutButton.BackColor = Color.Transparent;
            BigCutButton.ForeColor = Color.White;
        }

        private void BigCopyButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            Clipboard.SetImage(f.pictureBox1.Image);
        }

        private void BigCopyButton_MouseEnter(object sender, EventArgs e)
        {
            BigCopyButton.Image = NegativeConvert(BigCopyButton.Image);
            BigCopyButton.BackColor = Color.FromArgb(2, 170, 245);
            BigCopyButton.ForeColor = Color.Black;
        }

        private void BigCopyButton_MouseLeave(object sender, EventArgs e)
        {
            BigCopyButton.Image = NegativeConvert(BigCopyButton.Image);
            BigCopyButton.BackColor = Color.Transparent;
            BigCopyButton.ForeColor = Color.White;
        }

        private void BigPasteButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.pictureBox1.Image = Clipboard.GetImage();
        }

        private void BigPasteButton_MouseEnter(object sender, EventArgs e)
        {
            BigPasteButton.Image = NegativeConvert(BigPasteButton.Image);
            BigPasteButton.BackColor = Color.FromArgb(2, 170, 245);
            BigPasteButton.ForeColor = Color.Black;
        }

        private void BigPasteButton_MouseLeave(object sender, EventArgs e)
        {
            BigPasteButton.Image = NegativeConvert(BigPasteButton.Image);
            BigPasteButton.BackColor = Color.Transparent;
            BigPasteButton.ForeColor = Color.White;
        }
    }
}
