using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.scripts
{
    static class UI
    {
        private static Textbox spawnChanceBox = new Textbox(275, 50, 75, 30);
        private static Textbox deathChanceBox = new Textbox(350, 100, 75, 30);
        private static Textbox mutationChanceBox = new Textbox(370, 150, 75, 30);

        private static Textbox EquilibriumBox = new Textbox(6, 450, 380, 30);

        public static void Display()
        {
            UpdateChanceBoxes();

            EquilibriumBox.ShowDescription("Equilibrium is the amount of organisms where the population will stabilize. S = spawnrate, D = deathrate.");

            //DrawAesthetic();

            DrawText();
        }

        private static void DrawText()
        {
            Raylib.DrawText($"Spawn chance/s: {Organisms.spawnChance}%", 10, 50, 30, Color.BLACK);
            Raylib.DrawText($"Death chance/org/s: {Organisms.deathChance}%", 10, 100, 30, Color.BLACK);
            Raylib.DrawText($"Mutation chance/birth: {Organisms.mutationChance}%", 10, 150, 30, Color.BLACK);

            Raylib.DrawText($"t = {Game.seconds}", 10, 250, 30, Color.BLACK);
            Raylib.DrawText($"total organisms = {Organisms.GetCount()}", 10, 300, 30, Color.BLACK);
            Raylib.DrawText($"total mutated organisms = {Organisms.mutated}", 10, 350, 30, Color.BLACK);

            Raylib.DrawText($"Equilibrium = S / D = {Equilibrium.equilibrium}", 10, 450, 30, Color.BLACK);
            
        }

        private static void UpdateChanceBoxes()
        {
            spawnChanceBox.UpdateChance(ref Organisms.spawnChance);
            deathChanceBox.UpdateChance(ref Organisms.deathChance);
            mutationChanceBox.UpdateChance(ref Organisms.mutationChance);
        }

        private static void DrawAesthetic()
        {
            Raylib.DrawRectangle(6, 50, 25, 30, Color.BLUE);
            Raylib.DrawRectangle(6, 100, 25, 30, Color.BLUE);
            Raylib.DrawRectangle(6, 150, 25, 30, Color.BLUE);
        }
    }
}
