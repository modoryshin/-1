namespace САиП1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.МетодПарныхСравнений_панель = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Матрица = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.МетодПоследовательныхСравнений_панель = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.МетодПарныхСравнений_панель.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Матрица)).BeginInit();
            this.МетодПоследовательныхСравнений_панель.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Метод парных сравнений";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Метод последовательных сравнений";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // МетодПарныхСравнений_панель
            // 
            this.МетодПарныхСравнений_панель.Controls.Add(this.richTextBox1);
            this.МетодПарныхСравнений_панель.Controls.Add(this.button4);
            this.МетодПарныхСравнений_панель.Controls.Add(this.Матрица);
            this.МетодПарныхСравнений_панель.Controls.Add(this.comboBox1);
            this.МетодПарныхСравнений_панель.Controls.Add(this.button3);
            this.МетодПарныхСравнений_панель.Location = new System.Drawing.Point(12, 60);
            this.МетодПарныхСравнений_панель.Name = "МетодПарныхСравнений_панель";
            this.МетодПарныхСравнений_панель.Size = new System.Drawing.Size(399, 464);
            this.МетодПарныхСравнений_панель.TabIndex = 2;
            this.МетодПарныхСравнений_панель.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(12, 247);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(370, 205);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Составить отчет";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Матрица
            // 
            this.Матрица.AllowUserToAddRows = false;
            this.Матрица.AllowUserToDeleteRows = false;
            this.Матрица.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Матрица.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.Матрица.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Матрица.Location = new System.Drawing.Point(12, 52);
            this.Матрица.Name = "Матрица";
            this.Матрица.RowTemplate.Height = 25;
            this.Матрица.Size = new System.Drawing.Size(370, 158);
            this.Матрица.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(12, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(50, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(68, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Задать число целей";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // МетодПоследовательныхСравнений_панель
            // 
            this.МетодПоследовательныхСравнений_панель.Controls.Add(this.richTextBox2);
            this.МетодПоследовательныхСравнений_панель.Controls.Add(this.button6);
            this.МетодПоследовательныхСравнений_панель.Controls.Add(this.dataGridView1);
            this.МетодПоследовательныхСравнений_панель.Controls.Add(this.button5);
            this.МетодПоследовательныхСравнений_панель.Controls.Add(this.comboBox2);
            this.МетодПоследовательныхСравнений_панель.Location = new System.Drawing.Point(12, 60);
            this.МетодПоследовательныхСравнений_панель.Name = "МетодПоследовательныхСравнений_панель";
            this.МетодПоследовательныхСравнений_панель.Size = new System.Drawing.Size(399, 464);
            this.МетодПоследовательныхСравнений_панель.TabIndex = 8;
            this.МетодПоследовательныхСравнений_панель.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(370, 63);
            this.dataGridView1.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(89, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Задать число целей";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox2.Location = new System.Drawing.Point(12, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(71, 23);
            this.comboBox2.TabIndex = 0;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox2.Location = new System.Drawing.Point(14, 145);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(370, 205);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(14, 114);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Составить отчет";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 527);
            this.Controls.Add(this.МетодПоследовательныхСравнений_панель);
            this.Controls.Add(this.МетодПарныхСравнений_панель);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.МетодПарныхСравнений_панель.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Матрица)).EndInit();
            this.МетодПоследовательныхСравнений_панель.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel МетодПарныхСравнений_панель;
        private DataGridView Матрица;
        private ComboBox comboBox1;
        private Button button3;
        private RichTextBox richTextBox1;
        private Button button4;
        private Panel МетодПоследовательныхСравнений_панель;
        private DataGridView dataGridView1;
        private Button button5;
        private ComboBox comboBox2;
        private RichTextBox richTextBox2;
        private Button button6;
    }
}