﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rule_engine.Model;

namespace Rule_engine
{
    class Program
    {
        static void Main(string[] args)
        {
            Races races = new Races();

            var race1 = races.FirstRace();
            Rules.CalculateRank(race1);
            Rules.CalculatePoints(race1);
            var race2 = races.SecondRace();
            Rules.CalculateRank(race2);
            Rules.CalculatePoints(race2);
            Console.WriteLine();
            PrintRaceTable(race1);
            PrintRaceTable(race2);
            Console.ReadKey();
        }

        static void PrintRaceTable(List<Team> teams)
        {
            foreach(var f in teams.OrderBy(i => i.Position))
            {
                Console.WriteLine(f.Name + " position: " + f.Position + ", " +   "points: " +  f.Points);
            }
            Console.WriteLine();
        }
    }
}
