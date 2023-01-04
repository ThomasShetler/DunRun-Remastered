using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DunRun_Remastered
{
    public class Entity
    {
        public int level { get; set; }
        public string Name { get; set; }
        public double  hp { get; set; }
        public int defense { get; set; }
        public int attack { get; set; }
        public string Picture { get; set; }
        public List<object> invetory = new List<object>();
    
        public Armor armor { get; set; }

        public Weapon weapon { get; set; }
    }
    public class Player : Entity
    {

        public int gold { get; set; }
        public int magic { get; set; }
        public double exp { get; set; }
        public double TillNext { get; set; }

    }
    public class Enemy : Entity
    {
        public Item DropItem { get; set; }
        public int RewardGold { get; set; }
        public int RewardExp { get; set; }
    }


}
