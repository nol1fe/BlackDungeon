using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public abstract class ControllerBase
    {
        protected event GameStateChanged OnGameStateChange;
        protected ViewBase View;

        public ControllerBase(ViewBase view, GameStateChanged onGameStateChange)
        {
            View = view;
            OnGameStateChange = onGameStateChange;

            View.Show();
        }

        protected void ChangeGameState(GameState gameState)
        {
            OnGameStateChange(gameState);
        }

        public abstract void Initialize();
    }
}
