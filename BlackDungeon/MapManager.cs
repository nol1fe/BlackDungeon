using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public class MapManager
    {
        public const char EMPTY_SIGN = '\0';
        
        public void Draw(MapObjectBase mapObject)
        {
            Console.SetCursorPosition(mapObject.X, mapObject.Y);
            Console.Write(mapObject.Sign);
        }

        public void Clear(MapObjectBase mapObject)
        {
            Console.SetCursorPosition(mapObject.X, mapObject.Y);
            Console.Write(EMPTY_SIGN);
        }
    }
}
