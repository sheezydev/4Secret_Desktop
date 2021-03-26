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

namespace _4Secret_Project
{
    public partial class Crafts : Form
    {
        Form1 main;
        List<CraftItems> lista;

        public Crafts(Form1 alap)
        {
            lista = new List<CraftItems>
            {
                new CraftItems { Name = "Ekim Orc Rod" , Category = "Rod" , Level  = "36" , Ingot1 = 180, Ingot2 = 180 , Ingot3 = 180 , Ingot4  = 180 , MithrilOrWeapon = "Mithril" , MithrilOrWeaponAmount = 50, Osiris =32 , Wellwater=4 , Waterofworld = 20},
                new CraftItems { Name = "Book of Shadows" , Category = "Book" , Level  = "36"  , Ingot1 = 45, Ingot2 = 45 , Ingot3 = 45 , Ingot4  = 45 , MithrilOrWeapon = "Mithril" , MithrilOrWeaponAmount = 12, Osiris =8 , Wellwater=1 , Waterofworld = 5},
                new CraftItems { Name = "Succubus Queen's Wand" , Category = "Wand" , Level  = "36"  , Ingot1 = 135, Ingot2 = 135 , Ingot3 = 135 , Ingot4  = 135 , MithrilOrWeapon = "Mithril" ,MithrilOrWeaponAmount = 38, Osiris =8 , Wellwater=4 , Waterofworld = 15},
                new CraftItems { Name = "Lapiris' Mercy" , Category = "Crossbow" , Level  = "36"  , Ingot1 = 180, Ingot2 = 180 , Ingot3 = 180 , Ingot4  = 180 , MithrilOrWeapon = "Mithril" ,MithrilOrWeaponAmount = 50, Osiris =20 , Wellwater=4 , Waterofworld = 20},
                new CraftItems { Name = "Little Muray's Two-Handed Hammer" , Category = "Axe" , Level = "36", Ingot1 = 180, Ingot2 = 180 , Ingot3 = 180 , Ingot4  = 180 , MithrilOrWeapon = "Mithril" , MithrilOrWeaponAmount = 50, Osiris =20 , Wellwater=4 , Waterofworld = 20},
                new CraftItems { Name = "Night Bringer" , Category = "Chakram" , Level  = "36"  , Ingot1 = 180, Ingot2 = 180 , Ingot3 = 180 , Ingot4  = 180 , MithrilOrWeapon = "Mithril" , MithrilOrWeaponAmount = 50, Osiris =20 , Wellwater=4 , Waterofworld = 20},
                new CraftItems { Name = "Pirate's Shortsword" , Category = "Dagger" , Level  = "36"  , Ingot1 = 45, Ingot2 = 45 , Ingot3 = 45 , Ingot4  = 45 , MithrilOrWeapon = "Mithril" , MithrilOrWeaponAmount = 12, Osiris =8 , Wellwater=1 , Waterofworld = 5},
                new CraftItems { Name = "Shield of Shadows" , Category = "Shield" , Level  = "36"  , Ingot1 = 45, Ingot2 = 45 , Ingot3 = 45 , Ingot4  = 45 , MithrilOrWeapon = "Mithril" , MithrilOrWeaponAmount = 12, Osiris =8 , Wellwater=1 , Waterofworld = 5},
                new CraftItems { Name = "Skeleton One-Hand Sword" , Category = "One-Handed" , Level  = "36"  , Ingot1 = 135, Ingot2 = 135 , Ingot3 = 135 , Ingot4  = 135 , MithrilOrWeapon = "Mithril " ,MithrilOrWeaponAmount = 38, Osiris =8 , Wellwater=4 , Waterofworld = 15},
                new CraftItems { Name = "Shortsword of the Ice-cold Murderer" , Category = "Dagger" , Level  = "38", Ingot1 = 75 , Ingot2 = 75 , Ingot3 = 75 , Ingot4 = 50 , MithrilOrWeapon = "Haylolien (Dungeon 79)" , MithrilOrWeaponAmount = 1 , Osiris = 20 , Wellwater = 5 , Waterofworld = 30},
                new CraftItems { Name = "Emperor's Sword" , Category = "One-Handed" , Level  = "38" , Ingot1 = 225 , Ingot2 = 225 , Ingot3 = 225 , Ingot4 = 150 , MithrilOrWeapon = "Akanok (Dungeon 79)" , MithrilOrWeaponAmount = 1 , Osiris = 40 , Wellwater = 15 , Waterofworld = 90},
                new CraftItems { Name = "Axe of the Immortal" , Category = "Axe" , Level  = "38" , Ingot1 = 300 , Ingot2 = 300 , Ingot3 = 300 , Ingot4 = 200 , MithrilOrWeapon = "Ensollaze (Dungeon 79)" , MithrilOrWeaponAmount = 1 , Osiris = 60 , Wellwater = 20 , Waterofworld = 120},
                new CraftItems { Name = "Crossbow of the Abyss" , Category = "Crossbow" , Level  = "38", Ingot1 = 300 , Ingot2 = 300 , Ingot3 = 300 , Ingot4 = 200 , MithrilOrWeapon = "Dark Visit (Dungeon 79)" , MithrilOrWeaponAmount = 1 , Osiris = 60 , Wellwater = 20 , Waterofworld = 120},
                new CraftItems { Name = "King's Shield" , Category = "Shield" , Level  = "38", Ingot1 = 75 , Ingot2 = 75 , Ingot3 = 75 , Ingot4 = 50 , MithrilOrWeapon = "Anundedir (Dungeon 79)" , MithrilOrWeaponAmount = 1 , Osiris = 20 , Wellwater = 5 , Waterofworld = 30},
                new CraftItems { Name = "Wand of the Tamed Magic" , Category = "Wand" , Level  = "38" , Ingot1 = 225 , Ingot2 = 225 , Ingot3 = 225 , Ingot4 = 150 , MithrilOrWeapon = "Touch of Intelligence (Dungeon 79)" , MithrilOrWeaponAmount = 1 , Osiris = 40 , Wellwater = 15 , Waterofworld = 90},
                new CraftItems { Name = "Book of the Noble Spellpower" , Category = "Book" , Level  = "38", Ingot1 = 75 , Ingot2 = 75 , Ingot3 = 75 , Ingot4 = 50 , MithrilOrWeapon = "The Unfolding of Knowledge (Dungeon 79)" , MithrilOrWeaponAmount = 1 , Osiris = 20 , Wellwater = 5 , Waterofworld = 30},
                new CraftItems { Name = "Magic Rod of the Perennial Magic" , Category = "Rod" , Level  = "38" , Ingot1 = 300 , Ingot2 = 300 , Ingot3 = 300 , Ingot4 = 200 , MithrilOrWeapon = "Appreciation of Perfection (Dungeon 79)" , MithrilOrWeaponAmount = 1 , Osiris = 60 , Wellwater = 20 , Waterofworld = 120},
                
            };
            main = alap;
            InitializeComponent();
        }

