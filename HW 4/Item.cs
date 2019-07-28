using System;
using System.Collections.Generic;
using System.Text;

namespace HW_4
{
    class Item : ICloneable
    {
        public int id;
        public string name;
        public int intelligence;
        public int agility;
        public int strength;

        public Item()
        {
            name = "item";
            intelligence = 0;
            agility = 0;
            strength = 0;
        }

        public virtual object Clone()
        {
            Item clone_item = new Item();
            clone_item.id = this.id;
            clone_item.name = this.name;
            clone_item.strength = this.strength;
            clone_item.agility = this.agility;
            clone_item.intelligence = this.intelligence;
         
            return clone_item;
        }


        public override string ToString()
        {
            return $" {name} ({intelligence} {agility} {strength})";
        }
    }
}

