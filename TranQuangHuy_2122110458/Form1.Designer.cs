using System;
using System.Windows.Forms;

namespace TranQuangHuy_2122110458
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ip_gender = new System.Windows.Forms.ComboBox();
            this.ip_address = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ip_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ip_faculy = new System.Windows.Forms.ComboBox();
            this.ip_class = new System.Windows.Forms.ComboBox();
            this.ip_date = new System.Windows.Forms.DateTimePicker();
            this.ip_code = new System.Windows.Forms.TextBox();
            this.ip_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.ip_class2 = new System.Windows.Forms.Label();
            this.ip_faculy1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ip_time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ip_name2 = new System.Windows.Forms.Label();
            this.datastudent = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datastudent)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.datastudent);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(751, 468);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ip_gender);
            this.panel2.Controls.Add(this.ip_address);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ip_phone);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ip_faculy);
            this.panel2.Controls.Add(this.ip_class);
            this.panel2.Controls.Add(this.ip_date);
            this.panel2.Controls.Add(this.ip_code);
            this.panel2.Controls.Add(this.ip_name);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Controls.Add(this.ip_class2);
            this.panel2.Controls.Add(this.ip_faculy1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ip_time);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ip_name2);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 212);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ip_gender
            // 
            this.ip_gender.FormattingEnabled = true;
            this.ip_gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "LGBT"});
            this.ip_gender.Location = new System.Drawing.Point(115, 111);
            this.ip_gender.Margin = new System.Windows.Forms.Padding(2);
            this.ip_gender.Name = "ip_gender";
            this.ip_gender.Size = new System.Drawing.Size(149, 21);
            this.ip_gender.TabIndex = 60;
            this.ip_gender.SelectedIndexChanged += new System.EventHandler(this.ip_gender_SelectedIndexChanged);
            // 
            // ip_address
            // 
            this.ip_address.FormattingEnabled = true;
            this.ip_address.Items.AddRange(new object[] {
            "HoChiMinh City",
            "HaNoi City",
            "Danang City",
            "Dalat City"});
            this.ip_address.Location = new System.Drawing.Point(390, 156);
            this.ip_address.Margin = new System.Windows.Forms.Padding(2);
            this.ip_address.Name = "ip_address";
            this.ip_address.Size = new System.Drawing.Size(152, 21);
            this.ip_address.TabIndex = 59;
            this.ip_address.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(315, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // ip_phone
            // 
            this.ip_phone.Location = new System.Drawing.Point(115, 158);
            this.ip_phone.Margin = new System.Windows.Forms.Padding(2);
            this.ip_phone.Name = "ip_phone";
            this.ip_phone.Size = new System.Drawing.Size(149, 20);
            this.ip_phone.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(52, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Phone";
            this.label1.FontChanged += new System.EventHandler(this.label1_FontChanged);
            // 
            // ip_faculy
            // 
            this.ip_faculy.FormattingEnabled = true;
            this.ip_faculy.Items.AddRange(new object[] {
            "Information Technology",
            "English Business",
            "Digital Makerting",
            "Sorfwave "});
            this.ip_faculy.Location = new System.Drawing.Point(390, 63);
            this.ip_faculy.Margin = new System.Windows.Forms.Padding(2);
            this.ip_faculy.Name = "ip_faculy";
            this.ip_faculy.Size = new System.Drawing.Size(152, 21);
            this.ip_faculy.TabIndex = 55;
            this.ip_faculy.SelectedIndexChanged += new System.EventHandler(this.ip_faculy_SelectedIndexChanged);
            // 
            // ip_class
            // 
            this.ip_class.FormattingEnabled = true;
            this.ip_class.Items.AddRange(new object[] {
            "CCQ2211K",
            "CCQ2211C",
            "CCQ2211L",
            ""});
            this.ip_class.Location = new System.Drawing.Point(390, 110);
            this.ip_class.Margin = new System.Windows.Forms.Padding(2);
            this.ip_class.Name = "ip_class";
            this.ip_class.Size = new System.Drawing.Size(152, 21);
            this.ip_class.TabIndex = 54;
            // 
            // ip_date
            // 
            this.ip_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ip_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ip_date.Location = new System.Drawing.Point(390, 20);
            this.ip_date.Margin = new System.Windows.Forms.Padding(2);
            this.ip_date.Name = "ip_date";
            this.ip_date.Size = new System.Drawing.Size(152, 23);
            this.ip_date.TabIndex = 51;
            // 
            // ip_code
            // 
            this.ip_code.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.ip_code.Location = new System.Drawing.Point(115, 20);
            this.ip_code.Margin = new System.Windows.Forms.Padding(2);
            this.ip_code.Name = "ip_code";
            this.ip_code.Size = new System.Drawing.Size(149, 20);
            this.ip_code.TabIndex = 49;
            this.ip_code.TextChanged += new System.EventHandler(this.ip_code_TextChanged);
            // 
            // ip_name
            // 
            this.ip_name.Location = new System.Drawing.Point(115, 65);
            this.ip_name.Margin = new System.Windows.Forms.Padding(2);
            this.ip_name.Name = "ip_name";
            this.ip_name.Size = new System.Drawing.Size(149, 20);
            this.ip_name.TabIndex = 48;
            this.ip_name.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(9, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Student code";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_add.Location = new System.Drawing.Point(609, 23);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(84, 33);
            this.btn_add.TabIndex = 43;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_delete.Location = new System.Drawing.Point(609, 144);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(84, 34);
            this.btn_delete.TabIndex = 42;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.button_delete);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_edit.Location = new System.Drawing.Point(609, 83);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(84, 34);
            this.btn_edit.TabIndex = 41;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.button_edit);
            // 
            // ip_class2
            // 
            this.ip_class2.AutoSize = true;
            this.ip_class2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ip_class2.Location = new System.Drawing.Point(333, 116);
            this.ip_class2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ip_class2.Name = "ip_class2";
            this.ip_class2.Size = new System.Drawing.Size(42, 17);
            this.ip_class2.TabIndex = 40;
            this.ip_class2.Text = "Class";
            this.ip_class2.Click += new System.EventHandler(this.ip_class2_Click);
            // 
            // ip_faculy1
            // 
            this.ip_faculy1.AutoSize = true;
            this.ip_faculy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ip_faculy1.Location = new System.Drawing.Point(330, 67);
            this.ip_faculy1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ip_faculy1.Name = "ip_faculy1";
            this.ip_faculy1.Size = new System.Drawing.Size(49, 17);
            this.ip_faculy1.TabIndex = 39;
            this.ip_faculy1.Text = "Faculy";
            this.ip_faculy1.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(45, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ip_time
            // 
            this.ip_time.AutoSize = true;
            this.ip_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ip_time.Location = new System.Drawing.Point(337, 21);
            this.ip_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ip_time.Name = "ip_time";
            this.ip_time.Size = new System.Drawing.Size(38, 17);
            this.ip_time.TabIndex = 37;
            this.ip_time.Text = "Date";
            this.ip_time.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 35;
            // 
            // ip_name2
            // 
            this.ip_name2.AutoSize = true;
            this.ip_name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ip_name2.Location = new System.Drawing.Point(56, 68);
            this.ip_name2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ip_name2.Name = "ip_name2";
            this.ip_name2.Size = new System.Drawing.Size(45, 17);
            this.ip_name2.TabIndex = 36;
            this.ip_name2.Text = "Name";
            this.ip_name2.Click += new System.EventHandler(this.label1_Click);
            // 
            // datastudent
            // 
            this.datastudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datastudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datastudent.BackgroundColor = System.Drawing.Color.DarkGray;
            this.datastudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datastudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.Column2,
            this.Column5,
            this.Column4,
            this.Column3,
            this.Column6,
            this.Date,
            this.Column7});
            this.datastudent.Location = new System.Drawing.Point(2, 218);
            this.datastudent.Margin = new System.Windows.Forms.Padding(2);
            this.datastudent.Name = "datastudent";
            this.datastudent.RowHeadersWidth = 51;
            this.datastudent.RowTemplate.Height = 24;
            this.datastudent.Size = new System.Drawing.Size(741, 250);
            this.datastudent.TabIndex = 51;
            this.datastudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datastudent_CellClick);
            this.datastudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datastudent_CellContentClick_1);
            // 
            // code
            // 
            this.code.HeaderText = "Student Code";
            this.code.MinimumWidth = 6;
            this.code.Name = "code";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Gender";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Faculy";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Date
            // 
            this.Date.HeaderText = "Class";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Address";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 469);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datastudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button_delete(object sender, EventArgs e)
        {
            if (datastudent.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Do you want to delete this record? The data will not be recoverable.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowIndex = datastudent.CurrentCell.RowIndex;
                    datastudent.Rows.RemoveAt(rowIndex);
                    //Delete();
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView datastudent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ip_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ip_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ip_faculy;
        private System.Windows.Forms.ComboBox ip_class;
        private System.Windows.Forms.DateTimePicker ip_date;
        private System.Windows.Forms.TextBox ip_code;
        private System.Windows.Forms.TextBox ip_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label ip_class2;
        private System.Windows.Forms.Label ip_faculy1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ip_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ip_name2;
        private System.Windows.Forms.ComboBox ip_gender;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Column7;
    }
}

