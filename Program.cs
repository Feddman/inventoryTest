using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory(200);

            Item apple = new Item("apple", 30);
            Item sword = new Item("sword", 100);

            Item dragonShield = new Item("Dragon Shield", 400);

            inventory.addItem(apple);
            inventory.addItem(apple);
            inventory.addItem(sword);


            inventory.viewItems();


            inventory.addItem(dragonShield); 


        }

       
       

    }
}
