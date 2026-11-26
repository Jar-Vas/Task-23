using System;
using System.Collections.Generic;
using System.Text;

namespace Task_23
{
    internal class Settings
    {
        public static int Height = 10;
        public static int Width = 15;
        public static int cellSize = 40;
        public static Area area = new Area(Height, Width);
        public static float dt = 1f;
        public static float repulsiveForce = 1f;
    }
}
