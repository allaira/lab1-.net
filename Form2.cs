using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form2 : Form
    {
        private OneDArray myArray = new OneDArray();

        public Form2()
        {
            InitializeComponent();

            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button4.Click += button4_Click;
            this.FormClosing += Form2_FormClosing;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] names = myArray.GetReversed();
            foreach (string name in names)
            {
                listBox1.Items.Add(name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int idx))
            {
                string result = myArray[idx];
                MessageBox.Show(result, "Результат");
            }
            else
            {
                MessageBox.Show("Введіть коректне ціле число!");
            }
        }

        // Кнопка: Закрити форму
        private void button4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[0] != null)
                Application.OpenForms[0].Show();
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms[0] != null)
                Application.OpenForms[0].Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}