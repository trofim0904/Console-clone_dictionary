using System;
using System.Collections.Generic;
using System.Text;

namespace HW_4
{
    class Bristleback : Hero, IStrikePower
    {
        public Bristleback()
        {
            items = new ItemList<Item>();
            name = "Bristleback";
            strength = 22;
            agility = 17;
            intelligence = 14;
            power = StrikePower();

        }

        public int StrikePower()
        {
            return strength * 2;
        }
    }
}
