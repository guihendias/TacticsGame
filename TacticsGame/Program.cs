using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacticsGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Character knight = CharacterFactory.CreateCharacter(CharacterType.Knight);
            Character archer = CharacterFactory.CreateCharacter(CharacterType.Archer);
            Character mage = CharacterFactory.CreateCharacter(CharacterType.Mage);

            Console.WriteLine(knight);
            Console.WriteLine(archer);
            Console.WriteLine(mage);

            Player player = new Player("Kleber", TeamType.Blue);
            Console.WriteLine(player);

            Console.ReadKey();
        }
    }
}
