using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public class GameView : ViewBase
    {
        private Player player;
        private MapManager mapManager;

        public GameView(Player player)
        {
            this.player = player;
            mapManager = new MapManager();
        }

        public override void Show()
        {
            player.HasActiveGame = true;
            Console.Clear();
            mapManager.Draw(player);
        }
    }
}
