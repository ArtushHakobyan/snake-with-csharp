using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SnakeGame
{
    public class Game
    {
        private static Random rd = new Random();

        private int difficulty;

        private int Difficulty
        {
            set
            {
                if (value > 0 && value < 4)
                    difficulty = value;
                else
                    difficulty = 1;
            }
            get
            {
                return difficulty;
            }
        }
        private Snake snake;
        private Food food;

        public Game(Snake snk, int dif, Food f)
        {
            this.snake = snk;
            this.Difficulty = dif;
            this.food = f;
        }

        public void Render(bool draw)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("Score: " + snake.Score);
            snake.Render(draw);
            food.Render(draw);
        }

        public void Start()
        {
            do
            {
                this.Render(true);
                Thread.Sleep(300/difficulty);
                this.Render(false);
                if (snake.Pos.Equals(food.Pos))
                {
                    food.Pos = new Vector2D(rd.Next(0, Console.WindowWidth), rd.Next(0, Console.WindowHeight));
                    snake.AddBody();
                    snake.Score++;
                }
            } while (snake.Move());
        }
    }
}
