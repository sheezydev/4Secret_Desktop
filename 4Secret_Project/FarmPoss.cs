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
    public partial class FarmPoss : Form
    {
        Form1 main;
        public FarmPoss(Form1 alap)
        {
            main = alap;
            InitializeComponent();
        }

        private void FarmPoss_Load(object sender, EventArgs e)
        {
            panelDragonrod.BackColor = Color.FromArgb(50, Color.White);
            


        }

        private void buttonDragonrod_Click(object sender, EventArgs e)
        {
            
            mainDragonrod.Visible = true;
            mainMarduk.Visible = false;
            mainTigerasDung.Visible = false;
            mainTigerasCoins.Visible = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            
            mainDragonrod.Visible = false;
            mainMarduk.Visible = false;
            mainTigerasDung.Visible = false;
            mainTigerasCoins.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            mainDragonrod.Visible = false;
            mainMarduk.Visible = false;
            mainTigerasDung.Visible = false;
            mainTigerasCoins.Visible = false;
        }

        private void buttonCoins_Click(object sender, EventArgs e)
        {
            
            mainDragonrod.Visible = false;
            mainMarduk.Visible = false;
            mainTigerasDung.Visible = false;
            mainTigerasCoins.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            mainDragonrod.Visible = false;
            mainMarduk.Visible = false;
            mainTigerasDung.Visible = false;
            mainTigerasCoins.Visible = false;
        }

        private void buttonTigerasDung_Click(object sender, EventArgs e)
        {
            
            mainDragonrod.Visible = false;
            mainMarduk.Visible = false;
            mainTigerasDung.Visible = true;
            mainTigerasCoins.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            mainDragonrod.Visible = false;
            mainMarduk.Visible = false;
            mainTigerasDung.Visible = false;
            mainTigerasCoins.Visible = false;
        }

        private void buttonMarduk_Click(object sender, EventArgs e)
        {
            
            mainDragonrod.Visible = false;
            mainMarduk.Visible = true;
            mainTigerasDung.Visible = false;
            mainTigerasCoins.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            mainDragonrod.Visible = false;
            mainMarduk.Visible = false;
            mainTigerasDung.Visible = false;
            mainTigerasCoins.Visible = false;
        }

        private void buttonPirate_Click(object sender, EventArgs e)
        {
            mainPirate.Visible = true;
            mainDragonrod.Visible = false;
            mainMarduk.Visible = false;
            mainTigerasDung.Visible = false;
            mainTigerasCoins.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mainDragonrod.Visible = false;
            mainMarduk.Visible = false;
            mainTigerasDung.Visible = false;
            mainTigerasCoins.Visible = false;
            mainPirate.Visible = false;
        }
    }
}
