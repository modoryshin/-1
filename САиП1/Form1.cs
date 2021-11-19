namespace САиП1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshForm();
            МетодПарныхСравнений_панель.Visible = true;
        }

        private void RefreshForm()
        {
            МетодПарныхСравнений_панель.Visible = false;
            МетодПоследовательныхСравнений_панель.Visible = false;
            Матрица.Rows.Clear();
            Матрица.Columns.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int matrSize = Convert.ToInt32(comboBox1.Text);
            Матрица.Rows.Clear();
            Матрица.Columns.Clear();
            for (int i = 0; i < matrSize; i++)
            {
                Матрица.Columns.Add("Z"+(i+1).ToString(), "Z" + (i + 1).ToString());
            }
            for (int i = 0; i < matrSize; i++)
            {
                Матрица.Rows.Add();
                Матрица.Rows[i].HeaderCell.Value = "Z" + (i + 1).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            string text = "Определим цену каждой цели: ";
            int[] vals = new int[Матрица.RowCount];
            for (int i = 0; i < Матрица.RowCount; i++)
            {
                for(int j = 0; j < Матрица.RowCount; j++)
                {
                    vals[i] = vals[i] + Convert.ToInt32(Матрица.Rows[i].Cells[j].Value);
                }
            }
            int sum=0;
            for(int i = 0; i < vals.Length; i++)
            {
                if (i == vals.Length - 1)
                {
                    text = text + "C" + (i + 1).ToString() + "=" + vals[i].ToString()+"\n";
                }
                else
                {
                    text = text + "C" + (i + 1).ToString() + "=" + vals[i]+", ";
                }
                sum = sum + vals[i];
            }
            text = text + "Сумма цен C = " + sum.ToString() + "\n";
            double sum1 = 0;
            Dictionary<string, double> results = new Dictionary<string, double>();
            text = text + "Искомые веса целей: ";
            for (int i = 0; i < vals.Length; i++)
            {
                double weights = Convert.ToDouble(vals[i]) / sum;
                sum1 = sum1 + weights;
                if (i == vals.Length - 1)
                {
                    text = text + "V" + (i + 1).ToString() + "=" + Math.Round(weights, 2).ToString() + ". \n";
                }
                else
                {
                    text = text + "V" + (i + 1).ToString() + "=" + Math.Round(weights,2).ToString() + ", ";
                }
                results.Add("Z"+(i+1).ToString(), Math.Round(weights, 2));
            }
            if (Math.Ceiling(sum1) == 1)
            {
                text = text + "Проверка: сумма Vi=" + Math.Ceiling(sum1).ToString() + ", i ∈ [1;4], значит, решено верно. \nПорядок предпочтения целей: ";
                foreach(var item in results.OrderByDescending(e => e.Value))
                {
                    text = text + item.Key + ", ";
                }
                richTextBox1.Text = text;
            }
            else
            {
                text = text + "Проверка: сумма Vi=" + sum1.ToString() + ", i ∈ [1;4], значит, решено не верно.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshForm();
            МетодПоследовательныхСравнений_панель.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int matrSize = Convert.ToInt32(comboBox2.Text);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            for (int i = 0; i < matrSize; i++)
            {
                dataGridView1.Columns.Add("Z" + (i + 1).ToString(), "Z" + (i + 1).ToString());
            }
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].HeaderCell.Value = "p";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            int size = Convert.ToInt32(comboBox2.Text);
            int[,] array = new int[2, size];
            for(int i = 0; i < size; i++)
            {
                array[0, i] = Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value);
                array[1, i] = i + 1;
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    if (array[0,j] < array[0,j + 1])
                    {
                        int t = array[0,j + 1];
                        array[0,j + 1] = array[0,j];
                        array[0,j] = t;
                        t = array[1, j + 1];
                        array[1, j + 1] = array[1, j];
                        array[1, j] = t;
                    }
                }
            }
            for (int i = 0; i < size; i++)
            {
                for(int j = 1; j < size; j++)
                {
                    for (int c = 2; c < size; c++)
                    {
                        if ((array[0, i] <= array[0, j] + array[0, c]) && (i < j) && (c > j)){
                            array[0, i] += 20;
                        }
                    }
                }
            }
            int sum = 0;
            for(int i = 0; i < size; i++)
            {
                sum = sum + array[0, i];
            }
            double[,] results = new double[2, size];
            for(int i = 0; i < size; i++)
            {
                results[0, i] = (Convert.ToDouble(array[0, i])) / sum;
                results[1, i] = array[1, i];
            }
            for(int i = 0; i < size; i++)
            {
                richTextBox2.Text += results[0, i] + " " + results[1, i] + "\n";
            }
        }
    }
}