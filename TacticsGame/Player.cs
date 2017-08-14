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


        public Player(string name, TeamType type, List<Character> characters)
        {
            Name = name;
            Type = type;

            Characters = characters;
        }

        public Player(string name, TeamType type, int characterNumbers)
        {
            Name = name;
            Type = type;
            Characters = new List<Character>();

            Random random = new Random();
            int maxCharacters = Enum.GetNames(typeof(CharacterType)).Length;

            for (int i = 0; i < characterNumbers; i++)
            {
                int index = random.Next(maxCharacters);
                Characters.Add(CharacterFactory.CreateCharacter((CharacterType)index));
            }
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
