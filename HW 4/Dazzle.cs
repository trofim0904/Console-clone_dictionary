using System;
using System.Collections.Generic;
using System.Text;

namespace HW_4
{
    class Dazzle:Hero, IStrikePower
    {
        public Dazzle()
        {
            items = new ItemList<Item>();
            name = "Dazzle";
            strength = 18;
            agility = 21;
            intelligence = 25;
            power = StrikePower();
        }

        public int StrikePower()
        {
            return intelligence * 2;
        }
    }
}
