using System;
using System.Collections.Generic;

namespace HW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Team dota_team = new Team();

           
            Bristleback bristleback = new Bristleback();
            Io io = new Io();
            Medusa medusa = new Medusa();
            Dazzle dazzle = new Dazzle();
            Storm_Spirit storm_spirit = new Storm_Spirit();

            bristleback.GetItems();
            io.GetItems();
            medusa.GetItems();
            dazzle.GetItems();
            storm_spirit.GetItems();
            

            dota_team.createTeam(bristleback, io, dazzle, medusa, storm_spirit);


            int id = 1;
            Console.WriteLine("----------------------------TEAM----------------------------");
            foreach (KeyValuePair<Hero,ItemList<Item>> valuePair in dota_team.team)
            {
                
                Console.WriteLine(id++ +". "+ valuePair.Key);
                if (valuePair.Value != null )
                {
                    for (int i = 0; i < valuePair.Value.Count; i++)
                    {
                        Console.WriteLine("  [" + valuePair.Value[i] + " ]");
                    }
                }
                else
                {
                    Console.WriteLine("  [null]");
                }
            }

            Console.WriteLine();
            Dictionary<Hero, ItemList<Item>> clone = (Dictionary<Hero, ItemList<Item>>)dota_team.Clone();
         
            id = 1;
            Console.WriteLine("----------------------------CLONE---------------------------");
            foreach (KeyValuePair<Hero, ItemList<Item>> valuePair in clone)
            {
                
                Console.WriteLine(id++ + ". " + valuePair.Key);

                if (valuePair.Value != null)
                {
                    for (int i = 0; i < valuePair.Value.Count; i++)
                    {
                        Console.WriteLine("  [" + valuePair.Value[i] + " ]");
                    }
                }
                else
                {
                    Console.WriteLine("  [null]");
                }
            }

            Console.ReadKey();
        }
    }
}
