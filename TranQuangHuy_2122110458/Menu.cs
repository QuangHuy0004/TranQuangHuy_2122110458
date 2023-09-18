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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void F1_Click(object sender, EventArgs e)
        {
            Form1 objfrom1 = new Form1();
            objfrom1.ShowDialog();
        }

        private void F2_Click(object sender, EventArgs e)
        {
            Form2 objfrom2 = new Form2();
            objfrom2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
