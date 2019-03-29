using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Food
    {
        private static Random rd = new Random();

        public Vector2D Pos { get; set; }

        public Food(Vector2D pos)
        {
            this.Pos = pos;
        }

        public Food()
        {
            this.Pos = new Vector2D(rd.Next(0, Console.WindowWidth), rd.Next(0, Console.WindowHeight));
        }

        public void Render(bool draw)
        {
            Console.SetCursorPosition(this.Pos.X, this.Pos.Y);
            Console.ForegroundColor = draw ? ConsoleColor.Yellow : Console.BackgroundColor;
            Console.Write('$');
            Console.ResetColor();
        }
    }
}
