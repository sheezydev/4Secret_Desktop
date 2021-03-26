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
    public partial class Form1 : Form
    {
        private bool drag = false;
        private Point startpoint = new Point(0, 0);
        private Form activeForm;
        private Button currentButton;
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
                Crafts kraft = new Crafts(this);
                OpenMellekForm(kraft, sender);
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
                FarmPoss farm = new FarmPoss(this);
                OpenMellekForm(farm, sender);
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
    }
}
