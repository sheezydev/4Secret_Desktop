using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Secret_Project
{
    public class CraftItems
    {
        public string name;
        public string category;
        public string level;
        private int osiris;
        private int wellwater;
        private string mithrilOrWeapon;
        private int mithrilOrWeaponAmount;
        private int ingot1;
        private int ingot2;
        private int ingot3;
        private int ingot4;
        private int waterofworld;


        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public string Level { get => level; set => level = value; }
        public int Osiris { get => osiris; set => osiris = value; }
        public int Wellwater { get => wellwater; set => wellwater = value; }
        public string MithrilOrWeapon { get => mithrilOrWeapon; set => mithrilOrWeapon = value; }
        public int Ingot1 { get => ingot1; set => ingot1 = value; }
        public int Ingot2 { get => ingot2; set => ingot2 = value; }
        public int Ingot3 { get => ingot3; set => ingot3 = value; }
        public int Ingot4 { get => ingot4; set => ingot4 = value; }
        public int Waterofworld { get => waterofworld; set => waterofworld = value; }
        public int MithrilOrWeaponAmount { get => mithrilOrWeaponAmount; set => mithrilOrWeaponAmount = value; }

        public CraftItems()
        {
            this.Name = name;
            this.Category = category;
            this.Level = level;
        }

        public CraftItems(string name, string category, string level, int osiris, int wellwater, string mithrilOrWeapon, int ingot1, int ingot2, int ingot3, int ingot4, int waterofworld , int mithrilOrWeaponAmount)
        {
            this.Name = name;
            this.Category = category;
            this.Level = level;
            this.Osiris = osiris;
            this.Wellwater = wellwater;
            this.MithrilOrWeapon = mithrilOrWeapon;
            this.Ingot1 = ingot1;
            this.Ingot2 = ingot2;
            this.Ingot3 = ingot3;
            this.Ingot4 = ingot4;
            this.Waterofworld = waterofworld;
            this.MithrilOrWeaponAmount = MithrilOrWeaponAmount;
        }
    }

   
}
