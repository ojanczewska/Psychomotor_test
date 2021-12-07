using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad5_175962
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle; 
            MaximizeBox = false;  
            label1.Text = "Aplikacja ma na celu sprawdzenie sprawaności\r\n psychomotorycznej kandydatów na kierowców.\r\nSkłada się z 3 krótkich testów\r\n badających prosty i złożony czas reakcji,\r\nz czego dwa pierwsze testy sprawdzają rekację\r\n na bodżce optyczne, a trzeci test skupia się\r\n na reakcji na bodźce akustyczne.\r\n Po ukończeniu testów użytkownik\r\n może sprawdzić swoje wyniki.";
           
        }

        private void Info_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
