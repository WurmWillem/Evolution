using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.scripts
{
    static class Equilibrium
    {
        public static float equilibrium = Organisms.spawnChance / Organisms.deathChance;

        public static void Update()
        {
            equilibrium = Organisms.spawnChance / Organisms.deathChance;
        }
    }
}
