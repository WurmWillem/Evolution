using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.scripts
{
    class Organism
    {
        public int x;
        public int y;

        public Organism()
        {
            x = Raylib.GetRandomValue(1, 61);
            y = Raylib.GetRandomValue(1, 41);

        }
    }
}
