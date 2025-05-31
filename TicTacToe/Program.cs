using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPlayerOne = true;
            string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int numTurns = 0;

            while (!CheckVictory() && numTurns < 9)
            {
                PrintGrid();

                if (isPlayerOne)
                {
                    Console.WriteLine("Player 1's turn: ");
                }
                else
                {
                    Console.WriteLine("Player 2's turn: ");
                }
                string choice = Console.ReadLine();

                if(grid.Contains(choice) && choice != "X" || choice != "O")
                {
                    int gridIndex = Convert.ToInt32(choice) - 1;
                    if(isPlayerOne)
                    {
                        grid[gridIndex] = "X";
                    }
                    else
                    {
                        grid[gridIndex] = "O";
                    }
                    numTurns++;
                }
                isPlayerOne = !isPlayerOne;
            }
            if (CheckVictory())
            {
                Console.WriteLine("You won");
            }
            else
            {
                Console.WriteLine("Tie");
            }
            void PrintGrid()
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(grid[i * 3 + j] + " | ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("-----------");
                }
            }
            bool CheckVictory()
            {
                bool row1 = grid[0] == grid[1] && grid[1] == grid[2];
                bool row2 = grid[3] == grid[4] && grid[4] == grid[5];
                bool row3 = grid[6] == grid[7] && grid[7] == grid[8];
                bool col1 = grid[0] == grid[3] && grid[3] == grid[6];
                bool col2 = grid[1] == grid[4] && grid[4] == grid[7];
                bool col3 = grid[2] == grid[5] && grid[5] == grid[8];
                bool diag1 = grid[0] == grid[4] && grid[4] == grid[8];
                bool diag2 = grid[2] == grid[4] && grid[4] == grid[6];

                return row1 || col1 || diag1 || diag2 || row2 || col2 || row3 || col3;
            }
            Console.ReadLine();
        }
    }
}
