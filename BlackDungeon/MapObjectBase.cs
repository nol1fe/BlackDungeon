using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public abstract class MapObjectBase
    {
        public char Sign { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public MapObjectBase(char sign, int x, int y)
        {
            Sign = sign;
            X = x;
            Y = y;
        }
    }
}
