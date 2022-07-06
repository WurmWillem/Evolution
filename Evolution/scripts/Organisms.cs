using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.scripts
{
    static class Organisms
    {
        private static List<Organism> organisms = new List<Organism>();

        public static int spawnChance = 10;
        public static int deathChance = 5;
        public static int replicationChance = 4;

        public static void Display()
        {
            foreach (Organism org in organisms)
            {
                Raylib.DrawRectangle(org.x * 20, org.y * 20, 30, 30, Color.RED);
            }
        }
        public static void Update()
        {
            for (int i = 0; i < organisms.Count; i++)
            {
                if (Raylib.GetRandomValue(1, 101) <= deathChance)
                {
                    organisms.RemoveAt(i);
                }

                if (Raylib.GetRandomValue(1, 101) <= replicationChance)
                {
                    Add();
                }
            }

            if (Raylib.GetRandomValue(1, 101) <= spawnChance)
            {
                Add();
            }
        }

        public static void Reset()
        {
            organisms = new List<Organism>();
        }

        public static void Add()
        {
            Organism org = new Organism();
            organisms.Add(org);
        }

        public static int GetCount()
        {
            return organisms.Count;
        }
    }
}
