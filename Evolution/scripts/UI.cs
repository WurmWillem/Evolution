using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Evolution.scripts
{
    static class UI
    {
        private static Textbox spawnChanceBox = new Textbox(275, 50, 75, 30);
        private static Textbox deathChanceBox = new Textbox(350, 100, 75, 30);
        private static Textbox mutationChanceBox = new Textbox(370, 150, 75, 30);

        private static Textbox speedUpBox = new Textbox(35, 550, 90, 130);

        private static Textbox EquilibriumBox = new Textbox(6, 450, 380, 30);

        private static Texture2D speedUp = Raylib.LoadTexture("SpeedUp.png");

        public static void Display()
        {
            UpdateChanceBoxes();

            EquilibriumBox.ShowDescription("Equilibrium is the amount of organisms where the population will stabilize. S = spawnrate, D = deathrate.");

            speedUpBox.UpdateClicked();

            Draw();
        }

        private static void Draw()
        {
            Raylib.DrawText($"Spawn chance/s: {Organisms.spawnChance}%", 10, 50, 30, Color.BLACK);
            Raylib.DrawText($"Death chance/org/s: {Organisms.deathChance}%", 10, 100, 30, Color.BLACK);
            Raylib.DrawText($"Mutation chance/birth: {Organisms.mutationChance}%", 10, 150, 30, Color.BLACK);

            Raylib.DrawText($"t = {Game.seconds}", 10, 250, 30, Color.BLACK);
            Raylib.DrawText($"total organisms = {Organisms.GetCount()}", 10, 300, 30, Color.BLACK);
            Raylib.DrawText($"total mutated organisms = {Organisms.mutated}", 10, 350, 30, Color.BLACK);

            Raylib.DrawText($"Equilibrium = S / D = {Equilibrium.equilibrium}", 10, 450, 30, Color.BLACK);

            Raylib.DrawTexture(speedUp, 10, 550, Color.RAYWHITE);
        }

        private static void UpdateChanceBoxes()
        {
            spawnChanceBox.UpdateChance(ref Organisms.spawnChance);
            deathChanceBox.UpdateChance(ref Organisms.deathChance);
            mutationChanceBox.UpdateChance(ref Organisms.mutationChance);
        }
    }
}
