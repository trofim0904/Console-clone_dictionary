using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HW_4
{
    class Hero: ICloneable
    {
        public string name;
        public int intelligence;
        public int agility;
        public int strength;
        public int power;
        public ItemList<Item> items;

        

        public void GetItems()
        {
            Random random = new Random();
            for(int i = 0; i < 6; i++)
            {
                int id = random.Next(1, 5);
                if (id == 1)
                {
                    items.Add( new Bracer());
                }
                if (id == 2)
                {
                    items.Add(new Iron_Branch());
                }
                if (id == 3)
                {
                    items.Add(new Null_Talisman());
                }
                if (id == 4)
                {
                    items.Add(new Wraith_Band());
                }
            }
            
        }

        public override string ToString()
        {
            
          return $"Name:  {name}  Power: {power} (Int:{intelligence} Agl:{agility} Str:{strength})";
            
        }

        public virtual object Clone()
        {
            Hero clone_hero = new Hero();
            
            clone_hero.name = this.name;
            clone_hero.strength = this.strength;
            clone_hero.agility = this.agility;
            clone_hero.intelligence = this.intelligence;
            clone_hero.power = this.power;
           
            return clone_hero;
        }
    }
}
