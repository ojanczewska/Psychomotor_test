using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psychomotor_test
{
    public partial class Form1 : Form
    {
        public static long[] globalResults { get; set; } = new long[3];
        public static long[] globalTest1 { get; set; } = new long[7];
        public static long[] globalTest2 { get; set; } = new long[7];
        public static long[] globalTest3{ get; set; } = new long[5];
        public static long[] ukonczono { get; set; } = new long[3];

        public Form1()
        {
            InitializeComponent();
            label4.Text = "TEST NIEZREALIZOWANY";
            label5.Text = "TEST NIEZREALIZOWANY";
            label6.Text = "TEST NIEZREALIZOWANY";
            button_Test2.Enabled = false;
            button_Test3.Enabled = false;
            FormBorderStyle = FormBorderStyle.FixedSingle; 
            MaximizeBox = false;  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void informacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info projectInfoForm = new Info();
            projectInfoForm.ShowDialog();
        }

        private void button_Test1_Click(object sender, EventArgs e)
        {

            Test1 test1 = new Test1();
            test1.ShowDialog();   
            if(ukonczono[0] == 1)
            {
                label4.Text = " TEST ZREALIZOWANY";
                button_Test1.Enabled = false;
                button_Test2.Enabled = true;

            }
        }

        private void button_Test2_Click(object sender, EventArgs e)
        {
            Test2 test2 = new Test2();
            test2.ShowDialog();
            if (ukonczono[1] == 1)
            {
                label5.Text = " TEST ZREALIZOWANY";
                button_Test2.Enabled = false;
                button_Test3.Enabled = true;

            }
        }

        private void button_Test3_Click(object sender, EventArgs e)
        {
            Test3 test3 = new Test3();
            test3.ShowDialog();
            if (ukonczono[2] == 1)
            {
                label6.Text = " TEST ZREALIZOWANY";
                button_Test3.Enabled = false;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_Wynik_Click(object sender, EventArgs e)
        {
            Wyniki wyniki = new Wyniki();
            wyniki.ShowDialog();
        }

        private void nowePodejścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_Test1.Enabled = true;
            button_Test2.Enabled = false;
            button_Test3.Enabled = false;
            label4.Text = "TEST NIEZREALIZOWANY";
            label5.Text = "TEST NIEZREALIZOWANY";
            label6.Text = "TEST NIEZREALIZOWANY";
            ukonczono[0] = ukonczono[1] = ukonczono[2] = 0;
            globalResults[0] = globalResults[1] = globalResults[2] = 0;
            globalTest1[0] = globalTest1[1] = globalTest1[2] = globalTest1[3] = globalTest1[4] = globalTest1[5] = globalTest1[6] = 0;
            globalTest2[0] = globalTest2[1] = globalTest2[2] = globalTest2[3] = globalTest2[4] = globalTest2[5] = globalTest2[6] = 0;
            globalTest3[0] = globalTest3[1] = globalTest3[2] = globalTest3[3] = globalTest3[4] = 0;
        }
    }
}
