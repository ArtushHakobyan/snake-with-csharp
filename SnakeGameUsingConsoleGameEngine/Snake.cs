using System;
using System.Collections.Generic;
using System.Text;
using GameEngine;

namespace SnakeGameUsingConsoleGameEngine
{
    public class Snake : GameObject
    {
        public Vector2D Direction = new Vector2D(1, 0);

        public Snake()
        {

        }

        public Snake(int x, int y, char icon, ConsoleColor color, string name):base(x, y, icon, color)
        {
            Name = name;
        }

        public Snake(Vector2D pos, char icon, ConsoleColor color, string name):base(icon, color, pos)
        {
            Name = name;
        }

        public override void Start()
        {
            Pos.X = 6;
            Pos.Y = 6;
        }

        public override void Update()
        {
            Pos += Direction;
        }
    }
}
