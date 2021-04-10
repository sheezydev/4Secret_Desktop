using _4Secret_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.IO;
using System.Globalization;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace _4Secret_Project
{
    public partial class Crafts : Form
    {
        Form1 main;
        
        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://test-6295b-default-rtdb.europe-west1.firebasedatabase.app/",
            AuthSecret = "ChHZAP8OX3LLIbei2osvlvcqyfYjVeXuWBAoth1F"
        };
        IFirebaseClient client;
        public Crafts(Form1 alap)
        {

            main = alap;
            InitializeComponent();
        }
        
        public void Crafts_Load(object sender, EventArgs e)
        {



            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                throw (new Exception("Database cannot connect"));
            }


            timer1.Start();
            label3.Text = "Crafts are loading..";
            Items();


        }

        public static string ImageIntoBase64String(PictureBox pbox)
        {
            MemoryStream ms = new MemoryStream();
            pbox.Image.Save(ms, pbox.Image.RawFormat);
            return Convert.ToBase64String(ms.ToArray());
        }

        public static Image Base64StringIntoImage(string str64)
        {
            byte[] img = Convert.FromBase64String(str64);
            MemoryStream ms = new MemoryStream(img);
            return Image.FromStream(ms);
        }


        public async void Items()
        {
            FirebaseResponse resp = await client.GetTaskAsync("Counter/weapons");
            nodeWeapon get = resp.ResultAs<nodeWeapon>();


            Items[] ListaItems = new Items[Convert.ToInt32(get.count)];

            int k = 1;
            for (int i = 0; i < Convert.ToInt32(get.count); i++)
            {
                FirebaseResponse resp2 = await client.GetTaskAsync("Weapons/" + k);
                CraftItems obj2 = resp2.ResultAs<CraftItems>();
                k++;
                ListaItems[i] = new Items();
                ListaItems[i]._Name = obj2.Name;
                ListaItems[i]._Category = obj2.Category;
                ListaItems[i]._Level = obj2.Level;
                var res = await client.GetTaskAsync("Images/" + ListaItems[i]._Name);
                ImageModal data = res.ResultAs<ImageModal>();
                ListaItems[i].pictureBox1.Image = Base64StringIntoImage(data.ImageString);

                if (ListaItems[i]._Level == "36")
                {
                    ListaItems[i]._Ingot1 = "Copper Ingot " + Convert.ToString(obj2.Ingot1) + " Piece";
                    ListaItems[i]._Ingot2 = "Iron Ingot " + Convert.ToString(obj2.Ingot2) + " Piece";
                    ListaItems[i]._Ingot3 = "Silver Ingot " + Convert.ToString(obj2.Ingot3) + " Piece";
                    ListaItems[i]._Ingot4 = "Cobalt Ingot " + Convert.ToString(obj2.Ingot4) + " Piece";
                }
                else
                {
                    ListaItems[i]._Ingot1 = "Gold Ingot " + Convert.ToString(obj2.Ingot1) + " Piece";
                    ListaItems[i]._Ingot2 = "Chalcopyrite Ingot " + Convert.ToString(obj2.Ingot2) + " Piece";
                    ListaItems[i]._Ingot3 = "Malachite Ingot " + Convert.ToString(obj2.Ingot3) + " Piece";
                    ListaItems[i]._Ingot4 = "Hematite Ingot " + Convert.ToString(obj2.Ingot4) + " Piece";
                }

                if (ListaItems[i]._Level == "36" && (ListaItems[i]._Category == "Rod" || ListaItems[i]._Category == "Wand"))
                {
                    ListaItems[i].labelStones.Text = "Holy Stone of Hesed Castle 1 Piece";
                }
                else
                {
                    if (ListaItems[i]._Level == "36" && (ListaItems[i]._Category == "Crossbow" || ListaItems[i]._Category == "One-Handed" || ListaItems[i]._Category == "Chakram" || ListaItems[i]._Category == "Axe"))
                    {
                        ListaItems[i].labelStones.Text = "Holy Stone of Ardir Castle 1 Piece";
                    }
                    else
                    {
                        if (ListaItems[i]._Level == "36" && (ListaItems[i]._Category == "Book" || ListaItems[i]._Category == "Shield" || ListaItems[i]._Category == "Dagger"))
                        {
                            ListaItems[i].labelStones.Text = "You don't need a stone for this one!";
                        }
                        else
                        {
                            if (ListaItems[i]._Level == "38" && ListaItems[i]._Category == "Rod")
                            {
                                ListaItems[i].labelStones.Text = "Holy Stone of Tyconteroga Castle 12 Piece";
                            }
                            else
                            {
                                if (ListaItems[i]._Level == "38" && ListaItems[i]._Category == "Crossbow" || ListaItems[i]._Category == "Axe" || ListaItems[i]._Category == "Chakram")
                                {
                                    ListaItems[i].labelStones.Text = "Holy Stone of Gebra Castle 12 Piece";
                                }
                                else
                                {
                                    if (ListaItems[i]._Level == "38" && ListaItems[i]._Category == "Wand")
                                    {
                                        ListaItems[i].labelStones.Text = "Holy Stone of Tyconteroga Castle 9 Piece";
                                    }
                                    else
                                    {
                                        if (ListaItems[i]._Level == "38" && ListaItems[i]._Category == "One-Handed")
                                        {
                                            ListaItems[i].labelStones.Text = "Holy Stone of Gebra Castle 9 Piece";
                                        }
                                        else
                                        {
                                            if (ListaItems[i]._Level == "38" && ListaItems[i]._Category == "Book")
                                            {
                                                ListaItems[i].labelStones.Text = "Holy Stone of Tyconteroga Castle 3 Piece";
                                            }
                                            else
                                            {
                                                if (ListaItems[i]._Level == "38" && (ListaItems[i]._Category == "Shield" || ListaItems[i]._Category == "Dagger"))
                                                {
                                                    ListaItems[i].labelStones.Text = "Holy Stone of Gebra Castle 3 Piece";
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                ListaItems[i]._MithrilOrWeapon = obj2.MithrilOrWeapon + " " + obj2.MithrilOrWeaponAmount + " Piece";

                ListaItems[i]._Osiris = "Osiris Gemstone " + obj2.Osiris + " Piece";
                ListaItems[i]._Waterofworld = "Water of World " + obj2.Waterofworld + " Piece";
                ListaItems[i]._Wellwater = "Well Water " + obj2.Wellwater + " Piece";


                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(ListaItems[i]);
                }
            }

        }

        private void bunifuTextbox1_KeyDown(object sender, EventArgs e)
        {

        }

        private async void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();


            FirebaseResponse resp = await client.GetTaskAsync("Counter/weapons");
            nodeWeapon get = resp.ResultAs<nodeWeapon>();


            

            if (textBoxSearch.text == "")
            {
                MessageBox.Show("You did not search for nothing!");

                Items();

            }
            else
            {
                if (textBoxSearch.text != "")
                {
                    //List<CraftItems> h = lista.Where(i => i.Name.Contains(textBoxSearch.text) || i.Name.ToLower().Contains(textBoxSearch.text.ToLower()) || i.Category.ToLower() == textBoxSearch.text.ToLower()).ToList();
                    Items[] ListaItems = new Items[Convert.ToInt32(get.count)];
                    int counter = 0;
                    int k = 1;
                    for (int i = 0; i < Convert.ToInt32(get.count); i++)
                    {
                        FirebaseResponse resp2 = await client.GetTaskAsync("Weapons/" + k);
                        CraftItems obj = resp2.ResultAs<CraftItems>();
                        k++;
                        if (obj.Name.Contains(textBoxSearch.text) || obj.Name.ToLower().Contains(textBoxSearch.text.ToLower()) || obj.Category.ToLower() == textBoxSearch.text.ToLower())
                        {
                            counter++;
                            ListaItems[i] = new Items();
                            ListaItems[i]._Name = obj.Name;
                            ListaItems[i]._Category = obj.Category;
                            ListaItems[i]._Level = obj.Level;
                            var res = await client.GetTaskAsync("Images/" + ListaItems[i]._Name);
                            ImageModal data = res.ResultAs<ImageModal>();
                            ListaItems[i].pictureBox1.Image = Base64StringIntoImage(data.ImageString);
                            if (ListaItems[i]._Level == "36")
                            {
                                ListaItems[i]._Ingot1 = "Copper Ingot " + Convert.ToString(obj.Ingot1) + " Piece";
                                ListaItems[i]._Ingot2 = "Iron Ingot " + Convert.ToString(obj.Ingot2) + " Piece";
                                ListaItems[i]._Ingot3 = "Silver Ingot " + Convert.ToString(obj.Ingot3) + " Piece";
                                ListaItems[i]._Ingot4 = "Cobalt Ingot " + Convert.ToString(obj.Ingot4) + " Piece";
                            }
                            else
                            {
                                ListaItems[i]._Ingot1 = "Gold Ingot " + Convert.ToString(obj.Ingot1) + " Piece";
                                ListaItems[i]._Ingot2 = "Chalcopyrite Ingot " + Convert.ToString(obj.Ingot2) + " Piece";
                                ListaItems[i]._Ingot3 = "Malachite Ingot " + Convert.ToString(obj.Ingot3) + " Piece";
                                ListaItems[i]._Ingot4 = "Hematite Ingot " + Convert.ToString(obj.Ingot4) + " Piece";
                            }

                            if (ListaItems[i]._Level == "36" && (ListaItems[i]._Category == "Rod" || ListaItems[i]._Category == "Wand"))
                            {
                                ListaItems[i].labelStones.Text = "Holy Stone of Hesed Castle 1 Piece";
                            }
                            else
                            {
                                if (ListaItems[i]._Level == "36" && (ListaItems[i]._Category == "Crossbow" || ListaItems[i]._Category == "One-Handed" || ListaItems[i]._Category == "Chakram" || ListaItems[i]._Category == "Axe"))
                                {
                                    ListaItems[i].labelStones.Text = "Holy Stone of Ardir Castle 1 Piece";
                                }
                                else
                                {
                                    if (ListaItems[i]._Level == "36" && (ListaItems[i]._Category == "Book" || ListaItems[i]._Category == "Shield" || ListaItems[i]._Category == "Dagger"))
                                    {
                                        ListaItems[i].labelStones.Text = "You don't need a stone for this one!";
                                    }
                                    else
                                    {
                                        if (ListaItems[i]._Level == "38" && ListaItems[i]._Category == "Rod")
                                        {
                                            ListaItems[i].labelStones.Text = "Holy Stone of Tyconteroga Castle 12 Piece";
                                        }
                                        else
                                        {
                                            if (ListaItems[i]._Level == "38" && ListaItems[i]._Category == "Crossbow" || ListaItems[i]._Category == "Axe" || ListaItems[i]._Category == "Chakram")
                                            {
                                                ListaItems[i].labelStones.Text = "Holy Stone of Gebra Castle 12 Piece";
                                            }
                                            else
                                            {
                                                if (ListaItems[i]._Level == "38" && ListaItems[i]._Category == "Wand")
                                                {
                                                    ListaItems[i].labelStones.Text = "Holy Stone of Tyconteroga Castle 9 Piece";
                                                }
                                                else
                                                {
                                                    if (ListaItems[i]._Level == "38" && ListaItems[i]._Category == "One-Handed")
                                                    {
                                                        ListaItems[i].labelStones.Text = "Holy Stone of Gebra Castle 9 Piece";
                                                    }
                                                    else
                                                    {
                                                        if (ListaItems[i]._Level == "38" && ListaItems[i]._Category == "Book")
                                                        {
                                                            ListaItems[i].labelStones.Text = "Holy Stone of Tyconteroga Castle 3 Piece";
                                                        }
                                                        else
                                                        {
                                                            if (ListaItems[i]._Level == "38" && (ListaItems[i]._Category == "Shield" || ListaItems[i]._Category == "Dagger"))
                                                            {
                                                                ListaItems[i].labelStones.Text = "Holy Stone of Gebra Castle 3 Piece";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            ListaItems[i]._MithrilOrWeapon = obj.MithrilOrWeapon + " " + obj.MithrilOrWeaponAmount + " Piece";

                            ListaItems[i]._Osiris = "Osiris Gemstone " + obj.Osiris + " Piece";
                            ListaItems[i]._Waterofworld = "Water of World " + obj.Waterofworld + " Piece";
                            ListaItems[i]._Wellwater = "Well Water " + obj.Wellwater + " Piece";


                            if (flowLayoutPanel1.Controls.Count < 0)
                            {
                                flowLayoutPanel1.Controls.Clear();
                            }
                            else
                            {
                                flowLayoutPanel1.Controls.Add(ListaItems[i]);
                            }
                        }
                        
                    }


                    if(counter <= 0)
                    {
                        MessageBox.Show("We can't find nothing with this filter!");
                        Items();
                    }
                }
            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelLoad2.Width += 35;

            if (panelLoad2.Width >= panelLoad1.Width)
            {

                timer1.Stop();
                panel1.Visible = false;
            }

        }
    }
}
