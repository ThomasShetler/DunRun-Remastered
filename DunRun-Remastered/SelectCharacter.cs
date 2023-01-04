using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DunRun_Remastered
{
    public partial class SelectCharacter : Form
    {
        private Form1 parentForm;
        public SelectCharacter(Form1 parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            parentForm.player.Name = textBox1.Text;

            if (radioButton1.Checked == true)
            {
                Weapon Stick = new Weapon();
                Stick.Name = "stick";
                Stick.Description = "just a basic stick";
                Stick.attack = 2;
                Armor cloth = new Armor();
                cloth.Name = "Cloth Armror";
                cloth.Description = "just a few rags to protect your junk!";
                cloth.defense = 2;
                parentForm.player.attack = 10;
                parentForm.player.hp = 20;
                parentForm.player.defense = 20;
                parentForm.player.magic = 10;
                parentForm.player.weapon = Stick;
                parentForm.player.invetory.Add(Stick);
                parentForm.player.armor = cloth;
                parentForm.player.invetory.Add(cloth);
                parentForm.player.TillNext = 20;
                parentForm.player.level = 1;

            }
            if (radioButton2.Checked == true)
            {
                Weapon Stick = new Weapon();
                Stick.Name = "stick";
                Stick.Description = "just a basic stick";
                Stick.attack = 2;
                Stick.qty = 1;
                Armor cloth = new Armor();
                cloth.Name = "Cloth Armror";
                cloth.Description = "just a few rags to protect your junk!";
                cloth.defense = 2;
                cloth.qty = 1;
                parentForm.player.level = 1;
                parentForm.player.attack = 20;
                parentForm.player.hp = 20;
                parentForm.player.defense = 10;
                parentForm.player.magic = 10;
                parentForm.player.weapon = Stick;
                parentForm.player.invetory.Add(Stick);
                parentForm.player.armor = cloth;
                parentForm.player.invetory.Add(cloth);
                parentForm.player.TillNext = 20;

            }
            if (radioButton3.Checked == true)
            {
                Weapon Stick = new Weapon();
                Stick.Name = "stick";
                Stick.Description = "just a basic stick";
                Stick.attack = 2;

                Armor cloth = new Armor();
                cloth.Name = "Cloth Armror";
                cloth.Description = "just a few rags to protect your junk!";
                cloth.defense = 2;
                parentForm.player.attack = 15;
                parentForm.player.hp = 15;
                parentForm.player.defense = 15;
                parentForm.player.magic = 10;
                parentForm.player.weapon = Stick;
                parentForm.player.armor = cloth;
                parentForm.player.invetory.Add(cloth);
                parentForm.player.invetory.Add(Stick);
                parentForm.player.TillNext = 20;
                parentForm.player.level = 1;


            }
            parentForm.updateUI();
            this.Close();

        }

    }
}
