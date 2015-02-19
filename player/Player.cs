using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Player
    {
        private string name;
       
        private int strength;
        private int magic;
        private int dex;

        private int level;

        private int health;
        private int damage; // how many damage absorbed per hit
        
        private int mana;


        public Inventory inventory;

        public Player(string name)
        {
            this.name = name;
            this.inventory = new Inventory(250);
        }

        public void attack()
        {
            Console.WriteLine(this.name + " attacks");
        }

        public void escape()
        {
            Console.WriteLine(this.name + " escapes!");
        }

        public void usePotion(Item item)
        {
            Console.WriteLine(this.name + "used " + item);
        }
        
    }
}
