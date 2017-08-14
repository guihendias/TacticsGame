using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacticsGame
{
    public class Player
    {
        public string Name { get; set; }

        public TeamType Type { get; set; }

        public List<Character> Characters;

        public Player(string name, TeamType type)
        {
            Name = name;
            Type = type;

            Characters = new List<Character>();
            Characters.Add(CharacterFactory.CreateCharacter(CharacterType.Archer));
            Characters.Add(CharacterFactory.CreateCharacter(CharacterType.Knight));
            Characters.Add(CharacterFactory.CreateCharacter(CharacterType.Mage));
        }

        public override string ToString()
        {
            StringBuilder sBuilder = new StringBuilder();
            sBuilder.Append(Name).Append("(").Append(Type).Append(")\n");

            foreach (Character character in Characters)
            {
                sBuilder.Append(character.ToString());
            }

            return sBuilder.ToString();
        }
    }
}
