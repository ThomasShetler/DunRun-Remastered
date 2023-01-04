using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace DunRun_Remastered
{
    public class Enemies
    {
       public List<Enemy> EnyTeir1()
        {
            List<Enemy> enemies = new List<Enemy>();
            Armor cloth = new Armor();
            Items items = new Items();
            cloth.Name = "Cloth Armror";
            cloth.Description = "just a few rags to protect your junk!";
            cloth.defense = 2;
            cloth.qty = 1;
            Enemy enemy = new Enemy();
            enemy.Name = "Snoodly";
            enemy.weapon = items.GenWeapon(items.FirstTeirWeapon());
            enemy.armor = cloth;
            enemy.DropItem = enemy.weapon;
            enemy.RewardGold = 20;
            enemy.level = 1;
            enemy.RewardExp = 20;
            enemy.hp = 10;
            enemy.attack = 7;
            enemy.defense = 10;
            enemies.Add(enemy);
            Enemy enemy2 = new Enemy();
            enemy2.Name = "Rat";
            enemy2.weapon = items.GenWeapon(items.FirstTeirWeapon());
            enemy2.armor = cloth;
            enemy2.DropItem = enemy2.weapon;
            enemy2.RewardGold = 20;
            enemy2.level = 1;
            enemy2.RewardExp = 20;
            enemy2.hp = 5;
            enemy2.attack = 3;
            enemy2.defense = 3;
            enemies.Add(enemy2);
            Enemy enemy3 = new Enemy();
            enemy3.Name = "Big Bug";
            enemy3.weapon = items.GenWeapon(items.FirstTeirWeapon());
            enemy3.armor = cloth;
            enemy3.DropItem = enemy3.weapon;
            enemy3.RewardGold = 20;
            enemy3.level = 1;
            enemy3.RewardExp = 20;
            enemy3.hp = 5;
            enemy3.attack = 3;
            enemy3.defense = 3;
            enemies.Add(enemy3);
            Enemy enemy4 = new Enemy();
            enemy4.Name = "Ankle Biter Goblin";
            enemy4.weapon = items.GenWeapon(items.FirstTeirWeapon());
            enemy4.armor = cloth;
            enemy4.DropItem = enemy4.weapon;
            enemy4.RewardGold = 20;
            enemy4.level = 1;
            enemy4.RewardExp = 20;
            enemy4.hp = 5;
            enemy4.attack = 3;
            enemy4.defense = 3;
            enemies.Add(enemy4);
            return enemies;
        } 
    }
}
