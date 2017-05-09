using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public class MenuView : ViewBase
    {
        public Dictionary<GameMenu, string> Items;

        public override void Show()
        {
            InitItems();
            var x = 0;
            var y = 3;
            foreach (var item in Items)
            {
                viewBuilder.PrintViewName("Menu");
                viewBuilder.PrintLine(item.Value, x, y++);

            }
            
        }

        private void InitItems()
        {
            Items = new Dictionary<GameMenu, string>();
            Items.Add(GameMenu.NewGame, "New Game");
            Items.Add(GameMenu.Exit, "Exit");
        }
    }
}
