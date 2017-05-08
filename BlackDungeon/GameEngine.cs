using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public class GameEngine
    {
        private Player player;
        
        public GameEngine()
        {
            player = new Player();

            Console.CursorVisible = false;
        }

        public void Start()
        {

            while (true)
            {
                HandleKeyPressed();
                Thread.Sleep(10);
            }

        }

        private ConsoleKey HandleKeyPressed()
        {
            var keyInfo = Console.ReadKey(true).Key;

            switch (keyInfo)
            {
                case ConsoleKey.D:
                case ConsoleKey.A:
                case ConsoleKey.W:
                case ConsoleKey.S:
                    PlayerProcessor.MovePlayer(player, keyInfo);
                    break;

            }

            return keyInfo;
        }
    }
}
