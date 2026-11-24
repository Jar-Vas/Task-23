
using Raylib_cs;
using System.Numerics;

namespace Task_23
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Raylib.InitWindow(Settings.Width * Settings.cellSize, Settings.Height * Settings.cellSize, "My first Raylib-cs");
            Raylib.SetTargetFPS(60);

            bool fMouse = false;
            Vector2 pMouse = new Vector2(0, 0);
            List<Unit> selected = new List<Unit>();
            Marine m = new Marine(new System.Numerics.Vector2(100, 100));

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.Black);

                #region area
                for (int i = 0; i < Settings.Height; i++)
                {
                    for (int j = 0; j < Settings.Width; j++)
                    {
                        Raylib.DrawRectangle(j * Settings.cellSize, i * Settings.cellSize, Settings.cellSize, Settings.cellSize, Color.Blue);
                    }
                }
                for (int i = 0; i < Settings.Height; i++)
                {
                    for (int j = 0; j < Settings.Width; j++)
                    {
                        Raylib.DrawRectangleLines(j * Settings.cellSize, i * Settings.cellSize, Settings.cellSize, Settings.cellSize, Color.DarkBlue);
                    }
                }
                #endregion area
                Texture t = new Texture(new List<RectSet> { new RectSet(new Rectangle(-20, -30, 20, 30), Color.Red) });
                //t.Draw(new System.Numerics.Vector2(100, 100), 1);
                //Raylib.DrawText("Hello Raylib!", 300, 100, 40, Color.White);
                //Raylib.DrawCircle(500, 400, 100, Color.Red);
                //Raylib.DrawRectangle(100, 200, 200, 100, Color.Blue);
                m.Draw();
                m.Rotate(1);

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
                    //selected = Settings.area.GetAllUnitAt(pMouse, Raylib.GetMousePosition());
                    //Console.WriteLine("Count: " + selected.Count);
                }

                
                Raylib.EndDrawing();
            }

            //Raylib.CloseWindow();
        }
    }
}
