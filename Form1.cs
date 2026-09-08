using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab1
{
    public partial class Form1 : Form
    {
        // Оголошуємо компонент графіка
        private Chart chart1;

        public Form1()
        {
            InitializeComponent();

            chart1 = new Chart();
            chart1.Location = new Point(370, 107); 
            chart1.Size = new Size(450, 400);      

            ChartArea area = new ChartArea("DefaultArea");
            chart1.ChartAreas.Add(area);

            Series series = new Series("F(x)")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2
            };
            chart1.Series.Add(series);

            // Додаємо створений графік на вікно
            this.Controls.Add(chart1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double xn = Convert.ToDouble(textBox1.Text.Replace('.', ','));
                double xk = Convert.ToDouble(textBox5.Text.Replace('.', ','));
                double h = Convert.ToDouble(textBox2.Text.Replace('.', ','));
                double a = Convert.ToDouble(textBox3.Text.Replace('.', ','));

                if (h <= 0 || xn >= xk)
                {
                    MessageBox.Show("Некоректний крок або межі інтервалу!");
                    return;
                }

                Tabul tabul = new Tabul();

                dataGridView1.Rows.Clear();
                chart1.Series[0].Points.Clear();


                tabul.Tab(xn, xk, h, a);

                for (int i = 0; i < tabul.n; i++)
                {
                    double curX = Math.Round(tabul.xy[i, 0], 2);
                    double curY = Math.Round(tabul.xy[i, 1], 4);

                    dataGridView1.Rows.Add(curX.ToString(), curY.ToString());

                    // Фільтрація точок розриву тангенса для адекватного масштабу
                    if (!double.IsNaN(curY) && !double.IsInfinity(curY) && Math.Abs(curY) < 50)
                    {
                        chart1.Series[0].Points.AddXY(curX, curY);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
    }

}