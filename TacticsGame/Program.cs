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

            Player player = new Player("Kleber", TeamType.Blue);
            Player player2 = new Player("Ligia", TeamType.Red);

            Board board = new Board(10, 10);
            Console.WriteLine(board);

            if (board[2, 2] is PassableCell)
            {
                ((PassableCell)board[2, 2]).Occupy(player.Characters[0]);
            }

            Console.ReadKey();
        }
    }
}
