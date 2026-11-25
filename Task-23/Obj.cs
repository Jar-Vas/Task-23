using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Task_23
{
    abstract internal class Obj
    {
        public Vector2 Coord { get; set; }
        public long Id { get; set; }
        public long Angle { get; set; }

        public static long ObjCount { get; set; } = 0;
        public static List<Obj> Objs { get; set; }
        public abstract void Draw();
    }
    abstract internal class Unit : Obj
    {
        public float Speed;
        public float UnitSize;

    }
    internal class Marine : Unit
    {
        public static Texture Tex { get; set; } = new Texture(new List<RectSet> { new RectSet(new Rectangle(-5, -5, 10, 10), Color.Red)
        , new RectSet(new Rectangle(-5, -5, 20, 3), Color.Magenta)});
        
        public Marine(Vector2 coord)
        {
            Coord = coord;
            Speed = 2;
            UnitSize = 20;
            Angle = 0;
            Id = Obj.ObjCount;
            Settings.area.Arr[((int)(coord.X / Settings.cellSize)), ((int)(coord.Y / Settings.cellSize))].Objs.Add(this);

            Obj.ObjCount++;
        }
        //public void Rotate(float angle) { Tex.Rotate(angle); }
        public override void Draw() { Tex.Draw(Coord, Angle); }
    }
}
