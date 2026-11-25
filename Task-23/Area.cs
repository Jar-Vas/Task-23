using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Numerics;
using System.Text;

namespace Task_23
{
    internal class Area
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Cell[,] Arr {  get; set; }
        public Area (int Height, int Width) 
        { 
            Arr = new Cell[Width, Height];
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Arr[x, y] = new Cell();
                }
            }
        }

        public List<Unit> GetAllUnitAt(Vector2 start, Vector2 end)
        {
            List<Unit> units = new List<Unit>();

            float left = Math.Min(start.X, end.X);
            float right = Math.Max(start.X, end.X);
            float top = Math.Min(start.Y, end.Y);
            float bottom = Math.Max(start.Y, end.Y);

            int minX = Math.Clamp((int)Math.Floor(left / Settings.cellSize), 0, Arr.GetLength(0) - 1);
            int maxX = Math.Clamp((int)Math.Floor(right / Settings.cellSize), 0, Arr.GetLength(0) - 1);
            int minY = Math.Clamp((int)Math.Floor(top / Settings.cellSize), 0, Arr.GetLength(1) - 1);
            int maxY = Math.Clamp((int)Math.Floor(bottom / Settings.cellSize), 0, Arr.GetLength(1) - 1);

            for (int x = minX; x <= maxX; x++)
            {
                for (int y = minY; y <= maxY; y++)
                {
                    foreach (Obj obj in Arr[x, y].Objs)
                    {
                        if (obj is Unit unit &&
                            unit.Coord.X >= left && unit.Coord.X <= right &&
                            unit.Coord.Y >= top && unit.Coord.Y <= bottom)
                        {
                            units.Add(unit);
                        }
                    }
                }
            }

            return units;
        }


    }
}
