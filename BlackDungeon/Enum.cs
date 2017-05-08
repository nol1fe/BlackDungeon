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
        PlayerFootsteps = 1,
    }
}
