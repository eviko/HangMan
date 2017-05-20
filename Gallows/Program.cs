using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Player player2 = new Player();
            Console.WriteLine("Give the name of player1");
            player1.name = Console.ReadLine();
            Console.WriteLine("Give the name of player2");
            player2.name = Console.ReadLine();
            int firstPlayer = 0;

            do
            {
                Console.WriteLine("Who plays first.For player 1 press 1,for player 2 press 2");
                while (!int.TryParse(Console.ReadLine(), out firstPlayer))
                {
                    Console.WriteLine("Please give a number");
                }
            } while (firstPlayer != 1 && firstPlayer != 2);
            if (firstPlayer == 1)
            {
                Console.WriteLine($"{player2.name} give the word");
                player2.givenWord = Console.ReadLine().ToUpper();
                Console.Clear();
                player2.DisplayTheWordToFind();
                player2.ChecktheLetter();
            }
            else
            {
                Console.WriteLine($"{player1.name} give the word");
                player1.givenWord = Console.ReadLine();
            }
        }
    }
}
