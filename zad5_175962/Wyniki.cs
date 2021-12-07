using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace zad5_175962
{
    public partial class Wyniki : Form
    {
        public Wyniki()
        {
            InitializeComponent();
            if( Form1.globalResults[0]<= 800 && Form1.globalResults[0] > 0)
            {
                label4.Text = "ZALICZONY";
            }
            else label4.Text = "NIEZALICZONY";

            if (Form1.globalResults[1] <= 1000 && Form1.globalResults[1] > 0)
            {
                label5.Text = "ZALICZONY";
            }
            else label5.Text = "NIEZALICZONY";

            if (Form1.globalResults[2] <= 600 && Form1.globalResults[2] > 0)
            {
                label6.Text = "ZALICZONY";
            }
            else label6.Text = "NIEZALICZONY";

            FormBorderStyle = FormBorderStyle.FixedSingle; 
            MaximizeBox = false; 
        }

        private void Wyniki_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Title = "Numer testu";
            chart1.ChartAreas[0].AxisY.Title = "Czas[ms]";
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = Math.Max(Form1.globalResults.Max() + 300, 1000);
            chart1.ChartAreas[0].CursorY.Position = 800;
            chart1.Series["Wyniki testu 1"].IsValueShownAsLabel = true;
            chart1.Series["Wyniki testu 1"].Points.DataBindY(Form1.globalTest1);

            chart2.ChartAreas[0].AxisX.Title = "Numer testu";
            chart2.ChartAreas[0].AxisY.Title = "Czas[ms]";
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Maximum = Math.Max(Form1.globalResults.Max() + 300, 1200);
            chart2.ChartAreas[0].CursorY.Position = 1000;
            chart2.Series["Wynik testu 2"].IsValueShownAsLabel = true;
            chart2.Series["Wynik testu 2"].Points.DataBindY(Form1.globalTest2);

            chart3.ChartAreas[0].AxisX.Title = "Numer testu";
            chart3.ChartAreas[0].AxisY.Title = "Czas[ms]";
            chart3.ChartAreas[0].AxisY.Minimum = 0;
            chart3.ChartAreas[0].AxisY.Maximum = Math.Max(Form1.globalResults.Max() + 300, 1000);
            chart3.ChartAreas[0].CursorY.Position = 600;
            chart3.Series["Wynik testu 3"].IsValueShownAsLabel = true;
            chart3.Series["Wynik testu 3"].Points.DataBindY(Form1.globalTest3);

        }
    }
}
