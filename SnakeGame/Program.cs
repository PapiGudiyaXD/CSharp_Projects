using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Program
    {
        //Practise
        public enum Direction
        {
            Left,
            Right,
            Up,
            Down
        }
        public class Measurement
        {
            public int x {  get; set; }
            public int y { get; set; }
            public int X { get { return x; } }
            public int Y { get { return y; } }
            
            public Measurement(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public override bool Equals(object obj)
            {
                if((obj == null) || !GetType().Equals(obj.GetType()))
                {
                    return false;
                }
                Measurement other = (Measurement)obj;
                return x == other.x && y == other.y;
            }
            public void ApplyMovementDirection(Direction direction)
            {
                switch(direction)
                {
                    case Direction.Left:
                        x--;
                        break;
                    case Direction.Right:
                        x++;
                        break;
                    case Direction.Up:
                        y--;
                        break;
                    case Direction.Down: 
                        y++;
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Measurement gridDimension = new Measurement(40, 20);
            Measurement snakePos = new Measurement(10, 1);
            Random rand = new Random();
            Measurement ApplePos = new Measurement(rand.Next(1, gridDimension.X -1 ), rand.Next(1, gridDimension.Y -1));
            int frameDelayMili = 120;
            Direction movementDirection = Direction.Down;
            List<Measurement> snakePosHistory = new List<Measurement>();
            int snakeTailLength = 1;
            int score = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Score: " + score);

                snakePos.ApplyMovementDirection(movementDirection);

                for (int y = 0; y < gridDimension.Y; y++)
                {
                    for (int x = 0; x < gridDimension.X; x++)
                    {
                        Measurement currentCoord = new Measurement(x, y);
                        if (currentCoord.Equals(snakePos) || snakePosHistory.Contains(currentCoord))
                        {
                            Console.Write("■");
                        }
                        else if (ApplePos.Equals(currentCoord))
                        {
                            Console.Write("*");
                        }
                        else if (x == 0 || y == 0 || x == gridDimension.X - 1 || y == gridDimension.Y - 1)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                if(snakePos.Equals(ApplePos))
                {
                    snakeTailLength++;
                    score++;
                    ApplePos = new Measurement(rand.Next(1, gridDimension.X - 1), rand.Next(1, gridDimension.Y - 1));
                }
                else if(snakePos.X == 0 || snakePos.Y == 0 || snakePos.X == gridDimension.X-1 || snakePos.Y == gridDimension.Y -1 || snakePosHistory.Contains(snakePos))
                {
                    score = 0;
                    snakeTailLength = 1;
                    snakePos = new Measurement(10, 1);
                    snakePosHistory.Clear();
                    movementDirection = Direction.Down;
                    continue;
                }

                    snakePosHistory.Add(new Measurement(snakePos.X, snakePos.Y));
                if(snakePosHistory.Count > snakeTailLength)
                {
                    snakePosHistory.RemoveAt(0);
                }
                DateTime time = DateTime.Now;
                while ((DateTime.Now - time).TotalMilliseconds < frameDelayMili)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKey key = Console.ReadKey().Key;
                        switch(key)
                        {
                            case ConsoleKey.LeftArrow:
                                movementDirection = Direction.Left;
                            break;
                                case ConsoleKey.RightArrow:
                                movementDirection = Direction.Right;
                                break;
                            case ConsoleKey.UpArrow:
                                movementDirection = Direction.Up;
                                break;
                            case ConsoleKey.DownArrow:
                                movementDirection = Direction.Down;
                                break;
                        }
                    }
                }
            }
            
        }
    }
}
