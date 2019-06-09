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

namespace PhotoMaker.UserControls
{
    public partial class FilePanelControl : UserControl
    {
        public FilePanelControl()
        {
            InitializeComponent();
            OpenFileButton.BackColor = Color.Transparent;
            SaveFileButton.BackColor = Color.Transparent;
            CloseFileButton.BackColor = Color.Transparent;
            LanguageChangeButton.ForeColor = Color.White;
        }

        private void FilePanelControl_Load(object sender, EventArgs e)
        {

        }

        private void OpenFileButton_MouseEnter(object sender, EventArgs e)
        {
            OpenFileButton.BackColor = Color.FromArgb(2, 170, 245);
        }

        private void OpenFileButton_MouseLeave(object sender, EventArgs e)
        {
            OpenFileButton.BackColor = Color.Transparent;
        }

        private void SaveFileButton_MouseEnter(object sender, EventArgs e)
        {
            SaveFileButton.BackColor = Color.FromArgb(2, 170, 245);
        }

        private void SaveFileButton_MouseLeave(object sender, EventArgs e)
        {
            SaveFileButton.BackColor = Color.Transparent;
        }

        private void CloseFileButton_Click(object sender, EventArgs e)
        {

        }

        private void CloseFileButton_MouseEnter(object sender, EventArgs e)
        {
            CloseFileButton.BackColor = Color.FromArgb(2, 170, 245);
        }

        private void CloseFileButton_MouseLeave(object sender, EventArgs e)
        {
            CloseFileButton.BackColor = Color.Transparent;
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            //PhotoMakerForm obj = new PhotoMakerForm();
            //obj.Close();
            //obj.CloseButton_Click(sender, e);
        }
    }
}
