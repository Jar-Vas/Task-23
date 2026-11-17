
using Raylib_cs;

namespace Task_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int Height = 80;
            int Width = 130;
            int cellSize = 10;
            Area area = new Area(Height, Width);


            Raylib.InitWindow(Width * cellSize, Height * cellSize, "My first Raylib-cs");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.Black);
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
                //Raylib.DrawText("Hello Raylib!", 300, 100, 40, Color.White);
                //Raylib.DrawCircle(500, 400, 100, Color.Red);
                //Raylib.DrawRectangle(100, 200, 200, 100, Color.Blue);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
