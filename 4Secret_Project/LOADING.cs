using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChaseLabs.CLUpdate;
using System.Windows.Forms;


namespace _4Secret_Project
{
    public partial class LOADING : Form
    {
        Form1 main;
        
        public LOADING()
        {
            main = new Form1();
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 20;
            if (panel2.Width >= 758)
            {
                timer1.Stop();
                this.Hide();
                main.Show();
            }
        }

        private void LOADING_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
    }
}
