using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void CutButton_Click(object sender, EventArgs e)
        {

        }

        private void CutButton_MouseEnter(object sender, EventArgs e)
        {
            CutButton.BackgroundImage = NegativeConvert(CutButton.BackgroundImage);
            CutButton.BackColor = Color.FromArgb(25, 118, 211);
        }

        private void CutButton_MouseLeave(object sender, EventArgs e)
        {
            CutButton.BackgroundImage = NegativeConvert(CutButton.BackgroundImage);
            CutButton.BackColor = Color.Transparent;
        }

        private void CopyButton_MouseEnter(object sender, EventArgs e)
        {
            CopyButton.BackgroundImage = NegativeConvert(CopyButton.BackgroundImage);
            CopyButton.BackColor = Color.FromArgb(25, 118, 211);
        }

        private void CopyButton_MouseLeave(object sender, EventArgs e)
        {
            CopyButton.BackgroundImage = NegativeConvert(CopyButton.BackgroundImage);
            CopyButton.BackColor = Color.Transparent;
        }

        private void PasteButton_MouseEnter(object sender, EventArgs e)
        {
            PasteButton.BackgroundImage = NegativeConvert(PasteButton.BackgroundImage);
            PasteButton.BackColor = Color.FromArgb(25, 118, 211);
        }

        private void PasteButton_MouseLeave(object sender, EventArgs e)
        {
            PasteButton.BackgroundImage = NegativeConvert(PasteButton.BackgroundImage);
            PasteButton.BackColor = Color.Transparent;
        }

        private void PenButton_MouseEnter(object sender, EventArgs e)
        {
            PenButton.Image = NegativeConvert(PenButton.Image);
            PenButton.BackColor = Color.FromArgb(25, 118, 211);
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
        }

        private void PainterPanelControl_Load(object sender, EventArgs e)
        {

        }

        private void FitButton_MouseEnter(object sender, EventArgs e)
        {
            FitButton.Image = NegativeConvert(FitButton.Image);
            FitButton.BackColor = Color.FromArgb(25, 118, 211);
        }

        private void FitButton_MouseLeave(object sender, EventArgs e)
        {
            FitButton.Image = NegativeConvert(FitButton.Image);
            FitButton.BackColor = Color.Transparent;
        }

        private void ZoomOUT_Button_MouseEnter(object sender, EventArgs e)
        {
            ZoomOUT_Button.Image = NegativeConvert(ZoomOUT_Button.Image);
            ZoomOUT_Button.BackColor = Color.FromArgb(25, 118, 211);
        }

        private void ZoomOUT_Button_MouseLeave(object sender, EventArgs e)
        {
            ZoomOUT_Button.Image = NegativeConvert(ZoomOUT_Button.Image);
            ZoomOUT_Button.BackColor = Color.Transparent;
        }

        private void ZoomIN_Button_MouseEnter(object sender, EventArgs e)
        {
            ZoomIN_Button.Image = NegativeConvert(ZoomIN_Button.Image);
            ZoomIN_Button.BackColor = Color.FromArgb(25, 118, 211);
        }

        private void ZoomIN_Button_MouseLeave(object sender, EventArgs e)
        {
            ZoomIN_Button.Image = NegativeConvert(ZoomIN_Button.Image);
            ZoomIN_Button.BackColor = Color.Transparent;
        }
    }
}
