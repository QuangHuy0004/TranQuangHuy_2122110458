using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranQuangHuy_2122110458
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string date = txtDate.Text;
            string faculty = txtFaculty.Text;
            string gender = "";

            if (otp1.Checked)
            {
                gender = "Female";
            }
            else if (otp2.Checked)
            {
                gender = "Male";
            }

            if (user == "" || date == "" || faculty == "" || gender == "")
            {
                MessageBox.Show("Please fill in all fields!");
            }
            else
            {
                //add DataGridView
                dataStatus.Rows.Add(user, date, faculty, gender);
                MessageBox.Show("Add student success");
                //add RichtextBox
                txt_Status.Text = ( user + "\n" + date+ "\n " + faculty+ "\n " + gender);

                // Xóa các trường nhập liệu sau khi thêm
                //txtUser.Clear();
                //txtFaculty.Items.Remove(txtFaculty.SelectedItem);
                //otp1.Checked = false;
                //otp2.Checked = false;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Status_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
