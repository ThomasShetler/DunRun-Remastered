using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunRun_Remastered
{
    public class dungeon
    {
       
       public Enemy Boss { get; set; }
       public List<floor> floors = new List<floor>();
    }
    public class floor 
    {
        public int level { get; set; }
        public List<Enemy> Enemies = new List<Enemy>();
        
    }


}
