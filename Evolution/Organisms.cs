using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution
{
    static class Organisms
    {
        private static List<Organism> organisms = new List<Organism>();

        public static int spawnChance = 50;
        public static int deathChance = 50;
        public static int mutationChance = 10;


        public static int mutated = 0;

        public static void Display()
        {
            foreach (Organism org in organisms)
            {
                Raylib.DrawRectangle(org.x * 20, org.y * 20, 30, 30, org.color);

            }
        }
        public static void Update()
        {
            if (Raylib.GetRandomValue(1, 101) <= spawnChance)
            {
                Add();
            }
        }

        private static void Add()
        {
            bool mutation = false;

            if (Raylib.GetRandomValue(1, 101) <= mutationChance)
            {
                mutation = true;
                mutated++;
            }

            Organism org = new Organism(mutation);
            organisms.Add(org);
        }

        public static int GetCount()
        {
            return organisms.Count;
        }
        
    }
}
