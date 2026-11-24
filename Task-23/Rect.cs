using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Raylib_cs;

namespace Task_23
{
    //  //
    internal class RectSet
    {
        public Raylib_cs.Rectangle Rect { get; set; }
        public Vector2 Origin { get; set; }
        public float Rotation { get; set; }
        public Color RColor { get; set; }
        public bool Full { get; set; }
        public RectSet(Raylib_cs.Rectangle rect, Vector2 origin, float rotation, Color rColor, bool full = true) { Rect = rect; Origin = origin; Rotation = rotation; RColor = rColor; Full = full; }
        public RectSet(Raylib_cs.Rectangle rect, float rotation, Color rColor, bool full = true) { Rect = rect; Origin = new Vector2(0, 0); Rotation = rotation; RColor = rColor; Full = full; }
        public RectSet(Raylib_cs.Rectangle rect, Color rColor, bool full = true) { Rect = rect; Origin = new Vector2(0, 0); Rotation = 0.0f; RColor = rColor; Full = full; }
        public RectSet() { Rect = new Rectangle(); Origin = new Vector2(0, 0); Rotation = 0.0f; RColor = new Color(); Full = true; }
        public RectSet(RectSet other) {  Rect = other.Rect; Origin = other.Origin; Rotation = other.Rotation; RColor = other.RColor; Full = other.Full; }
    }
}
