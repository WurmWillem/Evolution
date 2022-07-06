using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.scripts
{
    static class Formulas
    {
        public static float equilibrium = Organisms.spawnChance / (Organisms.replicationChance - Organisms.deathChance);
        public static float Change = Organisms.spawnChance + (Organisms.replicationChance - Organisms.deathChance) * Organisms.GetCount();
        public static void Update()
        {
            equilibrium = Organisms.spawnChance / (Organisms.deathChance - Organisms.replicationChance);

            Change = Organisms.spawnChance + (Organisms.replicationChance - Organisms.deathChance) * Organisms.GetCount();

            //Console.WriteLine($"{Organisms.spawnChance} / {Organisms.replicationChance} - {Organisms.deathChance} = {equilibrium}");
        }
    }
}
