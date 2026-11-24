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
        public Vector2Int(Vector2Int other) { X = other.X; Y = other.Y;  }
        public Vector2Int() { X = 0; Y = 0; }
        public static Vector2Int operator +(Vector2Int a, Vector2Int b) { return new Vector2Int(a.X + b.X, a.Y + b.Y); }
        public static Vector2Int operator -(Vector2Int a, Vector2Int b) { return new Vector2Int(a.X - b.X, a.Y - b.Y); }
    }
    internal class Vector2d
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Vector2d(double x, double y) { X = x; Y = y; }
        public Vector2d(Vector2Int other) { X = other.X; Y = other.Y; }
        public Vector2d() { X = 0.0; Y = 0.0; }
        public static Vector2d operator +(Vector2d a, Vector2d b) { return new Vector2d(a.X + b.X, a.Y + b.Y); }
        public static Vector2d operator -(Vector2d a, Vector2d b) { return new Vector2d(a.X - b.X, a.Y - b.Y); }
    }
}
