using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Text;

namespace Task_23.HelpClass
{
    // help data-structure for Unit.Went //
    internal class prPos
    {
        public static int CountPos { get; set; } = 32;
        
        public List<float> Poss { get; set; }
        public int Index { get; set; }
        
        public prPos(List<float> poss,  int index) { Poss = poss; Index = index; }
        public prPos(prPos other) { Poss = other.Poss; Index = other.Index; }
        public prPos() { Poss = new List<float>(CountPos); for (int i = 0; i < CountPos; i++) { try { Poss[i] = -1; } catch (Exception e) { Console.WriteLine(Poss.Count + "QQQQQQQQQQQQQQQQQQQQ"); } } Index = 0; }

        // Add new data //
        public void Add(float d)
        {
            Poss[Index] = d;
            Index = (Index + 1) % CountPos;
        }

        // Spec get //
        public float Get()
        {
            float ret = 0.0f;
            int c = CountPos;
            foreach (float f in Poss)
            {
                if (f > 0)
                {
                    ret += f;
                }
                else
                {
                    c--;
                }
            }
            if (c == 0) { return 1e9f; }
            return ret / c;
        }
    }
}
