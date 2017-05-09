using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public class ConsoleViewBuilderArgs
    {
        public int? X { get; set; }
        public int? Y { get; set; }
        public string Text { get; set; }
        public HorizontalPosition HorizontalPosition { get; set; }
        public VerticalPosition VerticalPosition { get; set; }
        public ConsoleColor ForegroundColor { get; set; }
        public ConsoleColor BackgroundColor { get; set; }
        public ConsoleWriteMode WriteMode { get; set; }

        public ConsoleViewBuilderArgs()
        {
            ForegroundColor = ConsoleColor.Gray;
            BackgroundColor = ConsoleColor.Black;
        }

    }
}
