using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.scripts
{
    class Textbox
    {
        private bool clicked = false;
        private float x, y;

        private Rectangle rect;

        public Textbox(float X, float Y, float Width, float Height) 
        {
            x = X;
            y = Y;

            rect = new Rectangle(X, Y, Width, Height);
        }

        public void SpeedUp()
        {
            //Raylib.DrawRectangleRec(rect, Color.RED);
            if (IsClicked(rect))
            {
                Game.frames = 0;
                if (Game.frameMultiplier == 3)
                {
                    Game.frameMultiplier = 1;
                }
                else
                {
                    Game.frameMultiplier = 3;
                }
            }
        }

        public void UpdateChance(ref int chance)
        {
            Raylib.DrawRectangleRec(rect, Color.LIGHTGRAY);
            
            if (IsClicked(rect))
            {
                clicked = true;
                chance = 1;
            }
            else if (Raylib.IsMouseButtonPressed(0)) clicked = false;

            if (clicked && Raylib.GetCharPressed() != 0)
            {
                int key = GetTypedKey();

                chance = GetSpawnChance(chance, key);
            }
        }

        public void Restart()
        {
            //Raylib.DrawRectangleRec(rect, Color.RED);
            if (IsClicked(rect))
            {
                Game.Restart();
            }
        }

        public void ShowDescription(string descr1, string descr2 = "")
        {
            Raylib.DrawRectangleRec(rect, Color.LIGHTGRAY);
            if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), rect)) 
            {
                Raylib.DrawText(descr1, 10, (int) y + 50, 20, Color.BLACK);
                Raylib.DrawText(descr2, 10, (int)y + 70, 20, Color.BLACK);
            }
        }

        private bool IsClicked(Rectangle rect)
        {
            if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), rect) && Raylib.IsMouseButtonPressed(0))
            {
                return true;
            }
            return false;
        }

        private int GetTypedKey()
        {
            int num;
            string key = ((char)Raylib.GetKeyPressed()).ToString();

            if (Int32.TryParse(key, out num))
            {
                num = Int32.Parse(key);
            }
            return num;
        }
        private int GetSpawnChance(int spawnChance, int key)
        {
            if (spawnChance == 1 && key != 0)
            {
                return key;
            }
            else if (spawnChance * 10 + key <= 100)
            {
                return spawnChance * 10 + key;
            }
            return 1;
        }
    }   
}
