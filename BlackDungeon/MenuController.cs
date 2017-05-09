using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public class MenuController : ControllerBase
    {
        private MenuView menuView;
        public MenuController(MenuView view, GameStateChanged onGameStateChange) : base(view, onGameStateChange)
        {
            menuView = view;
        }

        public override void Initialize()
        {
           
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
                    var selectedMenu = menuView.GetSelectedMenuPosition();
                    switch (selectedMenu)
                    {
                        case GameMenu.NewGame:
                            ChangeGameState(GameState.NewGame);
                            break;
                        case GameMenu.Exit:
                            ChangeGameState(GameState.Exit);
                            break;
                    }
                    break;
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    menuView.SelectPrevious();
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    menuView.SelectNext();
                    break;
            }

            return keyInfo;
        }

    }
}
