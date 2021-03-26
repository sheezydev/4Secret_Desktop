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
    public partial class Items : UserControl
    {
        public Items()
        {
            InitializeComponent();
        }


        #region Properties

        private string _category;
        private string _name;
        private string _level;
        private string _osiris;
        private string _wellwater;
        private string _mithrilOrWeapon;
        private int _mitrilOrWeaponAmount;
        private string _ingot1;
        private string _ingot2;
        private string _ingot3;
        private string _ingot4;
        private string _waterofworld;

        [Category("Custom Props")]
        public string _Osiris
        {
            get { return _osiris; }
            set { _osiris = value; labelOsiris.Text = value; }
        }

        [Category("Custom Props")]
        public string _Wellwater
        {
            get { return _wellwater; }
            set { _wellwater = value; labelWellWater.Text =  value; }
        }

        [Category("Custom Props")]
        public string _MithrilOrWeapon
        {
            get { return _mithrilOrWeapon; }
            set { _mithrilOrWeapon = value; labelMithrilOrWeapon.Text = value; }
        }

        [Category("Custom Props")]
        public int _MitrilOrWeaponAmount
        {
            get { return _mitrilOrWeaponAmount; }
            set { _mitrilOrWeaponAmount = value; labelMithrilOrWeapon.Text = Convert.ToString(value); }
        }

        [Category("Custom Props")]
        public string _Ingot1
        {
            get { return _ingot1; }
            set { _ingot1 = value; labelIngot1.Text = value; }
        }

        [Category("Custom Props")]
        public string _Ingot2
        {
            get { return _ingot2; }
            set { _ingot2 = value; labelIngot2.Text = value; }
        }

        [Category("Custom Props")]
        public string _Ingot3
        {
            get { return _ingot3; }
            set { _ingot3 = value; labelIngot3.Text = value; }
        }

        [Category("Custom Props")]
        public string _Ingot4
        {
            get { return _ingot4; }
            set { _ingot4 = value; labelIngot4.Text = value; }
        }

        [Category("Custom Props")]
        public string _Waterofworld
        {
            get { return _waterofworld; }
            set { _waterofworld = value; labelWoW.Text = value; }
        }

        [Category("Custom Props")]
        public string _Category
        {
            get { return _category; }
            set { _category = value; labelCategory.Text = value; }
        }
        [Category("Custom Props")]
        public string _Name
        {
            get { return _name; }
            set { _name = value; labelName.Text = value; }
        }

        [Category("Custom Props")]
        public string _Level
        {
            get { return _level; }
            set { _level = value; labelLevel.Text = value; }
        }

        #endregion

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (Height <= 90)
            {
                panel4.Visible = true;
                this.Height += 267;
                panel4.Location = new Point(3, 87);
            }
            else
            {
                this.Height -= 267;
                panel4.Location = new Point(936, 4);
                panel4.Visible = false;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Height -= 267;
            panel4.Location = new Point(936, 4);
            panel4.Visible = false;
        }
    }
}
