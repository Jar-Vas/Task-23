using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Task_23
{
    internal class Texture
    {
        // DANGER !! If you use rotate functions use default Origin //
        public List<RectSet> Tex { get; set; }
        public Texture(List<RectSet> texture) { Tex = texture; }
        public Texture() { Tex = new List<RectSet>(); }
        public Texture(Texture other) { Tex = other.Tex; }

        public void Rotate(float angle)
        {
            for (int i = 0; i < Tex.Count; i++)
            {
                Tex[i].Rotation += angle;
            }
        }

        public void Draw(Vector2 coord, float scale = 1.0f)
        {
            for (int i = 0; i < Tex.Count; i++)
            {
                Rectangle temp = new Rectangle(Tex[i].Rect.Position * scale + coord, Tex[i].Rect.Size * scale);
                if (Tex[i].Full) { Raylib.DrawRectanglePro(temp, Tex[i].Origin, Tex[i].Rotation, Tex[i].RColor); }
            }
        }
    }
}
