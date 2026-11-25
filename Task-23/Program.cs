
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
            Marine m1 = new Marine(new System.Numerics.Vector2(100, 150));
            Marine m2 = new Marine(new System.Numerics.Vector2(100, 200));

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    m2 = new Marine(new System.Numerics.Vector2(200 + 1 * i, 250 + 1 * j));
                }
            }

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                for (int i = 0; i < Unit.Units.Count; i++)
                {
                    Unit.Units[i].Tick();
                }
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

                if (Raylib.IsMouseButtonDown(MouseButton.Left))
                {
                    if (fMouse)
                    {
                        Vector2 start, end;
                        (start, end) = HelpFunc.Formating(pMouse, Raylib.GetMousePosition());
                        Raylib.DrawRectangle(
                            ((int)start.X), ((int)start.Y), ((int)(end.X - start.X)),
                            ((int)(end.Y - start.Y)), new Color(0, 128, 0, 80)
                            );

                        Raylib.DrawRectangleLines(
                            ((int)start.X), ((int)start.Y), ((int)(end.X - start.X)),
                            ((int)(end.Y - start.Y)), new Color(0, 128, 0, 100)
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
                    if (fMouse)
                    {
                        selected = Settings.area.GetAllUnitAt(pMouse, Raylib.GetMousePosition());
                        Console.WriteLine("Count: " + selected.Count);
                    }
                    fMouse = false;
                    //selected = Settings.area.GetAllUnitAt(pMouse, Raylib.GetMousePosition());
                    //Console.WriteLine("Count: " + selected.Count);
                }

                if (Raylib.IsMouseButtonDown(MouseButton.Right))
                {
                    for (int i = 0; i < selected.Count; i++) 
                    {
                        selected[i].Move(Raylib.GetMousePosition());
                    }
                }

                Raylib.ClearBackground(Color.Black);


                foreach (Unit u in selected)
                {
                    Raylib.DrawCircle(((int)u.Coord.X), ((int)u.Coord.Y), u.UnitSize, new Color(0, 100, 0, 40));
                    Raylib.DrawCircleLines(((int)u.Coord.X), ((int)u.Coord.Y), u.UnitSize, new Color(0, 0, 0, 40));
                }

                Texture t = new Texture(new List<RectSet> { new RectSet(new Rectangle(-20, -30, 20, 30), Color.Red) });
                //t.Draw(new System.Numerics.Vector2(100, 100), 1);
                //Raylib.DrawText("Hello Raylib!", 300, 100, 40, Color.White);
                //Raylib.DrawCircle(500, 400, 100, Color.Red);
                //Raylib.DrawRectangle(100, 200, 200, 100, Color.Blue);
                for (int i = 0; i < Unit.Units.Count; i++)
                {
                    Unit.Units[i].Draw();
                }
                m.Angle++;


                
                Raylib.EndDrawing();
            }

            //Raylib.CloseWindow();
        }
    }
}
