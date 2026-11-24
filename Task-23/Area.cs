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
            List<Unit> Units = new List<Unit>();
            Vector2Int _start, _end;
            (_start, _end) = HelpFunc.Normalize(start, end);
            for (int x = _start.X; x < _end.X; x++)
            {
                for (int y = _start.Y; y < _end.Y; y++)
                {
                    foreach(Obj i in (Arr[y, x].Objs))
                    {
                        if (i is Unit unit)
                        {
                            Units.Add(unit);
                        }
                    }
                }
            }
            return Units;
        }


    }
}
