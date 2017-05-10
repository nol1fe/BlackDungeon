using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public class MenuView : ViewBase
    {
        private Player player;
        private Dictionary<GameMenu, string> MenuOptions;
        private GameMenu selectedMenuOption;
        private Point MenuLocation;
        private int positionInMenu;

        public MenuView(Player player)
        {
            this.player = player;
        }
        public override void Show()
        {
            positionInMenu = 0;
            InitItems();
            RedrawMenu();

            //loadingScreen();
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
            if (player.HasActiveGame)
            {
                MenuOptions.Add(GameMenu.Continue, "Continue");
            }
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

        public void loadingScreen() // XDDDDDDDDDDDDDDDDDDDD
        {
            Console.Clear();
            string path = @"C:\Users\nol1fe\Desktop\C#\loader.txt";

            string[] textFromFile = File.ReadAllLines(path);
            var longestItem = textFromFile.OrderByDescending(x => x.Length).FirstOrDefault();
            var itemsInFile = textFromFile.ToList().Count / 2;
            var yCenter = (Console.WindowHeight / 2) - itemsInFile;
            var consoleArgs = new ConsoleViewBuilderArgs()
            {
                X = (Console.WindowWidth - longestItem.Length) / 2,
                BackgroundColor = ConsoleColor.Black,
                Y = yCenter
            };
            foreach (var item in textFromFile)
            {
                viewBuilder.PrintTextCustoArgs(item, consoleArgs);
                consoleArgs.Y++;
            }

            for (var i = 0; i < 47; i++)
            {
                Console.SetCursorPosition(21 + i, 15);        // HEHE, WYLICZANE NA SZTYWNO
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write(MapManager.EMPTY_SIGN);
                Thread.Sleep(30);

            }
            Console.ResetColor();
        }

    }
}
