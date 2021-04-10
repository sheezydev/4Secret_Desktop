using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace _4Secret_Project
{
    public partial class Battlemodes : Form
    {
        Form1 main;

        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://test-6295b-default-rtdb.europe-west1.firebasedatabase.app/",
            AuthSecret = "ChHZAP8OX3LLIbei2osvlvcqyfYjVeXuWBAoth1F"
        };
        IFirebaseClient client;
        public Battlemodes(Form1 alap)
        {
            main = alap;
            InitializeComponent();
        }

        private void buttonBOW_Click(object sender, EventArgs e)
        {

            panelBOW.BringToFront();
        }

        private void buttonCTF_Click(object sender, EventArgs e)
        {
            panelctf.BringToFront();
        }

        private void buttonBR_Click(object sender, EventArgs e)
        {
            panelBR.BringToFront();
        }

        private void buttonBG_Click(object sender, EventArgs e)
        {
            panelBG.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelISLAND.BringToFront();
        }

        private async void Battlemodes_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                throw (new Exception("Database cannot connect"));
            }

            FirebaseResponse resp = await client.GetTaskAsync("Texts/battlemodes/Schedule");
            Texts obj = resp.ResultAs<Texts>();

            label1.Text = obj.text;


            panelMAIN.BringToFront();
            panelCTFHELP.BackColor = Color.FromArgb(170, Color.Black);
            panelBOWHELP.BackColor = Color.FromArgb(170, Color.Black);
            panelBGHELP.BackColor = Color.FromArgb(170, Color.Black);
            panelBRHELP.BackColor = Color.FromArgb(170, Color.Black);
            panelISLANDHELP.BackColor = Color.FromArgb(170, Color.Black);


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelMAIN.BringToFront();
        }

        
    }
}
