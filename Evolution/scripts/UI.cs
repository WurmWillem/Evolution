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
        private static Textbox replicationChanceBox = new Textbox(420, 150, 75, 30);

        private static Textbox speedUpBox = new Textbox(35, 600, 90, 130);
        private static Textbox restartBox = new Textbox(175, 600, 90, 130);

        private static Textbox EquilibriumBox = new Textbox(6, 400, 450, 30);

        private static Texture2D speedUp = Raylib.LoadTexture("SpeedUp.png");
        private static Texture2D restart = Raylib.LoadTexture("Restart.png");

        public static void Display()
        {
            UpdateChanceBoxes();

            EquilibriumBox.ShowDescription("Equilibrium is the amount of organisms where the population will stabilize.", "S = spawnrate, D = deathrate, R = replicationrate");

            speedUpBox.SpeedUp();
            restartBox.Restart();

            Draw();
        }

        private static void Draw()
        {
            Raylib.DrawText($"Spawn chance/s: {Organisms.spawnChance}%", 10, 50, 30, Color.BLACK);
            Raylib.DrawText($"Death chance/org/s: {Organisms.deathChance}%", 10, 100, 30, Color.BLACK);
            Raylib.DrawText($"Replication chance/org/s: {Organisms.replicationChance}%", 10, 150, 30, Color.BLACK);

            Raylib.DrawText($"t = {Game.seconds}", 10, 250, 30, Color.BLACK);
            Raylib.DrawText($"total organisms = {Organisms.GetCount()}", 10, 300, 30, Color.BLACK);
            //Raylib.DrawText($"total mutated organisms = {Organisms.mutated}", 10, 350, 30, Color.BLACK);

            Raylib.DrawText($"Equilibrium = B / (D - R) = {Formulas.equilibrium}", 10, 400, 30, Color.BLACK);
            Raylib.DrawText($"expected Change = {Formulas.Change}", 10, 500, 30, Color.BLACK);

            Raylib.DrawTexture(speedUp, 10, 600, Color.RAYWHITE);
            Raylib.DrawTexture(restart, 150, 600, Color.RAYWHITE);
        }

        private static void UpdateChanceBoxes()
        {
            spawnChanceBox.UpdateChance(ref Organisms.spawnChance);
            deathChanceBox.UpdateChance(ref Organisms.deathChance);
            replicationChanceBox.UpdateChance(ref Organisms.replicationChance);
        }
    }
}
