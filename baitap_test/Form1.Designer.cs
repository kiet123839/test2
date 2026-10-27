namespace baitap_test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown2 = new NumericUpDown();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            checkBox1 = new CheckBox();
            comboBox3 = new ComboBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(765, 384);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hàng hóa";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(191, 47);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(545, 31);
            textBox3.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 53);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 13;
            label7.Text = "Mã Hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(409, 294);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 12;
            label6.Text = "ngày nhập";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(556, 295);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(187, 31);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(556, 226);
            numericUpDown2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(180, 31);
            numericUpDown2.TabIndex = 10;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(409, 226);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 9;
            label5.Text = "Số lượng tồn";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(191, 294);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(191, 228);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 7;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(191, 162);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(545, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 300);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 3;
            label4.Text = "Giá bán ";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 228);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 2;
            label3.Text = "Đơn vị";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 162);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 1;
            label2.Text = " loại  hàng ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 112);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(802, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(507, 384);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 187);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(271, 29);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "chỉ hiện hàng còn kinh doanh";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(6, 112);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(182, 33);
            comboBox3.TabIndex = 7;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(420, 31);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 440);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1311, 297);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(9, 798);
            button1.Name = "button1";
            button1.Size = new Size(128, 34);
            button1.TabIndex = 3;
            button1.Text = "thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(143, 798);
            button2.Name = "button2";
            button2.Size = new Size(128, 34);
            button2.TabIndex = 4;
            button2.Text = "sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(291, 798);
            button3.Name = "button3";
            button3.Size = new Size(128, 34);
            button3.TabIndex = 5;
            button3.Text = "xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(452, 798);
            button4.Name = "button4";
            button4.Size = new Size(128, 34);
            button4.TabIndex = 6;
            button4.Text = "làm mới";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(723, 798);
            button5.Name = "button5";
            button5.Size = new Size(128, 34);
            button5.TabIndex = 7;
            button5.Text = "Xem bảng giá";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(871, 798);
            button6.Name = "button6";
            button6.Size = new Size(128, 34);
            button6.TabIndex = 8;
            button6.Text = "Xuất PDF";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(1037, 798);
            button7.Name = "button7";
            button7.Size = new Size(128, 34);
            button7.TabIndex = 9;
            button7.Text = "thiết kế";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(1190, 798);
            button8.Name = "button8";
            button8.Size = new Size(198, 34);
            button8.TabIndex = 10;
            button8.Text = "Xuất Excel tồn kho";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 895);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
        private ComboBox comboBox3;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        public DataGridView dataGridView1;
        private Label label7;
        private TextBox textBox3;
    }
}
