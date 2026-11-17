using System;
using System.Collections.Generic;
using System.Text;

namespace Task_23
{
    internal class Vector2Int
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Vector2Int(int x, int y) { X = x; Y = y; }
        public Vector2Int() { X = 0; Y = 0; }
        public static Vector2Int operator +(Vector2Int a, Vector2Int b) { return new Vector2Int(a.X + b.X, a.Y + b.Y); }
        public static Vector2Int operator -(Vector2Int a, Vector2Int b) { return new Vector2Int(a.X - b.X, a.Y - b.Y); }
    }
}
