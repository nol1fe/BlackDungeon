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
            ProcessConsoleViewArgs(new ConsoleViewBuilderArgs()
            {
                HorizontalPosition = HorizontalPosition.Center,
                VerticalPosition = VerticalPosition.Top,
                WriteMode = ConsoleWriteMode.Line,
                Text = name
            });
        }

        public void Print(ConsoleViewBuilderArgs args)
        {
            ProcessConsoleViewArgs(args);
        }

        public void PrintPositioned(string text, HorizontalPosition horizontalPosition, VerticalPosition verticalPosition)
        {
            ProcessConsoleViewArgs(new ConsoleViewBuilderArgs()
            {
                HorizontalPosition = horizontalPosition,
                VerticalPosition = verticalPosition,
                WriteMode = ConsoleWriteMode.Line,
                Text = text
            });
        }

        public void PrintLine(string line, int x, int y)
        {
            ProcessConsoleViewArgs(new ConsoleViewBuilderArgs()
            {
                X = x,
                Y = y,
                WriteMode = ConsoleWriteMode.Line,
                Text = line
            });
        }

        public void PrintCenteredLine(string text, int y)
        {
            ProcessConsoleViewArgs(new ConsoleViewBuilderArgs()
            {
                HorizontalPosition = HorizontalPosition.Center,
                WriteMode = ConsoleWriteMode.Line,
                Y = y,
                Text = text
            });
        }

        private void ProcessConsoleViewArgs(ConsoleViewBuilderArgs args)
        {
            if (args != null)
            {
                var x = 0;
                var y = 0;
                var textLenght = string.IsNullOrEmpty(args.Text) ? 0 : args.Text.Length;

                if (args.X.HasValue)
                {
                    x = args.X.Value;
                }
                else
                {
                    switch (args.HorizontalPosition)
                    {
                        case HorizontalPosition.Center:
                            x = (Console.WindowWidth - textLenght) / 2;
                            break;
                        case HorizontalPosition.Left:
                            x = 0;
                            break;
                        case HorizontalPosition.Right:
                            x = (Console.WindowWidth - textLenght);
                            break;
                    }
                }

                if (args.Y.HasValue)
                {
                    y = args.Y.Value;
                }
                else
                {
                    switch (args.VerticalPosition)
                    {
                        case VerticalPosition.Center:
                            y = Console.WindowHeight / 2;
                            break;
                        case VerticalPosition.Top:
                            y = 0;
                            break;
                        case VerticalPosition.Bottom:
                            y = Console.WindowHeight;
                            break;
                    }
                }

                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = args.ForegroundColor;
                Console.BackgroundColor = args.BackgroundColor;

                if (!string.IsNullOrEmpty(args.Text))
                {
                    switch (args.WriteMode)
                    {
                        case ConsoleWriteMode.Line:
                            Console.WriteLine(args.Text);
                            break;
                        case ConsoleWriteMode.Sign:
                            Console.Write(args.Text);
                            break;
                    }
                }

            }
            else
            {
                //default
                Console.SetCursorPosition(0, 0);
                Console.ResetColor();
            }
        }

    }
}
