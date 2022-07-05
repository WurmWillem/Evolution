using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution
{
    class Organism
    {
        private Random rnd = new Random();
        public int x;
        public int y;

        public Organism(int X, int Y)
        {
            x = X;
            y = Y;
        }
       
    }
}
