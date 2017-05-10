using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public class GameController : ControllerBase
    {
        private GameView gameView;
        private Player player;
        public GameController(GameView view, GameStateChanged onGameStateChange, Player player) : base(view, onGameStateChange)
        {
            gameView = view;
            this.player = player;

        }

        public override void Initialize()
        {
            player.HasActiveGame = true;

            while (true)
            {
                HandleKeyPressed();
            }
        }
        private ConsoleKey HandleKeyPressed()
        {
            var keyInfo = Console.ReadKey(true).Key;

            switch (keyInfo)
            {
                case ConsoleKey.Enter:
                      break;
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    PlayerProcessor.MovePlayer(player, keyInfo);
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    ChangeGameState(GameState.MainMenu);
                    break;
            }

            return keyInfo;
        }
    }
}
