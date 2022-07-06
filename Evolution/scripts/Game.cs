using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.scripts
{
    static class Game
    {
        public static int frames = 0;
        public static int frameMultiplier = 1;

        public static int seconds = 0;

        private static int organisms = 10;

        public static void Start()
        {
            Organisms.Display();
            UI.Display();

            Formulas.Update();

            frames += 1 * frameMultiplier;

            if (frames % 60 == 0)
            {
                seconds++;
                Organisms.Update();
            }
        }

        public static void Setup()
        {
            for (int i = 0; i < organisms; i++)
            {
                Organisms.Add();
            }
        }

        public static void Restart()
        {
            Organisms.Reset();
            Setup();

            seconds = 0;
            frames = 0;
            frameMultiplier = 1;
        }
    }
}
