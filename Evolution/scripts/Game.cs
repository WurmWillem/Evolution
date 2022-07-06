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
        private static int frames = 0;
        public static int seconds = 0;

        public static void Start()
        {
            Organisms.Display();
            UI.Display();

            Equilibrium.Update();

            frames++;

            if (frames % 60 == 0)
            {
                seconds++;
                Organisms.Update();
            }

            
        }
    }
}
