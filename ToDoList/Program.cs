using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("==Welcome to the To-Do-List Program==");
            List<string> taskList = new List<string>();
            
            string input = null;

            while (input != "e")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add a task to the list.");
                Console.WriteLine("Enter 2 to remove the task from the list.");
                Console.WriteLine("Enter 3 to view the list.");
                Console.WriteLine("Enter e to exit the list.");

                input = Console.ReadLine();
                if(input == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("Please! Enter the task you want to add up.");
                        string task = Console.ReadLine();
                        taskList.Add(task);
                        Console.WriteLine("The task has been added to the list.");

                        Console.WriteLine("Do you want to add more? y/n");
                        string character = Console.ReadLine().Trim();
                        if(character != "y")
                        {
                            break;
                        }
                    }
                }
                else if (input == "2")
                {
                    Console.WriteLine("PLease! Enter the task you want to remove from the list.");
                    string removeTask = Console.ReadLine();
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i+1 + ":" + taskList[i]);
                    }
                    Console.WriteLine("Enter the number of task you want to remove from the list");
                    int removeNum = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(removeNum - 1);
                    Console.WriteLine("Task finally removeed from the list.");
                }
                else if( input == "3")
                {
                    while(true)
                    {
                        Console.WriteLine("loading up the list");
                        for (int i = 0; i < taskList.Count; i++)
                        {
                            Console.WriteLine(i+1 + ":" + taskList[i]);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press b to go back");
                        string character1 = Console.ReadLine().Trim();
                        if (character1 == "b")
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    
                }
                else if( input == "e")
                {
                    Console.WriteLine("Exited from the list.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please Try again.");
                }
            }
            Console.ReadLine();
     
        }
            
    }
}
