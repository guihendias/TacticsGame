using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacticsGame
{
    public abstract class Cell
    {

        public Vector2 Position { get; protected set; }

        public Cell(Vector2 position)
        {
            Position = position;
        }

        public abstract char Symbol { get; }

        public abstract Object Occupant { get; }

        public abstract bool IsOccupied { get; }

    }
}
