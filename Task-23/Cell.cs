using System;
using System.Collections.Generic;
using System.Text;

namespace Task_23
{
    internal class Cell
    {
        public Vector2Int Coord {  get; set; }
        public int zFactor { get; set; } // ground high: 0 - lg, 1 - ng, 2 - hg
        public List<Obj> Objs { get; set; }
        public Cell(Vector2Int coord, int zfactor, List<Obj> objs) { Coord = coord; zFactor = zfactor; Objs = objs; }
        public Cell(Vector2Int coord, int zfactor) { Coord = coord; zFactor = zfactor; Objs = new List<Obj>(); }
        public Cell(Vector2Int coord) { Coord = coord; zFactor = 0; Objs = new List<Obj>(); }
        public Cell() { Coord = new Vector2Int(); zFactor = 0; Objs = new List<Obj>(); }
        public Cell(Cell other) { Coord = other.Coord; zFactor = other.zFactor; Objs = other.Objs; }
    }
}
