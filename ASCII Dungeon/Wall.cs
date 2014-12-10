using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    public class Wall : GameObject
    {
        public override char ObjectAppearance
        {
            get { return '█'; }
        }

        public Wall(int x, int y) : base(x,y) { }
    }
}
