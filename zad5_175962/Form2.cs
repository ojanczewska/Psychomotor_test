using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad5_175962
{
    public partial class Test1 : Form
    {

        private Boolean proba = true;
        private long time_counter = 0;
        private int randomIndex = 0;
        private int previouslyRandomIndex;
        private long powtorzenia;
        private long dodaj = 0;
        private long srednia =0;
        private long czas0 = 0;

        public Test1()
        {
            InitializeComponent();
            label1.Text = "FAZA SZKOLENIOWA:\r\nJak najszybciej przyciśnij przycisk zapalony na czerwono.\r\nPróba zostanie wykonana 7 razy.\r\nAby rozpocząć wcisnij przycisk 'Start próby'. ";
            button_start.Text = "Start próby";
            FormBorderStyle = FormBorderStyle.FixedSingle; 
            MaximizeBox = false;  

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Button_Start_Click(object sender, EventArgs e)
        {
            button_start.Enabled = false;
            timer1.Start();

            if (proba == true)
            {
                button12.BackColor = Color.Red;
                previouslyRandomIndex = 11;
                powtorzenia = 0;
            }
            else
            {
                button8.BackColor = Color.Red;
                previouslyRandomIndex = 7;
                powtorzenia = 0;
            }

                
            
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Button[] buttons = {this.button1, this.button2, this.button3, this.button4, this.button5,
                                    this.button6, this.button7, this.button8, this.button9, this.button10,
                                    this.button11, this.button12, this.button13, this.button14, this.button15,
                                    this.button16, this.button17, this.button18, this.button19, this.button20 };

            if (button.BackColor == Color.Red)
            {
                
                if (proba == false)
                {
                    suma();
                }
                    

                Random random = new Random();
                buttons[previouslyRandomIndex].BackColor = Color.Yellow;
                do
                {
                    randomIndex = random.Next(20);
                } while (randomIndex == previouslyRandomIndex);
                previouslyRandomIndex = randomIndex;

                buttons[randomIndex].BackColor = Color.Red;

                powtorzenia++;

                if(powtorzenia >= 7)
                {
                    timer1.Stop();
                   
                    if (proba == true)
                    {
                        buttons[randomIndex].BackColor = Color.Yellow;
                        button_start.Text = "Start testu";
                        label1.Text = "FAZA TESTOWA:\r\nJak najszybciej przyciśnij przycisk zapalony na czerwono.\r\nTest zostanie wykonana 7 razy.\r\nAby rozpocząć wcisnij przycisk 'Start testu'.";
                        label_czas.Text = "00:00:00";
                        time_counter = 0;
                        button_start.Enabled = true;
                        proba = false;

                    }
                    else
                    {

                        Thread.Sleep(1000);
                        oblicz_srednia();
                        Form1.ukonczono[0] = 1;
                        this.Close();

                    }
                }

            }
         }

        private void suma()
        {
            dodaj += time_counter - czas0;

            Form1.globalTest1[powtorzenia] = time_counter - czas0;
            czas0 = time_counter;
            
        }
        private void oblicz_srednia()
        {
            srednia = dodaj / powtorzenia;

            Form1.globalResults[0] = srednia;
        }
        private void label_czas_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_counter += 25;
            label_czas.Text = time_counter + "ms";
        }

        private void Test1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
