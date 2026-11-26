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
        public float UnitSize;

        public static long ObjCount { get; set; } = 0;
        public static List<Obj> Objs { get; set; } = new List<Obj>();
        public abstract void Draw();
    }
    abstract internal class Unit : Obj
    {
        public float Speed;
        public float Angle { get; set; }
        public (bool, Vector2, HelpClass.prPos) Went { get; set; } // (IsWalk, PointToWalk, (prPos, currentIndex)) 

        public abstract void Move(Vector2 to);
        public abstract void Tick();

        public static List<Unit> Units { get; set; } = new List<Unit>();
    }
    internal class Marine : Unit
    {
        public static Texture Tex { get; set; } = new Texture(new List<RectSet> { new RectSet(new Rectangle(-5, -5, 10, 10), Color.Red)
        , new RectSet(new Rectangle(-5, -5, 20, 3), Color.Magenta)});
        public Marine(Vector2 coord)
        {
            Coord = coord;
            Speed = 5;
            UnitSize = 20;
            Angle = 0;
            Went = (false, new Vector2(0, 0), new HelpClass.prPos());
            Id = Obj.ObjCount;
            Settings.area.Arr[((int)(coord.X / Settings.cellSize)), ((int)(coord.Y / Settings.cellSize))].Objs.Add(this);
            Obj.Objs.Add(this);
            Unit.Units.Add(this);

            Obj.ObjCount++;
        }

        public override void Draw() { Tex.Draw(Coord, Angle); }

        public override void Move(Vector2 to)
        {
            Went = (true, to, new HelpClass.prPos());
        }
        public override void Tick()
        {
            for (int i = 0; i < Obj.Objs.Count; i++)
            {
                if (Obj.Objs[i].Id == Id) { continue; }
                float d = HelpFunc.Dist(Obj.Objs[i].Coord, Coord);
                if (d < UnitSize + Obj.Objs[i].UnitSize)
                {
                    Vector2 Vel = -Settings.repulsiveForce * MathF.Sqrt(UnitSize + Obj.Objs[i].UnitSize - d) * (Obj.Objs[i].Coord - Coord) / d;
                    Coord += Settings.dt * Vel;
                    Obj.Objs[i].Coord -= Settings.dt * Vel;
                }
            }
            if (Went.Item1)
            {
                float d = HelpFunc.Dist(Coord, Went.Item2);
                
                if (d < Math.Max(UnitSize/3, 1) || Went.Item3.Get() < Speed/2)
                {
                    Went = (false, new Vector2(0, 0), new HelpClass.prPos());
                    return;
                }
                Vector2 Vel = Speed * (Went.Item2 - Coord) / d;
                Coord += Settings.dt * Vel;
                Went.Item3.Add(d);
            }
        }
    }
}
