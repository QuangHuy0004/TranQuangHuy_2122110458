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
        private List<string> usedIDs = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("xin chao");
        }
        private bool IsNumeric(string text)
        {
            return int.TryParse(text, out _);
        }

    private void tabPage1_Click(object sender, EventArgs e)
        {
            
            foreach(char c in ip_code.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("The id can only be numbered!");
                    return;
                }
            }
            {
                 

                if (string.IsNullOrEmpty(ip_code.Text))
                {
                    MessageBox.Show("Please enter a code!");
                }
                else if (string.IsNullOrEmpty(ip_name.Text))
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
                else if (string.IsNullOrWhiteSpace(ptImage.ImageLocation))
                {
                    MessageBox.Show("Please select an image!");
                }

                else
                {
                    string imageFileName = System.IO.Path.GetFileName(ptImage.ImageLocation);

                    if (usedIDs.Contains(ip_code.Text))
                    {
                        MessageBox.Show("ID alreadly exists");
                        return;
                    }
                    usedIDs.Add(ip_code.Text);

                    // Add data to DataGridView, including the modified image name
                    int rowIndex = datastudent.Rows.Add(ip_code.Text, ip_name.Text, ip_gender.Text, ip_phone.Text, DateTime.Now.ToString("dd/MM/yyyy"), ip_faculy.Text, ip_class.Text, ip_address.Text, S);



                    MessageBox.Show("Add student success");
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
            if (datastudent.Rows.Count == 0)
            {
                MessageBox.Show("No data available to edit.");
                return;
            }

            if (datastudent.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
            }
            else
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

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datastudent.Rows[e.RowIndex];
                ip_code.Text = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : "";
                ip_name.Text = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "";
               ip_gender.Text = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : "";
               ip_phone.Text = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "";
                ip_faculy.Text = row.Cells[5].Value != null ? row.Cells[5].Value.ToString() : "";
                ip_class.Text = row.Cells[6].Value != null ? row.Cells[6].Value.ToString() : "";
                ip_address.Text = row.Cells[7].Value != null ? row.Cells[7].Value.ToString() : "";
                ptImage.ImageLocation = row.Cells[8].Value.ToString();

            }
        }

        private void ip_code_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void datastudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow selectedRow = datastudent.Rows[e.RowIndex];

            bool isRowEmpty = true;

            foreach (DataGridViewCell cell in selectedRow.Cells)
            {
                if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                    // Nếu có bất kỳ ô nào có giá trị, đánh dấu dòng không trống
                    isRowEmpty = false;
                    break; // Thoát khỏi vòng lặp khi tìm thấy ô có giá trị
                }
            }

            if (isRowEmpty)
            {
                // Nếu dòng không có dữ liệu, hiển thị thông báo
                MessageBox.Show("Dòng không có dữ liệu.");
            }
            else
            {
                // Nếu dòng có dữ liệu, thực hiện các tác vụ khác ở đây
                // Ví dụ: hiển thị thông tin dòng đã chọn
                //string rowData = selectedRow.Cells[0].Value.ToString();
                //MessageBox.Show("Dòng được chọn có thông tin: " + rowData);
            }




            // Truy cập dữ liệu trên dòng và hiển thị hoặc sử dụng nó
            //string studentCode = selectedRow.Cells[0].Value.ToString();
            //string name = selectedRow.Cells[1].Value.ToString();
            //string date = selectedRow.Cells[2].Value.ToString();
            //string phone = selectedRow.Cells[3].Value.ToString();
            //string classs = selectedRow.Cells[4].Value.ToString();
            //string gender = selectedRow.Cells[5].Value.ToString();
            //string faculy = selectedRow.Cells[6].Value.ToString();
            //string address = selectedRow.Cells[7].Value.ToString();



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
            datastudent.Rows[e.RowIndex].Selected = true;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to escape?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void ptImage_Click(object sender, EventArgs e)
        {

        }

        string S = "";
        private void btFile_Click(object sender, EventArgs e)
        {    
            ptImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ptImage.ImageLocation = dlg.FileName;
                S = dlg.FileName;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to escape?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ClearForm()
        {
            ip_code.Clear();
            ip_name.Clear();
            ip_gender.SelectedIndex = -1; 
            ip_phone.Clear();
            ip_faculy.SelectedIndex = -1;
            ip_class.SelectedIndex = -1;
            ip_address.SelectedIndex = -1;
            ptImage.Image = null;                                                                                         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ip_class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}