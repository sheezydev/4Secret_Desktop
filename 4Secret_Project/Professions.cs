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
    public partial class Professions : Form
    {
        Form1 main;
        public Professions(Form1 alap)
        {
            main = alap;
            InitializeComponent();
        }

        

        private void panelMINING_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBG_Click(object sender, EventArgs e)
        {
            panelMINING.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelMINING.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelHERBALISM.Visible = false;
        }

        private void buttonHERBAL_Click(object sender, EventArgs e)
        {
            panelHERBALISM.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelBLACKSMITH.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelALCHEMIST.Visible = false;
        }

        private void buttonALCH_Click(object sender, EventArgs e)
        {
            panelALCHEMIST.Visible = true;
        }

        private void buttonBLACKSMITH_Click(object sender, EventArgs e)
        {
            panelBLACKSMITH.Visible = true;
        }

        private void Professions_Load(object sender, EventArgs e)
        {
            timer1.Start();
            panel9.BringToFront();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelLoad2.Width += 35;

            if (panelLoad2.Width >= panelLoad1.Width)
            {
                timer1.Stop();
                panel9.Visible = false;
            }
        }
    }
}
