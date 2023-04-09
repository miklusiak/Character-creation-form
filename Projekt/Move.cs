using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class Move
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Move ()
        {
            X = 1;
            Y = 1;
        }
        public Move (int x, int y)
        {
            X = x;
            Y = y;
        }
        public void WriteMove()
        {
            System.Diagnostics.Debug.WriteLine($"X:{X} Y:{Y}");
        }
    }
}
