using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public class MenuView : ViewBase
    {
        private Dictionary<GameMenu, string> MenuOptions;
        private GameMenu selectedMenuOption;
        private Point MenuLocation;
        private int positionInMenu;

        public override void Show()
        {
            positionInMenu = 0;
            InitItems();
            RedrawMenu();
        }

        public GameMenu GetSelectedMenuPosition()
        {
            return selectedMenuOption;
        }

        public void SelectNext()
        {
            positionInMenu++;
            if (positionInMenu > MenuOptions.Count - 1)
            {
                positionInMenu = 0;
            }

            RedrawMenu();
        }

        public void SelectPrevious()
        {
            positionInMenu--;
            if (positionInMenu < 0)
            {
                positionInMenu = MenuOptions.Count - 1;
            }

            RedrawMenu();
        }

        private void InitItems()
        {
            MenuLocation = new Point(Console.WindowWidth/2, 3);
            MenuOptions = new Dictionary<GameMenu, string>();
            MenuOptions.Add(GameMenu.NewGame, "New Game");
            MenuOptions.Add(GameMenu.Exit, "Exit");
        }
        private void RedrawMenu()
        {
            var selected = MenuOptions.ElementAt(positionInMenu);
            selectedMenuOption = selected.Key;

            PrintMenu();

            viewBuilder.Print(new ConsoleViewBuilderArgs()
            {
                HorizontalPosition = HorizontalPosition.Center,
                ForegroundColor = ConsoleColor.White,
                BackgroundColor = ConsoleColor.Black,
                Text = selected.Value,
                Y = MenuLocation.Y + positionInMenu,
            });
        }

        private void PrintMenu()
        {
            viewBuilder.PrintViewName("Menu");

            var y = MenuLocation.Y;
            foreach (var item in MenuOptions)
            {
                viewBuilder.Print(new ConsoleViewBuilderArgs() {
                    HorizontalPosition = HorizontalPosition.Center,
                    ForegroundColor = ConsoleColor.Gray,
                    BackgroundColor = ConsoleColor.Black,
                    Text = item.Value,
                    Y = y++,
                });
            }
        }

    }
}
