using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranQuangHuy_2122110458
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ptImage.SizeMode = PictureBoxSizeMode.StretchImage;
            //ptImage.ImageLocation = @"d:\anh.jpg";

            ptImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPG Files (*.jpg )|*.jpg";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                ptImage.ImageLocation = dlg.FileName;
            }    
        }

        private void ptImage_Click(object sender, EventArgs e)
        {
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
