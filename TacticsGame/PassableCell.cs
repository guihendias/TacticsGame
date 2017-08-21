using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacticsGame
{
    public class PassableCell : Cell
    {
        private List<Character> occupants = null;

        public PassableCell(Vector2 position)
            : base(position)
        {
            occupants = new List<Character>();
        }

        public void Occupy(Character character)
        {
            if (IsOccupied) return;
            occupants.Add(character);
        }

        public void Leave()
        {
            occupants.RemoveAt(0);
        }

        public override bool IsOccupied
        {
            get { return occupants.Count > 0; }
        }

        public override Object Occupant
        {
            get { return IsOccupied ? occupants[0] : null; }
        }

        public override char Symbol
        {
            get { return IsOccupied ? occupants[0].Type.ToString()[0] : '.'; }
        }
    }
}
