using System;
using System.Collections.Generic;
using System.Text;

namespace HW_4
{
    class Storm_Spirit : Hero, IStrikePower
    {
        public Storm_Spirit()
        {
            items = new ItemList<Item>();
            name = "Storm Spirit";
            strength = 21;
            agility = 22;
            intelligence = 23;
            power = StrikePower();
        }
        public int StrikePower()
        {
            return intelligence * 2;
        }
    }
}
