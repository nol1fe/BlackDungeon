using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public static class PlayerProcessor
    {
        private static MapManager mapManager = new MapManager();
        private static SoundManager playerSoundManager = new SoundManager();
        private static ContentManager playerContentManager = new ContentManager(ResourceType.PlayerFootsteps);
        private static bool isPlayerMoving = false;

        public static void MovePlayer(Player player, ConsoleKey keyInfo)
        {
            if (!isPlayerMoving)
            {
                isPlayerMoving = true;
                playerSoundManager.PlaySound(playerContentManager.GetNextResourcePath(), onSoundComplete);

                mapManager.Clear(player);

                switch (keyInfo)
                {
                    case ConsoleKey.D:
                        player.MoveRight();
                        break;
                    case ConsoleKey.A:
                        player.MoveLeft();

                        break;
                    case ConsoleKey.W:
                        player.MoveUp();

                        break;
                    case ConsoleKey.S:
                        player.MoveDown();
                        break;
                }

                mapManager.Draw(player);
            }

        }

        private static void onSoundComplete(object sender, EventArgs e)
        {
            isPlayerMoving = false;
        }


    }
}
