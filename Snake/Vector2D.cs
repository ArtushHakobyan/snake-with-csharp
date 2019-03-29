using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Vector2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector2D(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Vector2D()
        {
            this.X = 0;
            this.Y = 0;
        }

        public override string ToString()
        {
            return "(" + this.X + "," + this.Y + ")";
        }

        public override bool Equals(object obj)
        {
            if (obj is Vector2D)
                return this.ToString() == obj.ToString();
            else
                throw new Exception();
        }

        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector2D operator -(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.X - v2.X, v1.Y - v2.Y);
        }
    }
}
