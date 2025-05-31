using System;

internal class Program
{
    static void Main(string[] args)
    {
        double result = 0;
        bool firstOperation = true;

        while (true)
        {
            double num1, num2;
            if (firstOperation)
            {
                Console.Write("Enter a number: ");
                if(!Double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Please enter numbers only!");
                    continue;
                }
                firstOperation = false;
            }
            else
            {
                num1 = result;
                Console.WriteLine($"Previous total was {result}");
            }
            Console.WriteLine();

            Console.Write("Select an operator from +, -, *, / : ");
            string sign = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter another number: ");
            if(!Double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Please enter numbers only!");
                continue;
            }

            switch(sign)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"The result is {result}");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"The result is {result}");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"The result is {result}");
                    break;
                case "/":
                    if(num2 == 0)
                    {
                        Console.WriteLine("A number divided by zero is undefined.");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"The result is {result}");
                    }
                    break;
                default:
                    throw new Exception("Invalid operator please! use a valid one!");
            }
            Console.WriteLine("Do you want to do further more calculation? y/n");
            string answer = Console.ReadLine();
            if (answer.ToLower().Trim() != "y")
            {
                Console.WriteLine("Calculation ended here. Please press a key!");
                break;
            }
        }
        Console.ReadLine();
    }
}
