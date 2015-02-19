using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Item
    {
        private string name;
        private int weight;

        public Item(string name, int weight) {
            this.name = name;
            this.weight = weight;
        }

        /*
         *GETTERS AND SETTERS 
         * 
         */

        public string getName()
        {
            return this.name;
        }

        public int getWeight()
        {
            return this.weight;
        }



    }
}
