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

        public static int SpawnChance = 50;

        public static void Display()
        {
            foreach (Organism org in organisms)
            {
                Raylib.DrawRectangle(org.x * 20, org.y * 20, 30, 30, Color.RED);

            }
        }
        public static void Update()
        {
            int rndNum = Raylib.GetRandomValue(1, 101);

            if (rndNum <= SpawnChance)
            {
                Add();
            }
        }

        private static void Add()
        {
            Organism org = new Organism(Raylib.GetRandomValue(1, 61), Raylib.GetRandomValue(1, 41));
            organisms.Add(org);
        }

        public static int GetCount()
        {
            return organisms.Count;
        }
        
    }
}
