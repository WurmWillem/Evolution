using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution
{
    static class UI
    {
        private static Textbox spawnChanceBox = new Textbox(415, 50, 75, 35);
        private static Textbox mutationChanceBox = new Textbox(475, 100, 75, 35);
        static public void Display()
        {
            spawnChanceBox.Update(ref Organisms.spawnChance);
            mutationChanceBox.Update(ref Organisms.mutationChance);

            Raylib.DrawText($"Spawn chance per second: {Organisms.spawnChance}%", 10, 50, 30, Color.BLACK);
            Raylib.DrawText($"Mutation chance per organism: {Organisms.mutationChance}%", 10, 100, 30, Color.BLACK);

            Raylib.DrawText($"t = {Game.seconds}", 10, 150, 30, Color.BLACK);
            Raylib.DrawText($"total organisms = {Organisms.GetCount()}", 10, 200, 30, Color.BLACK);
            Raylib.DrawText($"total mutated organisms = {Organisms.mutated}", 10, 250, 30, Color.BLACK);
        }
    }
}
