using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Secret_Project
{
    public partial class Events : Form
    {
        Form1 main;
        public Events(Form1 alap)
        {
            main = alap;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelWeekly.Visible = false;
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelDaily.Visible = false; 
        }

        private void buttonBR_Click(object sender, EventArgs e)
        {
            panelDaily.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelWeekly.Visible = true;
        }
    }
}
