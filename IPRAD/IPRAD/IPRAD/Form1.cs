using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPRAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter="Image File (*.bmp,jpg)| *.bmg;*.jpg";
            if (DialogResult.OK==ofile.ShowDialog())
            {
                this.picOriginal.Image = new Bitmap(ofile.FileName);

            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(this.picOriginal.Image);

            Processing.ConvertToGray(copy);
            this.picResult.Image = copy;
        }
    }
}
