using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Psychomotor_test
{
    public partial class Test2 : Form
    {

        private Boolean proba = true;
        private int time_counter = 0;
        private int randomIndex = 0;
        private int randomIndex2 = 0;
        private int randomIndex_p = 0;
        private int randomIndex2_p = 0;
        private int previouslyRandomIndex;
        private int powtorzenia = 0;
        private long czas0 = 0;
        private long dodaj = 0;
        private long srednia = 0;
        public Test2()
        {
            InitializeComponent();
            label1.Text = "FAZA SZKOLENIOWA:\r\nJak najszybciej przyciśnij przycisk odpowiadojący kolumnie i wierszu zapalających sie diod.\r\nPróba zostanie wykonana 7 razy.\r\nAby rozpocząć wcisnij przycisk 'Start próby'." ;
            button_start.Text = "Start próby";
            FormBorderStyle = FormBorderStyle.FixedSingle; 
            MaximizeBox = false;  

        }

  
        private void Info_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            button_start.Enabled = false;
            timer1.Start();
            powtorzenia = 0;
            if (proba == true)
            {
                pictureBox2.BackColor = Color.Red;
                pictureBox7.BackColor = Color.Red;
                previouslyRandomIndex = 6;
                randomIndex_p = 1;
                randomIndex2_p = 1;
            }
            else
            {
                pictureBox5.BackColor = Color.Red;
                pictureBox8.BackColor = Color.Red;
                previouslyRandomIndex = 14;
                randomIndex_p = 4;
                randomIndex2_p = 2;
            }
        }

        private void buttons_click(object sender, EventArgs e)
        {
            
            Button[] buttons = {this.button1, this.button2, this.button3, this.button4, this.button5,
                                    this.button6, this.button7, this.button8, this.button9, this.button10,
                                    this.button11, this.button12, this.button13, this.button14, this.button15,
                                    this.button16, this.button17, this.button18, this.button19, this.button20 };
            
            PictureBox[] boxses1 = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
          
            PictureBox[] boxses2 = { pictureBox6, pictureBox7, pictureBox8, pictureBox9 };

            if( sender == buttons[previouslyRandomIndex])
            {
                if (proba == false)
                {
                    suma();
                }

                Random random = new Random();
                Random random2 = new Random();
                boxses1[randomIndex_p].BackColor = Color.Yellow;
                boxses2[randomIndex2_p].BackColor = Color.Yellow;

                do
                {
                    randomIndex = random.Next(4);
                   
                } while (randomIndex == randomIndex_p );

                do
                {
                    randomIndex2 = random2.Next(3);
                } while (randomIndex2 == randomIndex2_p);

                previouslyRandomIndex = randomIndex + 5 * randomIndex2;
                randomIndex_p = randomIndex;
                randomIndex2_p = randomIndex2;

                boxses1[randomIndex_p].BackColor = Color.Red;
                boxses2[randomIndex2_p].BackColor = Color.Red;

                powtorzenia++;

                if (powtorzenia >= 7)
                {
                    timer1.Stop();
                    if (proba == true)
                    {
                        boxses1[randomIndex].BackColor = Color.Yellow;
                        boxses2[randomIndex2].BackColor = Color.Yellow;
                        button_start.Text = "Start testu";
                        label1.Text = "FAZA TESTOWA:\r\nJak najszybciej przyciśnij przycisk odpowiadojący kolumnie i wierszu zapalających sie diod.\r\nTest zostanie wykonana 7 razy.\r\nAby rozpocząć wcisnij przycisk 'Start testu'.";
                        button_start.Enabled = true;
                        label_czas.Text = "00:00:00";
                        time_counter = 0;
                        proba = false;

                    }
                    else
                    {
                        Thread.Sleep(1000);
                        oblicz_srednia();
                        Form1.ukonczono[1] = 1;
                        this.Close();
                    }
                }
            }
        }

        private void suma()
        {
            dodaj += time_counter - czas0;
            Form1.globalTest2[powtorzenia] = time_counter - czas0;
            czas0 = time_counter;
        }
        private void oblicz_srednia()
        {
            srednia = dodaj / powtorzenia;
            Form1.globalResults[1] = srednia;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_counter += 25;
            label_czas.Text = time_counter + "ms";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
