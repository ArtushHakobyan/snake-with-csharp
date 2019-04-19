using System;
using GameEngine;

namespace SnakeGameUsingConsoleGameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Snake snake = new Snake(0, 0, '@', ConsoleColor.Red, "Player");
            snake.Direction = new Vector2D(0, 1);
            game.Add(snake);
            game.FPS = 10;

            Game.OnRightKey += Game_OnRightKey;
            Game.OnLeftKey += Game_OnLeftKey;
            Game.OnDownKey += Game_OnDownKey;
            Game.OnUpKey += Game_OnUpKey;

            Console.WriteLine("Loading...");
            game.Start();
        }

        private static void Game_OnUpKey(GameObjects gameObjects)
        {
            Snake snake = (Snake)gameObjects["Player"];

            snake.Direction = new Vector2D(0, -1);
        }

        private static void Game_OnDownKey(GameObjects gameObjects)
        {
            Snake snake = (Snake)gameObjects["Player"];

            snake.Direction = new Vector2D(0, 1);
        }

        private static void Game_OnLeftKey(GameObjects gameObjects)
        {
            Snake snake = (Snake)gameObjects["Player"];

            snake.Direction = new Vector2D(-1, 0);
        }

        private static void Game_OnRightKey(GameObjects gameObjects)
        {
            Snake snake = (Snake)gameObjects["Player"];

            snake.Direction = new Vector2D(1, 0);
        }
    }
}
