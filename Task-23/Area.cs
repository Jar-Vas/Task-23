using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;
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

            foreach (Obj obj in Obj.Objs)
            {
                if (obj is Unit unit &&
                    unit.Coord.X >= left && unit.Coord.X <= right &&
                    unit.Coord.Y >= top && unit.Coord.Y <= bottom)
                {
                    units.Add(unit);
                }
            }

            return units;
        }


    }
}
