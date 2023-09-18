namespace TranQuangHuy_2122110458
{
    partial class Menu
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
            this.F1 = new System.Windows.Forms.Button();
            this.F2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // F1
            // 
            this.F1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.F1.Location = new System.Drawing.Point(46, 52);
            this.F1.Name = "F1";
            this.F1.Size = new System.Drawing.Size(75, 26);
            this.F1.TabIndex = 0;
            this.F1.Text = "From1";
            this.F1.UseVisualStyleBackColor = true;
            this.F1.Click += new System.EventHandler(this.F1_Click);
            // 
            // F2
            // 
            this.F2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.F2.Location = new System.Drawing.Point(46, 108);
            this.F2.Name = "F2";
            this.F2.Size = new System.Drawing.Size(75, 23);
            this.F2.TabIndex = 1;
            this.F2.Text = "From2";
            this.F2.UseVisualStyleBackColor = true;
            this.F2.Click += new System.EventHandler(this.F2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "0458_TranQuangHuy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F2);
            this.Controls.Add(this.F1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button F1;
        private System.Windows.Forms.Button F2;
        private System.Windows.Forms.Label label1;
    }
}