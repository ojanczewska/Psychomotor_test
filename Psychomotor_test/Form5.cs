using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Resources;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Psychomotor_test
{
    public partial class Test3 : Form
    {
        private Boolean proba = true;
        private int randomIndex = 0;
        private int powtorzenia;
        private int time_counter = 0;
        private int time_counter2 = 0;
        private long czas0 = 0;
        private long dodaj = 0;
        private long srednia = 0;
        private SoundPlayer sound1;
        private SoundPlayer sound2;
        private SoundPlayer sound3;

        public Test3()
        {
            InitializeComponent();
            label1.Text = "FAZA SZKOLENIOWA:\r\nPo usłuszeniu dzwieku, jak najszybciej\r\n przycisnij przycisk odpowiadający zrodlowi dzwieku.\r\nPróba zostanie wykonana 5 razy.\r\nAby rozpocząć wcisnij przycisk 'Start próby'. ";
            button_start.Text = "Start próby";
            sound1 = new SoundPlayer("bird.wav");
            sound2 = new SoundPlayer("COW.wav");
            sound3 = new SoundPlayer("syrena.wav");
            FormBorderStyle = FormBorderStyle.FixedSingle; 
            MaximizeBox = false; 
        }

        private void Test3_Load(object sender, EventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
 
            powtorzenia = 0;
            button_start.Enabled = false;
            timer1.Start();
            if (proba == true)
            {
                randomIndex=1;
                sound2.PlayLooping();

            }
            else
            {
                randomIndex = 0;
                sound1.PlayLooping();

            }           
        }


        private void buttons_click(object sender, EventArgs e)
        {
            Button[] buttons = { this.button1, this.button2, this.button3 };
            SoundPlayer[] sounds = { sound1, sound2, sound3 };


            if (sender == buttons[randomIndex])
            {
                if (proba == false)
                {
                    suma();
                }
                sounds[randomIndex].Stop();

                Random random = new Random();
                randomIndex = random.Next(3);

                powtorzenia++;

                if(powtorzenia >= 5)
                {
                    if(proba == true)
                    {
                        proba = false;
                        timer1.Stop();
                        button_start.Text = "Start testu";
                        label1.Text = "FAZA TESTOWA:\r\nPo usłuszeniu dzwieku, jak najszybciej\r\n przycisnij przycisk odpowiadający zrodlowi dzwieku.\r\nTest zostanie wykonana 5 razy.\r\nAby rozpocząć wcisnij przycisk 'Start testu'.";
                        button_start.Enabled = true;
                        label_czas.Text = "00:00:00";
                        time_counter = 0;

                    }
                    else
                    {
                        timer1.Stop();
                        Thread.Sleep(1000);
                        oblicz_srednia();
                        Form1.ukonczono[2] = 1;
                        this.Close();
                    }
                }
                else
                {
                    sounds[randomIndex].PlayLooping();
                }
                
            }
        }

        private void suma()
        {
            dodaj += time_counter - czas0;
            Form1.globalTest3[powtorzenia] = time_counter - czas0;
            czas0 = time_counter;
        }
        private void oblicz_srednia()
        {
            srednia = dodaj / powtorzenia;
            Form1.globalResults[2] = srednia;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_counter += 25;
            label_czas.Text = time_counter + "ms";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time_counter2 += 25;
        }

        private void Test3_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoundPlayer[] sounds = { sound1, sound2, sound3 };
            sounds[randomIndex].Stop();
        }
    }
}
