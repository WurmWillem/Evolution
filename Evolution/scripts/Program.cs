using System;
using Raylib_cs;

namespace Evolution.scripts
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1200, 800, "Evolution");

            Raylib.SetTargetFPS(60);

            Game.Setup();

            // Main game loop
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                    Game.Start();
                
                Raylib.DrawFPS(10, 10);
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
