using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public enum MediaState : int
    {
        Stopped = 1,
        Paused = 2,
        Playing = 3,
        ScanForward = 4,
        ScanReverse = 5,
        Buffering = 6,
        Waiting = 7,
        MediaEnded = 8,
        Transitioning = 9,
        Ready = 10,
        Reconnecting = 11,
        Last = 12

    }

    public enum ResourceType : int
    {
        PlayerFootsteps = 0,
    }

    public enum GameState : int
    {
        MainMenu = 0,
        NewGame = 1,
        Exit = 2
    }

    public enum GameMenu : int
    {
        NewGame = 0,
        Exit = 1
    }

    public enum HorizontalPosition : byte
    {
        Default = 0,
        Left = 1,
        Center = 2,
        Right = 3,
    }

    public enum VerticalPosition : byte
    {
        Default = 0,
        Top = 1,
        Center = 2,
        Bottom = 3,
    }

    public enum ConsoleWriteMode : byte
    {
        Line = 0,
        Sign = 1,
    }
}
