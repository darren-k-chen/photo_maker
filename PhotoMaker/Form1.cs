using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This code created by K.J. Chen ( 陳冠儒 )
// Copyright © 2019 K.J. Chen | All Rights Reserved

namespace PhotoMaker
{
    public partial class PhotoMakerForm : Form
    {
        public PhotoMakerForm()
        {
            InitializeComponent();
            //GithubButton.Image = imageList1.Images[0];
            //GithubButton.Image = imageList1.Images[1];
        }

        private void PhotoMakerForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
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
            // DeepSkyBlue
        }

        private void FileButton_MouseEnter(object sender, EventArgs e)
        {
            FileButton.BackColor = Color.LightSkyBlue;
        }

        private void FileButton_MouseLeave(object sender, EventArgs e)
        {
            FileButton.BackColor = Color.Transparent;
        }

        private void ProcessButton_MouseEnter(object sender, EventArgs e)
        {
            ProcessButton.BackColor = Color.LightSkyBlue;
        }

        private void ProcessButton_MouseLeave(object sender, EventArgs e)
        {
            ProcessButton.BackColor = Color.Transparent;
        }

        private void PainterButton_MouseEnter(object sender, EventArgs e)
        {
            PainterButton.BackColor = Color.LightSkyBlue;
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
            System.Diagnostics.Process.Start("https://github.com/kj-chen");
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
            GithubButton.BackColor = Color.Black;
            GithubButton.ForeColor = Color.White;
            GithubButton.Image = imageList1.Images[0];
            //GithubButton.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void GithubButton_MouseLeave(object sender, EventArgs e)
        {
            GithubButton.BackColor = Color.Transparent;
            GithubButton.ForeColor = Color.Black;
            GithubButton.Image = imageList1.Images[1];
            //GithubButton.ImageAlign = ContentAlignment.MiddleLeft;
        }
    }
}
