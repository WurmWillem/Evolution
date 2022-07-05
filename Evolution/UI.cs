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
        private static Textbox spawnChanceBox = new Textbox(415, 50, 75, 30);
        static public void Display()
        {
            spawnChanceBox.Update();

            Raylib.DrawText($"Spawn chance per second: {Organisms.SpawnChance}%", 10, 50, 30, Color.BLACK);

            Raylib.DrawText($"t = {Game.seconds}", 10, 100, 30, Color.BLACK);
            Raylib.DrawText($"total organisms = {Organisms.GetCount()}", 10, 150, 30, Color.BLACK);
        }
    }
}
