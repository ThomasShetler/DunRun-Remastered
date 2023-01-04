using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunRun_Remastered
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int qty { get; set; }

        public int SellPrice { get; set; }

    }
    public class Healthitem : Item
    {
        public int healingpower { get; set; }
    }
    public class Armor : Item
    {
        public int defense { get; set; }

    }
    public class Weapon: Item
    {
        public int attack { get; set; }

        
    }


}
