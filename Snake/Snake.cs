using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Snake : Body
    {
        private List<Body> body = new List<Body>();

        public Vector2D Dir;
        public int Score { get; set; }

        public Snake(Vector2D p, Vector2D d, ConsoleColor color):base(p, color)
        {
            this.Dir = d;
        }

        public Snake():base()
        {
            this.Dir = new Vector2D();
        }

        public void AddBody(Body newBody)
        {
            body.Add(newBody);
        }

        public void AddBody()
        {
            body.Add(new Body(body[body.Count-1].Pos, ConsoleColor.White));
        }

        public bool Move()
        {
            ChangeDir();
            for(int i = body.Count - 1; i > 0; i--)
            {
                body[i].Pos = body[i - 1].Pos;
            }
            body[0].Pos = this.Pos;
            this.Pos += this.Dir;

            if (this.Pos.X >= Console.WindowWidth)
                this.Pos.X = 0;
            else if (this.Pos.X < 0)
                this.Pos.X = Console.WindowWidth - 1;
            else if (this.Pos.Y >= Console.WindowHeight)
                this.Pos.Y = 0;
            else if (this.Pos.Y < 0)
                this.Pos.Y = Console.WindowHeight - 1;

            for(int i = 0; i < body.Count; i++)
            {
                if (this.Pos.Equals(body[i].Pos))
                    return false;
            }
            return true;
        }

        public override void Render(bool draw)
        {
            base.Render(draw);
            for(int i = 0; i < body.Count; i++)
            {
                body[i].Render(draw);
            }
        }

        private void ChangeDir()
        {
            switch(Program.Key)
            {
                case ConsoleKey.RightArrow:
                    if(this.Dir.X == 0)
                        this.Dir = new Vector2D(1, 0);
                    break;
                case ConsoleKey.LeftArrow:
                    if (this.Dir.X == 0)
                        this.Dir = new Vector2D(-1, 0);
                    break;
                case ConsoleKey.UpArrow:
                    if (this.Dir.Y == 0)
                        this.Dir = new Vector2D(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    if (this.Dir.Y == 0)
                        this.Dir = new Vector2D(0, 1);
                    break;
            }
        }
    }
}
