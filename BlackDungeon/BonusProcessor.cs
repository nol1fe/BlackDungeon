using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    class BonusProcessor
    {
        public int bonusX { get; set; }
        public int bonusY { get; set; }

        bool isBonusSpawned = false;

        public void HandlePlayerMovement()
        {

            ConsoleKeyInfo keyInfo;

            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.D:
                        Console.Clear();
                        if (isBonusSpawned) ShowBonus();
                        break;
                    case ConsoleKey.A:
                        Console.Clear();
                        if (isBonusSpawned) ShowBonus();
                        break;
                    case ConsoleKey.W:
                        Console.Clear();
                        if (isBonusSpawned) ShowBonus();
                        Console.Write("x");
                        break;
                    case ConsoleKey.S:
                        Console.Clear();
                        if (isBonusSpawned) ShowBonus();
                        break;
                    case ConsoleKey.Enter:
                        SpawnedBonusPosition();
                        break;

                }

            }
        }

        public void ShowBonus()
        {
            Console.SetCursorPosition(bonusX, bonusY);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("O");
            Console.ResetColor();
        }

        public void SpawnedBonusPosition()
        {
            var random = new Random();
            var distanceX = 0;
            var distanceY = 0;

            //do
            //{
            //    distanceX = random.Next(-10, 10);
            //    distanceY = random.Next(-10, 10);
            //}
            //while (!isGreaterThenZero(positionX, positionY, distanceX, distanceY));
            //isBonusSpawned = true;

            //bonusX = positionX + distanceX;
            //bonusY = positionY + distanceY;

        }

        //public bool isGreaterThenZero(int playerPositionX, int playerPositionY, int distX, int distY)
        //{
        //    var x = playerPositionX + distX;
        //    var y = playerPositionY + distX;

        //    if (x > 0 && y > 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
