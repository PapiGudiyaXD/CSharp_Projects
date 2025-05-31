using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yetikai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxLives = 5;
            int remainingLives = maxLives;
            List<char> guessLetter = new List<char>();
            bool win = false;
            string value = "apple";

            while(remainingLives > 0 && !win)
            {
                foreach(char c in value)
                {
                    if(!guessLetter.Contains(c))
                    {
                        Console.Write("_");
                    }
                    else
                    {
                        Console.Write(c);
                    }
                }
                Console.WriteLine($"\n{remainingLives}/{maxLives} lives remaining.");
                Console.Write("Enter a letter: ");
                char guess = Convert.ToChar(Console.ReadLine());
                if(value.Contains(guess))
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                    remainingLives--;
                }
                guessLetter.Add(guess);
                bool wordComplete = true;
                foreach (char c in value)
                {
                    if (!guessLetter.Contains(c))
                    {
                        wordComplete = false;
                    }
                }
                win = wordComplete;
            }
            if (win)
            {
                Console.WriteLine("Congrats you have completed");
            }
            else
            {
                Console.WriteLine("You lost");
            }
            Console.ReadKey();

        }
    }
}
