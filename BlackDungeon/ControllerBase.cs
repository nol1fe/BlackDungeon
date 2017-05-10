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
        private bool _isDisposed;

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
        //public void Dispose()
        //{

        //    Dispose(true);

        //    GC.SuppressFinalize(this);

        //}

        //public virtual void Dispose(bool disposing)
        //{
        //    if (_isDisposed)
        //    {
        //        return;
        //    }

        //    Dispose(true);

        //    _isDisposed = true;

        //    GC.SuppressFinalize(this);
        //}
    }
}
