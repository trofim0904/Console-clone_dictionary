using System;
using System.Collections.Generic;
using System.Text;

namespace HW_4
{
    class Io:Hero, IStrikePower
    {
        public Io()
        {
            items = new ItemList<Item>();
            name = "Io";
            strength = 17;
            agility = 14;
            intelligence = 23;
            power = StrikePower();
        }

        public int StrikePower()
        {
            return strength * 2;
        }
    }
}
