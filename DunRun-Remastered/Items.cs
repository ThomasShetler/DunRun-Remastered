using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DunRun_Remastered
{
    public class Items
    {
        public List<Weapon> FirstTeirWeapon ()
        {
            List<Weapon> teirOne = new List<Weapon>();
            Weapon i1 = new Weapon();
            i1.attack = 3;
            i1.Name = "Rusty Knife";
            i1.SellPrice = 3;
            i1.qty = 1;
            i1.Description = "just a rusty old knife";
            teirOne.Add(i1);
            Weapon i2 = new Weapon();
            i2.attack = 5;
            i2.Name = "Rusty Sword";
            i2.qty = 1;
            i2.SellPrice = 4;
            i2.Description = "just a rusty old sword";
            teirOne.Add(i2);
            Weapon i3 = new Weapon();
            i3.attack = 2;
            i3.Name = "Stick";
            i3.qty = 1;
            i3.Description = "just a simple stick";
            teirOne.Add(i3);
            Weapon i4 = new Weapon();
            i4.attack = 2;
            i4.Name = "Bone";
            i3.SellPrice = 1;
            i4.qty = 1;
            i4.Description = "a suspicious bone";
            teirOne.Add(i4);
            Weapon i5 = new Weapon();
            i5.attack = 3;
            i5.Name = "Glass Bottle";
            i5.qty = 1;
            i5.SellPrice = 3;
            i5.Description = "A sharp broken glass bottle";
            teirOne.Add(i5);
            return teirOne;

        }
        public List<Weapon> SecondTeirWeapon()
        {
            List<Weapon> teirOne = new List<Weapon>();
            Weapon i1 = new Weapon();
             i1.attack = 6;
            i1.Name = "pocket knife";
            i1.qty = 1;
            i1.Description = "Could be great for cutting some cake!";
            i1.SellPrice = 10;
            teirOne.Add(i1);
            
            Weapon i2 = new Weapon();
            i2.attack = 10;
            i2.Name = "Flimsy Dagger";
            i2.qty = 1;
            i2.SellPrice = 10;
            i2.Description = "Pretty flimsy dagger, still can leave a mark!";
            teirOne.Add(i2);
            Weapon i3 = new Weapon();
            i3.attack = 8;
            i3.Name = "Club";
            i3.qty = 1;
            i3.SellPrice = 10;
            i3.Description = "A heavy hitter indeed";
            teirOne.Add(i3);
            Weapon i4 = new Weapon();
            i4.attack = 7;
            i4.Name = "Spiked Bone";
            i4.qty = 1;
            i4.SellPrice = 10;
            i4.Description = "Sharpened bone!";
            teirOne.Add(i4);
            Weapon i5 = new Weapon();
            i5.attack = 6;
            i5.Name = "Stubby Spear";
            i5.qty = 1;
            i5.Description = "a not very sharp spear";
            i5.SellPrice = 15;
            teirOne.Add(i5);

            return teirOne;
        }
        public Weapon GenWeapon(List<Weapon> items)
        {
            Random rand = new Random();
            System.Threading.Thread.Sleep(10);
            int randomnum= rand.Next(items.Count);

            return items[randomnum];
         
        }

      
   



    }
}
