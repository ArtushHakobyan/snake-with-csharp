using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SnakeGame
{
    class Program
    {
        public static ConsoleKey Key;

        static void Main(string[] args)
        {
            Snake snake = new Snake(new Vector2D(5, 5), new Vector2D(1, 0), ConsoleColor.Red);
            snake.AddBody(new Body(new Vector2D(4, 5), ConsoleColor.White));
            snake.AddBody(new Body(new Vector2D(3, 5), ConsoleColor.White));
            Food food = new Food(new Vector2D(10, 5));
            Thread cfk = new Thread(CheckForKeys);
            cfk.IsBackground = true;
                        
            do
            {
                snake = new Snake(new Vector2D(5, 5), new Vector2D(1, 0), ConsoleColor.Red);
                snake.AddBody(new Body(new Vector2D(4, 5), ConsoleColor.White));
                snake.AddBody(new Body(new Vector2D(3, 5), ConsoleColor.White));
                Console.Clear();
                Console.Write("Enter Difficulty(1-3): ");
                int dif = int.Parse(Console.ReadLine());
                Console.Clear();
                Game game = new Game(snake, dif, food);

                if (!cfk.IsAlive)
                    cfk.Start();
                game.Start();

                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth/2 - 5, Console.WindowHeight/2-2);
                Console.WriteLine("Score: " + snake.Score);
                Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2);
                Console.WriteLine("GAME OVER : Press Enter To Play Again");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }

        static void CheckForKeys()
        {
            while(true)
            {
                Key = Console.ReadKey().Key;                
            }
        }
    }
}
