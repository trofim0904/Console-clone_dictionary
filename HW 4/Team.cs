using System;
using System.Collections.Generic;
using System.Text;

namespace HW_4
{
    class Team:ICloneable
    {
        public Dictionary<Hero, ItemList<Item>> team = new Dictionary<Hero, ItemList<Item>>(5);

        

        public void createTeam(Hero hero_1, Hero hero_2, Hero hero_3, Hero hero_4, Hero hero_5)
        {
            team.Add(hero_1, hero_1.items);
            team.Add(hero_2, hero_2.items);
            team.Add(hero_3, hero_3.items);
            team.Add(hero_4, hero_4.items);
            team.Add(hero_5, hero_5.items);
        }



        public object Clone()
        {
            Dictionary<Hero, ItemList<Item>> clone_team = new Dictionary<Hero, ItemList<Item>>(5);

            foreach(KeyValuePair<Hero,ItemList<Item>> team_for_clone in team)
            {
                ItemList<Item> clone_item = null;
                if (team_for_clone.Value != null)
                {
                    clone_item = new ItemList<Item>(team_for_clone.Value.create_Array());
                }
                    clone_team.Add((Hero)team_for_clone.Key.Clone(), clone_item);
                
            }
            
            return clone_team;
        }
    }
}
