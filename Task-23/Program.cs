
using Raylib_cs;
using System.Numerics;

namespace Task_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int Height = 20;
            int Width = 30;
            int cellSize = 30;
            Area area = new Area(Height, Width);


            Raylib.InitWindow(Width * cellSize, Height * cellSize, "My first Raylib-cs");
            Raylib.SetTargetFPS(60);

            bool fMouse = false;
            Vector2 pMouse = new Vector2(0, 0);
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.Black);

                #region area
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        Raylib.DrawRectangle(j * cellSize, i * cellSize, cellSize, cellSize, Color.Blue);
                    }
                }
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        Raylib.DrawRectangleLines(j * cellSize, i * cellSize, cellSize, cellSize, Color.DarkBlue);
                    }
                }
                #endregion area

                if (Raylib.IsMouseButtonDown(MouseButton.Left))
                {
                    if (fMouse)
                    {
                        Raylib.DrawRectangle(
                            ((int)pMouse.X), ((int)pMouse.Y), ((int)(Raylib.GetMouseX() - pMouse.X)),
                            ((int)(Raylib.GetMouseY() - pMouse.Y)), new Color(0, 128, 0, 80)
                            );

                        Raylib.DrawRectangleLines(
                            ((int)pMouse.X), ((int)pMouse.Y), ((int)(Raylib.GetMouseX() - pMouse.X)),
                            ((int)(Raylib.GetMouseY() - pMouse.Y)), new Color(0, 128, 0, 100)
                            );

                    }
                    else
                    {
                        fMouse = true;
                        pMouse = Raylib.GetMousePosition();
                    }
                }
                else
                {
                    fMouse = false;
                }

                Texture t = new Texture(new List<RectSet> { new RectSet(new Rectangle(-20, -30, 20, 30), Color.Red) });
                //t.Draw(new System.Numerics.Vector2(100, 100), 1);
                //Raylib.DrawText("Hello Raylib!", 300, 100, 40, Color.White);
                //Raylib.DrawCircle(500, 400, 100, Color.Red);
                //Raylib.DrawRectangle(100, 200, 200, 100, Color.Blue);
                Marine m = new Marine(new System.Numerics.Vector2(100, 100));
                m.Draw();
                m.Rotate(1);
                Raylib.EndDrawing();
            }

            //Raylib.CloseWindow();
        }
    }
}
