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
    }
}
