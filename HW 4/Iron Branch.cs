using System;
using System.Collections.Generic;
using System.Text;

namespace HW_4
{
    class Iron_Branch : Item, ICloneable 
    {
        public Iron_Branch()
        {
            id = 2;
            name = "Iron Branch";
            strength = 1;
            agility = 1;
            intelligence = 1;
        }
      
    }
}
