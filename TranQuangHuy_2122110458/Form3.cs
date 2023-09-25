using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TranQuangHuy_2122110458
{
    public partial class Form3 : Form
    {
        private string text;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form3_1 objform3_1 = new Form3_1();


            objform3_1.SetLabelText(Text);

            objform3_1.ShowDialog();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    }
}
