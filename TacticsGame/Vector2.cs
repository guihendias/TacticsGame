using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacticsGame
{
    public class Vector2
    {

        public int Row { get; set; }
        public int Column { get; set; }

        public Vector2(int row = 0, int column = 0)
        {
            Row = row;
            Column = column;
        }
    }
}
