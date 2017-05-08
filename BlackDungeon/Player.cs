using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public class Player : MapObjectBase
    {
        public Player() 
            : base('x', 0, 0)
        {

        }

        public void MoveLeft()
        {
            if (X > 0)
                X--;
        }
        public void MoveRight()
        {
            X++;
        }
        public void MoveUp()
        {
            if (Y > 0)
                Y--;
        }
        public void MoveDown()
        {
            Y++;
        }
    }
}
