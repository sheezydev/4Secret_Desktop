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
    public partial class FarmPoss : Form
    {
        Form1 main;
        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://test-6295b-default-rtdb.europe-west1.firebasedatabase.app/",
            AuthSecret = "ChHZAP8OX3LLIbei2osvlvcqyfYjVeXuWBAoth1F"
        };
        IFirebaseClient client;
        public FarmPoss(Form1 alap)
        {
            main = alap;
            InitializeComponent();
        }

        public Texts TextRetrieve(string path)
        {
            FirebaseResponse resp = client.Get(path);
            Texts obj = resp.ResultAs<Texts>();

            return obj;
        }

        private void FarmPoss_Load(object sender, EventArgs e)
        {

            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                throw (new Exception("Database cannot connect"));
            }

            label42.Text = TextRetrieve("Texts/farm/pirate/labels/Label42").text;
            label41.Text = TextRetrieve("Texts/farm/pirate/labels/Label41").text;
            label38.Text = TextRetrieve("Texts/farm/pirate/labels/Label38").text;

            label46.Text = TextRetrieve("Texts/farm/marduk/labels/Label46").text;
            label52.Text = TextRetrieve("Texts/farm/marduk/labels/Label52").text;
            label53.Text = TextRetrieve("Texts/farm/marduk/labels/Label53").text;

            label35.Text = TextRetrieve("Texts/farm/tigerasdung/labels/Label35").text;
            label47.Text = TextRetrieve("Texts/farm/tigerasdung/labels/Label47").text;
            label48.Text = TextRetrieve("Texts/farm/tigerasdung/labels/Label48").text;

            label12.Text = TextRetrieve("Texts/farm/dragonrod/labels/Label12").text;
            label13.Text = TextRetrieve("Texts/farm/dragonrod/labels/Label13").text;
            label14.Text = TextRetrieve("Texts/farm/dragonrod/labels/Label14").text;
            label16.Text = TextRetrieve("Texts/farm/dragonrod/labels/Label16").text;
            label17.Text = TextRetrieve("Texts/farm/dragonrod/labels/Label17").text;
            label18.Text = TextRetrieve("Texts/farm/dragonrod/labels/Label18").text;


            panelDragonrod.BackColor = Color.FromArgb(50, Color.White);
            timer1.Start();

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
