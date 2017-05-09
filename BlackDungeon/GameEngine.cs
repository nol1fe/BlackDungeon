using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public delegate void GameStateChanged(GameState gameState);

    public class GameEngine
    {
        private Player player;

        public GameEngine()
        {
            Console.CursorVisible = false;
            player = new Player();
        }

        public void Start()
        {
            ActivateGameState(GameState.MainMenu);

        }

        private void OnGameStateChange(GameState gameState)
        {
            ActivateGameState(gameState);
        }

        private void ActivateGameState(GameState gameState)
        {
            switch (gameState)
            {
                case GameState.MainMenu:
                    var menuController = new MenuController(new MenuView(), OnGameStateChange);
                    menuController.Initialize();
                    break;
                case GameState.NewGame:
                    /// TODO
                    //var gameController ...
                    break;
                case GameState.Exit:
                    Environment.Exit(0);
                    break;
            }
        }



        //public void Start()
        //{

        //    while (true)
        //    {
        //        HandleKeyPressed();
        //        Thread.Sleep(10);
        //    }

        //}

        //private ConsoleKey HandleKeyPressed()
        //{
        //    var keyInfo = Console.ReadKey(true).Key;

        //    switch (keyInfo)
        //    {
        //        case ConsoleKey.D:
        //        case ConsoleKey.A:
        //        case ConsoleKey.W:
        //        case ConsoleKey.S:
        //            PlayerProcessor.MovePlayer(player, keyInfo);
        //            break;

        //    }

        //    return keyInfo;
        //}
    }
}
