using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSi3610_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            Stopwatch sw = new Stopwatch();

            sw.Start();

            for (int n = 1;  n <= 10000; n++)
            {
                chart1.Series[0].Points.AddXY(n, myQuad(n));
            }

            sw.Stop();

            textBox1.Text = sw.Elapsed.TotalMilliseconds.ToString();

            sw.Reset();
            sw.Start();

            for (int n = 1; n <= 10; n++)
            {
                chart1.Series[1].Points.AddXY(n, 5 * n);
            }
            sw.Stop();

            textBox2.Text = sw.Elapsed.TotalMilliseconds.ToString();
        }
        private int myQuad(int x)
        {
            return x * x;
        }

    }
}
