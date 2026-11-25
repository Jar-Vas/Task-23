using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace Task_23
{
    static internal class HelpFunc
    {
        public static (Vector2, Vector2) Formating(Vector2 start, Vector2 end)
        {
            return (
                new Vector2(Math.Min(start.X, end.X), Math.Min(start.Y, end.Y)),
                new Vector2(Math.Max(start.X, end.X), Math.Max(start.Y, end.Y))
            );
        }
        public static (Vector2Int, Vector2Int) Normalize(Vector2 start, Vector2 end) {
            (start, end) = Formating(start, end);
            return (
                new Vector2Int(
                    (int)((start.X + Settings.cellSize / 2) / Settings.cellSize) - 1, 
                    (int)((start.Y + Settings.cellSize / 2) / Settings.cellSize) - 1),
                new Vector2Int(
                    (int)((end.X + 3 * Settings.cellSize / 2) / Settings.cellSize), 
                    (int)((end.Y + 3 * Settings.cellSize / 2) / Settings.cellSize))
                );
        }

        public static float Dist(Vector2 v1, Vector2 v2)
        {
            float dx, dy;
            dx = v1.X - v2.X;
            dy = v1.Y - v2.Y;
            return MathF.Sqrt(dx * dx + dy * dy);
        }


    }
}
