using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace _4Secret_Project
{
    public partial class Form1 : Form
    {
        private bool drag = false;
        private Point startpoint = new Point(0, 0);
        private Form activeForm;
        private Button currentButton;

        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://test-6295b-default-rtdb.europe-west1.firebasedatabase.app/",
            AuthSecret = "ChHZAP8OX3LLIbei2osvlvcqyfYjVeXuWBAoth1F"
        };
        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        public void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {

                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(34, 28, 25);
                    previousBtn.ForeColor = Color.FromArgb(238, 199, 96);
                }
            }

        }

        public void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                   
                        DisableButton();

                        currentButton = (Button)btnSender;
                        currentButton.BackColor = Color.FromArgb(238, 199, 96);
                        currentButton.ForeColor = Color.FromArgb(34, 28, 25);
                   
                }
            }
        }

        public void OpenMellekForm(Form mellekform, object btn)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = mellekform;
            mellekform.TopLevel = false;
            mellekform.FormBorderStyle = FormBorderStyle.None;
            this.panel5.Controls.Add(mellekform);
            this.panel5.Tag = mellekform;
            mellekform.BringToFront();
            mellekform.Show();
            labelTitle.Text = mellekform.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            buttonClose.BackColor = Color.Red;
        }


       

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonMinimize_MouseDown(object sender, MouseEventArgs e)
        {
            buttonMinimize.BackColor = Color.FromArgb(162, 138, 89);
            
        }

        private void buttonMinimize_MouseUp(object sender, MouseEventArgs e)
        {
            buttonMinimize.BackColor = Color.Transparent;
        }

        private void buttonClose_MouseUp(object sender, MouseEventArgs e)
        {
            buttonClose.BackColor = Color.Transparent;
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startpoint = new Point(e.X, e.Y);
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);
            }
            
        }

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void menuCrafts_Click(object sender, EventArgs e)
        {
            bool alreadyopened = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Crafts")
                {
                    alreadyopened = true;
                }
            }
            if (alreadyopened)
            {
            }
            else
            {
                ActivateButton(sender);
                menuBattleModes.Enabled = false;
                menuFarm.Enabled = false;
                menuProfessions.Enabled = false;
                menuEvents.Enabled = false;
                Crafts kraft = new Crafts(this);
                OpenMellekForm(kraft, sender);
                while (kraft.panelLoad2.Width <= 380)
                {
                    kraft.panelLoad2.Width += 1;
                }
                menuBattleModes.Enabled = true;
                menuFarm.Enabled = true;
                menuProfessions.Enabled = true;
                menuEvents.Enabled = true;
            }
        }
        private void menuFarm_Click(object sender, EventArgs e)
        {
            bool alreadyopened = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "FarmPoss")
                {
                    alreadyopened = true;
                }
            }
            if (alreadyopened)
            {
            }
            else
            {
                ActivateButton(sender);
                menuBattleModes.Enabled = false;
                menuCrafts.Enabled = false;
                menuProfessions.Enabled = false;
                menuEvents.Enabled = false;
                FarmPoss farm = new FarmPoss(this);
                OpenMellekForm(farm, sender);
                while (farm.panelLoad2.Width <= 380)
                {
                    farm.panelLoad2.Width += 1;
                }
                menuBattleModes.Enabled = true;
                menuCrafts.Enabled = true;
                menuProfessions.Enabled = true;
                menuEvents.Enabled = true;
            }
        }

        private void menuBattleModes_Click(object sender, EventArgs e)
        {
            bool alreadyopened = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Battlemodes")
                {
                    alreadyopened = true;
                }
            }
            if (alreadyopened)
            {
            }
            else
            {
                ActivateButton(sender);
                Battlemodes bmode = new Battlemodes(this);
                OpenMellekForm(bmode, sender);
            }
        }

        private void menuProfessions_Click(object sender, EventArgs e)
        {
            bool alreadyopened = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Professions")
                {
                    alreadyopened = true;
                }
            }
            if (alreadyopened)
            {
            }
            else
            {
                ActivateButton(sender);
                Professions prof = new Professions(this);
                OpenMellekForm(prof, sender);
                menuBattleModes.Enabled = false;
                menuFarm.Enabled = false;
                menuCrafts.Enabled = false;
                menuEvents.Enabled = false;
                while (prof.panelLoad2.Width <= 380)
                {
                    prof.panelLoad2.Width += 1;
                }
                menuBattleModes.Enabled = true;
                menuFarm.Enabled = true;
                menuCrafts.Enabled = true;
                menuEvents.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool alreadyopened = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Events")
                {
                    alreadyopened = true;
                }
            }
            if (alreadyopened)
            {
            }
            else
            {
                ActivateButton(sender);
                Events eventek = new Events(this);
                OpenMellekForm(eventek, sender);
            }
        }

        [DllImport("gdi32.dll", EntryPoint = "AddFontResourceW", SetLastError = true)]
        public static extern int AddFontResource([In][MarshalAs(UnmanagedType.LPWStr)]
                                         string lpFileName);

        private async void Form1_Load(object sender, EventArgs e)
        {
            AddFontResource(Path.GetFullPath(Path.Combine(Application.StartupPath, @"Image\MEPHISTO.TTF")));

            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                throw (new Exception("Database cannot connect"));
            }

            FirebaseResponse resp = await client.GetTaskAsync("Texts/version");
            Texts version = resp.ResultAs<Texts>();


            versionLabel.Text = "v" + version.text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisableButton();
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Battlemodes" || frm.Name == "Crafts" || frm.Name == "FarmPoss" || frm.Name == "Events" || frm.Name == "Professions")
                {
                    frm.Hide();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/q6K3TvM");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/4Secret.net");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.4secret.net/");
        }
    }
}
