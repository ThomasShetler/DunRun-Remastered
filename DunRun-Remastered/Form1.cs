using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DunRun_Remastered
{
    public partial class Form1 : Form
    {
        public Player player = new Player();
        public Enemy enemy1 = new Enemy();
        public dungeon dungeon1 = new dungeon();


        public bool buttonClick = false;

        public void genreateDungeon()
        {
            int i = 0;
            while(i < 10)
            {
                dungeon1.floors.Add(GenerateFloor(i));
                i++;
            }
   

        }
        public floor GenerateFloor(int level)
        {
            floor neflor = new floor();
            neflor.level = level;
            int i = 0;
            while (i < 10)
            {

                neflor.Enemies.Add(generateEnemy());
                i++;
            }
           
            return neflor;
        }
        public Enemy generateEnemy()
        {
            Enemies enemy = new Enemies();
            List<Enemy> enemies = enemy.EnyTeir1();
            Random rnd = new Random();
            System.Threading.Thread.Sleep(10);
            int randIndex = rnd.Next(enemy.EnyTeir1().Count);
                    
            Enemy random = enemies[randIndex];
            return random;


        }
        
        public Form1()
        {
            InitializeComponent();
            //listBox1.Items.Add(player.invetory);
            //enemy1.weapon
            Weapon Stick = new Weapon();
            Stick.Name = "stick";
            Stick.Description = "just a basic stick";
            Stick.attack = 2;
            Armor cloth = new Armor();
            cloth.Name = "Cloth Armror";
            cloth.Description = "just a few rags to protect your junk!";
            cloth.defense = 2;
            enemy1.weapon = Stick;
            enemy1.armor = cloth;
            enemy1.DropItem = Stick;
            enemy1.RewardGold = 20;
            enemy1.level = 1;
            enemy1.RewardExp = 20;
            enemy1.hp = 10;
            enemy1.attack = 7;
            enemy1.defense = 10;


        }
        public void UpdateLeveling()
        {
            progressBar1.Maximum = Convert.ToInt32(player.TillNext);
            progressBar1.Value = Convert.ToInt32(player.exp);
        }
        public void updateUI()
        {

            label10.Text = player.hp.ToString();
            label9.Text = player.attack.ToString();
            label13.Text = player.gold.ToString();
            label15.Text = player.magic.ToString();
            label7.Text = player.Name.ToString();
            label21.Text = player.defense.ToString();
            label18.Text = player.weapon.attack.ToString();
            label19.Text = player.armor.defense.ToString();
            label24.Text = player.exp.ToString();
            label28.Text = player.level.ToString();
            label26.Text = player.TillNext.ToString();
            label30.Text = floorlevel.ToString();
            if (enemy1.Name != null)
            {
                label3.Text = enemy1.hp.ToString();
                label6.Text = enemy1.Name.ToString();
            }
            
            
            listBox1.Items.Clear();
            foreach (Item item in player.invetory)
            {
                if (item == player.weapon || item == player.armor)
                {
                    listBox1.Items.Add(item.Name + $" [{item.qty}][EQP]");
                }
                else
                {
                    listBox1.Items.Add(item.Name + $" [{item.qty}]");
                }
               
            
                
            }

        }
        public void AddToInventory(Item item1) {
            
            List<int> index = new List<int>();
            bool ItemNotInInventory = true;
            int i = 0;
            foreach (Item item in player.invetory)
            {
                if (item.Name == item1.Name)
                {
                    item.qty = item.qty + 1;
                    ItemNotInInventory = false;
                }
                i++;

            }
            if (ItemNotInInventory == true)
            {
                player.invetory.Add(item1);
            }
            listBox1.Items.Clear();
            foreach (Item item in player.invetory)
            {
                if (item == player.weapon || item == player.armor)
                {
                    listBox1.Items.Add(item.Name + $" [{item.qty}][EQP]");
                }
                else
                {
                    listBox1.Items.Add(item.Name + $" [{item.qty}]");
                }



            }
            updateUI();
        }
        public void UpdateStats()
        {
            if (player.exp > player.TillNext)
            {
                player.TillNext = player.TillNext + (player.TillNext / 10) * 10;
                player.level = player.level + 1;
                richTextBox1.AppendText($"you leveled up to level:{player.level}");
                
            }
            UpdateLeveling();



        }


        private async void button4_Click(object sender, EventArgs e)
        {

            await FightSeqecence(player, enemy1);
        }
        public void BuildDungeon()
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            SelectCharacter selectCharacter = new SelectCharacter(this);
            selectCharacter.Show();


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }
        private async Task UpdateInventory()
        {
            listBox1.Items.Clear();
            foreach(Item item in player.invetory)
            {
                if(item.Name == player.weapon.Name)
                {
                    listBox1.Items.Add(item.Name + " [EQUIDED]");
                }
                listBox1.Items.Add(item.Name);

            }
        }
            
        private async Task Attack(Player player, Enemy enemy)
        {
            int attack = player.attack + player.weapon.attack;
            if (player.hp > 0)
                {
                    
                    enemy.hp = enemy.hp - attack + enemy.defense;
                    richTextBox1.AppendText($" \b Enemy took {attack - enemy.defense} Damange! Enemy Hp is now at {enemy.hp}");
                }
            int enattack = enemy.attack + enemy.weapon.attack;
                if (enemy.hp > 0)
                {
                   
                    player.hp = (player.hp - enattack) + player.defense;
                    richTextBox1.AppendText($" \b Player took {enattack - player.defense} Damange! Hp is now at {player.hp}");
                    label13.Text = player.hp.ToString();
                }
                if (enemy.hp <= 0)
                {
                    richTextBox1.AppendText("\b you won!");
                    player.exp = player.exp + enemy.RewardExp;
                    player.gold = player.gold + enemy.RewardGold;
                     richTextBox1.AppendText("\b you won!");
                    AddToInventory(enemy.DropItem);
                
                    ChangeEnemy();
                    updateUI();

                }
                else if (player.hp <= 0)
                {
                    richTextBox1.AppendText("\b you loose!");
                }
                richTextBox1.AppendText($"\b What to do now??");
            
        }

        private async Task FightSeqecence(Player player, Enemy enemy)
            {
                while (player.hp > 0 || enemy.hp > 0)
                {
                    int attack = player.attack + player.weapon.attack;
                    enemy.hp = enemy.hp - attack + enemy.defense;
                    richTextBox1.AppendText($" \b Enemy took {attack - enemy.defense} Damange! Enemy Hp is now at {enemy.hp}");
                    int enattack = enemy.attack + enemy.weapon.attack;
                    player.hp = player.hp - attack + enemy.defense;
                    richTextBox1.AppendText($" \b Enemy took {enattack - player.defense} Damange! Hp is now at {player.hp}");

                }
                if (enemy.hp > 0)
                {
                    richTextBox1.AppendText("\b you won!");
                    ChangeEnemy();
                    



                }
                else
                {
                    richTextBox1.AppendText("you loose!");
                }
            }

            async void button1_Click(object sender, EventArgs e)
            {
                await Attack(player, enemy1);

            }
        public int floorlevel = 0;
        public int enemyIndex = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            genreateDungeon();

            enemy1 = dungeon1.floors[floorlevel].Enemies[enemyIndex];
            richTextBox1.AppendText($"\b Enemy {dungeon1.floors[floorlevel].Enemies[enemyIndex].Name} Approuches What do you do?");
        }
        private void ChangeEnemy()
        {
            
            ++enemyIndex;
            if (dungeon1.floors[floorlevel].Enemies.Count > enemyIndex)
            {
                enemy1 = dungeon1.floors[floorlevel].Enemies[enemyIndex];
                richTextBox1.AppendText($"\b Enemy {dungeon1.floors[floorlevel].Enemies[enemyIndex].Name} Approuches What do you do?");

            }
            else
            {
                enemyIndex = 0;
                floorlevel++; 
                enemy1 = dungeon1.floors[floorlevel].Enemies[enemyIndex];


            }
            UpdateStats();
            updateUI();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }

    }

