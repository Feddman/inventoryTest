using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Inventory
    {
        private List<Item> items = new List<Item>();
        private int maxWeight;
        private int weight;
        

        public Inventory(int max) 
        {
            this.maxWeight = max;
            this.weight = 0;
        }


        public void addItem(Item item)
        {
            if (item.getWeight() <= this.maxWeight )
            {
                Console.WriteLine(item.getName() + " has been added to your inventory.");
                this.weight += item.getWeight();
                this.items.Add(item);
            }
            else 
            {
                Console.WriteLine("\n Can not carry this item any more. You can only carry " + this.getWeightRemains() + "\nAnd the item you picked up was a " + item.getName() + " with a weight of " + item.getWeight());

            }
        }

        public int getWeightRemains()
        {
            return this.maxWeight - this.weight;
        }

        public void viewItems()
        {
            if (this.items.Any())
            {
                Console.WriteLine("\nCurrently in Inventory: \n");
                foreach (Item item in this.items)
                {
                    Console.WriteLine(item.getName());
                }
                Console.WriteLine("\n" + getWeightRemains() + " left to carry \n");
            }
                
         
        }

        /*
         * GETTERS SETTERS
         * 
         */

        public void setMaxWeight(int max)
        {
            this.maxWeight = max;
        }

        public int getWeight()
        {
            return this.weight;
        }


        public int getMaxWeight()
        {
            return this.maxWeight;
        }
    }
}
