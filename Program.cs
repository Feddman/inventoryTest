using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {   
            Player fedde = new Player("fedde");

            Item apple = new Item("apple", 30);
            Item sword = new Item("sword", 100);

            Item dragonShield = new Item("Dragon Shield", 400);



            fedde.inventory.addItem(apple);
            fedde.inventory.addItem(apple);
            fedde.inventory.addItem(sword);


            fedde.inventory.viewItems();
            

            fedde.inventory.addItem(dragonShield); 


        }

       
       

    }
}
