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
        public static long ObjCount { get; set; } = 0;
        public static List<Obj> Objs { get; set; }
        public abstract void Draw();
    }
    internal class Marine : Obj
    {
        public static Texture Tex { get; set; } = new Texture(new List<RectSet> { new RectSet(new Rectangle(-5, -5, 5, 5), Color.Red) });
        public Marine(Vector2 coord)
        {
            Coord = coord;
            Id = Obj.ObjCount;
            //Obj.Objs.Add(this);
            Obj.ObjCount++;
        }

        public override void Draw() { Tex.Draw(Coord); }
    }
}
