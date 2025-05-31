using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yetikai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> taskList = new List<string>();
            string input = null;

            while(input != "e")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add a task to the list.");
                Console.WriteLine("Enter 2 to remove the task from the list.");
                Console.WriteLine("Enter 3 to view the list.");
                Console.WriteLine("Enter e to exit the list.");
                input = Console.ReadLine();

                if(input == "1")
                {
                    Console.WriteLine("enter the task you want add up");
                    string addTask = Console.ReadLine();
                    taskList.Add(addTask);
                    Console.WriteLine("Added");
                }
                if(input == "2")
                {
                    for(int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i+1 + ": " + taskList[i]);
                    }
                    Console.WriteLine("please enter the number of the task you want to remove");
                    int removeNum = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(removeNum);
                }
                if (input == "3")
                {

                    {
                        for (int i = 0; i < taskList.Count; i++)
                        {
                            Console.WriteLine(i + 1 + ": " + taskList[i]);
                        }
                    }
                }
                if(input == "e")
                {
                    Console.WriteLine("Exited the list");
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
