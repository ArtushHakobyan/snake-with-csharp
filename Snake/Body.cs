using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Body
    {
        public Vector2D Pos { get; set; }
        public ConsoleColor Color { get; set; }

        public Body(Vector2D p, ConsoleColor color)
        {
            this.Pos = p;
            this.Color = color;
        }

        public Body()
        {
            this.Pos = new Vector2D();
            this.Color = ConsoleColor.White;
        }

        public virtual void Render(bool draw)
        {
            Console.SetCursorPosition(this.Pos.X, this.Pos.Y);
            Console.ForegroundColor = draw ? this.Color : Console.BackgroundColor;
            Console.Write('@');
            Console.ResetColor();
        }
    }
}
