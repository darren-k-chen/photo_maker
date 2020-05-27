using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing.Bitmap;

/*
 * |==================================================|
 * |======This code created by K.J. Chen(陳冠儒)======|
 * |=Copyright © 2019 K.J. Chen | All Rights Reserved=|
 * |==================================================|
*/

namespace PhotoMaker.PanelControls
{
    public partial class ProcessPanelControl : UserControl
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

        public ProcessPanelControl()
        {
            InitializeComponent();
        }

        private void NegativeButton_MouseEnter(object sender, EventArgs e)
        {
            NegativeButton.Image = NegativeConvert(NegativeButton.Image);
            NegativeButton.ForeColor = Color.Black;
        }

        private void NegativeButton_MouseLeave(object sender, EventArgs e)
        {
            NegativeButton.Image = NegativeConvert(NegativeButton.Image);
            NegativeButton.ForeColor = Color.White;
        }

        private void NegativeButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.IntegrationProcessing();
        }

        private void BinarizationButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.IntegrationProcessing("BINARY");
            //f.PictureNegativeConvert();
        }

        private void MeanGrayScaleButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.IntegrationProcessing("GRAY", 'M');
        }

        private void LightGrayScaleButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.IntegrationProcessing("GRAY");
        }

        private void FilterRedButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.IntegrationProcessing("RGB", 'R');
        }

        private void FilterGreenButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.IntegrationProcessing("RGB", 'G');
        }

        private void FilterBlueButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.IntegrationProcessing("RGB", 'B');
        }
    }
}
