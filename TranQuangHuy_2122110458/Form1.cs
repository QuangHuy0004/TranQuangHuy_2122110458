using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TranQuangHuy_2122110458
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("xin chao");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            {
                if (ip_code.Text == "")
                {
                    MessageBox.Show("Please enter a code!");
                    
                }
                else if (ip_name.Text == "")
                {
                    MessageBox.Show("Please enter a name!");
                }
                else if (ip_gender.Text == "")
                {
                    MessageBox.Show("Please select a gender!");
                }
                else if (ip_phone.Text == "")
                {
                    MessageBox.Show("Please enter a phone!");
                }
                else if (ip_faculy.Text == "")
                {
                    MessageBox.Show("Please enter a faculty!");
                }
                else if (ip_class.Text == "")
                {
                    MessageBox.Show("Please enter a class!");
                }
                else if (ip_address.Text == "")
                {
                    MessageBox.Show("Please enter an address!");
                }

                {
                    datastudent.Rows.Add(ip_code.Text, ip_name.Text, ip_gender.Text, ip_phone.Text, ip_date.Text, ip_faculy.Text, ip_class.Text, ip_address.Text);
                    MessageBox.Show("Add student succes");
                }
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void button_edit(object sender, EventArgs e)
        {
            if (datastudent.SelectedCells.Count >= 0)
            {
                int vitri = datastudent.CurrentCell.RowIndex;

                datastudent[0, vitri].Value = ip_code.Text;
                datastudent[1, vitri].Value = ip_name.Text;
                datastudent[2, vitri].Value = ip_gender.Text;
                datastudent[3, vitri].Value = ip_phone.Text;
                datastudent[4, vitri].Value = ip_date.Text;
                datastudent[5, vitri].Value = ip_faculy.Text;
                datastudent[6, vitri].Value = ip_class.Text;
                datastudent[7, vitri].Value = ip_address.Text;
            }
            else
            {
                MessageBox.Show("There's nothing to edit");
            }
        }



        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_FontChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


      

        private void button_delete_Click(object sender, EventArgs e)
        {
           
        }

        private void Delete()
        {
            // Xóa dữ liệu trong các trường nhập liệu sau khi xóa
            ip_code.Clear();
            ip_name.Clear();
            ip_gender.Items.Remove(ip_gender.SelectedItem);
            ip_phone.Clear();
            ip_faculy.Items.Remove(ip_faculy.SelectedItem);
            ip_class.Items.Remove(ip_class.SelectedItem);
            ip_address.Items.Remove(ip_address.SelectedItem);
        }

        private void datastudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ip_code_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void datastudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy dòng được chọn
            DataGridViewRow selectedRow = datastudent.Rows[e.RowIndex];

            // Truy cập dữ liệu trên dòng và hiển thị hoặc sử dụng nó
            string studentCode = selectedRow.Cells[0].Value.ToString();
            string name = selectedRow.Cells[1].Value.ToString();
            string date = selectedRow.Cells[2].Value.ToString();
            string phone = selectedRow.Cells[3].Value.ToString();
            string classs = selectedRow.Cells[4].Value.ToString();
            string gender = selectedRow.Cells[5].Value.ToString();
            string faculy = selectedRow.Cells[6].Value.ToString();
            string address = selectedRow.Cells[7].Value.ToString();

            }

        private void ip_faculy_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void ip_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ip_class2_Click(object sender, EventArgs e)
        {

        }

        private void datastudent_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}