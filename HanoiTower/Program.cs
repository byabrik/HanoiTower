using System;

namespace HanoiTower
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var game = new Game(3);
            game.StartGame();

            Console.Read();
        }
    }
}