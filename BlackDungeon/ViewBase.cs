using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public abstract class ViewBase
    {
        protected ConsoleViewBuilder viewBuilder;

        public ViewBase()
        {
            viewBuilder = new ConsoleViewBuilder();
        }

        public abstract void Show();

    }
}
