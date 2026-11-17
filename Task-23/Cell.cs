using System;
using System.Collections.Generic;
using System.Text;

namespace Task_23
{
    internal class Cell
    {
        public Vector2Int Coord {  get; set; }
        public int zFactor { get; set; } // ground high: 0 - lg, 1 - ng, 2 - hg
        List<Obj> Objs { get; set; }

    }
}
