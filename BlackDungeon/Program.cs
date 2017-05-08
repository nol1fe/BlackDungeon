using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameEngine = new GameEngine();

            gameEngine.Start();

            Console.ReadKey();
        }
    }
}