        public void Crafts_Load(object sender, EventArgs e)
        {


            Items();

        }

        public void Items()
        {


            Items[] ListaItems = new Items[lista.Count];

            for (int i = 0; i < lista.Count; i++)
            {


                ListaItems[i] = new Items();
                ListaItems[i]._Name = lista[i].Name;
                ListaItems[i]._Category = lista[i].Category;
                ListaItems[i]._Level = Convert.ToString(lista[i].Level);
                if (ListaItems[i]._Level == "36")
                {
                    ListaItems[i]._Ingot1 = "Copper Ingot " + lista[i].Ingot1 + " Piece";
                    ListaItems[i]._Ingot2 = "Iron Ingot " + lista[i].Ingot2 + " Piece";
                    ListaItems[i]._Ingot3 = "Silver Ingot " + lista[i].Ingot3 + " Piece";
                    ListaItems[i]._Ingot4 = "Cobalt Ingot " + lista[i].Ingot4 + " Piece";
                }
                else
                {
                    ListaItems[i]._Ingot1 = "Gold Ingot " + lista[i].Ingot1 + " Piece";
                    ListaItems[i]._Ingot2 = "Chalcopyrite Ingot " + lista[i].Ingot2 + " Piece";
                    ListaItems[i]._Ingot3 = "Malachite Ingot " + lista[i].Ingot3 + " Piece";
                    ListaItems[i]._Ingot4 = "Hematite Ingot " + lista[i].Ingot4 + " Piece";
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
                ListaItems[i]._MithrilOrWeapon = lista[i].MithrilOrWeapon + " " + lista[i].MithrilOrWeaponAmount + " Piece";
                
                ListaItems[i]._Osiris = "Osiris Gemstone " + lista[i].Osiris + " Piece";
                ListaItems[i]._Waterofworld = "Water of World " + lista[i].Waterofworld + " Piece";
                ListaItems[i]._Wellwater = "Well Water " + lista[i].Wellwater + " Piece";
                string dirname = Path.GetFullPath(Path.Combine(Application.StartupPath, @"Image\"));
                string filename = dirname + lista[i].Name + ".png";
                using (Bitmap bm = new Bitmap(filename))
                {
                    ListaItems[i].pictureBox1.Image = (Bitmap)bm.Clone();
                }

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
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();


            Items[] ListaItemek = new Items[lista.Count];
            if (textBoxSearch.text == "")
            {
                MessageBox.Show("You did not search for nothing!");

                Items();

            }
            else
            {
                if (textBoxSearch.text != "")
                {
                    List<CraftItems> h = lista.Where(i => i.Name.Contains(textBoxSearch.text) || i.Name.ToLower().Contains(textBoxSearch.text.ToLower()) || i.Category.ToLower() == textBoxSearch.text.ToLower()).ToList();
                    if (h.Count > 0)
                    {
                        Items[] ListaItems = new Items[h.Count];
                        for (int i = 0; i < h.Count; i++)
                        {

                            ListaItems[i] = new Items();
                            ListaItems[i]._Name = h[i].Name;
                            ListaItems[i]._Category = h[i].Category;
                            ListaItems[i]._Level = Convert.ToString(h[i].Level);
                            if (ListaItems[i]._Level == "36")
                            {
                                ListaItems[i]._Ingot1 = "Copper Ingot " + h[i].Ingot1 + " Piece";
                                ListaItems[i]._Ingot2 = "Iron Ingot " + h[i].Ingot2 + " Piece";
                                ListaItems[i]._Ingot3 = "Silver Ingot " + h[i].Ingot3 + " Piece";
                                ListaItems[i]._Ingot4 = "Cobalt Ingot " + h[i].Ingot4 + " Piece";
                            }
                            else
                            {
                                ListaItems[i]._Ingot1 = "Gold Ingot " + h[i].Ingot1 + " Piece";
                                ListaItems[i]._Ingot2 = "Chalcopyrite Ingot " + h[i].Ingot2 + " Piece";
                                ListaItems[i]._Ingot3 = "Malachite Ingot " + h[i].Ingot3 + " Piece";
                                ListaItems[i]._Ingot4 = "Hematite Ingot " + h[i].Ingot4 + " Piece";
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
                            ListaItems[i]._MithrilOrWeapon = lista[i].MithrilOrWeapon + " " + lista[i].MithrilOrWeaponAmount + " Piece";

                            ListaItems[i]._Osiris = "Osiris Gemstone " + h[i].Osiris + " Piece";
                            ListaItems[i]._Waterofworld = "Water of World " + h[i].Waterofworld + " Piece";
                            ListaItems[i]._Wellwater = "Well Water " + h[i].Wellwater + " Piece";
                            string dirname = Path.GetFullPath(Path.Combine(Application.StartupPath, @"Image\"));
                            string filename = dirname + h[i].Name + ".png";
                            using (Bitmap bm = new Bitmap(filename))
                            {
                                ListaItems[i].pictureBox1.Image = (Bitmap)bm.Clone();
                            }

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
                    else
                    {
                        MessageBox.Show("We can't find nothing with this filter!");
                        Items();
                    }
                }
            }
        }

        private void textBoxSearch_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {

        }
    }
}
