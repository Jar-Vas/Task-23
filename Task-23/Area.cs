using System;
using System.Collections.Generic;
using System.Text;

namespace Task_23
{
    internal class Area
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Cell[,] Arr {  get; set; }
        public Area (int Height,  int Width) { Arr = new Cell[Width, Height]; }
    }
}
