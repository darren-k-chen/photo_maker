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
            QuitButton.ForeColor = Color.White;
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
            var f = this.TopLevelControl as PhotoMakerForm;
            f.DeleteFile();
            SaveFileButton.Enabled = false;
            CloseFileButton.Enabled = false;
            f.ProcessButton.Enabled = false;
            f.PainterButton.Enabled = false;
        }

        private void CloseFileButton_MouseEnter(object sender, EventArgs e)
        {
            CloseFileButton.BackColor = Color.FromArgb(2, 170, 245);
        }

        private void CloseFileButton_MouseLeave(object sender, EventArgs e)
        {
            CloseFileButton.BackColor = Color.Transparent;
        }

        public void OpenFileButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            if(f.OpenFile())
            {
                SaveFileButton.Enabled = true;
                CloseFileButton.Enabled = true;
                f.ProcessButton.Enabled = true;
                f.PainterButton.Enabled = true;
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.Close();
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            var f = this.TopLevelControl as PhotoMakerForm;
            f.SaveFile();
        }
    }
}
