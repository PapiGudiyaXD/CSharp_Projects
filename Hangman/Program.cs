using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool win = false;
            string value = "orthodox";
            int totalLives = 5;
            int remainingLives = totalLives;
            List<char> guessLetter = new List<char>();

            while (remainingLives > 0 && !win)
            {
                foreach (char c in value)
                {
                    if (guessLetter.Contains(c))
                    {
                        Console.Write(c);
                    }
                    else
                    {
                        Console.Write("_");
                    }
                }

                Console.WriteLine($"\n{remainingLives}/{totalLives} lives remaining");

                Console.Write("Please guess a letter: ");
                char guess = Convert.ToChar(Console.ReadLine());

                if (guessLetter.Contains(guess))
                {
                    Console.WriteLine("You already guessed that letter!");
                    continue;
                }

                if (value.Contains(guess))
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                    remainingLives--;
                }
                guessLetter.Add(guess);
             /*   bool wordComplete = true;
                foreach(char c in value)
                {
                    if(!guessLetter.Contains(c))
                    {
                        wordComplete = false;
                    }
                }
                win = wordComplete; */
                win = value.All(c => guessLetter.Contains(c));

            }

            if (win)
            {
                Console.WriteLine($"Congrats! You have completed the game. The word was {value}.");
            }
            else
            {
                Console.WriteLine($"You lost! The word was {value}.");
            }

            Console.ReadLine();
        }
    }
}
