using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows
{
    class Player
    {
        public string name { get; set; }
        public string givenWord = "";
        public char givenChar { get; set; }
        List<string> wordToFind = new List<string>();
        List<string> LettersTried = new List<string>();
        int playerLives = 5;
        int remainingLetters = 0;
        public void DisplayTheWordToFind()
        {
            for (int i = 0; i < givenWord.Length; i++)
            {
                if (i == 0 || i == givenWord.Length - 1)
                    wordToFind.Add(givenWord[i].ToString());
                else
                    wordToFind.Add("-");
            }
            foreach (string s in wordToFind)
                Console.Write(s);
        }
        /// <summary>
        /// Checks if the letter exists in givenword.If doesn't the life is reduced
        /// </summary>
        public void ChecktheLetter()
        {
            int countLetter = 0;
            int count = 0;

            while (givenWord.Length != 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Give a letter");
                string letter = Console.ReadLine().ToUpper();
                givenChar = Convert.ToChar(letter);

                if (givenWord.Contains(letter))
                    for (int i = 0; i < givenWord.Length; i++)
                    {
                        if (givenWord[i] == givenChar)
                        {
                            wordToFind[i] = letter;
                            countLetter++;
                            count++;
                        }
                    }
                else
                {
                    playerLives--;
                    Console.WriteLine($"The letter {givenChar}  doesn't exist.Give another.The player {name} has {playerLives} lives.");
                    LettersTried.Add(letter);
                    foreach (string l in LettersTried)
                        Console.Write(l);
                    WinState();
                }
                if (countLetter != 0)
                {
                    remainingLetters = givenWord.Length - 2 - count;
                    WinState();
                    Console.WriteLine($"The letter {givenChar} was found {countLetter} times.You have to find {remainingLetters} letters");
                    foreach (string s in wordToFind)
                        Console.Write(s);
                    countLetter = 0;
                }
                else
                    WinState();
            }
        }
        /// <summary>
        /// checks if the playes has win or not.
        /// </summary>
        public void WinState()
        {
            if (playerLives == 0)
                Console.WriteLine($"You lost.");
            else if (remainingLetters == 0)
            {
                Console.WriteLine($"You found the word {givenWord} ");
            }
        }
    }
}
