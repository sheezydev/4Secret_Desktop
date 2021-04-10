using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace _4Secret_Project
{
    public partial class Events : Form
    {
        Form1 main;
        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://test-6295b-default-rtdb.europe-west1.firebasedatabase.app/",
            AuthSecret = "ChHZAP8OX3LLIbei2osvlvcqyfYjVeXuWBAoth1F"
        };
        IFirebaseClient client;
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

        public static Image Base64StringIntoImage(string str64)
        {
            byte[] img = Convert.FromBase64String(str64);
            MemoryStream ms = new MemoryStream(img);
            return Image.FromStream(ms);
        }
        private async void Events_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                throw (new Exception("Database cannot connect"));
            }
            var res = await client.GetTaskAsync("Images/DailyEvents");
            ImageModal data = res.ResultAs<ImageModal>();

            panelDaily.BackgroundImage = Base64StringIntoImage(data.ImageString);

            var res2 = await client.GetTaskAsync("Images/WeeklyEvents");
            ImageModal data2 = res2.ResultAs<ImageModal>();

            panelWeekly.BackgroundImage = Base64StringIntoImage(data2.ImageString);
        }
    }
}
