namespace BlockChain2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ToChuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrevHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nonce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MerkleRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổ chức cấp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(225, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên người nhận";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số CCCD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày Cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Hết Hạn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ToChuc,
            this.TenNhan,
            this.CCCD,
            this.ngayCap,
            this.ngayHet});
            this.dataGridView1.Location = new System.Drawing.Point(496, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 210);
            this.dataGridView1.TabIndex = 13;
            // 
            // ToChuc
            // 
            this.ToChuc.HeaderText = "Tên Tổ Chức";
            this.ToChuc.Name = "ToChuc";
            // 
            // TenNhan
            // 
            this.TenNhan.HeaderText = "Tên Người Nhận";
            this.TenNhan.Name = "TenNhan";
            // 
            // CCCD
            // 
            this.CCCD.HeaderText = "Số CCCD";
            this.CCCD.Name = "CCCD";
            // 
            // ngayCap
            // 
            this.ngayCap.HeaderText = "Ngày Cấp";
            this.ngayCap.Name = "ngayCap";
            // 
            // ngayHet
            // 
            this.ngayHet.HeaderText = "Ngày Hết Hạn";
            this.ngayHet.Name = "ngayHet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 201);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giao dịch";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(300, 163);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Tạo Khối";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Show giao dịch chờ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(253, 97);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thêm Giao Dịch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(12, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1099, 239);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Block Chain";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(935, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 34);
            this.button5.TabIndex = 18;
            this.button5.Text = "Xác minh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(935, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 34);
            this.button4.TabIndex = 17;
            this.button4.Text = "Xuất dữ liệu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(935, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 34);
            this.button3.TabIndex = 16;
            this.button3.Text = "Nhập dữ liệu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.PrevHash,
            this.Nonce,
            this.Difficulty,
            this.MerkleRoot,
            this.Timestamp});
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(923, 201);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // index
            // 
            this.index.HeaderText = "STT";
            this.index.Name = "index";
            // 
            // PrevHash
            // 
            this.PrevHash.HeaderText = "PrevHash";
            this.PrevHash.Name = "PrevHash";
            // 
            // Nonce
            // 
            this.Nonce.HeaderText = "Nonce";
            this.Nonce.Name = "Nonce";
            // 
            // Difficulty
            // 
            this.Difficulty.HeaderText = "Difficulty";
            this.Difficulty.Name = "Difficulty";
            // 
            // MerkleRoot
            // 
            this.MerkleRoot.HeaderText = "Merkle Root";
            this.MerkleRoot.Name = "MerkleRoot";
            // 
            // Timestamp
            // 
            this.Timestamp.HeaderText = "Time Stamp";
            this.Timestamp.Name = "Timestamp";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(412, 166);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToChuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHet;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrevHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nonce;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn MerkleRoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

