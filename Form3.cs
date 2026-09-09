using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form3 : Form
    {
        private TwoDArray myArr = new TwoDArray();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = myArr.Cols;
            dataGridView1.RowCount = myArr.Rows;

            for (int j = 0; j < myArr.Cols; j++)
                dataGridView1.Columns[j].HeaderText = (j + 1).ToString();

            for (int i = 0; i < myArr.Rows; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                for (int j = 0; j < myArr.Cols; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = myArr[i, j];
                }
            }

            textBox1.Text = myArr.GetNegativeIndices();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[0] != null)
                Application.OpenForms[0].Show();
            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms[0] != null)
                Application.OpenForms[0].Show();
        }

    }
}