using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacticsGame
{
    public class BlockedCell : Cell
    {
        public BlockedCell(Vector2 position) : base (position) {}

        public override char Symbol
        {
            get { return 'X'; }
        }

        public override object Occupant
        {
            get { return null; }
        }

        public override bool IsOccupied
        {
            get { return true; }
        }
    }
}
