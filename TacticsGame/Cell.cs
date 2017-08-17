using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacticsGame
{
    public class Cell
    {
        private List<Character> occupants = null;

        public Vector2 Position { get; private set; }

        public Cell(Vector2 position)
        {
            Position = position;
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

        public bool IsOccupied
        {
            get { return occupants.Count > 0; }
        }

        public Character Occupant
        {
            get { return IsOccupied ? occupants[0] : null; }
        }
    }
}
