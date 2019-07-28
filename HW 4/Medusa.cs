using System;
using System.Collections.Generic;
using System.Text;

namespace HW_4
{
    class Medusa:Hero, IStrikePower
    {
        public Medusa()
        {
            items = new ItemList<Item>();
            name = "Medusa";
            strength = 15;
            agility = 22;
            intelligence = 19;
            power = StrikePower();
        }

        public int StrikePower()
        {
            return agility * 2;
        }
    }
}
