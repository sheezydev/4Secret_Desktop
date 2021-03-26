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
    public partial class Battlemodes : Form
    {
        Form1 main;
        public Battlemodes(Form1 alap)
        {
            main = alap;
            InitializeComponent();
        }

        private void buttonBOW_Click(object sender, EventArgs e)
        {

            
            panelBOW.Visible = true;
            panelctf.Visible = false;
            panelBR.Visible = false;
            panelBG.Visible = false;
            panelISLAND.Visible = false;

        }

        private void buttonCTF_Click(object sender, EventArgs e)
        {
            panelBOW.Visible = false;
            panelctf.Visible = true;
            panelBR.Visible = false;
            panelBG.Visible = false;
            panelISLAND.Visible = false;



        }

        private void buttonBR_Click(object sender, EventArgs e)
        {

            panelBOW.Visible = false;
            panelctf.Visible = false;
            panelBR.Visible = true;
            panelBG.Visible = false;
            panelISLAND.Visible = false;

        }

        private void buttonBG_Click(object sender, EventArgs e)
        {
            panelBOW.Visible = false;
            panelctf.Visible = false;
            panelBR.Visible = false;
            panelBG.Visible = true;
            panelISLAND.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelBOW.Visible = false;
            panelctf.Visible = false;
            panelBR.Visible = false;
            panelBG.Visible = false;
            panelISLAND.Visible = true;
           
        }

        private void Battlemodes_Load(object sender, EventArgs e)
        {
            
            panelCTFHELP.BackColor = Color.FromArgb(170, Color.Black);
            panelBOWHELP.BackColor = Color.FromArgb(170, Color.Black);
            panelBGHELP.BackColor = Color.FromArgb(170, Color.Black);
            panelBRHELP.BackColor = Color.FromArgb(170, Color.Black);
            panelISLANDHELP.BackColor = Color.FromArgb(170, Color.Black);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelBOW.Visible = false;
            panelctf.Visible = false;
            panelBR.Visible = false;
            panelBG.Visible = false;
            panelISLAND.Visible = false;
        }
    }
}
