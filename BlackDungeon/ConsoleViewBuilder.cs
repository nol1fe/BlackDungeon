using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public class ConsoleViewBuilder
    {
        public void PrintViewName(string name)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(name);
        }
        public void PrintLine(string line, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(line);
        }

    }
}
