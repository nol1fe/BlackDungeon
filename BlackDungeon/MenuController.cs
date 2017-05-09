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

       

        public MenuController(MenuView view, GameStateChanged onGameStateChange) : base(view, onGameStateChange)
        {
            
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
                    
                    break;
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                   
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:

                    break;
            }

            return keyInfo;
        }
    }
}
