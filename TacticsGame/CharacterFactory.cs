using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacticsGame
{
    public static class CharacterFactory
    {
        public static Character CreateCharacter(CharacterType type)
        {

            switch (type)
            {
                case CharacterType.Knight:
                    return new Character(CharacterType.Knight, 18, 8, 0, 4, 4, 2, 1);
                case CharacterType.Archer:
                    return new Character(CharacterType.Archer, 14, 0, 8, 2, 6, 3, 2);
                case CharacterType.Mage:
                    return new Character(CharacterType.Mage, 12, 5, 4, 3, 4, 2, 4);
                default:
                    return null;
            }
        }
    }
}
