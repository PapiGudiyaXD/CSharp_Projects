using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StandardCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result, num1;
            while (true)
            {
                Console.Write("Enter a number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Select a operator from + , - , * , / : ");
                string sign = Console.ReadLine();
                Console.Write("Enter another number: ");
                double num = Convert.ToDouble(Console.ReadLine());
                switch (sign)
                {
                    case "+":
                        result = num1 + num;
                        Console.WriteLine($"The sum of the numbers you provided is {result}");
                        break;
                    case "-":
                        result = num1 - num;
                        Console.WriteLine($"The difference of the numbers you provided is {result}");
                        break;
                    case "*":
                        result = num1 * num;
                        Console.WriteLine($"The product of the numbers you provided is {result}");
                        break;
                    case "/":
                        if (num == 0)
                        {
                            Console.WriteLine("A number can't be divided by zero");
                        }
                        else
                        {
                            result = num1 / num;
                            Console.WriteLine($"The division of the numbers you provided is {result}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                Console.WriteLine("Do you want to do further more calculation? y/n");
                string answer = Console.ReadLine();
                if(answer.Trim().ToLower() != "y")
                {
                    Console.WriteLine("The process ended here. Please press a key.");
                    break;
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
