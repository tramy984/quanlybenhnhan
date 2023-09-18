namespace quanlybenhnha
{
    partial class fBill
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listView1 = new ListView();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            panel4 = new Panel();
            button2 = new Button();
            button3 = new Button();
            numericUpDown2 = new NumericUpDown();
            button4 = new Button();
            comboBox3 = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(listView1);
            panel1.Location = new Point(12, 226);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 330);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 125);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 44);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 44);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày Sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 13);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 2;
            label3.Text = "ID Bệnh Nhân:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 78);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 3;
            label4.Text = "Chẩn Đoán:";
            // 
            // listView1
            // 
            listView1.Location = new Point(0, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(773, 322);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(comboBox1);
            panel3.Location = new Point(12, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 77);
            panel3.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(104, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(355, 28);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(104, 40);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(355, 28);
            comboBox2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 14);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 2;
            label5.Text = "Dịch Vụ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 48);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 3;
            label6.Text = "Type:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(522, 14);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 4;
            label7.Text = "Số Lượng:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(652, 14);
            button1.Name = "button1";
            button1.Size = new Size(94, 50);
            button1.TabIndex = 5;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(505, 37);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(110, 27);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBox3);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(numericUpDown2);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Location = new Point(12, 575);
            panel4.Name = "panel4";
            panel4.Size = new Size(776, 112);
            panel4.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(613, 28);
            button2.Name = "button2";
            button2.Size = new Size(133, 55);
            button2.TabIndex = 6;
            button2.Text = "Thanh Toán";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(342, 13);
            button3.Name = "button3";
            button3.Size = new Size(137, 36);
            button3.TabIndex = 7;
            button3.Text = "Miễn Giảm";
            button3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(342, 64);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(137, 27);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(20, 13);
            button4.Name = "button4";
            button4.Size = new Size(158, 36);
            button4.TabIndex = 9;
            button4.Text = "Chuyển Giường";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(20, 64);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(284, 28);
            comboBox3.TabIndex = 10;
            // 
            // fBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 699);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fBill";
            Text = "Hoá Đơn Thanh Toán";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView listView1;
        private Panel panel3;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Panel panel4;
        private Button button2;
        private NumericUpDown numericUpDown2;
        private Button button3;
        private ComboBox comboBox3;
        private Button button4;
    }
}